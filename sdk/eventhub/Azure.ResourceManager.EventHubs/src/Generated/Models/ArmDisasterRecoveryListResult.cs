// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The result of the List Alias(Disaster Recovery configuration) operation. </summary>
    internal partial class ArmDisasterRecoveryListResult
    {
        /// <summary> Initializes a new instance of <see cref="ArmDisasterRecoveryListResult"/>. </summary>
        internal ArmDisasterRecoveryListResult()
        {
            Value = new ChangeTrackingList<EventHubsDisasterRecoveryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDisasterRecoveryListResult"/>. </summary>
        /// <param name="value"> List of Alias(Disaster Recovery configurations). </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration). </param>
        internal ArmDisasterRecoveryListResult(IReadOnlyList<EventHubsDisasterRecoveryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Alias(Disaster Recovery configurations). </summary>
        public IReadOnlyList<EventHubsDisasterRecoveryData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration). </summary>
        public string NextLink { get; }
    }
}
