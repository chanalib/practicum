﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.DTOs
{
    public class CustomerPost
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }
    }
}
