namespace LibCurlSharp;

public class CurlOpt<TValue> : CurlOpt
{
    public CurlOpt(int optionValue) : base(optionValue)
    {
    }
}

public class CurlOpt
{
    public delegate UIntPtr ReadWriteCallbackDelegate(IntPtr ptr, UIntPtr size, UIntPtr nmemb, IntPtr userdata);
    
    public readonly int optionValue;

    public CurlOpt(int optionValue)
    {
        this.optionValue = optionValue;
    }

    // public static readonly CurlOpt<string> Url = new(10002);
    // public static readonly CurlOpt<ushort> Port = new(3);
    // public static readonly CurlOpt<int> Timeout = new(13);
    // public static readonly CurlOpt<bool> Post = new(47);

    public static readonly CurlOpt<bool> Verbose = new(41);
    public static readonly CurlOpt<bool> Header = new(42);
    public static readonly CurlOpt<bool> NoProgress = new(43);
    public static readonly CurlOpt<bool> NoSignal = new(99);

    public static readonly CurlOpt<bool> WildcardMatch = new(197);

    public static readonly CurlOpt<ReadWriteCallbackDelegate> WriteFunction = new (20011);
    public static readonly CurlOpt<IntPtr> WriteData = new (10001);
    public static readonly CurlOpt<ReadWriteCallbackDelegate> ReadFunction = new (20012);
    public static readonly CurlOpt<IntPtr> ReadData = new (10009);
    // public static readonly CurlOpt<TODO> IoctlFunction = new (20130); // [ioctl_callback ] - Deprecated option Callback for I/O operations. See CURLOPT_IOCTLFUNCTION
    public static readonly CurlOpt<IntPtr> IoctlData = new (10131);
    // public static readonly CurlOpt<TODO> SeekFunction = new (20167); // [seek_callback ] - Callback for seek operations. See CURLOPT_SEEKFUNCTION
    public static readonly CurlOpt<IntPtr> SeekData = new (10168);
    // public static readonly CurlOpt<TODO> SockOptFunction = new (20148); // [sockopt_callback ] - Callback for sockopt operations. See CURLOPT_SOCKOPTFUNCTION
    public static readonly CurlOpt<IntPtr> SockOptData = new (10149);
    // public static readonly CurlOpt<TODO> OpenSocketFunction = new (20163); // [opensocket_callback ] - Callback for socket creation. See CURLOPT_OPENSOCKETFUNCTION
    public static readonly CurlOpt<IntPtr> OpenSocketData = new (10164);
    // public static readonly CurlOpt<TODO> CloseSocketFunction = new (20208); // [closesocket_callback ] - Callback for closing socket. See CURLOPT_CLOSESOCKETFUNCTION
    public static readonly CurlOpt<IntPtr> CloseSocketData = new (10209);
    // public static readonly CurlOpt<TODO> ProgressFunction = new (20056); // [progress_callback ] - OBSOLETE callback for progress meter. See CURLOPT_PROGRESSFUNCTION
    public static readonly CurlOpt<IntPtr> ProgressData = new (10057);
    // public static readonly CurlOpt<TODO> XferInfoFunction = new (20219); // [progress_callback ] - Callback for progress meter. See CURLOPT_XFERINFOFUNCTION
    // public static readonly CurlOpt<TODO> HeaderFunction = new (20079); // [header_callback ] - Callback for writing received headers. See CURLOPT_HEADERFUNCTION
    public static readonly CurlOpt<IntPtr> HeaderData = new (10029);
    // public static readonly CurlOpt<TODO> DebugFunction = new (20094); // [debug_callback ] - Callback for debug information. See CURLOPT_DEBUGFUNCTION
    public static readonly CurlOpt<IntPtr> DebugData = new (10095);
    // public static readonly CurlOpt<TODO> SslCtxFunction = new (20108); // [ssl_ctx_callback ] - Callback for SSL context logic. See CURLOPT_SSL_CTX_FUNCTION
    public static readonly CurlOpt<IntPtr> SslCtxData = new (10109);
    // public static readonly CurlOpt<TODO> ConvToNetworkFunction = new (20143); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_TO_NETWORK_FUNCTION
    // public static readonly CurlOpt<TODO> ConvFromNetworkFunction = new (20142); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_FROM_NETWORK_FUNCTION
    // public static readonly CurlOpt<TODO> ConvFromUtf8Function = new (20144); // [conv_callback ] - OBSOLETE Callback for code base conversion. See CURLOPT_CONV_FROM_UTF8_FUNCTION
    // public static readonly CurlOpt<TODO> InterleaveFunction = new (20196); // [interleave_callback ] - Callback for RTSP interleaved data. See CURLOPT_INTERLEAVEFUNCTION
    public static readonly CurlOpt<IntPtr> InterleaveData = new (10195);
    // public static readonly CurlOpt<TODO> ChunkBgnFunction = new (20198); // [chunk_bgn_callback ] - Callback for wildcard download start of chunk. See CURLOPT_CHUNK_BGN_FUNCTION
    // public static readonly CurlOpt<TODO> ChunkEndFunction = new (20199); // [chunk_end_callback ] - Callback for wildcard download end of chunk. See CURLOPT_CHUNK_END_FUNCTION
    public static readonly CurlOpt<IntPtr> ChunkData = new (10201);
    // public static readonly CurlOpt<TODO> FnmatchFunction = new (20200); // [fnmatch_callback ] - Callback for wildcard matching. See CURLOPT_FNMATCH_FUNCTION
    public static readonly CurlOpt<IntPtr> FnmatchData = new (10202);
    public static readonly CurlOpt<bool> SuppressConnectHeaders = new(265);

