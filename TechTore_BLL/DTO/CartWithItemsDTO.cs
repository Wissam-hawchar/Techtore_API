using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTore_DAL.Models;

namespace _TechTore_BLL.DTO
{
    public class CartWithItemsDTO
    {
        public int CartId { get; set; }

        public int? UserId { get; set; }

        public byte[] CartDate { get; set; } = null!;

        public virtual ICollection<CartItemDTO> CartItems { get; set; } = new List<CartItemDTO>();
    }
}
