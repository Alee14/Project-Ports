using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine;

namespace Project_Ports
{
    public partial class Terminal : UserControl
    {
       
        public Terminal()
        {
            InitializeComponent();
        }    

        private void Terminal_Load(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TerminalAPI.RunCommand(txtInput, txtConsole);
                e.SuppressKeyPress = true;
                txtInput.Clear();
            }
        }
    }
}
