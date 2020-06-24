﻿namespace SerialConnectorForms
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenHand = new System.Windows.Forms.Button();
            this.btnCloseHand = new System.Windows.Forms.Button();
            this.btnShoulderRight = new System.Windows.Forms.Button();
            this.btnShoulderLeft = new System.Windows.Forms.Button();
            this.btnRollRight = new System.Windows.Forms.Button();
            this.btnRollLeft = new System.Windows.Forms.Button();
            this.btnElbowRight = new System.Windows.Forms.Button();
            this.btnElbowLeft = new System.Windows.Forms.Button();
            this.btnTwistRight = new System.Windows.Forms.Button();
            this.btnTwistLeft = new System.Windows.Forms.Button();
            this.btnPitchRight = new System.Windows.Forms.Button();
            this.btnPitchLeft = new System.Windows.Forms.Button();
            this.btnWaistRigth = new System.Windows.Forms.Button();
            this.btnWaistLeft = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxRotationalJoint = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tBoxJogSpeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.progressBar1.Size = new System.Drawing.Size(292, 19);
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
            this.reciverToolStripMenuItem});
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tBoxJogSpeed);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tBoxRotationalJoint);
            this.groupBox2.Controls.Add(this.btnOpenHand);
            this.groupBox2.Controls.Add(this.btnCloseHand);
            this.groupBox2.Controls.Add(this.btnShoulderRight);
            this.groupBox2.Controls.Add(this.btnShoulderLeft);
            this.groupBox2.Controls.Add(this.btnRollRight);
            this.groupBox2.Controls.Add(this.btnRollLeft);
            this.groupBox2.Controls.Add(this.btnElbowRight);
            this.groupBox2.Controls.Add(this.btnElbowLeft);
            this.groupBox2.Controls.Add(this.btnTwistRight);
            this.groupBox2.Controls.Add(this.btnTwistLeft);
            this.groupBox2.Controls.Add(this.btnPitchRight);
            this.groupBox2.Controls.Add(this.btnPitchLeft);
            this.groupBox2.Controls.Add(this.btnWaistRigth);
            this.groupBox2.Controls.Add(this.btnWaistLeft);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 270);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JOG Operator JOINT";
            // 
            // btnOpenHand
            // 
            this.btnOpenHand.Location = new System.Drawing.Point(172, 57);
            this.btnOpenHand.Name = "btnOpenHand";
            this.btnOpenHand.Size = new System.Drawing.Size(117, 23);
            this.btnOpenHand.TabIndex = 19;
            this.btnOpenHand.Text = "Open Hand";
            this.btnOpenHand.UseVisualStyleBackColor = true;
            this.btnOpenHand.Click += new System.EventHandler(this.btnOpenHand_Click);
            // 
            // btnCloseHand
            // 
            this.btnCloseHand.Location = new System.Drawing.Point(171, 28);
            this.btnCloseHand.Name = "btnCloseHand";
            this.btnCloseHand.Size = new System.Drawing.Size(117, 23);
            this.btnCloseHand.TabIndex = 18;
            this.btnCloseHand.Text = "Close Hand";
            this.btnCloseHand.UseVisualStyleBackColor = true;
            this.btnCloseHand.Click += new System.EventHandler(this.btnCloseHand_Click);
            // 
            // btnShoulderRight
            // 
            this.btnShoulderRight.Location = new System.Drawing.Point(100, 59);
            this.btnShoulderRight.Name = "btnShoulderRight";
            this.btnShoulderRight.Size = new System.Drawing.Size(26, 23);
            this.btnShoulderRight.TabIndex = 17;
            this.btnShoulderRight.Text = ">";
            this.btnShoulderRight.UseVisualStyleBackColor = true;
            this.btnShoulderRight.Click += new System.EventHandler(this.btnShoulderRight_Click);
            // 
            // btnShoulderLeft
            // 
            this.btnShoulderLeft.Location = new System.Drawing.Point(68, 59);
            this.btnShoulderLeft.Name = "btnShoulderLeft";
            this.btnShoulderLeft.Size = new System.Drawing.Size(26, 23);
            this.btnShoulderLeft.TabIndex = 16;
            this.btnShoulderLeft.Text = "<";
            this.btnShoulderLeft.UseVisualStyleBackColor = true;
            this.btnShoulderLeft.Click += new System.EventHandler(this.btnShoulderLeft_Click);
            // 
            // btnRollRight
            // 
            this.btnRollRight.Location = new System.Drawing.Point(100, 172);
            this.btnRollRight.Name = "btnRollRight";
            this.btnRollRight.Size = new System.Drawing.Size(26, 23);
            this.btnRollRight.TabIndex = 15;
            this.btnRollRight.Text = ">";
            this.btnRollRight.UseVisualStyleBackColor = true;
            this.btnRollRight.Click += new System.EventHandler(this.btnRollRight_Click);
            // 
            // btnRollLeft
            // 
            this.btnRollLeft.Location = new System.Drawing.Point(68, 172);
            this.btnRollLeft.Name = "btnRollLeft";
            this.btnRollLeft.Size = new System.Drawing.Size(26, 23);
            this.btnRollLeft.TabIndex = 14;
            this.btnRollLeft.Text = "<";
            this.btnRollLeft.UseVisualStyleBackColor = true;
            this.btnRollLeft.Click += new System.EventHandler(this.btnRollLeft_Click);
            // 
            // btnElbowRight
            // 
            this.btnElbowRight.Location = new System.Drawing.Point(100, 86);
            this.btnElbowRight.Name = "btnElbowRight";
            this.btnElbowRight.Size = new System.Drawing.Size(26, 23);
            this.btnElbowRight.TabIndex = 13;
            this.btnElbowRight.Text = ">";
            this.btnElbowRight.UseVisualStyleBackColor = true;
            this.btnElbowRight.Click += new System.EventHandler(this.btnElbowRight_Click);
            // 
            // btnElbowLeft
            // 
            this.btnElbowLeft.Location = new System.Drawing.Point(68, 86);
            this.btnElbowLeft.Name = "btnElbowLeft";
            this.btnElbowLeft.Size = new System.Drawing.Size(26, 23);
            this.btnElbowLeft.TabIndex = 12;
            this.btnElbowLeft.Text = "<";
            this.btnElbowLeft.UseVisualStyleBackColor = true;
            this.btnElbowLeft.Click += new System.EventHandler(this.btnElbowLeft_Click);
            // 
            // btnTwistRight
            // 
            this.btnTwistRight.Location = new System.Drawing.Point(100, 114);
            this.btnTwistRight.Name = "btnTwistRight";
            this.btnTwistRight.Size = new System.Drawing.Size(26, 23);
            this.btnTwistRight.TabIndex = 11;
            this.btnTwistRight.Text = ">";
            this.btnTwistRight.UseVisualStyleBackColor = true;
            this.btnTwistRight.Click += new System.EventHandler(this.btnTwistRight_Click);
            // 
            // btnTwistLeft
            // 
            this.btnTwistLeft.Location = new System.Drawing.Point(68, 114);
            this.btnTwistLeft.Name = "btnTwistLeft";
            this.btnTwistLeft.Size = new System.Drawing.Size(26, 23);
            this.btnTwistLeft.TabIndex = 10;
            this.btnTwistLeft.Text = "<";
            this.btnTwistLeft.UseVisualStyleBackColor = true;
            this.btnTwistLeft.Click += new System.EventHandler(this.btnTwistLeft_Click);
            // 
            // btnPitchRight
            // 
            this.btnPitchRight.Location = new System.Drawing.Point(100, 143);
            this.btnPitchRight.Name = "btnPitchRight";
            this.btnPitchRight.Size = new System.Drawing.Size(26, 23);
            this.btnPitchRight.TabIndex = 9;
            this.btnPitchRight.Text = ">";
            this.btnPitchRight.UseVisualStyleBackColor = true;
            this.btnPitchRight.Click += new System.EventHandler(this.btnPitchRight_Click);
            // 
            // btnPitchLeft
            // 
            this.btnPitchLeft.Location = new System.Drawing.Point(68, 143);
            this.btnPitchLeft.Name = "btnPitchLeft";
            this.btnPitchLeft.Size = new System.Drawing.Size(26, 23);
            this.btnPitchLeft.TabIndex = 8;
            this.btnPitchLeft.Text = "<";
            this.btnPitchLeft.UseVisualStyleBackColor = true;
            this.btnPitchLeft.Click += new System.EventHandler(this.btnPitchLeft_Click);
            // 
            // btnWaistRigth
            // 
            this.btnWaistRigth.Location = new System.Drawing.Point(100, 29);
            this.btnWaistRigth.Name = "btnWaistRigth";
            this.btnWaistRigth.Size = new System.Drawing.Size(26, 23);
            this.btnWaistRigth.TabIndex = 7;
            this.btnWaistRigth.Text = ">";
            this.btnWaistRigth.UseVisualStyleBackColor = true;
            this.btnWaistRigth.Click += new System.EventHandler(this.btnWaistRigth_Click);
            // 
            // btnWaistLeft
            // 
            this.btnWaistLeft.Location = new System.Drawing.Point(68, 29);
            this.btnWaistLeft.Name = "btnWaistLeft";
            this.btnWaistLeft.Size = new System.Drawing.Size(26, 23);
            this.btnWaistLeft.TabIndex = 6;
            this.btnWaistLeft.Text = "<";
            this.btnWaistLeft.UseVisualStyleBackColor = true;
            this.btnWaistLeft.Click += new System.EventHandler(this.btnWaistLeft_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Roll";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Pitch";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Twist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Elbow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Shoulder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Waist";
            // 
            // tBoxRotationalJoint
            // 
            this.tBoxRotationalJoint.Location = new System.Drawing.Point(74, 233);
            this.tBoxRotationalJoint.Name = "tBoxRotationalJoint";
            this.tBoxRotationalJoint.Size = new System.Drawing.Size(50, 20);
            this.tBoxRotationalJoint.TabIndex = 20;
            this.tBoxRotationalJoint.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Rotational";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Deg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Speed";
            // 
            // tBoxJogSpeed
            // 
            this.tBoxJogSpeed.Location = new System.Drawing.Point(74, 208);
            this.tBoxJogSpeed.Name = "tBoxJogSpeed";
            this.tBoxJogSpeed.Size = new System.Drawing.Size(50, 20);
            this.tBoxJogSpeed.TabIndex = 23;
            this.tBoxJogSpeed.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Connector Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShoulderRight;
        private System.Windows.Forms.Button btnShoulderLeft;
        private System.Windows.Forms.Button btnRollRight;
        private System.Windows.Forms.Button btnRollLeft;
        private System.Windows.Forms.Button btnElbowRight;
        private System.Windows.Forms.Button btnElbowLeft;
        private System.Windows.Forms.Button btnTwistRight;
        private System.Windows.Forms.Button btnTwistLeft;
        private System.Windows.Forms.Button btnPitchRight;
        private System.Windows.Forms.Button btnPitchLeft;
        private System.Windows.Forms.Button btnWaistRigth;
        private System.Windows.Forms.Button btnWaistLeft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpenHand;
        private System.Windows.Forms.Button btnCloseHand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxRotationalJoint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBoxJogSpeed;
    }
}

