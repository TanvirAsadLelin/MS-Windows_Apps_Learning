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

namespace CURD_InListbox_WindowsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill_Listbox();
        } 

        void Fill_Listbox()
        {  
            listBox1.Items.Clear();
          SqlConnection con = new SqlConnection(cs);
          string query = "select Name from Sports_Tbl";
            SqlCommand sqlCommand = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                string name = reader.GetString(0);
                listBox1.Items.Add(name);
            }

            con.Close();

            listBox1.Sorted = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryInsert = "insert into Sports_Tbl values(@name)";
            SqlCommand sqlCommand = new SqlCommand(queryInsert, con);

            sqlCommand.Parameters.AddWithValue("@name",textBoxSports.Text);

            con.Open();

           int value =  sqlCommand.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Inserted!!");
                
                Fill_Listbox();
                textBoxSports.Clear();
                textBoxSports.Focus();
            }
            else
            {
                MessageBox.Show("Not Inserted!!");
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryUpdate = "update Sports_Tbl set Name = @name where Name = @name1 ";
            SqlCommand sqlCommand = new SqlCommand(queryUpdate, con);

            sqlCommand.Parameters.AddWithValue("@name", textBoxSports.Text);
            sqlCommand.Parameters.AddWithValue("@name1", listBox1.SelectedItem);

            con.Open();

            int value = sqlCommand.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Updated!!");

                Fill_Listbox();
                textBoxSports.Clear();
                textBoxSports.Focus();
            }
            else
            {
                MessageBox.Show("Not Updated!!");
            }

            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSports.Text = listBox1.SelectedItem.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string queryDelete = "delete from Sports_Tbl where Name = @name";
            SqlCommand sqlCommand = new SqlCommand(queryDelete, con);


            sqlCommand.Parameters.AddWithValue("@name", listBox1.SelectedItem);

            con.Open();

            int value = sqlCommand.ExecuteNonQuery();

            if (value > 0)
            {
                MessageBox.Show("Deleted!!");

                Fill_Listbox();
                textBoxSports.Clear();
                textBoxSports.Focus();
            }
            else
            {
                MessageBox.Show("Not Delete!!");
            }

            con.Close();
        }
    }
}
