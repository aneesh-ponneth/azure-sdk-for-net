// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The list of payment methods. </summary>
    internal partial class PaymentMethodsListResult
    {
        /// <summary> Initializes a new instance of <see cref="PaymentMethodsListResult"/>. </summary>
        internal PaymentMethodsListResult()
        {
            Value = new ChangeTrackingList<BillingPaymentMethodData>();
        }

        /// <summary> Initializes a new instance of <see cref="PaymentMethodsListResult"/>. </summary>
        /// <param name="value"> The list of payment methods. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal PaymentMethodsListResult(IReadOnlyList<BillingPaymentMethodData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of payment methods. </summary>
        public IReadOnlyList<BillingPaymentMethodData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
