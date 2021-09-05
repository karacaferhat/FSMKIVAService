using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FSMKivaService.Entities
{
    [Keyless]
    public class SerialState
    {
        [Column(name: "kod")] public string Code { get; set; }
        [Column(name: "ad")] public string Name { get; set; }
        [Column(name: "durum")] public string State { get; set; }
    }
}
