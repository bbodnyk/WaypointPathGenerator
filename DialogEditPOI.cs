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
    public partial class DialogEditPOI : Form
    {
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private TreeView _treeview;
        private int _poi_index;

        public DialogEditPOI(Waypoint_Path_Gen wpg, GMAP gmap, TreeView treeview, int poi_index)
        {
            _wpg = wpg;
            _gmap = gmap;
            _treeview = treeview;
            _poi_index = poi_index;
            InitializeComponent();
            POIPoints pnt;
            pnt = _wpg.POIPointAt(_poi_index);
            txtPOIName.Text = pnt.name;
            txtPOILatitude.Text = Convert.ToString(pnt.lat);
            txtPOILongitude.Text = Convert.ToString(pnt.lon);
            txtPOIElevation.Text = Convert.ToString(pnt.elev);
            txtPOIAltitude.Text = Convert.ToString(pnt.alt);
            txtPOICameraAlt.Text = Convert.ToString(pnt.cam_alt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POIPoints pnt = new POIPoints(); 
            pnt.name = txtPOIName.Text;
            pnt.lat = Convert.ToDouble(txtPOILatitude.Text);
            pnt.lon = Convert.ToDouble(txtPOILongitude.Text);
            pnt.elev = Convert.ToDouble(txtPOIElevation.Text);
            pnt.alt = Convert.ToDouble(txtPOIAltitude.Text);
            pnt.cam_alt = Convert.ToDouble(txtPOICameraAlt.Text);
            pnt.visible = true;
            pnt.selected = true;
            _wpg.ReplacePOI(_poi_index, pnt);
            GMAPTree.Update_GMapTree(_wpg, _treeview);
            _gmap.ReDrawgMap();
            this.Close();
        }
    }
}
