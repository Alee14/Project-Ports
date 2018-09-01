using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortEngine
{
    public class PortsTerminalAPI
    {
        public static void InitializeConsole()
        {
            AppendConsolePrefix();
        }

        public static void AppendConsolePrefix()
        {
            string ConsolePrefix = (Properties.Settings.Default.userDisplayName + "@PortOS:~$ ");

            Console.Write(ConsolePrefix);
        }

        public static void RunCommand(String pendingCommand)
        {
            bool LastCommandWasClear = false;

            switch (pendingCommand)
            {
                case "help":
                    Console.WriteLine("help - lists the commands\r\ntest - displays a test message\r\nclear - clears the terminal\r\nchangeusername - changes your username for use with the Chatter application\r\n   example: changeusername --TheBestUser" + Environment.NewLine);
                    
                    break;
                case "clear":
                    Console.Clear();
                    LastCommandWasClear = true;
                    
                    break;
                case "test":
                    Console.WriteLine("This is a test!\r\nof the EBS!" + Environment.NewLine);
                    
                    break;
                    
                default:
                    if (pendingCommand.StartsWith("changeusername --"))
                    {
                        Console.WriteLine("Changed username.");
                        Properties.Settings.Default.userDisplayName = pendingCommand.Substring(17);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Syntax error. Reference the command list for commands that exist." + Environment.NewLine);
                    }
                    break;
            }

            if (LastCommandWasClear == true)
            {
                LastCommandWasClear = false;
                AppendConsolePrefix();
            }
            else
            {
                Console.WriteLine();
                AppendConsolePrefix();
            }
        }
    }
}
