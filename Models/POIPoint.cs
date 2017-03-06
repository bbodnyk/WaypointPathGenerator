﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Waypoint_Path_Generator.Models
{
    public class POIPoints
    {
        public int internal_id;
        public GMapMarker marker_id;
        public string name;
        public double lat, lon, alt;
        public double elev, cam_alt;
        public bool selected;
        public bool visible;
    }
}
