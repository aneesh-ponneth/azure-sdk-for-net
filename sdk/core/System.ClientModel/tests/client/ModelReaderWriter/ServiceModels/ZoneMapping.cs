// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    /// <summary> The ZoneMapping. </summary>
    public partial class ZoneMapping
    {
        /// <summary> Initializes a new instance of ZoneMapping. </summary>
        internal ZoneMapping()
        {
            Zones = new OptionalList<string>();
        }

        /// <summary> Initializes a new instance of ZoneMapping. </summary>
        /// <param name="location"> The location of the zone mapping. </param>
        /// <param name="zones"></param>
        internal ZoneMapping(string location, IReadOnlyList<string> zones)
        {
            Location = location;
            Zones = zones;
        }

        /// <summary> The location of the zone mapping. </summary>
        public string Location { get; }
        /// <summary> Gets the zones. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
