using System.Runtime.InteropServices;

namespace LibCurlSharp;

public static class CurlNative
{
    private const string NativeLibrary = "libcurl-x64.dll";

    [DllImport(NativeLibrary)]
    public static extern IntPtr curl_easy_init();

    [DllImport(NativeLibrary)]
    public static extern CurlStatus curl_easy_setopt(IntPtr curl, int option, string value);

    [DllImport(NativeLibrary)]
    public static extern CurlStatus curl_easy_setopt(IntPtr curl, int option, int value);

    [DllImport(NativeLibrary)]
    public static extern CurlStatus curl_easy_setopt(IntPtr curl, int option, IntPtr value);

    [DllImport(NativeLibrary)]
    public static extern CurlStatus curl_easy_perform(IntPtr curl);
}