// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The type used for update operations of the DataProduct. </summary>
    public partial class DataProductPatch
    {
        /// <summary> Initializes a new instance of <see cref="DataProductPatch"/>. </summary>
        public DataProductPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Owners = new ChangeTrackingList<string>();
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> List of name or email associated with data product resource deployment. </summary>
        public IList<string> Owners { get; }
        /// <summary> Purview account url for data product to connect to. </summary>
        public string PurviewAccount { get; set; }
        /// <summary> Purview collection url for data product to connect to. </summary>
        public string PurviewCollection { get; set; }
        /// <summary> Flag to enable or disable private link for data product resource. </summary>
        public DataProductControlState? PrivateLinksEnabled { get; set; }
        /// <summary> Current configured minor version of the data product resource. </summary>
        public string CurrentMinorVersion { get; set; }
    }
}
