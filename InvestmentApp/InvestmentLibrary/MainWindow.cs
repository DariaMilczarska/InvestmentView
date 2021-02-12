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
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void NewInvestmentButton_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            InvestmentWindow myForm = new InvestmentWindow() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void MyInvestmentBurron_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            CurrentInvestmetns myForm = new CurrentInvestmetns() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(myForm);
            myForm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
