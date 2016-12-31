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
            trkHeading.Value = Convert.ToInt16(_wp.head);
            trkCurveSize.Value = Convert.ToInt16(_wp.curvesize);
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
            _wp.head = Convert.ToDouble(txtwphead.Text);
            _wp.curvesize = Convert.ToDouble(txtwpcurvesize.Text);
            _wp.rotationdir = Convert.ToDouble(txtwprotdirection.Text);
            _wp.gimblemode = Convert.ToInt16(txtwpgimblemode.Text);
            _wp.gimblepitch = Convert.ToDouble(txtgimblepitch.Text);
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void trkHeading_Scroll(object sender, EventArgs e)
        {
            txtwphead.Text = Convert.ToString(trkHeading.Value);
        }

        private void txtwphead_TextChanged(object sender, EventArgs e)
        {
            _wp.head = Convert.ToDouble(txtwphead.Text);
            _gmap.ReDrawgMap();
        }

        private void trkCurceSize_Scroll(object sender, EventArgs e)
        {
            txtwpcurvesize.Text = Convert.ToString(trkCurveSize.Value);
        }

        private void txtwpcurvesize_TextChanged(object sender, EventArgs e)
        {
            _wp.curvesize = Convert.ToDouble(txtwpcurvesize.Text);
            _gmap.ReDrawgMap();
        }
    }
}
