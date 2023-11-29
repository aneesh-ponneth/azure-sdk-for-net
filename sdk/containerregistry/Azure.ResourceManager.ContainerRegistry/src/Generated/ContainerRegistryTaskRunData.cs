// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistryTaskRun data model.
    /// The task run that has the ARM resource and properties.
    /// The task run will have the information of request and result of a run.
    /// </summary>
    public partial class ContainerRegistryTaskRunData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunData"/>. </summary>
        public ContainerRegistryTaskRunData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of this task run. </param>
        /// <param name="runRequest">
        /// The request (parameters) for the run
        /// Please note <see cref="ContainerRegistryRunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryDockerBuildContent"/>, <see cref="ContainerRegistryEncodedTaskRunContent"/>, <see cref="ContainerRegistryFileTaskRunContent"/> and <see cref="ContainerRegistryTaskRunContent"/>.
        /// </param>
        /// <param name="runResult"> The result of this task run. </param>
        /// <param name="forceUpdateTag"> How the run should be forced to rerun even if the run request configuration has not changed. </param>
        internal ContainerRegistryTaskRunData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, AzureLocation? location, ContainerRegistryProvisioningState? provisioningState, ContainerRegistryRunContent runRequest, ContainerRegistryRunData runResult, string forceUpdateTag) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Location = location;
            ProvisioningState = provisioningState;
            RunRequest = runRequest;
            RunResult = runResult;
            ForceUpdateTag = forceUpdateTag;
        }

        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The provisioning state of this task run. </summary>
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The request (parameters) for the run
        /// Please note <see cref="ContainerRegistryRunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryDockerBuildContent"/>, <see cref="ContainerRegistryEncodedTaskRunContent"/>, <see cref="ContainerRegistryFileTaskRunContent"/> and <see cref="ContainerRegistryTaskRunContent"/>.
        /// </summary>
        public ContainerRegistryRunContent RunRequest { get; set; }
        /// <summary> The result of this task run. </summary>
        public ContainerRegistryRunData RunResult { get; }
        /// <summary> How the run should be forced to rerun even if the run request configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
    }
}
