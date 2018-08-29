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
    public partial class QuantumISP : UserControl
    {
        public QuantumISP()
        {
            InitializeComponent();
        }

        private void lblMalwarebitsHyperlink_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUnsub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! Why do you want to unsub us?\r*inserts a game over window*");
        }
    }
}
