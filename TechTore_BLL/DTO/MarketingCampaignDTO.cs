using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class MarketingCampaignDTO
    {
        public int CampaignId { get; set; }

        public int? UserId { get; set; }

        public string? CampaignName { get; set; }

        public string? Description { get; set; }

        public byte[] EndDate { get; set; } = null!;

        public decimal? Budget { get; set; }

        public string? Status { get; set; }
    }

}