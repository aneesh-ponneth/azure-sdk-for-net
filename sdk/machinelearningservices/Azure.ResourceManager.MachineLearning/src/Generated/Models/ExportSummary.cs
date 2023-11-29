// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The ExportSummary.
    /// Please note <see cref="ExportSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CsvExportSummary"/>, <see cref="CocoExportSummary"/> and <see cref="DatasetExportSummary"/>.
    /// </summary>
    public abstract partial class ExportSummary
    {
        /// <summary> Initializes a new instance of <see cref="ExportSummary"/>. </summary>
        protected ExportSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportSummary"/>. </summary>
        /// <param name="endOn"> The time when the export was completed. </param>
        /// <param name="exportedRowCount"> The total number of labeled datapoints exported. </param>
        /// <param name="format"> [Required] The format of exported labels, also as the discriminator. </param>
        /// <param name="labelingJobId"> Name and identifier of the job containing exported labels. </param>
        /// <param name="startOn"> The time when the export was requested. </param>
        internal ExportSummary(DateTimeOffset? endOn, long? exportedRowCount, ExportFormatType format, string labelingJobId, DateTimeOffset? startOn)
        {
            EndOn = endOn;
            ExportedRowCount = exportedRowCount;
            Format = format;
            LabelingJobId = labelingJobId;
            StartOn = startOn;
        }

        /// <summary> The time when the export was completed. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The total number of labeled datapoints exported. </summary>
        public long? ExportedRowCount { get; }
        /// <summary> [Required] The format of exported labels, also as the discriminator. </summary>
        internal ExportFormatType Format { get; set; }
        /// <summary> Name and identifier of the job containing exported labels. </summary>
        public string LabelingJobId { get; }
        /// <summary> The time when the export was requested. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}
