using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceholderSet_Textbox_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if(textBoxName.Text == "Enter your name")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Enter your name";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Enter your email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "") 
            {
                textBoxEmail.Text = "Enter your email";
                textBoxEmail.ForeColor = Color.Gray;
            }

        }
    }
}