    // public static readonly CurlOpt<TODO> ResolverStartFunction = new (20272); // [resolver_start_cb ] - Callback to be called before a new resolve request is started. See CURLOPT_RESOLVER_START_FUNCTION
    // public static readonly CurlOpt<TODO> ResolverStartData = new (10273); // [void *pointer] - Data pointer to pass to resolver start callback. See CURLOPT_RESOLVER_START_DATA
    // public static readonly CurlOpt<TODO> ErrorBuffer = new (10010); // [char *buf] - Error message buffer. See CURLOPT_ERRORBUFFER
    // public static readonly CurlOpt<TODO> Stderr = new (10037); // [FILE *stream] - stderr replacement stream. See CURLOPT_STDERR
    public static readonly CurlOpt<bool> FailOnError = new(45);
    public static readonly CurlOpt<bool> KeepSendingOnError = new(245);
    public static readonly CurlOpt<string> Url = new(10002);
    public static readonly CurlOpt<bool> PathAsIs = new(234);

    // public static readonly CurlOpt<TODO> Protocols = new (181); // [long bitmask ] - Deprecated option Allowed protocols. See CURLOPT_PROTOCOLS
    // public static readonly CurlOpt<TODO> RedirectProtocols = new (182); // [long bitmask ] - Deprecated option Protocols to allow redirects to. See CURLOPT_REDIR_PROTOCOLS
    public static readonly CurlOpt<string> DefaultProtocol = new(10238);
    public static readonly CurlOpt<string> Proxy = new(10004);
    public static readonly CurlOpt<string> PreProxy = new(10262);
    public static readonly CurlOpt<int> ProxyPort = new(59);

    // public static readonly CurlOpt<TODO> ProxyType = new (101); // [long type ] - Proxy type. See CURLOPT_PROXYTYPE
    public static readonly CurlOpt<string> NoProxy = new(10177);
    public static readonly CurlOpt<bool> HttpProxyTunnel = new(61);

    // public static readonly CurlOpt<TODO> ConnectTo = new (10243); // [struct curl_slist *connect_to] - Connect to a specific host and port. See CURLOPT_CONNECT_TO
    // public static readonly CurlOpt<TODO> Socks5Auth = new (267); // [long bitmask ] - Socks5 authentication methods. See CURLOPT_SOCKS5_AUTH
    public static readonly CurlOpt<string> Socks5GssapiService = new(10179);

