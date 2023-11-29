// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> General Replication extension model custom properties. </summary>
    public partial class GeneralReplicationExtensionModelCustomProperties : ReplicationExtensionModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="GeneralReplicationExtensionModelCustomProperties"/>. </summary>
        public GeneralReplicationExtensionModelCustomProperties()
        {
            InstanceType = "ReplicationExtensionModelCustomProperties";
        }

        /// <summary> Initializes a new instance of <see cref="GeneralReplicationExtensionModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal GeneralReplicationExtensionModelCustomProperties(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "ReplicationExtensionModelCustomProperties";
        }
    }
}
