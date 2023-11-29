// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> The response from the List Cache SKUs operation. </summary>
    internal partial class StorageCacheSkusResult
    {
        /// <summary> Initializes a new instance of <see cref="StorageCacheSkusResult"/>. </summary>
        internal StorageCacheSkusResult()
        {
            Value = new ChangeTrackingList<StorageCacheSku>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheSkusResult"/>. </summary>
        /// <param name="nextLink"> The URI to fetch the next page of cache SKUs. </param>
        /// <param name="value"> The list of SKUs available for the subscription. </param>
        internal StorageCacheSkusResult(string nextLink, IReadOnlyList<StorageCacheSku> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URI to fetch the next page of cache SKUs. </summary>
        public string NextLink { get; }
        /// <summary> The list of SKUs available for the subscription. </summary>
        public IReadOnlyList<StorageCacheSku> Value { get; }
    }
}
