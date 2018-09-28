/************************************************************************
 *  
 *  PortEngine
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
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace PortEngine
{
    public class StorylineAPI
    {

        public async static void StartHijackEvent1(TextBox txtHijack1)
        {
            if (GeneralAPI.HijackStorylineState == 1)
            {
                await Task.Delay(2000);
                txtHijack1.AppendText("SiliconOS is now booting..." + Environment.NewLine);
                await Task.Delay(5000);
                txtHijack1.AppendText("SYSTEM ERROR: HIJACKED" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Incoming connection..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G is now connected..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: WHO ARE YOU???" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: HOW DID YOU FIND THIS OS?!?!?!?!?" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: SINCE YOU FOUND THIS COMPUTER" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: PREPARE FOR YOUR COMPUTER TO DIE!!!!!" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G is deleting /sys/..." + Environment.NewLine);
                await Task.Delay(1000);
                txtHijack1.AppendText("Incoming connection..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("??? is now Connected..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("???: Hey there! Let me help you…" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("??? interupted the deletion of /sys/" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("??? is restoring /sys/" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: GAH! I CAN’T DELETE ANYTHING" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("/sys/ is restored..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G: WHO ARE YO-" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G has been kicked by ???" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("A.H.G disconnected…" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("???: Sorry about that let me reveal myself..." + Environment.NewLine);
                await Task.Delay(1000);
                txtHijack1.AppendText("??? is now known as Adam…" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Adam: I am Adam and I am one of the developers of SiliconOS!" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Adam: As you know, A.H.G is a group of hackers that destroys SiliconOS computers." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Adam: This computer will shortly reboot and redirected to the desktop…" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Adam: Also make sure to open Chatter once you get to the desktop!" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Adam disconnected..." + Environment.NewLine);
                await Task.Delay(5000);
                txtHijack1.Clear();
                await Task.Delay(2000);
                txtHijack1.AppendText("SiliconOS is now booting..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("GUI Driver has been found!" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Starting Desktop..." + Environment.NewLine);
                await Task.Delay(3000);

            }
            else
            {
                txtHijack1.AppendText("SiliconOS is now booting..." + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("GUI Driver has been found!" + Environment.NewLine);
                await Task.Delay(2000);
                txtHijack1.AppendText("Starting Desktop..." + Environment.NewLine);
                await Task.Delay(3000);
            }
            
        }

        public async static void StartChatterEvent1(TextBox txtSentMessageDump)
        {
            if (GeneralAPI.ChatterStorylineState == 1)
            {
                txtSentMessageDump.AppendText("Adam has entered the channel..." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Hey there user!" + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> You need to set a name so I know who you are." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Open the settings application to change your username using the intuitive interface presented to you." + Environment.NewLine);
                await Task.Delay(10000);
                txtSentMessageDump.AppendText("<Adam> Great!" + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Hello, " + GeneralAPI.PlayerName + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> If you open your app launcher, there is an application called the 'QuantumNet Browser'" + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> The QuantumNet is not a normal type of internet connection." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> It protects your privacy and has custom web-pages." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Think of it like the deep web, but, deeper." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> It does not use the normal domains used with the World Wide Web, it uses specially formatted domains." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Your computer seems to come with the best subscription out there of the QuantumNet. To check your subscription information, open the QuantumNet browser and type 'qt.quantumisp/home'" + Environment.NewLine);
                await Task.Delay(15000);
                txtSentMessageDump.AppendText("<Adam> The domain names are pretty much a mixed version of the ones you would see on the normal Internet." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Now, I need to talk about security and power. These will be important things when you go on with your quests or future endeavors inside of the QuantumNet." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Malwarebits is a very useful QuantumSite to visit. It will allow you to upgrade those things. To do this, head to 'qt.malwarebits/home'" + Environment.NewLine);
                await Task.Delay(15000);
                txtSentMessageDump.AppendText("<Adam> To upgrade these, you will need to earn HackPoints. The easiest way to do this is to play games." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> Anyways, I will see you... later..." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("<Adam> I need to work on... something else..." + Environment.NewLine);
                await Task.Delay(2000);
                txtSentMessageDump.AppendText("Adam has disconnected from the channel. " + Environment.NewLine);
            }
        }


    }
}
