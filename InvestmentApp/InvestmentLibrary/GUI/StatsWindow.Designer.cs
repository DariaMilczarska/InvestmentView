
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.StatsTitleLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatsTitleLabel.Location = new System.Drawing.Point(310, 16);
            this.StatsTitleLabel.Name = "StatsTitleLabel";
            this.StatsTitleLabel.Size = new System.Drawing.Size(91, 35);
            this.StatsTitleLabel.TabIndex = 0;
            this.StatsTitleLabel.Text = "Stats";
            // 
            // CurrenciesDataGridView
            // 
            this.CurrenciesDataGridView.AllowUserToAddRows = false;
            this.CurrenciesDataGridView.AllowUserToDeleteRows = false;
            this.CurrenciesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CurrenciesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CurrenciesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CurrenciesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CurrenciesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CurrenciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrenciesDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CurrenciesDataGridView.Location = new System.Drawing.Point(32, 38);
            this.CurrenciesDataGridView.MultiSelect = false;
            this.CurrenciesDataGridView.Name = "CurrenciesDataGridView";
            this.CurrenciesDataGridView.ReadOnly = true;
            this.CurrenciesDataGridView.RowHeadersVisible = false;
            this.CurrenciesDataGridView.RowHeadersWidth = 51;
            this.CurrenciesDataGridView.RowTemplate.Height = 24;
            this.CurrenciesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CurrenciesDataGridView.Size = new System.Drawing.Size(256, 175);
            this.CurrenciesDataGridView.TabIndex = 1;
            // 
            // CurrencyStatsGroupBox
            // 
            this.CurrencyStatsGroupBox.Controls.Add(this.CurrenciesDataGridView);
            this.CurrencyStatsGroupBox.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrencyStatsGroupBox.Location = new System.Drawing.Point(23, 80);
            this.CurrencyStatsGroupBox.Name = "CurrencyStatsGroupBox";
            this.CurrencyStatsGroupBox.Size = new System.Drawing.Size(321, 236);
            this.CurrencyStatsGroupBox.TabIndex = 3;
            this.CurrencyStatsGroupBox.TabStop = false;
            this.CurrencyStatsGroupBox.Text = "Currencies";
            // 
            // PercentageGroupBox
            // 
            this.PercentageGroupBox.Controls.Add(this.TypesDataGridView2);
            this.PercentageGroupBox.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PercentageGroupBox.Location = new System.Drawing.Point(383, 80);
            this.PercentageGroupBox.Name = "PercentageGroupBox";
            this.PercentageGroupBox.Size = new System.Drawing.Size(297, 236);
            this.PercentageGroupBox.TabIndex = 4;
            this.PercentageGroupBox.TabStop = false;
            this.PercentageGroupBox.Text = "Types in percentage";
            // 
            // TypesDataGridView2
            // 
            this.TypesDataGridView2.AllowUserToAddRows = false;
            this.TypesDataGridView2.AllowUserToDeleteRows = false;
            this.TypesDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TypesDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TypesDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TypesDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TypesDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypesDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TypesDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypesDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypesDataGridView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TypesDataGridView2.Location = new System.Drawing.Point(26, 38);
            this.TypesDataGridView2.MultiSelect = false;
            this.TypesDataGridView2.Name = "TypesDataGridView2";
            this.TypesDataGridView2.ReadOnly = true;
            this.TypesDataGridView2.RowHeadersVisible = false;
            this.TypesDataGridView2.RowHeadersWidth = 51;
            this.TypesDataGridView2.RowTemplate.Height = 24;
            this.TypesDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypesDataGridView2.Size = new System.Drawing.Size(244, 175);
            this.TypesDataGridView2.TabIndex = 2;
            // 
            // StatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 357);
            this.Controls.Add(this.PercentageGroupBox);
            this.Controls.Add(this.CurrencyStatsGroupBox);
            this.Controls.Add(this.StatsTitleLabel);
            this.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
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