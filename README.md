# SimplePwshInterpretor
Simple interpretor based on powershell core (for now 7)


PUBLISH
-------

Unfortunately due to open bug https://github.com/PowerShell/PowerShell/issues/13540, this cannot be with parameter "-p:PublishSingleFile=True". So the publish commands are:-

(win64 portable)
dotnet publish -c Release -r win-x64   --self-contained True

(for linux)
dotnet publish -c Release -r linux-x64 --self-contained True