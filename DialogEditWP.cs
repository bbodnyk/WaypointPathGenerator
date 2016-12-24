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
    public partial class DialogEditWP : Form
    {
        Waypoint_Path_Gen _wpg;
        GMAP _gmap;
        Path _path;
        LinkedList<WayPoints> _wp_list;
        WayPoints _wp;
        Models.Action _action;

        public DialogEditWP(Waypoint_Path_Gen wpg, GMAP gmap, int path_index, int wp_index)
        {
            _wpg = wpg;
            _gmap = gmap;
            _path = _wpg.PathAt(path_index);
            _wp_list = _path.waypoints;
            _wp = _wp_list.ElementAt(wp_index);
            InitializeComponent();
            txtwplat.Text = Convert.ToString(_wp.lat);
            txtwplon.Text = Convert.ToString(_wp.lon);
            txtwpalt.Text = Convert.ToString(_wp.alt);
            txtwphead.Text = Convert.ToString(_wp.head);
            txtwpcurvesize.Text = Convert.ToString(_wp.curvesize);
            txtwprotdirection.Text = Convert.ToString(_wp.rotationdir);
            txtwpgimblemode.Text = Convert.ToString(_wp.gimblemode);
            txtgimblepitch.Text = Convert.ToString(_wp.gimblepitch);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //txtwplat.Text = Convert.ToString(_wp.lat);
            //txtwplon.Text = Convert.ToString(_wp.lon);
            _wp.alt = Convert.ToDouble(txtwpalt.Text);

            //txtwphead.Text = Convert.ToString(_wp.head);
            //txtwpcurvesize.Text = Convert.ToString(_wp.curvesize);
            //txtwprotdirection.Text = Convert.ToString(_wp.rotationdir);
            //txtwpgimblemode.Text = Convert.ToString(_wp.gimblemode);
            //txtgimblepitch.Text = Convert.ToString(_wp.gimblepitch);
            _gmap.ReDrawgMap();
            this.Close();
        }
    }
}
