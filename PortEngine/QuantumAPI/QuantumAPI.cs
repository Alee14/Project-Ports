using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PortEngine
{
    public class QuantumnetAPI
    {

        private static void loadSite(UserControl site, Panel pnlSiteArea)
        {
            pnlSiteArea.Controls.Clear();
            pnlSiteArea.Controls.Add(site);
        }

        public static void navigateToSite(TextBox txtNavigateToThis, Panel pnlLoadSiteHere)
        {
            switch (txtNavigateToThis.Text)
            {
                case "qt.quantumconnections":
                    loadSite(new QuantumAPI.Sites.QuantumISP(), pnlLoadSiteHere);
                    break;
                case "qt.malwarebits":
                    loadSite(new Malwarebits(), pnlLoadSiteHere);
                    break;
                case "qt.portosdefender":
                    loadSite(new QuantumAPI.Sites.PortOSDefender(), pnlLoadSiteHere);
                    break;
                default:
                    loadSite(new QuantumAPI.Sites._404Error(), pnlLoadSiteHere);
                    break;
            }

        }
    }
}
