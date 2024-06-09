using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class NewsletterSubscription
{
    public int SubscriptionId { get; set; }

    public int? UserId { get; set; }

    public string? Email { get; set; }

    public byte[] SubscriptionDate { get; set; } = null!;

    public virtual User? User { get; set; }
}
