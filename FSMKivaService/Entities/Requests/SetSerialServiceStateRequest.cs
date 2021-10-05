using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSMKivaService.Entities.Requests
{
    public class SetSerialServiceStateRequest
    {
        [JsonPropertyName("serialno"), MaxLength(25)] public string SerialNo { get; set; }
        [JsonPropertyName("cari"), MaxLength(35)] public string Cari { get; set; }
        [JsonPropertyName("takipno"), MaxLength(50)] public string TakipNo { get; set; }

    }
}
