using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int? UserId { get; set; }

    public byte[] CartDate { get; set; } = null!;

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User? User { get; set; }
}
