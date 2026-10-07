#Requires -Version 5.1
param([Parameter(Mandatory)][string]$ScriptPath)
$ErrorActionPreference = 'Stop'
try {
    $tokens = $null
    $errors = $null
    $ast = [System.Management.Automation.Language.Parser]::ParseFile($ScriptPath, [ref]$tokens, [ref]$errors)
    if ($errors.Count) { throw ($errors | Out-String) }
    if (-not $ast.ParamBlock) { throw 'The script must declare a parameter block.' }
    $options = @()
    foreach ($parameter in $ast.ParamBlock.Parameters) {
        if ($parameter.StaticType -ne [bool]) { throw "Unsupported parameter type: $($parameter.Name.VariablePath.UserPath)" }
        $description = $parameter.Name.VariablePath.UserPath
        foreach ($attribute in $parameter.Attributes) {
            if ($attribute -is [System.Management.Automation.Language.AttributeAst]) {
                foreach ($argument in $attribute.NamedArguments) {
                    if ($argument.ArgumentName -eq 'HelpMessage' -and $argument.Argument -is [System.Management.Automation.Language.StringConstantExpressionAst]) {
                        $description = $argument.Argument.Value
                    }
                }
            }
        }
        $options += @{ Name = $parameter.Name.VariablePath.UserPath; Description = $description }
    }
    if (-not $options.Count) { throw 'No Boolean options found.' }
    @{ Hash = (Get-FileHash -LiteralPath $ScriptPath -Algorithm SHA256).Hash; Options = $options } | ConvertTo-Json -Depth 5 -Compress
} catch {
    Write-Error $_ -ErrorAction Continue
    exit 1
}
