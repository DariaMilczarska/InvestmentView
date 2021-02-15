using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class HistoryView
    {
        public double valuePurchased { get; set; }
        public double valueSold { get; set; }
        public double difference { get; set; }
        public double differenceInP { get; set; }
        public DateTime datePurchased { get; set; }
        public DateTime dateSold { get; set; }
    }
}
