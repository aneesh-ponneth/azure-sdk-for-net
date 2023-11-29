// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Defines the observed Arc Agent status that is resourceSynced back to the ARM resource. </summary>
    public partial class ArcAgentStatus
    {
        /// <summary> Initializes a new instance of <see cref="ArcAgentStatus"/>. </summary>
        internal ArcAgentStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArcAgentStatus"/>. </summary>
        /// <param name="deploymentState"> Observed deployment state of the Arc Agents on the target cluster. Possible values include: 'pending', 'provisioning', 'provisioned', 'deleting', 'failed', 'upgrading'. </param>
        /// <param name="errorMessage"> Error messages while onboarding/upgrading/uninstalling the Arc agents. </param>
        /// <param name="onboardingPublicKey"> Onboarding public key for provisioning the Managed identity for the HybridAKS cluster. Will be used to create the hybridIdentityMetadata proxy resource and will not be persisted. </param>
        /// <param name="agentVersion"> Version of the Arc agents currently running on the Provisioned cluster resource. </param>
        /// <param name="coreCount"> Number of CPU cores present in the Provisioned cluster resource. </param>
        /// <param name="managedIdentityCertificateExpirationOn"> ManagedIdentity certificate expiration time (ValidUntil). </param>
        /// <param name="lastConnectivityOn"> Last connected timestamp of the Provisioned cluster resource. </param>
        internal ArcAgentStatus(DeploymentState? deploymentState, string errorMessage, string onboardingPublicKey, string agentVersion, long? coreCount, DateTimeOffset? managedIdentityCertificateExpirationOn, DateTimeOffset? lastConnectivityOn)
        {
            DeploymentState = deploymentState;
            ErrorMessage = errorMessage;
            OnboardingPublicKey = onboardingPublicKey;
            AgentVersion = agentVersion;
            CoreCount = coreCount;
            ManagedIdentityCertificateExpirationOn = managedIdentityCertificateExpirationOn;
            LastConnectivityOn = lastConnectivityOn;
        }

        /// <summary> Observed deployment state of the Arc Agents on the target cluster. Possible values include: 'pending', 'provisioning', 'provisioned', 'deleting', 'failed', 'upgrading'. </summary>
        public DeploymentState? DeploymentState { get; }
        /// <summary> Error messages while onboarding/upgrading/uninstalling the Arc agents. </summary>
        public string ErrorMessage { get; }
        /// <summary> Onboarding public key for provisioning the Managed identity for the HybridAKS cluster. Will be used to create the hybridIdentityMetadata proxy resource and will not be persisted. </summary>
        public string OnboardingPublicKey { get; }
        /// <summary> Version of the Arc agents currently running on the Provisioned cluster resource. </summary>
        public string AgentVersion { get; }
        /// <summary> Number of CPU cores present in the Provisioned cluster resource. </summary>
        public long? CoreCount { get; }
        /// <summary> ManagedIdentity certificate expiration time (ValidUntil). </summary>
        public DateTimeOffset? ManagedIdentityCertificateExpirationOn { get; }
        /// <summary> Last connected timestamp of the Provisioned cluster resource. </summary>
        public DateTimeOffset? LastConnectivityOn { get; }
    }
}
