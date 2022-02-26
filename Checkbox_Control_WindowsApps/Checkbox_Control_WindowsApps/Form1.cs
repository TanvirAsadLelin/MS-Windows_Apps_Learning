using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Control_WindowsApps
{
    public partial class Form1 : Form
    {
        string textSamsung = "";
        string textNokia = "";
        string textSymphonoy = "";
        string textRedmi = "";
        string textOppo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxSamsung_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSamsung.Checked == true)
            {
                textSamsung = checkBoxSamsung.Text;
            }

            else
            {
                textSamsung = "";
            }
        }

        private void checkBoxNokia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNokia.Checked == true)
            {
                textNokia = checkBoxNokia.Text;
            }

            else
            {
                textNokia = "";
            }
        }

        private void checkBoxSymphonoy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSymphonoy.Checked == true)
            {
                textSymphonoy = checkBoxSymphonoy.Text;
            }

            else
            {
                textSymphonoy = "";
            }
        }

        private void checkBoxRedmi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRedmi.Checked == true)
            {
                textRedmi = checkBoxRedmi.Text;
            }

            else
            {
                textRedmi = "";
            }

        }

        private void checkBoxOppo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOppo.Checked == true)
            {
                textOppo = checkBoxOppo.Text;
            }

            else
            {
                textOppo = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selected companies" + textSamsung + " " + textNokia + " " + textSymphonoy + " " + textRedmi + " " + textOppo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnMybutton.Enabled = checkBoxEnable.Checked;
        }
    }
}
