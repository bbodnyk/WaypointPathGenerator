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
    public partial class DialogAddMathPath : Form
    {
        private double _lat;
        private double _lon;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private Options _options;
        private WayPoints _wp;
        private Path _path;
        private MathGUI _gui;
        private double _gps_radius;
        private bool _new_path;
        private bool _first_pass;
        private bool _build = false;

        public DialogAddMathPath(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path, double lat, double lon)
        {
            // Save arguments
            _wp = new WayPoints();
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _gps_radius = options.earth_radius;
            _lat = lat;
            _lon = lon;

            InitializeComponent();

            // New or Old Path

            if (path == null)
            {
                _new_path = true;
                _first_pass = true;
                _path = new Path();
                _path.visible = true;
                _build = true;

            } else
            {
                _build = false;
                _new_path = false;
                _first_pass = false;
                _path = path;
                _path.visible = true;
                _gui = _path.mathgui;
                txtPathName.Text = _gui.name;
                cmbPathType.SelectedText = _gui.path_type;
                cmbPathType.Text = _gui.path_type;
                trkSize.Value = Convert.ToInt16(_gui.size);
                trkAngle.Value = Convert.ToInt16(_gui.angle);
                trkAlt1.Value = Convert.ToInt16(_gui.altitude);
                trkNumPoints.Value = Convert.ToInt16(_gui.numpnts);
                trkScaleX.Value = Convert.ToInt16(_gui.scalex);
                trkScaleY.Value = Convert.ToInt16(_gui.scaley);
                txtScaleX.Text = Convert.ToString(trkScaleX.Value);
                txtScaleY.Text = Convert.ToString(trkScaleY.Value);
                _lat = _gui.lat;
                _lon = _gui.lon;
                _build = true;
                buildPath();
                _gmap.ReDrawgMap();
            }

            
        }

        private void DialogAddMathPath_Load(object sender, EventArgs e)
        {
            lbltrkAngleValue.Text = "Angle : " + Convert.ToString(trkAngle.Value);
            lbltrkNumPoints.Text = "Num Points : " + Convert.ToString(trkNumPoints.Value);
            lbltrkAlt1.Text = "Altitude : " + Convert.ToString(trkAlt1.Value);
            lbltrkSize.Text = "Size : " + Convert.ToString(trkSize.Value);
            lbltrkSize.Text = "Size : " + Convert.ToString(trkSize.Value);
            txtScaleX.Text = Convert.ToString(trkScaleX.Value);
            txtScaleY.Text = Convert.ToString(trkScaleY.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_new_path) _wpg.DeletePath(_path);
           
            this.Close();
        }

        private void trkAngle_Scroll(object sender, EventArgs e)
        {
            lbltrkAngleValue.Text = "Angle : " + Convert.ToString(trkAngle.Value);
            buildPath();
        }

        private void lbltrkValue_Click(object sender, EventArgs e)
        {

        }

        private void trkNumPoints_Scroll(object sender, EventArgs e)
        {
            lbltrkNumPoints.Text = "Num Points : " + Convert.ToString(trkNumPoints.Value);
            buildPath();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildPath();
        }

        private void buildPath()
        {
            if (!_build) return;

            double dist, bearing;
            double altitude = trkAlt1.Value;
            double size = trkSize.Value;
            int numpnt = trkNumPoints.Value;
            double scalex = Convert.ToDouble(txtScaleX.Text);
            double scaley = Convert.ToDouble(txtScaleY.Text);
            double lat2 = _lat + 1.0;
            double lon2 = _lon + 1.0;
            double lat, lon, lat_inc, lon_inc;
            double gps_radius = _options.earth_radius + Convert.ToDouble(trkAlt1.Value);
            double lat_degree = GPS.GPS_Distance(_lat, _lon, lat2, _lon, gps_radius);
            double lon_degree = GPS.GPS_Distance(_lat, _lon, _lat, lon2, gps_radius);

            rtbMathPath.Clear();
            rtbMathPath.AppendText("Parabola\n");
            rtbMathPath.AppendText("Meters/Degree Lat : " + Convert.ToString(lat_degree) + "\n");
            rtbMathPath.AppendText("Meters/Degree Lon : " + Convert.ToString(lon_degree) + "\n");


            // Get type of path

            string path_type = cmbPathType.Text;

            if(path_type == "Parabolic")
            {
                LinkedList<WayPoints> wplist = new LinkedList<WayPoints>();
                int gimblemode = 0;
                double gimblepitch = 0 ;
                double curvesize = 0;
                double rotdir = 0;

                // Parabolic Path - lon = lat * lat

                double xval = -size / 2;
                double xinc = size / numpnt;
                double yval, angle, distance;
                double new_lat, new_lon, scale_x, scale_y, rot_lat, rot_lon;
                Models.Action action = _wpg.GetAction("No Action");
                int no_action_id = action.internal_id;

                for (int i=0;i <= numpnt; i++)
                {
                    // Calculate lat & lon

                    yval = (xval * xval );
                    distance = Math.Sqrt((xval * xval) + (yval*yval));
                    angle = GPS.RadiansToDegrees(Math.Atan(yval / xval));
                    scale_x = xval * scalex;
                    scale_y = yval / scaley;
                    new_lat = _lat + (scale_y / lat_degree);
                    new_lon = _lon + (scale_x / lon_degree);

                    // Rotate Points

                    bearing = GPS.GPS_Bearing(_lat, _lon, new_lat, new_lon);
                    dist = GPS.GPS_Distance(_lat, _lon, new_lat, new_lon, gps_radius);
                    angle = Convert.ToDouble(trkAngle.Value);
                    rot_lat = GPS.GPS_Lat_BearDist(_lat, _lon, bearing + angle, dist, gps_radius);
                    rot_lon = GPS.GPS_Lon_BearDist(_lat, _lon, rot_lat, bearing + angle, dist, gps_radius);

                    rtbMathPath.AppendText("Lat/Lon : " + Convert.ToString(rot_lat) + ", " + Convert.ToString(rot_lon) + "\n");
                    _wp.Add_Waypoint_List(_wpg, wplist, rot_lat, rot_lon, altitude, 0.0, curvesize, rotdir, gimblemode, gimblepitch, no_action_id);
                    xval = xval + xinc;
                }

                // Save Path

                if (_new_path & _first_pass)
                {
                    string path_name = txtPathName.Text;
                    if (path_name == "") path_name = "Untitled - Parabolic";
                    _path.Add_Path(_wpg, _gmap, path_name, "Mathamatical", wplist);
                    _path = _wpg.PathAt(_wpg.PathCount() - 1);
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
                    //_wpg.ChangePathWP(_path, new_list);
                    //Models.Path path = _wpg.PathAt(_current_path_index);
                    //_gmap.Delete_gMapPath(path);
                    
                }
                _path.visible = true;
                _path.selected = false;
                //_gmap.BuildgMap();
                _gmap.ReDrawgMap();
            }

        }

        private void trkAlt1_Scroll(object sender, EventArgs e)
        {
            lbltrkAlt1.Text = "Altitude : " + Convert.ToString(trkAlt1.Value);
            buildPath();
        }

        private void trkSize_Scroll(object sender, EventArgs e)
        {
            lbltrkSize.Text = "Size : " + Convert.ToString(trkSize.Value);
            buildPath();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            MathGUI gui = new MathGUI();
            gui.name = txtPathName.Text;
            gui.path_type = "Parabolic";
            gui.size = trkSize.Value;
            gui.angle = trkAngle.Value;
            gui.altitude = trkAlt1.Value;
            gui.numpnts = trkNumPoints.Value;
            gui.scalex = trkScaleX.Value;
            gui.scaley = trkScaleY.Value;
            gui.lat = _lat;
            gui.lon = _lon;
            _path.mathgui = gui;
            _path.selected = false;
            _path.visible = true;
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void lbltrkSize_Click(object sender, EventArgs e)
        {

        }

        private void trkScaleX_Scroll(object sender, EventArgs e)
        {
            txtScaleX.Text = Convert.ToString(trkScaleX.Value);
            buildPath();
        }

        private void trkScaleY_Scroll(object sender, EventArgs e)
        {
            txtScaleY.Text = Convert.ToString(trkScaleY.Value);
            buildPath();
        }
    }
}
