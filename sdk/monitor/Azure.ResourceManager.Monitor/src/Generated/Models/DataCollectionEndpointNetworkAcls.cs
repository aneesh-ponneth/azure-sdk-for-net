// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Network access control rules for the endpoints. </summary>
    internal partial class DataCollectionEndpointNetworkAcls : NetworkRuleSet
    {
        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointNetworkAcls"/>. </summary>
        public DataCollectionEndpointNetworkAcls()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointNetworkAcls"/>. </summary>
        /// <param name="publicNetworkAccess"> The configuration to set whether network access from public internet to the endpoints are allowed. </param>
        internal DataCollectionEndpointNetworkAcls(MonitorPublicNetworkAccess? publicNetworkAccess) : base(publicNetworkAccess)
        {
        }
    }
}
