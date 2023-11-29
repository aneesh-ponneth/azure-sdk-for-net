// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The network manager effective connectivity configuration. </summary>
    public partial class EffectiveConnectivityConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="EffectiveConnectivityConfiguration"/>. </summary>
        internal EffectiveConnectivityConfiguration()
        {
            ConfigurationGroups = new ChangeTrackingList<NetworkConfigurationGroup>();
            Hubs = new ChangeTrackingList<ConnectivityHub>();
            AppliesToGroups = new ChangeTrackingList<ConnectivityGroupItem>();
        }

        /// <summary> Initializes a new instance of <see cref="EffectiveConnectivityConfiguration"/>. </summary>
        /// <param name="id"> Connectivity configuration ID. </param>
        /// <param name="configurationGroups"> Effective configuration groups. </param>
        /// <param name="description"> A description of the connectivity configuration. </param>
        /// <param name="connectivityTopology"> Connectivity topology type. </param>
        /// <param name="hubs"> List of hubItems. </param>
        /// <param name="isGlobal"> Flag if global mesh is supported. </param>
        /// <param name="appliesToGroups"> Groups for configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the connectivity configuration resource. </param>
        /// <param name="deleteExistingPeering"> Flag if need to remove current existing peerings. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        internal EffectiveConnectivityConfiguration(string id, IReadOnlyList<NetworkConfigurationGroup> configurationGroups, string description, ConnectivityTopology? connectivityTopology, IReadOnlyList<ConnectivityHub> hubs, GlobalMeshSupportFlag? isGlobal, IReadOnlyList<ConnectivityGroupItem> appliesToGroups, NetworkProvisioningState? provisioningState, DeleteExistingPeering? deleteExistingPeering, Guid? resourceGuid)
        {
            Id = id;
            ConfigurationGroups = configurationGroups;
            Description = description;
            ConnectivityTopology = connectivityTopology;
            Hubs = hubs;
            IsGlobal = isGlobal;
            AppliesToGroups = appliesToGroups;
            ProvisioningState = provisioningState;
            DeleteExistingPeering = deleteExistingPeering;
            ResourceGuid = resourceGuid;
        }

        /// <summary> Connectivity configuration ID. </summary>
        public string Id { get; }
        /// <summary> Effective configuration groups. </summary>
        public IReadOnlyList<NetworkConfigurationGroup> ConfigurationGroups { get; }
        /// <summary> A description of the connectivity configuration. </summary>
        public string Description { get; }
        /// <summary> Connectivity topology type. </summary>
        public ConnectivityTopology? ConnectivityTopology { get; }
        /// <summary> List of hubItems. </summary>
        public IReadOnlyList<ConnectivityHub> Hubs { get; }
        /// <summary> Flag if global mesh is supported. </summary>
        public GlobalMeshSupportFlag? IsGlobal { get; }
        /// <summary> Groups for configuration. </summary>
        public IReadOnlyList<ConnectivityGroupItem> AppliesToGroups { get; }
        /// <summary> The provisioning state of the connectivity configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Flag if need to remove current existing peerings. </summary>
        public DeleteExistingPeering? DeleteExistingPeering { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
    }
}