    // public static readonly CurlOpt<TODO> Socks5GssapiNec = new (180); // [long nec ] - Socks5 GSSAPI NEC mode. See CURLOPT_SOCKS5_GSSAPI_NEC
    public static readonly CurlOpt<string> ProxyServiceName = new(10235);
    public static readonly CurlOpt<bool> HaProxyProtocol = new(274);
    public static readonly CurlOpt<string> ServiceName = new(10236);
    public static readonly CurlOpt<string> Interface = new(10062);

    public static readonly CurlOpt<int> LocalPort = new(139);

    // public static readonly CurlOpt<TODO> LocalPortRange = new (140); // [long range ] - Bind connection locally to port range. See CURLOPT_LOCALPORTRANGE
    // public static readonly CurlOpt<TODO> DnsCacheTimeout = new (92); // [long age ] - Timeout for DNS cache. See CURLOPT_DNS_CACHE_TIMEOUT
    public static readonly CurlOpt<bool> DnsUseGlobalCache = new(91);
    public static readonly CurlOpt<string> DohUrl = new(10279);
    public static readonly CurlOpt<int> BufferSize = new(98);
    public static readonly CurlOpt<int> Port = new(3);
    public static readonly CurlOpt<bool> TcpFastOpen = new(244);
    public static readonly CurlOpt<bool> TcpNoDelay = new(121);
    public static readonly CurlOpt<int> AddressScope = new(171);
    public static readonly CurlOpt<bool> TcpKeepalive = new(213);
    public static readonly CurlOpt<int> TcpKeepIdle = new(214);
    public static readonly CurlOpt<int> TcpKeepInterval = new(215);
    public static readonly CurlOpt<string> UnixSocketPath = new(10231);
    public static readonly CurlOpt<string> AbstractUnixSocket = new(10264);

    // public static readonly CurlOpt<TODO> Netrc = new (51); // [long level ] - Enable .netrc parsing. See CURLOPT_NETRC
    public static readonly CurlOpt<string> NetrcFile = new(10118);
    public static readonly CurlOpt<string> UserPassword = new(10005);
    public static readonly CurlOpt<string> ProxyUserPassword = new(10006);
    public static readonly CurlOpt<string> Username = new(10173);
    public static readonly CurlOpt<string> Password = new(10174);
    public static readonly CurlOpt<string> LoginOptions = new(10224);
    public static readonly CurlOpt<bool> ProxyUsername = new(10175);
    public static readonly CurlOpt<bool> ProxyPassword = new(10176);

    // public static readonly CurlOpt<TODO> Httpauth = new (107); // [long bitmask ] - HTTP server authentication methods. See CURLOPT_HTTPAUTH
    public static readonly CurlOpt<string> TlsAuthUsername = new(10204);
    public static readonly CurlOpt<string> ProxyTlsAuthUsername = new(10251);
    public static readonly CurlOpt<string> TlsAuthPassword = new(10205);
    public static readonly CurlOpt<string> ProxyTlsAuthPassword = new(10252);
    public static readonly CurlOpt<string> TlsAuthType = new(10206);
    public static readonly CurlOpt<string> ProxyTlsAuthType = new(10253);

    // public static readonly CurlOpt<TODO> Proxyauth = new (111); // [long bitmask ] - HTTP proxy authentication methods. See CURLOPT_PROXYAUTH
    public static readonly CurlOpt<string> SaslAuthorized = new(10289);
    public static readonly CurlOpt<bool> SaslIr = new(218);
    public static readonly CurlOpt<string> XOAuth2Bearer = new(10220);

    // public static readonly CurlOpt<TODO> DisallowUsernameInUrl = new (278); // [long disallow ] - Do not allow username in URL. See CURLOPT_DISALLOW_USERNAME_IN_URL
    // public static readonly CurlOpt<TODO> Autoreferer = new (58); // [long autorefer ] - Automatically set Referer: header. See CURLOPT_AUTOREFERER
    public static readonly CurlOpt<string> AcceptEncoding = new(10102);
    public static readonly CurlOpt<bool> TransferEncoding = new(207);
    public static readonly CurlOpt<bool> FollowLocation = new(52);
    public static readonly CurlOpt<bool> UnrestrictedAuth = new(105);
    public static readonly CurlOpt<int> MaxRedirects = new(68);

