using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains the most important info about history of investitions
    /// </summary>
    class HistoryView
    {
        public String Name { get; set; }
        public double ValuePurchased { get; set; }
        public double ValueSold { get; set; }
        public double Difference { get; set; }
        public double DifferenceInP { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DateSold { get; set; }
    }
}
