// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for an Entity Recognition task. </summary>
    internal partial class EntitiesTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="EntitiesTaskParameters"/>. </summary>
        public EntitiesTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntitiesTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        internal EntitiesTaskParameters(bool? loggingOptOut, string modelVersion, StringIndexType? stringIndexType) : base(loggingOptOut, modelVersion)
        {
            StringIndexType = stringIndexType;
        }

        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
