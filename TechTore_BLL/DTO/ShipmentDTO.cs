using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ShipmentDTO
    {
        public int ShipmentId { get; set; }

        public int? OrderId { get; set; }

        public byte[] ShipmentDate { get; set; } = null!;

        public string? TrackingNumber { get; set; }

        public string? Status { get; set; }
    }

}