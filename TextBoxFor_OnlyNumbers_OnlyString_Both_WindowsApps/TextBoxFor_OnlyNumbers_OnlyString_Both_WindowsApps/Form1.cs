using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxFor_OnlyNumbers_OnlyString_Both_WindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        { 
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if(ch == 8)
            {
                e.Handled=false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void textBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8) // Value of Backspace 8
            {
                e.Handled = false;
            }
            else if (ch == 32) // value of Space 32
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxBoth_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8) // Value of Backspace 8
            {
                e.Handled = false;
            }
            else if (ch == 32) // value of Space 32
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
