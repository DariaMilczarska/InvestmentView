using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class InvestmentType
    {
        public int IdInvestmentType { get; set; }
        public String InvName { get; set; }
        public InvestmentType(String invName)
        {
            this.InvName = invName;
            this.IdInvestmentType = 0;
        }

        public InvestmentType()
        {
            this.IdInvestmentType = 0;
        }
    }
}
