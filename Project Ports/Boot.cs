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

namespace Project_Ports
{
    public partial class Boot : Form
    {
        public Boot()
        {
            InitializeComponent();
        }

        private void Boot_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            txtBoot.AppendText("PortOS is now booting...");
            Thread.Sleep(2000);
            txtBoot.AppendText("PortOS is now booting..." + Environment.NewLine);
            Thread.Sleep(2000);
            txtBoot.AppendText("GUI Driver has been found!" + Environment.NewLine);
            Thread.Sleep(2000);
            txtBoot.AppendText("Starting Desktop..." + Environment.NewLine);
            Thread.Sleep(3000);

            Desktop desktop = new Desktop();
            desktop.Show();
            this.Close();
        }
    }
}
