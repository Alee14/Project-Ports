/************************************************************************
 *  
 *  Project Ports
 *  Copyright (C) 2018 UniverseDG
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 **************************************************************************/
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
            txtSentMessages.AppendText(GeneralAPI.PlayerName + " has entered the channel!");

        }

        private async void txtSentMessages_TextChanged(object sender, EventArgs e)
        {
            if (txtSentMessages.Text == GeneralAPI.PlayerName + " has entered the channel!" + Environment.NewLine)
            {
                await Task.Delay(1000);
                StorylineAPI.StartChatterEvent1(txtSentMessages);
            }
        }
    }
}
