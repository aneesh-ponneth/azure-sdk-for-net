// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the LatencyScorecard. </summary>
    public partial class LatencyScorecard : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="LatencyScorecard"/>. </summary>
        /// <param name="location"> The location. </param>
        public LatencyScorecard(AzureLocation location) : base(location)
        {
            LatencyMetrics = new ChangeTrackingList<LatencyMetric>();
        }

        /// <summary> Initializes a new instance of <see cref="LatencyScorecard"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="latencyScorecardId"> The unique identifier of the Latency Scorecard. </param>
        /// <param name="latencyScorecardName"> The name of the Latency Scorecard. </param>
        /// <param name="description"> The description of the Latency Scorecard. </param>
        /// <param name="scorecardEndpointA"> The A endpoint in the scorecard. </param>
        /// <param name="scorecardEndpointB"> The B endpoint in the scorecard. </param>
        /// <param name="startOn"> The start time of the Latency Scorecard in UTC. </param>
        /// <param name="endOn"> The end time of the Latency Scorecard in UTC. </param>
        /// <param name="country"> The country associated with the Latency Scorecard. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </param>
        /// <param name="latencyMetrics"> The latency metrics of the Latency Scorecard. </param>
        internal LatencyScorecard(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string latencyScorecardId, string latencyScorecardName, string description, Uri scorecardEndpointA, Uri scorecardEndpointB, DateTimeOffset? startOn, DateTimeOffset? endOn, string country, IList<LatencyMetric> latencyMetrics) : base(id, name, resourceType, systemData, tags, location)
        {
            LatencyScorecardId = latencyScorecardId;
            LatencyScorecardName = latencyScorecardName;
            Description = description;
            ScorecardEndpointA = scorecardEndpointA;
            ScorecardEndpointB = scorecardEndpointB;
            StartOn = startOn;
            EndOn = endOn;
            Country = country;
            LatencyMetrics = latencyMetrics;
        }

        /// <summary> The unique identifier of the Latency Scorecard. </summary>
        public string LatencyScorecardId { get; }
        /// <summary> The name of the Latency Scorecard. </summary>
        public string LatencyScorecardName { get; }
        /// <summary> The description of the Latency Scorecard. </summary>
        public string Description { get; }
        /// <summary> The A endpoint in the scorecard. </summary>
        public Uri ScorecardEndpointA { get; }
        /// <summary> The B endpoint in the scorecard. </summary>
        public Uri ScorecardEndpointB { get; }
        /// <summary> The start time of the Latency Scorecard in UTC. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the Latency Scorecard in UTC. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The country associated with the Latency Scorecard. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </summary>
        public string Country { get; }
        /// <summary> The latency metrics of the Latency Scorecard. </summary>
        public IList<LatencyMetric> LatencyMetrics { get; }
    }
}
