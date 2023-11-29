// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of CodeVersion entities. </summary>
    internal partial class CodeVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of <see cref="CodeVersionResourceArmPaginatedResult"/>. </summary>
        internal CodeVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningCodeVersionData>();
        }

        /// <summary> Initializes a new instance of <see cref="CodeVersionResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of CodeVersion objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type CodeVersion. </param>
        internal CodeVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningCodeVersionData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of CodeVersion objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type CodeVersion. </summary>
        public IReadOnlyList<MachineLearningCodeVersionData> Value { get; }
    }
}
