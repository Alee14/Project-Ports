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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PortEngine
{
    public class WindowManager
    {
        public void createWindow(UserControl program, String name)
        {
            @base window = new @base()
            {
                Height = program.Height + 30,
                Width = program.Width
            };
            program.Parent = window.pnlContent;
            program.BringToFront();
            program.Dock = DockStyle.Fill;
            window.lblProg.Text = name;
            if  (PortEngine.Properties.Settings.Default.graphicsFriendly == false)  window.Opacity = 0;
            window.TopMost = true;
            window.Show();
        }
    }
}