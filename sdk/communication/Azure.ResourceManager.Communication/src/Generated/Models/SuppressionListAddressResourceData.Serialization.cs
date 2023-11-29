// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Communication
{
    public partial class SuppressionListAddressResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SuppressionListAddressResourceData DeserializeSuppressionListAddressResourceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> email = default;
            Optional<string> firstName = default;
            Optional<string> lastName = default;
            Optional<string> notes = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<string> dataLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firstName"u8))
                        {
                            firstName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastName"u8))
                        {
                            lastName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("dataLocation"u8))
                        {
                            dataLocation = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SuppressionListAddressResourceData(id, name, type, systemData.Value, email.Value, firstName.Value, lastName.Value, notes.Value, Optional.ToNullable(lastModified), dataLocation.Value);
        }
    }
}
