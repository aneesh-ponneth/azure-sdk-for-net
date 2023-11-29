// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Database level key used for encryption at rest. </summary>
    public partial class SqlDatabaseKey
    {
        /// <summary> Initializes a new instance of <see cref="SqlDatabaseKey"/>. </summary>
        public SqlDatabaseKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseKey"/>. </summary>
        /// <param name="keyType"> The database key type. Only supported value is 'AzureKeyVault'. </param>
        /// <param name="thumbprint"> Thumbprint of the database key. </param>
        /// <param name="createdOn"> The database key creation date. </param>
        /// <param name="subregion"> Subregion of the server key. </param>
        internal SqlDatabaseKey(SqlDatabaseKeyType? keyType, string thumbprint, DateTimeOffset? createdOn, string subregion)
        {
            KeyType = keyType;
            Thumbprint = thumbprint;
            CreatedOn = createdOn;
            Subregion = subregion;
        }

        /// <summary> The database key type. Only supported value is 'AzureKeyVault'. </summary>
        public SqlDatabaseKeyType? KeyType { get; }
        /// <summary> Thumbprint of the database key. </summary>
        public string Thumbprint { get; }
        /// <summary> The database key creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Subregion of the server key. </summary>
        public string Subregion { get; }
    }
}
