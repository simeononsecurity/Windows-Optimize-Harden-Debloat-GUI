using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Windows_Optimize_Harden_Debloat;

public sealed record ScriptOption(string Name, string Description);
public sealed record ScriptSchema(string Hash, ScriptOption[] Options);
public sealed record RunResult(int ExitCode, bool Cancelled, string Output, string Error);

public static class ScriptExecution
{
    public static string BuildCommand(string path, ScriptSchema schema, ISet<string> selected)
    {
        if (schema.Options.Length == 0 || !Regex.IsMatch(schema.Hash, "^[A-Fa-f0-9]{64}$"))
            throw new ArgumentException("Invalid script schema.");
        var names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var option in schema.Options)
            if (!Regex.IsMatch(option.Name, "^[A-Za-z_][A-Za-z0-9_]*$") || !names.Add(option.Name))
                throw new ArgumentException("Invalid or duplicate option.");
        if (selected.Count == 0 || selected.Any(name => !names.Contains(name)))
            throw new ArgumentException("Select at least one supported option.");
        string literal = "'" + Path.GetFullPath(path).Replace("'", "''") + "'";
        string arguments = string.Join(" ", schema.Options.Select(option =>
            $"-{option.Name} ${(selected.Contains(option.Name) ? "true" : "false")}"));
        // Every parameter is explicit, including unchecked options whose script defaults might be true.
        return $"$ErrorActionPreference='Stop'; if ((Get-FileHash -LiteralPath {literal} -Algorithm SHA256).Hash -ne '{schema.Hash}') {{ throw 'Script changed. Reload its options.' }}; & {literal} {arguments}";
    }

    public static ProcessStartInfo PowerShellCommand(string command)
    {
        var info = new ProcessStartInfo("powershell.exe");
        foreach (string argument in new[] { "-NoLogo", "-NoProfile", "-NonInteractive", "-ExecutionPolicy", "Bypass", "-EncodedCommand", Convert.ToBase64String(Encoding.Unicode.GetBytes(command)) })
            info.ArgumentList.Add(argument);
        return info;
    }

    public static async Task<RunResult> RunAsync(ProcessStartInfo info, CancellationToken cancellation,
        Action<string>? stdout = null, Action<string>? stderr = null)
    {
        cancellation.ThrowIfCancellationRequested();
        info.UseShellExecute = false;
        info.CreateNoWindow = true;
        info.RedirectStandardOutput = true;
        info.RedirectStandardError = true;
        using var process = new Process { StartInfo = info };
        process.Start();
        var output = new StringBuilder();
        var errors = new StringBuilder();
        static async Task DrainAsync(StreamReader stream, StringBuilder buffer, Action<string>? callback)
        {
            var chars = new char[2048];
            int count;
            while ((count = await stream.ReadAsync(chars)) != 0)
            {
                string chunk = new(chars, 0, count);
                buffer.Append(chunk);
                callback?.Invoke(chunk);
            }
        }
        Task outTask = DrainAsync(process.StandardOutput, output, stdout);
        Task errTask = DrainAsync(process.StandardError, errors, stderr);
        bool cancelled = false;
        try { await process.WaitForExitAsync(cancellation); }
        catch (OperationCanceledException)
        {
            cancelled = true;
            try { if (!process.HasExited) process.Kill(entireProcessTree: true); }
            catch (InvalidOperationException) { /* Process exited between the check and kill. */ }
            catch (System.ComponentModel.Win32Exception error)
            {
                // Retain ownership and keep the UI busy if Windows rejects termination.
                stderr?.Invoke("Unable to terminate the process: " + error.Message + " Waiting for exit.\n");
            }
            await process.WaitForExitAsync();
        }
        await Task.WhenAll(outTask, errTask);
        return new RunResult(process.ExitCode, cancelled, output.ToString(), errors.ToString());
    }
}
