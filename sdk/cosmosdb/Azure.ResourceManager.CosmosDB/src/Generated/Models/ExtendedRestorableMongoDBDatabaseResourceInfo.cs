// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB MongoDB database event. </summary>
    public partial class ExtendedRestorableMongoDBDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableMongoDBDatabaseResourceInfo"/>. </summary>
        internal ExtendedRestorableMongoDBDatabaseResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableMongoDBDatabaseResourceInfo"/>. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this database event. </param>
        /// <param name="eventTimestamp"> The time when this database event happened. </param>
        /// <param name="databaseName"> The name of this MongoDB database. </param>
        /// <param name="databaseId"> The resource ID of this MongoDB database. </param>
        internal ExtendedRestorableMongoDBDatabaseResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string databaseName, string databaseId)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            DatabaseName = databaseName;
            DatabaseId = databaseId;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this database event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this database event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of this MongoDB database. </summary>
        public string DatabaseName { get; }
        /// <summary> The resource ID of this MongoDB database. </summary>
        public string DatabaseId { get; }
    }
}
