// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Object for patch operations. </summary>
    public partial class NetworkManagerPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkManagerPatch"/>. </summary>
        public NetworkManagerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
