using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class SupportTicket
{
    public int TicketId { get; set; }

    public int? UserId { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public byte[] DateClosed { get; set; } = null!;

    public virtual User? User { get; set; }
}
