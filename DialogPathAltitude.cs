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
        double _lat_center, _lon_center;

        public DialogPathAltitude(Waypoint_Path_Gen wpg, GMAP gmap, Options options, Path path, double lat, double lon)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;
            _path = path;
            _lat_center = lat;
            _lon_center = lon;

            InitializeComponent();

            LinkedList<WayPoints> wplist = _path.waypoints;

            trkWP1.Minimum = 0;
            trkWP1.Maximum = wplist.Count() - 1;
            trkWP1.Value = 0;
            trkWP2.Minimum = 0;
            trkWP2.Maximum = wplist.Count() - 1;
            trkWP2.Value = wplist.Count() - 1;
            lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
            lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
            txtAlt1.Text = Convert.ToString(trkAlt1.Value);
            txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            txtPitch1.Text = Convert.ToString(trkPitch1.Value);
            txtPitch2.Text = Convert.ToString(trkPitch2.Value);
            txtWPDist.Text = Convert.ToString(trkWPDist.Value);

            cmbPOI.Items.Clear();
            cmbPOI.Items.Add("");
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                cmbPOI.Items.Add(_wpg.POIPointAt(i).name);
            }
            Series altseries = chartAlt.Series["Altitude"];
            Series headingseries = chartAlt.Series["Heading"];
            Series pitchseries = chartAlt.Series["Pitch"];
            Series distseries = chartAlt.Series["Distance"];
            altseries.Points.Clear();
            headingseries.Points.Clear();
            pitchseries.Points.Clear();
            distseries.Points.Clear();
            altseries.ChartType = SeriesChartType.Line;
            headingseries.ChartType = SeriesChartType.Line;
            pitchseries.ChartType = SeriesChartType.Line;
            distseries.ChartType = SeriesChartType.Line;
            ChartArea chartarea = chartAlt.ChartAreas[0];
            chartarea.AxisX.Minimum = 0;
            chartarea.AxisX.Maximum = wplist.Count() - 1;
            chartarea.AxisX.Interval = 1;
            chartarea.AxisX.Name = "Way Points";

            for (int i = 0; i < wplist.Count(); i++)
            {
                WayPoints wp = wplist.ElementAt(i);
                wp.selected = false;
                if (chkShowAlt.Checked) altseries.Points.AddXY(i, wp.alt);
                if (chkShowHeading.Checked) headingseries.Points.AddXY(i, wp.head);
                if (chkShowPitch.Checked) pitchseries.Points.AddXY(i, wp.gimblepitch);
                if (chkSHowDist.Checked)
                {
                    if (i == 0)
                    {
                        distseries.Points.AddXY(i, 0);
                    }
                    else
                    {
                        WayPoints wpprev = wplist.ElementAt(i - 1);
                        double dist = GPS.GPS_Distance(wpprev.lat, wpprev.lon, wp.lat, wp.lon, _options.earth_radius);
                        distseries.Points.AddXY(i, dist);
                    }
                }
            }
            _path.selected = false;
            _gmap.ReDrawgMap();
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
            if (chkAllWP.Checked)
            {
                trkWP1.Value = trkWP1.Minimum;
                lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
            }
            if (trkWP1.Value > trkWP2.Value) trkWP1.Value = trkWP2.Value;
            lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
        }

        private void trkWP2_Scroll(object sender, EventArgs e)
        {
            if (chkAllWP.Checked)
            {
                trkWP2.Value = trkWP2.Maximum;
                lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
            }
            if (trkWP2.Value < trkWP1.Value) trkWP2.Value = trkWP1.Value;
            lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
        }

        private void ChangeWP()
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trkPitch1_Scroll(object sender, EventArgs e)
        {
            txtPitch1.Text = Convert.ToString(trkPitch1.Value);
            if (chkSinglePitch.Checked)
            {
                trkPitch2.Value = trkPitch1.Value;
                txtPitch2.Text = Convert.ToString(trkPitch2.Value);
            }
        }

        private void trkAlt1_Scroll(object sender, EventArgs e)
        {
            txtAlt1.Text = Convert.ToString(trkAlt1.Value);
            if (chkSingleAlt.Checked)
            {
                trkAlt2.Value = trkAlt1.Value;
                txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            }
        }

        private void trkPitch2_Scroll(object sender, EventArgs e)
        {
            txtPitch2.Text = Convert.ToString(trkPitch2.Value);
            if (chkSinglePitch.Checked)
            {
                trkPitch1.Value = trkPitch2.Value;
                txtPitch1.Text = Convert.ToString(trkPitch1.Value);
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

        private void chkSinglePitch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinglePitch.Checked)
            {
                trkPitch2.Value = trkPitch1.Value;
                txtPitch2.Text = Convert.ToString(trkPitch2.Value);
                chkPOIMode.Checked = false;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LinkedList<WayPoints> wplist = _path.waypoints;
            WayPoints wp, wpprev;

            if (chkSetAlt.Checked)
            {
                // Adjust Path Altitude

                int start_wp = trkWP1.Value;
                int end_wp = trkWP2.Value;
                double start_alt = trkAlt1.Value;
                double end_alt = trkAlt2.Value;
                double alt_delta = start_alt - end_alt;
                double theta, alt_diff;
                if (start_wp == end_wp)
                {
                    wp = wplist.ElementAt(start_wp);
                    wp.alt = start_alt;
                }

                if ((end_wp - start_wp) == 1)
                {
                    wp = wplist.ElementAt(start_wp);
                    wp.alt = start_alt;
                    wp = wplist.ElementAt(end_wp);
                    wp.alt = end_alt;
                }

                if ((end_wp - start_wp) > 1)
                {

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
            }

            if (chkSetPOI.Checked)
            {
                // Set WP POI

                bool poimode = chkPOIMode.Checked;
                String poi_name = cmbPOI.GetItemText(cmbPOI.SelectedItem);

                // No POI Mode

                if (poimode)
                {
                    int start_wp = trkWP1.Value;
                    int end_wp = trkWP2.Value;

                    double lat_camera = _lat_center;
                    double lon_camera = _lon_center;
                    double cam_alt = 5;
                    int poi_id = -1;

                    double distance;

                    for (int i = 0; i < _wpg.POICount(); i++)
                    {
                        POIPoints tmp_point = _wpg.POIPointAt(i);
                        string name = tmp_point.name;
                        if (poi_name == name)
                        {
                            lat_camera = tmp_point.lat;
                            lon_camera = tmp_point.lon;
                            cam_alt = tmp_point.cam_alt;
                            poi_id = tmp_point.internal_id;
                        }
                    }

                    for (int i = 0; i < wplist.Count(); i++)
                    {
                        wp = wplist.ElementAt(i);
                        wp.head = GPS.GPS_Bearing(wp.lat, wp.lon, lat_camera, lon_camera);
                        distance = GPS.GPS_Distance(wp.lat, wp.lon, lat_camera, lon_camera, Form1.Globals.gps_radius);
                        wp.gimblepitch = -GPS.RadiansToDegrees(Math.Atan((wp.alt - cam_alt) / distance));
                        wp.gimblemode = 2;
                        wp.poi_id = poi_id;
                    }
                }
                else
                {

                    int start_wp = trkWP1.Value;
                    int end_wp = trkWP2.Value;
                    int start_pitch = trkPitch1.Value;
                    int end_pitch = trkPitch2.Value;
                    double last_pitch = 0;
                    WayPoints wp1, wp2;
                    double last_head = 0;
                    double theta, pitch_diff;
                    for (int i = start_wp; i < end_wp; i++)
                    {
                        double wprange = end_wp - start_wp;
                        wp1 = wplist.ElementAt(i);
                        wp2 = wplist.ElementAt(i + 1);
                        wp1.head = GPS.GPS_Bearing(wp1.lat, wp1.lon, wp2.lat, wp2.lon);
                        if (chkSinglePitch.Checked)
                        {
                            wp1.gimblepitch = start_pitch;
                        }
                        else
                        {
                            theta = GPS.DegreesToRadians(((i - start_wp) / wprange) * 180);
                            pitch_diff = end_pitch - start_pitch;
                            wp1.gimblepitch = start_pitch + pitch_diff * ((-Math.Cos(theta) + 1) / 2);
                        }
                        last_head = wp1.head;
                        last_pitch = wp1.gimblepitch;
                    }
                    wp1 = wplist.ElementAt(end_wp);
                    wp1.head = last_head;
                    wp1.gimblepitch = last_pitch;
                }
            }

            if (chkRemoveWP.Checked)
            {
                // Remove waypoints too close together
                int start_wp = trkWP1.Value;
                int end_wp = trkWP2.Value;
                WayPoints wp1, wp2;
                double dist;
                double maxdist = Convert.ToDouble(txtWPDist.Text);
                bool flag = false;

                do
                {
                    // Loop until minimum distance between waypoints is less than dist
                    
                        flag = false;
                        for (int i = start_wp; i < end_wp - 1; i++)
                        {
                            wp1 = wplist.ElementAt(i);
                            wp2 = wplist.ElementAt(i + 1);
                            dist = GPS.GPS_Distance(wp1.lat, wp1.lon, wp2.lat, wp2.lon, _options.earth_radius);
                            if(dist < maxdist)
                            {
                                wplist.Remove(wp2);
                                end_wp--;
                                trkWP2.Maximum = trkWP2.Maximum - 1;
                                lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
                                flag = true;
                                break;
                            }
                        }
                } while (flag);
            }

            // Redraw Altitude Plot


            Series altseries = chartAlt.Series["Altitude"];
            Series headingseries = chartAlt.Series["Heading"];
            Series pitchseries = chartAlt.Series["Pitch"];
            Series distseries = chartAlt.Series["Distance"];
            altseries.Points.Clear();
            headingseries.Points.Clear();
            pitchseries.Points.Clear();
            distseries.Points.Clear();
            altseries.ChartType = SeriesChartType.Line;
            headingseries.ChartType = SeriesChartType.Line;
            pitchseries.ChartType = SeriesChartType.Line;
            distseries.ChartType = SeriesChartType.Line;

            for (int i = 0; i < wplist.Count(); i++)
            {
                wp = wplist.ElementAt(i);
                if (chkShowAlt.Checked) altseries.Points.AddXY(i, wp.alt);
                if (chkShowHeading.Checked) headingseries.Points.AddXY(i, wp.head);
                if (chkShowPitch.Checked) pitchseries.Points.AddXY(i, wp.gimblepitch);
                if (chkSHowDist.Checked)
                {
                    if (i == 0)
                    {
                        distseries.Points.AddXY(i, 0);
                    }
                    else
                    {
                        wpprev = wplist.ElementAt(i - 1);
                        double dist = GPS.GPS_Distance(wpprev.lat, wpprev.lon, wp.lat, wp.lon, _options.earth_radius);
                        distseries.Points.AddXY(i, dist);
                    }
                }
            }


            _path.selected = false;
            _gmap.ReDrawgMap();
        }

        private void chkAllWP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllWP.Checked)
            {
                LinkedList<WayPoints> wplist = _path.waypoints;
                trkWP1.Minimum = 0;
                trkWP1.Maximum = wplist.Count() - 1;
                trkWP1.Value = 0;
                trkWP2.Minimum = 0;
                trkWP2.Maximum = wplist.Count() - 1;
                trkWP2.Value = wplist.Count() - 1;
                lblwp1.Text = "Waypoint " + Convert.ToString(trkWP1.Value);
                lblwp2.Text = "Waypoint " + Convert.ToString(trkWP2.Value);
                txtAlt1.Text = Convert.ToString(trkAlt1.Value);
                txtAlt2.Text = Convert.ToString(trkAlt2.Value);
            }
        }

        private void chkSetAlt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPOIMode_CheckedChanged(object sender, EventArgs e)
        {
            chkSinglePitch.Checked = false;
        }

        private void txtAlt1_TextChanged(object sender, EventArgs e)
        {
            double alt = Convert.ToDouble(txtAlt1.Text);
            double alt_min = Convert.ToDouble(trkAlt1.Minimum);
            double alt_max = Convert.ToDouble(trkAlt1.Maximum);
            if (alt < alt_min)
            {
                trkAlt1.Value = trkAlt1.Minimum;
                txtAlt1.Text = Convert.ToString(trkAlt1.Minimum);
            }
            if (alt > alt_max)
            {
                trkAlt1.Value = trkAlt1.Maximum;
                txtAlt1.Text = Convert.ToString(trkAlt1.Maximum);
            }
            trkAlt1.Value = Convert.ToInt16(alt);
        }

        private void txtAlt2_TextChanged(object sender, EventArgs e)
        {
            double alt = Convert.ToDouble(txtAlt2.Text);
            double alt_min = Convert.ToDouble(trkAlt2.Minimum);
            double alt_max = Convert.ToDouble(trkAlt2.Maximum);
            if (alt < alt_min)
            {
                trkAlt2.Value = trkAlt2.Minimum;
                txtAlt2.Text = Convert.ToString(trkAlt2.Minimum);
            }
            if (alt > alt_max)
            {
                trkAlt2.Value = trkAlt2.Maximum;
                txtAlt2.Text = Convert.ToString(trkAlt2.Maximum);
            }
            trkAlt2.Value = Convert.ToInt16(alt);
        }

        private void btnSwapAlt_Click(object sender, EventArgs e)
        {
            string save = txtAlt1.Text;
            txtAlt1.Text = txtAlt2.Text;
            txtAlt2.Text = save;
        }

        private void trkWPDist_Scroll(object sender, EventArgs e)
        {
            txtWPDist.Text = Convert.ToString(trkWPDist.Value);
        }

        private void chkSetPOI_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
