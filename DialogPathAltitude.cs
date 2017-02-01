using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Waypoint_Path_Generator.Models;


namespace Waypoint_Path_Generator
{
    public partial class DialogPathAltitude : Form
    {
        Path _path;
        Waypoint_Path_Gen _wpg;
        GMAP _gmap;
        Options _options;

        public DialogPathAltitude(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _path = path;

            InitializeComponent();

            LinkedList<WayPoints> wplist = _path.waypoints;

            trkWP1.Minimum = 0;
            trkWP1.Maximum = wplist.Count()-1;
            trkWP1.Value = 0;
            trkWP2.Minimum = 0;
            trkWP2.Maximum = wplist.Count()-1;
            trkWP2.Value = wplist.Count()-1;
            lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
            lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
            txtAlt1.Text = Convert.ToString(trkAlt1.Value);
            txtAlt2.Text = Convert.ToString(trkAlt2.Value);

            Series altseries = chartAlt.Series["Altitude"];
            altseries.ChartType = SeriesChartType.Area;
            ChartArea chartarea = chartAlt.ChartAreas[0];
            chartarea.AxisX.Minimum = 0;
            chartarea.AxisX.Maximum = wplist.Count()-1;
            chartarea.AxisX.Interval = 1;
            chartarea.AxisX.Name = "Way Points";

            for (int i = 0; i < wplist.Count(); i++)
            {
                WayPoints wp = wplist.ElementAt(i);
                altseries.Points.AddXY(i,wp.alt);
            }

        }

        private void DialogPathAltitude_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _path.selected = false;
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void chartAlt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trkWP1_Scroll(object sender, EventArgs e)
        {
            if (trkWP1.Value > trkWP2.Value) trkWP1.Value = trkWP2.Value;
            lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
        }

        private void trkWP2_Scroll(object sender, EventArgs e)
        {
            if (trkWP2.Value < trkWP1.Value) trkWP2.Value = trkWP1.Value;
            lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
        }

        private void ChangeWP()
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trkAlt1_Scroll(object sender, EventArgs e)
        {
            txtAlt1.Text = Convert.ToString(trkAlt1.Value);
            if(chkSingleAlt.Checked)
            {
                trkAlt2.Value = trkAlt1.Value;
                txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            }
        }

        private void trkAlt2_Scroll(object sender, EventArgs e)
        {
            txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            if (chkSingleAlt.Checked)
            {
                trkAlt1.Value = trkAlt2.Value;
                txtAlt1.Text = Convert.ToString(trkAlt2.Value);
            }
        }

        private void chkSingleAlt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSingleAlt.Checked)
            {
                trkAlt2.Value = trkAlt1.Value;
                txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LinkedList<WayPoints> wplist = _path.waypoints;
            WayPoints wp;
            Series altseries = chartAlt.Series["Altitude"];

            int start_wp = trkWP1.Value;
            int end_wp = trkWP2.Value;
            double start_alt = trkAlt1.Value;
            double end_alt = trkAlt2.Value;
            double alt_delta = start_alt - end_alt;
            double theta, alt_diff;
            if(start_wp == end_wp)
            {
                wp = wplist.ElementAt(start_wp);
                wp.alt = start_alt;
            }

            if( (end_wp - start_wp) == 1)
            {
                wp = wplist.ElementAt(start_wp);
                wp.alt = start_alt;
                wp = wplist.ElementAt(end_wp);
                wp.alt = end_alt;
            }

            if ((end_wp - start_wp) > 1) {

                for (int i = start_wp; i <= end_wp; i++)
                {
                    double wprange = end_wp - start_wp;
                    wp = wplist.ElementAt(i);
                    if (start_alt == end_alt) wp.alt = start_alt;
                    else
                    {
                        theta = GPS.DegreesToRadians(((i - start_wp) / wprange) * 180);
                        alt_diff = end_alt - start_alt;
                        wp.alt = start_alt + alt_diff * ((-Math.Cos(theta) + 1) / 2);
                    }
                }
            }

            altseries.Points.Clear();
            for (int i = 0; i < wplist.Count(); i++)
            {
                wp = wplist.ElementAt(i);
                altseries.Points.AddXY(i, wp.alt);
            }
        }

        
    }
}
