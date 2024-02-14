using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3Lab2
{
    internal class MUser
    {
        public string Username;
        public string Password;
        public string Role;
        public MUser(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
