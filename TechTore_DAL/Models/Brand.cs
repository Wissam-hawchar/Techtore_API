﻿using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string? BrandName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
