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
    public partial class ChatApp : UserControl
    {

        public ChatApp()
        {
            InitializeComponent();
        }

        private void btnSendMSG_Click(object sender, EventArgs e)
        {
            PortEngine.ChatAPI.SendMessage(txtMsgContents, txtSentMessages);
        }
    }
}
