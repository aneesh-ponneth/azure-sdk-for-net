// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Instructions for rendering the data. </summary>
    public partial class DiagnosticDataRendering
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticDataRendering"/>. </summary>
        public DiagnosticDataRendering()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticDataRendering"/>. </summary>
        /// <param name="renderingType"> Rendering Type. </param>
        /// <param name="title"> Title of data. </param>
        /// <param name="description"> Description of the data that will help it be interpreted. </param>
        internal DiagnosticDataRendering(DiagnosticDataRenderingType? renderingType, string title, string description)
        {
            RenderingType = renderingType;
            Title = title;
            Description = description;
        }

        /// <summary> Rendering Type. </summary>
        public DiagnosticDataRenderingType? RenderingType { get; set; }
        /// <summary> Title of data. </summary>
        public string Title { get; set; }
        /// <summary> Description of the data that will help it be interpreted. </summary>
        public string Description { get; set; }
    }
}
