// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListNetworkWatchers API service call. </summary>
    internal partial class NetworkWatcherListResult
    {
        /// <summary> Initializes a new instance of <see cref="NetworkWatcherListResult"/>. </summary>
        internal NetworkWatcherListResult()
        {
            Value = new ChangeTrackingList<NetworkWatcherData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkWatcherListResult"/>. </summary>
        /// <param name="value"> List of network watcher resources. </param>
        internal NetworkWatcherListResult(IReadOnlyList<NetworkWatcherData> value)
        {
            Value = value;
        }

        /// <summary> List of network watcher resources. </summary>
        public IReadOnlyList<NetworkWatcherData> Value { get; }
    }
}
