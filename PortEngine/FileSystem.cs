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
        public static string homeFolder
        {
            get
            {
                return Path.Combine(dataFolder, "home");
            }
        }
        public static string logsFolder
        {
            get
            {
                return Path.Combine(dataFolder, "logs");
            }
        }
        public static string sysFolder
        {
            get
            {
                return Path.Combine(dataFolder, "sys");
            }
        }


        public static void CreateGameFolder()
        {
                Directory.CreateDirectory(universedgFolder);
                Directory.CreateDirectory(portsFolder);
                Directory.CreateDirectory(dataFolder);
                Directory.CreateDirectory(homeFolder);
                Directory.CreateDirectory(logsFolder);
                Directory.CreateDirectory(sysFolder);
        }

    }
   
}