    // public static readonly CurlOpt<TODO> Postredir = new (161); // [long bitmask ] - How to act on redirects after POST. See CURLOPT_POSTREDIR
    public static readonly CurlOpt<bool> Put = new(54);
    public static readonly CurlOpt<bool> Post = new(47);

    // public static readonly CurlOpt<TODO> Postfields = new (10015); // [char *postdata] - Send a POST with this data. See CURLOPT_POSTFIELDS
    public static readonly CurlOpt<int> PostFieldSize = new(60);

    public static readonly CurlOpt<long> PostFieldSizeLarge = new(30120);

    // public static readonly CurlOpt<TODO> Copypostfields = new (10165); // [char *data] - Send a POST with this data - and copy it. See CURLOPT_COPYPOSTFIELDS
    // public static readonly CurlOpt<TODO> Httppost = new (10024); // [struct curl_httppost *formpost] - Deprecated option Multipart formpost HTTP POST. See CURLOPT_HTTPPOST
    public static readonly CurlOpt<string> Referer = new(10016);
    public static readonly CurlOpt<string> Useragent = new(10018);

    // public static readonly CurlOpt<TODO> Httpheader = new (10023); // [struct curl_slist *headers] - Custom HTTP headers. See CURLOPT_HTTPHEADER
    // public static readonly CurlOpt<TODO> Headeropt = new (229); // [long bitmask ] - Control custom headers. See CURLOPT_HEADEROPT
    // public static readonly CurlOpt<TODO> Proxyheader = new (10228); // [struct curl_slist *headers] - Custom HTTP headers sent to proxy. See CURLOPT_PROXYHEADER
    // public static readonly CurlOpt<TODO> Http200Aliases = new (10104); // [struct curl_slist *aliases] - Alternative versions of 200 OK. See CURLOPT_HTTP200ALIASES
    public static readonly CurlOpt<string> Cookie = new(10022);
    public static readonly CurlOpt<string> CookieFile = new(10031);
    public static readonly CurlOpt<string> Cookiejar = new(10082);

    // public static readonly CurlOpt<TODO> Cookiesession = new (96); // [long init ] - Start a new cookie session. See CURLOPT_COOKIESESSION
    public static readonly CurlOpt<string> CookieList = new(10135);

    public static readonly CurlOpt<string> Altsvc = new(10287);

    // public static readonly CurlOpt<TODO> AltsvcCtrl = new (286); // [long bitmask ] - Enable and configure Alt-Svc: treatment. See CURLOPT_ALTSVC_CTRL
    public static readonly CurlOpt<bool> HttpGet = new(80);

    // public static readonly CurlOpt<TODO> RequestTarget = new (10266); // [string ] - Set the request target. CURLOPT_REQUEST_TARGET
    // public static readonly CurlOpt<TODO> HttpVersion = new (84); // [long version ] - HTTP version to use. CURLOPT_HTTP_VERSION
    // public static readonly CurlOpt<TODO> Http09Allowed = new (285); // [long allowed ] - Allow HTTP/0.9 responses. CURLOPT_HTTP09_ALLOWED
    // public static readonly CurlOpt<TODO> IgnoreContentLength = new (136); // [long ignore ] - Ignore Content-Length. See CURLOPT_IGNORE_CONTENT_LENGTH
    public static readonly CurlOpt<bool> HttpContentDecoding = new(158);

    public static readonly CurlOpt<bool> HttpTransferDecoding = new(157);

    public static readonly CurlOpt<int> Expect100TimeoutMs = new(227);

    // public static readonly CurlOpt<TODO> TrailerFunction = new (20283); // [curl_trailer_callback *func] - Set callback for sending trailing headers. See CURLOPT_TRAILERFUNCTION
    // public static readonly CurlOpt<TODO> TrailerData = new (10284); // [void *userdata] - Custom pointer passed to the trailing headers callback. See CURLOPT_TRAILERDATA
    public static readonly CurlOpt<bool> PipeWait = new(237);
    public static readonly CurlOpt<SafeCurlHandle> StreamDepends = new(10240);
    public static readonly CurlOpt<SafeCurlHandle> StreamDependsE = new(10241);
    public static readonly CurlOpt<int> StreamWeight = new(239);
    public static readonly CurlOpt<string> MailFrom = new(10186);

