namespace Assignment_3
{
    partial class main
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxTxtBox = new System.Windows.Forms.TextBox();
            this.TxOk_LED = new Bulb.LedBulb();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.BaudComboBox = new System.Windows.Forms.ComboBox();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.COMPort = new System.Windows.Forms.TextBox();
            this.TX_CONNECT_BUTTON = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Refresh = new System.Windows.Forms.Button();
            this.sSeg_2 = new DmitryBrant.CustomControls.SevenSegment();
            this.sSeg_1 = new DmitryBrant.CustomControls.SevenSegment();
            this.PC7_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC6_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC5_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC4_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC3_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC2_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC1_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PC0_CHEKBOX = new System.Windows.Forms.CheckBox();
            this.PA7_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA6_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA5_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA4_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA3_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA2_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA1_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA0_LED_TXT = new System.Windows.Forms.TextBox();
            this.PA7_LED = new Bulb.LedBulb();
            this.PA6_LED = new Bulb.LedBulb();
            this.PA5_LED = new Bulb.LedBulb();
            this.PA4_LED = new Bulb.LedBulb();
            this.PA3_LED = new Bulb.LedBulb();
            this.PA2_LED = new Bulb.LedBulb();
            this.PA1_LED = new Bulb.LedBulb();
            this.PA0_LED = new Bulb.LedBulb();
            this.PORTC_TXT = new System.Windows.Forms.TextBox();
            this.PINA_TXT = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.AqGu1 = new AquaControls.AquaGauge();
            this.AqGu2 = new AquaControls.AquaGauge();
            this.POT1_TXT = new System.Windows.Forms.TextBox();
            this.POT2_TXT = new System.Windows.Forms.TextBox();
            this.aquaGauge1 = new AquaControls.AquaGauge();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 314);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxTxtBox);
            this.tabPage1.Controls.Add(this.TxOk_LED);
            this.tabPage1.Controls.Add(this.Baudrate);
            this.tabPage1.Controls.Add(this.BaudComboBox);
            this.tabPage1.Controls.Add(this.COMComboBox);
            this.tabPage1.Controls.Add(this.COMPort);
            this.tabPage1.Controls.Add(this.TX_CONNECT_BUTTON);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TxTxtBox
            // 
            this.TxTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTxtBox.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTxtBox.Location = new System.Drawing.Point(334, 181);
            this.TxTxtBox.Name = "TxTxtBox";
            this.TxTxtBox.Size = new System.Drawing.Size(92, 15);
            this.TxTxtBox.TabIndex = 8;
            this.TxTxtBox.Text = "Transmition OK";
            // 
            // TxOk_LED
            // 
            this.TxOk_LED.BackColor = System.Drawing.Color.Transparent;
            this.TxOk_LED.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxOk_LED.Location = new System.Drawing.Point(304, 176);
            this.TxOk_LED.Name = "TxOk_LED";
            this.TxOk_LED.On = true;
            this.TxOk_LED.Size = new System.Drawing.Size(23, 23);
            this.TxOk_LED.TabIndex = 7;
            this.TxOk_LED.Text = "Tx Ok";
            this.TxOk_LED.Click += new System.EventHandler(this.ledBulb1_Click);
            // 
            // Baudrate
            // 
            this.Baudrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Baudrate.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baudrate.Location = new System.Drawing.Point(89, 130);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(99, 15);
            this.Baudrate.TabIndex = 6;
            this.Baudrate.Text = "Baurdrate";
            this.Baudrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.FormattingEnabled = true;
            this.BaudComboBox.Location = new System.Drawing.Point(195, 127);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.Size = new System.Drawing.Size(120, 21);
            this.BaudComboBox.TabIndex = 5;
            // 
            // COMComboBox
            // 
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Location = new System.Drawing.Point(195, 80);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(120, 21);
            this.COMComboBox.TabIndex = 4;
            this.COMComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // COMPort
            // 
            this.COMPort.BackColor = System.Drawing.Color.White;
            this.COMPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMPort.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPort.Location = new System.Drawing.Point(89, 83);
            this.COMPort.Name = "COMPort";
            this.COMPort.Size = new System.Drawing.Size(99, 15);
            this.COMPort.TabIndex = 3;
            this.COMPort.Text = "COM Port";
            this.COMPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.COMPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TX_CONNECT_BUTTON
            // 
            this.TX_CONNECT_BUTTON.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_CONNECT_BUTTON.Location = new System.Drawing.Point(195, 176);
            this.TX_CONNECT_BUTTON.Name = "TX_CONNECT_BUTTON";
            this.TX_CONNECT_BUTTON.Size = new System.Drawing.Size(74, 23);
            this.TX_CONNECT_BUTTON.TabIndex = 1;
            this.TX_CONNECT_BUTTON.Text = "Connect";
            this.TX_CONNECT_BUTTON.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Refresh);
            this.tabPage2.Controls.Add(this.sSeg_2);
            this.tabPage2.Controls.Add(this.sSeg_1);
            this.tabPage2.Controls.Add(this.PC7_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC6_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC5_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC4_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC3_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC2_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC1_CHEKBOX);
            this.tabPage2.Controls.Add(this.PC0_CHEKBOX);
            this.tabPage2.Controls.Add(this.PA7_LED_TXT);
            this.tabPage2.Controls.Add(this.PA6_LED_TXT);
            this.tabPage2.Controls.Add(this.PA5_LED_TXT);
            this.tabPage2.Controls.Add(this.PA4_LED_TXT);
            this.tabPage2.Controls.Add(this.PA3_LED_TXT);
            this.tabPage2.Controls.Add(this.PA2_LED_TXT);
            this.tabPage2.Controls.Add(this.PA1_LED_TXT);
            this.tabPage2.Controls.Add(this.PA0_LED_TXT);
            this.tabPage2.Controls.Add(this.PA7_LED);
            this.tabPage2.Controls.Add(this.PA6_LED);
            this.tabPage2.Controls.Add(this.PA5_LED);
            this.tabPage2.Controls.Add(this.PA4_LED);
            this.tabPage2.Controls.Add(this.PA3_LED);
            this.tabPage2.Controls.Add(this.PA2_LED);
            this.tabPage2.Controls.Add(this.PA1_LED);
            this.tabPage2.Controls.Add(this.PA0_LED);
            this.tabPage2.Controls.Add(this.PORTC_TXT);
            this.tabPage2.Controls.Add(this.PINA_TXT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital I/O";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(362, 235);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 36;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // sSeg_2
            // 
            this.sSeg_2.ColonOn = false;
            this.sSeg_2.ColonShow = false;
            this.sSeg_2.ColorBackground = System.Drawing.Color.DarkGray;
            this.sSeg_2.ColorDark = System.Drawing.Color.DimGray;
            this.sSeg_2.ColorLight = System.Drawing.Color.Red;
            this.sSeg_2.CustomPattern = 0;
            this.sSeg_2.DecimalOn = false;
            this.sSeg_2.DecimalShow = true;
            this.sSeg_2.ElementWidth = 10;
            this.sSeg_2.ItalicFactor = 0F;
            this.sSeg_2.Location = new System.Drawing.Point(391, 104);
            this.sSeg_2.Name = "sSeg_2";
            this.sSeg_2.Padding = new System.Windows.Forms.Padding(4);
            this.sSeg_2.Size = new System.Drawing.Size(46, 80);
            this.sSeg_2.TabIndex = 35;
            this.sSeg_2.TabStop = false;
            this.sSeg_2.Value = null;
            // 
            // sSeg_1
            // 
            this.sSeg_1.ColonOn = false;
            this.sSeg_1.ColonShow = false;
            this.sSeg_1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sSeg_1.ColorDark = System.Drawing.Color.DimGray;
            this.sSeg_1.ColorLight = System.Drawing.Color.Red;
            this.sSeg_1.CustomPattern = 0;
            this.sSeg_1.DecimalOn = false;
            this.sSeg_1.DecimalShow = true;
            this.sSeg_1.ElementWidth = 10;
            this.sSeg_1.ItalicFactor = 0F;
            this.sSeg_1.Location = new System.Drawing.Point(339, 103);
            this.sSeg_1.Name = "sSeg_1";
            this.sSeg_1.Padding = new System.Windows.Forms.Padding(4);
            this.sSeg_1.Size = new System.Drawing.Size(46, 80);
            this.sSeg_1.TabIndex = 34;
            this.sSeg_1.TabStop = false;
            this.sSeg_1.Value = null;
            // 
            // PC7_CHEKBOX
            // 
            this.PC7_CHEKBOX.AutoSize = true;
            this.PC7_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC7_CHEKBOX.Location = new System.Drawing.Point(263, 241);
            this.PC7_CHEKBOX.Name = "PC7_CHEKBOX";
            this.PC7_CHEKBOX.Size = new System.Drawing.Size(50, 20);
            this.PC7_CHEKBOX.TabIndex = 33;
            this.PC7_CHEKBOX.Text = "PC7";
            this.PC7_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC6_CHEKBOX
            // 
            this.PC6_CHEKBOX.AutoSize = true;
            this.PC6_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC6_CHEKBOX.Location = new System.Drawing.Point(263, 215);
            this.PC6_CHEKBOX.Name = "PC6_CHEKBOX";
            this.PC6_CHEKBOX.Size = new System.Drawing.Size(49, 20);
            this.PC6_CHEKBOX.TabIndex = 32;
            this.PC6_CHEKBOX.Text = "PC6";
            this.PC6_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC5_CHEKBOX
            // 
            this.PC5_CHEKBOX.AutoSize = true;
            this.PC5_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC5_CHEKBOX.Location = new System.Drawing.Point(263, 189);
            this.PC5_CHEKBOX.Name = "PC5_CHEKBOX";
            this.PC5_CHEKBOX.Size = new System.Drawing.Size(49, 20);
            this.PC5_CHEKBOX.TabIndex = 31;
            this.PC5_CHEKBOX.Text = "PC5";
            this.PC5_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC4_CHEKBOX
            // 
            this.PC4_CHEKBOX.AutoSize = true;
            this.PC4_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC4_CHEKBOX.Location = new System.Drawing.Point(263, 163);
            this.PC4_CHEKBOX.Name = "PC4_CHEKBOX";
            this.PC4_CHEKBOX.Size = new System.Drawing.Size(49, 20);
            this.PC4_CHEKBOX.TabIndex = 30;
            this.PC4_CHEKBOX.Text = "PC4";
            this.PC4_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC3_CHEKBOX
            // 
            this.PC3_CHEKBOX.AutoSize = true;
            this.PC3_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC3_CHEKBOX.Location = new System.Drawing.Point(263, 137);
            this.PC3_CHEKBOX.Name = "PC3_CHEKBOX";
            this.PC3_CHEKBOX.Size = new System.Drawing.Size(49, 20);
            this.PC3_CHEKBOX.TabIndex = 29;
            this.PC3_CHEKBOX.Text = "PC3";
            this.PC3_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC2_CHEKBOX
            // 
            this.PC2_CHEKBOX.AutoSize = true;
            this.PC2_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC2_CHEKBOX.Location = new System.Drawing.Point(263, 111);
            this.PC2_CHEKBOX.Name = "PC2_CHEKBOX";
            this.PC2_CHEKBOX.Size = new System.Drawing.Size(50, 20);
            this.PC2_CHEKBOX.TabIndex = 28;
            this.PC2_CHEKBOX.Text = "PC2";
            this.PC2_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC1_CHEKBOX
            // 
            this.PC1_CHEKBOX.AutoSize = true;
            this.PC1_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC1_CHEKBOX.Location = new System.Drawing.Point(263, 85);
            this.PC1_CHEKBOX.Name = "PC1_CHEKBOX";
            this.PC1_CHEKBOX.Size = new System.Drawing.Size(49, 20);
            this.PC1_CHEKBOX.TabIndex = 27;
            this.PC1_CHEKBOX.Text = "PC1";
            this.PC1_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PC0_CHEKBOX
            // 
            this.PC0_CHEKBOX.AutoSize = true;
            this.PC0_CHEKBOX.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC0_CHEKBOX.Location = new System.Drawing.Point(264, 59);
            this.PC0_CHEKBOX.Name = "PC0_CHEKBOX";
            this.PC0_CHEKBOX.Size = new System.Drawing.Size(51, 20);
            this.PC0_CHEKBOX.TabIndex = 26;
            this.PC0_CHEKBOX.Text = "PC0";
            this.PC0_CHEKBOX.UseVisualStyleBackColor = true;
            // 
            // PA7_LED_TXT
            // 
            this.PA7_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA7_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA7_LED_TXT.Location = new System.Drawing.Point(116, 246);
            this.PA7_LED_TXT.Name = "PA7_LED_TXT";
            this.PA7_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA7_LED_TXT.TabIndex = 17;
            this.PA7_LED_TXT.Text = "PA7";
            // 
            // PA6_LED_TXT
            // 
            this.PA6_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA6_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA6_LED_TXT.Location = new System.Drawing.Point(116, 220);
            this.PA6_LED_TXT.Name = "PA6_LED_TXT";
            this.PA6_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA6_LED_TXT.TabIndex = 16;
            this.PA6_LED_TXT.Text = "PA6";
            // 
            // PA5_LED_TXT
            // 
            this.PA5_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA5_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA5_LED_TXT.Location = new System.Drawing.Point(116, 194);
            this.PA5_LED_TXT.Name = "PA5_LED_TXT";
            this.PA5_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA5_LED_TXT.TabIndex = 15;
            this.PA5_LED_TXT.Text = "PA5";
            // 
            // PA4_LED_TXT
            // 
            this.PA4_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA4_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA4_LED_TXT.Location = new System.Drawing.Point(116, 168);
            this.PA4_LED_TXT.Name = "PA4_LED_TXT";
            this.PA4_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA4_LED_TXT.TabIndex = 14;
            this.PA4_LED_TXT.Text = "PA4";
            // 
            // PA3_LED_TXT
            // 
            this.PA3_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA3_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA3_LED_TXT.Location = new System.Drawing.Point(116, 142);
            this.PA3_LED_TXT.Name = "PA3_LED_TXT";
            this.PA3_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA3_LED_TXT.TabIndex = 13;
            this.PA3_LED_TXT.Text = "PA3";
            // 
            // PA2_LED_TXT
            // 
            this.PA2_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA2_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA2_LED_TXT.Location = new System.Drawing.Point(116, 116);
            this.PA2_LED_TXT.Name = "PA2_LED_TXT";
            this.PA2_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA2_LED_TXT.TabIndex = 12;
            this.PA2_LED_TXT.Text = "PA2";
            // 
            // PA1_LED_TXT
            // 
            this.PA1_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA1_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA1_LED_TXT.Location = new System.Drawing.Point(116, 90);
            this.PA1_LED_TXT.Name = "PA1_LED_TXT";
            this.PA1_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA1_LED_TXT.TabIndex = 11;
            this.PA1_LED_TXT.Text = "PA1";
            this.PA1_LED_TXT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PA0_LED_TXT
            // 
            this.PA0_LED_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PA0_LED_TXT.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PA0_LED_TXT.Location = new System.Drawing.Point(116, 64);
            this.PA0_LED_TXT.Name = "PA0_LED_TXT";
            this.PA0_LED_TXT.Size = new System.Drawing.Size(32, 15);
            this.PA0_LED_TXT.TabIndex = 10;
            this.PA0_LED_TXT.Text = "PA0";
            this.PA0_LED_TXT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PA7_LED
            // 
            this.PA7_LED.Location = new System.Drawing.Point(73, 246);
            this.PA7_LED.Name = "PA7_LED";
            this.PA7_LED.On = true;
            this.PA7_LED.Size = new System.Drawing.Size(15, 15);
            this.PA7_LED.TabIndex = 9;
            this.PA7_LED.Text = "ledBulb8";
            // 
            // PA6_LED
            // 
            this.PA6_LED.Location = new System.Drawing.Point(73, 220);
            this.PA6_LED.Name = "PA6_LED";
            this.PA6_LED.On = true;
            this.PA6_LED.Size = new System.Drawing.Size(15, 15);
            this.PA6_LED.TabIndex = 8;
            this.PA6_LED.Text = "ledBulb7";
            // 
            // PA5_LED
            // 
            this.PA5_LED.Location = new System.Drawing.Point(73, 194);
            this.PA5_LED.Name = "PA5_LED";
            this.PA5_LED.On = true;
            this.PA5_LED.Size = new System.Drawing.Size(15, 15);
            this.PA5_LED.TabIndex = 7;
            this.PA5_LED.Text = "ledBulb6";
            // 
            // PA4_LED
            // 
            this.PA4_LED.Location = new System.Drawing.Point(73, 168);
            this.PA4_LED.Name = "PA4_LED";
            this.PA4_LED.On = true;
            this.PA4_LED.Size = new System.Drawing.Size(15, 15);
            this.PA4_LED.TabIndex = 6;
            this.PA4_LED.Text = "ledBulb5";
            // 
            // PA3_LED
            // 
            this.PA3_LED.Location = new System.Drawing.Point(73, 142);
            this.PA3_LED.Name = "PA3_LED";
            this.PA3_LED.On = true;
            this.PA3_LED.Size = new System.Drawing.Size(15, 15);
            this.PA3_LED.TabIndex = 5;
            this.PA3_LED.Text = "ledBulb4";
            // 
            // PA2_LED
            // 
            this.PA2_LED.Location = new System.Drawing.Point(73, 116);
            this.PA2_LED.Name = "PA2_LED";
            this.PA2_LED.On = true;
            this.PA2_LED.Size = new System.Drawing.Size(15, 15);
            this.PA2_LED.TabIndex = 4;
            this.PA2_LED.Text = "ledBulb3";
            // 
            // PA1_LED
            // 
            this.PA1_LED.Location = new System.Drawing.Point(73, 90);
            this.PA1_LED.Name = "PA1_LED";
            this.PA1_LED.On = true;
            this.PA1_LED.Size = new System.Drawing.Size(15, 15);
            this.PA1_LED.TabIndex = 3;
            this.PA1_LED.Text = "ledBulb2";
            // 
            // PA0_LED
            // 
            this.PA0_LED.Location = new System.Drawing.Point(73, 64);
            this.PA0_LED.Name = "PA0_LED";
            this.PA0_LED.On = true;
            this.PA0_LED.Size = new System.Drawing.Size(15, 15);
            this.PA0_LED.TabIndex = 2;
            this.PA0_LED.Text = "ledBulb1";
            // 
            // PORTC_TXT
            // 
            this.PORTC_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PORTC_TXT.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORTC_TXT.Location = new System.Drawing.Point(279, 27);
            this.PORTC_TXT.Name = "PORTC_TXT";
            this.PORTC_TXT.Size = new System.Drawing.Size(100, 20);
            this.PORTC_TXT.TabIndex = 1;
            this.PORTC_TXT.Text = "PORTC";
            this.PORTC_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORTC_TXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PINA_TXT
            // 
            this.PINA_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PINA_TXT.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINA_TXT.Location = new System.Drawing.Point(52, 27);
            this.PINA_TXT.Name = "PINA_TXT";
            this.PINA_TXT.Size = new System.Drawing.Size(108, 20);
            this.PINA_TXT.TabIndex = 0;
            this.PINA_TXT.Text = "PINA";
            this.PINA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.POT2_TXT);
            this.tabPage3.Controls.Add(this.POT1_TXT);
            this.tabPage3.Controls.Add(this.AqGu2);
            this.tabPage3.Controls.Add(this.AqGu1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(508, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pots";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.aquaGauge1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(508, 288);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Light";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(508, 288);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Temp Control";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AqGu1
            // 
            this.AqGu1.BackColor = System.Drawing.Color.Transparent;
            this.AqGu1.DialColor = System.Drawing.Color.Lavender;
            this.AqGu1.DialText = null;
            this.AqGu1.Glossiness = 11.36364F;
            this.AqGu1.Location = new System.Drawing.Point(73, 71);
            this.AqGu1.MaxValue = 0F;
            this.AqGu1.MinValue = 0F;
            this.AqGu1.Name = "AqGu1";
            this.AqGu1.RecommendedValue = 0F;
            this.AqGu1.Size = new System.Drawing.Size(150, 150);
            this.AqGu1.TabIndex = 0;
            this.AqGu1.ThresholdPercent = 0F;
            this.AqGu1.Value = 0F;
            // 
            // AqGu2
            // 
            this.AqGu2.BackColor = System.Drawing.Color.Transparent;
            this.AqGu2.DialColor = System.Drawing.Color.Lavender;
            this.AqGu2.DialText = null;
            this.AqGu2.Glossiness = 11.36364F;
            this.AqGu2.Location = new System.Drawing.Point(273, 71);
            this.AqGu2.MaxValue = 0F;
            this.AqGu2.MinValue = 0F;
            this.AqGu2.Name = "AqGu2";
            this.AqGu2.RecommendedValue = 0F;
            this.AqGu2.Size = new System.Drawing.Size(150, 150);
            this.AqGu2.TabIndex = 1;
            this.AqGu2.ThresholdPercent = 0F;
            this.AqGu2.Value = 0F;
            // 
            // POT1_TXT
            // 
            this.POT1_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.POT1_TXT.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POT1_TXT.Location = new System.Drawing.Point(85, 45);
            this.POT1_TXT.Name = "POT1_TXT";
            this.POT1_TXT.Size = new System.Drawing.Size(125, 20);
            this.POT1_TXT.TabIndex = 2;
            this.POT1_TXT.Text = "POT1 Voltage";
            this.POT1_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // POT2_TXT
            // 
            this.POT2_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.POT2_TXT.Font = new System.Drawing.Font("Kristen ITC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POT2_TXT.Location = new System.Drawing.Point(284, 45);
            this.POT2_TXT.Name = "POT2_TXT";
            this.POT2_TXT.Size = new System.Drawing.Size(129, 20);
            this.POT2_TXT.TabIndex = 3;
            this.POT2_TXT.Text = "POT2 Voltage";
            this.POT2_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aquaGauge1
            // 
            this.aquaGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aquaGauge1.DialColor = System.Drawing.Color.Lavender;
            this.aquaGauge1.DialText = null;
            this.aquaGauge1.Glossiness = 11.36364F;
            this.aquaGauge1.Location = new System.Drawing.Point(288, 64);
            this.aquaGauge1.MaxValue = 0F;
            this.aquaGauge1.MinValue = 0F;
            this.aquaGauge1.Name = "aquaGauge1";
            this.aquaGauge1.RecommendedValue = 0F;
            this.aquaGauge1.Size = new System.Drawing.Size(150, 150);
            this.aquaGauge1.TabIndex = 0;
            this.aquaGauge1.ThresholdPercent = 0F;
            this.aquaGauge1.Value = 0F;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "MCU Control GUI";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox COMPort;
        private System.Windows.Forms.Button TX_CONNECT_BUTTON;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.ComboBox BaudComboBox;
        private System.Windows.Forms.ComboBox COMComboBox;
        private Bulb.LedBulb TxOk_LED;
        private System.Windows.Forms.TextBox TxTxtBox;
        private System.Windows.Forms.TextBox PINA_TXT;
        private System.Windows.Forms.TextBox PORTC_TXT;
        private System.Windows.Forms.TextBox PA0_LED_TXT;
        private Bulb.LedBulb PA7_LED;
        private Bulb.LedBulb PA6_LED;
        private Bulb.LedBulb PA5_LED;
        private Bulb.LedBulb PA4_LED;
        private Bulb.LedBulb PA3_LED;
        private Bulb.LedBulb PA2_LED;
        private Bulb.LedBulb PA1_LED;
        private Bulb.LedBulb PA0_LED;
        private System.Windows.Forms.TextBox PA7_LED_TXT;
        private System.Windows.Forms.TextBox PA6_LED_TXT;
        private System.Windows.Forms.TextBox PA5_LED_TXT;
        private System.Windows.Forms.TextBox PA4_LED_TXT;
        private System.Windows.Forms.TextBox PA3_LED_TXT;
        private System.Windows.Forms.TextBox PA2_LED_TXT;
        private System.Windows.Forms.TextBox PA1_LED_TXT;
        private System.Windows.Forms.CheckBox PC7_CHEKBOX;
        private System.Windows.Forms.CheckBox PC6_CHEKBOX;
        private System.Windows.Forms.CheckBox PC5_CHEKBOX;
        private System.Windows.Forms.CheckBox PC4_CHEKBOX;
        private System.Windows.Forms.CheckBox PC3_CHEKBOX;
        private System.Windows.Forms.CheckBox PC2_CHEKBOX;
        private System.Windows.Forms.CheckBox PC1_CHEKBOX;
        private System.Windows.Forms.CheckBox PC0_CHEKBOX;
        private System.Windows.Forms.Button Refresh;
        private DmitryBrant.CustomControls.SevenSegment sSeg_2;
        private DmitryBrant.CustomControls.SevenSegment sSeg_1;
        private AquaControls.AquaGauge AqGu2;
        private AquaControls.AquaGauge AqGu1;
        private System.Windows.Forms.TextBox POT2_TXT;
        private System.Windows.Forms.TextBox POT1_TXT;
        private AquaControls.AquaGauge aquaGauge1;
    }
}

