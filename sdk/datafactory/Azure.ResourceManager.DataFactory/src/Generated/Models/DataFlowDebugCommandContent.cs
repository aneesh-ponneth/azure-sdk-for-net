// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Request body structure for data flow debug command. </summary>
    public partial class DataFlowDebugCommandContent
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandContent"/>. </summary>
        public DataFlowDebugCommandContent()
        {
        }

        /// <summary> The ID of data flow debug session. </summary>
        public Guid? SessionId { get; set; }
        /// <summary> The command type. </summary>
        public DataFlowDebugCommandType? Command { get; set; }
        /// <summary> The command payload object. </summary>
        public DataFlowDebugCommandPayload CommandPayload { get; set; }
    }
}
