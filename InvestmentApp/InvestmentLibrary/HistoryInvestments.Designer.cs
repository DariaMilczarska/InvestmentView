
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
            this.HistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HistoryOutcomeLabel = new System.Windows.Forms.Label();
            this.HistoryValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryDataGridView
            // 
            this.HistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataGridView.Location = new System.Drawing.Point(0, 64);
            this.HistoryDataGridView.Name = "HistoryDataGridView";
            this.HistoryDataGridView.RowHeadersWidth = 51;
            this.HistoryDataGridView.RowTemplate.Height = 24;
            this.HistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryDataGridView.Size = new System.Drawing.Size(883, 531);
            this.HistoryDataGridView.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(286, 34);
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
            this.panel1.Size = new System.Drawing.Size(883, 595);
            this.panel1.TabIndex = 0;
            // 
            // HistoryOutcomeLabel
            // 
            this.HistoryOutcomeLabel.AutoSize = true;
            this.HistoryOutcomeLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryOutcomeLabel.Location = new System.Drawing.Point(308, 15);
            this.HistoryOutcomeLabel.Name = "HistoryOutcomeLabel";
            this.HistoryOutcomeLabel.Size = new System.Drawing.Size(126, 34);
            this.HistoryOutcomeLabel.TabIndex = 2;
            this.HistoryOutcomeLabel.Text = "Outcome";
            // 
            // HistoryValueLabel
            // 
            this.HistoryValueLabel.AutoSize = true;
            this.HistoryValueLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryValueLabel.ForeColor = System.Drawing.Color.Green;
            this.HistoryValueLabel.Location = new System.Drawing.Point(440, 15);
            this.HistoryValueLabel.Name = "HistoryValueLabel";
            this.HistoryValueLabel.Size = new System.Drawing.Size(84, 34);
            this.HistoryValueLabel.TabIndex = 3;
            this.HistoryValueLabel.Text = "Value";
            // 
            // HistoryInvestments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 595);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
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