using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class FaqDTO
    {
        public int Faqid { get; set; }

        public string? Question { get; set; }

        public string? Answer { get; set; }
    }

}