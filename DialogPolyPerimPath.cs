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
    public partial class DialogPolyPerimPath : Form
    {

        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private Options _options;
        private TreeView _treeview;
        Models.Path _path = new Models.Path();
        WayPoints _wp = new WayPoints();
        int _current_path_index = -1;

        public DialogPolyPerimPath(Waypoint_Path_Gen wpg, GMAP gmap, Options options, TreeView treeview)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _treeview = treeview;
            InitializeComponent();
            txtAltPolyPath.Text = Convert.ToString(_options.def_altitude);
            cmbPolyPath.Items.Clear();
            for(int i = 0; i < _wpg.ShapeCount(); i++)
            {
                cmbPolyPath.Items.Add(_wpg.ShapeAt(i).name);
            }
        }

        private void txtAltPolyPath_TextChanged(object sender, EventArgs e)
        {
            BuildPath();
        }

        private void trkAltPolyPath_Scroll(object sender, EventArgs e)
        {
            txtAltPolyPath.Text = Convert.ToString(trkAltPolyPath.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_current_path_index != -1) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _current_path_index = -1;
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            this.Close();
        }

        private void BuildPath()
        {
            int polyindex = cmbPolyPath.SelectedIndex;
            if (polyindex == -1) return;

            // Get Path

            double lat, lat_next;
            double lon, lon_next;
            double alt = Convert.ToDouble(txtAltPolyPath.Text);
            double head;
            int gimblemode = 0;
            double gimblepitch = 0;
            double curvesize = 0;
            double rotdir = 0;
            Models.Action action = _wpg.GetAction("No Action");
            int action_id = action.internal_id;
            Models.Shape poly = _wpg.ShapeAt(polyindex);
            LinkedList<PolyPoint> points = poly.points;
            LinkedList<WayPoints> waypoints = new LinkedList<WayPoints>();
            string path_name = poly.name;
            for (int i = 0; i < points.Count; i++)
            {
                lat = points.ElementAt(i).lat;
                lon = points.ElementAt(i).lon;
                if (i < (points.Count - 1))
                {
                    lat_next = points.ElementAt(i + 1).lat;
                    lon_next = points.ElementAt(i + 1).lon;
                    head = GPS.GPS_Bearing(lat, lon, lat_next, lon_next);
                }
                else
                {
                    lat_next = points.ElementAt(0).lat;
                    lon_next = points.ElementAt(0).lon;
                    head = GPS.GPS_Bearing(lat, lon, lat_next, lon_next);
                }
                _wp.Add_Waypoint_List(_wpg, waypoints, lat, lon, alt, head, curvesize, rotdir, gimblemode, gimblepitch, action_id);
            }

            // Add Path

            if (_current_path_index != -1)
            {
                _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            }

            int index = cmbPolyPath.SelectedIndex;
            path_name = _wpg.ShapeAt(index).name;
            if (path_name == "") path_name = "Untitled - Perimeter";
            _path.Add_Path(_wpg, _gmap, path_name, "Perimeter", waypoints);
            index = _wpg.PathCount() - 1;
            _current_path_index = index;

            Models.Path path = _wpg.PathAt(index);
            path_name = "Untitled - Perimeter - " + Convert.ToString(path.internal_id);
            path.name = path_name;
            string exist_type = path.type;
            bool exist_select = path.selected;
            bool exist_visible = path.visible;
            if (exist_type == "Perimeter")
            {
                _wpg.ChangePathWP(index, waypoints);
                string pathname = path.name;
                int id = path.id;
                string type = path.type;
                _gmap.Delete_gMapPath(path);
                Models.Path newpath = new Models.Path();
                newpath.name = pathname;
                newpath.id = id;
                newpath.type = type;
                newpath.selected = exist_select;
                newpath.visible = exist_visible;
                newpath.waypoints = waypoints;
                _gmap.Add_gMapPath(path, false);
            }

            _gmap.ReDrawgMap();

        }

        private void cmbPolyPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildPath();
        }
    }
}
