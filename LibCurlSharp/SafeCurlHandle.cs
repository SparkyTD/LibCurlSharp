namespace LibCurlSharp;

public class SafeCurlHandle : IDisposable
{
    private readonly IntPtr handle;

    public SafeCurlHandle(IntPtr handle)
    {
        this.handle = handle;
    }

    public IntPtr GetUnsafeHandle() => handle;

    public void Dispose()
    {
    }
}