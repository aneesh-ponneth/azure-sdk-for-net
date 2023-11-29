// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The API backend service. </summary>
    internal partial class LogicApiResourceBackendService
    {
        /// <summary> Initializes a new instance of <see cref="LogicApiResourceBackendService"/>. </summary>
        internal LogicApiResourceBackendService()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicApiResourceBackendService"/>. </summary>
        /// <param name="serviceUri"> The service URL. </param>
        internal LogicApiResourceBackendService(Uri serviceUri)
        {
            ServiceUri = serviceUri;
        }

        /// <summary> The service URL. </summary>
        public Uri ServiceUri { get; }
    }
}
