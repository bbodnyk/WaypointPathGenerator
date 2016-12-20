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
    public partial class DialogKMLPolygon : Form
    {
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private TreeView _treeview;
        
        public DialogKMLPolygon(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;

            InitializeComponent();
        }

        private void btnReadKMLPoly_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /* Get kml filename */

                string kml_file = openFileDialog1.FileName;

                if (kml_file.Contains(".kml"))
                {
                    System.IO.TextReader stream = System.IO.File.OpenText(kml_file);
                    SharpKml.Engine.KmlFile file = KmlFile.Load(stream);
                    Kml _kml = file.Root as Kml;

                    SharpKml.Dom.Placemark[] tempPlaceMarks = new SharpKml.Dom.Placemark[1000];
                    SharpKml.Dom.Placemark tmp_placemark = new SharpKml.Dom.Placemark();
                    CoordinateCollection coordinates = new CoordinateCollection();
                    Form1.Globals.poly_point_count = 0;

                    if (_kml != null)
                    {
                        SharpKml.Base.Vector vector;
                        double lat;
                        double lon;
                        double alt;
                        string name = "";

                        foreach (var placemark in _kml.Flatten().OfType<SharpKml.Dom.Placemark>())
                        {
                            name = placemark.Name;
                        }
                        
                        Models.Shape shape = new Models.Shape();
                        shape.name = name;

                        foreach (var linering in _kml.Flatten().OfType<LinearRing>())
                        {
                            coordinates = linering.Coordinates;
                            int num = coordinates.Count;

                            LinkedList<PolyPoint> shape_points = new LinkedList<PolyPoint>();

                            for (int i = 0; i < num; i++)
                            {
                                PolyPoint point = new PolyPoint();
                                vector = coordinates.ElementAt(i);
                                lat = vector.Latitude;
                                lon = vector.Longitude;
                                alt = (double)vector.Altitude;
                                point.lat = lat;
                                point.lon = lon;
                                point.alt = alt;
                                shape_points.AddLast(point);
                                //dgvWaypoints.Rows.Add(Globals.waypoint_count, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(30));
                            }
                            shape.points = shape_points;
                            shape.visible = true;
                            _wpg.AddShape(shape);
                            _gmap.Add_gMapPoly(shape, true);

                        }

                    }
                }
                GMAPTree.Update_GMapTree(_wpg, _treeview);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
