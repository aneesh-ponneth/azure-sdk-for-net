// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for backup items. </summary>
    public partial class GenericProtectedItem : BackupGenericProtectedItem
    {
        /// <summary> Initializes a new instance of <see cref="GenericProtectedItem"/>. </summary>
        public GenericProtectedItem()
        {
            SourceAssociations = new ChangeTrackingDictionary<string, string>();
            ProtectedItemType = "GenericProtectedItem";
        }

        /// <summary> Initializes a new instance of <see cref="GenericProtectedItem"/>. </summary>
        /// <param name="protectedItemType"> backup item type. </param>
        /// <param name="backupManagementType"> Type of backup management for the backed up item. </param>
        /// <param name="workloadType"> Type of workload this item represents. </param>
        /// <param name="containerName"> Unique name of container. </param>
        /// <param name="sourceResourceId"> ARM ID of the resource to be backed up. </param>
        /// <param name="policyId"> ID of the backup policy with which this item is backed up. </param>
        /// <param name="lastRecoverOn"> Timestamp when the last (latest) backup copy was created for this backup item. </param>
        /// <param name="backupSetName"> Name of the backup set the backup item belongs to. </param>
        /// <param name="createMode"> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </param>
        /// <param name="deferredDeletedOn"> Time for deferred deletion in UTC. </param>
        /// <param name="isScheduledForDeferredDelete"> Flag to identify whether the DS is scheduled for deferred delete. </param>
        /// <param name="deferredDeleteTimeRemaining"> Time remaining before the DS marked for deferred delete is permanently deleted. </param>
        /// <param name="isDeferredDeleteScheduleUpcoming"> Flag to identify whether the deferred deleted DS is to be purged soon. </param>
        /// <param name="isRehydrate"> Flag to identify that deferred deleted DS is to be moved into Pause state. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="isArchiveEnabled"> Flag to identify whether datasource is protected in archive. </param>
        /// <param name="policyName"> Name of the policy used for protection. </param>
        /// <param name="softDeleteRetentionPeriodInDays"> Soft delete retention period in days. </param>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="policyState"> Indicates consistency of policy object and policy applied to this backup item. </param>
        /// <param name="protectionState"> Backup state of this backup item. </param>
        /// <param name="protectedItemId"> Data Plane Service ID of the protected item. </param>
        /// <param name="sourceAssociations"> Loosely coupled (type, value) associations (example - parent of a protected item). </param>
        /// <param name="fabricName"> Name of this backup item's fabric. </param>
        internal GenericProtectedItem(string protectedItemType, BackupManagementType? backupManagementType, BackupDataSourceType? workloadType, string containerName, ResourceIdentifier sourceResourceId, ResourceIdentifier policyId, DateTimeOffset? lastRecoverOn, string backupSetName, BackupCreateMode? createMode, DateTimeOffset? deferredDeletedOn, bool? isScheduledForDeferredDelete, string deferredDeleteTimeRemaining, bool? isDeferredDeleteScheduleUpcoming, bool? isRehydrate, IList<string> resourceGuardOperationRequests, bool? isArchiveEnabled, string policyName, int? softDeleteRetentionPeriodInDays, string friendlyName, string policyState, BackupProtectionState? protectionState, long? protectedItemId, IDictionary<string, string> sourceAssociations, string fabricName) : base(protectedItemType, backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoverOn, backupSetName, createMode, deferredDeletedOn, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, resourceGuardOperationRequests, isArchiveEnabled, policyName, softDeleteRetentionPeriodInDays)
        {
            FriendlyName = friendlyName;
            PolicyState = policyState;
            ProtectionState = protectionState;
            ProtectedItemId = protectedItemId;
            SourceAssociations = sourceAssociations;
            FabricName = fabricName;
            ProtectedItemType = protectedItemType ?? "GenericProtectedItem";
        }

        /// <summary> Friendly name of the container. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Indicates consistency of policy object and policy applied to this backup item. </summary>
        public string PolicyState { get; set; }
        /// <summary> Backup state of this backup item. </summary>
        public BackupProtectionState? ProtectionState { get; set; }
        /// <summary> Data Plane Service ID of the protected item. </summary>
        public long? ProtectedItemId { get; set; }
        /// <summary> Loosely coupled (type, value) associations (example - parent of a protected item). </summary>
        public IDictionary<string, string> SourceAssociations { get; }
        /// <summary> Name of this backup item's fabric. </summary>
        public string FabricName { get; set; }
    }
}
