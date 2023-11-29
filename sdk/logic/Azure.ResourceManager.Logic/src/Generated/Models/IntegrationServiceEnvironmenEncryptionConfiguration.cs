// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The encryption configuration for the integration service environment. </summary>
    internal partial class IntegrationServiceEnvironmenEncryptionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmenEncryptionConfiguration"/>. </summary>
        public IntegrationServiceEnvironmenEncryptionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmenEncryptionConfiguration"/>. </summary>
        /// <param name="encryptionKeyReference"> The encryption key reference. </param>
        internal IntegrationServiceEnvironmenEncryptionConfiguration(IntegrationServiceEnvironmenEncryptionKeyReference encryptionKeyReference)
        {
            EncryptionKeyReference = encryptionKeyReference;
        }

        /// <summary> The encryption key reference. </summary>
        public IntegrationServiceEnvironmenEncryptionKeyReference EncryptionKeyReference { get; set; }
    }
}
