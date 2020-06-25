using System;
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
    public partial class Dashboard : Form
    {
        string dataOUT;
        string sendWith;
        string dataIN;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            chBoxDtr.Checked = true;
            serialPort1.DtrEnable = true;

            chBoxRts.Checked = true;
            serialPort1.RtsEnable = true;

            chBoxXonXoff.Checked = false;
            serialPort1.Handshake = Handshake.None;

            btnSend.Enabled = true;

            sendWith = "New Line";

            toolStripReciverShowDataComboBox.Text = "Add to Old Data";
            toolStripTransmiterEndLineComboBox.Text = "New Line";
        }

        private void oPENComToolStripMenu_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cLOSEComToolStripMenu_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if(sendWith == "None")
                {
                    serialPort1.Write(dataOUT);
                }
                else if(sendWith == "Both")
                {
                    serialPort1.Write(dataOUT + "\r\n");
                }
                else if (sendWith == "New Line")
                {
                    serialPort1.WriteLine(dataOUT + "\r");
                }
            }
        }

        private void toolStripTransmiterEndLineComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripTransmiterEndLineComboBox.Text == "None")
            {
                sendWith = "None";
            }
            else if (toolStripTransmiterEndLineComboBox.Text == "Both")
            {
                sendWith = "Both";
            }
            else if (toolStripTransmiterEndLineComboBox.Text == "New Line")
            {
                sendWith = "New Line";
            }
        }

        private void chBoxDtr_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDtr.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRts_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRts.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void chBoxXonXoff_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxXonXoff.Checked)
            {
                serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
            }
            else
            {
                serialPort1.Handshake = Handshake.None;
            }
        }

        private void clearTransmiterToolStripMenu_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        //private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void EnterHandler()
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        dataOUT = tBoxDataOut.Text;
        //        if (sendWith == "None")
        //        {
        //            serialPort1.Write(dataOUT);
        //        }
        //        else if (sendWith == "Both")
        //        {
        //            serialPort1.Write(dataOUT + "\r\n");
        //        }
        //        else if (sendWith == "New Line")
        //        {
        //            serialPort1.WriteLine(dataOUT + "\r");
        //        }
        //    }
        //}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (toolStripReciverShowDataComboBox.Text == "Always Update")
            {
                tBoxDataIn.Text = dataIN;
            }
            else if (toolStripReciverShowDataComboBox.Text == "Add to Old Data")
            {
                tBoxDataIn.Text += dataIN + "\r\n";
            }
        }

        private void clearReciverToolStripMenu_Click(object sender, EventArgs e)
        {
            if (tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseHand_Click(object sender, EventArgs e)
        {
            serialPort1.Write("GC" + "\r");
        }

        private void btnOpenHand_Click(object sender, EventArgs e)
        {
            serialPort1.Write("GO" + "\r");
        }

        private void btnWaistLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + (-rotation) + ",0,0,0,0,0" + "\r");
        }

        private void btnWaistRigth_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + rotation + ",0,0,0,0,0" + "\r");
        }

        private void btnShoulderLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0," + (-rotation) + ",0,0,0,0" + "\r");
        }

        private void btnShoulderRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0," + (rotation) + ",0,0,0,0" + "\r");
        }

        private void btnElbowLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0," + (-rotation) + ",0,0,0" + "\r");
        }

        private void btnElbowRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0," + (rotation) + ",0,0,0" + "\r");
        }

        private void btnTwistLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0," + (-rotation) + ",0,0" + "\r");
        }

        private void btnTwistRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0," + (rotation) + ",0,0" + "\r");
        }

        private void btnPitchLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0,0," + (-rotation) + ",0" + "\r");
        }

        private void btnPitchRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0,0," + (rotation) + ",0" + "\r");
        }

        private void btnRollLeft_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0,0,0," + (-rotation) + "\r");
        }

        private void btnRollRight_Click(object sender, EventArgs e)
        {
            int rotation = 0;
            int speed = 0;
            speed = Convert.ToInt32(tBoxJogSpeed.Text);
            rotation = Convert.ToInt32(tBoxRotationalJoint.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MJ " + "0,0,0,0,0," + (rotation) + "\r");
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

        private void btnSetXYZ_Click(object sender, EventArgs e)
        {
            setterXYZ newsetterXYZ = new setterXYZ();
            newsetterXYZ.Show();
        }

        private void btnCLeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0,0,0," + (-abcCor) + "\r");
            //serialPort1.Write("MP " + "0,0,0,0,0," + (abcCor) + ",L" + "\r");
        }

        private void btnCRight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0,0,0," + (abcCor) + "\r");
            //serialPort1.Write("MP " + "0,0,0,0,0," + (abcCor) + ",R" + "\r");
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + "\r");
            //serialPort1.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + ",A" + "\r");
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0," + (-xyzCor) + ",0,0,0" + "\r");
            //serialPort1.Write("MP " + "0,0," + (xyzCor) + ",0,0,0" + ",B" + "\r");
        }

        private void btnBLeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0,0," + (-abcCor) + ",0" + "\r");
            //serialPort1.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + ",L" + "\r");
        }

        private void btnBRight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + "\r");
            //serialPort1.Write("MP " + "0,0,0,0," + (abcCor) + ",0" + ",R" + "\r");
        }

        private void btnYUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + "\r");
            //serialPort1.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + ",A" + "\r");
        }

        private void btnYDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0," + (-xyzCor) + ",0,0,0,0" + "\r");
            //serialPort1.Write("MP " + "0," + (xyzCor) + ",0,0,0,0" + ",B" + "\r");
        }

        private void btnALeft_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0," + (-abcCor) + ",0,0" + "\r");
            //serialPort1.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + ",L" + "\r");
        }

        private void btnARight_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int abcCor = 0;
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            abcCor = Convert.ToInt32(tBoxABCCor.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + "\r");
            //serialPort1.Write("MP " + "0,0,0," + (abcCor) + ",0,0" + ",R" + "\r");
        }

        private void btnXUp_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + (xyzCor) + ",0,0,0,0,0" + "\r");
            //serialPort1.Write("MP " + (xyzCor) + ",0,0,0,0,0" + ",A" + "\r");
        }

        private void btnXDown_Click(object sender, EventArgs e)
        {
            int xyzCor = 0;
            int speed = 0;
            xyzCor = Convert.ToInt32(tBoxXYZCor.Text);
            speed = Convert.ToInt32(tBoxXYZSpeed.Text);
            serialPort1.Write("SP " + speed + "\r");
            serialPort1.Write("MP " + (-xyzCor) + ",0,0,0,0,0" + "\r");
            //serialPort1.Write("MP " + (xyzCor) + ",0,0,0,0,0" + ",B" + "\r");
        }
    }
}
