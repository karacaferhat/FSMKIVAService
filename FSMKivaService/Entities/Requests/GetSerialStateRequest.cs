using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSMKivaService.Entities.Requests
{
    public class GetSerialStateRequest
    {
        [JsonPropertyName("serialno"), MaxLength(25)]public string SerialNo { get; set; }
    }
}
