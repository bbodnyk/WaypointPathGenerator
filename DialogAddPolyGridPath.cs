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
    public partial class DialogAddPolyGridPath : Form
    {
        public struct WPG_Vector
        {
            public double lat;
            public double lon;
            public double bearing;
        }

        public struct WPG_PointVector
        {
            public WPG_Point pnt1;
            public WPG_Point pnt2;
        }

        public struct WPG_Point
        {
            public double lat;
            public double lon;
        }

        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private GPS _gps;
        private WayPoints _wp;
        private Path _path;
        private double _lat;
        private double _lon;
        private double _cam_ang_hor;
        private double _cam_ang_ver;
        private double _over_wid;
        private double _over_hgt;
        private double _camera_width;
        private double _camera_height;
        private int _current_path_index = -1;

        public DialogAddPolyGridPath(Waypoint_Path_Gen wpg, GMAP gmap, double lat, double lon,
            double cam_ang_hor, double cam_ang_ver, double over_wid, double over_hgt)
        {
            _wpg = wpg;
            _gmap = gmap;
            _gps = new GPS();
            _wp = new WayPoints();
            _path = new Path();
            _lat = lat;
            _lon = lon;
            _cam_ang_hor = cam_ang_hor;
            _cam_ang_ver = cam_ang_ver;
            _over_wid = over_wid;
            _over_hgt = over_hgt;

            InitializeComponent();
            


            int shape_count = _wpg.ShapeCount();
            for (int i = 0; i < shape_count; i++)
            {
                cmbShape.Items.Add(_wpg.ShapeAt(i).name);
            }
            if (shape_count > 0) cmbShape.SelectedIndex = 0;
            BuildPolyGridPath();
            _current_path_index = _wpg.PathCount() - 1;
        }
 
        private void txtGridAlt_TextChanged_1(object sender, EventArgs e)
        {
            BuildPolyGridPath();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_current_path_index != -1) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void trkAltitude_Scroll(object sender, EventArgs e)
        {
            txtGridAlt.Text = Convert.ToString(trkAltitude.Value);
        }

        private void BuildPolyGridPath()
        {

            // Polygon Search Grid
            //

            double altitude = Convert.ToDouble(txtGridAlt.Text);
            _camera_width = (2 * (Math.Tan(_gps.DegreesToRadians(_cam_ang_hor / 2)) * altitude));
            _camera_height = (2 * (Math.Tan(_gps.DegreesToRadians(_cam_ang_ver / 2)) * altitude));

            // Get Poly Name and points
            //
            Double[,] point_arr = new double[1000, 3];
            WPG_Vector[,] poly_vectors = new WPG_Vector[1000, 2];
            WPG_Vector[,] path_vectors = new WPG_Vector[1000, 2];
            int poly_index = cmbShape.SelectedIndex;
            if (poly_index == -1)
            {
                MessageBox.Show("Error : Select a Polygon");
                return;
            }
            LinkedList<PolyPoint> points = new LinkedList<PolyPoint>();
            PolyPoint point = new PolyPoint();
            Models.Shape poly = _wpg.ShapeAt(poly_index);
            rtbPoly.Clear();
            rtbPoly.AppendText("Polygon : " + poly.name+"\n");

            points = poly.points;
            int poly_count = points.Count();
            double lat_max = -1000.0;
            double lon_max = -1000.0;
            double lat_min = 1000.0;
            double lon_min = 1000.0;
            //LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();
            int[,] no_actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };
            int[,] pict_actions = new int[,] { { 0, 2000 }, { 1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };


            for (int i = 0; i < poly_count; i++)
            {
                point = points.ElementAt(i);
                double lat = point.lat;
                double lon = point.lon;
                double alt = point.alt;
                //Add_Waypoint_List(new_list, lat, lon, alt, 0, 0, 0, 0, 0, no_actions);
                point_arr[i, 0] = lat;
                point_arr[i, 1] = lon;
                point_arr[i, 2] = alt;
                if (lat > lat_max) lat_max = lat;
                if (lat < lat_min) lat_min = lat;
                if (lon > lon_max) lon_max = lon;
                if (lon < lon_min) lon_min = lon;
            }
            double delta_lat = lat_max - lat_min;
            double delta_lon = lon_max - lon_min;
            // Generate Polygon Vectors
            int vector_count = 0;

            for (int i = 0; i < poly_count - 1; i++)
            {
                poly_vectors[vector_count, 0].lat = point_arr[i, 0];
                poly_vectors[vector_count, 0].lon = point_arr[i, 1];
                poly_vectors[vector_count, 1].lat = point_arr[i + 1, 0];
                poly_vectors[vector_count, 1].lon = point_arr[i + 1, 1];
                vector_count++;
            }

            rtbPoly.AppendText("Poly Vector Count : " + Convert.ToString(vector_count) + "\n");

            // Generate Potential Paths

            LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();

            int path_count = 0;

            double head = Convert.ToDouble(txtHeading.Text);
            double bearing = head - 90.0;
            double path_delta = _camera_width * ((100 - _over_wid) / 100);
            double dist = _gps.GPS_Distance(lat_min, lon_min, lat_max, lon_max, Form1.Globals.gps_radius);
            int num_path = Convert.ToInt16(dist / path_delta);
            double lat_base = lat_min;
            double lon_base = lon_min;
            if (head >= -90 & head < 90)
            {
                lat_base = lat_min;
                lon_base = lon_max;
            }

            // Generate First Potential Path
            double new_lat1 = _gps.GPS_Lat_BearDist(lat_base, lon_base, bearing, 1000, Form1.Globals.gps_radius);
            double new_lon1 = _gps.GPS_Lon_BearDist(lat_base, lon_base, new_lat1, bearing, 1000, Form1.Globals.gps_radius);
            double new_lat2 = _gps.GPS_Lat_BearDist(lat_base, lon_base, bearing, -1000, Form1.Globals.gps_radius);
            double new_lon2 = _gps.GPS_Lon_BearDist(lat_base, lon_base, new_lat2, bearing, -1000, Form1.Globals.gps_radius);
            double bear = _gps.GPS_Bearing(new_lat1, new_lon1, new_lat2, new_lon2);

            // Generate Path Waypoints to show paths
            //_wp.Add_Waypoint_List(new_list, new_lat1, new_lon1, 30, 0, 0, 0, 0, 0, no_actions);
            //_wp.Add_Waypoint_List(new_list, new_lat2, new_lon2, 30, 0, 0, 0, 0, 0, no_actions);

            path_vectors[path_count, 0].lat = new_lat1;
            path_vectors[path_count, 0].lon = new_lon1;
            path_vectors[path_count, 0].bearing = bearing;
            path_vectors[path_count, 1].lat = new_lat2;
            path_vectors[path_count, 1].lon = new_lon2;
            path_vectors[path_count, 1].bearing = bearing;
            path_count++;
            // Generate remaining Paths
            double new_lat_base, new_lon_base;

            for (int i = 0; i < num_path; i++)
            {
                new_lat_base = _gps.GPS_Lat_BearDist(lat_base, lon_base, 0 + bearing, path_delta * i, Form1.Globals.gps_radius);
                new_lon_base = _gps.GPS_Lon_BearDist(lat_base, lon_base, new_lat_base, 0 + bearing, path_delta * i, Form1.Globals.gps_radius);

                new_lat1 = _gps.GPS_Lat_BearDist(new_lat_base, new_lon_base, bearing + 90, 1000, Form1.Globals.gps_radius);
                new_lon1 = _gps.GPS_Lon_BearDist(new_lat_base, new_lon_base, new_lat1, bearing + 90, 1000, Form1.Globals.gps_radius);
                new_lat2 = _gps.GPS_Lat_BearDist(new_lat_base, new_lon_base, bearing + 270, 1000, Form1.Globals.gps_radius);
                new_lon2 = _gps.GPS_Lon_BearDist(new_lat_base, new_lon_base, new_lat2, bearing + 270, 1000, Form1.Globals.gps_radius);
                bear = _gps.GPS_Bearing(new_lat1, new_lon1, new_lat2, new_lon2);

                //_wp.Add_Waypoint_List(new_list, new_lat1, new_lon1, 30, 0, 0, 0, 0, 0, no_actions);
                //_wp.Add_Waypoint_List(new_list, new_lat2, new_lon2, 30, 0, 0, 0, 0, 0, no_actions);

                path_vectors[path_count, 0].lat = new_lat1;
                path_vectors[path_count, 0].lon = new_lon1;
                path_vectors[path_count, 0].bearing = bearing;
                path_vectors[path_count, 1].lat = new_lat2;
                path_vectors[path_count, 1].lon = new_lon2;
                path_vectors[path_count, 1].bearing = bearing;
                path_count++;
            }

            // Check for intersections of potential paths with polygon borders

            Form1.WPG_PointVector pvec1 = new Form1.WPG_PointVector();
            Form1.WPG_PointVector pvec2 = new Form1.WPG_PointVector();
            bool lines_intersect;
            bool segments_intersect;

            PointF closep1;
            PointF closep2;
            bool firstpnt = true;
            bool firstleg = true;
            double heading = 0.0;
            double lat1 = 0.0;
            double lon1 = 0.0;
            int gimblemode = 0;
            double curvesize = 0;
            double rotdir = 0;
            bool startend = chkRectHome.Checked;
            bool video = radioVideo.Checked;
            int leg_count = 0;

            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, _lat, _lon, altitude, 0.0, curvesize, rotdir, gimblemode, 0.0, no_actions);
            }

            for (int i = 1; i < path_count; i++)
            {
                pvec1.pnt1.lat = path_vectors[i, 0].lat;
                pvec1.pnt1.lon = path_vectors[i, 0].lon;
                pvec1.pnt2.lat = path_vectors[i, 1].lat;
                pvec1.pnt2.lon = path_vectors[i, 1].lon;

                for (int j = 0; j < vector_count; j++)
                {
                    PointF intersection;
                    pvec2.pnt1.lat = poly_vectors[j, 0].lat;
                    pvec2.pnt1.lon = poly_vectors[j, 0].lon;
                    pvec2.pnt2.lat = poly_vectors[j, 1].lat;
                    pvec2.pnt2.lon = poly_vectors[j, 1].lon;

                    _gps.GPS_Intersection(pvec1, pvec2, out lines_intersect, out segments_intersect, out intersection, out closep1, out closep2);
                    if (lines_intersect & segments_intersect)
                    {

                        if (firstpnt)
                        {
                            lat1 = Convert.ToDouble(intersection.X);
                            lon1 = Convert.ToDouble(intersection.Y);
                            firstpnt = false;
                        }
                        else
                        {
                            double lat = Convert.ToDouble(intersection.X);
                            double lon = Convert.ToDouble(intersection.Y);
                            if (firstleg)
                            {
                                heading = _gps.GPS_Bearing(lat1, lon1, lat, lon);
                                firstleg = false;
                            }
                            _wp.Add_Leg_List(_gps, new_list, lat1, lon1, lat, lon, altitude, heading, 0, 0, 0, 0, pict_actions, video, _camera_height, _over_hgt);
                            leg_count++;
                            firstpnt = true;
                        }

                    }
                }
            }

            if (startend)
            {
                _wp.Add_Waypoint_List(new_list, _lat, _lon, altitude, 0.0, curvesize, rotdir, gimblemode, 0.0, no_actions);
            }

            rtbPoly.AppendText("Leg Count :" + Convert.ToString(leg_count) + "\n");
            int wp_count = new_list.Count;
            rtbPoly.AppendText("Waypoint Count :" + Convert.ToString(wp_count) + "\n");

            // Save Path

            if (_current_path_index != -1)
            {
                _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            }

            string path_name = txtPolyPathName.Text;
            if (path_name == "") path_name = "Untitled - Polygon";
            _path.Add_Path(_wpg, _gmap, path_name, "Polygon", new_list);
            int index = _wpg.PathCount() - 1;
            _current_path_index = index;

            Models.Path path = _wpg.PathAt(index);
            string exist_type = path.type;
            bool exist_select = path.selected;
            bool exist_visible = path.visible;
            if (exist_type == "Polygon")
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
                _gmap.Add_gMapPath(path, true);
            }

            _gmap.ReDrawgMap();
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildPolyGridPath();
        }

        private void trkHeading_Scroll(object sender, EventArgs e)
        {
            txtHeading.Text = Convert.ToString(trkHeading.Value);
        }

        private void txtHeading_TextChanged(object sender, EventArgs e)
        {
            BuildPolyGridPath();
        }

        private void chkRectHome_CheckedChanged_1(object sender, EventArgs e)
        {
            BuildPolyGridPath();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioVideo_CheckedChanged(object sender, EventArgs e)
        {
            BuildPolyGridPath();
        }
    }
}

