using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator
{
    public partial class dialogAddCircularPath : Form
    {
        private double _lat;
        private double _lon;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private Options _options;
        private WayPoints _wp;
        private Path _path;
        //private int _current_path_index;
        private bool _first_pass;
        private bool _new_path;
        private bool _build = true;

        public dialogAddCircularPath(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path, double lat, double lon)
        {
            // Save arguments
            _wp = new WayPoints();          
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _lat = lat;
            _lon = lon;

            // Initialize Dialog

            InitializeComponent();

            // Setup Dialog GUI

            txtDiaAddCircPathAlt.Text = Convert.ToString(_options.def_altitude);
            cmbCircPOI.Items.Clear();
            cmbCircPOI.Items.Add("");
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                cmbCircPOI.Items.Add(_wpg.POIPointAt(i).name);
            }

            // See if new path

            if (path == null)
            {
                _new_path = true;
                _first_pass = true;
                _path = new Path();
                //_current_path_index = -1;
                _path.visible = true;
                _path.selected = false;
                double altitude = Convert.ToDouble(txtDiaAddCircPathAlt.Text);
                double circle_radius = Convert.ToDouble(txtDiaAddCircPathRadius.Text);
                double start_angle = Convert.ToDouble(txtCircStartAngle.Text);
                double circle_span = Convert.ToDouble(txtCircSpan.Text);
                int circle_num_points = Convert.ToInt16(txtCircNumPoints.Text);
                bool startend = chkCircHome.Checked;
                CircularGUI gui = new CircularGUI();
                gui.CW = startend;
                gui.name = txtDiaAddCircPathName.Text;
                gui.lat = _lat;
                gui.lon = _lon;
                gui.altitude = altitude;
                gui.radius = circle_radius;
                gui.numpoints = circle_num_points;
                gui.fullcirc = chkFullCircle.Checked;
                gui.start_angle = start_angle;
                gui.circ_span = circle_span;
                gui.startend = startend;
                gui.poimode = chkCircPOI.Checked;
                gui.poiname = cmbCircPOI.GetItemText(cmbCircPOI.SelectedItem);
                _path.circgui = gui;
            }
            else
            {
                _build = false;
                _new_path = false;
                _path = path;
                _path.selected = false;
                _path.visible = true;
                //_current_path_index = _path.id;
                CircularGUI gui = _path.circgui;
                txtDiaAddCircPathName.Text = gui.name;
                _lat = gui.lat;
                _lon = gui.lon;
                txtDiaAddCircPathAlt.Text = Convert.ToString(gui.altitude);
                txtDiaAddCircPathRadius.Text = Convert.ToString(gui.radius);                
                txtCircNumPoints.Text = Convert.ToString(gui.numpoints);
                chkFullCircle.Checked = gui.fullcirc;
                txtCircStartAngle.Text = Convert.ToString(gui.start_angle);
                txtCircSpan.Text = Convert.ToString(gui.circ_span);
                chkCircHome.Checked = gui.startend;
                chkCircPOI.Checked = gui.poimode;
                int index = cmbCircPOI.Items.IndexOf(gui.poiname);
                cmbCircPOI.SelectedIndex = index;
                _first_pass = false;
                _build = true;
            }
            buildCircPath();
        }

        private void bnCancelAddCircPath_Click(object sender, EventArgs e)
        {
            if (_new_path) _wpg.DeletePath(_path);
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void btnAddCircPath_Click(object sender, EventArgs e)
        {
            double altitude = Convert.ToDouble(txtDiaAddCircPathAlt.Text);
            double circle_radius = Convert.ToDouble(txtDiaAddCircPathRadius.Text);
            double start_angle = Convert.ToDouble(txtCircStartAngle.Text);
            double circle_span = Convert.ToDouble(txtCircSpan.Text);
            int circle_num_points = Convert.ToInt16(txtCircNumPoints.Text);
            bool startend = chkCircHome.Checked;
            CircularGUI gui = new CircularGUI();
            gui.CW = startend;
            gui.name = txtDiaAddCircPathName.Text;
            gui.lat = _lat;
            gui.lon = _lon;
            gui.altitude = altitude;
            gui.radius = circle_radius;
            gui.numpoints = circle_num_points;
            gui.fullcirc = chkFullCircle.Checked;
            gui.start_angle = start_angle;
            gui.circ_span = circle_span;
            gui.startend = startend;
            gui.poimode = chkCircPOI.Checked;
            gui.poiname = cmbCircPOI.GetItemText(cmbCircPOI.SelectedItem);
            _path.circgui = gui;
            _path.selected = false;
            _path.visible = true;
            _gmap.ReDrawgMap();
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        

        private void buildCircPath()
        {
            if (!_build) return;

            // Get Parameters

            double lat_home = _lat;
            double lon_home = _lon;
            double lat_center = _lat;
            double lon_center = _lon;
            double altitude = Convert.ToDouble(txtDiaAddCircPathAlt.Text);
            double circle_radius = Convert.ToDouble(txtDiaAddCircPathRadius.Text);
            double start_angle = Convert.ToDouble(txtCircStartAngle.Text);
            double circle_span = Convert.ToDouble(txtCircSpan.Text);
            int circle_num_points = Convert.ToInt16(txtCircNumPoints.Text);
            bool startend = chkCircHome.Checked;
            int[,] no_actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };
            int[,] actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };

            // Get Camera Location

            double lat_camera = lat_center;
            double lon_camera = lon_center;
            String cam_poi_name = cmbCircPOI.GetItemText(cmbCircPOI.SelectedItem);

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

            // Generate Full 360 degree circle

            LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();
            int gimblemode = 0;
            double gimplepitch = -GPS.RadiansToDegrees(Math.Atan(altitude / circle_radius));
            double curvesize = 0;
            double rotdir = 0;

            if (startend)
            {

                _wp.Add_Waypoint_List(new_list, lat_home, lon_home, altitude, 0.0, curvesize, rotdir, 0, 0.0, no_actions);

            }
            int count = 0;
            double heading = 0;
            double distance;
            double angle = start_angle;
            double angle_increment = circle_span / (circle_num_points);
            bool full_circle = chkFullCircle.Checked;
            if (circle_span == 360.0) full_circle = true;
            double circ_lat;
            double circ_lon;
            double start_lat = 0;
            double start_lon = 0;
            double start_head = 0;
            
            if (full_circle) angle_increment = 360.0 / circle_num_points;
            if (radioCCW.Checked) angle_increment = -angle_increment;
            int num_points = circle_num_points;
            if (!full_circle) num_points++;
            do
            {
                circ_lat = GPS.GPS_Lat_BearDist(lat_center, lon_center, angle, circle_radius, Form1.Globals.gps_radius);
                circ_lon = GPS.GPS_Lon_BearDist(lat_center, lon_center, circ_lat, angle, circle_radius, Form1.Globals.gps_radius);

                if (chkCircPOI.Checked)
                {
                    heading = GPS.GPS_Bearing(circ_lat, circ_lon, lat_camera, lon_camera);
                    distance = GPS.GPS_Distance(circ_lat, circ_lon, lat_camera, lon_camera, Form1.Globals.gps_radius);
                    gimplepitch = -GPS.RadiansToDegrees(Math.Atan(altitude / distance));
                    gimblemode = 2;
                }
                else {
                    heading = GPS.Mod_Angle(angle + 90);
                    if (radioCCW.Checked) heading = GPS.Mod_Angle(heading + 180.0);
                    gimplepitch = 0;
                    gimblemode = 0;
                }

                if (count == 0) { start_lat = circ_lat; start_lon = circ_lon; start_head = heading; }

                _wp.Add_Waypoint_List(new_list, circ_lat, circ_lon, altitude, heading, curvesize, rotdir, gimblemode, gimplepitch, actions);

                angle = angle + angle_increment;
                count++;

            } while (count < num_points );

            if (full_circle) _wp.Add_Waypoint_List(new_list, start_lat, start_lon, altitude, start_head, curvesize, rotdir, gimblemode, gimplepitch, actions); ;

            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, lat_home, lon_home, altitude, 0.0, curvesize, rotdir, gimblemode, 0.0, no_actions);
            }

            // Save Path

            if (_new_path & _first_pass)
            {
                string path_name = txtDiaAddCircPathName.Text;
                if (path_name == "") path_name = "Untitled - Circular";
                _path.Add_Path(_wpg, _gmap, path_name, "Circular", new_list);
                _path = _wpg.PathAt(_wpg.PathCount() - 1);
                _first_pass = false;
                //Models.Path newpath = _wpg.PathAt(_current_path_index);
                //newpath.visible = true;
                //newpath.selected = true;
            }
            else
            {
                _path.waypoints = new_list;
                //_wpg.ChangePathWP(_path, new_list);
                //Models.Path path = _wpg.PathAt(_current_path_index);
                //_gmap.Delete_gMapPath(path);
                //_gmap.Add_gMapPath(path, false);
            }
            _path.visible = true;
            _path.selected = false;
            //_gmap.BuildgMap();
            _gmap.ReDrawgMap();
        }


        private void chkCircPOI_CheckedChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void cmbCircPOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void txtDiaAddCircPathAlt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                double value = Convert.ToInt16(txtDiaAddCircPathAlt.Text);
                if (value < trkAlt.Minimum)
                {
                    txtDiaAddCircPathAlt.Text = Convert.ToString(trkAlt.Minimum);
                }
                if (value > trkAlt.Maximum)
                {
                    txtDiaAddCircPathAlt.Text = Convert.ToString(trkAlt.Maximum);
                }
                value = Convert.ToInt16(txtDiaAddCircPathRadius.Text);
                trkAlt.Value = Convert.ToInt16(value);
                buildCircPath();
            }
        }

        private void txtDiaAddCircPathAlt_TextChanged(object sender, EventArgs e)
        {
            //trkAlt.Value = Convert.ToInt16(txtDiaAddCircPathAlt.Text);
            //buildCircPath();
        }

        private void txtDiaAddCircPathName_TextChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void txtDiaAddCircPathRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                double value = Convert.ToInt16(txtDiaAddCircPathRadius.Text);
                if (value < trkRadius.Minimum)
                {
                    txtDiaAddCircPathRadius.Text = Convert.ToString(trkRadius.Minimum);
                }
                if (value > trkRadius.Maximum)
                {
                    txtDiaAddCircPathRadius.Text = Convert.ToString(trkRadius.Maximum);
                }
                value = Convert.ToInt16(txtDiaAddCircPathRadius.Text);
                trkRadius.Value = Convert.ToInt16(value);
                buildCircPath();
            }
        }

        private void txtDiaAddCircPathRadius_TextChanged(object sender, EventArgs e)
        {
            //trkRadius.Value = Convert.ToInt16(txtDiaAddCircPathRadius.Text);
            //buildCircPath();
        }

        private void txtCircNumPoints_TextChanged(object sender, EventArgs e)
        {
            trkNumPoints.Value = Convert.ToInt16(txtCircNumPoints.Text);
            buildCircPath();
        }

        private void txtCircStartAngle_TextChanged(object sender, EventArgs e)
        {
            trkstartangle.Value = Convert.ToInt16(txtCircStartAngle.Text);
            buildCircPath();
        }

        private void txtCircEndAngle_TextChanged(object sender, EventArgs e)
        {
            trkendangle.Value = Convert.ToInt16(txtCircSpan.Text);
            buildCircPath();
        }

        private void chkFullCircle_CheckedChanged(object sender, EventArgs e)
        {
            txtCircSpan.Text = "360";
            buildCircPath();
        }

        private void radioCW_CheckedChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void dialogAddCircularPath_FormClosed(object sender, FormClosedEventArgs e)
        {
      
        }

        private void chkCircHome_CheckedChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void trkRadius_Scroll(object sender, EventArgs e)
        {
            txtDiaAddCircPathRadius.Text = Convert.ToString(trkRadius.Value);
            buildCircPath();
        }

        private void trkNumPoints_Scroll(object sender, EventArgs e)
        {
            txtCircNumPoints.Text = Convert.ToString(trkNumPoints.Value);
        }

        private void trkstartangle_Scroll(object sender, EventArgs e)
        {
            txtCircStartAngle.Text = Convert.ToString(trkstartangle.Value);
        }

        private void trkendangle_Scroll(object sender, EventArgs e)
        {
            txtCircSpan.Text = Convert.ToString(trkendangle.Value);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtDiaAddCircPathAlt.Text = Convert.ToString(trkAlt.Value);
            buildCircPath();
        }

        private void dialogAddCircularPath_Load(object sender, EventArgs e)
        {

        }

        
    }
}

