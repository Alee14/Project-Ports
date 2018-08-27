using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortEngine
{
    public class GeneralAPI
    {

        public static void setNameOnAppLauncher(Label txtUserDestination)
        {
            txtUserDestination.Text = Properties.Settings.Default.userDisplayName;
        }

    }
}
