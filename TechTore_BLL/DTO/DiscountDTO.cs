using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class Discount
    {
        public int DiscountId { get; set; }

        public int? UserId { get; set; }

        public int? ProductId { get; set; }

        public int? DiscountPercentage { get; set; }

        public byte[] EndDate { get; set; } = null!;
    }

}