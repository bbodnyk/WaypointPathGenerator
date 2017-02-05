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
        Options _options;
        double _lat;
        double _lon;
        Path _path;
        LinkedList<WayPoints> _wp_list;
        WayPoints _wp;
        double _alt;
        int _action_id;
        bool _handler_off;

        public DialogManualPath(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview, Path path, Options options, double lat, double lon)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _options = options;
            _path = path;
            _lat = lat;
            _lon = lon;
            Models.Action action = _wpg.GetAction("No Action");
            _action_id = action.internal_id;
            

            InitializeComponent();

            // Create new Path with a Single Waypoint

            _alt = _options.def_altitude;

            _handler_off = true;
            txtManualAltitude.Text = Convert.ToString(_alt);
            _handler_off = false;
            string name = txtPathName.Text;
            _path.name = name; ;
            _path.type = "Manual";
            _path.visible = true;
            _path.selected = true;
            _wp_list = new LinkedList<WayPoints>();
            _wp = new WayPoints();
            _wp.lat = _lat;
            _wp.lon = _lon;
            _wp.visible = true;
            _wp.selected = false;
            _wp.head = 0;
            _wp.alt = _alt;
            _wp.action_id = _action_id;
            _wp_list.AddLast(_wp);
            _wp_list.AddLast(_wp);
            _path.waypoints = _wp_list;
            _wpg.AddPath(_path);
            if (name == "") name = "Untitled - Manual - " + Convert.ToString(_path.internal_id);
            _path.name = name;

            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _wpg.DeletePath(_path);
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            LinkedList<WayPoints> wp_list = _path.waypoints;
            int count = wp_list.Count();
            if(count > 1)
            {
                wp_list.RemoveLast();
                _gmap.ReDrawgMap();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _path.selected = true;
            LinkedList<WayPoints> wp_list = _path.waypoints;
            foreach (WayPoints wp in wp_list)
            {
                wp.selected = true;
            }
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void txtPathName_TextChanged(object sender, EventArgs e)
        {
            _path.name = txtPathName.Text;
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
        }

        private void txtManualAltitude_TextChanged(object sender, EventArgs e)
        {
            if (_handler_off) return;
            double alt = Convert.ToDouble(txtManualAltitude.Text);
            LinkedList<WayPoints> wp_list = _path.waypoints;
            for(int i=0; i < wp_list.Count; i++)
            {
                wp_list.ElementAt(i).alt = alt;
            }
            _gmap.ReDrawgMap();
        }
    }
}
