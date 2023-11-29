// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Item Level target info for restore operation. </summary>
    public partial class RangeBasedItemLevelRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of <see cref="RangeBasedItemLevelRestoreCriteria"/>. </summary>
        public RangeBasedItemLevelRestoreCriteria()
        {
            ObjectType = "RangeBasedItemLevelRestoreCriteria";
        }

        /// <summary> minimum value for range prefix match. </summary>
        public string MinMatchingValue { get; set; }
        /// <summary> maximum value for range prefix match. </summary>
        public string MaxMatchingValue { get; set; }
    }
}
