// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Parent resource information. </summary>
    internal partial class ManagedByInfo
    {
        /// <summary> Initializes a new instance of <see cref="ManagedByInfo"/>. </summary>
        public ManagedByInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedByInfo"/>. </summary>
        /// <param name="resourceId"> Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use. </param>
        internal ManagedByInfo(ResourceIdentifier resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary> Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
