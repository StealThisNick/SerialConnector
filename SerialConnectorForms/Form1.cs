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
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith;
        string dataIN;
        public Form1()
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

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.EnterHandler();
                e.Handled = true;
                e.SuppressKeyPress = true;
                
            }
        }

        private void EnterHandler()
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if (sendWith == "None")
                {
                    serialPort1.Write(dataOUT);
                }
                else if (sendWith == "Both")
                {
                    serialPort1.Write(dataOUT + "\r\n");
                }
                else if (sendWith == "New Line")
                {
                    serialPort1.WriteLine(dataOUT + "\r");
                }
            }
        }

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

    }
}
