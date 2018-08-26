using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PortEngine
{
    public class ChatAPI
    {
        public static void SendMessage(TextBox txtPending, TextBox txtDestination)
        {
            txtDestination.AppendText("<Player> " + txtPending.Text + Environment.NewLine);
            txtPending.Clear();
        }
    }
}
