using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {   
            listBoxGetItem.Items.Clear();
            foreach(string s in checkedListBoxItems.CheckedItems )
            {
                listBoxGetItem.Items.Add(s);
            }
        }

        private void btnItemIndex_Click(object sender, EventArgs e)
        {    
            listBoxIndexItems.Items.Clear();
             for (int i = 0; i < checkedListBoxItems.CheckedIndices.Count; i++)
            {
                listBoxIndexItems.Items.Add(checkedListBoxItems.CheckedIndices[i]);
            }
        }
    }
}
