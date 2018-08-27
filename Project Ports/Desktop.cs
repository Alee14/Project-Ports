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
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PortEngine;


namespace Project_Ports
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        WindowManager wm = new WindowManager();

        private void dclock_Tick(object sender, EventArgs e)
        {

                this.ltime.Text = DateTime.Now.ToString("hh:mm tt");
            
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            #if DEBUG
            MessageBox.Show("You have set the build to \"Debug\" there are some features that is disabled in this build.");
            #endif
            dclock.Start();
            hijackScreen.Hide();
            
            if (Properties.Settings.Default.hijacked == true)
            {
                #if DEBUG
                hijackScreen.Hide();
                return;
                #endif
                hijackScreen.Show();
                Thread.Sleep(2000);
                txtHijack.AppendText("PortOS is now booting..." + Environment.NewLine);
                Thread.Sleep(5000);
                txtHijack.AppendText("SYSTEM ERROR: HIJACKED" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Incoming connection..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G is now connected..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: WHO ARE YOU???" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: HOW DID YOU FIND THIS OS?!?!?!?!?" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: SINCE YOU FOUND THIS COMPUTER" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: PREPARE FOR YOUR COMPUTER TO DIE!!!!!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G is deleting /sys/..." + Environment.NewLine);
                Thread.Sleep(1000);
                txtHijack.AppendText("Incoming connection..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("??? is now Connected..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("???: Hey there! Let me help you…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("??? interupted the deletion of /sys/" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("??? is restoring /sys/" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: GAH! I CAN’T DELETE ANYTHING" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("/sys/ is restored..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G: WHO ARE YO-" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G has been kicked by ???" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("A.H.G disconnected…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("???: Sorry about that let me reveal myself..." + Environment.NewLine);
                Thread.Sleep(1000);
                txtHijack.AppendText("??? is now known as Adam…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Adam: I am Adam and I am one of the developers of PortOS!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Adam: As you know, A.H.G is a group of hackers that destroys PortOS computers." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Adam: This computer will shortly reboot and redirected to the desktop…" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Adam: Also make sure to open Chatter once you get to the desktop!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Adam disconnected..." + Environment.NewLine);
                Thread.Sleep(5000);
                txtHijack.Clear();
                Thread.Sleep(2000);
                txtHijack.AppendText("PortOS is now booting..." + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("GUI Driver has been found!" + Environment.NewLine);
                Thread.Sleep(2000);
                txtHijack.AppendText("Starting Desktop..." + Environment.NewLine);
                Thread.Sleep(3000);

                hijackScreen.Hide();
                Properties.Settings.Default.hijacked = false;


            }
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new Terminal(), "Terminal");
        }

        private void testWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new TestWindow(), "TestWindow");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new Settings(), "System Settings");
        }

        private void chatterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new ChatApp(), "Chatter");
        }

        private void quantumNetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new QuantumNet(), "QuantumNet Browser");
        }
    }
}
