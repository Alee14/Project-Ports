/************************************************************************
 *  
 *  PortEngine
 *  Copyright (C) 2018 UniverseDG
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 **************************************************************************/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortEngine
{
    public class FileSystem
    {
        public static string universedgFolder
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UniverseDG");
            }
        }
        public static string portsFolder
        {
            get
            {
                return Path.Combine(universedgFolder, "Project Ports");
            }
        }
        public static string dataFolder
        {
            get
            {
                return Path.Combine(portsFolder, "Data");
            }
        }
        public static string bootFolder
        {
            get
            {
                return Path.Combine(dataFolder, "boot");
            }
        }
        public static string homeFolder
        {
            get
            {
                return Path.Combine(dataFolder, "home");
            }
        }
        public static string usrFolder
        {
            get
            {
                return Path.Combine(dataFolder, "usr");
            }
        }
        public static string etcFolder
        {
            get
            {
                return Path.Combine(dataFolder, "etc");
            }
        }
        public static string tmpFolder
        {
            get
            {
                return Path.Combine(dataFolder, "tmp");
            }
        }
        public static string rootFolder
        {
            get
            {
                return Path.Combine(dataFolder, "root");
            }
        }
        public static string mntFolder
        {
            get
            {
                return Path.Combine(dataFolder, "mnt");
            }
        }
        public static string runFolder
        {
            get
            {
                return Path.Combine(dataFolder, "run");
            }
        }
        public static string sysFolder
        {
            get
            {
                return Path.Combine(dataFolder, "sys");
            }
        }
        public static void warningTxt()
        {
         //   string textWarning = "Warning: You are currently in the Project Ports AppData folder" + Environment.NewLine +
         //                        "Please be caution if modifing the system files, the game can corrupt. "+ Environment.NewLine + "Stay safe, UniverseDG";

         //   File.WriteAllText(dataFolder, "warning.txt", textWarning);
        }


        public static void CreateGameFolder()
        {
                Directory.CreateDirectory(universedgFolder);
                Directory.CreateDirectory(portsFolder);
                Directory.CreateDirectory(dataFolder);
                Directory.CreateDirectory(homeFolder);
                Directory.CreateDirectory(bootFolder);
                Directory.CreateDirectory(sysFolder);
                Directory.CreateDirectory(etcFolder);
                Directory.CreateDirectory(usrFolder);
                Directory.CreateDirectory(tmpFolder);
                Directory.CreateDirectory(rootFolder);
                Directory.CreateDirectory(runFolder);
                Directory.CreateDirectory(mntFolder);
        }
    }
   
}


