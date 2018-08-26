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
    public partial class QuantumNet : UserControl
    {
        public QuantumNet()
        {
            InitializeComponent();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QuantumnetAPI.navigateToSite(txtAddress, pnlSiteContents);
            }
        }
    }
}
