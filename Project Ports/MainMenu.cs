﻿/************************************************************************
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
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine;

namespace Project_Ports
{

    public partial class MainMenu : Form
    {
        WindowManager wm = new WindowManager();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            Boot boot = new Boot();
            #if DEBUG
            Properties.Settings.Default.hijacked = false;
            #endif 
            if (Properties.Settings.Default.hijacked == true)
            {
                hijackScreen hijack = new hijackScreen();
                hijack.Show();
            }
            else
            {
                boot.Show();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            wm.createWindow(new AboutPorts(), "About Ports");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            #if DEBUG
            MessageBox.Show("You have set the build to \"Debug\". There are some features that is disabled in debug builds.");
            #endif
            portsVersion.Text = Properties.Settings.Default.version;
            FileSystem.CreateGameFolder();

        }

    }
}