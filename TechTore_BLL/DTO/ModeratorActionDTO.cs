using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ModeratorActionDTO
    {
        public int ActionId { get; set; }

        public int? ModeratorId { get; set; }

        public int? TargetUserId { get; set; }

        public string? ActionDescription { get; set; }

        public byte[] Timestamp { get; set; } = null!;
    }

}