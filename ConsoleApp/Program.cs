using System.Runtime.InteropServices;

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

