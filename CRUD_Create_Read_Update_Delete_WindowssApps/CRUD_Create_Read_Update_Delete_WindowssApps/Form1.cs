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

namespace CRUD_Create_Read_Update_Delete_WindowssApps
{
    

    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);

            string queryCheckId = "select * from Employee_Tbl where Id = @id";

            SqlCommand cmd2 = new SqlCommand(queryCheckId, sqlConnection);
             
            cmd2.Parameters.AddWithValue("@id", textBoxE_Id.Text);

            sqlConnection.Open();

             SqlDataReader sqlDataReader = cmd2.ExecuteReader();

            if (sqlDataReader.HasRows == true)
            {
                MessageBox.Show(textBoxE_Id.Text + " ID Already Exists", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }

            else
            {

                sqlConnection.Close();

                string queryInsert = "insert into Employee_Tbl values (@id, @name,@gender,@age,@designation,@salary)";
                SqlCommand cmd = new SqlCommand(queryInsert, sqlConnection);
                cmd.Parameters.AddWithValue("@id", textBoxE_Id.Text);
                cmd.Parameters.AddWithValue("@name", textBoxE_Name.Text);
                cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem);
                cmd.Parameters.AddWithValue("@age", numericUpDownAge.Value);
                cmd.Parameters.AddWithValue("@designation", comboBoxDesignation.SelectedItem);
                cmd.Parameters.AddWithValue("@salary", textBoxSalary.Text);

                sqlConnection.Open();

                int valueRow = cmd.ExecuteNonQuery();
                if (valueRow > 0)
                {
                    MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();

                }
                else
                {
                    MessageBox.Show("Insertion failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                resetControl();
            }

        }

        void BindGridView()
        {
            SqlConnection sqlConnection = new SqlConnection(cs);

            string queryShowData = "select * from Employee_Tbl";

            SqlDataAdapter adapter = new SqlDataAdapter(queryShowData, sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewEmployeTbl.DataSource = dataTable;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);
            string queryInsert = "update Employee_Tbl set Id = @id,Name=@name,Gender=@gender,Age=@age,Designation=@designation,Salary = @salary where Id = @id";
            SqlCommand cmd = new SqlCommand(queryInsert, sqlConnection);
            cmd.Parameters.AddWithValue("@id", textBoxE_Id.Text);
            cmd.Parameters.AddWithValue("@name", textBoxE_Name.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDownAge.Value);
            cmd.Parameters.AddWithValue("@designation", comboBoxDesignation.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", textBoxSalary.Text);

            sqlConnection.Open();

            int valueRow = cmd.ExecuteNonQuery();
            if (valueRow > 0)
            {
                MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();

            }
            else
            {
                MessageBox.Show("Update failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlConnection.Close();
            resetControl();
        }

        private void dataGridViewEmployeTbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxE_Id.Text = dataGridViewEmployeTbl.SelectedRows[0].Cells[0].Value.ToString();
            textBoxE_Name.Text = dataGridViewEmployeTbl.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxGender.Text = dataGridViewEmployeTbl.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDownAge.Value = Convert.ToInt32( dataGridViewEmployeTbl.SelectedRows[0].Cells[3].Value);
            comboBoxDesignation.Text = dataGridViewEmployeTbl.SelectedRows[0].Cells[4].Value.ToString();
            textBoxSalary.Text = dataGridViewEmployeTbl.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);

         
            string queryInsert = "delete from Employee_Tbl where Id = @id";
            SqlCommand cmd = new SqlCommand(queryInsert, sqlConnection);
            cmd.Parameters.AddWithValue("@id", textBoxE_Id.Text);
            cmd.Parameters.AddWithValue("@name", textBoxE_Name.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDownAge.Value);
            cmd.Parameters.AddWithValue("@designation", comboBoxDesignation.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", textBoxSalary.Text);

            sqlConnection.Open();

            int valueRow = cmd.ExecuteNonQuery();
            if (valueRow > 0)
            {
                MessageBox.Show("Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();

            }
            else
            {
                MessageBox.Show("Deletion failed", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlConnection.Close();
            resetControl();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControl();
        }

        void resetControl()
        {
            textBoxE_Id.Clear();
            textBoxE_Name.Clear();
            comboBoxGender.SelectedItem = null;
            numericUpDownAge.Value = 0;
            comboBoxDesignation.SelectedItem = null;
            textBoxSalary.Clear();

            textBoxE_Id.Focus();
        }
    }
}
