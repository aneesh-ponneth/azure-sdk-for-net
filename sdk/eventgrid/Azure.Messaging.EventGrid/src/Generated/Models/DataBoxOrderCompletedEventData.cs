// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.DataBox.OrderCompleted event. </summary>
    public partial class DataBoxOrderCompletedEventData
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxOrderCompletedEventData"/>. </summary>
        internal DataBoxOrderCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxOrderCompletedEventData"/>. </summary>
        /// <param name="serialNumber"> Serial Number of the device associated with the event. The list is comma separated if more than one serial number is associated. </param>
        /// <param name="stageName"> Name of the current Stage. </param>
        /// <param name="stageTime"> The time at which the stage happened. </param>
        internal DataBoxOrderCompletedEventData(string serialNumber, DataBoxStageName? stageName, DateTimeOffset? stageTime)
        {
            SerialNumber = serialNumber;
            StageName = stageName;
            StageTime = stageTime;
        }

        /// <summary> Serial Number of the device associated with the event. The list is comma separated if more than one serial number is associated. </summary>
        public string SerialNumber { get; }
        /// <summary> Name of the current Stage. </summary>
        public DataBoxStageName? StageName { get; }
        /// <summary> The time at which the stage happened. </summary>
        public DateTimeOffset? StageTime { get; }
    }
}
