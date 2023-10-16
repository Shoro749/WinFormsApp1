using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public class Users
    {
        public string login { get; set; }
        public string password { get; set; }

        public Users()
        {
            this.login = " ";
            this.password = " ";
        }
        public Users(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
