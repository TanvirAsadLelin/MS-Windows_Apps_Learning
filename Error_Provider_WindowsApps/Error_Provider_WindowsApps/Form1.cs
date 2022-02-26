using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Provider_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.Focus();

                errorProvider1.Icon = Properties.Resources.error;
                // MessageBox.Show("Please fill the name !!");

                errorProvider1.SetError(this.textBoxName, "Please fill the name !!");
            }
            else
            {
                //  errorProvider1.Clear();
                errorProvider1.Icon = Properties.Resources.check;
            }
                
        }

        private void textBoxAge_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxAge.Text))
            {
                textBoxAge.Focus();
                errorProvider2.Icon = Properties.Resources.error;

                //  MessageBox.Show("Please fill the age !!");

                errorProvider2.SetError(this.textBoxAge, "Please fill the age !!");
            }
            else
            {
                // errorProvider2.Clear();
                errorProvider2.Icon = Properties.Resources.check;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxAge.Focus();
                //  MessageBox.Show("Please fill the age !!");

                errorProvider1.SetError(this.textBoxName, "Please fill the name !!");
            }

           else if (string.IsNullOrEmpty(textBoxAge.Text))
            {
                textBoxAge.Focus();
                //  MessageBox.Show("Please fill the age !!");

                errorProvider2.SetError(this.textBoxAge, "Please fill the age !!");
            }
            else
            {
                MessageBox.Show("Welcome");
            }
           
        }
    }
}
