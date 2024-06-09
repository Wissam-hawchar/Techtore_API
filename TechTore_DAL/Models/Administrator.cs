using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Administrator
{
    public int AdminId { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
