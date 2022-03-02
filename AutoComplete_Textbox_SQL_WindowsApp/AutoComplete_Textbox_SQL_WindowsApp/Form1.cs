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

namespace AutoComplete_Textbox_SQL_WindowsApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        void AutoCompleteTBArray()
        {
            string[] hobbies = { "Swimming", "Reading", "Walking", "Sleeping", "Eating" };
            textBoxHobbies.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // textBoxHobbies.AutoCompleteMode = AutoCompleteMode.Append;
            // textBoxHobbies.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxHobbies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxHobbies.AutoCompleteCustomSource.AddRange(hobbies);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // AutoCompleteTBArray();

            AutoCompleteTB_SQL();

        }

        void AutoCompleteTB_SQL()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Hobbies_Tbl";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                coll.Add(dr.GetString(0));

            }
            textBoxHobbies.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxHobbies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxHobbies.AutoCompleteCustomSource = coll;

            con.Close();
        }
    }
}
