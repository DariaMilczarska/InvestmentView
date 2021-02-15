using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLibrary
{
    class Currency
    {
        public int IdCurrency { get; set; }
        public String Shorthand { get; set; }
        public double Value { get; set; }
        public String DataSource { get; set; }
        public Currency()
        {
            this.IdCurrency = 0;
        }

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
