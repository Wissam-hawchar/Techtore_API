﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.DTO
{
    public partial class ProductImageDTO
    {
        public int ImageId { get; set; }

        public int? ProductId { get; set; }

        public string? ImageUrl { get; set; }
    }

}