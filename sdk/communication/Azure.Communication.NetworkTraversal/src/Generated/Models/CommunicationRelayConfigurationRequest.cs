// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.NetworkTraversal
{
    /// <summary> Request for a CommunicationRelayConfiguration. </summary>
    internal partial class CommunicationRelayConfigurationRequest
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationRelayConfigurationRequest"/>. </summary>
        public CommunicationRelayConfigurationRequest()
        {
        }

        /// <summary> An identity to be associated with telemetry for data relayed using the returned credentials. Must be an existing ACS user identity. If not provided, the telemetry will not contain an associated identity value. </summary>
        public string Id { get; set; }
        /// <summary> Filter the routing methodology returned. If not provided, will return all route types in separate ICE servers. </summary>
        public RouteType? RouteType { get; set; }
        /// <summary> The credential Time-To-Live (TTL), in seconds. The default value will be used if given value exceeds it. </summary>
        public int? Ttl { get; set; }
    }
}
