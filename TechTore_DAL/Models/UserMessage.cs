using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class UserMessage
{
    public int MessageId { get; set; }

    public int? SenderId { get; set; }

    public int? ReceiverId { get; set; }

    public string? MessageContent { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual User? Receiver { get; set; }

    public virtual User? Sender { get; set; }
}
