// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of EventRoute objects. </summary>
    internal partial class DigitalTwinsEventRouteCollection
    {
        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEventRouteCollection"/>. </summary>
        /// <param name="value"> The EventRoute objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DigitalTwinsEventRouteCollection(IEnumerable<DigitalTwinsEventRoute> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEventRouteCollection"/>. </summary>
        /// <param name="value"> The EventRoute objects. </param>
        /// <param name="nextLink"> A URI to retrieve the next page of results. </param>
        internal DigitalTwinsEventRouteCollection(IReadOnlyList<DigitalTwinsEventRoute> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The EventRoute objects. </summary>
        public IReadOnlyList<DigitalTwinsEventRoute> Value { get; }
        /// <summary> A URI to retrieve the next page of results. </summary>
        public string NextLink { get; }
    }
}
