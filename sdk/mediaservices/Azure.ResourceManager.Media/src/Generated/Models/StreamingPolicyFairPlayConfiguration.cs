// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify configurations of FairPlay in Streaming Policy. </summary>
    public partial class StreamingPolicyFairPlayConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="StreamingPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="allowPersistentLicense"> All license to be persistent or not. </param>
        public StreamingPolicyFairPlayConfiguration(bool allowPersistentLicense)
        {
            AllowPersistentLicense = allowPersistentLicense;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="customLicenseAcquisitionUriTemplate"> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </param>
        /// <param name="allowPersistentLicense"> All license to be persistent or not. </param>
        internal StreamingPolicyFairPlayConfiguration(string customLicenseAcquisitionUriTemplate, bool allowPersistentLicense)
        {
            CustomLicenseAcquisitionUriTemplate = customLicenseAcquisitionUriTemplate;
            AllowPersistentLicense = allowPersistentLicense;
        }

        /// <summary> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </summary>
        public string CustomLicenseAcquisitionUriTemplate { get; set; }
        /// <summary> All license to be persistent or not. </summary>
        public bool AllowPersistentLicense { get; set; }
    }
}
