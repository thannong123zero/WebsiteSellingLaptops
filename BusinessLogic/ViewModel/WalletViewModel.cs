﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class WalletViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
        public string? Description { get; set; }
    }
}
