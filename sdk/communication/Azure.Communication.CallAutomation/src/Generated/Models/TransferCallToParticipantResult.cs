// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for transferring the call. </summary>
    public partial class TransferCallToParticipantResult
    {
        /// <summary> Initializes a new instance of <see cref="TransferCallToParticipantResult"/>. </summary>
        internal TransferCallToParticipantResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TransferCallToParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal TransferCallToParticipantResult(string operationContext)
        {
            OperationContext = operationContext;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
