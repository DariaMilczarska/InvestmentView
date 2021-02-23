using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains info about specyfied investment
    /// </summary>
    class UserInvestment
    {
        public int IdUserInvestment { get; set; }
        public int idUser { get; set; }
        public int IdInvestment { get; set; }
        public DateTime DatePurchased { get; set; }
        public double ValuePurcharsed { get; set; }
        public double Amount { get; set; }
        public double ValuePLN { get; set; }
        public double Difference { get; set; }     
        public double DifferenceInP { get; set; } = 0;

    }
}
