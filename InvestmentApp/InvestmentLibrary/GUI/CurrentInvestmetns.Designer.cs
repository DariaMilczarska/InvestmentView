
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentInvestmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.ActiveInvestitionsLabel = new System.Windows.Forms.Label();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.ValueTowithDrawLabel = new System.Windows.Forms.Label();
            this.ValueToWithdrawTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentInvestmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentInvestmentsDataGridView
            // 
            this.CurrentInvestmentsDataGridView.AllowUserToAddRows = false;
            this.CurrentInvestmentsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentInvestmentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CurrentInvestmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrentInvestmentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CurrentInvestmentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CurrentInvestmentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentInvestmentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CurrentInvestmentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentInvestmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CurrentInvestmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentInvestmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CurrentInvestmentsDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.CurrentInvestmentsDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CurrentInvestmentsDataGridView.Location = new System.Drawing.Point(1, 79);
            this.CurrentInvestmentsDataGridView.MultiSelect = false;
            this.CurrentInvestmentsDataGridView.Name = "CurrentInvestmentsDataGridView";
            this.CurrentInvestmentsDataGridView.ReadOnly = true;
            this.CurrentInvestmentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CurrentInvestmentsDataGridView.RowHeadersVisible = false;
            this.CurrentInvestmentsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentInvestmentsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CurrentInvestmentsDataGridView.RowTemplate.Height = 24;
            this.CurrentInvestmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrentInvestmentsDataGridView.Size = new System.Drawing.Size(1235, 520);
            this.CurrentInvestmentsDataGridView.TabIndex = 0;
            // 
            // ActiveInvestitionsLabel
            // 
            this.ActiveInvestitionsLabel.AutoSize = true;
            this.ActiveInvestitionsLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActiveInvestitionsLabel.Location = new System.Drawing.Point(13, 22);
            this.ActiveInvestitionsLabel.Name = "ActiveInvestitionsLabel";
            this.ActiveInvestitionsLabel.Size = new System.Drawing.Size(281, 32);
            this.ActiveInvestitionsLabel.TabIndex = 2;
            this.ActiveInvestitionsLabel.Text = "Active Investitions";
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.BackColor = System.Drawing.Color.LightGray;
            this.WithdrawalButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WithdrawalButton.Location = new System.Drawing.Point(303, 17);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(231, 44);
            this.WithdrawalButton.TabIndex = 3;
            this.WithdrawalButton.Text = "Withdraw selected";
            this.WithdrawalButton.UseVisualStyleBackColor = false;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // ValueTowithDrawLabel
            // 
            this.ValueTowithDrawLabel.AutoSize = true;
            this.ValueTowithDrawLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueTowithDrawLabel.Location = new System.Drawing.Point(551, 22);
            this.ValueTowithDrawLabel.Name = "ValueTowithDrawLabel";
            this.ValueTowithDrawLabel.Size = new System.Drawing.Size(252, 32);
            this.ValueTowithDrawLabel.TabIndex = 5;
            this.ValueTowithDrawLabel.Text = "Value to withdraw";
            // 
            // ValueToWithdrawTextBox
            // 
            this.ValueToWithdrawTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueToWithdrawTextBox.Location = new System.Drawing.Point(809, 24);
            this.ValueToWithdrawTextBox.Name = "ValueToWithdrawTextBox";
            this.ValueToWithdrawTextBox.Size = new System.Drawing.Size(130, 30);
            this.ValueToWithdrawTextBox.TabIndex = 6;
            this.ValueToWithdrawTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentInvestmetns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 595);
            this.Controls.Add(this.ValueToWithdrawTextBox);
            this.Controls.Add(this.ValueTowithDrawLabel);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.ActiveInvestitionsLabel);
            this.Controls.Add(this.CurrentInvestmentsDataGridView);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label ValueTowithDrawLabel;
        private System.Windows.Forms.TextBox ValueToWithdrawTextBox;
    }
}