using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ReviewDTO
    {
        public int ReviewId { get; set; }

        public int? UserId { get; set; }

        public int? ProductId { get; set; }

        public int? Rating { get; set; }

        public string? Comment { get; set; }

        public byte[] ReviewDate { get; set; } = null!;
    }

}