// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The access keys for the cognitive services account. </summary>
    public partial class ServiceAccountApiKeys
    {
        /// <summary> Initializes a new instance of <see cref="ServiceAccountApiKeys"/>. </summary>
        internal ServiceAccountApiKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountApiKeys"/>. </summary>
        /// <param name="key1"> Gets the value of key 1. </param>
        /// <param name="key2"> Gets the value of key 2. </param>
        internal ServiceAccountApiKeys(string key1, string key2)
        {
            Key1 = key1;
            Key2 = key2;
        }

        /// <summary> Gets the value of key 1. </summary>
        public string Key1 { get; }
        /// <summary> Gets the value of key 2. </summary>
        public string Key2 { get; }
    }
}
