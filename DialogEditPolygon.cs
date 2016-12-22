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
    public partial class DialogEditPolygon : Form
    {
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private TreeView _treeview;
        private int _poly_index;
        private Shape _poly;

        public DialogEditPolygon(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview, int poly_index)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _poly_index = poly_index;
            _poly = _wpg.ShapeAt(_poly_index);
            InitializeComponent();
            txtPolyName.Text = _poly.name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceptChange_Click(object sender, EventArgs e)
        {
            _poly.name = txtPolyName.Text;
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            this.Close();
        }
    }
}
