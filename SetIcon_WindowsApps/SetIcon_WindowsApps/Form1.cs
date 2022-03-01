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

namespace SetIcon_WindowsApps
{
    public partial class Form1 : TemplateForm
    {
        string text1 = "";
        string text2 = "";
        string text3 = "";
        string text4 = "";
        string text5 = "";
     

        
       
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        private void checkBox1000_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1000.Checked == true)
            {
                text1 = checkBox1000.Text;
                index = index + 1;
              
            }

            else
            {
                text1 = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                text2 = checkBox1.Text;
                index = index + 1;

            }

            else
            {
                text2 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                text3 = checkBox2.Text;
                index = index + 1;

            }

            else
            {
                text3 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                text4 = checkBox3.Text;
                index = index + 1;

            }

            else
            {
                text4 = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                text5 = checkBox4.Text;
                index = index + 1;

            }

            else
            {
                text5="";

                
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            int total = 0;
            try
            {
                total = total + int.Parse(text1) + int.Parse(text2) + int.Parse(text3) + int.Parse(text4) + int.Parse(text5);
                lblTotal.Text = "Total value : " + total.ToString();
                lblTotal.Visible = true;

            }
            catch
            {

            }



            lblIndex.Text ="Total select box: "+ index.ToString();
            lblIndex.Visible = true;
            



        }
    }
}
