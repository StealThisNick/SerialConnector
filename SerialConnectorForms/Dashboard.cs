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
        public static SerialPort serialPortPublic = new SerialPort();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPortPublic = serialPort1;
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

            toolStripTransmiterEndLineComboBox.Text = "New Line";
        }

        private void oPENComToolStripMenu_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPortPublic.PortName = cBoxCOMPORT.Text;
                serialPortPublic.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPortPublic.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPortPublic.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPortPublic.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);

                serialPortPublic.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cLOSEComToolStripMenu_Click_1(object sender, EventArgs e)
        {
            if (serialPortPublic.IsOpen)
            {
                serialPortPublic.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPortPublic.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if(sendWith == "None")
                {
                    serialPortPublic.Write(dataOUT);
                }
                else if(sendWith == "Both")
                {
                    serialPortPublic.WriteLine(dataOUT + "\r\n");
                }
                else if (sendWith == "New Line")
                {
                    serialPortPublic.Write(dataOUT + "\r");
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
                serialPortPublic.DtrEnable = true;
            }
            else
            {
                serialPortPublic.DtrEnable = false;
            }
        }

        private void chBoxRts_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRts.Checked)
            {
                serialPortPublic.RtsEnable = true;
            }
            else
            {
                serialPortPublic.RtsEnable = false;
            }
        }

        private void chBoxXonXoff_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxXonXoff.Checked)
            {
                serialPortPublic.Handshake = Handshake.RequestToSendXOnXOff;
            }
            else
            {
                serialPortPublic.Handshake = Handshake.None;
            }
        }

        private void clearTransmiterToolStripMenu_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPortPublic.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            tBoxDataIn.Text += dataIN + "\r\n";
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

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JOG_Operator newJOG_Operator = new JOG_Operator();
            newJOG_Operator.Show();
        }
    }
}