    // public static readonly CurlOpt<TODO> MailRcpt = new (10187); // [struct curl_slist *rcpts] - Address of the recipients. See CURLOPT_MAIL_RCPT
    public static readonly CurlOpt<string> MailAuth = new(10217);
    public static readonly CurlOpt<bool> MailRcptAllowFails = new(290);
    public static readonly CurlOpt<int> TftpBlkSize = new(178);
    public static readonly CurlOpt<bool> TftpNoOptions = new(242);
    public static readonly CurlOpt<string> FtpPort = new(10017);

    // public static readonly CurlOpt<TODO> Quote = new (10028); // [struct curl_slist *cmds] - Commands to run before transfer. See CURLOPT_QUOTE
    // public static readonly CurlOpt<TODO> Postquote = new (10039); // [struct curl_slist *cmds] - Commands to run after transfer. See CURLOPT_POSTQUOTE
    // public static readonly CurlOpt<TODO> Prequote = new (10093); // [struct curl_slist *cmds] - Commands to run just before transfer. See CURLOPT_PREQUOTE
    public static readonly CurlOpt<bool> Append = new(50);
    public static readonly CurlOpt<bool> FtpUseEprt = new(106);
    public static readonly CurlOpt<bool> FtpUseEpsv = new(85);
    public static readonly CurlOpt<bool> FtpUsePret = new(188);

    // public static readonly CurlOpt<TODO> FtpCreateMissingDirs = new (110); // [long create ] - Create missing directories on the remote server. See CURLOPT_FTP_CREATE_MISSING_DIRS
    public static readonly CurlOpt<string> FtpAlternativeToUser = new(10147);

    public static readonly CurlOpt<bool> FtpSkipPasvIp = new(137);

    // public static readonly CurlOpt<TODO> FtpSslAuth = new (129); // [long order ] - Control how to do TLS. See CURLOPT_FTPSSLAUTH
    // public static readonly CurlOpt<TODO> FtpSslCcc = new (154); // [long how ] - Back to non-TLS again after authentication. See CURLOPT_FTP_SSL_CCC
    public static readonly CurlOpt<string> FtpAccount = new(10134);

    // public static readonly CurlOpt<TODO> FtpFileMethod = new (138); // [long method ] - Specify how to reach files. See CURLOPT_FTP_FILEMETHOD
    // public static readonly CurlOpt<TODO> RtspRequest = new (189); // [long request ] - RTSP request. See CURLOPT_RTSP_REQUEST
    public static readonly CurlOpt<string> RtspSessionId = new(10190);
    public static readonly CurlOpt<string> RtspStreamUri = new(10191);
    public static readonly CurlOpt<string> RtspTransport = new(10192);
    public static readonly CurlOpt<int> RtspClientCSeq = new(193);
    public static readonly CurlOpt<int> RtspServerCSeq = new(194);
    public static readonly CurlOpt<bool> TransferText = new(53);
    public static readonly CurlOpt<bool> ProxyTransferMode = new(166);
    public static readonly CurlOpt<bool> Crlf = new(27);
    public static readonly CurlOpt<string> Range = new(10007);
    public static readonly CurlOpt<int> ResumeFrom = new(21);
    public static readonly CurlOpt<long> ResumeFromLarge = new(30116);

    // public static readonly CurlOpt<TODO> Curlu = new (10282); // [void *pointer] - Set URL to work on with a URL handle. See CURLOPT_CURLU
    public static readonly CurlOpt<string> CustomRequest = new(10036);
    public static readonly CurlOpt<bool> FileTime = new(69);
    public static readonly CurlOpt<bool> DirListOnly = new(48);
    public static readonly CurlOpt<bool> Nobody = new(44);
    public static readonly CurlOpt<int> InfileSize = new(14);
    public static readonly CurlOpt<long> InFileSizeLarge = new(30115);
    public static readonly CurlOpt<bool> Upload = new(46);

