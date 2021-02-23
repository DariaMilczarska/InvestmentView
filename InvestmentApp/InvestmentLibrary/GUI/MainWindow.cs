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
    public partial class MainWindow : Form
    {
        readonly User user = SqlConnector.GetUser();
        public MainWindow()
        {
            InitializeComponent();
            UpdateCurrencyData();
            UpdateInvestmentData();
            UpdateUserInvestmentData();
            CalculateOutcome();
        }

        private void NewInvestmentButton_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            InvestmentWindow myForm = new InvestmentWindow(user) { Dock = DockStyle.None, TopLevel = false, TopMost = true };

            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void MyInvestmentBurron_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            CurrentInvestmetns myForm = new CurrentInvestmetns(user) { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void HistoryOfInvestments_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            HistoryInvestments myForm = new HistoryInvestments() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void UpdateCurrencyData()
        {
            List<Currency> currencies = SqlConnector.GetCurrency_All();
            foreach(Currency c in currencies)
            {
                if(c.Shorthand != "PLN")
                {
                    c.InitializeValue();
                    SqlConnector.UpdateCurrencyData(c);
                }            
            }
        }

        private void UpdateInvestmentData()
        {
            List<Investment> investments = SqlConnector.GetInvestment_All();
            foreach(Investment i in investments)
            {
                i.InitializeValue();
                SqlConnector.UpdateInvestmentData(i);
            }
        }

        private void UpdateUserInvestmentData()
        {
            List<UserInvestment> userInvestments = SqlConnector.GetUserInvestemnt_All();
            foreach(UserInvestment ui in userInvestments)
            {
                SqlConnector.UpdateDifference(ui);
            }
        }

        public void CalculateOutcome()
        {
            List<InvestmentView> availableInvestments = SqlConnector.GetInvestmentView_All();
            double sum = 0;
            double sumInvested = 0;
            double percent;
            foreach (InvestmentView iv in availableInvestments)
            {
                sum += iv.Profit;
                sumInvested += iv.ValuePLN;
            }
            percent = (100*(sumInvested + sum) / sumInvested) -100;

            this.OutcomeValueLabel.Text =  $"{sum.ToString("0.00")} ({percent.ToString("0.00")}%)";
            if(sum > 0)
            {
                OutcomeValueLabel.ForeColor = Color.Green;
            }
            else
            {
                OutcomeValueLabel.ForeColor = Color.Red;
            }
           
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            StatsWindow myForm = new StatsWindow(){ Dock = DockStyle.None, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
