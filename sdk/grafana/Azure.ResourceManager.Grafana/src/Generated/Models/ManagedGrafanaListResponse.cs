// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The ManagedGrafanaListResponse. </summary>
    internal partial class ManagedGrafanaListResponse
    {
        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaListResponse"/>. </summary>
        internal ManagedGrafanaListResponse()
        {
            Value = new ChangeTrackingList<ManagedGrafanaData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaListResponse"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal ManagedGrafanaListResponse(IReadOnlyList<ManagedGrafanaData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ManagedGrafanaData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
