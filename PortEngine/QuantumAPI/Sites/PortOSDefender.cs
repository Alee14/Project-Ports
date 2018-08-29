using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortEngine.QuantumAPI.Sites
{
    public partial class PortOSDefender : UserControl
    {
        public PortOSDefender()
        {
            InitializeComponent();
        }

        private void PortOSDefender_Load(object sender, EventArgs e)
        {
            rtxtNews.Text = "10/3/2030: Adam and "+ Properties.Settings.Default.userDisplayName +" had tracked down one of the A.H.G employees";
        }
    }
}
