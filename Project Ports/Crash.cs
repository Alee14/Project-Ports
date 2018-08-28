using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine;

namespace Project_Ports
{
    public partial class Crash : Form
    {
        public Crash()
        {
            InitializeComponent();
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.hijacked = true;
            Properties.Settings.Default.chatterStoryline = true;
            this.Close();
            
        }
    }
}
