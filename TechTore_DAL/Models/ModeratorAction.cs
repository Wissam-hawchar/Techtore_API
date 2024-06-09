using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class ModeratorAction
{
    public int ActionId { get; set; }

    public int? ModeratorId { get; set; }

    public int? TargetUserId { get; set; }

    public string? ActionDescription { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual User? Moderator { get; set; }

    public virtual User? TargetUser { get; set; }
}