    public static readonly CurlOpt<int> UploadBufferSize = new(280);

    // public static readonly CurlOpt<TODO> MimePost = new (10269); // [mime ] - Post/send MIME data. See CURLOPT_MIMEPOST
    public static readonly CurlOpt<int> MaxFileSize = new(114);

    public static readonly CurlOpt<long> MaxFileSizeLarge = new(30117);

    // public static readonly CurlOpt<TODO> Timecondition = new (33); // [long cond ] - Make a time conditional request. See CURLOPT_TIMECONDITION
    public static readonly CurlOpt<int> TimeValue = new(34);
    public static readonly CurlOpt<long> TimeValueLarge = new(30270);
    public static readonly CurlOpt<int> Timeout = new(13);
    public static readonly CurlOpt<int> TimeoutMs = new(155);
    public static readonly CurlOpt<int> LowSpeedLimit = new(19);
    public static readonly CurlOpt<int> LowSpeedTime = new(20);
    public static readonly CurlOpt<long> MaxSendSpeedLarge = new(30145);
    public static readonly CurlOpt<long> MaxReceiveSpeedLarge = new(30146);
    public static readonly CurlOpt<int> MaxConnects = new(71);
    public static readonly CurlOpt<bool> FreshConnect = new(74);
    public static readonly CurlOpt<bool> ForbidReuse = new(75);
    public static readonly CurlOpt<int> MaxAgeConn = new(288);
    public static readonly CurlOpt<int> ConnectTimeout = new(78);
    public static readonly CurlOpt<int> ConnectTimeoutMs = new(156);

    // public static readonly CurlOpt<TODO> Ipresolve = new (113); // [long resolve ] - IP version to use. See CURLOPT_IPRESOLVE
    public static readonly CurlOpt<bool> ConnectOnly = new(141);
    public static readonly CurlOpt<bool> UseSsl = new(119);

    // public static readonly CurlOpt<TODO> Resolve = new (10203); // [struct curl_slist *hosts] - Provide fixed/fake name resolves. See CURLOPT_RESOLVE
    public static readonly CurlOpt<string> DnsInterface = new(10221);
    public static readonly CurlOpt<string> DnsLocalIp4 = new(10222);
    public static readonly CurlOpt<string> DnsLocalIp6 = new(10223);
    public static readonly CurlOpt<string> DnsServers = new(10211);

    public static readonly CurlOpt<bool> DnsShuffleAddresses = new(275);

    public static readonly CurlOpt<int> AcceptTimeoutMs = new (212);
    public static readonly CurlOpt<int> HappyEyeballsTimeoutMs = new (271);
    public static readonly CurlOpt<int> UpkeepIntervalMs = new (281);
    public static readonly CurlOpt<string> SslCCert = new(10025);
    public static readonly CurlOpt<string> ProxySslCert = new(10254);
    public static readonly CurlOpt<string> SslCertType = new(10086);
    public static readonly CurlOpt<string> ProxySslCertType = new(10255);
    public static readonly CurlOpt<string> SslKey = new(10087);
    public static readonly CurlOpt<string> ProxySslKey = new(10256);
    public static readonly CurlOpt<string> SslKeyType = new(10088);
    public static readonly CurlOpt<string> ProxySslKeyType = new(10257);
    public static readonly CurlOpt<string> KeyPasswd = new(10026);
    public static readonly CurlOpt<string> ProxyKeyPasswd = new(10258);
    public static readonly CurlOpt<bool> SslEnableAlpn = new(226);
    public static readonly CurlOpt<bool> SslEnableNpn = new(225);
    public static readonly CurlOpt<string> SslEngine = new(10089);
    public static readonly CurlOpt<bool> SslEngineDefault = new(90);
    public static readonly CurlOpt<bool> SslFalseStart = new(233);

