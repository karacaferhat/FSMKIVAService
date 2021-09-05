using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSMKivaService.Entities.Responses
{
    public class GetSerialStateResponse
    {
        [JsonPropertyName("kod")] public string Code { get; set; }
        [JsonPropertyName("ad")] public string Name { get; set; }
        [JsonPropertyName("durum")] public string State { get; set; }
    }
}
