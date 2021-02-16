
namespace InvestmentLibrary
{
    partial class StatsWindow
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
            this.StatsTitleLabel = new System.Windows.Forms.Label();
            this.CurrenciesDataGridView = new System.Windows.Forms.DataGridView();
            this.CurrencyStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.PercentageGroupBox = new System.Windows.Forms.GroupBox();
            this.TypesDataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CurrenciesDataGridView)).BeginInit();
            this.CurrencyStatsGroupBox.SuspendLayout();
            this.PercentageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypesDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // StatsTitleLabel
            // 
            this.StatsTitleLabel.AutoSize = true;
            this.StatsTitleLabel.Location = new System.Drawing.Point(259, 24);
            this.StatsTitleLabel.Name = "StatsTitleLabel";
            this.StatsTitleLabel.Size = new System.Drawing.Size(69, 29);
            this.StatsTitleLabel.TabIndex = 0;
            this.StatsTitleLabel.Text = "Stats";
            // 
            // CurrenciesDataGridView
            // 
            this.CurrenciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrenciesDataGridView.Location = new System.Drawing.Point(24, 40);
            this.CurrenciesDataGridView.Name = "CurrenciesDataGridView";
            this.CurrenciesDataGridView.RowHeadersWidth = 51;
            this.CurrenciesDataGridView.RowTemplate.Height = 24;
            this.CurrenciesDataGridView.Size = new System.Drawing.Size(350, 151);
            this.CurrenciesDataGridView.TabIndex = 1;
            // 
            // CurrencyStatsGroupBox
            // 
            this.CurrencyStatsGroupBox.Controls.Add(this.CurrenciesDataGridView);
            this.CurrencyStatsGroupBox.Location = new System.Drawing.Point(94, 72);
            this.CurrencyStatsGroupBox.Name = "CurrencyStatsGroupBox";
            this.CurrencyStatsGroupBox.Size = new System.Drawing.Size(398, 210);
            this.CurrencyStatsGroupBox.TabIndex = 3;
            this.CurrencyStatsGroupBox.TabStop = false;
            this.CurrencyStatsGroupBox.Text = "Currencies";
            // 
            // PercentageGroupBox
            // 
            this.PercentageGroupBox.Controls.Add(this.TypesDataGridView2);
            this.PercentageGroupBox.Location = new System.Drawing.Point(90, 312);
            this.PercentageGroupBox.Name = "PercentageGroupBox";
            this.PercentageGroupBox.Size = new System.Drawing.Size(406, 236);
            this.PercentageGroupBox.TabIndex = 4;
            this.PercentageGroupBox.TabStop = false;
            this.PercentageGroupBox.Text = "Types in percentage";
            // 
            // TypesDataGridView2
            // 
            this.TypesDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypesDataGridView2.Location = new System.Drawing.Point(26, 49);
            this.TypesDataGridView2.Name = "TypesDataGridView2";
            this.TypesDataGridView2.RowHeadersWidth = 51;
            this.TypesDataGridView2.RowTemplate.Height = 24;
            this.TypesDataGridView2.Size = new System.Drawing.Size(350, 164);
            this.TypesDataGridView2.TabIndex = 2;
            // 
            // StatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 595);
            this.Controls.Add(this.PercentageGroupBox);
            this.Controls.Add(this.CurrencyStatsGroupBox);
            this.Controls.Add(this.StatsTitleLabel);
            this.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StatsWindow";
            this.Text = "StatsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.CurrenciesDataGridView)).EndInit();
            this.CurrencyStatsGroupBox.ResumeLayout(false);
            this.PercentageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypesDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatsTitleLabel;
        private System.Windows.Forms.DataGridView CurrenciesDataGridView;
        private System.Windows.Forms.GroupBox CurrencyStatsGroupBox;
        private System.Windows.Forms.GroupBox PercentageGroupBox;
        private System.Windows.Forms.DataGridView TypesDataGridView2;
    }
}