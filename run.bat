 cd AOTNativeDLL
 dotnet publish /p:NativeLib=Shared -c Release 
 cd ..\ConsoleApp
 dotnet build 
 cd bin\Debug\net8.0
 ConsoleApp.exe
