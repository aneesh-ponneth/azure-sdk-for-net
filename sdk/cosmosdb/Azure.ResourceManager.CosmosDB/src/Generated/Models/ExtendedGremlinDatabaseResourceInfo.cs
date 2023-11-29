// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedGremlinDatabaseResourceInfo. </summary>
    public partial class ExtendedGremlinDatabaseResourceInfo : GremlinDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedGremlinDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB Gremlin database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public ExtendedGremlinDatabaseResourceInfo(string databaseName) : base(databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedGremlinDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB Gremlin database. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedGremlinDatabaseResourceInfo(string databaseName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, string rid, float? timestamp, ETag? etag) : base(databaseName, restoreParameters, createMode)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
