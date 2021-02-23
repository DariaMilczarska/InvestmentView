
namespace InvestmentLibrary
{
    partial class HistoryInvestments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HistoryValueLabel = new System.Windows.Forms.Label();
            this.HistoryOutcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryDataGridView
            // 
            this.HistoryDataGridView.AllowUserToAddRows = false;
            this.HistoryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.HistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.HistoryDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.HistoryDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.HistoryDataGridView.Location = new System.Drawing.Point(3, 61);
            this.HistoryDataGridView.MultiSelect = false;
            this.HistoryDataGridView.Name = "HistoryDataGridView";
            this.HistoryDataGridView.ReadOnly = true;
            this.HistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.HistoryDataGridView.RowHeadersVisible = false;
            this.HistoryDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.HistoryDataGridView.RowTemplate.Height = 24;
            this.HistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryDataGridView.Size = new System.Drawing.Size(867, 531);
            this.HistoryDataGridView.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(21, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(324, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Finished Investments";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.HistoryValueLabel);
            this.panel1.Controls.Add(this.HistoryOutcomeLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.HistoryDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 595);
            this.panel1.TabIndex = 0;
            // 
            // HistoryValueLabel
            // 
            this.HistoryValueLabel.AutoSize = true;
            this.HistoryValueLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryValueLabel.ForeColor = System.Drawing.Color.Green;
            this.HistoryValueLabel.Location = new System.Drawing.Point(503, 17);
            this.HistoryValueLabel.Name = "HistoryValueLabel";
            this.HistoryValueLabel.Size = new System.Drawing.Size(87, 32);
            this.HistoryValueLabel.TabIndex = 3;
            this.HistoryValueLabel.Text = "Value";
            // 
            // HistoryOutcomeLabel
            // 
            this.HistoryOutcomeLabel.AutoSize = true;
            this.HistoryOutcomeLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryOutcomeLabel.Location = new System.Drawing.Point(370, 17);
            this.HistoryOutcomeLabel.Name = "HistoryOutcomeLabel";
            this.HistoryOutcomeLabel.Size = new System.Drawing.Size(127, 32);
            this.HistoryOutcomeLabel.TabIndex = 2;
            this.HistoryOutcomeLabel.Text = "Outcome";
            // 
            // HistoryInvestments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(869, 595);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HistoryInvestments";
            this.Text = "HistoryInvestments";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryDataGridView;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HistoryValueLabel;
        private System.Windows.Forms.Label HistoryOutcomeLabel;
    }
}