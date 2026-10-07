# Windows Optimize Harden Debloat GUI

A Windows interface for inspecting and running a local copy of the [hardening script](https://github.com/simeononsecurity/Windows-Optimize-Harden-Debloat).

## Requirements

- Windows with Windows PowerShell 5.1.
- .NET 10 Desktop Runtime, or build a self-contained Windows release.
- Administrator privileges, requested through the application manifest.
- An extracted hardening-script release with its companion files.

## Use

1. Select the local `sos-optimize-windows.ps1` file.
2. Review options loaded from its parameter definitions. Script inspection parses the PowerShell syntax tree without executing the selected script.
3. Select the required changes. Every option starts unchecked.
4. Choose **Preview and run**, review the selected descriptions, then confirm.
5. Review output, error output, and the process exit code. Verify effective Windows settings separately.

Every Boolean parameter is passed explicitly, including unchecked options. This prevents true defaults in the underlying script from enabling omitted options. Scripts with non-Boolean parameters are rejected. A hash check requires reloading options if the script changes after inspection.

The GUI does not download or silently replace the selected script. Review its origin and version before use. The preview shows selected categories, not an exact registry or policy diff. Recovery depends on the underlying script and your system backup.

## Stop behavior

**Stop process** terminates the PowerShell process and its process tree, drains output, and waits for exit before enabling another run. Completed configuration changes remain. Stopping is not rollback. Detached services or scheduled tasks created by the underlying script are outside the process tree.

Closing the window during inspection or execution is blocked until the operation ends. UI updates stay on the UI thread. Standard output and standard error are read concurrently.

## Build and tests

```powershell
dotnet build Windows-Optimize-Harden-Debloat.csproj
dotnet run --project tests/Regression.csproj
powershell -NoProfile -File tests/SchemaRegression.ps1
```

CI builds on Windows with .NET 10 and runs argument, schema, output, exit-code, and process-tree cancellation tests. The process tests use harmless child processes. They never execute a hardening script. A native GUI acceptance pass should select a fixture script, confirm unchecked defaults, inspect the preview, run, stop, and close before testing a real script in a disposable VM.
