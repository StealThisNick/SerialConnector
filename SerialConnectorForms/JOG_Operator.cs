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
    public partial class JOG_Operator : Form
    {
        SerialPort serialport2 = new SerialPort();
        public JOG_Operator()
        {
            InitializeComponent();
        }

        private void JOG_Operator_Load(object sender, EventArgs e)
        {
        }

        private void btnCloseHand_Click(object sender, EventArgs e)
        {
            Dashboard.serialPortKurwa.Write("GC" + "\r");
        }

        private void btnOpenHand_Click(object sender, EventArgs e)
        {
            Dashboard.serialPortKurwa.Write("GO" + "\r");
        }

        private void btnWaistLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnWaistRigth_Click(object sender, EventArgs e)
        {

        }

        private void btnShoulderLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnShoulderRight_Click(object sender, EventArgs e)
        {

        }

        private void btnElbowLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnElbowRight_Click(object sender, EventArgs e)
        {

        }

        private void btnTwistLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnTwistRight_Click(object sender, EventArgs e)
        {

        }

        private void btnPitchLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnPitchRight_Click(object sender, EventArgs e)
        {

        }

        private void btnRollLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRollRight_Click(object sender, EventArgs e)
        {

        }

        
    }
}
