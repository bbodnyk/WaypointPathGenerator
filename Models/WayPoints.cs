using System;
using System.Collections.Generic;

namespace Waypoint_Path_Generator.Models
{
    public class WayPoints
    {
        public double lat, lon, alt, head, curvesize, rotationdir;
        public int gimblemode;
        public double gimblepitch;
        public int[,] actions;
        public bool selected;
        public bool visible;
        public GMap.NET.WindowsForms.GMapMarker marker;


        public void Add_Waypoint_List(LinkedList<WayPoints> list, double lat, double lon, double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int[,] actions)
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
            waypoint.actions = actions;
            list.AddLast(waypoint);
        }

        public void Add_Leg_List(GPS gps, LinkedList<WayPoints> list, double lat1, double lon1, double lat2, double lon2, 
            double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int[,] actions, 
            bool video, double camera_increment, double overlap)
        {
            // See if we have to reverse the points

            WayPoints wp = new WayPoints();
            int list_count = list.Count;
            if (list_count > 0)
            {
                double last_lat = list.Last.Value.lat;
                double last_lon = list.Last.Value.lon;
                double dist1 = gps.GPS_Distance(last_lat, last_lon, lat1, lon1, Form1.Globals.gps_radius);
                double dist2 = gps.GPS_Distance(last_lat, last_lon, lat2, lon2, Form1.Globals.gps_radius);
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

            int[,] no_actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };

            if (video)
            {
                // If in Video mode only output start and end points

                wp.Add_Waypoint_List(list, lat1, lon1, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, no_actions);
                wp.Add_Waypoint_List(list, lat2, lon2, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, no_actions);
            }
            else
            {
                // Photo Mode - Break into seperate segments

                // Output first WP

                wp.Add_Waypoint_List(list, lat1, lon1, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, actions);

                camera_increment = camera_increment * (1 - overlap / 100.0);
                double distance = gps.GPS_Distance(lat1, lon1, lat2, lon2, Form1.Globals.gps_radius);
                double bearing = gps.GPS_Bearing(lat1, lon1, lat2, lon2);
                double new_lat, new_lon, last_lat, last_lon;
                int num_wp = (int)(distance / camera_increment);
                if (num_wp != 0)
                {
                    if (num_wp == 1)
                    {
                        new_lat = gps.GPS_Lat_BearDist(lat1, lon1, bearing, distance / 2, Form1.Globals.gps_radius);
                        new_lon = gps.GPS_Lon_BearDist(lat1, lon1, new_lat, bearing, distance / 2, Form1.Globals.gps_radius);
                        wp.Add_Waypoint_List(list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, actions);
                    }
                    else
                    {
                        double width = (num_wp - 1) * camera_increment;
                        double dist_diff = distance - width;
                        new_lat = gps.GPS_Lat_BearDist(lat1, lon1, bearing, dist_diff / 2, Form1.Globals.gps_radius);
                        new_lon = gps.GPS_Lon_BearDist(lat1, lon1, new_lat, bearing, dist_diff / 2, Form1.Globals.gps_radius);
                        wp.Add_Waypoint_List(list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, actions);
                        last_lat = new_lat;
                        last_lon = new_lon;
                        for (int i = 0; i < num_wp - 1; i++)
                        {
                            new_lat = gps.GPS_Lat_BearDist(last_lat, last_lon, bearing, camera_increment, Form1.Globals.gps_radius);
                            new_lon = gps.GPS_Lon_BearDist(last_lat, last_lon, new_lat, bearing, camera_increment, Form1.Globals.gps_radius);
                            wp.Add_Waypoint_List(list, new_lat, new_lon, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, actions);
                            last_lat = new_lat;
                            last_lon = new_lon;
                        }
                    }
                }

                // Output last WP 

                wp.Add_Waypoint_List(list, lat2, lon2, alt, heading, curvesize, rotdir, gimblemode, gimblepitch, actions);

            }
        }
                

    }
}