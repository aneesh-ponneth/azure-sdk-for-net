// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing the CloudEndpoint data model.
    /// Cloud Endpoint object.
    /// </summary>
    public partial class CloudEndpointData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CloudEndpointData"/>. </summary>
        public CloudEndpointData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageAccountResourceId"> Storage Account Resource Id. </param>
        /// <param name="azureFileShareName"> Azure file share name. </param>
        /// <param name="storageAccountTenantId"> Storage Account Tenant Id. </param>
        /// <param name="partnershipId"> Partnership Id. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        /// <param name="isBackupEnabled"> Backup Enabled. </param>
        /// <param name="provisioningState"> CloudEndpoint Provisioning State. </param>
        /// <param name="lastWorkflowId"> CloudEndpoint lastWorkflowId. </param>
        /// <param name="lastOperationName"> Resource Last Operation Name. </param>
        /// <param name="changeEnumerationStatus"> Cloud endpoint change enumeration status. </param>
        internal CloudEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier storageAccountResourceId, string azureFileShareName, Guid? storageAccountTenantId, string partnershipId, string friendlyName, string isBackupEnabled, string provisioningState, string lastWorkflowId, string lastOperationName, CloudEndpointChangeEnumerationStatus changeEnumerationStatus) : base(id, name, resourceType, systemData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            AzureFileShareName = azureFileShareName;
            StorageAccountTenantId = storageAccountTenantId;
            PartnershipId = partnershipId;
            FriendlyName = friendlyName;
            IsBackupEnabled = isBackupEnabled;
            ProvisioningState = provisioningState;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            ChangeEnumerationStatus = changeEnumerationStatus;
        }

        /// <summary> Storage Account Resource Id. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> Azure file share name. </summary>
        public string AzureFileShareName { get; set; }
        /// <summary> Storage Account Tenant Id. </summary>
        public Guid? StorageAccountTenantId { get; set; }
        /// <summary> Partnership Id. </summary>
        public string PartnershipId { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Backup Enabled. </summary>
        public string IsBackupEnabled { get; }
        /// <summary> CloudEndpoint Provisioning State. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> CloudEndpoint lastWorkflowId. </summary>
        public string LastWorkflowId { get; set; }
        /// <summary> Resource Last Operation Name. </summary>
        public string LastOperationName { get; set; }
        /// <summary> Cloud endpoint change enumeration status. </summary>
        public CloudEndpointChangeEnumerationStatus ChangeEnumerationStatus { get; }
    }
}
