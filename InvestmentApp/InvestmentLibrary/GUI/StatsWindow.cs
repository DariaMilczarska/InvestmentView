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
    public struct TypesPercentage
    {
        public String name;
        public double percent;
    }
    public partial class StatsWindow : Form
    {
     
        public StatsWindow()
        {
            InitializeComponent();
            this.CurrenciesDataGridView.DataSource = SqlConnector.GetCurrencyView();
            this.TypesDataGridView2.DataSource = CalculateTypesPercentage();
        }

        private DataTable CalculateTypesPercentage()
        {
            double sum;
            List<double> helpListSum = new List<double>();
            List<String> helpListNames = new List<String>();
            DataTable result = new DataTable();
            result.Columns.Add("Type", typeof(string));
            result.Columns.Add("Percent", typeof(string));
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
                TypesPercentage t = new TypesPercentage()
                {
                    name = helpListNames[i],
                    percent = 100 * helpListSum[i] / total
                };
                result.Rows.Add(t.name, t.percent.ToString("0.00"));
            }

            return result;
        }
    }
}
