﻿using System;
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
        private WayPoints _wp;
        private Path _path;
        private int _current_path_index = -1;

        public dialogAddCircularPath(Waypoint_Path_Gen wpg, GMAP gmap, double lat, double lon)
        {
            _wp = new WayPoints();
            _path = new Path();
            _wpg = wpg;
            _gmap = gmap;
            _lat = lat;
            _lon = lon;
            InitializeComponent();
            buildCircPath();
            _current_path_index = _wpg.PathCount() - 1;
            // Fill POI combobox
            cmbCircPOI.Items.Clear();
            for(int i = 0; i < _wpg.POICount(); i++)
            {
                cmbCircPOI.Items.Add(_wpg.POIPointAt(i).name);
            }
        }

        private void bnCancelAddCircPath_Click(object sender, EventArgs e)
        {
            if (_current_path_index != -1) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void btnAddCircPath_Click(object sender, EventArgs e)
        {
            //buildCircPath();
            //_gmaptree.Update_GMapTree(_wpg, _treeview);
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

            } while (count < circle_num_points);

            if (full_circle) _wp.Add_Waypoint_List(new_list, start_lat, start_lon, altitude, start_head, curvesize, rotdir, gimblemode, gimplepitch, actions); ;

            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, lat_home, lon_home, altitude, 0.0, curvesize, rotdir, gimblemode, 0.0, no_actions);
            }

            // Save Path

            if(_current_path_index != -1)
            {
                _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            }
            string path_name = txtDiaAddCircPathName.Text;
            if (path_name == "") path_name = "Untitled - Circular";
            _path.Add_Path(_wpg, _gmap, path_name, "Circular", new_list);
            int index = _wpg.PathCount()-1;
            _current_path_index = index;

            Models.Path path = _wpg.PathAt(index);
            string exist_type = path.type;
            bool exist_select = path.selected;
            bool exist_visible = path.visible;
            if (exist_type == "Circular")
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
            
            _gmap.ReDrawgMap();
            //_wpg.ChangePathWP(index, new_list);
            //cmbCircReuse.ResetText();

           
        }


        private void chkCircPOI_CheckedChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void cmbCircPOI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaAddCircPathAlt_TextChanged(object sender, EventArgs e)
        {
            trkAlt.Value = Convert.ToInt16(txtDiaAddCircPathAlt.Text);
            buildCircPath();
        }

        private void txtDiaAddCircPathName_TextChanged(object sender, EventArgs e)
        {
            buildCircPath();
        }

        private void txtDiaAddCircPathRadius_TextChanged(object sender, EventArgs e)
        {
            trkRadius.Value = Convert.ToInt16(txtDiaAddCircPathRadius.Text);
            buildCircPath();
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
        }
    }
}

