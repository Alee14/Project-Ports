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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine;

namespace Project_Ports
{
    public partial class Crash : Form
    {
        public Crash()
        {
            InitializeComponent();
        }

        private async void Crash_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            if (Properties.Settings.Default.hijacked2 == true)
            {
                MessageBox.Show("Coming soon!");
            }
            else
            {
                Boot boot = new Boot();
                boot.Show();
                this.Close();
            }
        }
    }
}
