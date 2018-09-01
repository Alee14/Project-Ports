using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortEngine;

namespace PortsTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunConsole = true;
            PortsTerminalAPI.InitializeConsole();

            while(RunConsole == true)
            {
                PortsTerminalAPI.RunCommand(Console.ReadLine());
            }

            
            Console.ReadLine();
        }
    }
}
