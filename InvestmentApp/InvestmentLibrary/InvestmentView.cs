using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class InvestmentView
    {
        public String InvestitionName { get; set; }
        public String TypeName { get; set; }
        public double ValuePurchased { get; set; }
        public double Amount { get; set; }
        public double ValueInPLN { get; set; }
        public double Value{ get; set; }
        public DateTime DatePurchased { get; set; }
        public double RealValue { get; set; }
        public double Difference { get; set; }
        public double DifferenceInP { get; set; }

        public InvestmentView()
        {

        }
    }

}
