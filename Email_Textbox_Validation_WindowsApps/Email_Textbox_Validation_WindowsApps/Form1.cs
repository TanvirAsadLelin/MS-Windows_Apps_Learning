using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace Email_Textbox_Validation_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Please fill the name!!");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {

            if (Regex.IsMatch(textBoxEmail.Text, pattern) == false)
            {
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid Email!!");
            }
            else
            {
                errorProviderEmail.Clear();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Please fill the name!!");
            }
            else if (Regex.IsMatch(textBoxEmail.Text, pattern) == false)
            {
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid Email!!");
            }
            else
            {
                MessageBox.Show("Welcome", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
