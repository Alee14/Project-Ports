using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void ChatApp_Load(object sender, EventArgs e)
        {
            /*
            #if DEBUG
            Properties.Settings.Default.chatterStoryline = false;
            #endif
            

            if (Properties.Settings.Default.chatterStoryline == true)
            {
                Thread.Sleep(2000);
                txtSentMessages.AppendText("Adam has entered the channel..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessages.AppendText("<Adam> Hey there user!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessages.AppendText("<Adam> You need to set a name so I know who you are." + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessages.AppendText("<Adam> Open a terminal and input do the following: \"changeusername --YourUsernameHere\"." + Environment.NewLine);
                Thread.Sleep(10000);
                txtSentMessages.AppendText("<Adam> Great!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtSentMessages.AppendText("<Adam> Hello username" + Environment.NewLine); //TODO
                
            } */
        }
    }
}
