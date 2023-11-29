// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Grouping configuration property bag. </summary>
    public partial class SecurityInsightsGroupingConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsGroupingConfiguration"/>. </summary>
        /// <param name="isEnabled"> Grouping enabled. </param>
        /// <param name="isClosedIncidentReopened"> Re-open closed matching incidents. </param>
        /// <param name="lookbackDuration"> Limit the group to alerts created within the lookback duration (in ISO 8601 duration format). </param>
        /// <param name="matchingMethod"> Grouping matching method. When method is Selected at least one of groupByEntities, groupByAlertDetails, groupByCustomDetails must be provided and not empty. </param>
        public SecurityInsightsGroupingConfiguration(bool isEnabled, bool isClosedIncidentReopened, TimeSpan lookbackDuration, SecurityInsightsGroupingMatchingMethod matchingMethod)
        {
            IsEnabled = isEnabled;
            IsClosedIncidentReopened = isClosedIncidentReopened;
            LookbackDuration = lookbackDuration;
            MatchingMethod = matchingMethod;
            GroupByEntities = new ChangeTrackingList<SecurityInsightsAlertRuleEntityMappingType>();
            GroupByAlertDetails = new ChangeTrackingList<SecurityInsightsAlertDetail>();
            GroupByCustomDetails = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsGroupingConfiguration"/>. </summary>
        /// <param name="isEnabled"> Grouping enabled. </param>
        /// <param name="isClosedIncidentReopened"> Re-open closed matching incidents. </param>
        /// <param name="lookbackDuration"> Limit the group to alerts created within the lookback duration (in ISO 8601 duration format). </param>
        /// <param name="matchingMethod"> Grouping matching method. When method is Selected at least one of groupByEntities, groupByAlertDetails, groupByCustomDetails must be provided and not empty. </param>
        /// <param name="groupByEntities"> A list of entity types to group by (when matchingMethod is Selected). Only entities defined in the current alert rule may be used. </param>
        /// <param name="groupByAlertDetails"> A list of alert details to group by (when matchingMethod is Selected). </param>
        /// <param name="groupByCustomDetails"> A list of custom details keys to group by (when matchingMethod is Selected). Only keys defined in the current alert rule may be used. </param>
        internal SecurityInsightsGroupingConfiguration(bool isEnabled, bool isClosedIncidentReopened, TimeSpan lookbackDuration, SecurityInsightsGroupingMatchingMethod matchingMethod, IList<SecurityInsightsAlertRuleEntityMappingType> groupByEntities, IList<SecurityInsightsAlertDetail> groupByAlertDetails, IList<string> groupByCustomDetails)
        {
            IsEnabled = isEnabled;
            IsClosedIncidentReopened = isClosedIncidentReopened;
            LookbackDuration = lookbackDuration;
            MatchingMethod = matchingMethod;
            GroupByEntities = groupByEntities;
            GroupByAlertDetails = groupByAlertDetails;
            GroupByCustomDetails = groupByCustomDetails;
        }

        /// <summary> Grouping enabled. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Re-open closed matching incidents. </summary>
        public bool IsClosedIncidentReopened { get; set; }
        /// <summary> Limit the group to alerts created within the lookback duration (in ISO 8601 duration format). </summary>
        public TimeSpan LookbackDuration { get; set; }
        /// <summary> Grouping matching method. When method is Selected at least one of groupByEntities, groupByAlertDetails, groupByCustomDetails must be provided and not empty. </summary>
        public SecurityInsightsGroupingMatchingMethod MatchingMethod { get; set; }
        /// <summary> A list of entity types to group by (when matchingMethod is Selected). Only entities defined in the current alert rule may be used. </summary>
        public IList<SecurityInsightsAlertRuleEntityMappingType> GroupByEntities { get; }
        /// <summary> A list of alert details to group by (when matchingMethod is Selected). </summary>
        public IList<SecurityInsightsAlertDetail> GroupByAlertDetails { get; }
        /// <summary> A list of custom details keys to group by (when matchingMethod is Selected). Only keys defined in the current alert rule may be used. </summary>
        public IList<string> GroupByCustomDetails { get; }
    }
}
