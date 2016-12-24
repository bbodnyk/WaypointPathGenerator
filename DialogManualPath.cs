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
    public partial class DialogManualPath : Form
    {
        Waypoint_Path_Gen _wpg;
        GMAP _gmap;
        TreeView _treeview;
        double _lat;
        double _lon;
        Path _path;
        LinkedList<WayPoints> _wp_list;
        WayPoints _wp;
        double _alt;

        public DialogManualPath(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview, double lat, double lon)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _lat = lat;
            _lon = lon;
            int[,] _actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };
            

            InitializeComponent();

            // Create new Path with a Single Waypoint

            _alt = Convert.ToDouble(txtManualAltitude.Text);
            _path = new Path();
            string name = txtPathName.Text;
            _path.name = name; ;
            _path.type = "Manual";
            _path.visible = true;
            _path.selected = false;
            _wp_list = new LinkedList<WayPoints>();
            _wp = new WayPoints();
            _wp.lat = _lat;
            _wp.lon = _lon;
            _wp.head = 0;
            _wp.alt = _alt;
            _wp.actions = _actions;
            _wp_list.AddLast(_wp);
            _path.waypoints = _wp_list;
            _wpg.AddPath(_path);


            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
