using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class OrderDTO
    {
        public int OrderId { get; set; }

        public int? UserId { get; set; }

        public byte[] OrderDate { get; set; } = null!;

        public decimal? TotalAmount { get; set; }
    }

}