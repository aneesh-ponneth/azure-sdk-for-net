// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Represents the SKU name and Azure pricing tier for auto scale v-core resource. </summary>
    public partial class AutoScaleVCoreSku
    {
        /// <summary> Initializes a new instance of <see cref="AutoScaleVCoreSku"/>. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AutoScaleVCoreSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="AutoScaleVCoreSku"/>. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <param name="tier"> The name of the Azure pricing tier to which the SKU applies. </param>
        /// <param name="capacity"> The capacity of an auto scale v-core resource. </param>
        internal AutoScaleVCoreSku(string name, VCoreSkuTier? tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of the SKU level. </summary>
        public string Name { get; set; }
        /// <summary> The name of the Azure pricing tier to which the SKU applies. </summary>
        public VCoreSkuTier? Tier { get; set; }
        /// <summary> The capacity of an auto scale v-core resource. </summary>
        public int? Capacity { get; set; }
    }
}
