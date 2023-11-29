// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Properties of the Dynatrace environment. </summary>
    public partial class DynatraceEnvironmentProperties
    {
        /// <summary> Initializes a new instance of <see cref="DynatraceEnvironmentProperties"/>. </summary>
        public DynatraceEnvironmentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceEnvironmentProperties"/>. </summary>
        /// <param name="userId"> User id. </param>
        /// <param name="accountInfo"> Dynatrace Account Information. </param>
        /// <param name="environmentInfo"> Dynatrace Environment Information. </param>
        /// <param name="singleSignOnProperties"> The details of a Dynatrace single sign-on. </param>
        internal DynatraceEnvironmentProperties(string userId, DynatraceAccountInfo accountInfo, DynatraceEnvironmentInfo environmentInfo, DynatraceSingleSignOnProperties singleSignOnProperties)
        {
            UserId = userId;
            AccountInfo = accountInfo;
            EnvironmentInfo = environmentInfo;
            SingleSignOnProperties = singleSignOnProperties;
        }

        /// <summary> User id. </summary>
        public string UserId { get; set; }
        /// <summary> Dynatrace Account Information. </summary>
        public DynatraceAccountInfo AccountInfo { get; set; }
        /// <summary> Dynatrace Environment Information. </summary>
        public DynatraceEnvironmentInfo EnvironmentInfo { get; set; }
        /// <summary> The details of a Dynatrace single sign-on. </summary>
        public DynatraceSingleSignOnProperties SingleSignOnProperties { get; set; }
    }
}
