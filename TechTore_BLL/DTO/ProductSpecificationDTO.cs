using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ProductSpecificationDTO
    {
        public int SpecificationId { get; set; }

        public int? ProductId { get; set; }

        public string? SpecificationName { get; set; }

        public string? SpecificationValue { get; set; }
    }

}