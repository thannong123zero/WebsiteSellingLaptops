﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string CitizenId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public byte Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string? Avatatar { get; set; }
    }
}
