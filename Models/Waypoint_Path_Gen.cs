using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpKml.Base;
using SharpKml.Engine;
using System.Xml;
using SharpKml.Dom;

using WpgShape = Waypoint_Path_Generator.Models.Shape;
using System.Windows.Forms;

namespace Waypoint_Path_Generator.Models
{

    public class Waypoint_Path_Gen
    {
        static int _internal_id;
        static LinkedList<POIPoints> poi_list;
        static LinkedList<Models.Path> path_list;
        static LinkedList<Models.Action> action_list;
        static LinkedList<WpgShape> shape_list;
        static Options _options;

        public Waypoint_Path_Gen(Options options)
        {
            _internal_id = 990;
            _options = options;
            poi_list = new LinkedList<POIPoints>();
            path_list = new LinkedList<Models.Path>();
            action_list = new LinkedList<Models.Action>();
            shape_list = new LinkedList<WpgShape>();
        }

        private int next_internal_id()
        {
            _internal_id = _internal_id + 10;
            return _internal_id;
        }

        public void AddShape(WpgShape poly)
        {
            poly.internal_id = next_internal_id();
            shape_list.AddLast(poly);
        }

        public void AddShapeId(int id, WpgShape poly)
        {
            poly.internal_id = id;
            if (id > _internal_id) _internal_id = id;
            shape_list.AddLast(poly);
        }

        public void DeleteShape(WpgShape poly)
        {
            shape_list.Remove(poly);
        }

        public Models.Shape ShapeWithId(int id)
        {
            for (int i = 0; i < shape_list.Count(); i++)
            {
                if (shape_list.ElementAt(i).internal_id == id)
                {
                    return shape_list.ElementAt(i);
                }
            }
            return null;
        }

        public Models.Shape ShapeAt(int index)
        {
            return shape_list.ElementAt(index);
        }

        public int ShapeCount()
        {
            return shape_list.Count();
        }

        public void ClearShapes()
        {
            shape_list.Clear();
        }

        public void AddAction(Models.Action action)
        {
            action.internal_id = next_internal_id();
            action_list.AddLast(action);
        }

        public void DeleteAction(string name)
        {
            int count = action_list.Count;
            Action action;
            for (int i = 0; i < count; i++)
            {
                action = action_list.ElementAt(i);
                if (name == action.name)
                {
                    if (!action.locked)
                    { action_list.Remove(action); return; }

                    else { MessageBox.Show("Can not delete a Locked Action."); return; }
                }
            }
        }

        public Action GetAction(string name)
        {
            for (int i = 0; i < action_list.Count; i++)
            {
                if (action_list.ElementAt(i).name == name)
                {
                    return action_list.ElementAt(i);
                }
            }
            return action_list.ElementAt(0);
        }

        public int ActionCount()
        {
            return action_list.Count();
        }

        public Action ActionWithId(int id)
        {
            for (int i = 0; i < action_list.Count; i++)
            {
                if (action_list.ElementAt(i).internal_id == id)
                {
                    return action_list.ElementAt(i);
                }
            }
            return action_list.ElementAt(0);
        }

        public Action ActionAt(int index)
        {
            return action_list.ElementAt(index);
        }

        public void ClearActions()
        {
            action_list.Clear();
        }

        public void ReplacePOI(int index, POIPoints pnt)
        {
            poi_list.ElementAt(index).name = pnt.name;
            poi_list.ElementAt(index).lat = pnt.lat;
            poi_list.ElementAt(index).lon = pnt.lon;
            poi_list.ElementAt(index).alt = pnt.alt;
            poi_list.ElementAt(index).cam_alt = pnt.cam_alt;
            poi_list.ElementAt(index).elev = pnt.elev;
            poi_list.ElementAt(index).selected = pnt.selected;
            poi_list.ElementAt(index).visible = pnt.visible;
            /*
            int count = 0;
            LinkedListNode<POIPoints> node = poi_list.First;
            LinkedListNode<POIPoints> next_node;
            while (node != null)
            {
                next_node = node.Next;
                if (count == index)
                {

                    poi_list.AddBefore(node, pnt);
                    next_node = node.Next;
                    poi_list.Remove(node);
                    break;
                }
                count++;
                node = next_node;
            }
            */
        }

        public void ClearPOI()
        {
            poi_list.Clear();
        }

        public int PathCount()
        {
            return path_list.Count();
        }

        public int POICount()
        {
            return poi_list.Count();
        }

        public void POIPointDeleteAt(int index)
        {
            POIPoints point = POIPointAt(index);
            poi_list.Remove(point);
        }

        //
        //
        // Path Mathods
        //
        //

        public void AddPath(Models.Path path)
        {
            path.internal_id = next_internal_id();
            path_list.AddLast(path);
        }

        public void AddPathId(int id, Models.Path path)
        {
            path.internal_id = id;
            if (id > _internal_id) _internal_id = id;
            path_list.AddLast(path);
        }
        public void DeletePath(Models.Path path)
        {
            path_list.Remove(path);
        }

        public void ReplacePath(int index, Models.Path path)
        {
            path_list.ElementAt(index).id = path.id;
            path_list.ElementAt(index).name = path.name;
            path_list.ElementAt(index).type = path.type;
            path_list.ElementAt(index).waypoints = path.waypoints;
            path_list.ElementAt(index).selected = path.selected;
            path_list.ElementAt(index).visible = path.visible;
        }

        public void ClearPath()
        {
            path_list.Clear();
        }

        public int PathIndex(Path path)
        {
            string name = path.name;
            for (int i = 0; i < path_list.Count(); i++)
            {
                if (name == PathAt(i).name)
                {
                    return i;
                }
            }
            return -1;
        }

        public Models.Path PathIntId(int id)
        {
            for (int i = 0; i < path_list.Count(); i++)
            {
                if (id == PathAt(i).internal_id)
                {
                    return path_list.ElementAt(i);
                }
            }

            return null;
        }

        public Models.Path PathAt(int index)
        {
            return path_list.ElementAt(index);
        }

