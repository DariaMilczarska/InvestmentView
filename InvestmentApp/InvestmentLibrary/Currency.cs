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
        public int idCurrency { get; set; }
        public String Shorthand { get; set; }
        public double value { get; set; }
        public String dataSource { get; set; }
        public Currency()
        {
            this.idCurrency = 0;
        }

        public void InitializeValue()
        {
            WebClient web = new WebClient();
            string data = web.DownloadString(dataSource);
            String[] splited = data.Split(new String[] { "profilLast\">" }, StringSplitOptions.None);
            String[] endSplit = splited[1].Split(' ');
            String temp = endSplit[0].Replace('.', ',');
            this.value = Double.Parse(temp);
        }
    }
}
