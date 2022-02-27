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

namespace ExtractNumberFromString_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            int total = 0;
            string regx = @"\d+";
            foreach(string s in listBox1.SelectedItems)
            {
                // Regular expression for extracting number from string
                //  "\d+"
             total = total + int.Parse(Regex.Match(s, regx).Value);

            }
            lblTotal.Text = "Total price: "+ total.ToString();
            lblTotal.Visible = true;
        }
    }
}
