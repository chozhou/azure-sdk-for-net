// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class ManagedHsmPrivateLinkResourceListResult
    {
        internal static ManagedHsmPrivateLinkResourceListResult DeserializeManagedHsmPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedHsmPrivateLinkResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedHsmPrivateLinkResource> array = new List<ManagedHsmPrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmPrivateLinkResource.DeserializeManagedHsmPrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ManagedHsmPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
