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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortEngine.QuantumAPI.Sites
{
    public partial class PortOSDefender : UserControl
    {
        public PortOSDefender()
        {
            InitializeComponent();
        }

        private void PortOSDefender_Load(object sender, EventArgs e)
        {
            rtxtNews.Text = "10/3/2030: Adam and "+ Properties.Settings.Default.userDisplayName +" has tracked down one of the A.H.G employees.";
        }
    }
}
