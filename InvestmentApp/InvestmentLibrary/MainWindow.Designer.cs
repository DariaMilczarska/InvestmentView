
namespace InvestmentLibrary
{
    partial class MainWindow
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OutcomeValueLabel = new System.Windows.Forms.Label();
            this.NewInvestmentButton = new System.Windows.Forms.Button();
            this.DiagramButton = new System.Windows.Forms.Button();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.HistoryOfInvestments = new System.Windows.Forms.Button();
            this.MyInvestmentBurron = new System.Windows.Forms.Button();
            this.MyInvestmensButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Location = new System.Drawing.Point(1, 117);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(0, 0);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // OutcomeValueLabel
            // 
            this.OutcomeValueLabel.AutoSize = true;
            this.OutcomeValueLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeValueLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.OutcomeValueLabel.Location = new System.Drawing.Point(829, 63);
            this.OutcomeValueLabel.Name = "OutcomeValueLabel";
            this.OutcomeValueLabel.Size = new System.Drawing.Size(90, 36);
            this.OutcomeValueLabel.TabIndex = 19;
            this.OutcomeValueLabel.Text = "Value";
            // 
            // NewInvestmentButton
            // 
            this.NewInvestmentButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewInvestmentButton.ForeColor = System.Drawing.Color.Navy;
            this.NewInvestmentButton.Location = new System.Drawing.Point(344, 56);
            this.NewInvestmentButton.Name = "NewInvestmentButton";
            this.NewInvestmentButton.Size = new System.Drawing.Size(341, 59);
            this.NewInvestmentButton.TabIndex = 18;
            this.NewInvestmentButton.Text = "New Investment";
            this.NewInvestmentButton.UseVisualStyleBackColor = true;
            this.NewInvestmentButton.Click += new System.EventHandler(this.NewInvestmentButton_Click);
            // 
            // DiagramButton
            // 
            this.DiagramButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiagramButton.ForeColor = System.Drawing.Color.Navy;
            this.DiagramButton.Location = new System.Drawing.Point(5, 56);
            this.DiagramButton.Name = "DiagramButton";
            this.DiagramButton.Size = new System.Drawing.Size(341, 59);
            this.DiagramButton.TabIndex = 17;
            this.DiagramButton.Text = "View Diagram";
            this.DiagramButton.UseVisualStyleBackColor = true;
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutcomeLabel.Location = new System.Drawing.Point(814, 10);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(126, 34);
            this.OutcomeLabel.TabIndex = 16;
            this.OutcomeLabel.Text = "Outcome";
            // 
            // HistoryOfInvestments
            // 
            this.HistoryOfInvestments.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HistoryOfInvestments.ForeColor = System.Drawing.Color.Navy;
            this.HistoryOfInvestments.Location = new System.Drawing.Point(344, 0);
            this.HistoryOfInvestments.Name = "HistoryOfInvestments";
            this.HistoryOfInvestments.Size = new System.Drawing.Size(341, 59);
            this.HistoryOfInvestments.TabIndex = 15;
            this.HistoryOfInvestments.Text = "History";
            this.HistoryOfInvestments.UseVisualStyleBackColor = true;
            // 
            // MyInvestmentBurron
            // 
            this.MyInvestmentBurron.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyInvestmentBurron.ForeColor = System.Drawing.Color.Navy;
            this.MyInvestmentBurron.Location = new System.Drawing.Point(5, -1);
            this.MyInvestmentBurron.Name = "MyInvestmentBurron";
            this.MyInvestmentBurron.Size = new System.Drawing.Size(341, 59);
            this.MyInvestmentBurron.TabIndex = 13;
            this.MyInvestmentBurron.Text = "My Investments";
            this.MyInvestmentBurron.UseVisualStyleBackColor = true;
            this.MyInvestmentBurron.Click += new System.EventHandler(this.MyInvestmentBurron_Click);
            // 
            // MyInvestmensButton
            // 
            this.MyInvestmensButton.Location = new System.Drawing.Point(6, 0);
            this.MyInvestmensButton.Name = "MyInvestmensButton";
            this.MyInvestmensButton.Size = new System.Drawing.Size(186, 59);
            this.MyInvestmensButton.TabIndex = 14;
            this.MyInvestmensButton.Text = "My Investments";
            this.MyInvestmensButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1046, 764);
            this.Controls.Add(this.OutcomeValueLabel);
            this.Controls.Add(this.NewInvestmentButton);
            this.Controls.Add(this.DiagramButton);
            this.Controls.Add(this.OutcomeLabel);
            this.Controls.Add(this.HistoryOfInvestments);
            this.Controls.Add(this.MyInvestmentBurron);
            this.Controls.Add(this.MyInvestmensButton);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label OutcomeValueLabel;
        private System.Windows.Forms.Button NewInvestmentButton;
        private System.Windows.Forms.Button DiagramButton;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Button HistoryOfInvestments;
        private System.Windows.Forms.Button MyInvestmentBurron;
        private System.Windows.Forms.Button MyInvestmensButton;
    }
}