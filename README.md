# azure-webjobs-sdk-script-webhost-in-servicefabric
Hosting the .NET Core 2 WebJobs Script host in Service Fabric as Guest Executable

## prerequisites
- `azure-webjobs-sdk-script` repository is cloned to the same parent folder (as this repository)
- in `azure-webjobs-sdk-script`
```
  git checkout core-oop
  cd src\WebJobs.Script.WebHost
  dotnet restore
  dotnet build
  dotnet publish -f netcoreapp2.0 -r win10-x64
```

