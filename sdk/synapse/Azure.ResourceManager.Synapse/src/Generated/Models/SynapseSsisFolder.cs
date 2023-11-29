// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Ssis folder. </summary>
    public partial class SynapseSsisFolder : SynapseSsisObjectMetadata
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSsisFolder"/>. </summary>
        internal SynapseSsisFolder()
        {
            MetadataType = SynapseSsisObjectMetadataType.Folder;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSsisFolder"/>. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        internal SynapseSsisFolder(SynapseSsisObjectMetadataType metadataType, long? id, string name, string description) : base(metadataType, id, name, description)
        {
            MetadataType = metadataType;
        }
    }
}
