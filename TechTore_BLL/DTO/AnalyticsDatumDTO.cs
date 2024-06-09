using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class AnalyticsDatumDTO
    {
        public int AnalyticsId { get; set; }

        public int? UserId { get; set; }

        public string? PageVisited { get; set; }

        public byte[] Timestamp { get; set; } = null!;

        public string? DeviceType { get; set; }

        public string? Browser { get; set; }
    }
}