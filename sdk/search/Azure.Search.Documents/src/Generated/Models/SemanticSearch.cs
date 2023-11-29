// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines parameters for a search index that influence semantic capabilities. </summary>
    public partial class SemanticSearch
    {
        /// <summary> Initializes a new instance of <see cref="SemanticSearch"/>. </summary>
        public SemanticSearch()
        {
            Configurations = new ChangeTrackingList<SemanticConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="SemanticSearch"/>. </summary>
        /// <param name="defaultConfigurationName"> Allows you to set the name of a default semantic configuration in your index, making it optional to pass it on as a query parameter every time. </param>
        /// <param name="configurations"> The semantic configurations for the index. </param>
        internal SemanticSearch(string defaultConfigurationName, IList<SemanticConfiguration> configurations)
        {
            DefaultConfigurationName = defaultConfigurationName;
            Configurations = configurations;
        }

        /// <summary> Allows you to set the name of a default semantic configuration in your index, making it optional to pass it on as a query parameter every time. </summary>
        public string DefaultConfigurationName { get; set; }
        /// <summary> The semantic configurations for the index. </summary>
        public IList<SemanticConfiguration> Configurations { get; }
    }
}
