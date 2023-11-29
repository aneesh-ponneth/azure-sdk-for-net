// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Container for SQL workloads under SQL Availability Group. </summary>
    public partial class SqlAvailabilityGroupWorkloadProtectionContainer : WorkloadContainer
    {
        /// <summary> Initializes a new instance of <see cref="SqlAvailabilityGroupWorkloadProtectionContainer"/>. </summary>
        public SqlAvailabilityGroupWorkloadProtectionContainer()
        {
            ContainerType = ProtectableContainerType.SqlAvailabilityGroupWorkLoadContainer;
        }

        /// <summary> Initializes a new instance of <see cref="SqlAvailabilityGroupWorkloadProtectionContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        /// <param name="sourceResourceId"> ARM ID of the virtual machine represented by this Azure Workload Container. </param>
        /// <param name="lastUpdatedOn"> Time stamp when this container was updated. </param>
        /// <param name="extendedInfo"> Additional details of a workload container. </param>
        /// <param name="workloadType"> Workload type for which registration was sent. </param>
        /// <param name="operationType"> Re-Do Operation. </param>
        internal SqlAvailabilityGroupWorkloadProtectionContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, ResourceIdentifier sourceResourceId, DateTimeOffset? lastUpdatedOn, WorkloadContainerExtendedInfo extendedInfo, BackupWorkloadType? workloadType, WorkloadOperationType? operationType) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType, sourceResourceId, lastUpdatedOn, extendedInfo, workloadType, operationType)
        {
            ContainerType = containerType;
        }
    }
}
