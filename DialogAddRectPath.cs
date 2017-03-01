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
    public partial class DialogAddRectPath : Form
    {
        private double _lat;
        private double _lon;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private WayPoints _wp;
        private Path _path;
        private Options _options;
        private Shape _poly;
        private int _current_intid;
        private double _camera_angle_hor;
        private double _camera_angle_ver;
        private double _camera_width;
        private double _camera_height;
        private double _overlap_width;
        private double _overlap_height;
        private bool _video;
        private bool _new_path;
        private bool _first_pass;
        private bool _build;


        public DialogAddRectPath(Waypoint_Path_Gen wpg, GMAP gmap,  Options options, Path path, double lat, double lon)
        {
            _wp = new WayPoints();
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _lat = lat;
            _lon = lon;
            _camera_angle_hor = _options.focal_angle_hor;
            _camera_angle_ver = _options.focal_angle_ver;
            //_overlap_width = over_wid;
            //_overlap_height = over_hgt;
            _overlap_width = _options.hor_overlap_percent;
            _overlap_height = _options.ver_overlap_percent;
            _poly = new Shape();

            InitializeComponent();

            // Fill POI combobox
            cmbRectCamPOI.Items.Clear();
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                cmbRectCamPOI.Items.Add(_wpg.POIPointAt(i).name);
            }

            // New or Redefine Path

            if ( path == null )
            {
                _new_path = true;
                _first_pass = true;
                _path = new Path();
                _path.visible = true;
                _path.selected = false;
                _build = true;
                txtPathAlt.Text = Convert.ToString(_options.def_altitude);
                trkRectAlt.Value = Convert.ToInt16(_options.def_altitude);
            } else
            {
                _new_path = false;
                _path = path;
                _path.selected = false;
                _current_intid = path.internal_id;
                RectanglarGUI gui = _path.rectanglegui;
                _build = false;
                _lat = gui.lat;
                _lon = gui.lon;
                txtRectPathName.Text = gui.name;
                radioVideo.Checked = Convert.ToBoolean(gui.video);
                radioPhoto.Checked = !Convert.ToBoolean(gui.video);
                chkRectHome.Checked = Convert.ToBoolean(gui.startend);
                txtPathAlt.Text = Convert.ToString(gui.altitude);
                txtGridRotation.Text = Convert.ToString(gui.heading);
                txtGridLength.Text = Convert.ToString(gui.length);
                txtGridWidth.Text = Convert.ToString(gui.width);
                chkOnePass.Checked = Convert.ToBoolean(gui.single);
                chkRectCamPOI.Checked = Convert.ToBoolean(gui.poimode);
                int index = cmbRectCamPOI.Items.IndexOf(gui.poiname);
                cmbRectCamPOI.SelectedIndex = index;
                _build = true;
            }
            _build = true;
            BuildRectPath();
        }

        private void DialogAddRectPath_Load(object sender, EventArgs e)
        {

        }

        private void chkRectHome_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void txtGridLength_TextChanged(object sender, EventArgs e)
        {
            trkRectLength.Value = Convert.ToInt16(txtGridLength.Text);
            BuildRectPath();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkOnePass_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void lblGridWidth_Click(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void lblGridLength_Click(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void txtGridWidth_TextChanged(object sender, EventArgs e)
        {
            trkRectWidth.Value = Convert.ToInt16(txtGridWidth.Text);
            BuildRectPath();
        }

        private void txtGridRotation_TextChanged(object sender, EventArgs e)
        {
            trkRectHeading.Value = Convert.ToInt16(txtGridRotation.Text);
            BuildRectPath();
        }

        private void trkRectHeading_Scroll(object sender, EventArgs e)
        {
            txtGridRotation.Text = Convert.ToString(trkRectHeading.Value);
        }

        private void trkRectLength_Scroll(object sender, EventArgs e)
        {
            txtGridLength.Text = Convert.ToString(trkRectLength.Value);
        }

        private void trkRectWidth_Scroll(object sender, EventArgs e)
        {
            txtGridWidth.Text = Convert.ToString(trkRectWidth.Value);
        }
        
        private void btnCancelAddRectPath_Click(object sender, EventArgs e)
        {
            //if (_current_path_index != -1) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void BuildRectPath()
        {

            if (!_build) return;

            // Get center position

            double lat_home = _lat;
            double lon_home = _lon;
            double lat_center = _lat;
            double lon_center = _lon;
            string path_name = txtRectPathName.Text;

/*
            int poi_count = _wpg.POICount();
            POIPoints tmp_point;
            for (int i = 0; i < poi_count; i++)
            {
                tmp_point = _wpg.POIPointAt(i);
                string name = tmp_point.name;
                if (home_name == name)
                {

                    lat_home = tmp_point.lat;
                    lon_home = tmp_point.lon;
                }
            }
*/
            double lat_camera;
            double lon_camera;

            LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();

            // Get Values from input Boxes

            _video = radioVideo.Checked;
            bool OnePass = chkOnePass.Checked;
            bool startend = chkRectHome.Checked;
            bool camerapoi = chkRectCamPOI.Checked;
            int poi_count;

            if (camerapoi)
            {
                string poi_name = cmbRectCamPOI.GetItemText(cmbRectCamPOI.SelectedItem);
                poi_count = _wpg.POICount();

                for (int i = 0; i < poi_count; i++)
                {
                    POIPoints tmp_point = _wpg.POIPointAt(i);
                    string name = tmp_point.name;
                    if (poi_name == name)
                    {

                        lat_camera = tmp_point.lat;
                        lon_camera = tmp_point.lon;
                    }
                }
            }

            double box_width = Convert.ToDouble(txtGridLength.Text);
            double box_height = Convert.ToDouble(txtGridWidth.Text);
            double altitude = Convert.ToDouble(txtPathAlt.Text);
            _camera_width = (2 * (Math.Tan(GPS.DegreesToRadians(_camera_angle_hor / 2)) * altitude));
            _camera_height = (2 * (Math.Tan(GPS.DegreesToRadians(_camera_angle_ver / 2)) * altitude));

            if (!Form1.Globals.UnitsMetric)
            {
                box_width = FeetToMeters(box_width);
                box_height = FeetToMeters(box_height);
                _camera_width = FeetToMeters(_camera_width);
                _camera_height = FeetToMeters(_camera_height);
            }
            //double box_rotate = Convert.ToDouble(txtGridRotation.Text);
            double box_rotate = Convert.ToDouble(txtGridRotation.Text) - 90.0;
            //double box_rotate = 0.0;

            double hor_overlap = _overlap_width / 100;
            double ver_overlap = _overlap_height / 100;
            
            

            double gps_radius = Form1.Globals.gps_radius;
            Models.Action action = _wpg.GetAction("No Actions");
            int video_actions = action.internal_id;
            int no_actions = action.internal_id;
            action = _wpg.GetAction("Pause/Take Picture");
            int photo_actions = action.internal_id;
             
            /* Start Calculating */


            double diagonal_length = Math.Sqrt((box_width / 2) * (box_width / 2) + (box_height / 2) * (box_height / 2));
            double diagonal_angle = GPS.RadiansToDegrees(Math.Atan((box_width / 2) / (box_height / 2)));

            


            /* Calculate Top, Bottom, Left & Right Center Positions */

            double lat_top;
            double lon_top;
            double lat_bottom;
            double lon_bottom;
            double lat_left;
            double lon_left;
            double lat_right;
            double lon_right;

            lat_top = GPS.GPS_Lat_BearDist(lat_center, lon_center, 0, box_height / 2, gps_radius);
            lon_top = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, 0, box_height / 2, gps_radius);

            lat_bottom = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180, box_height / 2, gps_radius);
            lon_bottom = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_bottom, 180, box_height / 2, gps_radius);

            lat_left = GPS.GPS_Lat_BearDist(lat_center, lon_center, 270, box_width / 2, gps_radius);
            lon_left = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_left, 270, box_width / 2, gps_radius);

            lat_right = GPS.GPS_Lat_BearDist(lat_center, lon_center, 90, box_width / 2, gps_radius);
            lon_right = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_right, 90, box_width / 2, gps_radius);

            /* Calculate 4 corner locations */

            double lat_top_left;
            double lon_top_left;
            double lat_bottom_left;
            double lon_bottom_left;
            double lat_top_right;
            double lon_top_right;
            double lat_bottom_right;
            double lon_bottom_right;
            double[,] polypnt = new double[4,2];

            lat_top_left = GPS.GPS_Lat_BearDist(lat_center, lon_center, -diagonal_angle, diagonal_length, gps_radius);
            lon_top_left = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, -diagonal_angle, diagonal_length, gps_radius);
            polypnt[0,0] = lat_top_left;
            polypnt[0,1] = lon_top_left;

            lat_top_right = GPS.GPS_Lat_BearDist(lat_center, lon_center, diagonal_angle, diagonal_length, gps_radius);
            lon_top_right = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, diagonal_angle, diagonal_length, gps_radius);
            polypnt[1, 0] = lat_top_right;
            polypnt[1, 1] = lon_top_right;

            lat_bottom_right = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180 - diagonal_angle, diagonal_length, gps_radius);
            lon_bottom_right = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, 180 - diagonal_angle, diagonal_length, gps_radius);
            polypnt[2, 0] = lat_bottom_right;
            polypnt[2, 1] = lon_bottom_right;

            lat_bottom_left = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180 + diagonal_angle, diagonal_length, gps_radius);
            lon_bottom_left = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, 180 + diagonal_angle, diagonal_length, gps_radius);
            polypnt[3, 0] = lat_bottom_left;
            polypnt[3, 1] = lon_bottom_left;

            // Rotate Points

            double new_lat, new_lon;

            
            for (int i = 0; i < 4; i++)
            {

                double rot_bearing = GPS.GPS_Bearing(lat_center, lon_center, polypnt[i,0], polypnt[i,1]);
                double rot_distance = GPS.GPS_Distance(lat_center, lon_center, polypnt[i, 0], polypnt[i, 1], gps_radius);

                // Calculate a new location by increasing the bearing

                new_lat = GPS.GPS_Lat_BearDist(lat_center, lon_center, rot_bearing + box_rotate, rot_distance, gps_radius);
                new_lon = GPS.GPS_Lon_BearDist(lat_center, lon_center, new_lat, rot_bearing + box_rotate, rot_distance, gps_radius);
                polypnt[i, 0] = new_lat;
                polypnt[i, 1] = new_lon;
            }
            
            // Generate Rectangle Polygon

            
            _poly.name = "temp";
            _poly.visible = true;
            LinkedList<PolyPoint> shape_points = new LinkedList< PolyPoint >();
            for(int i = 0; i <= 3; i++)
            {
                PolyPoint newpnt = new PolyPoint();
                newpnt.lat = polypnt[i, 0];
                newpnt.lon = polypnt[i, 1];
                newpnt.alt = 10;
                shape_points.AddLast(newpnt);
            }
            PolyPoint pnt = new PolyPoint();
            pnt.lat = polypnt[0, 0];
            pnt.lon = polypnt[0, 1];
            pnt.alt = 10;
            shape_points.AddLast(pnt);
            _poly.points = shape_points;

            // Get Direction Flags

            double drone_heading = 90.0;
            int ver_dir_flag = 1;
            if (radioUpLeft.Checked) { ver_dir_flag = 1; }
            if (radioUpRight.Checked) { ver_dir_flag = 1; drone_heading = 270; }
            if (radioLowLeft.Checked) { ver_dir_flag = -1; }
            if (radioLowRight.Checked) { ver_dir_flag = -1; drone_heading = 270; }

            // Grid Calculations

            double lat_next;
            double next_lon_start;
            double next_lon_end;
            double lon_tmp;
            double row_increment = _camera_width * (1.0 - hor_overlap);
            int num_rows = Convert.ToInt16(box_height / row_increment);
            box_rotate = 0.0;

            // Create Waypoints

            int gimblemode = 2;
            double gimblepitch = -90.0;
            double curvesize = 0;
            double rotdir = 0;

            if (OnePass | num_rows == 1)
            {

                if (startend)
                {
                    _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                }

                if (radioUpLeft.Checked | radioLowLeft.Checked)
                {
                    _wp.Add_Leg_List(_wpg, new_list, lat_left, lon_left, lat_right, lon_right, 
                        altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                }
                else
                {
                    _wp.Add_Leg_List(_wpg, new_list, lat_right, lon_right, lat_left, lon_left, 
                        altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                }

                if (startend)
                {
                    _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                }
            }
            else
            {

                /* More than one row */

                if (num_rows == 2)
                {
                    double offset = row_increment;
                    double diagonal_length_2 = Math.Sqrt((box_width / 2) * (box_width / 2) + (offset / 2) * (offset / 2));
                    double diagonal_angle_2 = GPS.RadiansToDegrees(Math.Atan((box_width / 2) / (offset / 2)));

                    lat_top_left = GPS.GPS_Lat_BearDist(lat_center, lon_center, -diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);
                    lon_top_left = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, -diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);

                    lat_top_right = GPS.GPS_Lat_BearDist(lat_center, lon_center, diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);
                    lon_top_right = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);

                    lat_bottom_left = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180 + diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);
                    lon_bottom_left = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, 180 + diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);

                    lat_bottom_right = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180 - diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);
                    lon_bottom_right = GPS.GPS_Lon_BearDist(lat_center, lon_center, lat_top, 180 - diagonal_angle_2 + box_rotate, diagonal_length_2, gps_radius);

                    if (startend)
                    {
                        _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                    }
                    if (radioLowLeft.Checked)
                    {
                        _wp.Add_Leg_List(_wpg, new_list, lat_bottom_left, lon_bottom_left, lat_bottom_right, lon_bottom_right, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                        _wp.Add_Leg_List(_wpg, new_list, lat_top_right, lon_top_right, lat_top_left, lon_top_left, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                    }

                    if (radioLowRight.Checked)
                    {
                        _wp.Add_Leg_List(_wpg, new_list, lat_bottom_right, lon_bottom_right, lat_bottom_left, lon_bottom_left, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                        _wp.Add_Leg_List(_wpg, new_list, lat_top_left, lon_top_left, lat_top_right, lon_top_right, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                    }

                    if (radioUpLeft.Checked)
                    {
                        _wp.Add_Leg_List(_wpg, new_list, lat_top_left, lon_top_left, lat_top_right, lon_top_right, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                        _wp.Add_Leg_List(_wpg, new_list, lat_bottom_right, lon_bottom_right, lat_bottom_left, lon_bottom_left, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                    }

                    if (radioUpRight.Checked)
                    {
                        _wp.Add_Leg_List(_wpg, new_list, lat_top_right, lon_top_right, lat_top_left, lon_top_left, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                        _wp.Add_Leg_List(_wpg, new_list, lat_bottom_left, lon_bottom_left, lat_bottom_right, lon_bottom_right, 
                            altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                    }

                    if (startend)
                    {
                        _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                    }
                }
                else {

                    /* More than 2 rows */

                    double row_span = (num_rows - 1) * row_increment;
                    lat_top = GPS.GPS_Lat_BearDist(lat_center, lon_center, 0 + box_rotate, row_span / 2, gps_radius);
                    lat_bottom = GPS.GPS_Lat_BearDist(lat_center, lon_center, 180 + box_rotate, row_span / 2, gps_radius);
                    double degrees_per_foot = (lat_top - lat_bottom) / row_span;

                    if (startend)
                    {
                        _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                    }

                    int row_count = 0;
                    next_lon_start = 0.0;
                    next_lon_end = 0.0;
                    double lat_current = 0.0;

                    do
                    {

                        /* First Row */

                        if (row_count == 0)
                        {
                            if (radioLowLeft.Checked)
                            {
                                _wp.Add_Leg_List(_wpg, new_list, lat_bottom, lon_left, lat_bottom, lon_right, 
                                    altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                                lat_current = lat_bottom;
                                next_lon_start = lon_right;
                                next_lon_end = lon_left;
                            }
                            if (radioLowRight.Checked)
                            {
                                _wp.Add_Leg_List(_wpg, new_list, lat_bottom, lon_right, lat_bottom, lon_left, 
                                    altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                                lat_current = lat_bottom;
                                next_lon_start = lon_left;
                                next_lon_end = lon_right;
                            }
                            if (radioUpLeft.Checked)
                            {
                                _wp.Add_Leg_List(_wpg, new_list, lat_top, lon_left, lat_top, lon_right, 
                                    altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                                lat_current = lat_top;
                                next_lon_start = lon_right;
                                next_lon_end = lon_left;
                            }
                            if (radioUpRight.Checked)
                            {
                                _wp.Add_Leg_List(_wpg, new_list, lat_top, lon_right, lat_top, lon_left, 
                                    altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                                lat_current = lat_top;
                                next_lon_start = lon_left;
                                next_lon_end = lon_right;
                            }

                        }
                        else
                        {
                            /* Output 2nd, 3rd, etc. */

                            //lat_current = Globals.waypoints[Globals.waypoint_count - 1, 0];
                            lat_next = lat_current + (-ver_dir_flag * (degrees_per_foot * row_increment));
                            _wp.Add_Leg_List(_wpg, new_list, lat_next, next_lon_start, lat_next, next_lon_end, 
                                altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, video_actions, photo_actions, _video, _camera_height, _overlap_height);
                            lon_tmp = next_lon_start;
                            next_lon_start = next_lon_end;
                            next_lon_end = lon_tmp;
                            lat_current = lat_next;
                        }
                        row_count++;
                    } while (row_count < num_rows);

                    if (startend)
                    {
                        _wp.Add_Waypoint_List(_wpg, new_list, lat_home, lon_home, altitude, drone_heading, curvesize, rotdir, gimblemode, gimblepitch, -1, no_actions);
                    }
                }
            }


            // Rotate WayPoints about Center
         
            int count = 0;
            double lat, lon, alt, head, bearing, distance;
            double lat_first = lat_center;
            double lon_first = lon_center;
            int action_id;
            LinkedListNode<WayPoints> node = new_list.First;
            //LinkedListNode<WayPoints> next_node = node.Next;
            LinkedListNode<WayPoints> save_node;
            //lat_first = node.Value.lat;
            //lon_first = node.Value.lon;
            //alt_first = node.Value.alt;
            //head_first = node.Value.head;

            while (node != null)
            {
                if (count != 0)
                {

                    // Get Waypoint values

                    lat = node.Value.lat;
                    lon = node.Value.lon;
                    alt = node.Value.alt;
                    head = node.Value.head;
                    gimblemode = node.Value.gimblemode;
                    gimblepitch = node.Value.gimblepitch;
                    curvesize = node.Value.curvesize;
                    rotdir = node.Value.rotationdir;
                    action_id = node.Value.action_id;
                    box_rotate = Convert.ToDouble(txtGridRotation.Text) - 90.0;

                    // Calculate Bearing and distance from first waypoint

                    bearing = GPS.GPS_Bearing(lat_first, lon_first, lat, lon);
                    distance = GPS.GPS_Distance(lat_first, lon_first, lat, lon, gps_radius);

                    // Calculate a new location by increasing the bearing

                    new_lat = GPS.GPS_Lat_BearDist(lat_first, lon_first, bearing + box_rotate, distance, gps_radius);
                    new_lon = GPS.GPS_Lon_BearDist(lat_first, lon_first, new_lat, bearing + box_rotate, distance, gps_radius);

                    // Set new waypoint

                    WayPoints new_wp = new WayPoints();
                    new_wp.lat = new_lat;
                    new_wp.lon = new_lon;
                    new_wp.alt = alt;
                    new_wp.head = head + box_rotate;
                    new_wp.gimblemode = gimblemode;
                    new_wp.gimblepitch = gimblepitch;
                    new_wp.curvesize = curvesize;
                    new_wp.rotationdir = rotdir;
                    new_wp.action_id = action_id;
                    save_node = node;
                    new_list.AddBefore(node, new_wp);
                    node = node.Next;
                    new_list.Remove(save_node);
                }
                count++;
            }

            // Redo start and end points

            if (startend)
            {
                WayPoints wp = new_list.First.Value;
                new_list.RemoveFirst();
                wp.lat = lat_home;
                wp.lon = lon_home;
                new_list.AddFirst(wp);
                wp = new_list.Last.Value;
                new_list.RemoveLast();
                wp.lat = lat_home;
                wp.lon = lon_home;
                new_list.AddLast(wp);
            }

            // Save Path

            if (_new_path & _first_pass)
            {
                path_name = txtRectPathName.Text;
                if (path_name == "") path_name = "Untitled - Rectangular";
                _path.Add_Path(_wpg, _gmap, path_name, "Rectangular", new_list);
                Path newpath = _wpg.PathAt(_wpg.PathCount() - 1);
                _current_intid = newpath.internal_id;
                path_name = "Untitled - Rectangular - " + Convert.ToString(newpath.internal_id);
                newpath.name = path_name;
                _first_pass = false;
            }
            else
            {
                path_name = txtRectPathName.Text;
                if (path_name == "") path_name = "Untitled - Rectangular";
                _wpg.ChangePathWPIntId(_current_intid, new_list);
                _path = _wpg.PathIntId(_current_intid);
                _path.name = path_name;
                //Models.Path path = _wpg.PathAt(_current_path_index);
                //_gmap.Delete_gMapPath(path);
                //_gmap.Add_gMapPath(path, false);
            }

            _gmap.ReDrawgMap();
            _gmap.Add_gMapPoly(_poly, true);

        }

        private double MetersToFeet(double meters)
        {
            double conversion = 3.280839;
            return (meters * conversion);
        }
        private double FeetToMeters(double feet)
        {
            double conversion = 3.280839;
            return (feet / conversion);
        }
        
        private void btnAddRectPath_Click(object sender, EventArgs e)
        {

            Path path = _wpg.PathIntId(_current_intid);
            RectanglarGUI gui = new RectanglarGUI();
            gui.name = path.name;
            gui.lat = _lat;
            gui.lon = _lon;
            gui.video = radioVideo.Checked;
            gui.startend = chkRectHome.Checked;
            gui.altitude = Convert.ToDouble(txtPathAlt.Text);
            gui.heading = Convert.ToDouble(txtGridRotation.Text);
            gui.length = Convert.ToDouble(txtGridLength.Text);
            gui.width = Convert.ToDouble(txtGridWidth.Text);
            gui.single = chkOnePass.Checked;
            gui.poimode = chkRectCamPOI.Checked;
            gui.poiname = cmbRectCamPOI.SelectedText;
            path.rectanglegui = gui;
            _gmap.Delete_gMapPoly(_poly);
            this.Close();
        }

        private void chkRectCamPOI_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void grpStartLoc_Enter(object sender, EventArgs e)
        {

        }

        private void radioUpLeft_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void radioLowLeft_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void radioUpRight_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void radioLowRight_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void trkRectAlt_Scroll(object sender, EventArgs e)
        {
            txtPathAlt.Text = Convert.ToString(trkRectAlt.Value);
        }

        private void txtPathAlt_TextChanged(object sender, EventArgs e)
        {
            trkRectAlt.Value = Convert.ToInt16(txtPathAlt.Text);
            BuildRectPath();
        }

        private void txtRectPathName_TextChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void radioPhoto_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }

        private void radioVideo_CheckedChanged(object sender, EventArgs e)
        {
            BuildRectPath();
        }
    }
}
