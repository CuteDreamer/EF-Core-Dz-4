using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Dz_4
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public UserSettings UserSettings { get; set; }
    }
}
