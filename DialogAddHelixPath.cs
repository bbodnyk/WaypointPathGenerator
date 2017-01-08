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
    public partial class DialogAddHelixPath : Form
    {

        private double _lat;
        private double _lon;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private WayPoints _wp;
        private Path _path;
        private int _current_path_index = -1;
        private bool _redefine = false;
        private bool _build;

        public DialogAddHelixPath(Waypoint_Path_Gen wpg, GMAP gmap, Path path, double lat, double lon)
        {
            _wp = new WayPoints();
            _wpg = wpg;
            _gmap = gmap;
            _lat = lat;
            _lon = lon;

            InitializeComponent();

            if (path == null)
            {
                _redefine = false;
                _path = new Path();
                _path.visible = true;
                _current_path_index = -1;
                _build = true;
            }
            else
            {
                _build = false;
                _redefine = true;
                _path = path;
                _current_path_index = _wpg.PathIndex(path);
                HelicalGUI gui = _path.helixgui;
                txtAddHelixPathName.Text = gui.name;
                _lat = gui.lat;
                _lon = gui.lon;
                txtHelixStartAlt.Text = Convert.ToString(gui.start_alt);
                txtHelixEndAlt.Text = Convert.ToString(gui.end_alt);
                txtHelixStartRadius.Text = Convert.ToString(gui.start_rad);
                txtHelixEndRadius.Text = Convert.ToString(gui.end_rad);
                txtHelixStartAngle.Text = Convert.ToString(gui.start_angle);
                txtHelixSpan.Text = Convert.ToString(gui.helix_span);
                txtHelixNumPoints.Text = Convert.ToString(gui.num_points);
                chkHelicalHome.Checked = gui.startend;
                chkHelixPOI.Checked = gui.poimode;
                cmbHelixPOI.SelectedText = gui.poiname;
                _build = true;
                _path.selected = false;
            }

            buildHelicalPath();

            _gmap.ReDrawgMap();
            //_current_path_index = _wpg.PathCount() - 1;
            cmbHelixPOI.Items.Clear();
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                cmbHelixPOI.Items.Add(_wpg.POIPointAt(i).name);
            }
        }

        private void bnCancelAddCircPath_Click(object sender, EventArgs e)
        {
            if (_current_path_index != -1 & !_redefine) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void trkStartAlt_Scroll(object sender, EventArgs e)
        {
            txtHelixStartAlt.Text = Convert.ToString(trkStartAlt.Value);
        }

        private void trkEndRad_Scroll(object sender, EventArgs e)
        {
            txtHelixEndRadius.Text = Convert.ToString(trkEndRad.Value);
        }

        private void trkEndAlt_Scroll(object sender, EventArgs e)
        {
            txtHelixEndAlt.Text = Convert.ToString(trkEndAlt.Value);
        }

        private void trkStartRad_Scroll(object sender, EventArgs e)
        {
            txtHelixStartRadius.Text = Convert.ToString(trkStartRad.Value);
        }

        private void trkStartAngle_Scroll(object sender, EventArgs e)
        {
            txtHelixStartAngle.Text = Convert.ToString(trkStartAngle.Value);
        }

        private void trkEndAngle_Scroll(object sender, EventArgs e)
        {
            txtHelixSpan.Text = Convert.ToString(trkHelixSpan.Value);
        }

        private void trkNumPoints_Scroll(object sender, EventArgs e)
        {
            txtHelixNumPoints.Text = Convert.ToString(trkNumPoints.Value);
        }

        private void buildHelicalPath()
        {
            if (!_build) return;

            bool startend = chkHelicalHome.Checked;
            double lat_home = _lat;
            double lon_home = _lon;
            double lat_center = _lat;
            double lon_center = _lon;
            double helix_start_alt = Convert.ToDouble(txtHelixStartAlt.Text);
            double helix_end_alt = Convert.ToDouble(txtHelixEndAlt.Text);
            double helix_start_radius = Convert.ToDouble(txtHelixStartRadius.Text);
            double helix_end_radius = Convert.ToDouble(txtHelixEndRadius.Text);
            double helix_start_angle = Convert.ToDouble(txtHelixStartAngle.Text);
            double helix_span = Convert.ToDouble(txtHelixSpan.Text);
            int helix_num_points = Convert.ToInt16(txtHelixNumPoints.Text);
            int[,] no_actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };
            int[,] actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };

            double cw = 1.0;
            if (radioCCW.Checked) cw = -1.0;

            double lat_camera = lat_center;
            double lon_camera = lon_center;
            String cam_poi_name = cmbHelixPOI.GetItemText(cmbHelixPOI.SelectedItem);

            for (int i = 0; i < _wpg.POICount(); i++)
            {
                POIPoints tmp_point = _wpg.POIPointAt(i);
                string name = tmp_point.name;
                if (cam_poi_name == name)
                {
                    lat_camera = tmp_point.lat;
                    lon_camera = tmp_point.lon;
                }
            }

            LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();
            int count = 0;
            double angle = helix_start_angle;
            double angle_increment = cw * helix_span / helix_num_points;
            double circ_lat;
            double circ_lon;
            //if (chkFullCircle.Checked) angle_increment = 360.0 / helix_num_points;
            //if (radioCCW.Checked) angle_increment = -angle_increment;
            double alt_diff = helix_end_alt - helix_start_alt;
            int alt_dir;
            if (helix_start_alt > helix_end_alt) alt_dir = -1; else alt_dir = 1;
            double alt_increment = (helix_end_alt - helix_start_alt) / helix_num_points;
            double radius_increment = (helix_end_radius - helix_start_radius) / helix_num_points;
            double helix_radius;
            double helix_altitude;
            int gimblemode = 0;
            double gimplepitch = 0;
            double distance;
            double curvesize = 0;
            double rotdir = 0;
            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, lat_home, lon_home, helix_start_alt, 0.0, curvesize, rotdir, gimblemode, gimplepitch, no_actions);
            }
            do
            {

                double heading = GPS.Mod_Angle(angle + 180.0);
                helix_radius = helix_start_radius + (count * radius_increment);
                helix_altitude = helix_start_alt + (count * alt_increment);
                //norm_angle = 180.0*(angle / (helix_end_angle - helix_start_angle));
                //helix_altitude = helix_start_alt + (alt_diff * alt_dir * (1+Math.Cos(DegreesToRadians(norm_angle)))/2);
                circ_lat = GPS.GPS_Lat_BearDist(lat_center, lon_center, angle, helix_radius, Form1.Globals.gps_radius);
                circ_lon = GPS.GPS_Lon_BearDist(lat_center, lon_center, circ_lat, angle, helix_radius, Form1.Globals.gps_radius);

                if (chkHelixPOI.Checked)
                {
                    heading = GPS.GPS_Bearing(circ_lat, circ_lon, lat_camera, lon_camera);
                    distance = GPS.GPS_Distance(circ_lat, circ_lon, lat_camera, lon_camera, Form1.Globals.gps_radius);
                    gimplepitch = -GPS.RadiansToDegrees(Math.Atan(helix_altitude / distance));
                    gimblemode = 2;
                }
                else {
                    heading = GPS.Mod_Angle(angle + 90);
                    if (radioCCW.Checked) heading = GPS.Mod_Angle(heading + 180.0);
                }

                _wp.Add_Waypoint_List(new_list, circ_lat, circ_lon, helix_altitude, heading, curvesize, rotdir, gimblemode, gimplepitch, actions);

                angle = angle + angle_increment;
                count++;

            } while (count <= helix_num_points);

            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, lat_home, lon_home, helix_start_alt, 0.0, curvesize, rotdir, gimblemode, gimplepitch, no_actions);
            }

            // Save Path

            if (_current_path_index == -1)
            {
                string path_name = txtAddHelixPathName.Text;
                if (path_name == "") path_name = "Untitled - Helical";
                _path.Add_Path(_wpg, _gmap, path_name, "Helical", new_list);
                _current_path_index = _wpg.PathCount() - 1;
                Models.Path newpath = _wpg.PathAt(_current_path_index);
                newpath.visible = true;
                newpath.selected = false;
            } else
            {
                _wpg.ChangePathWP(_current_path_index, new_list);
                Models.Path path = _wpg.PathAt(_current_path_index);
                _gmap.Delete_gMapPath(path);
                _gmap.Add_gMapPath(path, false);
            }

            /*
            if (_current_path_index != -1)
            {
                _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            }
            string path_name = txtAddHelixPathName.Text;
            if (path_name == "") path_name = "Untitled - Helical";
            _path.Add_Path(_wpg, _gmap, path_name, "Helical", new_list);
            int index = _wpg.PathCount() - 1;
            _current_path_index = index;
            Models.Path path = _wpg.PathAt(index);
            _path = path;
            string exist_type = path.type;
            bool exist_select = path.selected;
            bool exist_visible = path.visible;
            if (exist_type == "Helical")
            {
                _wpg.ChangePathWP(index, new_list);
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
                newpath.waypoints = new_list;
                _gmap.Add_gMapPath(path, false);
            }
            */

            _gmap.ReDrawgMap();
            //_wpg.ChangePathWP(index, new_list);
            //cmbCircReuse.ResetText();

            
            
        }

        private void btnAddHelixPath_Click(object sender, EventArgs e)
        {
            Models.Path path = _wpg.PathAt(_current_path_index);
            //_gmap.Delete_gMapPath(path);
            //_gmap.Add_gMapPath(path, false);
            HelicalGUI gui = new HelicalGUI();
            gui.CW = radioCW.Checked;
            gui.name = txtAddHelixPathName.Text;
            gui.lat = _lat;
            gui.lon = _lon;
            gui.start_alt = Convert.ToDouble(txtHelixStartAlt.Text);
            gui.end_alt = Convert.ToDouble(txtHelixEndAlt.Text);
            gui.start_rad = Convert.ToDouble(txtHelixStartRadius.Text);
            gui.end_rad = Convert.ToDouble(txtHelixEndRadius.Text);
            gui.start_angle = Convert.ToDouble(txtHelixStartAngle.Text);
            gui.helix_span = Convert.ToDouble(txtHelixSpan.Text);
            gui.num_points = Convert.ToInt16(txtHelixNumPoints.Text);
            gui.startend = chkHelicalHome.Checked;
            gui.poimode = chkHelixPOI.Checked;
            gui.poiname = cmbHelixPOI.GetItemText(cmbHelixPOI.SelectedItem);
            path.helixgui = gui;
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void txtHelixStartAlt_TextChanged(object sender, EventArgs e)
        {
            trkStartAlt.Value = Convert.ToInt16(txtHelixStartAlt.Text);
            buildHelicalPath();
        }

        private void txtHelixEndAlt_TextChanged(object sender, EventArgs e)
        {
            trkEndAlt.Value = Convert.ToInt16(txtHelixEndAlt.Text);
            buildHelicalPath();
        }

        private void txtHelixStartRadius_TextChanged(object sender, EventArgs e)
        {
            trkStartRad.Value = Convert.ToInt16(txtHelixStartRadius.Text);
            buildHelicalPath();
        }

        private void txtHelixEndRadius_TextChanged(object sender, EventArgs e)
        {
            trkEndRad.Value = Convert.ToInt16(txtHelixEndRadius.Text);
            buildHelicalPath();
        }

        private void txtHelixStartAngle_TextChanged(object sender, EventArgs e)
        {
            trkStartAngle.Value = Convert.ToInt16(txtHelixStartAngle.Text);
            buildHelicalPath();
        }

        private void txtHelixEndAngle_TextChanged(object sender, EventArgs e)
        {
            trkHelixSpan.Value = Convert.ToInt16(txtHelixSpan.Text);
            buildHelicalPath();
        }

        private void txtHelixNumPoints_TextChanged(object sender, EventArgs e)
        {
            trkNumPoints.Value = Convert.ToInt16(txtHelixNumPoints.Text);
            buildHelicalPath();
        }

        private void chkHelicalHome_CheckedChanged(object sender, EventArgs e)
        {
            buildHelicalPath();
        }

        private void chkHelixPOI_CheckedChanged(object sender, EventArgs e)
        {
            buildHelicalPath();
        }

        private void txtAddHelixPathName_TextChanged(object sender, EventArgs e)
        {
            buildHelicalPath();
        }

        private void radioCW_CheckedChanged(object sender, EventArgs e)
        {
            buildHelicalPath();
        }

        private void DialogAddHelixPath_Load(object sender, EventArgs e)
        {

        }
    }
}

