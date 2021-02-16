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
            percent = 100 - (100 * (sumInvested + sum) / sumInvested);
            this.HistoryValueLabel.Text = ($"{sum} ({percent}%)");
        }
    }
}
