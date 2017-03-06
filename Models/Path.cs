using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Waypoint_Path_Generator.Models
{
    public class Path
    {
        public int id;
        public int internal_id;
        public GMapRoute route_id;
        public string name;
        public string type;
        public LinkedList<WayPoints> waypoints;
        public bool selected;
        public bool visible;
        public CircularGUI circgui;
        public HelicalGUI helixgui;
        public RectanglarGUI rectanglegui;
        public PolygonGridGUI polygridgui;
        public MathGUI mathgui;

        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;


        public void Add_Path(Waypoint_Path_Gen wpg, GMAP gmap, string name, string type, LinkedList<WayPoints> list)
        {
            _wpg = wpg;
            _gmap = gmap;
            int id = wpg.PathCount();
            Models.Path new_path = new Models.Path();
            new_path.id = id;
            new_path.name = name;
            new_path.type = type;
            new_path.selected = false;
            new_path.visible = true;
            new_path.waypoints = list;
            _wpg.AddPath(new_path);
            //Update_GMapTree();
            _gmap.Add_gMapPath(new_path, true);
        }

        public void Add_Empty_Path(Waypoint_Path_Gen wpg, GMAP gmap, string name, string type)
        {
            _wpg = wpg;
            _gmap = gmap;
            int id = wpg.PathCount();
            Models.Path new_path = new Models.Path();
            new_path.id = id;
            new_path.name = name;
            new_path.type = type;
            new_path.selected = false;
            new_path.visible = true;
            new_path.waypoints = null;
            _wpg.AddPath(new_path);
            //Update_GMapTree();
            _gmap.Add_gMapPath(new_path, true);
        }
    }
}
