﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Dz_4
{
    public class UserSettings
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
