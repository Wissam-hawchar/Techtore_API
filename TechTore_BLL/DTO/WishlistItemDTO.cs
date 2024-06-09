using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class WishlistItemDTO
    {
        public int WishlistItemId { get; set; }

        public int? WishlistId { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }

        public decimal? Subtotal { get; set; }
    }

}