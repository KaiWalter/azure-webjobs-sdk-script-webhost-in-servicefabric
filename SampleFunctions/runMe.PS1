
$env:AzureWebJobsScriptRoot = $PSScriptRoot
$env:AzureWebJobsStorage = "UseDevelopmentStorage=true"

gci env:Azure*

Push-Location

Set-Location "C:\src\azure-webjobs-sdk-script\src\WebJobs.Script.WebHost\bin\Debug\netcoreapp2.0\publish"

dotnet Microsoft.Azure.WebJobs.Script.WebHost.dll

Pop-Location