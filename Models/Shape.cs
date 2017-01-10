using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class Shape
    {
        public int internal_id;
        public string name;
        public LinkedList<PolyPoint> points;
        public bool selected;
        public bool visible;
    }

    
}
