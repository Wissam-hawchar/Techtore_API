using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class WishlistDTO
    {
        public int WishlistId { get; set; }

        public int? UserId { get; set; }

        public byte[] WishlistDate { get; set; } = null!;
    }

}