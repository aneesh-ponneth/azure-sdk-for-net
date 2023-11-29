// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Base type for List return in our api. </summary>
    internal partial class SupportedFileFormats
    {
        /// <summary> Initializes a new instance of <see cref="SupportedFileFormats"/>. </summary>
        /// <param name="value"> list of objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SupportedFileFormats(IEnumerable<DocumentTranslationFileFormat> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SupportedFileFormats"/>. </summary>
        /// <param name="value"> list of objects. </param>
        internal SupportedFileFormats(IReadOnlyList<DocumentTranslationFileFormat> value)
        {
            Value = value;
        }

        /// <summary> list of objects. </summary>
        public IReadOnlyList<DocumentTranslationFileFormat> Value { get; }
    }
}
