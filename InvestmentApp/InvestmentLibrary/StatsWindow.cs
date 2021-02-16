using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentLibrary
{
    public partial class StatsWindow : Form
    {
        public StatsWindow()
        {
            InitializeComponent();
            this.CurrenciesDataGridView.DataSource = SqlConnector.GetCurrency_All();
            this.TypesDataGridView2.DataSource = CalculateTypesPercentage();
        }

        private List<String> CalculateTypesPercentage()
        {
            double sum;
            List<double> helpListSum = new List<double>();
            List<String> helpListNames = new List<String>();
            List<String> result = new List<string>();
            foreach (InvestmentType t in SqlConnector.GetInvestmentType_All())
            {
                List<double> temp = SqlConnector.GetInvestmentType(t.InvName);
                if(temp.Count > 0)
                {
                    sum = temp.Sum();
                    helpListSum.Add(sum);
                    helpListNames.Add(t.InvName);
                }             
            }
            double total = helpListSum.Sum();
            for(int i = 0; i < helpListSum.Count; ++i)
            {
                result.Add($"{helpListNames[i]}: {100 * helpListSum[i] / total}");
            }

            return result;
        }
    }
}
