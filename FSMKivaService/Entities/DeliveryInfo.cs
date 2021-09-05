using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FSMKivaService.Entities
{
    [Keyless]
    public class DeliveryInfo
    {
        [Column(name: "serino")]public string SerialNo { get; set; }
        [Column(name: "kod")] public string Material { get; set; }
        [Column(name: "ad")] public string Name { get; set; }
    }
}
