// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the AzureFirewallRCAction. </summary>
    internal partial class AzureFirewallRCAction
    {
        /// <summary> Initializes a new instance of <see cref="AzureFirewallRCAction"/>. </summary>
        public AzureFirewallRCAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallRCAction"/>. </summary>
        /// <param name="actionType"> The type of action. </param>
        internal AzureFirewallRCAction(AzureFirewallRCActionType? actionType)
        {
            ActionType = actionType;
        }

        /// <summary> The type of action. </summary>
        public AzureFirewallRCActionType? ActionType { get; set; }
    }
}
