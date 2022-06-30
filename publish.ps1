
Find-PackageProvider -Name NuGet | Install-PackageProvider -Force -Scope CurrentUser
#Install-PackageProvider -Name NuGet -Type Module -Scope CurrentUser -Force
Register-PackageSource -Name nuget.org -Location https://www.nuget.org/api/v2 -ProviderName NuGet
Write-Host "Package sources are"
Get-PackageSource
Write-Host "Package sources ends"
#Install-Package Microsoft.PowerShell.SDK -Scope CurrentUser -SkipDependencies
#powershell -NoProfile -ExecutionPolicy unrestricted -Command "[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; &([scriptblock]::Create((Invoke-WebRequest -UseBasicParsing 'https://dot.net/v1/dotnet-install.ps1'))) -InstallDir ."
#Install-Package Microsoft.PowerShell.SDK -Version 7.0.6 -Type Module -Scope CurrentUser
dotnet publish -c Release -r win10-x64   --self-contained True