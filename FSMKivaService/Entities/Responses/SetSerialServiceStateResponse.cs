using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSMKivaService.Entities.Responses
{
    public class SetSerialServiceStateResponse
    {
        [JsonPropertyName("isSuccess")] public bool isSuccess { get; set; }
        [JsonPropertyName("Message")] public string Message { get; set; }
    }
}
