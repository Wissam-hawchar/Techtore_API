﻿using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public byte[] ReviewDate { get; set; } = null!;

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
