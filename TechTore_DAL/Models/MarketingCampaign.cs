using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class MarketingCampaign
{
    public int CampaignId { get; set; }

    public int? UserId { get; set; }

    public string? CampaignName { get; set; }

    public string? Description { get; set; }

    public byte[] EndDate { get; set; } = null!;

    public decimal? Budget { get; set; }

    public string? Status { get; set; }

    public virtual User? User { get; set; }
}
