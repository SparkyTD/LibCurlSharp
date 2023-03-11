using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using LibCurlSharp;


var curl = Easy.Initialize();
curl.SetOpt(CurlOpt.Url, "http://eth0.me");
curl.SetOpt(CurlOpt.WriteData, 123);
curl.SetOpt(CurlOpt.WriteFunction, (ptr, size, nMemB, userdata) =>
{
    var realSize = (int)(size * nMemB);
    var buffer = new byte[realSize];
    Marshal.Copy(ptr, buffer, 0, realSize);
    return UIntPtr.Zero;
});
Console.Out.WriteLine(curl.Perform());