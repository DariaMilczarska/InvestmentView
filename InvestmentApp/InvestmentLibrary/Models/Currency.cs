using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    /// <summary>
    /// Contains info about available currencies
    /// </summary>
    class Currency
    {
        public int IdCurrency { get; set; }
        /// <summary>
        /// Name of the currency (shorter version)
        /// </summary>
        public String Shorthand { get; set; }
        /// <summary>
        /// Current value of the currency
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// DataSource od the currency - needed to determine value
        /// </summary>
        public String DataSource { get; set; }
        public Currency()
        {
            this.IdCurrency = 0;
        }

        /// <summary>
        /// Initializes/updates value of the currency based od DataSource;
        /// </summary>
        public void InitializeValue()
        {
            WebClient web = new WebClient();
            string data = web.DownloadString(DataSource);
            String[] splited = data.Split(new String[] { "profilLast\">" }, StringSplitOptions.None);
            String[] endSplit = splited[1].Split(' ');
            String temp = endSplit[0].Replace('.', ',');
            this.Value = Double.Parse(temp);
        }
    }
}
