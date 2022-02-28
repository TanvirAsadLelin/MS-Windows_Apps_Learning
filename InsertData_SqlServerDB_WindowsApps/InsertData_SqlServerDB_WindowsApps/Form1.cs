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

namespace InsertData_SqlServerDB_WindowsApps
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCustomerID.Text) == true)
            {
                textBoxCustomerID.Focus();
                errorProviderCID.SetError(this.textBoxCustomerID, "Please insert ID");
            }
            else if (string.IsNullOrEmpty(textBoxCustomerName.Text) == true)
            {
                textBoxCustomerName.Focus();
                errorProviderCName.SetError(this.textBoxCustomerName, "Please insert name");
            }

            else if (comboBoxCustomerGender.SelectedItem == null)
            {
                comboBoxCustomerGender.Focus();
                errorProviderCGender.SetError(this.comboBoxCustomerGender, "Please  select gender");
            }
            else if (string.IsNullOrEmpty(textBoxCustomerAddress.Text) == true)
            {
                textBoxCustomerAddress.Focus();
                errorProviderCAddress.SetError(this.textBoxCustomerAddress, "Please insert Address");
            }



            else
            {

                string cs = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(cs);


                string query2 = "select * from Customer_Tbl where Customer_ID = @cid";

                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd2.Parameters.AddWithValue("@cid", textBoxCustomerID.Text);
                con.Open();
                SqlDataReader rd = cmd2.ExecuteReader(); // for select statement
                if (rd.HasRows == true)
                {
                    MessageBox.Show(textBoxCustomerID.Text + "ID already exsit !!");

                }
                else
                {
                    con.Close();
                    string query = "insert into Customer_Tbl values(@cid,@cname,@cgender,@cadd)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cid", textBoxCustomerID.Text);
                    cmd.Parameters.AddWithValue("@cname", textBoxCustomerName.Text);
                    cmd.Parameters.AddWithValue("@cgender", comboBoxCustomerGender.SelectedItem);
                    cmd.Parameters.AddWithValue("@cadd", textBoxCustomerAddress.Text);

                    con.Open();
                    int value = cmd.ExecuteNonQuery(); // use for insert , update , delete 

                    if (value > 0)
                    {
                        MessageBox.Show("Customer is added");

                    }
                    else
                    {
                        MessageBox.Show("Customer insertion faild");
                    }

                    con.Close();
                }

            }

        }

        private void textBoxCustomerID_Leave(object sender, EventArgs e)
        {
             if(string.IsNullOrEmpty(textBoxCustomerID.Text) == true)
            {
                textBoxCustomerID.Focus();
                errorProviderCID.SetError(this.textBoxCustomerID, "Please insert ID");
            }

            else
            {
                errorProviderCID.Clear();
            }
        }

        private void textBoxCustomerName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCustomerName.Text) == true)
            {
                textBoxCustomerName.Focus();
                errorProviderCName.SetError(this.textBoxCustomerName, "Please insert name");
            }

            else
            {
                errorProviderCName.Clear();
            }
        }

        private void comboBoxCustomerGender_Leave(object sender, EventArgs e)
        {
            if(comboBoxCustomerGender.SelectedItem == null)
            {
                comboBoxCustomerGender.Focus();
                errorProviderCGender.SetError(this.comboBoxCustomerGender, "Please  select gender");
            }

            else
            {
                errorProviderCGender.Clear(); 
            }
        }

        private void textBoxCustomerAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCustomerAddress.Text) == true)
            {
                textBoxCustomerAddress.Focus();
                errorProviderCAddress.SetError(this.textBoxCustomerAddress, "Please insert Address");
            }

            else
            {
                errorProviderCAddress.Clear();
            }
        }
    }
}
