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
    public partial class HistoryInvestments : Form
    {
        public HistoryInvestments()
        {
            InitializeComponent();
            this.HistoryDataGridView.DataSource = SqlConnector.GetHistoryView_All();
            CalculateOutcome();
        }

        private void CalculateOutcome()
        {
            List<HistoryView> avaiableInvestments = SqlConnector.GetHistoryView_All();
            double sum = 0;
            double sumInvested = 0;
            double percent;
            foreach (HistoryView iv in avaiableInvestments)
            {
                sum += iv.Difference;
                sumInvested += iv.ValuePurchased;
            }
            percent = (100 * (sumInvested + sum) / sumInvested) - 100;
            this.HistoryValueLabel.Text = ($"{sum.ToString("0.00")} ({percent.ToString("0.00")}%)");
            if(sum > 0)
            {
                this.HistoryValueLabel.ForeColor = Color.Green;
            }
            else
            {
                this.HistoryValueLabel.ForeColor = Color.Red;
            }
        }
    }
}
