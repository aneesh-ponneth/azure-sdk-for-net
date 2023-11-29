// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The MarketplaceRule. </summary>
    public partial class MarketplaceRule
    {
        /// <summary> Initializes a new instance of <see cref="MarketplaceRule"/>. </summary>
        public MarketplaceRule()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceRule"/>. </summary>
        /// <param name="ruleType"> Rule type. </param>
        /// <param name="value"></param>
        internal MarketplaceRule(MarketplaceRuleType? ruleType, IList<string> value)
        {
            RuleType = ruleType;
            Value = value;
        }

        /// <summary> Rule type. </summary>
        public MarketplaceRuleType? RuleType { get; set; }
        /// <summary> Gets the value. </summary>
        public IList<string> Value { get; }
    }
}
