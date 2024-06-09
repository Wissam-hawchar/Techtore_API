using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class AnalyticsDatum
{
    public int AnalyticsId { get; set; }

    public int? UserId { get; set; }

    public string? PageVisited { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? DeviceType { get; set; }

    public string? Browser { get; set; }

    public virtual User? User { get; set; }
}
