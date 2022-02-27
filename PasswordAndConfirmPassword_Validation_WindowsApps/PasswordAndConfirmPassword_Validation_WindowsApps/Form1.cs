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

namespace PasswordAndConfirmPassword_Validation_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Verbatim literal @ 
        //  string pattern = "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text) == true)
            {
                textBoxUserName.Focus();
                errorProviderUserName.SetError(this.textBoxUserName, "Please enter username!");
            }
            else
            {
                errorProviderUserName.Clear();
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBoxPass.Text, pattern) == false)
            {
                textBoxPass.Focus();
                errorProviderPass.SetError(this.textBoxPass, "Please enter Uppercase , Lowercase, Numbers , Special characters");

            }
            else
            {
                errorProviderPass.Clear();
            }

        }

        private void textBoxConfirmPass_Leave(object sender, EventArgs e)
        {
           if(textBoxPass.Text != textBoxConfirmPass.Text)
            {
                textBoxConfirmPass.Focus();
                errorProviderConfirmPass.SetError(this.textBoxPass, "Password is not match!");
            }

            else
            {
                  errorProviderConfirmPass.Clear();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text) == true)
            {
                textBoxUserName.Focus();
                errorProviderUserName.SetError(this.textBoxUserName, "Please enter username!");
            }

            else if (Regex.IsMatch(textBoxPass.Text, pattern) == false)
            {
                textBoxPass.Focus();
                errorProviderPass.SetError(this.textBoxPass, "Please enter Uppercase , Lowercase, Numbers , Special characters");

            }

            else if (textBoxPass.Text != textBoxConfirmPass.Text)
            {
                textBoxConfirmPass.Focus();
                errorProviderConfirmPass.SetError(this.textBoxPass, "Password is not match!");
            }

            else
            {
                MessageBox.Show("Welcome","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
