using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class Options
    {
        public bool units_metric;

        public double def_altitude;
        public double def_elevation;
        public double earth_radius;

        public double focal_angle_hor;
        public double focal_angle_ver;
        public double hor_overlap_percent;
        public double ver_overlap_percent;

        public string def_POI;

        public string def_xml_config_file;
        public string def_kml_path;
        public string def_csv_path;

        public Options()
        {
            def_xml_config_file = "waypoint_path_generator.xml";
            def_kml_path = "c:\\tmp\\waypoints.kml";
            def_csv_path = "c:\\tmp\\waypoints.csv";
            focal_angle_hor = 81;
            focal_angle_ver = 66;
            hor_overlap_percent = 25;
            hor_overlap_percent = 15;
            earth_radius = 6371000;
        }
    }
}
