// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> List Restore Ranges Request. </summary>
    public partial class BackupFindRestorableTimeRangeContent
    {
        /// <summary> Initializes a new instance of <see cref="BackupFindRestorableTimeRangeContent"/>. </summary>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        public BackupFindRestorableTimeRangeContent(RestoreSourceDataStoreType sourceDataStoreType)
        {
            SourceDataStoreType = sourceDataStoreType;
        }

        /// <summary> Gets or sets the type of the source data store. </summary>
        public RestoreSourceDataStoreType SourceDataStoreType { get; }
        /// <summary> Start time for the List Restore Ranges request. ISO 8601 format. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time for the List Restore Ranges request. ISO 8601 format. </summary>
        public DateTimeOffset? EndOn { get; set; }
    }
}
