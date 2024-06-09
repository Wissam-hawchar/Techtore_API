using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class FeaturedProduct
{
    public int FeaturedProductId { get; set; }

    public int? ProductId { get; set; }

    public byte[] EndDate { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
