﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialConnectorForms
{
    public partial class JOG_Operator : Form
    {
        SerialPort _serialPort = new SerialPort();
        public JOG_Operator()
        {
            InitializeComponent();
        }

        private void JOG_Operator_Load(object sender, EventArgs e)
        {
            _serialPort = Dashboard.serialPortPublic;

            rBtnJointJog.Checked = true;
            rBtnXyzJog.Checked = false;

            jogJOINT.Visible = true;

            jogXYZ.Visible = false;
        }

        private void rBtnJointJog_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnJointJog.Checked)
            {
                rBtnXyzJog.Checked = false;

                jogJOINT.Visible = true;

                jogXYZ.Visible = false;
            }
        }

        private void rBtnXyzJog_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnXyzJog.Checked)
            {
                rBtnJointJog.Checked = false;

                jogJOINT.Visible = false;

                jogXYZ.Visible = true;
            }
        }

        private void btnCloseHand_Click(object sender, EventArgs e)
        {
            _serialPort.Write("GC" + "\r");
        }

        private void btnOpenHand_Click(object sender, EventArgs e)
        {
            _serialPort.Write("GO" + "\r");
        }

        private void btnWaistLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + (-rotation) + ",0,0,0,0,0" + "\r");
        }

        private void btnWaistRigth_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + rotation + ",0,0,0,0,0" + "\r");
        }

        private void btnShoulderLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0," + (-rotation) + ",0,0,0,0" + "\r");
        }

        private void btnShoulderRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0," + (rotation) + ",0,0,0,0" + "\r");
        }

        private void btnElbowLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0," + (-rotation) + ",0,0,0" + "\r");
        }

        private void btnElbowRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0," + (rotation) + ",0,0,0" + "\r");
        }

        private void btnTwistLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0," + (-rotation) + ",0,0" + "\r");
        }

        private void btnTwistRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0," + (rotation) + ",0,0" + "\r");
        }

        private void btnPitchLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0,0," + (-rotation) + ",0" + "\r");
        }

        private void btnPitchRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0,0," + (rotation) + ",0" + "\r");
        }

        private void btnRollLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0,0,0," + (-rotation) + "\r");
        }

        private void btnRollRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MJ " + "0,0,0,0,0," + (rotation) + "\r");
        }

        private void gBoxXYZJoints_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen z = new Pen(Color.Blue, 1);
            Pen x = new Pen(Color.Red, 1);
            Pen y = new Pen(Color.Green, 1);
            l.DrawLine(z, 20, 20, 20, 130);
            l.DrawLine(x, 20, 130, 130, 130);
            l.DrawLine(y, 20, 130, 130, 45);
            l.Dispose();
        }

        private void btnCLeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0,0,0," + (-abcCor) + "\r");
            //_serialPort.Write("MP " + "0,0,0,0,0," + (abcCor) + ",L" + "\r");
        }

        private void btnCRight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0,0,0," + (abcCor) + "\r");
            //_serialPort.Write("MP " + "0,0,0,0,0," + (abcCor) + ",R" + "\r");
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + "\r");
            //_serialPort.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + ",A" + "\r");
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0," + (-xyzCor) + ",0,0,0" + "\r");
            //_serialPort.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + ",B" + "\r");
        }

        private void btnBLeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0,0," + (-abcCor) + ",0" + "\r");
            //_serialPort.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + ",L" + "\r");
        }

        private void btnBRight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + "\r");
            //_serialPort.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + ",R" + "\r");
        }

        private void btnYUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + "\r");
            //_serialPort.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + ",A" + "\r");
        }

        private void btnYDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0," + (-xyzCor) + ",0,0,0,0" + "\r");
            //_serialPort.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + ",B" + "\r");
        }

        private void btnALeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0," + (-abcCor) + ",0,0" + "\r");
            //_serialPort.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + ",L" + "\r");
        }

        private void btnARight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + "\r");
            //_serialPort.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + ",R" + "\r");
        }

        private void btnXUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + (xyzCor) + ",0,0,0,0,0" + "\r");
            //_serialPort.Write("MP " + (xyzCor) + ",0,0,0,0,0" + ",A" + "\r");
        }

        private void btnXDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            _serialPort.Write("SP " + speed + "\r");
            _serialPort.Write("MP " + (-xyzCor) + ",0,0,0,0,0" + "\r");
            //_serialPort.Write("MP " + (xyzCor) + ",0,0,0,0,0" + ",B" + "\r");
        }

        private void btnSetXYZ_Click_1(object sender, EventArgs e)
        {
            setterXYZ newsetterXYZ = new setterXYZ();
            newsetterXYZ.Show();
        }

        private void btnSaveCurrentPosition_Click(object sender, EventArgs e)
        {
            int positionNumberToSave = Convert.ToInt32(nBoxPositionNumberToSave.Value);

            _serialPort.Write("HE " + positionNumberToSave + "\r");
        }
    }
}
