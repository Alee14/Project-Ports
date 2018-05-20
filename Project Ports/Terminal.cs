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
           WindowManager wm = new PortEngine.WindowManager();
           
    }
}
