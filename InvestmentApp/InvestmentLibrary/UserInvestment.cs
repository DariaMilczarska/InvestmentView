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
        public double amount { get; set; } = 0;
        public double valuePLN { get; set; } = 0;

        //public UserInvestment(User user, Investment investment, DateTime datePurchased, double value, double diff)
        //{
        //    this.user = user;
        //    this.investment = investment;
        //    this.datePurchased = datePurchased;
        //    this.valuePurchased = value;
        //    this.difference = diff;
        //}

        public UserInvestment()
        {
            this.idUserInvestment = 6;
            this.difference = 0;
        }
    }
}
