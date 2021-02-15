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
        readonly User user;
        public CurrentInvestmetns(User u)
        {
            InitializeComponent();
            this.CurrentInvestmentsDataGridView.DataSource = SqlConnector.GetInvestmentView_All();
            this.user = u;
        }

        private void InvestmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            String name = (String) this.CurrentInvestmentsDataGridView.CurrentRow.Cells["InvestitionName"].Value;
            Investment selectedInvestment = SqlConnector.GetInvestment(name);
            UserInvestment ui = SqlConnector.GetUserInvestment(user.idUser, selectedInvestment.IdInvestment);
            SqlConnector.FinishInvestment(ui.IdUserInvestment);
        }
    }
}