        public void SetPathPoi(bool setpoi, int poi_id, Path path)
        {
            double poi_lat, poi_lon, poi_alt, poi_elev, poi_camalt;
            LinkedList<WayPoints> wp_list = path.waypoints;
            int wpcnt = wp_list.Count;

            if (setpoi)
            {
                // Point Drone at POI
                // Get POI location

                if (poi_id == 0)
                {
                    MathGUI gui = path.mathgui;
                    poi_lat = gui.lat;
                    poi_lon = gui.lon;
                }
                else {
                    POIPoints poipnt = POIPointID(poi_id);
                    if (poipnt == null) return;
                    poi_lat = poipnt.lat;
                    poi_lon = poipnt.lon;
                    poi_alt = poipnt.alt;
                    poi_elev = poipnt.elev;
                    poi_camalt = poipnt.cam_alt;
                }
                // Loop thorugh waypoints

                for (int i = 0; i < wpcnt; i++)
                {
                    WayPoints wp = wp_list.ElementAt(i);
                    wp.head = GPS.GPS_Bearing(wp.lat, wp.lon, poi_lat, poi_lon);
                }
            }
            else
            // Point Drone at next wp
            {
                for(int i = 0; i < wpcnt - 1; i++)
                {
                    WayPoints wp1 = wp_list.ElementAt(i);
                    WayPoints wp2 = wp_list.ElementAt(i+1);
                    wp1.head = GPS.GPS_Bearing(wp1.lat, wp1.lon, wp2.lat, wp2.lon);
                }
            }
        }

        public void ChangePathWP(int index, LinkedList<WayPoints> wp_list)
        {
            path_list.ElementAt(index).waypoints = wp_list;
        }

        public void ChangePathWPIntId(int intid, LinkedList<WayPoints> wp_list)
        {
            Path path;
            for (int i = 0; i < path_list.Count; i++)
            {
                path = path_list.ElementAt(i);
                if (path.internal_id == intid)
                {
                    path.waypoints = wp_list;
                    return;
                }
            }

            //path_list.ElementAt(index).waypoints = wp_list;
        }
        public void ChangePathName(int index, string name)
        {
            path_list.ElementAt(index).name = name;
        }

        public void SplitPath(bool before)
        {
            Path path;
            Path path1 = new Path();
            Path path2 = new Path();
            string path_name;
            int selected_wp_index = -1;
            int selected_path_index = -1;
            Path selected_path;
            LinkedList<WayPoints> wp_list;

            // Get Selected Waypoint
            for (int i = 0; i < PathCount(); i++)
            {
                path = PathAt(i);
                wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    if (wp_list.ElementAt(j).selected)
                    {
                        selected_wp_index = j;
                        break;
                    }
                }
                if (selected_wp_index != -1)
                {
                    selected_path_index = i;
                    selected_path = PathAt(i);
                    break;
                }

            }
            if (selected_path_index == -1 | selected_wp_index == -1) return;

            // Create two new paths

            path = PathAt(selected_path_index);
            path_name = path.name;
            path1.name = path_name + "-1";
            path2.name = path_name + "-2";
            path1.type = path.type + " - Split";
            path2.type = path.type + " - Split";
            path1.selected = false;
            path2.selected = false;
            path1.visible = true;
            path2.visible = true;

            // Create two Waypoint Lists

            wp_list = path.waypoints;
            LinkedList<WayPoints> wp_list1 = new LinkedList<WayPoints>();
            LinkedList<WayPoints> wp_list2 = new LinkedList<WayPoints>();
            int wp_count = wp_list.Count;
            if (wp_count <= 1) return;

            // Split at first Waypoint

            if (selected_wp_index == 0)
            {
                WayPoints wpnew = new WayPoints();
                wpnew = wp_list.ElementAt(0);
                wp_list1.AddLast(wpnew);
                for (int i = 1; i < wp_count - 1; i++)
                {
                    wpnew = new WayPoints();
                    wpnew = wp_list.ElementAt(i);
                    wp_list2.AddLast(wpnew);
                }
            }

            // Split at last wp

            if (selected_wp_index == wp_count - 1)
            {
                WayPoints wpnew;
                for (int i = 0; i < wp_count - 1; i++)
                {
                    wpnew = new WayPoints();
                    wpnew = wp_list.ElementAt(i);
                    wp_list1.AddLast(wpnew);
                }
                wpnew = new WayPoints();
                wpnew = wp_list.ElementAt(wp_count - 1);
                wp_list2.AddLast(wpnew);
            }

            // Split at Middle

            if (selected_wp_index > 0 & selected_wp_index < wp_count - 1)
            {
                WayPoints wpnew;
                if (before)
                {
                    for (int i = 0; i < selected_wp_index; i++)
                    {
                        wpnew = new WayPoints();
                        wpnew = wp_list.ElementAt(i);
                        wp_list1.AddLast(wpnew);
                    }
                    for (int i = selected_wp_index; i < wp_count; i++)
                    {
                        wpnew = new WayPoints();
                        wpnew = wp_list.ElementAt(i);
                        wp_list2.AddLast(wpnew);
                    }
                }
                else
                {
                    for (int i = 0; i <= selected_wp_index; i++)
                    {
                        wpnew = new WayPoints();
                        wpnew = wp_list.ElementAt(i);
                        wp_list1.AddLast(wpnew);
                    }
                    for (int i = selected_wp_index + 1; i < wp_count; i++)
                    {
                        wpnew = new WayPoints();
                        wpnew = wp_list.ElementAt(i);
                        wp_list2.AddLast(wpnew);
                    }
                }
            }
            // Add Waypoints to paths

            path1.waypoints = wp_list1;
            path2.waypoints = wp_list2;

            // Delete original Path

            DeletePath(path);

            // Add two new paths

            AddPath(path1);
            AddPath(path2);


        }

