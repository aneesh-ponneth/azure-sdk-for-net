// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> storage resource of type Azure Storage Account. </summary>
    public partial class AppPlatformStorageAccount : AppPlatformStorageProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformStorageAccount"/>. </summary>
        /// <param name="accountName"> The account name of the Azure Storage Account. </param>
        /// <param name="accountKey"> The account key of the Azure Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="accountKey"/> is null. </exception>
        public AppPlatformStorageAccount(string accountName, string accountKey)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(accountKey, nameof(accountKey));

            AccountName = accountName;
            AccountKey = accountKey;
            StorageType = StorageType.StorageAccount;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformStorageAccount"/>. </summary>
        /// <param name="storageType"> The type of the storage. </param>
        /// <param name="accountName"> The account name of the Azure Storage Account. </param>
        /// <param name="accountKey"> The account key of the Azure Storage Account. </param>
        internal AppPlatformStorageAccount(StorageType storageType, string accountName, string accountKey) : base(storageType)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            StorageType = storageType;
        }

        /// <summary> The account name of the Azure Storage Account. </summary>
        public string AccountName { get; set; }
        /// <summary> The account key of the Azure Storage Account. </summary>
        public string AccountKey { get; set; }
    }
}
