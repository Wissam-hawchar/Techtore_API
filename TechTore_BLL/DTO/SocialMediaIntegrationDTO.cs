using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class SocialMediaIntegrationDTO
    {
        public int SocialMediaId { get; set; }

        public int? UserId { get; set; }

        public string? Platform { get; set; }

        public string? ProfileLink { get; set; }
    }

}