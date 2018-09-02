using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortEngine;

namespace Project_Ports.Programs
{
    public partial class FileManager : UserControl
    {
        List<string> listFiles = new List<string>();
        public FileManager()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            
        }
    }
}
