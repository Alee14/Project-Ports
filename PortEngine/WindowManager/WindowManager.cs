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