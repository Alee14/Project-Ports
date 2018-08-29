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
    public partial class QuantumISP : UserControl
    {
        public QuantumISP()
        {
            InitializeComponent();
        }

        private void lblMalwarebitsHyperlink_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUnsub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! Why do you want to unsub us?\r*inserts a game over window*");
        }
    }
}
