// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ExecuteRequestContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serviceEndpoint"u8);
            writer.WriteStringValue(ServiceEndpoint);
            writer.WritePropertyName("requestMetadata"u8);
            writer.WriteObjectValue(RequestMetadata);
            writer.WriteEndObject();
        }
    }
}
