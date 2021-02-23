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
        List<InvestmentView> availableInvestments = SqlConnector.GetInvestmentView_All();
        public CurrentInvestmetns(User u)
        {          
            InitializeComponent();
            InitializeList();
            this.user = u;
            this.ValueToWithdrawTextBox.Text = "0";
        }


        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox())
            {
                String name = (String)this.CurrentInvestmentsDataGridView.CurrentRow.Cells["Name"].Value;
                Investment selectedInvestment = SqlConnector.GetInvestment(name);
                UserInvestment ui = SqlConnector.GetUserInvestment(user.idUser, selectedInvestment.IdInvestment);
                double tempVal = Double.Parse(this.ValueToWithdrawTextBox.Text);
                if (ui.ValuePLN == tempVal)
                {
                    SqlConnector.FinishInvestment(ui.IdUserInvestment);
                }
                else if(tempVal > 0  && tempVal < ui.ValuePLN)
                {
                    double am = tempVal / selectedInvestment.Value;
                    SqlConnector.AddHistoryInvestment(ui, tempVal, am);
                    SqlConnector.WithdrawPartOfInvestment(ui.IdUserInvestment, tempVal);
                }
                else
                {
                    MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InitializeList();
            }
            else
            {
                 MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void InitializeList()
        {
            this.CurrentInvestmentsDataGridView.DataSource = null;
            availableInvestments = SqlConnector.GetInvestmentView_All();
            this.CurrentInvestmentsDataGridView.DataSource = availableInvestments;
        }

        private bool ValidateTextBox()
        {
            if(Double.TryParse(this.ValueToWithdrawTextBox.Text, out double output) && this.ValueToWithdrawTextBox.TextLength > 0)
            {
                return true;
            }

            return false;
        }

    }
}
