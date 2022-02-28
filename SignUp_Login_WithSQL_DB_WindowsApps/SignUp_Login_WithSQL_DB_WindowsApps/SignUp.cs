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

namespace SignUp_Login_WithSQL_DB_WindowsApps
{
    public partial class SignUp : Form
    {
        string patternEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
        public SignUp()
        {
            InitializeComponent();
        }


        private void textBoxS_Id_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxS_Id.Text)== true)
            {
                textBoxS_Id.Focus();
                errorProviderS_Id.SetError(this.textBoxS_Id, "Insert ID !");
            }
            else
            {
                errorProviderS_Id.Clear();
            }
        }

        private void textBoxS_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(Char.IsDigit(ch) == true)
            {
                 e.Handled = false;
            }

            else if(ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxS_Name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxS_Name.Text) == true)
            {
                textBoxS_Name.Focus();
                errorProviderS_Name.SetError(this.textBoxS_Name, "Insert ID !");
            }
            else
            {
                errorProviderS_Name.Clear();
            }
        }

        private void textBoxS_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled=false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxS_FName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxS_FName.Text) == true)
            {
                textBoxS_FName.Focus();
                errorProviderFatherName.SetError(this.textBoxS_FName, "Insert father's name !");
            }
            else
            {
                errorProviderFatherName.Clear();
            }
        }

        private void textBoxS_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxS_MName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxS_MName.Text) == true)
            {
                textBoxS_MName.Focus();
                errorProviderMotherName.SetError(this.textBoxS_MName, "Insert Mother's name !");
            }
            else
            {
                errorProviderMotherName.Clear();
            }
        }

        private void textBoxS_MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxS_Surname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxS_Surname.Text) == true)
            {
                textBoxS_Surname.Focus();
                errorProviderSurname.SetError(this.textBoxS_Surname, "Insert Surname !");
            }
            else
            {
                errorProviderSurname.Clear();
            }
        }

        private void textBoxS_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {
            if(comboBoxGender.SelectedItem == null)
            {   
                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Please select Gender");
            }
            else
            {
                errorProviderGender.Clear();
            }
        }

        private void numericUpDownClass_Leave(object sender, EventArgs e)
        {
            if(numericUpDownClass.Value == 0)
            {
                numericUpDownClass.Focus();
                errorProviderClass.SetError(this.numericUpDownClass, "Please select a class");
            }

            else
            {
                errorProviderClass.Clear();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBoxEmail.Text,patternEmail)== false)
            {    
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid email");
            }
            else
            {
                errorProviderEmail.Clear();
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPass.Text, patternPassword) == false)
            {
                textBoxPass.Focus();
                errorProviderPass.SetError(this.textBoxPass, "Use Uppercase , Lowercase, Number , Symbols");
            }
            else
            {
                errorProviderPass.Clear();
            }
        }

        private void textBoxCon_Pass_Leave(object sender, EventArgs e)
        {
            if(textBoxPass.Text != textBoxCon_Pass.Text)
            {
                textBoxCon_Pass.Focus();
                errorProviderConPass.SetError(this.textBoxCon_Pass, "Password is not match");
            }

            else
            {
                errorProviderConPass.Clear();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxS_Id.Text) == true)
            {
                textBoxS_Id.Focus();
                errorProviderS_Id.SetError(this.textBoxS_Id, "Insert ID !");
            }
            else if (string.IsNullOrEmpty(textBoxS_Name.Text) == true)
            {
                textBoxS_Name.Focus();
                errorProviderS_Name.SetError(this.textBoxS_Name, "Insert ID !");
            }
            else if (string.IsNullOrEmpty(textBoxS_FName.Text) == true)
            {
                textBoxS_FName.Focus();
                errorProviderFatherName.SetError(this.textBoxS_FName, "Insert father's name !");
            }

            else if (string.IsNullOrEmpty(textBoxS_MName.Text) == true)
            {
                textBoxS_MName.Focus();
                errorProviderMotherName.SetError(this.textBoxS_MName, "Insert Mother's name !");
            }
            else if (string.IsNullOrEmpty(textBoxS_Surname.Text) == true)
            {
                textBoxS_Surname.Focus();
                errorProviderSurname.SetError(this.textBoxS_Surname, "Insert Surname !");
            }
            else if (comboBoxGender.SelectedItem == null)
            {
                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Please select Gender");
            }

            else if (numericUpDownClass.Value == 0)
            {
                numericUpDownClass.Focus();
                errorProviderClass.SetError(this.numericUpDownClass, "Please select a class");
            }

            else if (Regex.IsMatch(textBoxEmail.Text, patternEmail) == false)
            {
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid email");
            }

            else if (Regex.IsMatch(textBoxPass.Text, patternPassword) == false)
            {
                textBoxPass.Focus();
                errorProviderPass.SetError(this.textBoxPass, "Use Uppercase , Lowercase, Number , Symbols");
            }
            else if (textBoxPass.Text != textBoxCon_Pass.Text)
            {
                textBoxCon_Pass.Focus();
                errorProviderConPass.SetError(this.textBoxCon_Pass, "Password is not match");
            }

            else
            {
                MessageBox.Show("Sign up complete");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxS_Id.Clear();
            textBoxS_Name.Clear();
            textBoxS_FName.Clear();
            textBoxS_MName.Clear();
            textBoxS_Surname.Clear();
            comboBoxGender.SelectedItem = null;
            numericUpDownClass.Value = 0;
            textBoxEmail.Clear();
            textBoxPass.Clear();
            textBoxCon_Pass.Clear();

        }
    }
}
