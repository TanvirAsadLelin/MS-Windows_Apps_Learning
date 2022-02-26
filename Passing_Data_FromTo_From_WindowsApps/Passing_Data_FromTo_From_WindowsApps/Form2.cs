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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //lblFirstName.Text = Form1.textFisrtName;
            //lblMiddleName.Text = Form1.textMiddleName;
            //lblLastName.Text = Form1.textLastName;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = Form1.textFisrtName;
            lblMiddleName.Text = Form1.textMiddleName;
            lblLastName.Text = Form1.textLastName;

            lblFirstName.Visible = true;
            lblMiddleName.Visible = true;
            lblLastName.Visible = true;
        }
    }
}
