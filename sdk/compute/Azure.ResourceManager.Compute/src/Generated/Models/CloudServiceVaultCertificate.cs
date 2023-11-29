// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance. </summary>
    public partial class CloudServiceVaultCertificate
    {
        /// <summary> Initializes a new instance of <see cref="CloudServiceVaultCertificate"/>. </summary>
        public CloudServiceVaultCertificate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceVaultCertificate"/>. </summary>
        /// <param name="certificateUri"> This is the URL of a certificate that has been uploaded to Key Vault as a secret. </param>
        internal CloudServiceVaultCertificate(Uri certificateUri)
        {
            CertificateUri = certificateUri;
        }

        /// <summary> This is the URL of a certificate that has been uploaded to Key Vault as a secret. </summary>
        public Uri CertificateUri { get; set; }
    }
}
