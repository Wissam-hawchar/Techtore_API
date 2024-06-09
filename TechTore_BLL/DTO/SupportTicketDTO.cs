using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class SupportTicketDTO
    {
        public int TicketId { get; set; }

        public int? UserId { get; set; }

        public string? Subject { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }

        public byte[] DateClosed { get; set; } = null!;
    }

}