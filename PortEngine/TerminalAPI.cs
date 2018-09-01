/************************************************************************
 *  
 *  PortEngine
 *  Deprecated Component - TerminalAPI
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortEngine
{
    public class TerminalAPI
    {
        public static void RunCommand(TextBox txtConsoleInput, TextBox txtConsoleOutput)
        {
            bool LastCommandWasClear = false;

            txtConsoleOutput.AppendText(Properties.Settings.Default.userDisplayName + "@PortOS:~$ " + txtConsoleInput.Text + Environment.NewLine);


            switch (txtConsoleInput.Text.ToLower())
            {
                case "help":
                    txtConsoleOutput.AppendText("help - lists the commands\r\ntest - displays a test message\r\nclear - clears the terminal\r\n" + Environment.NewLine);
                    break;
                case "clear":
                    txtConsoleOutput.Clear();
                    LastCommandWasClear = true;
                    break;
                case "test":
                    txtConsoleOutput.AppendText("This is a test!\r\nof the EBS!" + Environment.NewLine);
                    break;
                default:
                    txtConsoleOutput.AppendText("Bad command. Reference the command list for commands that exist." + Environment.NewLine);
                    break;
            }

            if (LastCommandWasClear == true)
            {
                LastCommandWasClear = false;
            }
            else
            {
                txtConsoleOutput.AppendText(Environment.NewLine);
            }
            
        }
    }
}
