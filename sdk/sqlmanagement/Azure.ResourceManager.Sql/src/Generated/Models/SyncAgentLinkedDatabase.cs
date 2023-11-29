// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An Azure SQL Database sync agent linked database. </summary>
    public partial class SyncAgentLinkedDatabase : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SyncAgentLinkedDatabase"/>. </summary>
        public SyncAgentLinkedDatabase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SyncAgentLinkedDatabase"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseType"> Type of the sync agent linked database. </param>
        /// <param name="databaseId"> Id of the sync agent linked database. </param>
        /// <param name="description"> Description of the sync agent linked database. </param>
        /// <param name="serverName"> Server name of the sync agent linked database. </param>
        /// <param name="databaseName"> Database name of the sync agent linked database. </param>
        /// <param name="userName"> User name of the sync agent linked database. </param>
        internal SyncAgentLinkedDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SyncMemberDbType? databaseType, Guid? databaseId, string description, string serverName, string databaseName, string userName) : base(id, name, resourceType, systemData)
        {
            DatabaseType = databaseType;
            DatabaseId = databaseId;
            Description = description;
            ServerName = serverName;
            DatabaseName = databaseName;
            UserName = userName;
        }

        /// <summary> Type of the sync agent linked database. </summary>
        public SyncMemberDbType? DatabaseType { get; }
        /// <summary> Id of the sync agent linked database. </summary>
        public Guid? DatabaseId { get; }
        /// <summary> Description of the sync agent linked database. </summary>
        public string Description { get; }
        /// <summary> Server name of the sync agent linked database. </summary>
        public string ServerName { get; }
        /// <summary> Database name of the sync agent linked database. </summary>
        public string DatabaseName { get; }
        /// <summary> User name of the sync agent linked database. </summary>
        public string UserName { get; }
    }
}
