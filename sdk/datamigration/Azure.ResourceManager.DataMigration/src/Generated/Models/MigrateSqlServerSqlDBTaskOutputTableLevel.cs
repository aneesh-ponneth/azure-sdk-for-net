// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputTableLevel. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputTableLevel : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputTableLevel"/>. </summary>
        internal MigrateSqlServerSqlDBTaskOutputTableLevel()
        {
            ResultType = "TableLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputTableLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="objectName"> Name of the item. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="state"> Current state of migration. </param>
        /// <param name="statusMessage"> Status message. </param>
        /// <param name="itemsCount"> Number of items. </param>
        /// <param name="itemsCompletedCount"> Number of successfully completed items. </param>
        /// <param name="errorPrefix"> Wildcard string prefix to use for querying all errors of the item. </param>
        /// <param name="resultPrefix"> Wildcard string prefix to use for querying all sub-tem results of the item. </param>
        internal MigrateSqlServerSqlDBTaskOutputTableLevel(string id, string resultType, string objectName, DateTimeOffset? startedOn, DateTimeOffset? endedOn, MigrationState? state, string statusMessage, long? itemsCount, long? itemsCompletedCount, string errorPrefix, string resultPrefix) : base(id, resultType)
        {
            ObjectName = objectName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            State = state;
            StatusMessage = statusMessage;
            ItemsCount = itemsCount;
            ItemsCompletedCount = itemsCompletedCount;
            ErrorPrefix = errorPrefix;
            ResultPrefix = resultPrefix;
            ResultType = resultType ?? "TableLevelOutput";
        }

        /// <summary> Name of the item. </summary>
        public string ObjectName { get; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Current state of migration. </summary>
        public MigrationState? State { get; }
        /// <summary> Status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Number of items. </summary>
        public long? ItemsCount { get; }
        /// <summary> Number of successfully completed items. </summary>
        public long? ItemsCompletedCount { get; }
        /// <summary> Wildcard string prefix to use for querying all errors of the item. </summary>
        public string ErrorPrefix { get; }
        /// <summary> Wildcard string prefix to use for querying all sub-tem results of the item. </summary>
        public string ResultPrefix { get; }
    }
}