        public void ReversePathWP(int i)
        {
            // Build new wp list
            Models.Path path = path_list.ElementAt(i);
            LinkedList<WayPoints> wplist = path.waypoints;
            LinkedList<WayPoints> wpnew = new LinkedList<WayPoints>();
            int count = wplist.Count;
            int index = count - 1;
            while (index >= 0)
            {
                WayPoints wp = wplist.ElementAt(index);
                WayPoints wp_new = new WayPoints();
                wp_new = wp;
                wpnew.AddLast(wp_new);
                index--;
            }
            // Build New Path Element
            Models.Path newpath = new Models.Path();
            newpath.name = path.name;
            newpath.type = path.type;
            newpath.selected = path.selected;
            newpath.visible = path.visible;
            newpath.waypoints = wpnew;
            // Now insert new before the old and delete the old
            LinkedListNode<Models.Path> node = path_list.First;
            LinkedListNode<Models.Path> next_node;
            count = 0;
            while (node != null)
            {
                next_node = node.Next;
                if (count == i)
                {
                    path_list.AddBefore(node, newpath);
                    next_node = node.Next;
                    path_list.Remove(path);
                }
                count++;
                node = next_node;
            }

        }

        public void POIReplace(int index, POIPoints newpoint)
        {
            poi_list.ElementAt(index).name = newpoint.name;
            poi_list.ElementAt(index).lat = newpoint.lat;
            poi_list.ElementAt(index).lon = newpoint.lon;
            poi_list.ElementAt(index).alt = newpoint.alt;
            poi_list.ElementAt(index).elev = newpoint.elev;
            poi_list.ElementAt(index).cam_alt = newpoint.cam_alt;
            poi_list.ElementAt(index).selected = newpoint.selected;
            poi_list.ElementAt(index).visible = newpoint.visible;
        }

        public POIPoints POIPointName(string name)
        {
            for (int i = 0; i < POICount(); i++)
            {
                POIPoints poipnt = POIPointAt(i);
                if (poipnt.name == name)
                {
                    return poipnt;
                }
            }
            return null;
        }

        public POIPoints POIPointID(int poi_id)
        {
            for (int i = 0; i < POICount(); i++)
            {
                POIPoints poipnt = POIPointAt(i);
                if (poipnt.internal_id == poi_id)
                {
                    return poipnt;
                }
            }
            return null;
        }

        public POIPoints POIPointAt(int index)
        {
            return poi_list.ElementAt(index);
        }

        public void AddPOI(POIPoints poipoint)
        {
            poipoint.internal_id = next_internal_id();
            poi_list.AddLast(poipoint);
        }

        public void AddPOIId(int id, POIPoints poipoint)
        {
            poipoint.internal_id = id;
            if (id > _internal_id) _internal_id = id;
            poi_list.AddLast(poipoint);
        }

        public void SavePOI()
        {
            // Save gps_path_creator.poi
            string name, out_string;
            double lat, lon, alt, elev, cam_alt;

            // Delete file if it exists
            if (File.Exists("C:waypoint_path_generator.poi")) File.Delete("waypoint_path_generator.poi");

            StreamWriter writer = new StreamWriter("waypoint_path_generator.poi");

            for (int i = 0; i < poi_list.Count; i++)
            {
                name = poi_list.ElementAt(i).name;
                lat = poi_list.ElementAt(i).lat;
                lon = poi_list.ElementAt(i).lon;
                elev = poi_list.ElementAt(i).elev;
                alt = poi_list.ElementAt(i).alt;
                cam_alt = poi_list.ElementAt(i).cam_alt;
                out_string = name + ", " + Convert.ToString(lat) + ", " + Convert.ToString(lon) + ", " + Convert.ToString(elev);
                out_string = out_string + ", " + Convert.ToString(alt) + ", " + Convert.ToString(cam_alt);
                writer.WriteLine(out_string);
            }
            writer.Close();
        }


