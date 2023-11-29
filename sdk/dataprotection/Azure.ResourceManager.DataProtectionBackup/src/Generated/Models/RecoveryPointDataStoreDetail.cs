// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> RecoveryPoint datastore details. </summary>
    public partial class RecoveryPointDataStoreDetail
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPointDataStoreDetail"/>. </summary>
        public RecoveryPointDataStoreDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPointDataStoreDetail"/>. </summary>
        /// <param name="createdOn"></param>
        /// <param name="expireOn"></param>
        /// <param name="recoveryPointDataStoreId"></param>
        /// <param name="metadata"></param>
        /// <param name="state"></param>
        /// <param name="recoveryPointDataStoreType"></param>
        /// <param name="isVisible"></param>
        /// <param name="rehydrationExpireOn"></param>
        /// <param name="rehydrationStatus"></param>
        internal RecoveryPointDataStoreDetail(DateTimeOffset? createdOn, DateTimeOffset? expireOn, Guid? recoveryPointDataStoreId, string metadata, string state, string recoveryPointDataStoreType, bool? isVisible, DateTimeOffset? rehydrationExpireOn, RecoveryPointDataStoreRehydrationStatus? rehydrationStatus)
        {
            CreatedOn = createdOn;
            ExpireOn = expireOn;
            RecoveryPointDataStoreId = recoveryPointDataStoreId;
            Metadata = metadata;
            State = state;
            RecoveryPointDataStoreType = recoveryPointDataStoreType;
            IsVisible = isVisible;
            RehydrationExpireOn = rehydrationExpireOn;
            RehydrationStatus = rehydrationStatus;
        }

        /// <summary> Gets or sets the created on. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Gets or sets the expire on. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Gets or sets the recovery point data store id. </summary>
        public Guid? RecoveryPointDataStoreId { get; set; }
        /// <summary> Gets or sets the metadata. </summary>
        public string Metadata { get; set; }
        /// <summary> Gets or sets the state. </summary>
        public string State { get; set; }
        /// <summary> Gets or sets the recovery point data store type. </summary>
        public string RecoveryPointDataStoreType { get; set; }
        /// <summary> Gets or sets the is visible. </summary>
        public bool? IsVisible { get; set; }
        /// <summary> Gets the rehydration expire on. </summary>
        public DateTimeOffset? RehydrationExpireOn { get; }
        /// <summary> Gets the rehydration status. </summary>
        public RecoveryPointDataStoreRehydrationStatus? RehydrationStatus { get; }
    }
}
