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
using System.Drawing;
using System.Windows.Forms;

namespace PortEngine
{
    public partial class @base : Form
    {
        bool drag;
        int mousex;
        int mousey;
        public @base()
        {
            InitializeComponent();
        }

        #region titlebar
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
        #region timers
        private void tmClose_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0) Dispose();
        }

        private void tmOpen_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity == 1) tmOpen.Enabled = false;
        }
        #endregion
        #region closing
        private void base_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PortEngine.Properties.Settings.Default.graphicsFriendly == true) Dispose();
            tmClose.Enabled = true;
            e.Cancel = true;
        }

        private void base_Load(object sender, EventArgs e)
        {
            tmOpen.Enabled = true;
        }
        #endregion
        #region inactive titlebars
        private void base_Activated(object sender, EventArgs e)
        {
            if (PortEngine.Properties.Settings.Default.graphicsFriendly == true) return;
            pnlTitle.BackColor = Color.White;
            lblProg.ForeColor = SystemColors.ControlText;
            lblProg.BackColor = pnlTitle.BackColor;
        }

        private void base_Deactivate(object sender, EventArgs e)
        {
            if (PortEngine.Properties.Settings.Default.graphicsFriendly == true) return;
            pnlTitle.BackColor = Color.WhiteSmoke;
            lblProg.ForeColor = SystemColors.ControlDark;
            lblProg.BackColor = pnlTitle.BackColor;
        }
#endregion
    }
}