using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNexus.Class
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Status { get; set; }

        public User()
        {
            Username = "";
            Password = "";
            Status = "Guest";
        }

        public User(string ul, string up, string us)
        {
            Username = ul;
            Password = up;
            Status = us;
        }
    }
}
