using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class UserRoleDTO
    {
        public int UserRoleId { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }
    }

}