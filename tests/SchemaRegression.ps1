$ErrorActionPreference = 'Stop'
$root = Join-Path ([IO.Path]::GetTempPath()) ([guid]::NewGuid().ToString())
$null = New-Item -ItemType Directory $root
try {
    $fixture = Join-Path $root 'fixture.ps1'
    $sentinel = Join-Path $root 'executed.txt'
    $literal = $sentinel.Replace("'", "''")
    @"
param([Parameter(HelpMessage='First option')][bool]`$First = `$true, [bool]`$Second = `$true)
Set-Content -LiteralPath '$literal' -Value 'must never execute'
"@ | Set-Content -LiteralPath $fixture
    $helper = Join-Path $PSScriptRoot '../Read-ScriptOptions.ps1'
    $hostExe = (Get-Process -Id $PID).Path
    $result = & $hostExe -NoProfile -File $helper -ScriptPath $fixture
    if ($LASTEXITCODE -ne 0) { throw 'Schema inspection failed.' }
    $schema = $result | ConvertFrom-Json
    if ($schema.Options.Count -ne 2 -or $schema.Options[0].Description -ne 'First option') { throw 'Wrong schema.' }
    if (Test-Path $sentinel) { throw 'Inspection executed the script.' }
    if ($schema.Hash -ne (Get-FileHash $fixture -Algorithm SHA256).Hash) { throw 'Wrong source hash.' }
    'param([string]$Unsupported)' | Set-Content -LiteralPath $fixture
    # Use a process so a deliberate helper failure does not terminate this test host.
    $info = New-Object Diagnostics.ProcessStartInfo
    $info.FileName = $hostExe
    $info.Arguments = '-NoProfile -File "' + $helper + '" -ScriptPath "' + $fixture + '"'
    $info.UseShellExecute = $false
    $info.RedirectStandardError = $true
    $process = [Diagnostics.Process]::Start($info)
    $null = $process.StandardError.ReadToEnd()
    $process.WaitForExit()
    if ($process.ExitCode -eq 0) { throw 'Unsupported schema was accepted.' }
    $process.Dispose()
    Write-Output 'PASS: AST metadata, hash binding, no execution and unsupported schema rejection'
} finally { Remove-Item -LiteralPath $root -Recurse -Force }
