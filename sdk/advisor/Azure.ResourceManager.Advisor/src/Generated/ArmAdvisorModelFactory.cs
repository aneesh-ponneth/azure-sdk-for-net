// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Advisor;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAdvisorModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Advisor.MetadataEntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The display name. </param>
        /// <param name="dependsOn"> The list of keys on which this entity depends on. </param>
        /// <param name="applicableScenarios"> The list of scenarios applicable to this metadata entity. </param>
        /// <param name="supportedValues"> The list of supported values. </param>
        /// <returns> A new <see cref="Advisor.MetadataEntityData"/> instance for mocking. </returns>
        public static MetadataEntityData MetadataEntityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, IEnumerable<string> dependsOn = null, IEnumerable<Scenario> applicableScenarios = null, IEnumerable<MetadataSupportedValueDetail> supportedValues = null)
        {
            dependsOn ??= new List<string>();
            applicableScenarios ??= new List<Scenario>();
            supportedValues ??= new List<MetadataSupportedValueDetail>();

            return new MetadataEntityData(id, name, resourceType, systemData, displayName, dependsOn?.ToList(), applicableScenarios?.ToList(), supportedValues?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.MetadataSupportedValueDetail"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="displayName"> The display name. </param>
        /// <returns> A new <see cref="Models.MetadataSupportedValueDetail"/> instance for mocking. </returns>
        public static MetadataSupportedValueDetail MetadataSupportedValueDetail(string id = null, string displayName = null)
        {
            return new MetadataSupportedValueDetail(id, displayName);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConfigData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="exclude"> Exclude the resource from Advisor evaluations. Valid values: False (default) or True. </param>
        /// <param name="lowCpuThreshold"> Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5 (default), 10, 15 or 20. </param>
        /// <param name="digests"> Advisor digest configuration. Valid only for subscriptions. </param>
        /// <returns> A new <see cref="Models.ConfigData"/> instance for mocking. </returns>
        public static ConfigData ConfigData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? exclude = null, CpuThreshold? lowCpuThreshold = null, IEnumerable<DigestConfig> digests = null)
        {
            digests ??= new List<DigestConfig>();

            return new ConfigData(id, name, resourceType, systemData, exclude, lowCpuThreshold, digests?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Advisor.ResourceRecommendationBaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="category"> The category of the recommendation. </param>
        /// <param name="impact"> The business impact of the recommendation. </param>
        /// <param name="impactedField"> The resource type identified by Advisor. </param>
        /// <param name="impactedValue"> The resource identified by Advisor. </param>
        /// <param name="lastUpdated"> The most recent time that Advisor checked the validity of the recommendation. </param>
        /// <param name="metadata"> The recommendation metadata. </param>
        /// <param name="recommendationTypeId"> The recommendation-type GUID. </param>
        /// <param name="risk"> The potential risk of not implementing the recommendation. </param>
        /// <param name="shortDescription"> A summary of the recommendation. </param>
        /// <param name="suppressionIds"> The list of snoozed and dismissed rules for the recommendation. </param>
        /// <param name="extendedProperties"> Extended properties. </param>
        /// <param name="resourceMetadata"> Metadata of resource that was assessed. </param>
        /// <param name="description"> The detailed description of recommendation. </param>
        /// <param name="label"> The label of recommendation. </param>
        /// <param name="learnMoreLink"> The link to learn more about recommendation and generation logic. </param>
        /// <param name="potentialBenefits"> The potential benefit of implementing recommendation. </param>
        /// <param name="actions"> The list of recommended actions to implement recommendation. </param>
        /// <param name="remediation"> The automated way to apply recommendation. </param>
        /// <param name="exposedMetadataProperties"> The recommendation metadata properties exposed to customer to provide additional information. </param>
        /// <returns> A new <see cref="Advisor.ResourceRecommendationBaseData"/> instance for mocking. </returns>
        public static ResourceRecommendationBaseData ResourceRecommendationBaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Category? category = null, Impact? impact = null, string impactedField = null, string impactedValue = null, DateTimeOffset? lastUpdated = null, IDictionary<string, BinaryData> metadata = null, string recommendationTypeId = null, Risk? risk = null, ShortDescription shortDescription = null, IEnumerable<Guid> suppressionIds = null, IDictionary<string, string> extendedProperties = null, ResourceMetadata resourceMetadata = null, string description = null, string label = null, string learnMoreLink = null, string potentialBenefits = null, IEnumerable<IDictionary<string, BinaryData>> actions = null, IDictionary<string, BinaryData> remediation = null, IDictionary<string, BinaryData> exposedMetadataProperties = null)
        {
            metadata ??= new Dictionary<string, BinaryData>();
            suppressionIds ??= new List<Guid>();
            extendedProperties ??= new Dictionary<string, string>();
            actions ??= new List<IDictionary<string, BinaryData>>();
            remediation ??= new Dictionary<string, BinaryData>();
            exposedMetadataProperties ??= new Dictionary<string, BinaryData>();

            return new ResourceRecommendationBaseData(id, name, resourceType, systemData, category, impact, impactedField, impactedValue, lastUpdated, metadata, recommendationTypeId, risk, shortDescription, suppressionIds?.ToList(), extendedProperties, resourceMetadata, description, label, learnMoreLink, potentialBenefits, actions?.ToList(), remediation, exposedMetadataProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Advisor.SuppressionContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suppressionId"> The GUID of the suppression. </param>
        /// <param name="ttl"> The duration for which the suppression is valid. </param>
        /// <param name="expirationTimeStamp"> Gets or sets the expiration time stamp. </param>
        /// <returns> A new <see cref="Advisor.SuppressionContractData"/> instance for mocking. </returns>
        public static SuppressionContractData SuppressionContractData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string suppressionId = null, string ttl = null, DateTimeOffset? expirationTimeStamp = null)
        {
            return new SuppressionContractData(id, name, resourceType, systemData, suppressionId, ttl, expirationTimeStamp);
        }
    }
}
