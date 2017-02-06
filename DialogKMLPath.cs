using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SharpKml.Engine;
using SharpKml.Dom;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator
{
    public partial class DialogKMLPath : Form
    {
        double _lat;
        double _lon;
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private WayPoints _wp;
        private Models.Path _path;
        private TreeView _treeview;
        int _current_path_index;
        double[,] _kml_points = new double[1000, 4];
        int _kml_point_count = 0;
        string _kml_filename = null;

        public DialogKMLPath(Waypoint_Path_Gen wpg, GMAP gmap,TreeView treeview, double lat, double lon)
        {
            _lat = lat;
            _lon = lon;
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _current_path_index = -1;
            _path = new Models.Path();
            _wp = new WayPoints();

            InitializeComponent();

            // Fill POI combobox

            cmbKLMPOI.Items.Clear();
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                cmbKLMPOI.Items.Add(_wpg.POIPointAt(i).name);
            }

            // Generate EMpty Path

            _path.Add_Empty_Path(_wpg, _gmap, "Empty Path", "KML");
            _current_path_index = _wpg.PathCount() - 1;
        }

        private void chKLMPOI_CheckedChanged(object sender, EventArgs e)
        {
            BuildKMLPath();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectKMLFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /* Get kml filename */

                string kml_file = openFileDialog1.FileName;

                if (kml_file.Contains(".kml"))
                {

                    Form1.Globals.kml_filename = kml_file;
                    rtbKMLRead.AppendText("KML File : " + kml_file + "\n");
                    rtbKMLRead.AppendText("\n");

                    /* Open KML File */

                    System.IO.TextReader stream = System.IO.File.OpenText(kml_file);
                    SharpKml.Engine.KmlFile file = KmlFile.Load(stream);
                    Kml _kml = file.Root as Kml;

                    SharpKml.Dom.Placemark[] tempPlaceMarks = new SharpKml.Dom.Placemark[1000];
                    SharpKml.Dom.Placemark tmp_placemark = new SharpKml.Dom.Placemark();
                    CoordinateCollection coordinates = new CoordinateCollection();


                    Form1.Globals.kml_point_count = 0;

                    //rtbKMLRead.AppendText("Waypoint Count : " + Convert.ToString(Globals.waypoint_count) + "\n");

                    int numOfPlaceMarks = 0;

                    if (_kml != null)
                    {
                        foreach (var placemark in _kml.Flatten().OfType<SharpKml.Dom.Placemark>())
                        {
                            string placename = placemark.Name;
                            rtbKMLRead.AppendText("Placemark Name : " + placename + "\n");
                            tmp_placemark.Name = placename;
                            numOfPlaceMarks++;
                        }
                        rtbKMLRead.AppendText("Number of Placemarks : " + Convert.ToString(numOfPlaceMarks) + "\n");


                        int num_linestring = 0;
                        SharpKml.Base.Vector vector;
                        double lat;
                        double lon;
                        double alt;

                        foreach (var linestring in _kml.Flatten().OfType<LineString>())
                        {
                            coordinates = linestring.Coordinates;
                            int num = coordinates.Count;
                            rtbKMLRead.AppendText("Num Coordinates : " + Convert.ToString(num) + "\n");
                            for (int i = 0; i < num; i++)
                            {
                                vector = coordinates.ElementAt(i);
                                lat = vector.Latitude;
                                lon = vector.Longitude;
                                alt = (double)vector.Altitude;
                                rtbKMLRead.AppendText("Lat/Lon : " + Convert.ToString(lat));
                                rtbKMLRead.AppendText(", " + Convert.ToString(lon) + "Altitude : " + Convert.ToString(alt) + "\n");
                                _kml_points[_kml_point_count, 0] = lat;
                                _kml_points[_kml_point_count, 1] = lon;
                                _kml_points[_kml_point_count, 2] = alt;
                                _kml_point_count++;
                                //dgvWaypoints.Rows.Add(Globals.waypoint_count, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(30));
                            }
                            num_linestring++;
                        }
                        rtbKMLRead.AppendText("Number of Linestrings : " + Convert.ToString(num_linestring) + "\n");

                        BuildKMLPath();


                    }
                }
                else { MessageBox.Show("Wrong file type!", "GPS Grid:", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
        }

        private void BuildKMLPath()
        {
            // Create Path

            if (_current_path_index != -1)
            {
                _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            }

            string path_name = txtKMLName.Text;
            if (path_name == "") path_name = _kml_filename;

            LinkedList<WayPoints> wp_list = new LinkedList<WayPoints>();

            double lat, lon, alt;
            int gimblemode = 0;
            double gimblepitch = 0;
            double curvesize = 0;
            double rotdir = 0;
            Models.Action action = _wpg.GetAction("No Action");
            int action_id = action.internal_id;

            LinkedList<WayPoints> new_list = new LinkedList<WayPoints>();

            /* Generate Waypoints for each coordinate */

            for (int i = 0; i < _kml_point_count; i++)
            {
                lat = _kml_points[i, 0];
                lon = _kml_points[i, 1];
                alt = _kml_points[i, 2];
                double heading = 0.0;
                double poi_lat = 0;
                double poi_lon = 0;

                /* Calculate Heading for each Waypoint */
                if (chKLMPOI.Checked)
                {
                    int poi_index = cmbKLMPOI.SelectedIndex;
                    if (poi_index == -1)
                    {
                        poi_lat = _lat;
                        poi_lon = _lon;
                    }
                    else {
                        POIPoints tmp_point = _wpg.POIPointAt(poi_index);
                        poi_lat = tmp_point.lat;
                        poi_lon = tmp_point.lon;
                    }
                    heading = GPS.GPS_Bearing(lat, lon, poi_lat, poi_lon);
                    gimblemode = 2;
                    double distance = GPS.GPS_Distance(lat, lon, poi_lat, poi_lon, Form1.Globals.gps_radius);
                    gimblepitch = -GPS.RadiansToDegrees(Math.Atan(alt / distance));
                    gimblemode = 2;
                }
                else {
                    if (i != _kml_point_count - 1)
                    {
                        double lat_next = _kml_points[i + 1, 0];
                        double lon_next = _kml_points[i + 1, 1];
                        heading = GPS.GPS_Bearing(lat, lon, lat_next, lon_next);
                    }
                }
                _wp.Add_Waypoint_List(_wpg, new_list, lat, lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, -1, action_id);
                //dgvWaypoints.Rows.Add(Globals.waypoint_count + i+1, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(alt));
            }

            _path.Add_Path(_wpg, _gmap, path_name, "KML", new_list);
            int index = _wpg.PathCount() - 1;
            _current_path_index = index;

            Models.Path path = _wpg.PathAt(index);
            string exist_type = path.type;
            bool exist_select = path.selected;
            bool exist_visible = path.visible;
            if (exist_type == "KML")
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
            GMAPTree.Update_GMapTree(_wpg, _treeview);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_current_path_index != -1) _wpg.DeletePath(_wpg.PathAt(_current_path_index));
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            this.Close();
        }

        private void btnAddKML_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKLMPOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildKMLPath();
        }

        private void txtKMLName_TextChanged(object sender, EventArgs e)
        {
            BuildKMLPath();
        }
    }
}
