// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The security domain properties of the managed hsm. </summary>
    public partial class ManagedHSMSecurityDomainProperties
    {
        /// <summary> Initializes a new instance of <see cref="ManagedHSMSecurityDomainProperties"/>. </summary>
        internal ManagedHSMSecurityDomainProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHSMSecurityDomainProperties"/>. </summary>
        /// <param name="activationStatus"> Activation Status. </param>
        /// <param name="activationStatusMessage"> Activation Status Message. </param>
        internal ManagedHSMSecurityDomainProperties(ManagedHSMSecurityDomainActivationStatus? activationStatus, string activationStatusMessage)
        {
            ActivationStatus = activationStatus;
            ActivationStatusMessage = activationStatusMessage;
        }

        /// <summary> Activation Status. </summary>
        public ManagedHSMSecurityDomainActivationStatus? ActivationStatus { get; }
        /// <summary> Activation Status Message. </summary>
        public string ActivationStatusMessage { get; }
    }
}
