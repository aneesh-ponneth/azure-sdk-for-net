// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Edgenode is a global Point of Presence (POP) location used to deliver CDN content to end users. </summary>
    public partial class EdgeNode : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EdgeNode"/>. </summary>
        public EdgeNode()
        {
            IPAddressGroups = new ChangeTrackingList<IPAddressGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeNode"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="ipAddressGroups"> List of ip address groups. </param>
        internal EdgeNode(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<IPAddressGroup> ipAddressGroups) : base(id, name, resourceType, systemData)
        {
            IPAddressGroups = ipAddressGroups;
        }

        /// <summary> List of ip address groups. </summary>
        public IList<IPAddressGroup> IPAddressGroups { get; }
    }
}
