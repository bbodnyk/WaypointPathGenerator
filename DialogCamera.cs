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
    public partial class DialogCamera : Form
    {
        Options _options;

        public DialogCamera(Options options)
        {

            _options = options;

            InitializeComponent();
            
            txtAlt.Text = Convert.ToString(options.def_altitude);
            txtCamHorAngle.Text = Convert.ToString(options.focal_angle_hor);
            txtCamVerAngle.Text = Convert.ToString(options.focal_angle_ver);
            txtImageLength.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(options.focal_angle_hor / 2)) * options.def_altitude));
            txtImageWidth.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(options.focal_angle_ver / 2)) * options.def_altitude));
            txtImageHorOverlap.Text = Convert.ToString(options.hor_overlap_percent);
            txtImageVerOverlap.Text = Convert.ToString(options.ver_overlap_percent);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void DialogCamera_Load(object sender, EventArgs e)
        {

        }

        private void txtAlt_TextChanged(object sender, EventArgs e)
        {

            double value = Convert.ToDouble(txtAlt.Text);
            if (value < trkAltitude.Minimum)
            {
                txtAlt.Text = Convert.ToString(trkAltitude.Minimum);
            }
            if (value > trkAltitude.Maximum)
            {
                txtAlt.Text = Convert.ToString(trkAltitude.Maximum);
            }

            _options.def_altitude = Convert.ToDouble(txtAlt.Text);
            trkAltitude.Value = Convert.ToInt16(_options.def_altitude);
            txtImageLength.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_hor / 2)) * _options.def_altitude));
            txtImageWidth.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_ver / 2)) * _options.def_altitude));
        }

        private void trkAltitude_Scroll(object sender, EventArgs e)
        {
            txtAlt.Text = Convert.ToString(trkAltitude.Value);
        }

        private void txtCamHorAngle_TextChanged(object sender, EventArgs e)
        {
            _options.focal_angle_hor = Convert.ToDouble(txtCamHorAngle.Text);
            txtImageLength.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_hor / 2)) * _options.def_altitude));
        }

        private void txtCamVerAngle_TextChanged(object sender, EventArgs e)
        {
            _options.focal_angle_ver = Convert.ToDouble(txtCamVerAngle.Text);
            txtImageWidth.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(_options.focal_angle_ver / 2)) * _options.def_altitude));
        }
    }
}
