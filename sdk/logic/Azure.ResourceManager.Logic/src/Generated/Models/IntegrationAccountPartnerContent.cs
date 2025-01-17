// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account partner content. </summary>
    public partial class IntegrationAccountPartnerContent
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountPartnerContent"/>. </summary>
        public IntegrationAccountPartnerContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountPartnerContent"/>. </summary>
        /// <param name="b2b"> The B2B partner content. </param>
        internal IntegrationAccountPartnerContent(B2BPartnerContent b2b)
        {
            B2B = b2b;
        }

        /// <summary> The B2B partner content. </summary>
        internal B2BPartnerContent B2B { get; set; }
        /// <summary> The list of partner business identities. </summary>
        public IList<IntegrationAccountBusinessIdentity> B2BBusinessIdentities
        {
            get
            {
                if (B2B is null)
                    B2B = new B2BPartnerContent();
                return B2B.BusinessIdentities;
            }
        }
    }
}
