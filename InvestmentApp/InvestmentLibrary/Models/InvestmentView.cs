using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains the most important info about user investments
    /// </summary>
    class InvestmentView
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public double ValuePLN { get; set; }
        public double RateNow{ get; set; }
        public DateTime DateBought { get; set; }
        public double ValueNow { get; set; }
        public double Profit { get; set; }
        public double ProfitPercent { get; set; }

    }

}
