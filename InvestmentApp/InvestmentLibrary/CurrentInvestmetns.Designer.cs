
namespace InvestmentLibrary
{
    partial class CurrentInvestmetns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentInvestmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.ActiveInvestitionsLabel = new System.Windows.Forms.Label();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInvestmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentInvestmentsDataGridView
            // 
            this.CurrentInvestmentsDataGridView.AllowUserToAddRows = false;
            this.CurrentInvestmentsDataGridView.AllowUserToDeleteRows = false;
            this.CurrentInvestmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrentInvestmentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CurrentInvestmentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CurrentInvestmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentInvestmentsDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CurrentInvestmentsDataGridView.Location = new System.Drawing.Point(1, 60);
            this.CurrentInvestmentsDataGridView.Name = "CurrentInvestmentsDataGridView";
            this.CurrentInvestmentsDataGridView.RowHeadersWidth = 51;
            this.CurrentInvestmentsDataGridView.RowTemplate.Height = 24;
            this.CurrentInvestmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrentInvestmentsDataGridView.Size = new System.Drawing.Size(832, 539);
            this.CurrentInvestmentsDataGridView.TabIndex = 0;
            // 
            // ActiveInvestitionsLabel
            // 
            this.ActiveInvestitionsLabel.AutoSize = true;
            this.ActiveInvestitionsLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActiveInvestitionsLabel.Location = new System.Drawing.Point(12, 13);
            this.ActiveInvestitionsLabel.Name = "ActiveInvestitionsLabel";
            this.ActiveInvestitionsLabel.Size = new System.Drawing.Size(246, 34);
            this.ActiveInvestitionsLabel.TabIndex = 2;
            this.ActiveInvestitionsLabel.Text = "Active Investitions";
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Location = new System.Drawing.Point(264, 10);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(212, 44);
            this.WithdrawalButton.TabIndex = 3;
            this.WithdrawalButton.Text = "Withdraw selected";
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // CurrentInvestmetns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 595);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.ActiveInvestitionsLabel);
            this.Controls.Add(this.CurrentInvestmentsDataGridView);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentInvestmetns";
            this.Text = "CurrentInvestmetns";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInvestmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView CurrentInvestmentsDataGridView;
        private System.Windows.Forms.Label ActiveInvestitionsLabel;
        private System.Windows.Forms.Button WithdrawalButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}