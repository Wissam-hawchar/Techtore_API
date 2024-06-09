using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class ProductSpecification
{
    public int SpecificationId { get; set; }

    public int? ProductId { get; set; }

    public string? SpecificationName { get; set; }

    public string? SpecificationValue { get; set; }

    public virtual Product? Product { get; set; }
}
