﻿namespace SimpleDnsCrypt.Config
{
    /// <summary>
    ///     Global Easy DNSCrypt configuration.
    /// </summary>
    public static class Global
    {
        /// <summary>
        ///     The name of this application.
        /// </summary>
        public const string ApplicationName = "Simple DNSCrypt";

        /// <summary>
        ///     URL to the dnscrypt-resolvers.csv (hosted on github).
        /// </summary>
        public const string ResolverUrl =
            "https://raw.githubusercontent.com/jedisct1/dnscrypt-proxy/master/dnscrypt-resolvers.csv";

        /// <summary>
        ///     URL to the minisign signature, to verify the downloaded dnscrypt-resolvers.csv (hosted on github).
        /// </summary>
        public const string SignatureUrl =
            "https://raw.githubusercontent.com/jedisct1/dnscrypt-proxy/master/dnscrypt-resolvers.csv.minisig";

        /// <summary>
        ///     Minisign public key, to verify the dnscrypt-resolvers.csv.
        /// </summary>
        public const string PublicKey = "RWQf6LRCGA9i53mlYecO4IzT51TGPpvWucNSCh1CBM0QTaLn73Y7GFO3";

        /// <summary>
        ///     Local address the primary resolver will listen on.
        /// </summary>
        public const string PrimaryResolverAddress = "127.0.0.1";

        /// <summary>
        ///     Local address the secondary resolver will listen on.
        /// </summary>
        public const string SecondaryResolverAddress = "127.0.0.2";

        /// <summary>
        ///     Address for the global gateway.
        /// </summary>
        public const string GlobalGatewayAddress = "0.0.0.0";

        /// <summary>
        ///     Local port the primary resolver will listen on.
        /// </summary>
        public const int PrimaryResolverPort = 53;

        /// <summary>
        ///     Local port the secondary resolver will listen on.
        /// </summary>
        public const int SecondaryResolverPort = 53;

        /// <summary>
        ///     The name of the primary windows service.
        /// </summary>
        public const string PrimaryResolverServiceName = "dnscrypt-proxy";

        /// <summary>
        ///     The name of the secondary windows service.
        /// </summary>
        public const string SecondaryResolverServiceName = "dnscrypt-proxy-secondary";

        /// <summary>
        ///     The folder where the dnscrypt-proxy lives in.
        /// </summary>
        public const string DnsCryptProxyFolder = "dnscrypt-proxy";

        /// <summary>
        ///     The name of the resolver file.
        /// </summary>
        public const string DnsCryptProxyResolverListName = "dnscrypt-resolvers.csv";

        /// <summary>
        ///     The name of the resolver signature file.
        /// </summary>
        public const string DnsCryptProxySignatureFileName = "dnscrypt-resolvers.csv.minisig";

        /// <summary>
        ///     The name of the dnscrypt-proxy executable.
        /// </summary>
        public const string DnsCryptProxyExecutableName = "dnscrypt-proxy.exe";

        /// <summary>
        ///     The default pimary resolver, if no resolver is set (on start up)
        /// </summary>
        public const string PrimaryBackupResolverName = "dnsmachine.net-de";

        /// <summary>
        ///     The backup primary resolver, if PrimaryBackupResolverName is not in the list.
        /// </summary>
        public const string SecondaryBackupResolverName = "dnscrypt.org-fr";

        /// <summary>
        ///     Time we wait on a service restart (ms).
        /// </summary>
        public const int ServiceRestartTime = 5000;

        /// <summary>
        ///     Time we wait on a service start (ms).
        /// </summary>
        public const int ServiceStartTime = 2500;

        /// <summary>
        ///     Time we wait on a service stop (ms).
        /// </summary>
        public const int ServiceStopTime = 2500;

        /// <summary>
        ///     Time we wait on a service uninstall (ms).
        /// </summary>
        public const int ServiceUninstallTime = 2500;

        /// <summary>
        ///     List of interfaces, marked as hidden.
        /// </summary>
        public static readonly string[] NetworkInterfaceBlacklist =
        {
            "Microsoft Virtual",
            "Hamachi Network",
            "VMware Virtual",
            "VirtualBox",
            "Software Loopback",
            "Microsoft ISATAP",
            "Microsoft-ISATAP",
            "Teredo Tunneling Pseudo-Interface"
        };

        /// <summary>
        ///     List of files must exist.
        /// </summary>
        public static readonly string[] DnsCryptProxyFiles =
        {
            "dnscrypt-proxy.exe",
            "dnscrypt-resolvers.csv",
            "dnscrypt-resolvers.csv.minisig",
            "hostip.exe",
            "libdcplugin_ldns_aaaa_blocking.dll",
            "libeay32.dll",
            "libgcc_s_dw2-1.dll",
            "libldns-1.dll",
            "libsodium-13.dll",
            "libwinpthread-1.dll"
        };
    }
}