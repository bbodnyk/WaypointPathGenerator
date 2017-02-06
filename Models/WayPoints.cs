using System;
using System.Collections.Generic;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator.Models
{
    public class WayPoints
    {

        public double lat, lon, alt, head, curvesize, rotationdir;
        public int gimblemode;
        public double gimblepitch;
        //public int[,] actions;
        public int action_id;
        public int poi_id;
        public bool selected;
        public bool visible;
        public int path_int_id;
        public GMap.NET.WindowsForms.GMapMarker marker;

        public void Insert_Waypoint_List( Waypoint_Path_Gen wpg, double lat, double lon, bool before)
        {
            // Find Selected WP
            for (int path_id = 0; path_id < wpg.PathCount(); path_id++)
            {
                Path path = wpg.PathAt(path_id);
                LinkedList<WayPoints> wp_list = path.waypoints;
                LinkedListNode<WayPoints> node = wp_list.First;
                LinkedListNode<WayPoints> next_node;
                while(node != null)
                {
                    next_node = node.Next;
                    if (node.Value.selected)
                    {
                        WayPoints wp_new = new WayPoints();
                        wp_new.lat = lat;
                        wp_new.lon = lon;
                        wp_new.alt = node.Value.alt;
                        wp_new.head = node.Value.head;
                        wp_new.curvesize = node.Value.curvesize;
                        wp_new.rotationdir = node.Value.rotationdir;
                        wp_new.gimblemode = node.Value.gimblemode;
                        wp_new.gimblepitch = node.Value.gimblepitch;
                        wp_new.action_id = node.Value.action_id;
                        //wp_new.actions = node.Value.actions;
                        wp_new.selected = true;
                        wp_new.visible = true;
                        wp_new.path_int_id = path.internal_id;

                        if (before) wp_list.AddBefore(node, wp_new);
                        else wp_list.AddAfter(node, wp_new);
                        node.Value.selected = false;
                        return;
                    }

                    node = next_node;
                }
                
            }

            
        }

        public void Add_Waypoint_List(Waypoint_Path_Gen wpg, LinkedList<WayPoints> list, double lat, double lon, double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int poi_id, int action_id)
        {
            WayPoints waypoint = new WayPoints();
            waypoint.lat = lat;
            waypoint.lon = lon;
            waypoint.alt = alt;
            waypoint.head = heading;
            waypoint.curvesize = curvesize;
            waypoint.rotationdir = rotdir;
            waypoint.gimblemode = gimblemode;
            waypoint.gimblepitch = gimblepitch;
            waypoint.action_id = action_id;
            list.AddLast(waypoint);
        }

        public void Add_Leg_List(Waypoint_Path_Gen wpg, LinkedList<WayPoints> list, double lat1, double lon1, double lat2, double lon2, 
            double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int poi_id, int video_actions_id, int photo_actions_id, 
            bool video, double camera_increment, double overlap)
        {
            // See if we have to reverse the points

            WayPoints wp = new WayPoints();
            int list_count = list.Count;
            if (list_count > 0)
            {
                double last_lat = list.Last.Value.lat;
                double last_lon = list.Last.Value.lon;
                double dist1 = GPS.GPS_Distance(last_lat, last_lon, lat1, lon1, Form1.Globals.gps_radius);
                double dist2 = GPS.GPS_Distance(last_lat, last_lon, lat2, lon2, Form1.Globals.gps_radius);
                if (dist2 < dist1)
                {
                    double temp = lat1;
                    lat1 = lat2;
                    lat2 = temp;
                    temp = lon1;
                    lon1 = lon2;
                    lon2 = temp;
                }

            }

            if (video)
            {
                // If in Video mode only output start and end points

            
                wp.Add_Waypoint_List(wpg, list, lat1, lon1, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, video_actions_id);
                wp.Add_Waypoint_List(wpg, list, lat2, lon2, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, video_actions_id);
            }
            else
            {
                // Photo Mode - Break into seperate segments

                // Output first WP

                wp.Add_Waypoint_List(wpg, list, lat1, lon1, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, photo_actions_id);

                camera_increment = camera_increment * (1 - overlap / 100.0);
                double distance = GPS.GPS_Distance(lat1, lon1, lat2, lon2, Form1.Globals.gps_radius);
                double bearing = GPS.GPS_Bearing(lat1, lon1, lat2, lon2);
                double new_lat, new_lon, last_lat, last_lon;
                int num_wp = (int)(distance / camera_increment);
                if (num_wp != 0)
                {
                    if (num_wp == 1)
                    {
                        new_lat = GPS.GPS_Lat_BearDist(lat1, lon1, bearing, distance / 2, Form1.Globals.gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat1, lon1, new_lat, bearing, distance / 2, Form1.Globals.gps_radius);
                        wp.Add_Waypoint_List(wpg, list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, photo_actions_id);
                    }
                    else
                    {
                        double width = (num_wp - 1) * camera_increment;
                        double dist_diff = distance - width;
                        new_lat = GPS.GPS_Lat_BearDist(lat1, lon1, bearing, dist_diff / 2, Form1.Globals.gps_radius);
                        new_lon = GPS.GPS_Lon_BearDist(lat1, lon1, new_lat, bearing, dist_diff / 2, Form1.Globals.gps_radius);
                        wp.Add_Waypoint_List(wpg, list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, photo_actions_id);
                        last_lat = new_lat;
                        last_lon = new_lon;
                        for (int i = 0; i < num_wp - 1; i++)
                        {
                            new_lat = GPS.GPS_Lat_BearDist(last_lat, last_lon, bearing, camera_increment, Form1.Globals.gps_radius);
                            new_lon = GPS.GPS_Lon_BearDist(last_lat, last_lon, new_lat, bearing, camera_increment, Form1.Globals.gps_radius);
                            wp.Add_Waypoint_List(wpg, list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, photo_actions_id);
                            last_lat = new_lat;
                            last_lon = new_lon;
                        }
                    }
                }

                // Output last WP 

                wp.Add_Waypoint_List(wpg, list, lat2, lon2, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, poi_id, photo_actions_id);

            }
        }
                

    }
}