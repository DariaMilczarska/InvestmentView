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
    public partial class CurrentInvestmetns : Form
    {
        public CurrentInvestmetns()
        {
            InitializeComponent();
            this.dataGridView.DataSource = SqlConnector.GetInvestmentView_All();
        }

        private void InvestmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
