using System.Runtime.InteropServices;

namespace AOTNativeDLL;

public class Class1
{
    [UnmanagedCallersOnly(EntryPoint = "generate_code")]
    public static int GenerateCode() {
        try {

            Console.WriteLine("[DLL.GenerateCodeAsync] Starting");
            using var client = new HttpClient();
            Console.WriteLine("[DLL.GenerateCodeAsync] Client created");

            var response = client.GetAsync("https://api.zippopotam.us/us/33162").Result;
            Console.WriteLine($"[DLL.GenerateCodeAsync] Response received: {response.StatusCode}");

            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"[DLL.GenerateCodeAsync] Response Content: {content}");
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString());
            return -1;
        }
        return 0;
    }

    // NOTE: Change this exported name to anything other than "free" (such as "release") and it will work
    // Also change the entry point in the ImportDLL class in the console app
    [UnmanagedCallersOnly(EntryPoint = "free")]
    public static void ReleaseMem (IntPtr ptr) {

    }
}
