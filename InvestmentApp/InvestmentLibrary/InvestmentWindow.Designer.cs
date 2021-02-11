
namespace InvestmentLibrary
{
    partial class InvestmentWindow
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
            this.newInvestmentPanel = new System.Windows.Forms.Panel();
            this.AddInvestmentLabel = new System.Windows.Forms.Label();
            this.InvValueTextBox = new System.Windows.Forms.TextBox();
            this.InvValueLabel = new System.Windows.Forms.Label();
            this.invNameLabel = new System.Windows.Forms.Label();
            this.InvNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newInvestmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newInvestmentPanel
            // 
            this.newInvestmentPanel.AllowDrop = true;
            this.newInvestmentPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newInvestmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newInvestmentPanel.Controls.Add(this.comboBox1);
            this.newInvestmentPanel.Controls.Add(this.invNameLabel);
            this.newInvestmentPanel.Controls.Add(this.InvNameTextBox);
            this.newInvestmentPanel.Controls.Add(this.InvValueLabel);
            this.newInvestmentPanel.Controls.Add(this.InvValueTextBox);
            this.newInvestmentPanel.Controls.Add(this.AddInvestmentLabel);
            this.newInvestmentPanel.Location = new System.Drawing.Point(0, -1);
            this.newInvestmentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.newInvestmentPanel.Name = "newInvestmentPanel";
            this.newInvestmentPanel.Size = new System.Drawing.Size(918, 426);
            this.newInvestmentPanel.TabIndex = 0;
            // 
            // AddInvestmentLabel
            // 
            this.AddInvestmentLabel.AutoSize = true;
            this.AddInvestmentLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.AddInvestmentLabel.ForeColor = System.Drawing.Color.Navy;
            this.AddInvestmentLabel.Location = new System.Drawing.Point(56, 33);
            this.AddInvestmentLabel.Name = "AddInvestmentLabel";
            this.AddInvestmentLabel.Size = new System.Drawing.Size(177, 27);
            this.AddInvestmentLabel.TabIndex = 0;
            this.AddInvestmentLabel.Text = "New inwestment";
            // 
            // InvValueTextBox
            // 
            this.InvValueTextBox.Location = new System.Drawing.Point(158, 112);
            this.InvValueTextBox.Name = "InvValueTextBox";
            this.InvValueTextBox.Size = new System.Drawing.Size(87, 27);
            this.InvValueTextBox.TabIndex = 1;
            // 
            // InvValueLabel
            // 
            this.InvValueLabel.AutoSize = true;
            this.InvValueLabel.Location = new System.Drawing.Point(59, 115);
            this.InvValueLabel.Name = "InvValueLabel";
            this.InvValueLabel.Size = new System.Drawing.Size(94, 19);
            this.InvValueLabel.TabIndex = 2;
            this.InvValueLabel.Text = "Value (PLN)";
            // 
            // invNameLabel
            // 
            this.invNameLabel.AutoSize = true;
            this.invNameLabel.Location = new System.Drawing.Point(59, 82);
            this.invNameLabel.Name = "invNameLabel";
            this.invNameLabel.Size = new System.Drawing.Size(52, 19);
            this.invNameLabel.TabIndex = 4;
            this.invNameLabel.Text = "Name";
            // 
            // InvNameTextBox
            // 
            this.InvNameTextBox.Location = new System.Drawing.Point(117, 79);
            this.InvNameTextBox.Name = "InvNameTextBox";
            this.InvNameTextBox.Size = new System.Drawing.Size(128, 27);
            this.InvNameTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // InvestmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(915, 421);
            this.Controls.Add(this.newInvestmentPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvestmentWindow";
            this.Text = "Form1";
            this.newInvestmentPanel.ResumeLayout(false);
            this.newInvestmentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newInvestmentPanel;
        private System.Windows.Forms.Label AddInvestmentLabel;
        private System.Windows.Forms.Label InvValueLabel;
        private System.Windows.Forms.TextBox InvValueTextBox;
        private System.Windows.Forms.Label invNameLabel;
        private System.Windows.Forms.TextBox InvNameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}