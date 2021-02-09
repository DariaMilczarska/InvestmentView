using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class UserInvestment
    {
        public int idUserInvestment { get; set; }
        public int idUser { get; set; }
        public int idInvestment { get; set; }
        public DateTime datePurchased { get; set; }
        public decimal valuePurchased { get; set; }
        public decimal difference { get; set; }
    }
}
