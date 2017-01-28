using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waypoint_Path_Generator.Models
{
    public class Action
    {
        public string name;
        public int internal_id;
        public int[,] actions;
        public bool locked;
    }
}
