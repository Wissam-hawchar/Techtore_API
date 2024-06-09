using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class UserRatingDTO
    {
        public int UserRatingId { get; set; }

        public int? UserId { get; set; }

        public int? Rating { get; set; }

        public string? Comment { get; set; }

        public byte[] RatingDate { get; set; } = null!;
    }

}