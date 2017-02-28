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
    public partial class DialogTangentArcPath : Form
    {
        private double _lat;
        private double _lon;
        private double _alt;
        private double _bearing;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private Options _options;
        private Path _path;
        private WayPoints _wp;
        private bool _new_path;
        private bool _first_pass;
        private bool _build;

        public DialogTangentArcPath(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path, double lat, double lon, double alt, double bearing)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _lat = lat;
            _lon = lon;
            _alt = alt;
            _bearing = bearing;
            _wp = new WayPoints();

            InitializeComponent();

            txtAngle.Text = Convert.ToString(trkAngle.Value);
            txtRadius.Text = Convert.ToString(trkRadius.Value);
            txtNumPoints.Text = Convert.ToString(trkNumPoints.Value);

            if (path == null)
            {
                _new_path = true;
                _first_pass = true;
                _path = new Path();
                _path.visible = true;
                _path.selected = false;
                _build = true;

            } else
            {
                _new_path = false;
                _first_pass = false;
                _path = path;
                _path.visible = true;
                _path.selected = false;
            }

            buildPath();
        }

        private void buildPath()
        {
            bool cwdir = radioCCW.Checked;
            double radius = trkRadius.Value;
            double anglespan = trkAngle.Value;
            double numpoints = trkNumPoints.Value;
            double lat_center, lon_center;
            double lat_new, lon_new;
            double ang_inc, angle;
            Models.Action action = _wpg.GetAction("No Action");
            int no_action_id = action.internal_id;

            // Calculate Center Point

            double ang;
            if (cwdir)
            {
                ang = _bearing + 90;
            } else
            {
                ang = _bearing - 90;
            }

            lat_center = GPS.GPS_Lat_BearDist(_lat, _lon, ang, radius, _options.earth_radius);
            lon_center = GPS.GPS_Lon_BearDist(_lat, _lon, lat_center, ang, radius, _options.earth_radius);

            LinkedList<WayPoints> wplist = new LinkedList<WayPoints>();

            ang = ang + 180;
            ang_inc = anglespan / numpoints;

            for(int i=1; i<= numpoints; i++)
            {
                if(cwdir) angle = ang - (i * ang_inc);
                else angle = ang + (i * ang_inc);
                lat_new = GPS.GPS_Lat_BearDist(lat_center, lon_center, angle, radius, _options.earth_radius);
                lon_new = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_new, angle, radius, _options.earth_radius);
                _wp.Add_Waypoint_List(_wpg, wplist, lat_new, lon_new, _alt, 0.0, 0.0, 0.0, 0, 0, -1, no_action_id);

            }


            if (_new_path & _first_pass)
            {
                string path_name = txtName.Text;
                _path.Add_Path(_wpg, _gmap, path_name, "TangentArc", wplist);
                _path = _wpg.PathAt(_wpg.PathCount() - 1);
                string path_id = Convert.ToString(_path.internal_id);
                if (path_name == "") path_name = "Untitled - TangentArc - " + path_id;
                _path.name = path_name;
                //MathGUI gui = new MathGUI();
                //gui.name = txtPathName.Text;
                
                //_path.mathgui = gui;
                _path.visible = true;
                _path.selected = false;
                _first_pass = false;
                //Models.Path newpath = _wpg.PathAt(_current_path_index);
                //newpath.visible = true;
                //newpath.selected = true;
            }
            else
            {
                _path.waypoints = wplist;
            }

            _gmap.ReDrawgMap();

        }

        private void trkRadius_Scroll(object sender, EventArgs e)
        {
            txtRadius.Text = Convert.ToString(trkRadius.Value);
            buildPath();
        }

        private void trkAngle_Scroll(object sender, EventArgs e)
        {
            txtAngle.Text = Convert.ToString(trkAngle.Value);
            buildPath();
        }

        private void trkNumPoints_Scroll(object sender, EventArgs e)
        {
            txtNumPoints.Text = Convert.ToString(trkNumPoints.Value);
            buildPath();
        }

        private void radioCW_CheckedChanged(object sender, EventArgs e)
        {
            buildPath();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buildPath();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_new_path) _wpg.DeletePath(_path);
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _path.selected = false;
            _path.visible = true;
            _gmap.ReDrawgMap();
            this.Close();
        }
    }
}
