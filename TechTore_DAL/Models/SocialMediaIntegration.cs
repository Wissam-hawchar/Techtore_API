using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class SocialMediaIntegration
{
    public int SocialMediaId { get; set; }

    public int? UserId { get; set; }

    public string? Platform { get; set; }

    public string? ProfileLink { get; set; }

    public virtual User? User { get; set; }
}
