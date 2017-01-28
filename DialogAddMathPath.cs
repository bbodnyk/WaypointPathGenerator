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
    public partial class DialogAddMathPath : Form
    {
        private double _lat;
        private double _lon;
        private GMAP _gmap;
        private Waypoint_Path_Gen _wpg;
        private Options _options;
        private WayPoints _wp;
        private Path _path;

        public DialogAddMathPath(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path, double lat, double lon)
        {
            // Save arguments
            _wp = new WayPoints();
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _lat = lat;
            _lon = lon;

            InitializeComponent();
        }

        private void DialogAddMathPath_Load(object sender, EventArgs e)
        {
            lbltrkAngleValue.Text = "Angle : " + Convert.ToString(trkAngle.Value);
            lbltrkNumPoints.Text = "Num Points : " + Convert.ToString(trkNumPoints.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trkAngle_Scroll(object sender, EventArgs e)
        {
            lbltrkAngleValue.Text = "Angle : " + Convert.ToString(trkAngle.Value);
        }

        private void lbltrkValue_Click(object sender, EventArgs e)
        {

        }

        private void trkNumPoints_Scroll(object sender, EventArgs e)
        {
            lbltrkNumPoints.Text = "Num Points : " + Convert.ToString(trkNumPoints.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildPath();
        }

        private void buildPath()
        {

        }
    }
}
