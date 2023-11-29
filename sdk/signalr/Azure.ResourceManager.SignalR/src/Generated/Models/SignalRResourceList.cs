// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SignalR;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Object that includes an array of resources and a possible link for next set. </summary>
    internal partial class SignalRResourceList
    {
        /// <summary> Initializes a new instance of <see cref="SignalRResourceList"/>. </summary>
        internal SignalRResourceList()
        {
            Value = new ChangeTrackingList<SignalRData>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceList"/>. </summary>
        /// <param name="value"> List of the resources. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal SignalRResourceList(IReadOnlyList<SignalRData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of the resources. </summary>
        public IReadOnlyList<SignalRData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
