// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A managed server dns alias creation request. </summary>
    public partial class ManagedServerDnsAliasCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServerDnsAliasCreateOrUpdateContent"/>. </summary>
        public ManagedServerDnsAliasCreateOrUpdateContent()
        {
        }

        /// <summary> Whether or not DNS record should be created for this alias. </summary>
        public bool? CreateDnsRecord { get; set; }
    }
}
