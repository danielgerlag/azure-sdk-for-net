// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetInstanceViewStatusesSummary
    {
        internal static VirtualMachineScaleSetInstanceViewStatusesSummary DeserializeVirtualMachineScaleSetInstanceViewStatusesSummary(JsonElement element)
        {
            IReadOnlyList<VirtualMachineStatusCodeCount> statusesSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusesSummary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineStatusCodeCount> array = new List<VirtualMachineStatusCodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineStatusCodeCount.DeserializeVirtualMachineStatusCodeCount(item));
                        }
                    }
                    statusesSummary = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetInstanceViewStatusesSummary(statusesSummary);
        }
    }
}