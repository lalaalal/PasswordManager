using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class User
    {
        private string id;
        private string pw;
        public User(string id, string pw)
        {
            this.id = id;
            this.pw = hash(pw);
        }

        private string hash(string str)
        {
            return str;
        }

        public string getId()
        {
            return id;
        }

        public string getPw()
        {
            return pw;
        }
    }
}
