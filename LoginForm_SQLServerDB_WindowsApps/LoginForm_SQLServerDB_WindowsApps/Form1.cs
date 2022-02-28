using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LoginForm_SQLServerDB_WindowsApps
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBoxShowPass.Checked;
            switch(check)
            {
                case true:
                    textBoxPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    textBoxPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);

                string query = "select * from Login_tbl where username = @user and password = @pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@user", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login fail", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();

            }
            else
            {
                MessageBox.Show("Please fill both field", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) == true)
            {
                textBoxUsername.Focus();
                errorProviderUsername.SetError(this.textBoxUsername, "Please fill this filed!");

            }
            else
            {
                errorProviderUsername.Clear();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPassword.Text) == true)
            {
                textBoxPassword.Focus();
                errorProviderPass.SetError(this.textBoxPassword, "Please fill this field!");
            }
            else
            {
                errorProviderPass.Clear();
            }
        }
    }
}
