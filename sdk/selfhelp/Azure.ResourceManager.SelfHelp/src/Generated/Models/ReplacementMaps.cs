// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Solution replacement maps. </summary>
    public partial class ReplacementMaps
    {
        /// <summary> Initializes a new instance of <see cref="ReplacementMaps"/>. </summary>
        public ReplacementMaps()
        {
            WebResults = new ChangeTrackingList<WebResult>();
            Diagnostics = new ChangeTrackingList<SolutionsDiagnostic>();
            Troubleshooters = new ChangeTrackingList<SolutionsTroubleshooters>();
            MetricsBasedCharts = new ChangeTrackingList<MetricsBasedChart>();
            Videos = new ChangeTrackingList<SelfHelpVideo>();
            VideoGroups = new ChangeTrackingList<VideoGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="ReplacementMaps"/>. </summary>
        /// <param name="webResults"> Solution AzureKB results. </param>
        /// <param name="diagnostics"> Solution diagnostics results. </param>
        /// <param name="troubleshooters"> Solutions Troubleshooters. </param>
        /// <param name="metricsBasedCharts"> Solution metrics based charts. </param>
        /// <param name="videos"> Video solutions, which have the power to engage the customer by stimulating their senses. </param>
        /// <param name="videoGroups"> Group of Videos. </param>
        internal ReplacementMaps(IList<WebResult> webResults, IList<SolutionsDiagnostic> diagnostics, IList<SolutionsTroubleshooters> troubleshooters, IList<MetricsBasedChart> metricsBasedCharts, IList<SelfHelpVideo> videos, IList<VideoGroup> videoGroups)
        {
            WebResults = webResults;
            Diagnostics = diagnostics;
            Troubleshooters = troubleshooters;
            MetricsBasedCharts = metricsBasedCharts;
            Videos = videos;
            VideoGroups = videoGroups;
        }

        /// <summary> Solution AzureKB results. </summary>
        public IList<WebResult> WebResults { get; }
        /// <summary> Solution diagnostics results. </summary>
        public IList<SolutionsDiagnostic> Diagnostics { get; }
        /// <summary> Solutions Troubleshooters. </summary>
        public IList<SolutionsTroubleshooters> Troubleshooters { get; }
        /// <summary> Solution metrics based charts. </summary>
        public IList<MetricsBasedChart> MetricsBasedCharts { get; }
        /// <summary> Video solutions, which have the power to engage the customer by stimulating their senses. </summary>
        public IList<SelfHelpVideo> Videos { get; }
        /// <summary> Group of Videos. </summary>
        public IList<VideoGroup> VideoGroups { get; }
    }
}
