using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpKml.Dom;
using Waypoint_Path_Generator.Models;
using SharpKml.Base;

namespace Waypoint_Path_Generator
{
    public partial class DialogOutputPath : Form
    {
        Waypoint_Path_Gen _wpg;
        Options _options;
        Path _path;

        public DialogOutputPath(Options options, Waypoint_Path_Gen wpg, Path path)
        {
            _options = options;
            _wpg = wpg;
            _path = path;
            InitializeComponent();
            txtCSVFilePath.Text = _options.def_csv_path;
            txtKMLFilePath.Text = _options.def_kml_path;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOutputCVS_Click(object sender, EventArgs e)
        {
            LinkedList<WayPoints> wp_list = _path.waypoints;

            WayPoints point = new WayPoints();
            string str = "";
            string filename = txtCSVFilePath.Text;

            int pcount = 0;
            int point_count = wp_list.Count;
            if (point_count > 0)
            {
                do
                {
                    point = wp_list.ElementAt(pcount);
                    double lat = point.lat;
                    double lon = point.lon;
                    double altitude = point.alt;

                    double head = point.head;
                    double curvesize = point.curvesize;
                    double rotationdir = point.rotationdir;
                    int gimblemode = point.gimblemode;
                    double gimblepitch = point.gimblepitch;
                    if (!_options.units_metric)
                    {
                        altitude = GPS.FeetToMeters(altitude);
                        curvesize = GPS.FeetToMeters(curvesize);
                    }

                    str = str + Convert.ToString(lat) + "," + Convert.ToString(lon);
                    str = str + ", " + Convert.ToString(altitude);
                    str = str + ", " + Convert.ToString(head);
                    str = str + ", " + Convert.ToString(curvesize);
                    str = str + ", " + Convert.ToString(rotationdir);
                    str = str + ", " + Convert.ToString(gimblemode);
                    str = str + ", " + Convert.ToString(gimblepitch);
                    int actionid = point.action_id;
                    Models.Action pnt_action = _wpg.ActionWithId(actionid);


                    
                    for (int i = 0; i < 15; i++)
                    {
                        str = str + ", " + Convert.ToString(pnt_action.actions[i, 0]);
                        str = str + ", " + Convert.ToString(pnt_action.actions[i, 1]);
                    }
                    
                    str = str + "\r\n";
                    pcount++;

                } while (pcount < point_count);

                // Write to File 

                System.IO.File.WriteAllText(filename, str);
            }

            this.Close();
        }

        private void btnOutputKML_Click(object sender, EventArgs e)
        {
            LinkedList<WayPoints> wp_list = _path.waypoints;

            int pcount = 0;
            int point_count = wp_list.Count;
            if (point_count > 0)
            {
                //double lat_center = Convert.ToDouble(txtCenterLat.Text);
                //double lon_center = Convert.ToDouble(txtCenterLon.Text);
                double lat, new_lat, start_lat;
                double lon, new_lon, start_lon;
                double image_len;
                double image_wid;

                image_len = (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_hor / 2)) * 30.0);
                image_wid = (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_ver / 2)) * 30.0);
                double alt;
                double bear;
                string location_name = txtKMLPath.Text;
                string filename = txtKMLFilePath.Text;

                Kml kml = new Kml();

                Folder folder = new Folder();
                SharpKml.Dom.Placemark placemark = new SharpKml.Dom.Placemark();
                LineString linestring = new LineString();
                var vector = new Vector();
                CoordinateCollection coordinates = new CoordinateCollection();

                Style path_style = new Style();
                path_style.Polygon = new PolygonStyle();
                path_style.Line = new LineStyle();
                // Color32( alpha, blue, green, red
                path_style.Polygon.Color = new Color32(128, 255, 255, 0);
                path_style.Line.Color = new Color32(255, 255, 255, 0);
                linestring.AltitudeMode = AltitudeMode.RelativeToGround;
                linestring.Extrude = true;
                WayPoints point = new WayPoints();

