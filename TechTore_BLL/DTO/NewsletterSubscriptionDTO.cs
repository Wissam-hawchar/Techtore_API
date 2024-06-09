using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class NewsletterSubscriptionDTO
    {
        public int SubscriptionId { get; set; }

        public int? UserId { get; set; }

        public string? Email { get; set; }

        public byte[] SubscriptionDate { get; set; } = null!;
    }

}