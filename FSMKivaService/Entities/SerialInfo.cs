using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FSMKivaService.Entities
{
    [Keyless]
    public class SerialInfo
    {
        [Column(name: "material_id")] public long MaterialId { get; set; }
        [Column(name: "kod")] public string Code { get; set; }
        [Column(name: "ad")] public string Name { get; set; }
        [Column(name: "guc")] public string Power { get; set; }
        [Column(name: "devir")] public string Rpm { get; set; }
        [Column(name: "govde")] public string Body { get; set; }
        [Column(name: "uretimtar")] public string ProdectionDate { get; set; }
        [Column(name: "verimsinifi")] public string EfficencyClass { get; set; }
        [Column(name: "yapisekli")] public string StructureType { get; set; }
        [Column(name: "frekans")] public string Frequency { get; set; }
        [Column(name: "gerilim")] public string Voltage { get; set; }
    }
}
