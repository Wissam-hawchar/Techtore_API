using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ProductDTO
    {
        public int ProductId { get; set; }

        public int? CategoryId { get; set; }

        public int? BrandId { get; set; }

        public string? ProductName { get; set; }

        public decimal? Price { get; set; }

        public int? StockQuantity { get; set; }

        public string? Description { get; set; }
    }

}