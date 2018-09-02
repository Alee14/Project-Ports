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
using System.Diagnostics;

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
            DirectoryInfo fmdataFolder = new DirectoryInfo(FileSystem.dataFolder);
            txtPath.Text = fmdataFolder.FullName;
            foreach (string item in Directory.GetFiles(fmdataFolder.FullName))
            {
                imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
                listFiles.Add(fi.FullName);
                listView.Items.Add(fi.Name, imageList.Images.Count - 1);
            }
            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
                Process.Start(listFiles[listView.FocusedItem.Index]);
        }
    }
}
