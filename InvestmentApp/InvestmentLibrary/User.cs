using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class User
    {
        public int idUser { get; set; }
        public String login { get; set; } = null;
        public String password { get; set; } = null;

        public User(String login, String password)
        {
            this.login = login;
            this.password = password;
            this.idUser = 0;
        }
    }
}
