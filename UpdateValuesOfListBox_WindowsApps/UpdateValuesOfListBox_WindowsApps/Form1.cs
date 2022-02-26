using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateValuesOfListBox_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {   

             if(listBoxItem.SelectedIndex != null)
            {
              
            }
               
            else
                textBoxUpdateItem.Text = listBoxItem.SelectedItem.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = listBoxItem.SelectedIndex;
            listBoxItem.Items.RemoveAt(index);
            listBoxItem.Items.Insert(index,textBoxUpdateItem.Text);

        }
    }
}
