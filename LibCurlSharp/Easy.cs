using System.Runtime.InteropServices;

namespace LibCurlSharp;

public static class Easy
{
    public static SafeCurlHandle Initialize()
    {
        var curlHandle = CurlNative.curl_easy_init();
        return new SafeCurlHandle(curlHandle);
    }

    public static CurlStatus SetOpt<TValue>(this SafeCurlHandle handle, CurlOpt<TValue> option, TValue value)
    {
        var curl = handle.GetUnsafeHandle();
        return value switch
        {
            string stringValue => CurlNative.curl_easy_setopt(curl, option.optionValue, stringValue),
            bool boolValue => CurlNative.curl_easy_setopt(curl, option.optionValue, boolValue ? 1 : 0),
            int intValue => CurlNative.curl_easy_setopt(curl, option.optionValue, intValue),
            IntPtr handleValue => CurlNative.curl_easy_setopt(curl, option.optionValue, handleValue),
            SafeCurlHandle curlHandleValue => CurlNative.curl_easy_setopt(curl, option.optionValue, curl),
            CurlOpt.ReadWriteCallbackDelegate delegateValue => CurlNative.curl_easy_setopt(curl, option.optionValue, Marshal.GetFunctionPointerForDelegate(delegateValue)),
            _ => throw new Exception($"Unsupported option: {option}")
        };
    }

    public static CurlStatus Perform(this SafeCurlHandle handle)
    {
        return CurlNative.curl_easy_perform(handle.GetUnsafeHandle());
    }
}