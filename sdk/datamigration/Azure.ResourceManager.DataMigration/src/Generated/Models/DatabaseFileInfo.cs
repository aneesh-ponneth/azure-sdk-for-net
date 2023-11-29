// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database file specific information. </summary>
    public partial class DatabaseFileInfo
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseFileInfo"/>. </summary>
        internal DatabaseFileInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseFileInfo"/>. </summary>
        /// <param name="databaseName"> Name of the database. </param>
        /// <param name="id"> Unique identifier for database file. </param>
        /// <param name="logicalName"> Logical name of the file. </param>
        /// <param name="physicalFullName"> Operating-system full path of the file. </param>
        /// <param name="restoreFullName"> Suggested full path of the file for restoring. </param>
        /// <param name="fileType"> Database file type. </param>
        /// <param name="sizeMB"> Size of the file in megabytes. </param>
        internal DatabaseFileInfo(string databaseName, string id, string logicalName, string physicalFullName, string restoreFullName, DatabaseFileType? fileType, double? sizeMB)
        {
            DatabaseName = databaseName;
            Id = id;
            LogicalName = logicalName;
            PhysicalFullName = physicalFullName;
            RestoreFullName = restoreFullName;
            FileType = fileType;
            SizeMB = sizeMB;
        }

        /// <summary> Name of the database. </summary>
        public string DatabaseName { get; }
        /// <summary> Unique identifier for database file. </summary>
        public string Id { get; }
        /// <summary> Logical name of the file. </summary>
        public string LogicalName { get; }
        /// <summary> Operating-system full path of the file. </summary>
        public string PhysicalFullName { get; }
        /// <summary> Suggested full path of the file for restoring. </summary>
        public string RestoreFullName { get; }
        /// <summary> Database file type. </summary>
        public DatabaseFileType? FileType { get; }
        /// <summary> Size of the file in megabytes. </summary>
        public double? SizeMB { get; }
    }
}
