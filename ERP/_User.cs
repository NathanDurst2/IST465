﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string isAdmin { get; set; }
        public string LastLogon { get; set; }
    }
}
