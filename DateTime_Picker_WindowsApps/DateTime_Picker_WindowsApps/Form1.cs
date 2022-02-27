using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Picker_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToString("hh:mm:ss-tt"));
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToString("dd - mm - yy    hh: mm: ss - tt")); 
        }
    }
}
