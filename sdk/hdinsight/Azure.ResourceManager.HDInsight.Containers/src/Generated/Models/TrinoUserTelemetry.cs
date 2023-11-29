// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> User telemetry. </summary>
    internal partial class TrinoUserTelemetry
    {
        /// <summary> Initializes a new instance of <see cref="TrinoUserTelemetry"/>. </summary>
        public TrinoUserTelemetry()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrinoUserTelemetry"/>. </summary>
        /// <param name="storage"> Trino user telemetry definition. </param>
        internal TrinoUserTelemetry(TrinoTelemetryConfig storage)
        {
            Storage = storage;
        }

        /// <summary> Trino user telemetry definition. </summary>
        public TrinoTelemetryConfig Storage { get; set; }
    }
}
