namespace SerialConnectorForms
{
    partial class Dashboard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chBoxXonXoff = new System.Windows.Forms.CheckBox();
            this.chBoxRts = new System.Windows.Forms.CheckBox();
            this.chBoxDtr = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSend = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENComToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEComToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.transmiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTransmiterToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineTransmiterToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTransmiterEndLineComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.reciverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearReciverToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataReciverToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripReciverShowDataComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnSetXYZ = new System.Windows.Forms.Button();
            this.jogOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chBoxXonXoff);
            this.groupBox1.Controls.Add(this.chBoxRts);
            this.groupBox1.Controls.Add(this.chBoxDtr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxParity);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Ports Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "FLOW CONTROL";
            // 
            // chBoxXonXoff
            // 
            this.chBoxXonXoff.AutoSize = true;
            this.chBoxXonXoff.Location = new System.Drawing.Point(120, 196);
            this.chBoxXonXoff.Name = "chBoxXonXoff";
            this.chBoxXonXoff.Size = new System.Drawing.Size(81, 17);
            this.chBoxXonXoff.TabIndex = 12;
            this.chBoxXonXoff.Text = "XON/XOFF";
            this.chBoxXonXoff.UseVisualStyleBackColor = true;
            this.chBoxXonXoff.CheckedChanged += new System.EventHandler(this.chBoxXonXoff_CheckedChanged);
            // 
            // chBoxRts
            // 
            this.chBoxRts.AutoSize = true;
            this.chBoxRts.Checked = true;
            this.chBoxRts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxRts.Location = new System.Drawing.Point(175, 172);
            this.chBoxRts.Name = "chBoxRts";
            this.chBoxRts.Size = new System.Drawing.Size(74, 17);
            this.chBoxRts.TabIndex = 11;
            this.chBoxRts.Text = "RTS/CTS";
            this.chBoxRts.UseVisualStyleBackColor = true;
            this.chBoxRts.CheckedChanged += new System.EventHandler(this.chBoxRts_CheckedChanged);
            // 
            // chBoxDtr
            // 
            this.chBoxDtr.AutoSize = true;
            this.chBoxDtr.Checked = true;
            this.chBoxDtr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxDtr.Location = new System.Drawing.Point(120, 173);
            this.chBoxDtr.Name = "chBoxDtr";
            this.chBoxDtr.Size = new System.Drawing.Size(49, 17);
            this.chBoxDtr.TabIndex = 10;
            this.chBoxDtr.Text = "DTR";
            this.chBoxDtr.UseVisualStyleBackColor = true;
            this.chBoxDtr.CheckedChanged += new System.EventHandler(this.chBoxDtr_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "STOP BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PARITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORTS";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(103, 125);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(129, 21);
            this.cBoxStopBits.TabIndex = 4;
            this.cBoxStopBits.Text = "Two";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(103, 98);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(129, 21);
            this.cBoxDataBits.TabIndex = 3;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(103, 71);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(129, 21);
            this.cBoxParity.TabIndex = 2;
            this.cBoxParity.Text = "Even";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(103, 42);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(129, 21);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(103, 15);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(129, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(360, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 20);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(0, 17);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tBoxDataOut.Size = new System.Drawing.Size(354, 96);
            this.tBoxDataOut.TabIndex = 2;
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(0, 120);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIn.Size = new System.Drawing.Size(454, 155);
            this.tBoxDataIn.TabIndex = 3;
            this.tBoxDataIn.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cOMControlToolStripMenuItem,
            this.transmiterToolStripMenuItem,
            this.reciverToolStripMenuItem,
            this.jogOperatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // cOMControlToolStripMenuItem
            // 
            this.cOMControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENComToolStripMenu,
            this.cLOSEComToolStripMenu});
            this.cOMControlToolStripMenuItem.Name = "cOMControlToolStripMenuItem";
            this.cOMControlToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.cOMControlToolStripMenuItem.Text = "COM Control";
            // 
            // oPENComToolStripMenu
            // 
            this.oPENComToolStripMenu.Name = "oPENComToolStripMenu";
            this.oPENComToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.oPENComToolStripMenu.Text = "OPEN";
            this.oPENComToolStripMenu.Click += new System.EventHandler(this.oPENComToolStripMenu_Click_1);
            // 
            // cLOSEComToolStripMenu
            // 
            this.cLOSEComToolStripMenu.Name = "cLOSEComToolStripMenu";
            this.cLOSEComToolStripMenu.Size = new System.Drawing.Size(114, 22);
            this.cLOSEComToolStripMenu.Text = "CLOSE";
            this.cLOSEComToolStripMenu.Click += new System.EventHandler(this.cLOSEComToolStripMenu_Click_1);
            // 
            // transmiterToolStripMenuItem
            // 
            this.transmiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTransmiterToolStripMenu,
            this.endLineTransmiterToolStripMenu});
            this.transmiterToolStripMenuItem.Name = "transmiterToolStripMenuItem";
            this.transmiterToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.transmiterToolStripMenuItem.Text = "Transmiter";
            // 
            // clearTransmiterToolStripMenu
            // 
            this.clearTransmiterToolStripMenu.Name = "clearTransmiterToolStripMenu";
            this.clearTransmiterToolStripMenu.Size = new System.Drawing.Size(124, 22);
            this.clearTransmiterToolStripMenu.Text = "Clear";
            this.clearTransmiterToolStripMenu.Click += new System.EventHandler(this.clearTransmiterToolStripMenu_Click);
            // 
            // endLineTransmiterToolStripMenu
            // 
            this.endLineTransmiterToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTransmiterEndLineComboBox});
            this.endLineTransmiterToolStripMenu.Name = "endLineTransmiterToolStripMenu";
            this.endLineTransmiterToolStripMenu.Size = new System.Drawing.Size(124, 22);
            this.endLineTransmiterToolStripMenu.Text = "End Line";
            // 
            // toolStripTransmiterEndLineComboBox
            // 
            this.toolStripTransmiterEndLineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripTransmiterEndLineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripTransmiterEndLineComboBox.Items.AddRange(new object[] {
            "None",
            "Both",
            "New Line"});
            this.toolStripTransmiterEndLineComboBox.Name = "toolStripTransmiterEndLineComboBox";
            this.toolStripTransmiterEndLineComboBox.Size = new System.Drawing.Size(121, 23);
            this.toolStripTransmiterEndLineComboBox.DropDownClosed += new System.EventHandler(this.toolStripTransmiterEndLineComboBox_DropDownClosed);
            // 
            // reciverToolStripMenuItem
            // 
            this.reciverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearReciverToolStripMenu,
            this.showDataReciverToolStripMenu});
            this.reciverToolStripMenuItem.Name = "reciverToolStripMenuItem";
            this.reciverToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.reciverToolStripMenuItem.Text = "Reciver";
            // 
            // clearReciverToolStripMenu
            // 
            this.clearReciverToolStripMenu.Name = "clearReciverToolStripMenu";
            this.clearReciverToolStripMenu.Size = new System.Drawing.Size(168, 22);
            this.clearReciverToolStripMenu.Text = "Clear";
            this.clearReciverToolStripMenu.Click += new System.EventHandler(this.clearReciverToolStripMenu_Click);
            // 
            // showDataReciverToolStripMenu
            // 
            this.showDataReciverToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripReciverShowDataComboBox});
            this.showDataReciverToolStripMenu.Name = "showDataReciverToolStripMenu";
            this.showDataReciverToolStripMenu.Size = new System.Drawing.Size(168, 22);
            this.showDataReciverToolStripMenu.Text = "Show Data With";
            // 
            // toolStripReciverShowDataComboBox
            // 
            this.toolStripReciverShowDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripReciverShowDataComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripReciverShowDataComboBox.Items.AddRange(new object[] {
            "Always Update",
            "Add to Old Data"});
            this.toolStripReciverShowDataComboBox.Name = "toolStripReciverShowDataComboBox";
            this.toolStripReciverShowDataComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tBoxDataOut);
            this.groupBox12.Controls.Add(this.tBoxDataIn);
            this.groupBox12.Controls.Add(this.btnSend);
            this.groupBox12.Location = new System.Drawing.Point(340, 29);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(460, 275);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Monitor";
            // 
            // btnSetXYZ
            // 
            this.btnSetXYZ.Location = new System.Drawing.Point(806, 46);
            this.btnSetXYZ.Name = "btnSetXYZ";
            this.btnSetXYZ.Size = new System.Drawing.Size(117, 23);
            this.btnSetXYZ.TabIndex = 26;
            this.btnSetXYZ.Text = "Set XYZ";
            this.btnSetXYZ.UseVisualStyleBackColor = true;
            this.btnSetXYZ.Click += new System.EventHandler(this.btnSetXYZ_Click);
            // 
            // jogOperatorToolStripMenuItem
            // 
            this.jogOperatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem});
            this.jogOperatorToolStripMenuItem.Name = "jogOperatorToolStripMenuItem";
            this.jogOperatorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.jogOperatorToolStripMenuItem.Text = "Jog Operator";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 335);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSetXYZ);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Connector Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chBoxXonXoff;
        private System.Windows.Forms.CheckBox chBoxRts;
        private System.Windows.Forms.CheckBox chBoxDtr;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineTransmiterToolStripMenu;
        private System.Windows.Forms.ToolStripComboBox toolStripTransmiterEndLineComboBox;
        private System.Windows.Forms.ToolStripMenuItem clearReciverToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem showDataReciverToolStripMenu;
        private System.Windows.Forms.ToolStripComboBox toolStripReciverShowDataComboBox;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ToolStripMenuItem clearTransmiterToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem oPENComToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem cLOSEComToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Button btnSetXYZ;
        private System.Windows.Forms.ToolStripMenuItem jogOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

