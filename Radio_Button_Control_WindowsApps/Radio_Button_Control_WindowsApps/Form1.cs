using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button_Control_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(radioButtonBangla.Checked == true)
            {
                MessageBox.Show("You have selected: " + radioButtonBangla.Text);
            }
           else if (radioButtonCanada.Checked == true)
            {
                MessageBox.Show("You have selected: " + radioButtonCanada.Text);
            }

            else if (radioButtonIndia.Checked == true)
            {
                MessageBox.Show("You have selected: " + radioButtonIndia.Text);
            }

            else if (radioButtonGer.Checked == true)
            {
                MessageBox.Show("You have selected: " + radioButtonGer.Text);
            }

            else
            {
                MessageBox.Show("Please select your country");
            }

        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked == true)
            {
                groupBox1.BackColor = Color.Blue;
            }
            else if (radioButtonYellow.Checked == true)
            {
                groupBox1.BackColor = Color.Yellow;
            }

            else if (radioButtonGreen.Checked == true)
            {
                groupBox1.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("Please select a colour");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (radioButtonBrown.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Brown;
            }

            else if (radioButtonPurple.Checked == true) 
            {
                this.BackColor = System.Drawing.Color.Purple;
            }

            else
            {
                MessageBox.Show("Please select a colour");
            }
        }
    }
}
