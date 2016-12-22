using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator
{
    public partial class DialogEditPath : Form
    {
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private TreeView _treeview;
        private int _path_index;
        private Path _path;

        public DialogEditPath(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview, int path_index)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _path_index = path_index;
            _path = _wpg.PathAt(path_index);

            InitializeComponent();
            // Set text boxes
            txtPathName.Text = _path.name;
            txtPathType.Text = _path.type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _path.name = txtPathName.Text;
            _path.type = txtPathType.Text;
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            this.Close();
        }
    }
}
