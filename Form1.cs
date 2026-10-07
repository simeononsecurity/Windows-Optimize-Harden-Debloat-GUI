using System.Diagnostics;
using System.Text.Json;

namespace Windows_Optimize_Harden_Debloat;

public partial class Form1 : Form
{
    private ScriptSchema? schema;
    private string? scriptPath;
    private CancellationTokenSource? running;

    public Form1() { InitializeComponent(); }

    private async void SelectScript_Click(object? sender, EventArgs e)
    {
        using var picker = new OpenFileDialog { Filter = "PowerShell scripts (*.ps1)|*.ps1", Title = "Select the extracted hardening script" };
        if (picker.ShowDialog(this) != DialogResult.OK) return;
        execute.Enabled = false;
        selectScript.Enabled = false;
        schema = null;
        optionPanel.Controls.Clear();
        running = new CancellationTokenSource();
        try
        {
            var info = new ProcessStartInfo("powershell.exe");
            foreach (var arg in new[] { "-NoProfile", "-NonInteractive", "-ExecutionPolicy", "Bypass", "-File", Path.Combine(AppContext.BaseDirectory, "Read-ScriptOptions.ps1"), "-ScriptPath", picker.FileName })
                info.ArgumentList.Add(arg);
            RunResult result = await ScriptExecution.RunAsync(info, running.Token);
            if (result.ExitCode != 0) throw new InvalidOperationException(result.Error);
            schema = JsonSerializer.Deserialize<ScriptSchema>(result.Output, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? throw new InvalidOperationException("No script options found.");
            scriptPath = picker.FileName;
            scriptLabel.Text = scriptPath;
            foreach (var option in schema.Options)
                optionPanel.Controls.Add(new CheckBox { Text = option.Description, Tag = option.Name, AutoSize = true, Checked = false, MaximumSize = new Size(840, 0) });
            execute.Enabled = true;
        }
        catch (Exception error) { MessageBox.Show(this, error.Message, "Script inspection failed"); }
        finally { running.Dispose(); running = null; selectScript.Enabled = true; }
    }

    private async void Execute_Click(object? sender, EventArgs e)
    {
        if (schema is null || scriptPath is null || running is not null) return;
        try
        {
            var selected = optionPanel.Controls.OfType<CheckBox>().Where(box => box.Checked)
                .Select(box => (string)box.Tag!).ToHashSet(StringComparer.OrdinalIgnoreCase);
            string command = ScriptExecution.BuildCommand(scriptPath, schema, selected);
            string preview = "Selected changes:\n\n" + string.Join("\n", schema.Options.Where(option => selected.Contains(option.Name)).Select(option => option.Description))
                + "\n\nAll unchecked options will be disabled. Stopping interrupts execution and does not undo completed changes. Continue?";
            if (MessageBox.Show(this, preview, "Review changes", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            output.Clear();
            running = new CancellationTokenSource();
            execute.Enabled = selectScript.Enabled = optionPanel.Enabled = false;
            stop.Enabled = true;
            var progress = new Progress<string>(text => { if (!IsDisposed) output.AppendText(text); });
            var info = ScriptExecution.PowerShellCommand(command);
            info.WorkingDirectory = Path.GetDirectoryName(scriptPath)!;
            var result = await ScriptExecution.RunAsync(info, running.Token,
                text => ((IProgress<string>)progress).Report(text),
                text => ((IProgress<string>)progress).Report("[stderr] " + text));
            output.AppendText(result.Cancelled ? "\nProcess stopped. Completed changes remain.\n" : $"\nProcess exited with code {result.ExitCode}. Review output and verify system settings.\n");
        }
        catch (Exception error) { MessageBox.Show(this, error.Message, "Execution error"); }
        finally
        {
            running?.Dispose(); running = null;
            execute.Enabled = selectScript.Enabled = optionPanel.Enabled = true;
            stop.Enabled = false;
        }
    }

    private void Stop_Click(object? sender, EventArgs e)
    {
        if (running is null) return;
        running.Cancel();
        stop.Enabled = false;
        output.AppendText("\nStopping the process tree...\n");
    }

    private void ClosingForm(object? sender, FormClosingEventArgs e)
    {
        if (running is null) return;
        e.Cancel = true;
        MessageBox.Show(this, "Wait for script inspection or stop the running process before closing.");
    }
}
