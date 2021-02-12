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
    public partial class InvestmentWindow : Form
    {
        List<InvestmentType> availableInvestmentTypes = SqlConnector.GetInvestmentType_All();
        List<Investment> availableInvestments = SqlConnector.GetInvestment_All();
        List<Currency> availableCurrencies = SqlConnector.GetCurrency_All();
        public InvestmentWindow()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            this.InvestemntTypeComboBox.DataSource = null;
            this.InvestemntTypeComboBox.DataSource = availableInvestmentTypes;
            this.InvestemntTypeComboBox.DisplayMember = "invName";

            this.NameComboBox.DataSource = null;
            this.NameComboBox.DataSource = availableInvestments;
            this.NameComboBox.DisplayMember = "invName";

            this.CurrencyComboBox.DataSource = null;
            this.CurrencyComboBox.DataSource = availableCurrencies;
            this.CurrencyComboBox.DisplayMember = "Shorthand";
        }

        private void AddTypeButton_Click(object sender, EventArgs e)
        {
            if (ValidateInvestmentType())
            {
                try
                {
                    InvestmentType type = new InvestmentType();
                    type.invName = this.TypeNameTextBox.Text;
                    type = SqlConnector.CreateInvestmentType(type);
                    availableInvestmentTypes.Add(type);
                    InitializeLists();
                }
                catch (MySql.Data.MySqlClient.MySqlException exception)
                {
                    MessageBox.Show("This investemnt type already exists", "Duplicate error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.TypeNameTextBox.Text = "";
        }

        private bool ValidateInvestmentType()
        {
            bool output = true;
            if (this.TypeNameTextBox.TextLength == 0)
            {
                output = false;
            }
            return output;
        }

        private void CreateInvestmentbutton_Click(object sender, EventArgs e)
        {
            if (ValidateInvestment())
            {
                try
                {
                    Investment investment = new Investment();
                    investment.invName = this.NameTextBox.Text;
                    investment.investmentType = (InvestmentType)this.InvestemntTypeComboBox.SelectedItem;
                    investment.dataSource = this.DataSourceTextBox.Text;
                    investment.currency = (Currency)this.CurrencyComboBox.SelectedItem;
                    investment.InitializeValue();
                    investment = SqlConnector.CreateInvestment(investment);
                    availableInvestments.Add(investment);
                    InitializeLists();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                    MessageBox.Show("This investemnt already exists", "Duplicate error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.NameTextBox.Text = "";
            this.DataSourceTextBox.Text = "";
            this.InvestemntTypeComboBox.SelectedItem = "";
        }
        private bool ValidateInvestment()
        {
            bool output = true;
            if (this.InvestemntTypeComboBox.SelectedItem == null)
            {
                return false;
            }
            if (this.CurrencyComboBox.SelectedItem == null)
            {
                return false;
            }
            if (this.NameTextBox.TextLength == 0)
            {
                return false;
            }
            if (this.DataSourceTextBox.TextLength == 0)
            {
                return false;
            }
            return output;
        }
        private void CreateCurrencyButton_Click(object sender, EventArgs e)
        {
            if (ValidateCurrency())
            {
                try
                {
                    Currency c = new Currency();
                    c.Shorthand = this.CurrencyShortcutTextBox.Text;
                    c.dataSource = this.CurrencyDataSourceTextBox.Text;
                    c.InitializeValue();
                    c = SqlConnector.AddCurrency(c);
                    this.availableCurrencies.Add(c);
                    InitializeLists();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                    MessageBox.Show("This currency already exists", "Duplicate error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.CurrencyShortcutTextBox.Text = "";
            this.CurrencyDataSourceTextBox.Text = "";
        }

        private bool ValidateCurrency()
        {
            if (this.CurrencyShortcutTextBox.TextLength == 0)
            {
                return false;
            }
            if (this.CurrencyDataSourceTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void AddInvestmentButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInvestment())
            {
                try
                {
                    UserInvestment ui = new UserInvestment();
                    ui.investment = (Investment)this.NameComboBox.SelectedItem;
                    ui.user = SqlConnector.GetUser();
                    ui.valuePLN = Double.Parse(this.InvValueTextBox.Text);
                    ui.valuePurchased = Double.Parse(this.RateTextBox.Text);
                    ui.amount = Double.Parse(this.AmountTextBox.Text);
                    ui.datePurchased = this.InvestDateTimePicker.Value;
                    ui = SqlConnector.AddUserInvestment(ui);
                }
                catch (Exception)
                {

                    MessageBox.Show("Something went wrong", "Duplicate error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorret data! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.InvValueTextBox.Text = "";
            this.RateTextBox.Text = "";
            this.AmountTextBox.Text = "";
            this.InvestDateTimePicker.Value = DateTime.Today;
        }
        private bool ValidateUserInvestment()
        {
            if (this.NameComboBox.SelectedItem == null)
            {
                return false;
            }
            if (this.InvValueTextBox.TextLength == 0 || !Double.TryParse(this.InvValueTextBox.Text, out double result))
            {
                return false;
            }
            if (this.RateTextBox.TextLength == 0 || !Double.TryParse(this.RateTextBox.Text, out double r))
            {
                return false;
            }
            if (this.AmountTextBox.TextLength == 0 || !Double.TryParse(this.AmountTextBox.Text, out double re))
            {
                return false;
            }
            if (!this.InvestDateTimePicker.Checked)
            {
                return false;
            }
            return true;
        }
    }
}
