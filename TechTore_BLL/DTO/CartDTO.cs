﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class CartDTO
    {
        public int CartId { get; set; }

        public int? UserId { get; set; }

        public byte[] CartDate { get; set; } = null!;
    }
}