// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Generate SSO Url operations response details. </summary>
    public partial class GenerateSsoUriResult
    {
        /// <summary> Initializes a new instance of <see cref="GenerateSsoUriResult"/>. </summary>
        internal GenerateSsoUriResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GenerateSsoUriResult"/>. </summary>
        /// <param name="value"> Redirect Url containing the SSO URL value. </param>
        internal GenerateSsoUriResult(string value)
        {
            Value = value;
        }

        /// <summary> Redirect Url containing the SSO URL value. </summary>
        public string Value { get; }
    }
}
