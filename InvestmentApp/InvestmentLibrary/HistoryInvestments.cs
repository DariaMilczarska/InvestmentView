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
        }
    }
}
