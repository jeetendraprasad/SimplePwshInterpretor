
ECHO 'Y' | Install-PackageProvider -Name NuGet -Scope CurrentUser
ECHO 'Y' | Install-Package Microsoft.PowerShell.SDK -Version 7.0.6 -Type Module -Scope CurrentUser
dotnet publish -c Release -r win10-x64   --self-contained True