using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class UserMessageDTO
    {
        public int MessageId { get; set; }

        public int? SenderId { get; set; }

        public int? ReceiverId { get; set; }

        public string? MessageContent { get; set; }

        public byte[] Timestamp { get; set; } = null!;
    }

}