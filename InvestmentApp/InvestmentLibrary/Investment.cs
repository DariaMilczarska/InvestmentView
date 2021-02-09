using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class Investment
    {
        public int idInvestment { get; set; }
        public int idInvestmentType { get; set; }
        public decimal value { get; set; }
        public String invName { get; set; }
        public String dataSource { get; set; } = null;
    }
}
