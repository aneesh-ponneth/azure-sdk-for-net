// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The parameters to list service SAS credentials of a specific resource. </summary>
    public partial class ServiceSasContent
    {
        /// <summary> Initializes a new instance of <see cref="ServiceSasContent"/>. </summary>
        /// <param name="canonicalizedResource"> The canonical path to the signed resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="canonicalizedResource"/> is null. </exception>
        public ServiceSasContent(string canonicalizedResource)
        {
            Argument.AssertNotNull(canonicalizedResource, nameof(canonicalizedResource));

            CanonicalizedResource = canonicalizedResource;
        }

        /// <summary> The canonical path to the signed resource. </summary>
        public string CanonicalizedResource { get; }
        /// <summary> The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s). </summary>
        public ServiceSasSignedResourceType? Resource { get; set; }
        /// <summary> The signed permissions for the service SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </summary>
        public StorageAccountSasPermission? Permissions { get; set; }
        /// <summary> An IP address or a range of IP addresses from which to accept requests. </summary>
        public string IPAddressOrRange { get; set; }
        /// <summary> The protocol permitted for a request made with the account SAS. </summary>
        public StorageAccountHttpProtocol? Protocols { get; set; }
        /// <summary> The time at which the SAS becomes valid. </summary>
        public DateTimeOffset? SharedAccessStartOn { get; set; }
        /// <summary> The time at which the shared access signature becomes invalid. </summary>
        public DateTimeOffset? SharedAccessExpiryOn { get; set; }
        /// <summary> A unique value up to 64 characters in length that correlates to an access policy specified for the container, queue, or table. </summary>
        public string Identifier { get; set; }
        /// <summary> The start of partition key. </summary>
        public string PartitionKeyStart { get; set; }
        /// <summary> The end of partition key. </summary>
        public string PartitionKeyEnd { get; set; }
        /// <summary> The start of row key. </summary>
        public string RowKeyStart { get; set; }
        /// <summary> The end of row key. </summary>
        public string RowKeyEnd { get; set; }
        /// <summary> The key to sign the account SAS token with. </summary>
        public string KeyToSign { get; set; }
        /// <summary> The response header override for cache control. </summary>
        public string CacheControl { get; set; }
        /// <summary> The response header override for content disposition. </summary>
        public string ContentDisposition { get; set; }
        /// <summary> The response header override for content encoding. </summary>
        public string ContentEncoding { get; set; }
        /// <summary> The response header override for content language. </summary>
        public string ContentLanguage { get; set; }
        /// <summary> The response header override for content type. </summary>
        public string ContentType { get; set; }
    }
}
