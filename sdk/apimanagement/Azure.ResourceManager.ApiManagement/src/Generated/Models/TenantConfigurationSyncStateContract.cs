// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Result of Tenant Configuration Sync State. </summary>
    public partial class TenantConfigurationSyncStateContract : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TenantConfigurationSyncStateContract"/>. </summary>
        public TenantConfigurationSyncStateContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TenantConfigurationSyncStateContract"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="branch"> The name of Git branch. </param>
        /// <param name="commitId"> The latest commit Id. </param>
        /// <param name="isExported"> value indicating if last sync was save (true) or deploy (false) operation. </param>
        /// <param name="isSynced"> value indicating if last synchronization was later than the configuration change. </param>
        /// <param name="isGitEnabled"> value indicating whether Git configuration access is enabled. </param>
        /// <param name="syncOn">
        /// The date of the latest synchronization. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="configurationChangeOn">
        /// The date of the latest configuration change. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="lastOperationId"> Most recent tenant configuration operation identifier. </param>
        internal TenantConfigurationSyncStateContract(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string branch, string commitId, bool? isExported, bool? isSynced, bool? isGitEnabled, DateTimeOffset? syncOn, DateTimeOffset? configurationChangeOn, string lastOperationId) : base(id, name, resourceType, systemData)
        {
            Branch = branch;
            CommitId = commitId;
            IsExported = isExported;
            IsSynced = isSynced;
            IsGitEnabled = isGitEnabled;
            SyncOn = syncOn;
            ConfigurationChangeOn = configurationChangeOn;
            LastOperationId = lastOperationId;
        }

        /// <summary> The name of Git branch. </summary>
        public string Branch { get; set; }
        /// <summary> The latest commit Id. </summary>
        public string CommitId { get; set; }
        /// <summary> value indicating if last sync was save (true) or deploy (false) operation. </summary>
        public bool? IsExported { get; set; }
        /// <summary> value indicating if last synchronization was later than the configuration change. </summary>
        public bool? IsSynced { get; set; }
        /// <summary> value indicating whether Git configuration access is enabled. </summary>
        public bool? IsGitEnabled { get; set; }
        /// <summary>
        /// The date of the latest synchronization. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? SyncOn { get; set; }
        /// <summary>
        /// The date of the latest configuration change. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? ConfigurationChangeOn { get; set; }
        /// <summary> Most recent tenant configuration operation identifier. </summary>
        public string LastOperationId { get; set; }
    }
}