        public void WriteXml(string file_name)
        {
            string name;
            double lat, lon, alt, elev, cam_alt, head, rotdir, gimble_pitch, curvesize;
            int gimble_mode, int_id;
            int[,] actions;
            int action_id;
            Models.Action action;

            // Generate XML

            if (File.Exists(file_name)) File.Delete(file_name);

            using (XmlWriter xml_writer = XmlWriter.Create(file_name))
            {
                xml_writer.WriteStartDocument();
                xml_writer.WriteStartElement("WPG");


                // Write Configuration
                xml_writer.WriteStartElement("Config"); // Start of Config
                                                        //MessageBox.Show(Globals.default_location);
                xml_writer.WriteElementString("Default_Location", Form1.Globals.default_location);
                xml_writer.WriteElementString("Default_Altitude", Convert.ToString(_options.def_altitude));
                xml_writer.WriteElementString("Out_MissionHub_Path", _options.def_csv_path);
                xml_writer.WriteElementString("Out_MissionPlanner_Path", _options.def_mp_path);
                xml_writer.WriteElementString("Out_KML_Path", _options.def_kml_path);
                xml_writer.WriteElementString("Cam_Hor_Angle", Form1.Globals.default_cam_hor_ang);
                xml_writer.WriteElementString("Cam_Ver_Angle", Form1.Globals.default_cam_ver_ang);
                xml_writer.WriteElementString("Cam_Hor_OverLap", Form1.Globals.default_cam_hor_over);
                xml_writer.WriteElementString("Cam_Ver_OverLap", Form1.Globals.default_cam_ver_over);
                xml_writer.WriteElementString("Earth_Radius", Convert.ToString(_options.earth_radius));
                xml_writer.WriteEndElement(); // End of Config

                // Write POI

                for (int i = 0; i < poi_list.Count; i++)
                {
                    xml_writer.WriteStartElement("POI"); // Start of POI
                    name = poi_list.ElementAt(i).name;
                    int_id = poi_list.ElementAt(i).internal_id;
                    lat = poi_list.ElementAt(i).lat;
                    lon = poi_list.ElementAt(i).lon;
                    elev = poi_list.ElementAt(i).elev;
                    alt = poi_list.ElementAt(i).alt;
                    cam_alt = poi_list.ElementAt(i).cam_alt;
                    xml_writer.WriteElementString("Name", name);
                    xml_writer.WriteElementString("InternalId", Convert.ToString(int_id));
                    xml_writer.WriteElementString("Lat", Convert.ToString(lat));
                    xml_writer.WriteElementString("Lon", Convert.ToString(lon));
                    xml_writer.WriteElementString("Elev", Convert.ToString(elev));
                    xml_writer.WriteElementString("Alt", Convert.ToString(alt));
                    xml_writer.WriteElementString("Cam_Alt", Convert.ToString(cam_alt));
                    xml_writer.WriteEndElement(); // End of POI
                }

                // Write Actions

                xml_writer.WriteStartElement("WP_Action_List"); // Start of Action_List

                for (int i = 0; i < action_list.Count; i++)
                {
                    action = action_list.ElementAt(i);
                    name = action.name;
                    actions = action.actions;
                    string action_id_str = Convert.ToString(action.internal_id);
                    xml_writer.WriteStartElement("WP_Action"); // Start of Action
                    xml_writer.WriteElementString("Name", name);
                    xml_writer.WriteElementString("IntID", action_id_str);
                    if (action.locked) xml_writer.WriteElementString("Locked", "true");
                    else xml_writer.WriteElementString("Locked", "false");

                    xml_writer.WriteStartElement("Action_List"); // Start of Element Action List
                    for (int k = 0; k < 15; k++)
                    {
                        xml_writer.WriteStartElement("Action"); // Start of Action
                        xml_writer.WriteElementString("Type", Convert.ToString(actions[k, 0]));
                        xml_writer.WriteElementString("Param", Convert.ToString(actions[k, 1]));
                        xml_writer.WriteEndElement(); // End of Action
                    }
                    xml_writer.WriteEndElement(); // End of Element Action List
                    xml_writer.WriteEndElement(); // End of Action
                }
                xml_writer.WriteEndElement(); // End of Action_List

                // Write Polygons

                int shape_count = ShapeCount();
                Models.Shape shape;
                PolyPoint point;

                if (shape_count > 0)
                {
                    xml_writer.WriteStartElement("Polygon_List"); // Start of Polygon_List
                    for (int i = 0; i < shape_list.Count(); i++)
                    {
                        shape = shape_list.ElementAt(i);
                        int_id = shape.internal_id;
                        xml_writer.WriteStartElement("Polygon"); // Start of Polygon
                        xml_writer.WriteElementString("Name", shape.name);
                        xml_writer.WriteElementString("InternalId", Convert.ToString(int_id));
                        LinkedList<PolyPoint> points = shape.points;
                        xml_writer.WriteStartElement("Vertex_List"); // Start of Vertex List
                        for (int j = 0; j < points.Count; j++)
                        {
                            point = points.ElementAt(j);
                            xml_writer.WriteStartElement("Vertex"); // Start of Vertex
                            xml_writer.WriteElementString("Lat", Convert.ToString(point.lat));
                            xml_writer.WriteElementString("Lon", Convert.ToString(point.lon));
                            xml_writer.WriteElementString("Alt", Convert.ToString(point.alt));
                            xml_writer.WriteEndElement(); // End of Vertex
                        }
                        xml_writer.WriteEndElement(); // End of Vertex_List
                        xml_writer.WriteEndElement(); // End of Polygon
                    }
                    xml_writer.WriteEndElement(); // End of Polygon_List
                }

                // Write Paths

                for (int i = 0; i < path_list.Count; i++)
                {
                    xml_writer.WriteStartElement("Path"); // Start of Path
                    Path path = path_list.ElementAt(i);
                    int_id = path.internal_id;
                    name = path.name;
                    string path_type = path.type;
                    xml_writer.WriteElementString("Name", name);
                    xml_writer.WriteElementString("Type", path_type);
                    xml_writer.WriteElementString("InternalId", Convert.ToString(int_id));

                    // Path GUI Configuration

                    if (path_type == "Circular")
                    {
                        CircularGUI gui = path.circgui;
                        xml_writer.WriteStartElement("GUI"); // Start of Gui
                        xml_writer.WriteElementString("CW", Convert.ToString(gui.CW));
                        xml_writer.WriteElementString("Name", gui.name);
                        xml_writer.WriteElementString("Lat", Convert.ToString(gui.lat));
                        xml_writer.WriteElementString("Lon", Convert.ToString(gui.lon));
                        xml_writer.WriteElementString("Altitude", Convert.ToString(gui.altitude));
                        xml_writer.WriteElementString("Radius", Convert.ToString(gui.radius));
                        xml_writer.WriteElementString("NumPoints", Convert.ToString(gui.numpoints));
                        xml_writer.WriteElementString("FullCircle", Convert.ToString(gui.fullcirc));
                        xml_writer.WriteElementString("StartAngle", Convert.ToString(gui.start_angle));
                        xml_writer.WriteElementString("CircleSpan", Convert.ToString(gui.circ_span));
                        xml_writer.WriteElementString("StartEnd", Convert.ToString(gui.startend));
                        xml_writer.WriteElementString("POIMode", Convert.ToString(gui.poimode));
                        xml_writer.WriteElementString("POIName", gui.poiname);
                        xml_writer.WriteEndElement(); // End of GUI
                    }

                    if (path_type == "Helical")
                    {
                        HelicalGUI gui = path.helixgui;
                        xml_writer.WriteStartElement("GUI"); // Start of Gui
                        xml_writer.WriteElementString("CW", Convert.ToString(gui.CW));
                        xml_writer.WriteElementString("Name", gui.name);
                        xml_writer.WriteElementString("Lat", Convert.ToString(gui.lat));
                        xml_writer.WriteElementString("Lon", Convert.ToString(gui.lon));
                        xml_writer.WriteElementString("StartAltitude", Convert.ToString(gui.start_alt));
                        xml_writer.WriteElementString("EndAltitude", Convert.ToString(gui.end_alt));
                        xml_writer.WriteElementString("StartRadius", Convert.ToString(gui.start_rad));
                        xml_writer.WriteElementString("EndRadius", Convert.ToString(gui.end_rad));
                        xml_writer.WriteElementString("StartAngle", Convert.ToString(gui.start_angle));
                        xml_writer.WriteElementString("HelixSpan", Convert.ToString(gui.helix_span));
                        xml_writer.WriteElementString("NumPoints", Convert.ToString(gui.num_points));
                        xml_writer.WriteElementString("StartEnd", Convert.ToString(gui.startend));
                        xml_writer.WriteElementString("POIMode", Convert.ToString(gui.poimode));
                        xml_writer.WriteElementString("POIName", gui.poiname);
                        xml_writer.WriteEndElement(); // End of GUI
                    }

                    if (path_type == "Rectangular")
                    {
                        RectanglarGUI gui = path.rectanglegui;
                        xml_writer.WriteStartElement("GUI"); // Start of Gui
                        xml_writer.WriteElementString("Name", gui.name);
                        xml_writer.WriteElementString("Lat", Convert.ToString(gui.lat));
                        xml_writer.WriteElementString("Lon", Convert.ToString(gui.lon));
                        xml_writer.WriteElementString("Video", Convert.ToString(gui.video));
                        xml_writer.WriteElementString("StartEnd", Convert.ToString(gui.startend));
                        xml_writer.WriteElementString("Altitude", Convert.ToString(gui.altitude));
                        xml_writer.WriteElementString("Heading", Convert.ToString(gui.heading));
                        xml_writer.WriteElementString("Length", Convert.ToString(gui.length));
                        xml_writer.WriteElementString("Width", Convert.ToString(gui.width));
                        xml_writer.WriteElementString("SinglePath", Convert.ToString(gui.single));
                        xml_writer.WriteElementString("POIMode", Convert.ToString(gui.poimode));
                        xml_writer.WriteElementString("POIName", gui.poiname);
                        xml_writer.WriteEndElement(); // End of GUI
                    }

                    if (path_type == "Polygon")
                    {
                        PolygonGridGUI gui = path.polygridgui;
                        xml_writer.WriteStartElement("GUI"); // Start of Gui
                        xml_writer.WriteElementString("Name", gui.name);
                        xml_writer.WriteElementString("Video", Convert.ToString(gui.video));
                        xml_writer.WriteElementString("StartEnd", Convert.ToString(gui.startend));
                        xml_writer.WriteElementString("Altitude", Convert.ToString(gui.altitude));
                        xml_writer.WriteElementString("Heading", Convert.ToString(gui.heading));
                        xml_writer.WriteElementString("PolyName", gui.polyname);
                        xml_writer.WriteElementString("Poly_IntID", Convert.ToString(gui.poly_internal_id));
                        xml_writer.WriteEndElement(); // End of GUI
                    }

                    if (path_type == "Mathamatical")
                    {
                        MathGUI gui = path.mathgui;
                        xml_writer.WriteStartElement("GUI"); // Start of Gui
                        xml_writer.WriteElementString("Name", gui.name);
                        xml_writer.WriteElementString("PathType", gui.path_type);
                        xml_writer.WriteElementString("Size", Convert.ToString(gui.size));
                        xml_writer.WriteElementString("RotAngle", Convert.ToString(gui.rot_angle));
                        xml_writer.WriteElementString("StartAngle", Convert.ToString(gui.start_angle));
                        xml_writer.WriteElementString("Radius", Convert.ToString(gui.radius));
                        xml_writer.WriteElementString("Altitude", Convert.ToString(gui.altitude));
                        xml_writer.WriteElementString("NumPoints", Convert.ToString(gui.numpnts));
                        xml_writer.WriteElementString("ScaleX", Convert.ToString(gui.scalex));
                        xml_writer.WriteElementString("ScaleY", Convert.ToString(gui.scaley));
                        xml_writer.WriteElementString("Lat", Convert.ToString(gui.lat));
                        xml_writer.WriteElementString("Lon", Convert.ToString(gui.lon));
                        xml_writer.WriteEndElement(); // End of GUI
                    }

                    //xml_writer.WriteStartElement("Waypoint_List"); // Start of Waypoint List
                    LinkedList<WayPoints> waypoint = path_list.ElementAt(i).waypoints;
                    for (int j = 0; j < waypoint.Count; j++)
                    {
                        xml_writer.WriteStartElement("Waypoint"); // Start of Waypoint
                        lat = waypoint.ElementAt(j).lat;
                        lon = waypoint.ElementAt(j).lon;
                        alt = waypoint.ElementAt(j).alt;
                        head = waypoint.ElementAt(j).head;
                        rotdir = waypoint.ElementAt(j).rotationdir;
                        curvesize = waypoint.ElementAt(j).curvesize;
                        gimble_mode = waypoint.ElementAt(j).gimblemode;
                        gimble_pitch = waypoint.ElementAt(j).gimblepitch;
                        action_id = waypoint.ElementAt(j).action_id;
                        xml_writer.WriteElementString("Lat", Convert.ToString(lat));
                        xml_writer.WriteElementString("Lon", Convert.ToString(lon));
                        xml_writer.WriteElementString("Alt", Convert.ToString(alt));
                        xml_writer.WriteElementString("Heading", Convert.ToString(head));
                        xml_writer.WriteElementString("CurveSize", Convert.ToString(curvesize));
                        xml_writer.WriteElementString("RotationDir", Convert.ToString(curvesize));
                        xml_writer.WriteElementString("GimbleMode", Convert.ToString(gimble_mode));
                        xml_writer.WriteElementString("GimblePitch", Convert.ToString(gimble_pitch));
                        xml_writer.WriteElementString("ActionID", Convert.ToString(action_id));

                        /*
                        for (int k = 0; k < 15; k++)
                        {
                            xml_writer.WriteStartElement("Action"); // Start of Action
                            xml_writer.WriteElementString("Type", Convert.ToString(actions[k, 0]));
                            xml_writer.WriteElementString("Param", Convert.ToString(actions[k, 1]));
                            xml_writer.WriteEndElement(); // End of Action
                        }
                        */

                        xml_writer.WriteEndElement(); // End of Waypoint
                    }

                    //xml_writer.WriteEndElement(); // End of Waypoints
                    xml_writer.WriteEndElement(); // End of Path
                }

                xml_writer.WriteEndElement(); // End of WPG
                xml_writer.WriteEndDocument();
            }

        }

