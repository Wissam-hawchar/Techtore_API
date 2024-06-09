using System;
using System.Collections.Generic;

namespace TechTore_DAL.Models;

public partial class Faq
{
    public int Faqid { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }
}
