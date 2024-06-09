using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Discount
{
    public int DiscountId { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? DiscountPercentage { get; set; }

    public byte[] EndDate { get; set; } = null!;

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
