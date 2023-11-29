// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkFunction.Models
{
    /// <summary> Emission policy destination properties. </summary>
    public partial class EmissionPolicyDestination
    {
        /// <summary> Initializes a new instance of <see cref="EmissionPolicyDestination"/>. </summary>
        public EmissionPolicyDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EmissionPolicyDestination"/>. </summary>
        /// <param name="destinationType"> Emission destination type. </param>
        internal EmissionPolicyDestination(EmissionDestinationType? destinationType)
        {
            DestinationType = destinationType;
        }

        /// <summary> Emission destination type. </summary>
        public EmissionDestinationType? DestinationType { get; set; }
    }
}
