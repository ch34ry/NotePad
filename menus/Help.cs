using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            Shortcuts();
            label3.Text = "This is Text Editor | created by someone";
        }

        public void Shortcuts()
        {
            label4.Text = "New:  Ctrl + N";
            label5.Text = "Open:  Ctrl + O";
            label6.Text = "Save:  Ctrl + S";
            label7.Text = "Save as:  Ctrl + Shift + S";
            label8.Text = "Exit:  Alt + F4";
            label9.Text = "Undo:  Ctrl + Z";
            label10.Text = "Redo:  Ctrl + X";



        }


    }
}
