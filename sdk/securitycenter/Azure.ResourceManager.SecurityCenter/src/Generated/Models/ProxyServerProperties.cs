// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> For a non-Azure machine that is not connected directly to the internet, specify a proxy server that the non-Azure machine can use. </summary>
    public partial class ProxyServerProperties
    {
        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        public ProxyServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        /// <param name="ip"> Proxy server IP. </param>
        /// <param name="port"> Proxy server port. </param>
        internal ProxyServerProperties(string ip, string port)
        {
            IP = ip;
            Port = port;
        }

        /// <summary> Proxy server IP. </summary>
        public string IP { get; set; }
        /// <summary> Proxy server port. </summary>
        public string Port { get; set; }
    }
}
