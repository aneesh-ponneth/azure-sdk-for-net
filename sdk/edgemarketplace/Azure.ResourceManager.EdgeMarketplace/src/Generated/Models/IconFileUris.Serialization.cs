// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeMarketplace.Models
{
    public partial class IconFileUris
    {
        internal static IconFileUris DeserializeIconFileUris(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> small = default;
            Optional<string> medium = default;
            Optional<string> wide = default;
            Optional<string> large = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("small"u8))
                {
                    small = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("medium"u8))
                {
                    medium = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wide"u8))
                {
                    wide = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("large"u8))
                {
                    large = property.Value.GetString();
                    continue;
                }
            }
            return new IconFileUris(small.Value, medium.Value, wide.Value, large.Value);
        }
    }
}
