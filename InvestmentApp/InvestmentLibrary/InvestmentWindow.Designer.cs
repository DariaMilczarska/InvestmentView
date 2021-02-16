
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.CurrencyGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateCurrencyButton = new System.Windows.Forms.Button();
            this.CurrencyDataSourceTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyShortcutTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyDataSourceLabel = new System.Windows.Forms.Label();
            this.CurrencyShortcutLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.InvestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.AddInvestmentButton = new System.Windows.Forms.Button();
            this.CreateInvestmentGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CreateInvestmentbutton = new System.Windows.Forms.Button();
            this.InvestmentNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.InvestemntTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.CreateTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeNameTextBox = new System.Windows.Forms.TextBox();
            this.AddTypeButton = new System.Windows.Forms.Button();
            this.TypeNameLabel = new System.Windows.Forms.Label();
            this.MyInvestmentNameLabel = new System.Windows.Forms.Label();
            this.InvValueLabel = new System.Windows.Forms.Label();
            this.InvValueTextBox = new System.Windows.Forms.TextBox();
            this.AddInvestmentLabel = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            this.CurrencyGroupBox.SuspendLayout();
            this.CreateInvestmentGroupBox.SuspendLayout();
            this.CreateTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.AllowDrop = true;
            this.startPanel.AutoSize = true;
            this.startPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPanel.Controls.Add(this.CurrencyGroupBox);
            this.startPanel.Controls.Add(this.AmountTextBox);
            this.startPanel.Controls.Add(this.AmountLabel);
            this.startPanel.Controls.Add(this.DateLabel);
            this.startPanel.Controls.Add(this.InvestDateTimePicker);
            this.startPanel.Controls.Add(this.NameComboBox);
            this.startPanel.Controls.Add(this.AddInvestmentButton);
            this.startPanel.Controls.Add(this.CreateInvestmentGroupBox);
            this.startPanel.Controls.Add(this.ValueLabel);
            this.startPanel.Controls.Add(this.RateTextBox);
            this.startPanel.Controls.Add(this.CreateTypeGroupBox);
            this.startPanel.Controls.Add(this.MyInvestmentNameLabel);
            this.startPanel.Controls.Add(this.InvValueLabel);
            this.startPanel.Controls.Add(this.InvValueTextBox);
            this.startPanel.Controls.Add(this.AddInvestmentLabel);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Margin = new System.Windows.Forms.Padding(4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(883, 595);
            this.startPanel.TabIndex = 0;
            // 
            // CurrencyGroupBox
            // 
            this.CurrencyGroupBox.Controls.Add(this.CreateCurrencyButton);
            this.CurrencyGroupBox.Controls.Add(this.CurrencyDataSourceTextBox);
            this.CurrencyGroupBox.Controls.Add(this.CurrencyShortcutTextBox);
            this.CurrencyGroupBox.Controls.Add(this.CurrencyDataSourceLabel);
            this.CurrencyGroupBox.Controls.Add(this.CurrencyShortcutLabel);
            this.CurrencyGroupBox.Location = new System.Drawing.Point(440, 89);
            this.CurrencyGroupBox.Name = "CurrencyGroupBox";
            this.CurrencyGroupBox.Size = new System.Drawing.Size(402, 221);
            this.CurrencyGroupBox.TabIndex = 19;
            this.CurrencyGroupBox.TabStop = false;
            this.CurrencyGroupBox.Text = "Create Currency";
            // 
            // CreateCurrencyButton
            // 
            this.CreateCurrencyButton.Location = new System.Drawing.Point(107, 156);
            this.CreateCurrencyButton.Name = "CreateCurrencyButton";
            this.CreateCurrencyButton.Size = new System.Drawing.Size(175, 47);
            this.CreateCurrencyButton.TabIndex = 5;
            this.CreateCurrencyButton.Text = "Create currency";
            this.CreateCurrencyButton.UseVisualStyleBackColor = true;
            this.CreateCurrencyButton.Click += new System.EventHandler(this.CreateCurrencyButton_Click);
            // 
            // CurrencyDataSourceTextBox
            // 
            this.CurrencyDataSourceTextBox.Location = new System.Drawing.Point(144, 95);
            this.CurrencyDataSourceTextBox.Name = "CurrencyDataSourceTextBox";
            this.CurrencyDataSourceTextBox.Size = new System.Drawing.Size(241, 32);
            this.CurrencyDataSourceTextBox.TabIndex = 4;
            // 
            // CurrencyShortcutTextBox
            // 
            this.CurrencyShortcutTextBox.Location = new System.Drawing.Point(144, 44);
            this.CurrencyShortcutTextBox.Name = "CurrencyShortcutTextBox";
            this.CurrencyShortcutTextBox.Size = new System.Drawing.Size(241, 32);
            this.CurrencyShortcutTextBox.TabIndex = 3;
            // 
            // CurrencyDataSourceLabel
            // 
            this.CurrencyDataSourceLabel.AutoSize = true;
            this.CurrencyDataSourceLabel.Location = new System.Drawing.Point(24, 96);
            this.CurrencyDataSourceLabel.Name = "CurrencyDataSourceLabel";
            this.CurrencyDataSourceLabel.Size = new System.Drawing.Size(116, 24);
            this.CurrencyDataSourceLabel.TabIndex = 2;
            this.CurrencyDataSourceLabel.Text = "DataSource";
            // 
            // CurrencyShortcutLabel
            // 
            this.CurrencyShortcutLabel.AutoSize = true;
            this.CurrencyShortcutLabel.Location = new System.Drawing.Point(50, 47);
            this.CurrencyShortcutLabel.Name = "CurrencyShortcutLabel";
            this.CurrencyShortcutLabel.Size = new System.Drawing.Size(88, 24);
            this.CurrencyShortcutLabel.TabIndex = 0;
            this.CurrencyShortcutLabel.Text = "Shortcut";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(195, 245);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(188, 32);
            this.AmountTextBox.TabIndex = 18;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(109, 245);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(80, 24);
            this.AmountLabel.TabIndex = 17;
            this.AmountLabel.Text = "Amount";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(137, 297);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(52, 24);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // InvestDateTimePicker
            // 
            this.InvestDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvestDateTimePicker.Location = new System.Drawing.Point(195, 294);
            this.InvestDateTimePicker.Name = "InvestDateTimePicker";
            this.InvestDateTimePicker.Size = new System.Drawing.Size(188, 32);
            this.InvestDateTimePicker.TabIndex = 15;
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(195, 89);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(188, 32);
            this.NameComboBox.TabIndex = 14;
            // 
            // AddInvestmentButton
            // 
            this.AddInvestmentButton.Location = new System.Drawing.Point(194, 350);
            this.AddInvestmentButton.Name = "AddInvestmentButton";
            this.AddInvestmentButton.Size = new System.Drawing.Size(187, 59);
            this.AddInvestmentButton.TabIndex = 12;
            this.AddInvestmentButton.Text = "Add my investment";
            this.AddInvestmentButton.UseVisualStyleBackColor = true;
            this.AddInvestmentButton.Click += new System.EventHandler(this.AddInvestmentButton_Click);
            // 
            // CreateInvestmentGroupBox
            // 
            this.CreateInvestmentGroupBox.Controls.Add(this.CurrencyComboBox);
            this.CreateInvestmentGroupBox.Controls.Add(this.CurrencyLabel);
            this.CreateInvestmentGroupBox.Controls.Add(this.CreateInvestmentbutton);
            this.CreateInvestmentGroupBox.Controls.Add(this.InvestmentNameLabel);
            this.CreateInvestmentGroupBox.Controls.Add(this.NameTextBox);
            this.CreateInvestmentGroupBox.Controls.Add(this.TypeLabel);
            this.CreateInvestmentGroupBox.Controls.Add(this.InvestemntTypeComboBox);
            this.CreateInvestmentGroupBox.Controls.Add(this.DataSourceLabel);
            this.CreateInvestmentGroupBox.Controls.Add(this.DataSourceTextBox);
            this.CreateInvestmentGroupBox.Location = new System.Drawing.Point(440, 316);
            this.CreateInvestmentGroupBox.Name = "CreateInvestmentGroupBox";
            this.CreateInvestmentGroupBox.Size = new System.Drawing.Size(402, 273);
            this.CreateInvestmentGroupBox.TabIndex = 13;
            this.CreateInvestmentGroupBox.TabStop = false;
            this.CreateInvestmentGroupBox.Text = "Create Investment";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(178, 169);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(188, 32);
            this.CurrencyComboBox.TabIndex = 16;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(73, 171);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(93, 24);
            this.CurrencyLabel.TabIndex = 15;
            this.CurrencyLabel.Text = "Currency";
            // 
            // CreateInvestmentbutton
            // 
            this.CreateInvestmentbutton.Location = new System.Drawing.Point(92, 216);
            this.CreateInvestmentbutton.Name = "CreateInvestmentbutton";
            this.CreateInvestmentbutton.Size = new System.Drawing.Size(219, 47);
            this.CreateInvestmentbutton.TabIndex = 14;
            this.CreateInvestmentbutton.Text = "Create Investment";
            this.CreateInvestmentbutton.UseVisualStyleBackColor = true;
            this.CreateInvestmentbutton.Click += new System.EventHandler(this.CreateInvestmentbutton_Click);
            // 
            // InvestmentNameLabel
            // 
            this.InvestmentNameLabel.AutoSize = true;
            this.InvestmentNameLabel.Location = new System.Drawing.Point(103, 85);
            this.InvestmentNameLabel.Name = "InvestmentNameLabel";
            this.InvestmentNameLabel.Size = new System.Drawing.Size(63, 24);
            this.InvestmentNameLabel.TabIndex = 13;
            this.InvestmentNameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(178, 83);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 32);
            this.NameTextBox.TabIndex = 12;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(11, 42);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(155, 24);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Investment type";
            // 
            // InvestemntTypeComboBox
            // 
            this.InvestemntTypeComboBox.FormattingEnabled = true;
            this.InvestemntTypeComboBox.Location = new System.Drawing.Point(178, 40);
            this.InvestemntTypeComboBox.Name = "InvestemntTypeComboBox";
            this.InvestemntTypeComboBox.Size = new System.Drawing.Size(188, 32);
            this.InvestemntTypeComboBox.TabIndex = 5;
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(45, 128);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(121, 24);
            this.DataSourceLabel.TabIndex = 11;
            this.DataSourceLabel.Text = "Data Source";
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(178, 126);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(188, 32);
            this.DataSourceTextBox.TabIndex = 10;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(137, 193);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(52, 24);
            this.ValueLabel.TabIndex = 9;
            this.ValueLabel.Text = "Rate";
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(195, 193);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(188, 32);
            this.RateTextBox.TabIndex = 8;
            // 
            // CreateTypeGroupBox
            // 
            this.CreateTypeGroupBox.Controls.Add(this.TypeNameTextBox);
            this.CreateTypeGroupBox.Controls.Add(this.AddTypeButton);
            this.CreateTypeGroupBox.Controls.Add(this.TypeNameLabel);
            this.CreateTypeGroupBox.Location = new System.Drawing.Point(50, 424);
            this.CreateTypeGroupBox.Name = "CreateTypeGroupBox";
            this.CreateTypeGroupBox.Size = new System.Drawing.Size(353, 166);
            this.CreateTypeGroupBox.TabIndex = 6;
            this.CreateTypeGroupBox.TabStop = false;
            this.CreateTypeGroupBox.Text = "Create type";
            // 
            // TypeNameTextBox
            // 
            this.TypeNameTextBox.Location = new System.Drawing.Point(135, 49);
            this.TypeNameTextBox.Name = "TypeNameTextBox";
            this.TypeNameTextBox.Size = new System.Drawing.Size(180, 32);
            this.TypeNameTextBox.TabIndex = 1;
            // 
            // AddTypeButton
            // 
            this.AddTypeButton.Location = new System.Drawing.Point(91, 100);
            this.AddTypeButton.Name = "AddTypeButton";
            this.AddTypeButton.Size = new System.Drawing.Size(142, 50);
            this.AddTypeButton.TabIndex = 2;
            this.AddTypeButton.Text = "Create type";
            this.AddTypeButton.UseVisualStyleBackColor = true;
            this.AddTypeButton.Click += new System.EventHandler(this.AddTypeButton_Click);
            // 
            // TypeNameLabel
            // 
            this.TypeNameLabel.AutoSize = true;
            this.TypeNameLabel.Location = new System.Drawing.Point(6, 52);
            this.TypeNameLabel.Name = "TypeNameLabel";
            this.TypeNameLabel.Size = new System.Drawing.Size(106, 24);
            this.TypeNameLabel.TabIndex = 0;
            this.TypeNameLabel.Text = "Type name";
            // 
            // MyInvestmentNameLabel
            // 
            this.MyInvestmentNameLabel.AutoSize = true;
            this.MyInvestmentNameLabel.Location = new System.Drawing.Point(126, 89);
            this.MyInvestmentNameLabel.Name = "MyInvestmentNameLabel";
            this.MyInvestmentNameLabel.Size = new System.Drawing.Size(63, 24);
            this.MyInvestmentNameLabel.TabIndex = 4;
            this.MyInvestmentNameLabel.Text = "Name";
            // 
            // InvValueLabel
            // 
            this.InvValueLabel.AutoSize = true;
            this.InvValueLabel.Location = new System.Drawing.Point(46, 141);
            this.InvValueLabel.Name = "InvValueLabel";
            this.InvValueLabel.Size = new System.Drawing.Size(143, 24);
            this.InvValueLabel.TabIndex = 2;
            this.InvValueLabel.Text = "Invested (PLN)";
            // 
            // InvValueTextBox
            // 
            this.InvValueTextBox.Location = new System.Drawing.Point(195, 141);
            this.InvValueTextBox.Name = "InvValueTextBox";
            this.InvValueTextBox.Size = new System.Drawing.Size(188, 32);
            this.InvValueTextBox.TabIndex = 1;
            // 
            // AddInvestmentLabel
            // 
            this.AddInvestmentLabel.AutoSize = true;
            this.AddInvestmentLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.AddInvestmentLabel.ForeColor = System.Drawing.Color.Navy;
            this.AddInvestmentLabel.Location = new System.Drawing.Point(332, 19);
            this.AddInvestmentLabel.Name = "AddInvestmentLabel";
            this.AddInvestmentLabel.Size = new System.Drawing.Size(216, 33);
            this.AddInvestmentLabel.TabIndex = 0;
            this.AddInvestmentLabel.Text = "New inwestment";
            // 
            // InvestmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(883, 595);
            this.Controls.Add(this.startPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InvestmentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestmentApp";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.CurrencyGroupBox.ResumeLayout(false);
            this.CurrencyGroupBox.PerformLayout();
            this.CreateInvestmentGroupBox.ResumeLayout(false);
            this.CreateInvestmentGroupBox.PerformLayout();
            this.CreateTypeGroupBox.ResumeLayout(false);
            this.CreateTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label AddInvestmentLabel;
        private System.Windows.Forms.Label InvValueLabel;
        private System.Windows.Forms.TextBox InvValueTextBox;
        private System.Windows.Forms.Label MyInvestmentNameLabel;
        private System.Windows.Forms.ComboBox InvestemntTypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.GroupBox CreateTypeGroupBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Button AddTypeButton;
        private System.Windows.Forms.TextBox TypeNameTextBox;
        private System.Windows.Forms.Label TypeNameLabel;
        private System.Windows.Forms.Button AddInvestmentButton;
        private System.Windows.Forms.GroupBox CreateInvestmentGroupBox;
        private System.Windows.Forms.Label InvestmentNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Button CreateInvestmentbutton;
        private System.Windows.Forms.DateTimePicker InvestDateTimePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.GroupBox CurrencyGroupBox;
        private System.Windows.Forms.Label CurrencyShortcutLabel;
        private System.Windows.Forms.Label CurrencyDataSourceLabel;
        private System.Windows.Forms.Button CreateCurrencyButton;
        private System.Windows.Forms.TextBox CurrencyDataSourceTextBox;
        private System.Windows.Forms.TextBox CurrencyShortcutTextBox;
    }
}