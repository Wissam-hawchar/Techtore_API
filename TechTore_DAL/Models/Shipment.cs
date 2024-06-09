using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public int? OrderId { get; set; }

    public byte[] ShipmentDate { get; set; } = null!;

    public string? TrackingNumber { get; set; }

    public string? Status { get; set; }

    public virtual Order? Order { get; set; }
}
