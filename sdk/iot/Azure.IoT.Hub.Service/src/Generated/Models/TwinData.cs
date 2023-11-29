// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </summary>
    public partial class TwinData
    {
        /// <summary> Initializes a new instance of <see cref="TwinData"/>. </summary>
        public TwinData()
        {
            Tags = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="TwinData"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device in the identity registry of the IoT Hub. It is a case-sensitive string (up to 128 char long) of ASCII 7-bit alphanumeric chars, and the following special characters {'-', ':', '.', '+', '%', '_', '#', '*', '?', '!', '(', ')', ',', '=', '@', ';', '$', '''}. </param>
        /// <param name="moduleId"> The unique identifier of the module in the identity registry of the IoT Hub. It is a case-sensitive string (up to 128 char long) of ASCII 7-bit alphanumeric chars, and the following special characters {'-', ':', '.', '+', '%', '_', '#', '*', '?', '!', '(', ')', ',', '=', '@', ';', '$', '''}. </param>
        /// <param name="tags"> The collection of key-value pairs read and written by the solution back end. They are not visible to device apps. They keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The values are JSON objects, up-to 4KB in length. </param>
        /// <param name="properties"> The desired and reported properties of the twin. </param>
        /// <param name="etag"> The string representing a ETag for the device twin, as per RFC7232. </param>
        /// <param name="version"> The version for the device twin including tags and desired properties. </param>
        /// <param name="deviceEtag"> The string representing a ETag for the device, as per RFC7232. </param>
        /// <param name="status"> The enabled status of the device. If disabled, the device cannot connect to the service. </param>
        /// <param name="statusReason"> The reason for the current status of the device, if any. </param>
        /// <param name="statusUpdateTime"> The date and time when the status of the device was last updated. </param>
        /// <param name="connectionState"> The connection state of the device. </param>
        /// <param name="lastActivityTime"> The date and time when the device last connected or received or sent a message. The date and time is sepecified in ISO8601 datetime format in UTC, for example, 2015-01-28T16:24:48.789Z. This value is not updated if the device uses the HTTP/1 protocol to perform messaging operations. </param>
        /// <param name="cloudToDeviceMessageCount"> The number of cloud-to-device messages sent. </param>
        /// <param name="authenticationType"> The authentication type used by the device. </param>
        /// <param name="x509Thumbprint"> The X509 thumbprint of the device. </param>
        /// <param name="capabilities"> The status of capabilities enabled on the device. </param>
        /// <param name="deviceScope"> The scope of the device. </param>
        internal TwinData(string deviceId, string moduleId, IDictionary<string, object> tags, TwinProperties properties, string etag, long? version, string deviceEtag, TwinStatus? status, string statusReason, DateTimeOffset? statusUpdateTime, TwinConnectionState? connectionState, DateTimeOffset? lastActivityTime, int? cloudToDeviceMessageCount, TwinAuthenticationType? authenticationType, X509Thumbprint x509Thumbprint, DeviceCapabilities capabilities, string deviceScope)
        {
            DeviceId = deviceId;
            ModuleId = moduleId;
            Tags = tags;
            Properties = properties;
            Etag = etag;
            Version = version;
            DeviceEtag = deviceEtag;
            Status = status;
            StatusReason = statusReason;
            StatusUpdateTime = statusUpdateTime;
            ConnectionState = connectionState;
            LastActivityTime = lastActivityTime;
            CloudToDeviceMessageCount = cloudToDeviceMessageCount;
            AuthenticationType = authenticationType;
            X509Thumbprint = x509Thumbprint;
            Capabilities = capabilities;
            DeviceScope = deviceScope;
        }

        /// <summary> The unique identifier of the device in the identity registry of the IoT Hub. It is a case-sensitive string (up to 128 char long) of ASCII 7-bit alphanumeric chars, and the following special characters {'-', ':', '.', '+', '%', '_', '#', '*', '?', '!', '(', ')', ',', '=', '@', ';', '$', '''}. </summary>
        public string DeviceId { get; set; }
        /// <summary> The unique identifier of the module in the identity registry of the IoT Hub. It is a case-sensitive string (up to 128 char long) of ASCII 7-bit alphanumeric chars, and the following special characters {'-', ':', '.', '+', '%', '_', '#', '*', '?', '!', '(', ')', ',', '=', '@', ';', '$', '''}. </summary>
        public string ModuleId { get; set; }
        /// <summary> The collection of key-value pairs read and written by the solution back end. They are not visible to device apps. They keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The values are JSON objects, up-to 4KB in length. </summary>
        public IDictionary<string, object> Tags { get; }
        /// <summary> The desired and reported properties of the twin. </summary>
        public TwinProperties Properties { get; set; }
        /// <summary> The string representing a ETag for the device twin, as per RFC7232. </summary>
        public string Etag { get; set; }
        /// <summary> The version for the device twin including tags and desired properties. </summary>
        public long? Version { get; set; }
        /// <summary> The string representing a ETag for the device, as per RFC7232. </summary>
        public string DeviceEtag { get; set; }
        /// <summary> The enabled status of the device. If disabled, the device cannot connect to the service. </summary>
        public TwinStatus? Status { get; set; }
        /// <summary> The reason for the current status of the device, if any. </summary>
        public string StatusReason { get; set; }
        /// <summary> The date and time when the status of the device was last updated. </summary>
        public DateTimeOffset? StatusUpdateTime { get; set; }
        /// <summary> The connection state of the device. </summary>
        public TwinConnectionState? ConnectionState { get; set; }
        /// <summary> The date and time when the device last connected or received or sent a message. The date and time is sepecified in ISO8601 datetime format in UTC, for example, 2015-01-28T16:24:48.789Z. This value is not updated if the device uses the HTTP/1 protocol to perform messaging operations. </summary>
        public DateTimeOffset? LastActivityTime { get; set; }
        /// <summary> The number of cloud-to-device messages sent. </summary>
        public int? CloudToDeviceMessageCount { get; set; }
        /// <summary> The authentication type used by the device. </summary>
        public TwinAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The X509 thumbprint of the device. </summary>
        public X509Thumbprint X509Thumbprint { get; set; }
        /// <summary> The status of capabilities enabled on the device. </summary>
        public DeviceCapabilities Capabilities { get; set; }
        /// <summary> The scope of the device. </summary>
        public string DeviceScope { get; set; }
    }
}
