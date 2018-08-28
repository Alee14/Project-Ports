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
    public partial class TestWindow : UserControl
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void TestWindow_Load(object sender, EventArgs e)
        {
           WindowManager wm = new WindowManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crash crash = new Crash();
            crash.Show();
        }
    }
}
