using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortEngine
{
    class CrashAPI
    {
        public static void ResetAPI ()
        {
            Properties.Settings.Default.userBalance = 0;
            //Properties.Settings.Default.userSecurityLevel = 1;
           // Properties.Settings.Default.userPowerLevel = 1;
            Properties.Settings.Default.userDisplayName = "Player";
        }
    }
}
