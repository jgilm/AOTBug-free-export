// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine($"Hello, World! {Environment.CurrentDirectory}");


var dllPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, ImportDLL.DllLocation));
Console.WriteLine($"DLL location: {dllPath}");
if (!File.Exists(dllPath)) {
    Console.WriteLine($"DLL does not exist at: {dllPath} does not exist");
}

Console.WriteLine("Before call to GenerateCode");
int returncode = ImportDLL.GenerateCode();
Console.WriteLine($"Return code from GenerateCode: {returncode}");


public static class ImportDLL
{
    public const string DllLocation = ".\\..\\..\\..\\..\\AOTNativeDLL\\bin\\Release\\net8.0\\win-x64\\publish\\AOTNativeDLL.dll";

    [DllImport(DllLocation, EntryPoint = "generate_code")]
    public static extern int GenerateCode();

    // NOTE: Change the entry point when the dll entry point name is changed
    [DllImport(DllLocation, EntryPoint = "free")]
    public static extern IntPtr ReleaseMem(IntPtr pointer);
}

