using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ProductTagDTO
    {
        public int TagId { get; set; }

        public int? ProductId { get; set; }

        public string? TagName { get; set; }

    }

}