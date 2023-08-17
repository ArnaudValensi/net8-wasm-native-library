namespace NativeLibraryWasm;

public class Class1
{
    [System.Runtime.InteropServices.UnmanagedCallersOnly(EntryPoint = "Answer")]
    public static int Answer()
    {
        return 42;
    }
}
