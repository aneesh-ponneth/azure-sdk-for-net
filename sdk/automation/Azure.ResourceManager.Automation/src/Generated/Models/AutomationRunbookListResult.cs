// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list runbook operation. </summary>
    internal partial class AutomationRunbookListResult
    {
        /// <summary> Initializes a new instance of <see cref="AutomationRunbookListResult"/>. </summary>
        internal AutomationRunbookListResult()
        {
            Value = new ChangeTrackingList<AutomationRunbookData>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of runbooks. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        internal AutomationRunbookListResult(IReadOnlyList<AutomationRunbookData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets a list of runbooks. </summary>
        public IReadOnlyList<AutomationRunbookData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
