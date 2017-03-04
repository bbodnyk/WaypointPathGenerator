using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waypoint_Path_Generator
{
    public partial class DialogAbout : Form
    {
        public DialogAbout()
        {
            InitializeComponent();
        }

        private void DialogAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version 1.0 - 132396ec";
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
