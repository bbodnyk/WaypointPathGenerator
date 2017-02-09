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
            txtMissionPlanner.Text = _options.def_mp_path;
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
                double pitch;
                double image_len;
                double image_wid;


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
                    double diag_ang;
                    double diag_len;
                    double poi_lat = 0;
                    double poi_lon = 0;
                    double gps_radius;
                    int poi_id;

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
                        poi_id = point.poi_id;
                        POIPoints poipnt = _wpg.POIPointID(poi_id);
                        if (poipnt != null)
                        {
                            poi_lat = poipnt.lat;
                            poi_lon = poipnt.lon;
                        } else
                        {
                            string path_type = _path.type;
                            if(path_type == "Circular")
                            {
                                CircularGUI gui = _path.circgui;
                                poi_lat = gui.lat;
                                poi_lon = gui.lon;
                            }
                            if (path_type == "Helical")
                            {
                                HelicalGUI gui = _path.helixgui;
                                poi_lat = gui.lat;
                                poi_lon = gui.lon;
                            }
                            if (path_type == "Rectangular")
                            {
                                RectanglarGUI gui = _path.rectanglegui;
                                poi_lat = gui.lat;
                                poi_lon = gui.lon;
                            }
                            if (path_type == "Mathamatical")
                            {
                                MathGUI gui = _path.mathgui;
                                poi_lat = gui.lat;
                                poi_lon = gui.lon;
                            }
                        }
                        pitch = point.gimblepitch;
                        gps_radius = _options.earth_radius + _options.def_elevation + alt;

                        coor.Clear();

                        if (pitch == -90)
                        {
                            image_len = (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_hor / 2)) * alt);
                            image_wid = (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_ver / 2)) * alt);
                            diag_ang = GPS.RadiansToDegrees(Math.Atan(image_len / image_wid));
                            diag_len = Math.Sqrt((image_len * image_len) + (image_wid * image_wid));
                            alt = 2;
                            bear = point.head;

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
                        else
                        {
                            if (pitch < 0)
                            {
                                vector = new Vector(lat, lon, alt);
                                coor.Add(vector);
                                vector = new Vector(lat, lon, 2);
                                coor.Add(vector);
                                vector = new Vector(poi_lat, poi_lon, 2);
                                coor.Add(vector);
                                vector = new Vector(lat, lon, alt);
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

                        

                    }
                }

                kml.Feature = folder;
                Serializer serializer = new Serializer();
                serializer.Serialize(kml);


                System.IO.File.WriteAllText(filename, serializer.Xml);

            }
            this.Close();
        }

        private void btnOutputMissionPlanner_Click(object sender, EventArgs e)
        {
            string str = "QGC WPL 110\n";

            LinkedList<WayPoints> wp_list = _path.waypoints;
            int count = 0;
            int wp_code, wp_delay;
            double gimble_pitch;

            if (_path.type == "Mathamatical")
            {
                MathGUI gui = _path.mathgui;
                str = str + Convert.ToString(count++) + " "; // wp count
                str = str + "1 0 16 0 0 0 0 ";
                str = str + Convert.ToString(gui.lat) + " ";
                str = str + Convert.ToString(gui.lon) + " ";
                str = str + Convert.ToString(gui.altitude);
                str = str + " 1\n";
            }

            for (int i = 0; i < wp_list.Count; i++)
            {
                wp_delay = 0;
                WayPoints wp = wp_list.ElementAt(i);
                int action_id = wp.action_id;
                Models.Action action = _wpg.ActionWithId(action_id);
                string action_name = action.name;
                if (action_name == "Take Picture")
                {
                    wp_delay = 1;
                }
                if (action_name == "Pause/Take Picture")
                {
                    wp_delay = action.actions[0, 1] / 1000;
                }
                // WAYPOINT
                wp_code = 16;
                str = str + Convert.ToString(count++) + " "; // wp count
                str = str + "0 0 ";
                str = str + Convert.ToString(wp_code) + " ";
                str = str + Convert.ToString(wp_delay) + " ";
                str = str + " 0 0 0 ";
                str = str + Convert.ToString(wp.lat) + " ";
                str = str + Convert.ToString(wp.lon) + " ";
                str = str + Convert.ToString(wp.alt);
                str = str + " 1\n";

                if (action_name == "Take Picture" | action_name == "Pause/Take Picture")
                {

                    gimble_pitch = wp.gimblepitch;
                    // DO_MOUNT_CONTROL
                    wp_code = 205;
                    str = str + Convert.ToString(count++) + " "; // wp count
                    str = str + "0 0 ";
                    str = str + Convert.ToString(wp_code) + " ";
                    str = str + Convert.ToString(gimble_pitch) + " ";
                    str = str + "0 0 0 0 0 0 1\n";
                    // DO_DIGICAM_CONTROL
                    wp_code = 203;
                    str = str + Convert.ToString(count++) + " "; // wp count
                    str = str + "0 0 ";
                    str = str + Convert.ToString(wp_code) + " ";
                    str = str + "0 0 0 0 0 0 0 1\n";
                }
            }

            // Write to File 

            string filename = _options.def_mp_path;
            System.IO.File.WriteAllText(filename, str);
            this.Close();
        }
    }
}
