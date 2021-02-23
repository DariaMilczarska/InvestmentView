using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains data for available Investments
    /// </summary>
    class Investment
    {
        public int IdInvestment { get; set; }
        /// <summary>
        /// Contains id of investment type assigned to investment
        /// </summary>
        public int IdInvestmentType { get; set; }
        /// <summary>
        /// Contains id of currency assigned to investment
        /// </summary>
        public int IdCurrency { get; set; }
        /// <summary>
        /// Contains current value of investment
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Contains name of investment
        /// </summary>
        public String InvName { get; set; }
        /// <summary>
        /// DataSource od the investment - needed to determine value
        /// </summary>
        public String DataSource { get; set; } = null;     

        public Investment()
        {
            this.IdInvestment = 0;
        }

        /// <summary>
        /// Initializes/updates value of the investment based od DataSource;
        /// </summary>
        public void InitializeValue()
        {
            if (DataSource.Contains("bankier"))
            {
                WebClient web = new WebClient();
                string data = web.DownloadString(DataSource);
                String[] splited = data.Split(new String[] { "data-last=\"" }, StringSplitOptions.None);
                String[] endSplit = splited[1].Split('"');
                String temp = endSplit[0].Replace('.', ',');
                this.Value = Double.Parse(temp);
                SqlConnector.UpdateInvestmentData(this);
            }
            else 
            {
                WebClient web = new WebClient();
                string data = web.DownloadString(DataSource);
                String[] splited = data.Split(new String[] { "<span class=\"q_ch_act\">" }, StringSplitOptions.None);
                String[] endSplit = splited[1].Split('<');
                String temp = endSplit[0].Replace('.', ',');
                this.Value = Double.Parse(temp);
                SqlConnector.UpdateInvestmentData(this);
            }
            
        }
    }
}
