using System.Diagnostics;
using Windows_Optimize_Harden_Debloat;

if (args.Length > 0 && args[0] == "--child")
{
    await Task.Delay(3000);
    await File.WriteAllTextAsync(args[1], "child survived");
    return;
}
if (args.Length > 0 && args[0] == "--parent")
{
    var child = new ProcessStartInfo(Environment.ProcessPath!);
    child.ArgumentList.Add("--child"); child.ArgumentList.Add(args[1]);
    Process.Start(child);
    Console.WriteLine("child started");
    await Task.Delay(30000);
    return;
}

static void Assert(bool condition, string message) { if (!condition) throw new Exception(message); }
var schema = new ScriptSchema(new string('a', 64), new[] { new ScriptOption("First", "First"), new ScriptOption("Second", "Second") });
string command = ScriptExecution.BuildCommand("script with ' quote.ps1", schema, new HashSet<string> { "First" });
Assert(command.Contains("-First $true -Second $false"), "Unchecked options must override script defaults");
Assert(command.Contains("'' quote.ps1"), "PowerShell literal quoting");
bool rejected = false;
try { ScriptExecution.BuildCommand("a.ps1", schema, new HashSet<string>()); } catch (ArgumentException) { rejected = true; }
Assert(rejected, "Empty selection must fail");
rejected = false;
try { ScriptExecution.BuildCommand("a.ps1", schema, new HashSet<string>{"Unknown"}); } catch (ArgumentException) { rejected = true; }
Assert(rejected, "Unknown option must fail");
ProcessStartInfo Shell(string body)
{
    var info = new ProcessStartInfo(OperatingSystem.IsWindows() ? "powershell.exe" : "/bin/sh");
    if (OperatingSystem.IsWindows()) { info.ArgumentList.Add("-NoProfile"); info.ArgumentList.Add("-Command"); }
    else info.ArgumentList.Add("-c");
    info.ArgumentList.Add(body);
    return info;
}
var failure = await ScriptExecution.RunAsync(Shell(OperatingSystem.IsWindows() ? "[Console]::Out.WriteLine('out'); [Console]::Error.WriteLine('err'); exit 7" : "echo out; echo err >&2; exit 7"), CancellationToken.None);
Assert(failure.ExitCode == 7 && failure.Output.Contains("out") && failure.Error.Contains("err"), "Output/error/exit code lost");
using var cancel = new CancellationTokenSource(TimeSpan.FromSeconds(1));
var timer = Stopwatch.StartNew();
var stopped = await ScriptExecution.RunAsync(Shell(OperatingSystem.IsWindows() ? "Start-Sleep 30" : "sleep 30"), cancel.Token);
Assert(stopped.Cancelled && timer.Elapsed < TimeSpan.FromSeconds(10), "Cancellation did not terminate process tree");
string sentinel = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".txt");
using var treeCancel = new CancellationTokenSource();
var parent = new ProcessStartInfo(Environment.ProcessPath!);
parent.ArgumentList.Add("--parent"); parent.ArgumentList.Add(sentinel);
var tree = await ScriptExecution.RunAsync(parent, treeCancel.Token, text => { if (text.Contains("child started")) treeCancel.Cancel(); });
await Task.Delay(4000);
Assert(tree.Cancelled && !File.Exists(sentinel), "Cancellation left a child process running");
Console.WriteLine("PASS: argument/schema validation, explicit flags, output, errors, exit status and process cancellation");
