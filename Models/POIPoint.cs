using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class POIPoints
    {
        public string name;
        public double lat, lon, alt;
        public double elev, cam_alt;
        public bool selected;
        public bool visible;
    }
}
