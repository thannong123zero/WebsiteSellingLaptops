﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class AdminModel : CustomerModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
