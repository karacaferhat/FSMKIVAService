using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FSMKivaService.Entities.Responses
{
    public class GetSerialInfoResponse
    {
        [JsonPropertyName("kod")] public string Code { get; set; }
        [JsonPropertyName("ad")] public string Name { get; set; }
        [JsonPropertyName("guc")] public string Power { get; set; }
        [JsonPropertyName("devir")] public string Rpm { get; set; }
        [JsonPropertyName("govde")] public string Body { get; set; }
        [JsonPropertyName("uretimtar")] public string ProdectionDate { get; set; }
        [JsonPropertyName("verimsinifi")] public string EfficencyClass { get; set; }
        [JsonPropertyName("yapisekli")] public string StructureType { get; set; }
        [JsonPropertyName("frekans")] public string Frequency { get; set; }
        [JsonPropertyName("gerilim")] public string Voltage { get; set; }
    }
}
