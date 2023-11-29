// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing the HealthcareApisIotConnector data model.
    /// IoT Connector definition.
    /// </summary>
    public partial class HealthcareApisIotConnectorData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotConnectorData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HealthcareApisIotConnectorData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotConnectorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="ingestionEndpointConfiguration"> Source configuration. </param>
        /// <param name="deviceMapping"> Device Mappings. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        internal HealthcareApisIotConnectorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HealthcareApisProvisioningState? provisioningState, HealthcareApisIotConnectorEventHubIngestionConfiguration ingestionEndpointConfiguration, HealthcareApisIotMappingProperties deviceMapping, ManagedServiceIdentity identity, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            IngestionEndpointConfiguration = ingestionEndpointConfiguration;
            DeviceMapping = deviceMapping;
            Identity = identity;
            ETag = etag;
        }

        /// <summary> The provisioning state. </summary>
        public HealthcareApisProvisioningState? ProvisioningState { get; }
        /// <summary> Source configuration. </summary>
        public HealthcareApisIotConnectorEventHubIngestionConfiguration IngestionEndpointConfiguration { get; set; }
        /// <summary> Device Mappings. </summary>
        internal HealthcareApisIotMappingProperties DeviceMapping { get; set; }
        /// <summary>
        /// The mapping.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData DeviceMappingContent
        {
            get => DeviceMapping is null ? default : DeviceMapping.Content;
            set
            {
                if (DeviceMapping is null)
                    DeviceMapping = new HealthcareApisIotMappingProperties();
                DeviceMapping.Content = value;
            }
        }

        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
