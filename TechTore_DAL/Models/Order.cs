﻿using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public byte[] OrderDate { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Payment? Payment { get; set; }

    public virtual Shipment? Shipment { get; set; }

    public virtual User? User { get; set; }
}
