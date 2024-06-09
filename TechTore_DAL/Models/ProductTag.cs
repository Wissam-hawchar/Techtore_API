using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class ProductTag
{
    public int TagId { get; set; }

    public int? ProductId { get; set; }

    public string? TagName { get; set; }

    public virtual Product? Product { get; set; }
}
