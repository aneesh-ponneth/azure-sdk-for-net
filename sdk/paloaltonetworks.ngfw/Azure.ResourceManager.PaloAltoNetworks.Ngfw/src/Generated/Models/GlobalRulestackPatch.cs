// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The type used for update operations of the GlobalRulestackResource. </summary>
    public partial class GlobalRulestackPatch
    {
        /// <summary> Initializes a new instance of <see cref="GlobalRulestackPatch"/>. </summary>
        public GlobalRulestackPatch()
        {
        }

        /// <summary> Global Location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The updatable properties of the GlobalRulestackResource. </summary>
        public GlobalRulestackUpdateProperties Properties { get; set; }
    }
}
