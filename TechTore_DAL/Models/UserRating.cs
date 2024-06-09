using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class UserRating
{
    public int UserRatingId { get; set; }

    public int? UserId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public byte[] RatingDate { get; set; } = null!;

    public virtual User? User { get; set; }
}