                do
                {
                    point = wp_list.ElementAt(pcount);
                    lat = point.lat;
                    lon = point.lon;
                    alt = point.alt;
                    if (!_options.units_metric) alt = GPS.FeetToMeters(alt);

                    vector = new Vector(lat, lon, alt);

                    coordinates.Add(vector);
                    pcount++;
                } while (pcount < point_count);

                linestring.Coordinates = coordinates;
                placemark.Geometry = linestring;
                placemark.AddStyle(path_style);
                placemark.Name = location_name;
                folder.AddFeature(placemark);
                // kml.Feature = placemark;

                /* Generate camera rectangles */

                if (chkGenCamRect.Checked)
                {

                    //image_len = 25;
                    //image_wid = 50;
                    double diag_ang = GPS.RadiansToDegrees(Math.Atan(image_len / image_wid));
                    double diag_len = Math.Sqrt((image_len * image_len) + (image_wid * image_wid));
                    double gps_radius;

                    for (int i = 0; i < wp_list.Count; i++)
                    {
                        Style poly_style = new Style();
                        poly_style.Polygon = new PolygonStyle();
                        poly_style.Line = new LineStyle();
                        // Color32( alpha, blue, green, red
                        poly_style.Polygon.Color = new Color32(128, 0, 255, 255);
                        poly_style.Line.Color = new Color32(255, 0, 255, 255);
                        Kml kml_rect = new Kml();
                        SharpKml.Dom.Placemark rect_placemark = new SharpKml.Dom.Placemark();
                        Polygon poly = new Polygon();
                        OuterBoundary outer = new OuterBoundary();
                        LinearRing line = new LinearRing();
                        CoordinateCollection coor = new CoordinateCollection();
                        poly.AltitudeMode = AltitudeMode.RelativeToGround;
                        poly.Extrude = false;

                        point = wp_list.ElementAt(i);
                        lat = point.lat;
                        lon = point.lon;
                        alt = point.alt;
                        gps_radius = _options.earth_radius + _options.def_elevation + alt;
                        alt = 2;
                        bear = point.head;
                        coor.Clear();
                        new_lat = GPS.GPS_Lat_BearDist(lat, lon, diag_ang + bear, diag_len, gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat, lon, new_lat, diag_ang + bear, diag_len, gps_radius);
                        start_lat = new_lat;
                        start_lon = new_lon;
                        vector = new Vector(new_lat, new_lon, alt);
                        coor.Add(vector);
                        new_lat = GPS.GPS_Lat_BearDist(lat, lon, 180 - diag_ang + bear, diag_len, gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat, lon, new_lat, 180 - diag_ang + bear, diag_len, gps_radius);
                        vector = new Vector(new_lat, new_lon, alt);
                        coor.Add(vector);
                        new_lat = GPS.GPS_Lat_BearDist(lat, lon, 180 + diag_ang + bear, diag_len, gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat, lon, new_lat, 180 + diag_ang + bear, diag_len, gps_radius);
                        vector = new Vector(new_lat, new_lon, alt);
                        coor.Add(vector);
                        new_lat = GPS.GPS_Lat_BearDist(lat, lon, 360 - diag_ang + bear, diag_len, gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat, lon, new_lat, 360 - diag_ang + bear, diag_len, gps_radius);
                        vector = new Vector(new_lat, new_lon, alt);
                        coor.Add(vector);
                        vector = new Vector(start_lat, start_lon, alt);
                        coor.Add(vector);

                        line.Coordinates = coor;
                        outer.LinearRing = line;
                        poly.OuterBoundary = outer;

                        rect_placemark.Geometry = poly;
                        rect_placemark.AddStyle(poly_style);
                        rect_placemark.Name = "WP " + Convert.ToString(i);
                        folder.AddFeature(rect_placemark);
                    }
                }

                kml.Feature = folder;
                Serializer serializer = new Serializer();
                serializer.Serialize(kml);


                System.IO.File.WriteAllText(filename, serializer.Xml);

            }
            this.Close();
        }
    }
}
