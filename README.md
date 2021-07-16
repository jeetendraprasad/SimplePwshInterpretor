DESCRIPTION
-----------

Simple interpretor based on powershell core (for now 7)



PUBLISH
-------

Unfortunately due to open bug https://github.com/PowerShell/PowerShell/issues/13540, this cannot be with parameter "-p:PublishSingleFile=True". So the publish commands are:-

(win10 64bit portable)
dotnet publish -c Release -r win10-x64   --self-contained True

(for linux)
dotnet publish -c Release -r linux-x64 --self-contained True



Acknowledgements
----------------
Some code of this software is taken from
1> https://github.com/BrunoVT1992/ConsoleTable (I may change that in future, but for now its suiting my simple purpose)