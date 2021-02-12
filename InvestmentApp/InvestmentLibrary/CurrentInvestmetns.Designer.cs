
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panels1 = new InvestmentLibrary.Panels();
            this.ActiveInvestitionsLabel = new System.Windows.Forms.Label();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView.Location = new System.Drawing.Point(0, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(814, 486);
            this.dataGridView.TabIndex = 0;
            // 
            // panels1
            // 
            this.panels1.AutoSize = true;
            this.panels1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panels1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panels1.Location = new System.Drawing.Point(0, 0);
            this.panels1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panels1.Name = "panels1";
            this.panels1.Size = new System.Drawing.Size(814, 548);
            this.panels1.TabIndex = 1;
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
            // CurrentInvestmetns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 548);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.ActiveInvestitionsLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panels1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentInvestmetns";
            this.Text = "CurrentInvestmetns";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private Panels panels1;
        private System.Windows.Forms.Label ActiveInvestitionsLabel;
        private System.Windows.Forms.Button WithdrawalButton;
    }
}