        public void ReadXml_Config(string file_name)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file_name);
            XmlNodeList configlist = xmlDoc.DocumentElement.SelectNodes("/WPG/Config");
            foreach (XmlNode node in configlist)
            {
                Form1.Globals.default_location = node.SelectSingleNode("Default_Location").InnerText;
                _options.def_altitude = Convert.ToDouble(node.SelectSingleNode("Default_Altitude").InnerText);
                _options.def_csv_path = node.SelectSingleNode("Out_MissionHub_Path").InnerText;
                _options.def_mp_path = node.SelectSingleNode("Out_MissionPlanner_Path").InnerText;
                _options.def_kml_path = node.SelectSingleNode("Out_KML_Path").InnerText;
                Form1.Globals.default_cam_hor_ang = node.SelectSingleNode("Cam_Hor_Angle").InnerText;
                Form1.Globals.default_cam_ver_ang = node.SelectSingleNode("Cam_Ver_Angle").InnerText;
                _options.focal_angle_hor = Convert.ToDouble(Form1.Globals.default_cam_hor_ang);
                _options.focal_angle_ver = Convert.ToDouble(Form1.Globals.default_cam_ver_ang);
                Form1.Globals.default_cam_hor_over = node.SelectSingleNode("Cam_Hor_OverLap").InnerText;
                Form1.Globals.default_cam_ver_over = node.SelectSingleNode("Cam_Ver_OverLap").InnerText;
                _options.hor_overlap_percent = Convert.ToDouble(Form1.Globals.default_cam_hor_over);
                _options.ver_overlap_percent = Convert.ToDouble(Form1.Globals.default_cam_ver_over);
                _options.earth_radius = Convert.ToDouble(node.SelectSingleNode("Earth_Radius").InnerText);
            }
        }

        public void ReadXml_Polygon(string file_name)
        {
            string lat, lon, alt;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file_name);

            string dialog_text = "XMLReadPath\n\n";

            // Get Polygons

            XmlNodeList shapelist = xmlDoc.DocumentElement.SelectNodes("/WPG/Polygon_List/Polygon");
            int shape_count = shapelist.Count;
            dialog_text = dialog_text + "Shape Count : " + shape_count + "\n";
            ClearShapes();
            foreach (XmlNode shape_node in shapelist)
            {
                Models.Shape shape = new Models.Shape();
                shape.name = shape_node.SelectSingleNode("Name").InnerText;
                shape.internal_id = Convert.ToInt16(shape_node.SelectSingleNode("InternalId").InnerText);
                dialog_text = dialog_text + "Shape : " + shape.name + "\n";
                LinkedList<PolyPoint> polypoints = new LinkedList<PolyPoint>();
                XmlNodeList vertex_nodes = shape_node.SelectNodes("./Vertex_List/Vertex");
                dialog_text = dialog_text + "Vertex Count: " + Convert.ToString(vertex_nodes.Count) + "\n";

                foreach (XmlNode vertex_node in vertex_nodes)
                {
                    lat = vertex_node.SelectSingleNode("Lat").InnerText;
                    lon = vertex_node.SelectSingleNode("Lon").InnerText;
                    alt = vertex_node.SelectSingleNode("Alt").InnerText;
                    PolyPoint point = new PolyPoint();
                    point.lat = Convert.ToDouble(lat);
                    point.lon = Convert.ToDouble(lon);
                    point.alt = Convert.ToDouble(alt);
                    polypoints.AddLast(point);
                    dialog_text = dialog_text + "\tVertex : " + lat + ", " + lon + ", " + alt + "\n";
                }

                shape.points = polypoints;
                AddShapeId(shape.internal_id, shape);
                //MessageBox.Show(Convert.ToString(polypoints.Count), "xxx");
            }

        }

        public void ReadXml_Path(string file_name)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file_name);

            string dialog_text = "XMLReadPath\n\n";


            // Get Paths

            XmlNodeList pathlist = xmlDoc.DocumentElement.SelectNodes("/WPG/Path");
            int path_count = pathlist.Count;
            dialog_text = dialog_text + "Path Count : " + path_count + "\n";

            ClearPath();

            foreach (XmlNode path_node in pathlist)
            {

                Models.Path path = new Models.Path();

                path.name = path_node.SelectSingleNode("Name").InnerText;
                path.type = path_node.SelectSingleNode("Type").InnerText;
                path.internal_id = Convert.ToInt16(path_node.SelectSingleNode("InternalId").InnerText);

                if (path.type == "Circular")
                {
                    CircularGUI gui = new CircularGUI();
                    XmlNodeList GUI_node = path_node.SelectNodes("./GUI");
                    foreach (XmlNode node in GUI_node)
                    {
                        gui.CW = Convert.ToBoolean(node.SelectSingleNode("CW").InnerText);
                        gui.name = node.SelectSingleNode("Name").InnerText;
                        gui.lat = Convert.ToDouble(node.SelectSingleNode("Lat").InnerText);
                        gui.lon = Convert.ToDouble(node.SelectSingleNode("Lon").InnerText);
                        gui.altitude = Convert.ToDouble(node.SelectSingleNode("Altitude").InnerText);
                        gui.radius = Convert.ToDouble(node.SelectSingleNode("Radius").InnerText);
                        gui.numpoints = Convert.ToInt16(node.SelectSingleNode("NumPoints").InnerText);
                        gui.fullcirc = Convert.ToBoolean(node.SelectSingleNode("FullCircle").InnerText);
                        gui.start_angle = Convert.ToDouble(node.SelectSingleNode("StartAngle").InnerText);
                        gui.circ_span = Convert.ToDouble(node.SelectSingleNode("CircleSpan").InnerText);
                        gui.startend = Convert.ToBoolean(node.SelectSingleNode("StartEnd").InnerText);
                        gui.poimode = Convert.ToBoolean(node.SelectSingleNode("POIMode").InnerText);
                        gui.poiname = node.SelectSingleNode("POIName").InnerText;
                    }
                    path.circgui = gui;
                }

                if (path.type == "Helical")
                {
                    HelicalGUI gui = new HelicalGUI();
                    XmlNodeList GUI_node = path_node.SelectNodes("./GUI");
                    foreach (XmlNode node in GUI_node)
                    {
                        gui.CW = Convert.ToBoolean(node.SelectSingleNode("CW").InnerText);
                        gui.name = node.SelectSingleNode("Name").InnerText;
                        gui.lat = Convert.ToDouble(node.SelectSingleNode("Lat").InnerText);
                        gui.lon = Convert.ToDouble(node.SelectSingleNode("Lon").InnerText);
                        gui.start_alt = Convert.ToDouble(node.SelectSingleNode("StartAltitude").InnerText);
                        gui.end_alt = Convert.ToDouble(node.SelectSingleNode("EndAltitude").InnerText);
                        gui.start_rad = Convert.ToDouble(node.SelectSingleNode("StartRadius").InnerText);
                        gui.end_rad = Convert.ToDouble(node.SelectSingleNode("EndRadius").InnerText);
                        gui.start_angle = Convert.ToDouble(node.SelectSingleNode("StartAngle").InnerText);
                        gui.helix_span = Convert.ToDouble(node.SelectSingleNode("HelixSpan").InnerText);
                        gui.num_points = Convert.ToInt16(node.SelectSingleNode("NumPoints").InnerText);
                        gui.startend = Convert.ToBoolean(node.SelectSingleNode("StartEnd").InnerText);
                        gui.poimode = Convert.ToBoolean(node.SelectSingleNode("POIMode").InnerText);
                        gui.poiname = node.SelectSingleNode("POIName").InnerText;
                    }
                    path.helixgui = gui;
                }

                if (path.type == "Rectangular")
                {
                    RectanglarGUI gui = new RectanglarGUI();
                    XmlNodeList GUI_node = path_node.SelectNodes("./GUI");
                    foreach (XmlNode node in GUI_node)
                    {
                        gui.name = node.SelectSingleNode("Name").InnerText;
                        gui.lat = Convert.ToDouble(node.SelectSingleNode("Lat").InnerText);
                        gui.lon = Convert.ToDouble(node.SelectSingleNode("Lon").InnerText);
                        gui.video = Convert.ToBoolean(node.SelectSingleNode("Video").InnerText);
                        gui.startend = Convert.ToBoolean(node.SelectSingleNode("StartEnd").InnerText);
                        gui.altitude = Convert.ToDouble(node.SelectSingleNode("Altitude").InnerText);
                        gui.heading = Convert.ToDouble(node.SelectSingleNode("Heading").InnerText);
                        gui.length = Convert.ToDouble(node.SelectSingleNode("Length").InnerText);
                        gui.width = Convert.ToDouble(node.SelectSingleNode("Width").InnerText);
                        gui.single = Convert.ToBoolean(node.SelectSingleNode("SinglePath").InnerText);
                        gui.poimode = Convert.ToBoolean(node.SelectSingleNode("POIMode").InnerText);
                        gui.poiname = node.SelectSingleNode("POIName").InnerText;
                    }
                    path.rectanglegui = gui;
                }

                if (path.type == "Polygon")
                {
                    PolygonGridGUI gui = new PolygonGridGUI();
                    XmlNodeList GUI_node = path_node.SelectNodes("./GUI");
                    foreach (XmlNode node in GUI_node)
                    {
                        gui.name = node.SelectSingleNode("Name").InnerText;
                        gui.video = Convert.ToBoolean(node.SelectSingleNode("Video").InnerText);
                        gui.startend = Convert.ToBoolean(node.SelectSingleNode("StartEnd").InnerText);
                        gui.altitude = Convert.ToDouble(node.SelectSingleNode("Altitude").InnerText);
                        gui.heading = Convert.ToDouble(node.SelectSingleNode("Heading").InnerText);
                        gui.polyname = node.SelectSingleNode("PolyName").InnerText;
                        gui.poly_internal_id = Convert.ToInt16(node.SelectSingleNode("Poly_IntID").InnerText);
                    }
                    path.polygridgui = gui;
                }

                if (path.type == "Mathamatical")
                {
                    MathGUI gui = new MathGUI();
                    XmlNodeList GUI_node = path_node.SelectNodes("./GUI");
                    foreach (XmlNode node in GUI_node)
                    {
                        gui.name = node.SelectSingleNode("Name").InnerText;
                        gui.path_type = node.SelectSingleNode("PathType").InnerText;
                        gui.size = Convert.ToDouble(node.SelectSingleNode("Size").InnerText);
                        gui.rot_angle = Convert.ToDouble(node.SelectSingleNode("RotAngle").InnerText);
                        gui.start_angle = Convert.ToDouble(node.SelectSingleNode("StartAngle").InnerText);
                        gui.radius = Convert.ToDouble(node.SelectSingleNode("Radius").InnerText);
                        gui.altitude = Convert.ToDouble(node.SelectSingleNode("Altitude").InnerText);
                        gui.numpnts = Convert.ToInt16(node.SelectSingleNode("NumPoints").InnerText);
                        gui.scalex = Convert.ToDouble(node.SelectSingleNode("ScaleX").InnerText);
                        gui.scaley = Convert.ToDouble(node.SelectSingleNode("ScaleY").InnerText);
                        gui.lat = Convert.ToDouble(node.SelectSingleNode("Lat").InnerText);
                        gui.lon = Convert.ToDouble(node.SelectSingleNode("Lon").InnerText);
                    }
                    path.mathgui = gui;
                }

                path.selected = false;
                path.visible = false;
                LinkedList<WayPoints> way_list = new LinkedList<WayPoints>();

                XmlNodeList way_nodes = path_node.SelectNodes("./Waypoint");
                int way_count = way_nodes.Count;

                dialog_text = dialog_text + "Path : " + path.name + "Type : " + path.type + "\n";
                dialog_text = dialog_text + "Waypoint Count : " + Convert.ToString(way_count) + "\n";
                //MessageBox.Show(dialog_text, "xxx");
                way_count = 0;
                foreach (XmlNode wp_node in way_nodes)
                {
                    WayPoints waypoint = new WayPoints();
                    waypoint.lat = Convert.ToDouble(wp_node.SelectSingleNode("Lat").InnerText);
                    waypoint.lon = Convert.ToDouble(wp_node.SelectSingleNode("Lon").InnerText);
                    waypoint.alt = Convert.ToDouble(wp_node.SelectSingleNode("Alt").InnerText);
                    waypoint.head = Convert.ToDouble(wp_node.SelectSingleNode("Heading").InnerText);
                    waypoint.curvesize = Convert.ToDouble(wp_node.SelectSingleNode("CurveSize").InnerText);
                    waypoint.rotationdir = Convert.ToDouble(wp_node.SelectSingleNode("RotationDir").InnerText);
                    waypoint.gimblemode = Convert.ToInt16(wp_node.SelectSingleNode("GimbleMode").InnerText);
                    waypoint.gimblepitch = Convert.ToDouble(wp_node.SelectSingleNode("GimblePitch").InnerText);
                    waypoint.action_id = Convert.ToInt16(wp_node.SelectSingleNode("ActionID").InnerText);

                    way_list.AddLast(waypoint);
                    way_count++;
                }
                //MessageBox.Show(dialog_text, "xxx");
                path.waypoints = way_list;
                AddPathId(path.internal_id, path);
                path_count++;
            }

        }

        public void ReadXml_Actions(string file_name)
        {
            ClearActions();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file_name);
            XmlNodeList nodelist = xmlDoc.DocumentElement.SelectNodes("/WPG/WP_Action_List/WP_Action");

            foreach (XmlNode top_action_node in nodelist)
            {
                //string text;
                Models.Action action = new Models.Action();
                action.name = top_action_node.SelectSingleNode("Name").InnerText;
                action.internal_id = Convert.ToInt16(top_action_node.SelectSingleNode("IntID").InnerText);
                action.locked = Convert.ToBoolean(top_action_node.SelectSingleNode("Locked").InnerText);
                //text = "Name : " + action.name + "\n\n";
                XmlNodeList action_list = top_action_node.SelectNodes("./Action_List/Action");
                int[,] array = new int[15, 2];
                int count = 0;

                foreach (XmlNode xmlaction in action_list)
                {
                    array[count, 0] = Convert.ToInt16(xmlaction.SelectSingleNode("Type").InnerText);
                    array[count, 1] = Convert.ToInt16(xmlaction.SelectSingleNode("Param").InnerText);
                    //text = text + "Action (" + Convert.ToString(count) + ")\n";
                    //text = text + "\tType : " + Convert.ToString(array[count, 0])+ "\n";
                    //text = text + "\tParam"+ Convert.ToString(array[count, 1]) + "\n";
                    //MessageBox.Show(text, "xxx");
                    count++;
                }
                action.actions = array;
                AddAction(action);
            }

        }



        public void ReadXml_POI(string file_name)
        {
            ClearPOI();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(file_name);
            XmlNodeList nodelist = xmlDoc.DocumentElement.SelectNodes("/WPG/POI");

            foreach (XmlNode node in nodelist)
            {
                POIPoints point = new POIPoints();
                point.name = node.SelectSingleNode("Name").InnerText;
                point.internal_id = Convert.ToInt16(node.SelectSingleNode("InternalId").InnerText);
                point.lat = Convert.ToDouble(node.SelectSingleNode("Lat").InnerText);
                point.lon = Convert.ToDouble(node.SelectSingleNode("Lon").InnerText);
                point.elev = Convert.ToDouble(node.SelectSingleNode("Elev").InnerText);
                point.alt = Convert.ToDouble(node.SelectSingleNode("Alt").InnerText);
                point.cam_alt = Convert.ToDouble(node.SelectSingleNode("Cam_Alt").InnerText);
                point.selected = false;
                point.visible = false;
                AddPOIId(point.internal_id, point);
            }
        }

        public void ReadPOI()
        {
            // Read POI File

            ClearPOI();
            if (File.Exists("waypoint_path_generator.poi"))
            {
                System.IO.StreamReader file = new System.IO.StreamReader("c:\\tmp\\waypoint_path_generator.poi");
                int count = 0;
                string line;
                POIPoints poipoint = new POIPoints();

                while ((line = file.ReadLine()) != null)
                {

                    var items = line.Split(',');
                    poipoint.name = items[0];
                    poipoint.lat = Convert.ToDouble(items[1]);
                    poipoint.lon = Convert.ToDouble(items[2]);
                    poipoint.elev = Convert.ToDouble(items[3]);
                    poipoint.alt = Convert.ToDouble(items[4]);
                    poipoint.cam_alt = Convert.ToDouble(items[5]);

                    AddPOI(poipoint);
                    count++;
                }

                file.Close();
            }
        }

        public int SelectedPOICount()
        {
            int count = 0;
            for (int i = 0; i < POICount(); i++)
            {
                if (poi_list.ElementAt(i).selected) count++;
            }
            return count;
        }

        public int SelectedPathCount(string type)
        {
            int count = 0;
            if (type == "")
            {
                for (int i = 0; i < PathCount(); i++)
                {
                    if (PathAt(i).selected) count++;
                }
            }
            else
            {
                for (int i = 0; i < PathCount(); i++)
                {
                    if (PathAt(i).selected & PathAt(i).type == type) count++;
                }
            }
            return count;
        }

        public int SelectedPolyCount()
        {
            int count = 0;
            for (int i = 0; i < ShapeCount(); i++)
            {
                if (ShapeAt(i).selected) count++;
            }
            return count;
        }

        public int SelectedWPCount()
        {
            int count = 0;
            for (int i = 0; i < PathCount(); i++)
            {
                Path path = PathAt(i);
                LinkedList<WayPoints> wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    if (wp_list.ElementAt(j).selected) count++;
                }
            }
            return count;
        }

        public void UnselectAll()
        {
            // Unselect All Paths, including Waypoints

            for (int i = 0; i < PathCount(); i++)
            {
                Path path = PathAt(i);
                path.selected = false;
                LinkedList<WayPoints> wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    wp_list.ElementAt(j).selected = false;
                }
            }
            // All Shapes

            for (int i = 0; i < ShapeCount(); i++)
            {
                Shape shape = ShapeAt(i);
                shape.selected = false;
            }

            // All POIs

            for (int i = 0; i < POICount(); i++)
            {
                POIPoints pnt = POIPointAt(i);
                pnt.selected = false;
            }
        }
    }

}