    // public static readonly CurlOpt<TODO> Sslversion = new (32); // [long version ] - SSL version to use. See CURLOPT_SSLVERSION
    // public static readonly CurlOpt<TODO> ProxySslversion = new (250); // [long version ] - Proxy SSL version to use. See CURLOPT_PROXY_SSLVERSION
    public static readonly CurlOpt<bool> SslVerifyHost = new(81);
    public static readonly CurlOpt<bool> ProxySslVerifyHost = new(249);
    public static readonly CurlOpt<bool> SslVerifyPeer = new(64);
    public static readonly CurlOpt<bool> ProxySslVerifyPeer = new(248);
    public static readonly CurlOpt<bool> SslVerifyStatus = new(232);
    public static readonly CurlOpt<string> CaInfo = new(10065);
    public static readonly CurlOpt<string> ProxyCaInfo = new(10246);
    public static readonly CurlOpt<string> IssuerCert = new(10170);
    public static readonly CurlOpt<string> Capath = new(10097);
    public static readonly CurlOpt<string> ProxyCapath = new(10247);
    public static readonly CurlOpt<string> CrlFile = new(10169);
    public static readonly CurlOpt<string> ProxyCrlFile = new(10260);
    public static readonly CurlOpt<bool> CertInfo = new(172);
    public static readonly CurlOpt<string> PinnedPublicKey = new(10230);
    public static readonly CurlOpt<string> ProxyPinnedPublicKey = new(10263);
    public static readonly CurlOpt<string> RandomFile = new(10076);
    public static readonly CurlOpt<string> EgdSocket = new(10077);
    public static readonly CurlOpt<string> SslCipherList = new(10083);
    public static readonly CurlOpt<string> ProxySslCipherList = new(10259);
    public static readonly CurlOpt<string> Tls13Ciphers = new(10276);
    public static readonly CurlOpt<string> ProxyTls13Ciphers = new(10277);
    public static readonly CurlOpt<bool> SslSessionIdCache = new(150);

    // public static readonly CurlOpt<TODO> SslOptions = new (216); // [long bitmask ] - Control SSL behavior. See CURLOPT_SSL_OPTIONS
    // public static readonly CurlOpt<TODO> ProxySslOptions = new (261); // [long bitmask ] - Control proxy SSL behavior. See CURLOPT_PROXY_SSL_OPTIONS
    public static readonly CurlOpt<string> KrbLevel = new(10063);

    // public static readonly CurlOpt<TODO> GssapiDelegation = new (210); // [long level ] - Disable GSS-API delegation. See CURLOPT_GSSAPI_DELEGATION
    // public static readonly CurlOpt<TODO> SshAuthTypes = new (151); // [long bitmask ] - SSH authentication types. See CURLOPT_SSH_AUTH_TYPES
    public static readonly CurlOpt<bool> SshCompression = new(268);
    public static readonly CurlOpt<string> SshHostPublicKeyMd5 = new(10162);
    public static readonly CurlOpt<string> SshPublicKeyfile = new(10152);
    public static readonly CurlOpt<string> SshPrivateKeyfile = new(10153);

    public static readonly CurlOpt<string> SshKnownHosts = new(10183);
    // public static readonly CurlOpt<TODO> SshKeyFunction = new (20184); // [ssh_keycallback ] - Callback for known hosts handling. See CURLOPT_SSH_KEYFUNCTION
    // public static readonly CurlOpt<TODO> SshKeyData = new (10185); // [void *pointer] - Custom pointer to pass to ssh key callback. See CURLOPT_SSH_KEYDATA
    // public static readonly CurlOpt<TODO> Private = new (10103); // [void *pointer] - Private pointer to store. See CURLOPT_PRIVATE
    // public static readonly CurlOpt<TODO> Share = new (10100); // [CURLSH *share] - Share object to use. See CURLOPT_SHARE
    // public static readonly CurlOpt<TODO> NewFilePerms = new (159); // [long mode ] - Mode for creating new remote files. See CURLOPT_NEW_FILE_PERMS
    // public static readonly CurlOpt<TODO> NewDirectoryPerms = new (160); // [long mode ] - Mode for creating new remote directories. See CURLOPT_NEW_DIRECTORY_PERMS
    // public static readonly CurlOpt<TODO> Telnetoptions = new (10070); // [struct curl_slist *cmds] - TELNET options. See CURLOPT_TELNETOPTIONS
}