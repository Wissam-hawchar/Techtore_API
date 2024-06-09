using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Wishlist
{
    public int WishlistId { get; set; }

    public int? UserId { get; set; }

    public byte[] WishlistDate { get; set; } = null!;

    public virtual User? User { get; set; }

    public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
}
