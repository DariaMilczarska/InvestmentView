using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class Investment
    {
        public int IdInvestment { get; set; }
        public int IdInvestmentType { get; set; }
        public int IdCurrency { get; set; }
        public double Value { get; set; }
        public String InvName { get; set; }
        public String DataSource { get; set; } = null;     

        public Investment()
        {
            this.IdInvestment = 0;
        }
        public void InitializeValue()
        {
            WebClient web = new WebClient();
            string data = web.DownloadString(DataSource);
            String[] splited = data.Split(new String[] { "data-last=\"" }, StringSplitOptions.None);
            String[] endSplit = splited[1].Split('"');
            String temp = endSplit[0].Replace('.', ',');
            this.Value = Double.Parse(temp);
            SqlConnector.UpdateInvestmentData(this);
        }
    }
}
