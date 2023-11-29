// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Kubernetes properties. </summary>
    public partial class MachineLearningKubernetesProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningKubernetesProperties"/>. </summary>
        public MachineLearningKubernetesProperties()
        {
            InstanceTypes = new ChangeTrackingDictionary<string, MachineLearningInstanceTypeSchema>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningKubernetesProperties"/>. </summary>
        /// <param name="relayConnectionString"> Relay connection string. </param>
        /// <param name="serviceBusConnectionString"> ServiceBus connection string. </param>
        /// <param name="extensionPrincipalId"> Extension principal-id. </param>
        /// <param name="extensionInstanceReleaseTrain"> Extension instance release train. </param>
        /// <param name="vcName"> VC name. </param>
        /// <param name="namespace"> Compute namespace. </param>
        /// <param name="defaultInstanceType"> Default instance type. </param>
        /// <param name="instanceTypes"> Instance Type Schema. </param>
        internal MachineLearningKubernetesProperties(string relayConnectionString, string serviceBusConnectionString, string extensionPrincipalId, string extensionInstanceReleaseTrain, string vcName, string @namespace, string defaultInstanceType, IDictionary<string, MachineLearningInstanceTypeSchema> instanceTypes)
        {
            RelayConnectionString = relayConnectionString;
            ServiceBusConnectionString = serviceBusConnectionString;
            ExtensionPrincipalId = extensionPrincipalId;
            ExtensionInstanceReleaseTrain = extensionInstanceReleaseTrain;
            VcName = vcName;
            Namespace = @namespace;
            DefaultInstanceType = defaultInstanceType;
            InstanceTypes = instanceTypes;
        }

        /// <summary> Relay connection string. </summary>
        public string RelayConnectionString { get; set; }
        /// <summary> ServiceBus connection string. </summary>
        public string ServiceBusConnectionString { get; set; }
        /// <summary> Extension principal-id. </summary>
        public string ExtensionPrincipalId { get; set; }
        /// <summary> Extension instance release train. </summary>
        public string ExtensionInstanceReleaseTrain { get; set; }
        /// <summary> VC name. </summary>
        public string VcName { get; set; }
        /// <summary> Compute namespace. </summary>
        public string Namespace { get; set; }
        /// <summary> Default instance type. </summary>
        public string DefaultInstanceType { get; set; }
        /// <summary> Instance Type Schema. </summary>
        public IDictionary<string, MachineLearningInstanceTypeSchema> InstanceTypes { get; }
    }
}
