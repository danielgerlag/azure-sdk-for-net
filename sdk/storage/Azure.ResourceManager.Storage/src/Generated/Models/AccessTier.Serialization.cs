// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static class AccessTierExtensions
    {
        public static string ToSerialString(this AccessTier value) => value switch
        {
            AccessTier.Hot => "Hot",
            AccessTier.Cool => "Cool",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessTier value.")
        };

        public static AccessTier ToAccessTier(this string value)
        {
            if (string.Equals(value, "Hot", StringComparison.InvariantCultureIgnoreCase)) return AccessTier.Hot;
            if (string.Equals(value, "Cool", StringComparison.InvariantCultureIgnoreCase)) return AccessTier.Cool;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessTier value.");
        }
    }
}