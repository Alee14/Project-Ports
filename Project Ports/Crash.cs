using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Crash_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            /*
            if (Properties.Settings.Default.hijacked2 == true)
            {
                MessageBox.Show("Coming soon!");
            }
            else
            {
                Boot boot = new Boot();
                boot.Show();
                this.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
