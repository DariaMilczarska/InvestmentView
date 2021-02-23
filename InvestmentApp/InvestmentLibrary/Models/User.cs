using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains onfo about current user
    /// </summary>
    public class User
    {
        public int idUser { get; set; }
        public String login { get; set; } = null;
        public String password { get; set; } = null;

        public User()
        {
            this.idUser = 0;
        }
    }
}
