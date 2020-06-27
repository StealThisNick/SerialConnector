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
    public partial class setterXYZ : Form
    {
        SerialPort _serialPort = new SerialPort();
        string confLeftRight = "";
        string confBelowAbove = "";
        string confFlipNoFlip = "";
        string gripStatus = "";
        public setterXYZ()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _serialPort = Dashboard.serialPortPublic;

            chBoxConfIgnore.Checked = true;
            rBtnGripStateIgnore.Checked = true;

        }

        private void chBoxConfIgnore_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxConfIgnore.Checked)
            {
                chBoxConfLeft.Checked = false;
                chBoxConfLeft.Enabled = false;

                chBoxConfRight.Checked = false;
                chBoxConfRight.Enabled = false;

                chBoxConfBelow.Checked = false;
                chBoxConfBelow.Enabled = false;

                chBoxConfAbove.Checked = false;
                chBoxConfAbove.Enabled = false;

                chBoxConfFlip.Checked = false;
                chBoxConfFlip.Enabled = false;

                chBoxConfNoFlip.Checked = false;
                chBoxConfNoFlip.Enabled = false;

                confLeftRight = "";
                confBelowAbove = "";
                confFlipNoFlip = "";
            }
            else
            {
                chBoxConfLeft.Enabled = true;

                chBoxConfRight.Checked = true;
                chBoxConfRight.Enabled = true;

                chBoxConfBelow.Enabled = true;

                chBoxConfAbove.Checked = true;
                chBoxConfAbove.Enabled = true;

                chBoxConfFlip.Enabled = true;

                chBoxConfNoFlip.Checked = true;
                chBoxConfNoFlip.Enabled = true;
            }
        }

        private void chBoxConfLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfLeft.Checked)
            {
                chBoxConfRight.Checked = false;
                confLeftRight = ",L";
            }
        }

        private void chBoxConfRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfRight.Checked)
            {
                chBoxConfLeft.Checked = false;
                confLeftRight = ",R";
            }
        }

        private void chBoxConfBelow_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfBelow.Checked)
            {
                chBoxConfAbove.Checked = false;
                confBelowAbove = ",B";
            }
        }

        private void chBoxConfAbove_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfAbove.Checked)
            {
                chBoxConfBelow.Checked = false;
                confBelowAbove = ",A";
            }
        }

        private void chBoxConfFlip_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfFlip.Checked)
            {
                chBoxConfNoFlip.Checked = false;
                confFlipNoFlip = ",F";
            }
        }

        private void chBoxConfNoFlip_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfNoFlip.Checked)
            {
                chBoxConfFlip.Checked = false;
                confFlipNoFlip = ",N";
            }
        }

        private void rBtnGripStateIgnore_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnGripStateIgnore.Checked)
            {
                gripStatus = "";
            }
        }

        private void rBtnGripStateOPEN_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnGripStateOPEN.Checked)
            {
                gripStatus = ",O";
            }
        }

        private void rBtnGripStateCLOSED_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnGripStateCLOSED.Checked)
            {
                gripStatus = ",C";
            }
        }


        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            int positionNumber = Convert.ToInt32(tBoxPositionNumber.Text);
            int xCor = Convert.ToInt32(tBoxXCor.Text);
            int yCor = Convert.ToInt32(tBoxYCor.Text);
            int zCor = Convert.ToInt32(tBoxZCor.Text);
            int aCor = Convert.ToInt32(tBoxACor.Text);
            int bCor = Convert.ToInt32(tBoxBCor.Text);
            int cCor = Convert.ToInt32(tBoxCCor.Text);

            _serialPort.Write("PD " + positionNumber + "," + xCor + "," + yCor + "," + zCor + "," + aCor + "," + bCor + "," + cCor + confLeftRight + confBelowAbove + confFlipNoFlip + gripStatus + "\r");

        }

    }
}
