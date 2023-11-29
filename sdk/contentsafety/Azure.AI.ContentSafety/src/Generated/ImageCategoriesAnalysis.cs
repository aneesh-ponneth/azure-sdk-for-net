// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.ContentSafety
{
    /// <summary> Image analysis result. </summary>
    public partial class ImageCategoriesAnalysis
    {
        /// <summary> Initializes a new instance of <see cref="ImageCategoriesAnalysis"/>. </summary>
        /// <param name="category"> The image analysis category. </param>
        internal ImageCategoriesAnalysis(ImageCategory category)
        {
            Category = category;
        }

        /// <summary> Initializes a new instance of <see cref="ImageCategoriesAnalysis"/>. </summary>
        /// <param name="category"> The image analysis category. </param>
        /// <param name="severity"> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’, and the output value can be 0, 2, 4, 6. </param>
        internal ImageCategoriesAnalysis(ImageCategory category, int? severity)
        {
            Category = category;
            Severity = severity;
        }

        /// <summary> The image analysis category. </summary>
        public ImageCategory Category { get; }
        /// <summary> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’, and the output value can be 0, 2, 4, 6. </summary>
        public int? Severity { get; }
    }
}
