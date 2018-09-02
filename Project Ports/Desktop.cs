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
            GeneralAPI.appendUsername(playerName);
            this.ltime.Text = DateTime.Now.ToString("hh:mm tt");
            
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            #if DEBUG
            btnTestWindow.Visible = true;
            btnhijack2.Visible = true;
            btnCrash.Visible = true;
            #endif
            dclock.Start();
            desktopWatermark.Text = "Project: Ports " + Properties.Settings.Default.version + Environment.NewLine + "Working Progress";
            appMenu.Hide();

        }

        private void appButton_Click(object sender, EventArgs e)
        {
            appMenu.Show();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Desktop_MouseClick(object sender, MouseEventArgs e)
        {
            appMenu.Hide();
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            wm.createWindow(new Terminal(), "Terminal");
            appMenu.Hide();

        }

        private void btnChatter_Click(object sender, EventArgs e)
        {
            wm.createWindow(new ChatApp(), "Chatter");
            appMenu.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            wm.createWindow(new Settings(), "System Settings");
            appMenu.Hide();
        }

        private void btnQuantumNet_Click(object sender, EventArgs e)
        {
            wm.createWindow(new QuantumNet(), "QuantumNet Browser");
            appMenu.Hide();
        }

        private void btnTestWindow_Click(object sender, EventArgs e)
        {
            wm.createWindow(new TestWindow(), "TestWindow");
            appMenu.Hide();
        }

        private async void btnhijack2_Click(object sender, EventArgs e)
        {
            appMenu.Hide();
            await Task.Delay(5000);
            appButton.Enabled = false;
            await Task.Delay(2000);
            dclock.Stop();
            ltime.Text = "66:66 AM";
            appButton.Text = "HIJACKED";
            await Task.Delay(5000);
            Crash crash = new Crash();
            crash.Show();

        }

        private void btnCrash_Click(object sender, EventArgs e)
        {
            Crash crash = new Crash();
            crash.Show();
            this.Close();
        }

        private void lbPrograms_Click(object sender, EventArgs e)
        {

        }

        private void btnFileManager_Click(object sender, EventArgs e)
        {

        }
    }
}
