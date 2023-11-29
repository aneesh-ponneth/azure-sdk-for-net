// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The storage profile. </summary>
    public partial class FlinkStorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="FlinkStorageProfile"/>. </summary>
        /// <param name="storageUriString"> Storage account uri which is used for savepoint and checkpoint state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageUriString"/> is null. </exception>
        public FlinkStorageProfile(string storageUriString)
        {
            Argument.AssertNotNull(storageUriString, nameof(storageUriString));

            StorageUriString = storageUriString;
        }

        /// <summary> Initializes a new instance of <see cref="FlinkStorageProfile"/>. </summary>
        /// <param name="storageUriString"> Storage account uri which is used for savepoint and checkpoint state. </param>
        /// <param name="storagekey"> Storage key is only required for wasb(s) storage. </param>
        internal FlinkStorageProfile(string storageUriString, string storagekey)
        {
            StorageUriString = storageUriString;
            Storagekey = storagekey;
        }

        /// <summary> Storage account uri which is used for savepoint and checkpoint state. </summary>
        public string StorageUriString { get; set; }
        /// <summary> Storage key is only required for wasb(s) storage. </summary>
        public string Storagekey { get; set; }
    }
}
