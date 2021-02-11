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
        public int idInvestment { get; set; }
        public InvestmentType investmentType { get; set; }
        public double value { get; set; }
        public String invName { get; set; }
        public String dataSource { get; set; } = null;

        public Investment(InvestmentType investmentType, double value, String invName, String dataSource)
        {
            this.investmentType = investmentType;
            this.value = value;
            this.invName = invName;
            this.dataSource = dataSource;
            this.idInvestment = 0;
        }
        public void InitializeValue()
        {
            WebClient web = new WebClient();
            string data = web.DownloadString(dataSource);
            String[] splited = data.Split(new String[] { "data-last=\"" }, StringSplitOptions.None);
            String[] endSplit = splited[1].Split('"');
            String temp = endSplit[0].Replace('.', ',');
            this.value = Double.Parse(temp);
            SqlConnector.EditInvestmentValue(this);
        }
    }
}
