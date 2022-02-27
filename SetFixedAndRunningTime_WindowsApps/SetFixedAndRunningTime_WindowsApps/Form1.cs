using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetFixedAndRunningTime_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //lblNowTime.Text = dt.ToString();
           // lblNowTime.Text = dt.ToLongDateString();
          //  lblNowTime.Text = dt.ToShortDateString();
         //   lblNowTime.Text = dt.ToLongTimeString();

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblNowTime.Text = dt.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
