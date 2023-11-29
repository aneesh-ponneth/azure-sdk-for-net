// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Key Vault linked service. </summary>
    public partial class AzureKeyVaultLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureKeyVaultLinkedService"/>. </summary>
        /// <param name="baseUrl"> The base URL of the Azure Key Vault. e.g. https://myakv.vault.azure.net Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="baseUrl"/> is null. </exception>
        public AzureKeyVaultLinkedService(object baseUrl)
        {
            Argument.AssertNotNull(baseUrl, nameof(baseUrl));

            BaseUrl = baseUrl;
            Type = "AzureKeyVault";
        }

        /// <summary> Initializes a new instance of <see cref="AzureKeyVaultLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="baseUrl"> The base URL of the Azure Key Vault. e.g. https://myakv.vault.azure.net Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureKeyVaultLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object baseUrl, CredentialReference credential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            BaseUrl = baseUrl;
            Credential = credential;
            Type = type ?? "AzureKeyVault";
        }

        /// <summary> The base URL of the Azure Key Vault. e.g. https://myakv.vault.azure.net Type: string (or Expression with resultType string). </summary>
        public object BaseUrl { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
