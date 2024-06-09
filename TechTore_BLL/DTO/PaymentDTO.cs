using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class PaymentDTO
    {
        public int PaymentId { get; set; }

        public int? OrderId { get; set; }

        public byte[] PaymentDate { get; set; } = null!;

        public decimal? Amount { get; set; }

        public string? PaymentMethod { get; set; }
    }

}