using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator
{
    public class GMAP
    {
        private GMapControl _mapcontrol;
        private PointLatLng _center;
        private GMapOverlay _overmarkers;
        private GMapOverlay _overroutes;
        private GMapOverlay _overpolys;
        private Bitmap _poi_image;
        private Bitmap _poi_selected_image;
        private Bitmap _drone_image;
        private Bitmap _drone_image_notselected;
        private Bitmap _drone_image_selected;
        private List<GMAPWPMarker> _markers = new List<GMAPWPMarker>();
        private Waypoint_Path_Gen _wpg;

        private class GMAPWPMarker
        {
            public int path;
            public int wp;
            public bool selected;
            public GMapMarker marker;
        }

        public GMAP(Waypoint_Path_Gen wpg, GMapControl mapcontrol, int index)
        {
            _wpg = wpg;
            _mapcontrol = mapcontrol;
            _mapcontrol.MinZoom = 1;
            _mapcontrol.MaxZoom = 24;

            switch (index)
            {
                case 0:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
                    break;
                case 1:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleMapProvider.Instance;
                    break;
                case 2:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
                    break;
                case 3:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
                    break;
                case 4:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleChinaSatelliteMapProvider.Instance;
                    break;
                case 5:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.ArcGIS_Topo_US_2D_MapProvider.Instance;
                    break;
                case 6:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
                    break;
            }

            //_mapcontrol.MapProvider = global::GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
            global::GMap.NET.GMaps.Instance.Mode = global::GMap.NET.AccessMode.ServerOnly;
            _mapcontrol.DragButton = MouseButtons.Middle;
            //_mapcontrol.ShowCenter = false;
            _overmarkers = new GMapOverlay("markers");
            _overroutes = new GMapOverlay("routes");
            _overpolys = new GMapOverlay("polygons");
            _mapcontrol.Overlays.Add(_overmarkers);
            _mapcontrol.Overlays.Add(_overroutes);
            _mapcontrol.Overlays.Add(_overpolys);
            _poi_image = (Bitmap)Image.FromFile("camera.png", true);
            _poi_selected_image = (Bitmap)Image.FromFile("camera_selected.png", true);

        }

        public void ToogleCenter()
        {
            _mapcontrol.ShowCenter = !_mapcontrol.ShowCenter;
        }

        public void BuildgMap()
        {
            /*
            switch (index)
            {
                case 0:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
                    break;
                case 1:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleMapProvider.Instance;
                    break;
                case 2:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
                    break;
                case 3:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
                    break;
                case 4:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.ArcGIS_Topo_US_2D_MapProvider.Instance;
                    break;
                case 5:
                    _mapcontrol.MapProvider = global::GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
                    break;
            }
            


            global::GMap.NET.GMaps.Instance.Mode = global::GMap.NET.AccessMode.ServerOnly;
            */
            _markers.Clear();
            _mapcontrol.Overlays.Clear();
            //_mapcontrol.ShowCenter = false;
            _overmarkers = new GMapOverlay("markers");
            _overroutes = new GMapOverlay("routes");
            _overpolys = new GMapOverlay("polygons");
            _mapcontrol.Overlays.Add(_overmarkers);
            _mapcontrol.Overlays.Add(_overroutes);
            _mapcontrol.Overlays.Add(_overpolys);

            _drone_image_notselected = (Bitmap)Image.FromFile("drone.png", true);
            _drone_image_selected = (Bitmap)Image.FromFile("drone_selected.png", true);
            

            // Map POI

            int poicount = _wpg.POICount();
            for (int i = 0; i < poicount; i++)
            {
                GMapMarker marker;
                POIPoints pnt = _wpg.POIPointAt(i);
                string poiname = pnt.name;
                if (i == 0) _mapcontrol.Position = new global::GMap.NET.PointLatLng(pnt.lat, pnt.lon);
                if (pnt.selected)
                    { marker = new GMarkerGoogle(new PointLatLng(pnt.lat, pnt.lon), _poi_selected_image); }
                else
                    { marker = new GMarkerGoogle(new PointLatLng(pnt.lat, pnt.lon), _poi_image); }

                //    GMarkerGoogleType.blue_pushpin);

                //marker.Size = new Size(32, 32);
                marker.Offset = new Point(-16, -16);
                marker.ToolTipText = poiname;
                marker.Tag = poiname;
                marker.IsVisible = pnt.visible;
                marker.IsHitTestVisible = true;
                _overmarkers.Markers.Add(marker);
            }

            // Map Path

            int pathcount = _wpg.PathCount();


            for (int i = 0; i < pathcount; i++)
            {
                Path path = _wpg.PathAt(i);
                string name = path.name;
                bool visible = path.visible;
                LinkedList<WayPoints> wplist = path.waypoints;
                int wpcount = wplist.Count;

                List<PointLatLng> points = new List<PointLatLng>();
                int count = 0;
                foreach (WayPoints wp in wplist)
                {
                    bool selected = wp.selected;
                    points.Add(new PointLatLng(wp.lat, wp.lon));
                    GMapMarker marker;

                    if (selected)
                    {
                        _drone_image = _drone_image_selected;
                        _drone_image = RotateImage(_drone_image_selected, wp.head);
                        marker = new GMarkerGoogle( new PointLatLng(wp.lat, wp.lon), _drone_image);
                        //GMarkerGoogleType.red_pushpin);
                    }
                    else {
                        _drone_image = _drone_image_notselected;
                        _drone_image = RotateImage(_drone_image_notselected, wp.head);
                        marker = new GMarkerGoogle(new PointLatLng(wp.lat, wp.lon),_drone_image);
                        //GMarkerGoogleType.blue_pushpin);
                    }
                    //marker.Size = new Size(64,64);
                    marker.Position = new PointLatLng(wp.lat, wp.lon);
                    marker.Offset = new Point(-16,-16);
                    marker.Tag = Convert.ToString(i) + "." + Convert.ToString(count);
                    marker.IsVisible = visible;
                    marker.ToolTipText = "WP(" + Convert.ToString(count) + ") - Alt:" + Convert.ToString(wp.alt);
                    _overmarkers.Markers.Add(marker);
                    wp.marker = marker;
                    GMAPWPMarker wpmarker = new GMAPWPMarker();
                    wpmarker.path = i;
                    wpmarker.wp = count;
                    wpmarker.marker = marker;
                    wpmarker.selected = wp.selected;
                    _markers.Add(wpmarker);
                    count++;
                }
                GMapRoute route = new GMapRoute(points, name);
                route.Stroke = new Pen(Color.Blue, 2);
                route.Tag = i;
                route.IsVisible = visible;
                route.IsHitTestVisible = true;
                _overroutes.Routes.Add(route);
                //mapcontrol.Overlays.Add(overroutes);
                //mapcontrol.Overlays.Add(markers);
            }

            //mapcontrol.Overlays.Add(markers);

            // Map Polygon

            int polycount = _wpg.ShapeCount();

            for (int i = 0; i < polycount; i++)
            {
                Shape polyshape = _wpg.ShapeAt(i);
                string name = polyshape.name;
                bool visible = polyshape.visible;
                LinkedList<PolyPoint> wplist = polyshape.points;
                int wpcount = wplist.Count;


                List<PointLatLng> points = new List<PointLatLng>();
                foreach (PolyPoint wp in wplist)
                {
                    points.Add(new PointLatLng(wp.lat, wp.lon));
                }
                GMapPolygon poly = new GMapPolygon(points, name);
                if(polyshape.selected) poly.Stroke = new Pen(Color.Red, 1);
                else poly.Stroke = new Pen(Color.Yellow, 1);
                poly.Fill = new SolidBrush(Color.FromArgb(25, Color.Yellow));
                poly.Tag = polyshape.name;
                poly.IsVisible = visible;

                _overpolys.Polygons.Add(poly);

            }

            if (!Form1.Globals.Map_FirstDraw)
            {
                _mapcontrol.Position = Form1.Globals.map_center;
                Form1.Globals.Map_FirstDraw = false;
            }
            _center = _mapcontrol.Position;
        }

        public void ReDrawgMap()
        {
            string lat, lon, poiname;

            PointLatLng center_position = _mapcontrol.Position;
            //_markers.Clear();
            _mapcontrol.Overlays.Clear();
            _mapcontrol.Position = center_position;
            //_mapcontrol.ShowCenter = false;
            _overmarkers = new GMapOverlay("markers");
            _overroutes = new GMapOverlay("routes");
            _overpolys = new GMapOverlay("polygons");

            _mapcontrol.Overlays.Add(_overmarkers);
            _mapcontrol.Overlays.Add(_overroutes);
            _mapcontrol.Overlays.Add(_overpolys);

            // Map POI

            int poicount = _wpg.POICount();
            for (int i = 0; i < poicount; i++)
            {
                GMapMarker marker;
                POIPoints pnt = _wpg.POIPointAt(i);
                poiname = pnt.name;
                //if (i == 0) _mapcontrol.Position = new global::GMap.NET.PointLatLng(pnt.lat, pnt.lon);
                if (pnt.selected)
                { marker = new GMarkerGoogle(new PointLatLng(pnt.lat, pnt.lon), _poi_selected_image); }
                else
                { marker = new GMarkerGoogle(new PointLatLng(pnt.lat, pnt.lon), _poi_image); }
                
                //GMarkerGoogleType.blue_pushpin);
                marker.Offset = new Point(-16, -16);
                marker.ToolTipText = poiname;
                marker.Tag = poiname;
                marker.IsVisible = pnt.visible;
                //marker.IsVisible = true;
                marker.IsHitTestVisible = true;
                _overmarkers.Markers.Add(marker);
            }

            // Map Path

            int pathcount = _wpg.PathCount();


            for (int i = 0; i < pathcount; i++)
            {
                Models.Path path = _wpg.PathAt(i);
                bool path_visible = path.visible;
                string name = path.name;
                LinkedList<WayPoints> wplist = path.waypoints;
                int wpcount = wplist.Count;

                List<PointLatLng> points = new List<PointLatLng>();
                int count = 0;
                foreach (WayPoints wp in wplist)
                {
                    bool selected = wp.selected;
                    points.Add(new PointLatLng(wp.lat, wp.lon));
                    GMapMarker marker;
                    if (selected)
                    {
                        _drone_image = _drone_image_selected;
                        _drone_image = RotateImage(_drone_image_selected, wp.head);
                        marker = new GMarkerGoogle(new PointLatLng(wp.lat, wp.lon), _drone_image);
                        //GMarkerGoogleType.red_pushpin);
                    }
                    else {
                        _drone_image = _drone_image_notselected;
                        _drone_image = RotateImage(_drone_image_notselected, wp.head);
                        marker = new GMarkerGoogle(new PointLatLng(wp.lat, wp.lon), _drone_image);
                        //GMarkerGoogleType.blue_pushpin);
                    }
                    //marker.Size = new Size(64,64);
                    marker.Offset = new Point(-16,-16);
                    marker.Tag = Convert.ToString(i) + "." + Convert.ToString(count);
                    marker.IsVisible = path_visible;
                    marker.ToolTipText = "WP(" + Convert.ToString(count) + ") - Alt:" + Convert.ToString(wp.alt);
                    _overmarkers.Markers.Add(marker);
                    GMAPWPMarker wpmarker = new GMAPWPMarker();
                    wpmarker.path = i;
                    wpmarker.wp = count;
                    wpmarker.marker = marker;
                    wpmarker.selected = wp.selected;
                    _markers.Add(wpmarker);

                    count++;
                }
                GMapRoute route = new GMapRoute(points, name);
                route.Stroke = new Pen(Color.Blue, 2);
                route.Tag = i;
                route.IsVisible = path_visible;
                route.IsHitTestVisible = true;
                _overroutes.Routes.Add(route);
                //gMap.Overlays.Add(overroutes);
                //gMap.Overlays.Add(markers);
            }

            //gMap.Overlays.Add(markers);

            // Map Polygon

            int polycount = _wpg.ShapeCount();

            for (int i = 0; i < polycount; i++)
            {
                Models.Shape polyshape = _wpg.ShapeAt(i);
                string name = polyshape.name;
                LinkedList<PolyPoint> wplist = polyshape.points;
                int wpcount = wplist.Count;


                List<PointLatLng> points = new List<PointLatLng>();
                foreach (PolyPoint wp in wplist)
                {
                    points.Add(new PointLatLng(wp.lat, wp.lon));
                }
                GMapPolygon poly = new GMapPolygon(points, name);
                if (polyshape.selected) poly.Stroke = new Pen(Color.Red, 1);
                else poly.Stroke = new Pen(Color.Yellow, 1);
                poly.Fill = new SolidBrush(Color.FromArgb(25, Color.Yellow));
                poly.Tag = polyshape.name;
                poly.IsVisible = polyshape.visible;
                poly.IsHitTestVisible = true;
                _overpolys.Polygons.Add(poly);

            }
            _mapcontrol.Position = center_position;
        }

        public PointLatLng GetCenter()
        {
            return _center;
        }

        public void SetCenter(double lat, double lon)
        {
            PointLatLng pnt = new PointLatLng(lat, lon);
            _mapcontrol.Position = pnt;
        }

        public void Add_gMapPOI(POIPoints point)
        {
            string pnt_name = point.name;
            //_mapcontrol.Position = new global::GMap.NET.PointLatLng(point.lat, point.lon);
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(point.lat, point.lon),
                GMarkerGoogleType.blue_pushpin);
            marker.ToolTipText = pnt_name;
            marker.Tag = pnt_name;
            marker.IsVisible = false;
            marker.IsHitTestVisible = false;
            _overmarkers.Markers.Add(marker);
        }

        public void Delete_gMapPOI(POIPoints point)
        {
            string pnt_name = point.name;

            int mark_count = _overmarkers.Markers.Count;
            for (int i = 0; i < mark_count; i++)
            {
                GMapMarker marker = _overmarkers.Markers.ElementAt(i);
                string markname = Convert.ToString(marker.Tag);
                if (pnt_name == markname)
                {
                    _overmarkers.Markers.RemoveAt(i);
                    break;
                }
            }
        }


        public void Add_gMapPath(Models.Path path, bool visible)
        {
            string name = path.name;
            int id = path.id;
            LinkedList<WayPoints> wplist = path.waypoints;
            if (wplist != null)
            {
                int wpcount = wplist.Count;

                List<PointLatLng> points = new List<PointLatLng>();
                int count = 0;
                foreach (WayPoints wp in wplist)
                {
                    points.Add(new PointLatLng(wp.lat, wp.lon));
                    _drone_image = _drone_image_notselected;
                    _drone_image = RotateImage(_drone_image_notselected, wp.head);
                    GMapMarker marker = new GMarkerGoogle(
                        new PointLatLng(wp.lat, wp.lon), _drone_image);
                    //GMarkerGoogleType.blue_pushpin);
                    //marker.Size = new Size(64,64);
                    marker.Offset = new Point(-16, -16);
                    marker.Tag = Convert.ToString(id) + "." + Convert.ToString(count);
                    marker.IsVisible = visible;
                    marker.IsHitTestVisible = true;
                    marker.ToolTipText = "WP(" + Convert.ToString(count) + ") - Alt:" + Convert.ToString(wp.alt);
                    _overmarkers.Markers.Add(marker);
                    wp.marker = marker;
                    count++;
                }
                GMapRoute route = new GMapRoute(points, name);
                route.Stroke = new Pen(Color.Blue, 2);
                route.Tag = id;
                route.IsVisible = visible;
                _overroutes.Routes.Add(route);
            }
        }

        public void Delete_gMapPath(Models.Path path)
        {
            string name = path.name;
            int path_id = path.id;
            LinkedList<WayPoints> wplist = path.waypoints;
            int wpcount = wplist.Count;

            // Loop thru Paths

            int route_count = _overroutes.Routes.Count;
            for (int i = 0; i < route_count; i++)
            {
                GMapRoute route = _overroutes.Routes.ElementAt(i);
                int routeid = Convert.ToInt16(route.Tag);
                if (routeid == path_id)
                {
                    _overroutes.Routes.RemoveAt(i);
                    break;
                }
            }
            route_count = _overroutes.Routes.Count;

            // Loop thru Waypoints

            bool found = false;
            int wp_count = _overmarkers.Markers.Count;
            do
            {
                foreach (GMapMarker marker in _overmarkers.Markers)
                {
                    string id_text = Convert.ToString(marker.Tag);
                    int index = id_text.IndexOf(".");
                    if (index != -1)
                    {
                        int indexwp = Convert.ToInt16(id_text.Substring(index + 1));
                        int indexpath = Convert.ToInt16(id_text.Substring(0, index));
                        if (path_id == indexpath)
                        {
                            _overmarkers.Markers.Remove(marker);
                            found = true;
                            break;
                        }
                        else found = false;
                    }
                    else found = false;
                }

            } while (found);


        }


        public void Add_gMapPoly(Models.Shape poly, bool visible)
        {
            string name = poly.name;
            LinkedList<PolyPoint> pntlist = poly.points;
            int pntcount = pntlist.Count;

            List<PointLatLng> points = new List<PointLatLng>();
            foreach (PolyPoint pnt in pntlist)
            {
                points.Add(new PointLatLng(pnt.lat, pnt.lon));
            }
            GMapPolygon gmpoly = new GMapPolygon(points, name);
            gmpoly.Stroke = new Pen(Color.Yellow, 1);
            gmpoly.Fill = new SolidBrush(Color.FromArgb(25, Color.Yellow));
            gmpoly.Tag = poly.name;
            gmpoly.IsVisible = visible;
            _overpolys.Polygons.Add(gmpoly);
        }

        public void Delete_gMapPoly(Models.Shape poly)
        {
            string name = poly.name;

            LinkedList<PolyPoint> polylist = poly.points;
            int polycount = polylist.Count;

            // Loop thru Map Polygons

            int poly_count = _overpolys.Polygons.Count;
            for (int i = 0; i < poly_count; i++)
            {
                GMapPolygon gmpoly = _overpolys.Polygons.ElementAt(i);
                string routename = Convert.ToString(gmpoly.Tag);
                if (routename == name)
                {
                    _overpolys.Polygons.RemoveAt(i);
                    break;
                }
            }
        }



        public void UpdateMarkerPos(int pathid, int wpind, PointLatLng pnt)
        {
            foreach (GMAPWPMarker mark in _markers)
            {
                if (mark.path == pathid & mark.wp == wpind)
                {
                    mark.marker.Position = pnt;
                }
            }
        }

        private Bitmap RotateImage(Bitmap b, double angle)
        {
            //Create a new empty bitmap to hold rotated image.
            int width = b.Width;
            int height = b.Height;
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            int xres = Convert.ToInt16(b.HorizontalResolution);
            int yres = Convert.ToInt16(b.VerticalResolution);
            returnBitmap.SetResolution(200,200);
            //Bitmap returnBitmap = new Bitmap(32, 32);
            //Make a graphics object from the empty bitmap.
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image.
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //float scale = (float)4.0;
            //g.ScaleTransform(scale,scale);
            //Rotate.
            float f_ang = Convert.ToSingle(angle);
            g.RotateTransform(f_ang);           
            //Move image back.
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //Draw passed in image onto graphics object.
            g.DrawImage(b, new Point(0, 0));
            return returnBitmap;
        }

    }
}
