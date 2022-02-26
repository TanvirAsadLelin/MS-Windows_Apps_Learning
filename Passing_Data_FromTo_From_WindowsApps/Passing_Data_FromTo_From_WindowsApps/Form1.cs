using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passing_Data_FromTo_From_WindowsApps
{
    public partial class Form1 : Form
    {
        public static string textFisrtName;
        public static string textMiddleName;
        public static string textLastName;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxFirstname.Text != "" && textBoxMiddlename.Text != "" && textBoxLastName.Text != "" )
            {
                textFisrtName = textBoxFirstname.Text;
                textMiddleName = textBoxMiddlename.Text;
                textLastName = textBoxLastName.Text;

                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("Please fill up three text box!");
            }
            
        }
    }
}
