// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptContentCurrentConnection. </summary>
    public partial class KqlScriptContentCurrentConnection
    {
        /// <summary> Initializes a new instance of <see cref="KqlScriptContentCurrentConnection"/>. </summary>
        public KqlScriptContentCurrentConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KqlScriptContentCurrentConnection"/>. </summary>
        /// <param name="name"></param>
        /// <param name="poolName"></param>
        /// <param name="databaseName"></param>
        /// <param name="type"></param>
        internal KqlScriptContentCurrentConnection(string name, string poolName, string databaseName, string type)
        {
            Name = name;
            PoolName = poolName;
            DatabaseName = databaseName;
            Type = type;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the pool name. </summary>
        public string PoolName { get; set; }
        /// <summary> Gets or sets the database name. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
    }
}
