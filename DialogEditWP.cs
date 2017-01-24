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
        int _wp_index;
        LinkedList<WayPoints> _wp_list;
        WayPoints _wp;

        public DialogEditWP(Waypoint_Path_Gen wpg, GMAP gmap, int path_index, int wp_index)
        {
            _wpg = wpg;
            _gmap = gmap;
            _wp_index = wp_index;
            _path = _wpg.PathAt(path_index);
            _wp_list = _path.waypoints;
            _wp = _wp_list.ElementAt(wp_index);
            InitializeComponent();
            txtWPIndex.Text = Convert.ToString(wp_index);
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
            int actionid = _wp.action_id;
            Models.Action wpaction = _wpg.ActionWithId(_wp.action_id);
            string name = wpaction.name;
            int current_action_index = -1;

            for (int i = 0; i < _wpg.ActionCount(); i++)
            {
                cmbActions.Items.Add(_wpg.ActionAt(i).name);
                if (name == _wpg.ActionAt(i).name) current_action_index = i;
            }
            if (current_action_index == -1) current_action_index = 0;
            cmbActions.SelectedIndex = current_action_index;
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
            _wp.alt = Convert.ToDouble(txtwpalt.Text);
            _wp.head = Convert.ToDouble(txtwphead.Text);
            _wp.curvesize = Convert.ToDouble(txtwpcurvesize.Text);
            _wp.rotationdir = Convert.ToDouble(txtwprotdirection.Text);
            _wp.gimblemode = Convert.ToInt16(txtwpgimblemode.Text);
            _wp.gimblepitch = Convert.ToDouble(txtgimblepitch.Text);
            int action_id = cmbActions.SelectedIndex;
            Models.Action action = _wpg.ActionAt(action_id);
            string name = action.name;
            _wp.action_id = action.internal_id;
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

        private void txtwpalt_TextChanged(object sender, EventArgs e)
        {
            _wp.alt = Convert.ToDouble(txtwpalt.Text);
            _gmap.ReDrawgMap();
        }

        private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DialogEditWP_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevWP_Click(object sender, EventArgs e)
        {
            // Save current wp

            _wp.alt = Convert.ToDouble(txtwpalt.Text);
            _wp.head = Convert.ToDouble(txtwphead.Text);
            _wp.curvesize = Convert.ToDouble(txtwpcurvesize.Text);
            _wp.rotationdir = Convert.ToDouble(txtwprotdirection.Text);
            _wp.gimblemode = Convert.ToInt16(txtwpgimblemode.Text);
            _wp.gimblepitch = Convert.ToDouble(txtgimblepitch.Text);
            int action_id = cmbActions.SelectedIndex;
            Models.Action action = _wpg.ActionAt(action_id);
            string name = action.name;
            _wp.action_id = action.internal_id;
            _wp.selected = false;

            // Go tp previous wp

            _wp_index--;
            if (_wp_index < 0) _wp_index = 0;
            _wp = _wp_list.ElementAt(_wp_index);
            txtWPIndex.Text = Convert.ToString(_wp_index);
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
            Models.Action wpaction = _wpg.ActionWithId(_wp.action_id);
            int current_action_index = -1;

            for (int i = 0; i < _wpg.ActionCount(); i++)
            {
                if (wpaction.name == _wpg.ActionAt(i).name) current_action_index = i;
            }
            if (current_action_index == -1) current_action_index = 0;
            cmbActions.SelectedIndex = current_action_index;
            _wp.selected = true;
            _gmap.ReDrawgMap();
        }

        private void btnNextWP_Click(object sender, EventArgs e)
        {
            // Save current wp

            _wp.alt = Convert.ToDouble(txtwpalt.Text);
            _wp.head = Convert.ToDouble(txtwphead.Text);
            _wp.curvesize = Convert.ToDouble(txtwpcurvesize.Text);
            _wp.rotationdir = Convert.ToDouble(txtwprotdirection.Text);
            _wp.gimblemode = Convert.ToInt16(txtwpgimblemode.Text);
            _wp.gimblepitch = Convert.ToDouble(txtgimblepitch.Text);
            int action_id = cmbActions.SelectedIndex;
            Models.Action action = _wpg.ActionAt(action_id);
            string name = action.name;
            int[,] actions = action.actions;
            _wp.action_id = action.internal_id;
            _wp.selected = false;

            // Go to next wp

            _wp_index++;
            if (_wp_index >= _wp_list.Count) _wp_index = _wp_list.Count-1;
            _wp = _wp_list.ElementAt(_wp_index);
            txtWPIndex.Text = Convert.ToString(_wp_index);
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
            Models.Action wpaction = _wpg.ActionWithId(_wp.action_id);
            int current_action_index = -1;

            for (int i = 0; i < _wpg.ActionCount(); i++)
            {
                if (wpaction.name == _wpg.ActionAt(i).name) current_action_index = i;
            }
            if (current_action_index == -1) current_action_index = 0;
            cmbActions.SelectedIndex = current_action_index;
            _wp.selected = true;

            _gmap.ReDrawgMap();
        }
    }
}
