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
            ChatAPI.SendMessage(txtMsgContents, txtSentMessages);
        }

        private void txtMsgContents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChatAPI.SendMessage(txtMsgContents, txtSentMessages);
                e.SuppressKeyPress = true;
            }
        }
    }
}
