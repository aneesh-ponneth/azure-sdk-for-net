// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Deployment configuration properties. </summary>
    public partial class BatchDeploymentConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="BatchDeploymentConfiguration"/>. </summary>
        public BatchDeploymentConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchDeploymentConfiguration"/>. </summary>
        /// <param name="cloudServiceConfiguration"> This property and virtualMachineConfiguration are mutually exclusive and one of the properties must be specified. This property cannot be specified if the Batch account was created with its poolAllocationMode property set to 'UserSubscription'. </param>
        /// <param name="vmConfiguration"> This property and cloudServiceConfiguration are mutually exclusive and one of the properties must be specified. </param>
        internal BatchDeploymentConfiguration(BatchCloudServiceConfiguration cloudServiceConfiguration, BatchVmConfiguration vmConfiguration)
        {
            CloudServiceConfiguration = cloudServiceConfiguration;
            VmConfiguration = vmConfiguration;
        }

        /// <summary> This property and virtualMachineConfiguration are mutually exclusive and one of the properties must be specified. This property cannot be specified if the Batch account was created with its poolAllocationMode property set to 'UserSubscription'. </summary>
        public BatchCloudServiceConfiguration CloudServiceConfiguration { get; set; }
        /// <summary> This property and cloudServiceConfiguration are mutually exclusive and one of the properties must be specified. </summary>
        public BatchVmConfiguration VmConfiguration { get; set; }
    }
}
