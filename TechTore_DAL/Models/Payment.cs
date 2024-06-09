using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? OrderId { get; set; }

    public byte[] PaymentDate { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Order? Order { get; set; }
}
