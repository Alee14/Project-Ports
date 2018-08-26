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


            switch (txtConsoleInput.Text.ToLower())
            {
                

                case "help":
                    txtConsoleOutput.AppendText("help - lists the commands\r\ntest - displays a test message\r\nclear - clears the terminal\r\nchangeusername - changes your username for use with the Chatter application\r\n   example: changeusername --TheBestUser" + Environment.NewLine);
                    break;
                case "clear":
                    txtConsoleOutput.Clear();
                    LastCommandWasClear = true;
                    break;
                case "test":
                    txtConsoleOutput.AppendText("This is a test!\r\nof the EBS!" + Environment.NewLine);
                    break;
                default:
                    if (txtConsoleInput.Text.StartsWith("changeusername --"))
                    {
                        txtConsoleOutput.AppendText("You have changed your username to " + txtConsoleInput.Text.Substring(17));
                        Properties.Settings.Default.userDisplayName = txtConsoleInput.Text.Substring(17);
                    }
                    else
                    {
                        txtConsoleOutput.AppendText("Bad command. Reference the command list for commands that exist." + Environment.NewLine);
                    }
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
