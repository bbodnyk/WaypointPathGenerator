using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Waypoint_Path_Generator.Models;

namespace Waypoint_Path_Generator
{
    public partial class DialogGoTo : Form
    {
        Waypoint_Path_Gen _wpg;
        GMAP _gmap;
        Options _options;
        GMap.NET.PointLatLng _center;

        public DialogGoTo(Waypoint_Path_Gen wpg, GMAP gmap, Options options)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;

            InitializeComponent();

            _center = _gmap.GetCenter();
            txtLat.Text = Convert.ToString(_center.Lat);
            txtLon.Text = Convert.ToString(_center.Lng);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DialogGoTo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLat_TextChanged(object sender, EventArgs e)
        {
            _center.Lat = Convert.ToDouble(txtLat.Text);
            _gmap.SetCenter(_center.Lat, _center.Lng);
            _gmap.ReDrawgMap();
        }

        private void txtLon_TextChanged(object sender, EventArgs e)
        {
            _center.Lng = Convert.ToDouble(txtLon.Text);
            _gmap.SetCenter(_center.Lat, _center.Lng);
            _gmap.ReDrawgMap();
        }
    }
}
