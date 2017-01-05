using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class CircularGUI
    {
        public bool CW;
        public string name;
        public double lat;
        public double lon;
        public double altitude;
        public double radius;
        public int numpoints;
        public bool fullcirc;
        public double start_angle;
        public double circ_span;
        public bool startend;
        public bool poimode;
        public string poiname;
    }
}
