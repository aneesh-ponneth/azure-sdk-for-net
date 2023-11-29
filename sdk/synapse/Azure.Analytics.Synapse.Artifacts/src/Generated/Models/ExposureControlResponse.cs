// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The exposure control response. </summary>
    public partial class ExposureControlResponse
    {
        /// <summary> Initializes a new instance of <see cref="ExposureControlResponse"/>. </summary>
        public ExposureControlResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExposureControlResponse"/>. </summary>
        /// <param name="featureName"> The feature name. </param>
        /// <param name="value"> The feature value. </param>
        internal ExposureControlResponse(string featureName, string value)
        {
            FeatureName = featureName;
            Value = value;
        }

        /// <summary> The feature name. </summary>
        public string FeatureName { get; }
        /// <summary> The feature value. </summary>
        public string Value { get; }
    }
}
