using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class HelicalGUI
    {
        public bool CW;
        public string name;
        public double lat;
        public double lon;
        public double start_alt;
        public double end_alt;
        public double start_rad;
        public double end_rad;
        public double start_angle;
        public double helix_span;
        public int num_points;
        public bool startend;
        public bool poimode;
        public string poiname;
    }
}
