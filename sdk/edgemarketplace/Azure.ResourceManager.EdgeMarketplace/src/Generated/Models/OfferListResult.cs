// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.EdgeMarketplace;

namespace Azure.ResourceManager.EdgeMarketplace.Models
{
    /// <summary> The response of a Offer list operation. </summary>
    internal partial class OfferListResult
    {
        /// <summary> Initializes a new instance of <see cref="OfferListResult"/>. </summary>
        /// <param name="value"> The Offer items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OfferListResult(IEnumerable<OfferData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="OfferListResult"/>. </summary>
        /// <param name="value"> The Offer items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal OfferListResult(IReadOnlyList<OfferData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Offer items on this page. </summary>
        public IReadOnlyList<OfferData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
