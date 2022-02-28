using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHover_MouseLeaveEvent_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Mouse is on the button!";

            btnClick.BackColor = Color.White;
            btnClick.ForeColor = Color.Red;

            btnClick.Font = new Font("hobo std", 17);

            btnClick.Width = 200;
            btnClick.Height = 150;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse left from the button!";

            btnClick.BackColor = Color.Coral;
            btnClick.ForeColor = Color.Black;

            btnClick.Font = new Font("Times New Roman", 12);

            btnClick.Width = 182;
            btnClick.Height = 136;
        }
    }
}
