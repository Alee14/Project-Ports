using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Ports
{
    public partial class hijackScreen : Form
    {
        public hijackScreen()
        {
            InitializeComponent();
        }

        private void hijackScreen_Load(object sender, EventArgs e)
        {

                    Thread.Sleep(2000);
                    txtHijack.AppendText("PortOS is now booting..." + Environment.NewLine);
                    Thread.Sleep(5000);
                    txtHijack.AppendText("SYSTEM ERROR: HIJACKED" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Incoming connection..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G is now connected..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: WHO ARE YOU???" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: HOW DID YOU FIND THIS OS?!?!?!?!?" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: SINCE YOU FOUND THIS COMPUTER" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: PREPARE FOR YOUR COMPUTER TO DIE!!!!!" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G is deleting /sys/..." + Environment.NewLine);
                    Thread.Sleep(1000);
                    txtHijack.AppendText("Incoming connection..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("??? is now Connected..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("???: Hey there! Let me help you…" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("??? interupted the deletion of /sys/" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("??? is restoring /sys/" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: GAH! I CAN’T DELETE ANYTHING" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("/sys/ is restored..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G: WHO ARE YO-" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G has been kicked by ???" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("A.H.G disconnected…" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("???: Sorry about that let me reveal myself..." + Environment.NewLine);
                    Thread.Sleep(1000);
                    txtHijack.AppendText("??? is now known as Adam…" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Adam: I am Adam and I am one of the developers of PortOS!" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Adam: As you know, A.H.G is a group of hackers that destroys PortOS computers." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Adam: This computer will shortly reboot and redirected to the desktop…" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Adam: Also make sure to open Chatter once you get to the desktop!" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Adam disconnected..." + Environment.NewLine);
                    Thread.Sleep(5000);
                    txtHijack.Clear();
                    Thread.Sleep(2000);
                    txtHijack.AppendText("PortOS is now booting..." + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("GUI Driver has been found!" + Environment.NewLine);
                    Thread.Sleep(2000);
                    txtHijack.AppendText("Starting Desktop..." + Environment.NewLine);
                    Thread.Sleep(3000);

                    Desktop desktop = new Desktop();
                    Properties.Settings.Default.hijacked = false;
                    desktop.Show();
                    this.Close();

                
            }
        }
    }
