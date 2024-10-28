using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Model
{
    public class LoginDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int UserID { get; set; }
        public string Role { get; set; }
        public int Returnvalue { get; set; }
        public string Msg { get; set; }
    }
}
