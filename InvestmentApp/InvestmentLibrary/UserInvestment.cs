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
        public User user { get; set; }
        public Investment investment { get; set; }
        public DateTime datePurchased { get; set; }
        public double valuePurchased { get; set; }
        public double difference { get; set; }

        public UserInvestment(User user, Investment investment, DateTime datePurchased, double value, double diff)
        {
            this.user = user;
            this.investment = investment;
            this.datePurchased = datePurchased;
            this.valuePurchased = value;
            this.difference = diff;
        }
    }
}
