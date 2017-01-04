using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.Windows.Forms;
using SharpKml.Base;
using SharpKml.Engine;
using System.IO;
using System.Xml;
//using SharpKml.Dom.GX;
using SharpKml.Dom;
using Waypoint_Path_Generator.Models;
using WpgShape = Waypoint_Path_Generator.Models.Shape;

namespace Waypoint_Path_Generator
{

    public partial class Form1 : Form
    {
        Options _options;
        GMAP _gmap;
        public Waypoint_Path_Gen _wpg;
        WayPoints _wp;
        TreeView _gmaptree;
        Models.Path _path;

        // Structures

        public struct XYPnt
        {
            public double x;
            public double y;
        }

        public struct WPG_Vector
        {
            public double lat;
            public double lon;
            public double bearing;
        }

        public struct WPG_PointVector
        {
            public WPG_Point pnt1;
            public WPG_Point pnt2;
        }

        public struct WPG_Point
        {
            public double lat;
            public double lon;
        }

        // Globals

        public class Globals
        {
            public static double[,] kml_points = new double[1000, 4];
            public static int kml_point_count = 0;
            public static string kml_filename;
            // Defaults


            public static double[,] poly_points = new double[1000, 4];
            public static int poly_point_count = 0;
            public static double gps_radius;
            public static LinkedList<WayPoints> waypoint_list = new LinkedList<WayPoints>();
            public static LinkedList<WayPoints> manpoint_list = new LinkedList<WayPoints>();
            public static int manpoint_count = 0;
            public static bool ActionWaypoint_Handler = false;
            public static bool POIpoint_Handler = false;
            public static bool Path_Handler = false;
            public static bool Shape_Handler = false;
            public static bool ManWp_Handler = false;
            public static bool TreView_Handler = true;
            public static bool MouseUp_Handler = true;
            public static bool MouseDown = false;
            public static bool Moving_Marker = false;
            public static bool Marker_click = true;
            public static int ActionsPath = -1;
            public static bool UnitsMetric = true;
            public static bool Map_FirstDraw = true;
            public static bool path_active = false;
            public static PointLatLng map_center;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapOverlay overroutes = new GMapOverlay("routes");
            GMapOverlay overpoly = new GMapOverlay("polygons");
            public static bool marker_selected = false;
            public static GMapMarker selected_marker;
            public static LinkedList<WayPoints> selected_wplist;
            public static Models.Path selected_path;
            public static int selected_wpindex;
            public static double mouse_down_lat;
            public static double mouse_down_lon;
            public static string default_location;
            //public static string default_altitude;
            //public static string default_out_csv_file = "c:\\tmp\\waypoints.csv";
            //public static string default_out_kml_file = "c:\\tmp\\waypoints.kml";
            public static string default_cam_hor_ang = "81";
            public static string default_cam_ver_ang = "66";
            public static string default_cam_hor_over = "25.0";
            public static string default_cam_ver_over = "15.0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Other CLasses

            _options = new Options();
            _wp = new WayPoints();
            _path = new Models.Path();
            // Create data structure

            _wpg = new Waypoint_Path_Gen(_options);

            // Create new GMap

            _gmap = new GMAP(_wpg, gMapControl,0);
            _gmaptree = treGMap;

            // Read Config File

            if (!File.Exists(_options.def_xml_config_file)) _wpg.ReadPOI();
            else {
                _wpg.ReadXml_Config(_options.def_xml_config_file);
                _wpg.ReadXml_POI(_options.def_xml_config_file);
                _wpg.ReadXml_Path(_options.def_xml_config_file);
                _wpg.ReadXml_Actions(_options.def_xml_config_file);
                _wpg.ReadXml_Polygon(_options.def_xml_config_file);
            }

            // Update GUI Controls

            Update_POI_Dgv();
            Update_DGVPath();
            Update_Actioncmb();
            //Update_Shapecmb();
            Update_GUI();

            // Set Waypoint dgv to be unsortable

            foreach (DataGridViewColumn dgvc in dgvActionsWaypoints.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Globals.gps_radius = _options.earth_radius + _options.def_elevation + _options.def_altitude;
            Globals.ActionWaypoint_Handler = true;
            Globals.POIpoint_Handler = true;
            Globals.Shape_Handler = true;
            Globals.ManWp_Handler = true;

            // Set Actions

            cmbAction1.SelectedIndex = 0;
            cmbAction2.SelectedIndex = 0;
            cmbAction3.SelectedIndex = 0;
            cmbAction4.SelectedIndex = 0;
            cmbAction5.SelectedIndex = 0;
            cmbAction6.SelectedIndex = 0;
            cmbAction7.SelectedIndex = 0;
            cmbAction8.SelectedIndex = 0;
            cmbAction9.SelectedIndex = 0;
            cmbAction10.SelectedIndex = 0;
            cmbAction11.SelectedIndex = 0;
            cmbAction12.SelectedIndex = 0;
            cmbAction13.SelectedIndex = 0;
            cmbAction14.SelectedIndex = 0;
            cmbAction15.SelectedIndex = 0;
            txtActionParam1.Text = "-1";
            txtActionParam2.Text = "-1";
            txtActionParam3.Text = "-1";
            txtActionParam4.Text = "-1";
            txtActionParam5.Text = "-1";
            txtActionParam6.Text = "-1";
            txtActionParam7.Text = "-1";
            txtActionParam8.Text = "-1";
            txtActionParam9.Text = "-1";
            txtActionParam10.Text = "-1";
            txtActionParam11.Text = "-1";
            txtActionParam12.Text = "-1";
            txtActionParam13.Text = "-1";
            txtActionParam14.Text = "-1";
            txtActionParam15.Text = "-1";

            // Build GMap

            _gmap.BuildgMap();
            Globals.map_center = _gmap.GetCenter();
            GMAPTree.Update_GMapTree(_wpg, _gmaptree);

            // Activate Map Tab

            tabLocation.SelectedIndex = 5;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void imperialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.UnitsMetric = false;
            }

        private void metricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.UnitsMetric = true;       
            }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Update_GUI()
        {
            double alt = Convert.ToDouble(_options.def_altitude);
            double hor_ang = _options.focal_angle_hor;
            double ver_ang = _options.focal_angle_ver;
            }





        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _wpg.WriteXml(_options.def_xml_config_file);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblrecGridLat_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtCircEndAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkForceBorder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private double Modulus(double val1, double val2)
        {
            int i = Convert.ToInt16(val1 / val2);
            return val1 - (i * val2);
        }

        private double Mod_Angle(double ang)
        {
            if (ang >= 0.0 & ang <= 360) return ang;
            if (ang > 360.0)
            {
                do
                {
                    ang = ang - 360.0;
                } while (ang > 360.0);
                return ang;
            }
            if (ang < 0.0)
            {
                do
                {
                    ang = ang + 360;
                } while (ang < 0);
                return ang;
            }
            return ang;
        }

        private void Add_Waypoint(double lat, double lon, double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int[,] actions)
        {
            WayPoints waypoint = new WayPoints();
            waypoint.lat = lat;
            waypoint.lon = lon;
            waypoint.alt = alt;
            waypoint.head = heading;
            waypoint.curvesize = curvesize;
            waypoint.rotationdir = rotdir;
            waypoint.gimblemode = gimblemode;
            waypoint.gimblepitch = gimblepitch;
            waypoint.actions = actions;
            Globals.waypoint_list.AddLast(waypoint);
        }

        public void Add_Man_Waypoint(double lat, double lon, double alt, double heading, double curvesize, double rotdir, int gimblemode, double gimblepitch, int[,] actions)
        {
            WayPoints waypoint = new WayPoints();
            waypoint.lat = lat;
            waypoint.lon = lon;
            waypoint.alt = alt;
            waypoint.head = heading;
            waypoint.curvesize = curvesize;
            waypoint.rotationdir = rotdir;
            waypoint.gimblemode = gimblemode;
            waypoint.gimblepitch = gimblepitch;
            waypoint.actions = actions;
            Globals.manpoint_list.AddLast(waypoint);
            Globals.manpoint_count++;
        }

        public void Message(string text1, string text2)
        {

            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", text1, text2);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Message");
        }

        /*
        private void txtCamHorAngle_TextChanged(object sender, EventArgs e)
        {
            double alt = Convert.ToDouble(txtAltitude.Text);
            double hor_ang = Convert.ToDouble(txtCamHorAngle.Text);
            txtImageLength.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(hor_ang / 2)) * alt));
            Globals.default_cam_hor_ang = txtCamHorAngle.Text;
        }

        private void txtImageHorOverlap_TextChanged(object sender, EventArgs e)
        {
            Globals.default_cam_hor_over = txtImageHorOverlap.Text;
        }

        private void txtImageVerOverlap_TextChanged(object sender, EventArgs e)
        {
            Globals.default_cam_ver_over = txtImageVerOverlap.Text;
        }

        private void txtCamVerAngle_TextChanged(object sender, EventArgs e)
        {
            double alt = Convert.ToDouble(txtAltitude.Text);
            double ver_ang = Convert.ToDouble(txtCamHorAngle.Text);
            txtImageWidth.Text = Convert.ToString(2 * (Math.Tan(GPS.DegreesToRadians(ver_ang / 2)) * alt));
            Globals.default_cam_ver_ang = txtCamVerAngle.Text;
        }
        */
        private void txtElevation_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkFullCircle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtNumCircle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCircleRadius_Click(object sender, EventArgs e)
        {

        }

        private void txtCircleRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtCircNumPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void chkOnePass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtbCircle_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkRectHome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCircHome_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txtLocationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFolderPath_Click(object sender, EventArgs e)
        {

        }

        private void chkCircClearWaypoints_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
 
        private void txtHelixStartAlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioHelixCW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblCircAlt_Click(object sender, EventArgs e)
        {

        }

        private void txtCircAlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvActionsWaypoints_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.ActionWaypoint_Handler)
            {

                int selcnt = dgvActionsWaypoints.SelectedRows.Count;
                //int index = dgvActionsWaypoints.SelectedRows[0].Index;
                int row = e.RowIndex;
                //MessageBox.Show("row : " + Convert.ToString(row) + " count : " + Convert.ToString(selcnt));
                if (row == -1) return;
                Models.Path path = _wpg.PathAt(Globals.ActionsPath);
                LinkedList<WayPoints> wplist = path.waypoints;
                if (wplist.Count() == 1)
                {
                    MessageBox.Show("Error: Can not delete single waypoint, delete path instead");
                    return;
                }
                else {
                    if (selcnt == 0)
                    {
                        WayPoints wp = wplist.ElementAt(row);
                        wplist.Remove(wp);
                    }
                    else {
                        for (int i = 0; i < selcnt; i++)
                        {
                            //MessageBox.Show("row : " + Convert.ToString(row));
                            WayPoints wp = wplist.ElementAt(row);
                            wplist.Remove(wp);
                        }
                    }
                }

                Globals.ActionWaypoint_Handler = false;
                dgvActionsWaypoints.Rows.Clear();
                Globals.ActionWaypoint_Handler = true;
                Globals.Path_Handler = false;
                Update_DGVPath();
                Globals.Path_Handler = true;
                int wp_count = wplist.Count;
                //MessageBox.Show("New Count : " + Convert.ToString(wp_count));
                int count = 0;
                int path_wcount = wplist.Count();
                //MessageBox.Show("Path Count : " + Convert.ToString(path_wcount));

                foreach (WayPoints wp in wplist)
                {
                    double lat = wp.lat;
                    double lon = wp.lon;
                    double alt = wp.alt;
                    double head = wp.head;
                    int gimblemode = wp.gimblemode;
                    double gimblepitch = wp.gimblepitch;
                    double curvesize = wp.curvesize;
                    double rotdir = wp.rotationdir;
                    int[,] actions = wp.actions;
                    if (head < 0.0) head = head + 360.0;
                    dgvActionsWaypoints.Rows.Add(count, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(alt), Convert.ToString(head),
                        Convert.ToString(curvesize), Convert.ToString(rotdir), Convert.ToString(gimblemode), Convert.ToString(gimblepitch)
                        , Convert.ToString(actions[0, 0]), Convert.ToString(actions[0, 1])
                        , Convert.ToString(actions[1, 0]), Convert.ToString(actions[1, 1])
                        , Convert.ToString(actions[2, 0]), Convert.ToString(actions[2, 1])
                        , Convert.ToString(actions[3, 0]), Convert.ToString(actions[3, 1])
                        );
                    count++;
                }
            }
        }

        private void dgvActionsPath_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.Path_Handler)
            {
                int row = e.RowIndex;
                if (row == Globals.ActionsPath)
                {
                    Globals.ActionWaypoint_Handler = false;
                    dgvActionsWaypoints.Rows.Clear();
                    Globals.ActionWaypoint_Handler = true;
                }
                Models.Path path = _wpg.PathAt(row);
                _wpg.DeletePath(path);
                RemovePath_GMapTree(path);
                _gmap.Delete_gMapPath(path);
                //pdate_GMapTree();
            }
        }

        private void dgvPaths_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.Path_Handler)
            {
                int row = e.RowIndex;
                Models.Path path = _wpg.PathAt(row);
                _wpg.DeletePath(path);
                RemovePath_GMapTree(path);
                _gmap.Delete_gMapPath(path);
                //GMAPTree.Update_GMapTree(_wpg, treGMap);;
                Update_DGVPath();
            }
        }

        private void dgvPaths_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.Path_Handler)
            {
                int row = e.RowIndex;
                Models.Path path = _wpg.PathAt(row);
                _wpg.DeletePath(path);
                GMAPTree.Update_GMapTree(_wpg, treGMap); ;
                //RemovePath_GMapTree(path);
                _gmap.Delete_gMapPath(path);
                //GMAPTree.Update_GMapTree(_wpg, treGMap);;
                Update_DGVPath();
                _gmap.ReDrawgMap();
            }
        }

        private void Update_DGVPath()
        {
            int path_count = _wpg.PathCount();

            // Fill Path Table 

            Globals.Path_Handler = false;
            //cmbManualReuse.Items.Clear();
            //cmbCombinePath1.SelectedIndex = -1;
            //cmbCombinePath2.SelectedIndex = -1;
            dgvActionsPath.Rows.Clear();
            Models.Path path;
            LinkedList<WayPoints> waypoint;
            path_count = _wpg.PathCount();
            int count = 0;
            string name, pathname;
            if (path_count > 0)
            {
                do
                {
                    path = _wpg.PathAt(count);
                    name = path.name;
                    pathname = Convert.ToString(count) + " - " + name;
                    waypoint = path.waypoints;
                    int way_count = waypoint.Count();
                    dgvActionsPath.Rows.Add(count, path.name, path.type, way_count);
                    //cmbManualReuse.Items.Add(pathname);
                    count++;
                } while (count < path_count);
            }

            dgvActionsPath.ClearSelection();
            Globals.Path_Handler = true;
        }

        private void RemovePOI_GMapTree(int index)
        {
            int trecnt = treGMap.Nodes[0].Nodes[0].Nodes.Count;
            for (int i = 0; i < trecnt; i++)
            {
                if (index == Convert.ToInt16(treGMap.Nodes[0].Nodes[0].Nodes[i].Tag))
                {
                    treGMap.Nodes[0].Nodes[0].Nodes[i].Remove();
                    break;
                }
            }
        }

        private void RemovePath_GMapTree(Models.Path path)
        {
            int path_id = path.id;
            int trecnt = treGMap.Nodes[0].Nodes[1].Nodes.Count;
            for (int i = 0; i < trecnt; i++)
            {
                int treid = Convert.ToInt16(treGMap.Nodes[0].Nodes[1].Nodes[i].Tag);
                if (path_id == Convert.ToInt16(treGMap.Nodes[0].Nodes[1].Nodes[i].Tag))
                {
                    treGMap.Nodes[0].Nodes[1].Nodes[i].Remove();
                    break;
                }
            }
        }
 
        private void Update_Actioncmb()
        {
            int count = _wpg.ActionCount();
            Models.Action action;
            string name;
            cmbActionsList.Items.Clear();
            cmbActionsWaypoints.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                action = _wpg.ActionAt(i);
                name = action.name;

                cmbActionsList.Items.Add(name);
                cmbActionsWaypoints.Items.Add(name);
            }
            //cmbActionsList.SelectedIndex = 0;
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string name = e.TabPage.Name;

            if (name == "tabGMap")
            {
                GMAPTree.Update_GMapTree(_wpg, treGMap);
                _gmap.ReDrawgMap();
            }

            if (name == "tabGrid")
            {
                //Update_Shapecmb();
            }

            if (name == "tabActions")
            {
                Update_Actioncmb();
                cmbActionsList.SelectedIndex = 0;
            }

            
            if (name == "tabPOI")
            {
                Update_POI_Dgv();
            }
            if (name == "tabLocation")
            {
                Update_POI_Dgv();
            }

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }
 
        private void btnCreatePOIWP_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(txtPOIWP.Text);
            int path_id = Globals.ActionsPath;
            Models.Path path = _wpg.PathAt(path_id);
            LinkedList<WayPoints> waypoints = path.waypoints;
            double lat = waypoints.ElementAt(index).lat;
            double lon = waypoints.ElementAt(index).lon;
            double alt = waypoints.ElementAt(index).alt;
            double elev = _options.def_elevation;

            POIPoints poipoint = new POIPoints();
            poipoint.name = txtPOIWPName.Text;
            poipoint.lat = lat;
            poipoint.lon = lon;
            poipoint.elev = elev;
            poipoint.alt = alt;
            poipoint.cam_alt = 5;
            poipoint.selected = false;
            poipoint.visible = true;
            _wpg.AddPOI(poipoint);
            _gmap.Add_gMapPOI(poipoint);
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            Update_POI_Dgv();
        }

        private void Update_POI_Dgv()
        {
            Button button = new Button();
            Globals.POIpoint_Handler = false;
            //dgvPOI.Columns.RemoveAt(7);
            //dgvPOI.Rows.Clear();
            if (_wpg.POICount() > 0)
            {

                for (int i = 0; i < _wpg.POICount(); i++)
                {
                    POIPoints tmp_point = _wpg.POIPointAt(i);

                    string name = Convert.ToString(tmp_point.name);
                    double lat = tmp_point.lat;
                    double lon = tmp_point.lon;
                    double elev = tmp_point.elev;
                    double alt = tmp_point.alt;
                    double cam_alt = tmp_point.cam_alt;
                    //double lat = button;

                    //dgvPOI.Rows.Add(i + 1, name, Convert.ToString(lat), Convert.ToString(lon),
                    //   Convert.ToString(elev), Convert.ToString(alt), Convert.ToString(cam_alt));
                }

                //dgvPOI.DataSource = dt;
            }
            Globals.POIpoint_Handler = true;
        }
        /*
        private void Update_POI_Cmb()
        {
            //cmbManPOI.Items.Clear();
            //cmbManLoc.Items.Clear();
            cmbLocation.Items.Clear();
            int count = _wpg.POICount(); ;
            if (count > 0)
            {
                //cmbManLoc.Items.Add("");
                for (int i = 0; i < count; i++)
                {
                    POIPoints tmp_point = _wpg.POIPointAt(i);
                    //cmbManPOI.Items.Add(tmp_point.name);
                    //cmbManLoc.Items.Add(tmp_point.name);
                    cmbLocation.Items.Add(tmp_point.name);
                }
            }
            //cmbManPOI.SelectedIndex = 0;
            //cmbManLoc.SelectedIndex = 0;
        }
        */
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void cmbHelixPOI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvActionsPath_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row == -1) return;
            int col = e.ColumnIndex;
            //int path_index = Convert.ToInt16(dgvActionsWaypoints.Rows[row].Cells[0].Value.ToString());

            Models.Path path = _wpg.PathAt(row);
            int path_id = path.id;
            Globals.ActionsPath = row;
            Globals.ActionWaypoint_Handler = false;
            string path_name = path.name;
            string path_type = path.type;
            LinkedList<WayPoints> waypoints = path.waypoints;
            dgvActionsWaypoints.Rows.Clear();
            int wp_count = waypoints.Count;
            int count = 0;
            int path_wcount = waypoints.Count();
            while (count < path_wcount)
            {
                double lat = waypoints.ElementAt(count).lat;
                double lon = waypoints.ElementAt(count).lon;
                double alt = waypoints.ElementAt(count).alt;
                double head = waypoints.ElementAt(count).head;
                int gimblemode = waypoints.ElementAt(count).gimblemode;
                double gimblepitch = waypoints.ElementAt(count).gimblepitch;
                double curvesize = waypoints.ElementAt(count).curvesize;
                double rotdir = waypoints.ElementAt(count).rotationdir;
                int[,] actions = waypoints.ElementAt(count).actions;
                if (head < 0.0) head = head + 360.0;
                dgvActionsWaypoints.Rows.Add(count, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(alt), Convert.ToString(head),
                    Convert.ToString(curvesize), Convert.ToString(rotdir), Convert.ToString(gimblemode), Convert.ToString(gimblepitch)
                    , Convert.ToString(actions[0, 0]), Convert.ToString(actions[0, 1])
                    , Convert.ToString(actions[1, 0]), Convert.ToString(actions[1, 1])
                    , Convert.ToString(actions[2, 0]), Convert.ToString(actions[2, 1])
                    , Convert.ToString(actions[3, 0]), Convert.ToString(actions[3, 1])
                    );
                count++;
            }
            Globals.ActionWaypoint_Handler = true;
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void tabActions_Click(object sender, EventArgs e)
        {

        }

        private void dgvPOI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!Globals.POIpoint_Handler) return;

            int row = e.RowIndex;
            if (row == -1) return;
            int col = e.ColumnIndex;
            if (col < 1) return;
            double cell_value = 0.0;
            string cell_string = "";

            //if (col >= 2 & col < 7) cell_value = Convert.ToDouble(dgvPOI.Rows[row].Cells[col].Value.ToString());
            //else cell_string = dgvPOI.Rows[row].Cells[col].Value.ToString();


            // Get POI

            POIPoints point;
            int count = _wpg.POICount();

            for (int i = 0; i < count; i++)
            {
                point = _wpg.POIPointAt(i);
                if (row == i)
                {
                    POIPoints newpnt = new POIPoints();
                    newpnt = point;
                    if (col == 1) newpnt.name = cell_string;
                    if (col == 2) newpnt.lat = cell_value;
                    if (col == 3) newpnt.lon = cell_value;
                    if (col == 4) newpnt.elev = cell_value;
                    if (col == 5) newpnt.alt = cell_value;
                    if (col == 6) newpnt.cam_alt = cell_value;
                    _wpg.POIReplace(i, newpnt);
                }
            }

        }
 
        private void dgvActionsPath_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row == -1) return;
            int col = e.ColumnIndex;
            if (col != 1)
            {
                return;
            }
            string newname = dgvActionsPath.Rows[row].Cells[col].Value.ToString();
            _wpg.ChangePathName(row, newname);
            Update_DGVPath();
        }
 
        private void dgvWayActionsPath_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore event if turned off

            if (!Globals.ActionWaypoint_Handler) return;

            // Get row & col

            int row = e.RowIndex;
            if (row == -1) return;
            int col = e.ColumnIndex;
            double cell_value = Convert.ToDouble(dgvActionsWaypoints.Rows[row].Cells[col].Value.ToString());

            // Find Waypoint Record

            Models.Path path = _wpg.PathAt(Globals.ActionsPath);
            LinkedList<WayPoints> waypoints = path.waypoints;

            LinkedListNode<WayPoints> node = waypoints.First;
            LinkedListNode<WayPoints> next_node;
            WayPoints new_wp = new WayPoints();
            int count = 0;

            while (node != null)
            {
                next_node = node.Next;
                count++;
                if (count == row + 1)
                {
                    /* Create new wp */

                    new_wp.lat = node.Value.lat;
                    new_wp.lon = node.Value.lon;
                    new_wp.alt = node.Value.alt;
                    new_wp.head = node.Value.head;
                    new_wp.curvesize = node.Value.curvesize;
                    new_wp.rotationdir = node.Value.rotationdir;
                    new_wp.gimblemode = node.Value.gimblemode;
                    new_wp.gimblepitch = node.Value.gimblepitch;
                    new_wp.actions = node.Value.actions;

                    /* Modify value of new_wp */

                    if (col == 1) new_wp.lat = cell_value;
                    if (col == 2) new_wp.lon = cell_value;
                    if (col == 3) new_wp.alt = cell_value;
                    if (col == 4) new_wp.head = cell_value;
                    if (col == 5) new_wp.curvesize = cell_value;
                    if (col == 6) new_wp.rotationdir = cell_value;
                    if (col == 7) new_wp.gimblemode = Convert.ToInt16(cell_value);
                    if (col == 8) new_wp.gimblepitch = cell_value;
                    //if (col == 9) new_wp.actions[0, 0] = Convert.ToInt16(cell_value);
                    //if (col == 10) new_wp.actions[0, 1] = Convert.ToInt16(cell_value);
                    //if (col == 11) new_wp.actions[1, 0] = Convert.ToInt16(cell_value);
                    //if (col == 12) new_wp.actions[1, 1] = Convert.ToInt16(cell_value);

                    /* Action Changed */

                    if (col > 8)
                    {
                        int[,] actions = new int[15, 2];
                        for (int i = 0; i < 15; i++)
                        {
                            actions[i, 0] = node.Value.actions[i, 0];
                            actions[i, 1] = node.Value.actions[i, 1];
                        }
                        int action_id = (col - 9) / 2;
                        if (Odd(col)) actions[action_id, 0] = Convert.ToInt16(cell_value);
                        else actions[action_id, 1] = Convert.ToInt16(cell_value);
                        new_wp.actions = actions;
                    }

                    waypoints.AddBefore(node, new_wp);
                    waypoints.Remove(node);
                }

                node = next_node;
            }
        }

        private bool Odd(int val)
        {
            int vald2 = val / 2;
            int rem = val - vald2 * 2;
            if (rem == 0) return false;
            else return true;
        }


        /*
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string location = cmbLocation.SelectedItem.ToString();

            // Loop Thru POI to find location

            for (int i = 0; i < _wpg.POICount(); i++)
            {
                POIPoints tmp_point = _wpg.POIPointAt(i);
                string name = tmp_point.name;
                if (name == location)
                {
                    Globals.default_location = name;
                    txtCenterLat.Text = Convert.ToString(tmp_point.lat);
                    txtCenterLon.Text = Convert.ToString(tmp_point.lon);
                    txtElevation.Text = Convert.ToString(tmp_point.elev);
                    txtAltitude.Text = Convert.ToString(tmp_point.alt);
                    //cmbManPOI.SelectedIndex = i;
                    Globals.gps_radius = _options.earth_radius + Convert.ToDouble(txtElevation.Text) + Convert.ToDouble(txtAltitude.Text);
                    txtGPSRadius.Text = Convert.ToString(Globals.gps_radius);
                }
            }
        }
*/
        private void lblAltitude_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void chkGenCamRect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "wpg.xml";
            saveFileDialog1.DefaultExt = ".xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                _wpg.WriteXml(filename);
            }
        }

        private void browseXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                _wpg.ReadXml_Config(filename);
                _wpg.ReadXml_POI(filename);
                _wpg.ReadXml_Path(filename);
                _wpg.ReadXml_Actions(filename);
                _wpg.ReadXml_Polygon(filename);
                GMAPTree.Update_GMapTree(_wpg, treGMap);
                _gmap.ReDrawgMap();
                Update_POI_Dgv();
                Update_DGVPath();
                Update_Actioncmb();
                //Update_Shapecmb();
                Update_GUI();
            }
        }

        private void startupXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("waypoint_path_generator.xml")) _wpg.ReadPOI();
            else {
                _wpg.ReadXml_Config("waypoint_path_generator.xml");
                _wpg.ReadXml_POI("waypoint_path_generator.xml");
                _wpg.ReadXml_Path("waypoint_path_generator.xml");
                _wpg.ReadXml_Actions("waypoint_path_generator.xml");
                _wpg.ReadXml_Polygon("waypoint_path_generator.xml");
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
            Update_POI_Dgv();
            Update_DGVPath();
            Update_Actioncmb();
            //Update_Shapecmb();
            Update_GUI();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAction2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearActionsGUI_Click(object sender, EventArgs e)
        {
            txtNewActionName.Text = "";
            cmbAction1.SelectedIndex = 0;
            cmbAction2.SelectedIndex = 0;
            cmbAction3.SelectedIndex = 0;
            cmbAction4.SelectedIndex = 0;
            cmbAction5.SelectedIndex = 0;
            cmbAction6.SelectedIndex = 0;
            cmbAction7.SelectedIndex = 0;
            cmbAction8.SelectedIndex = 0;
            cmbAction9.SelectedIndex = 0;
            cmbAction10.SelectedIndex = 0;
            cmbAction11.SelectedIndex = 0;
            cmbAction12.SelectedIndex = 0;
            cmbAction13.SelectedIndex = 0;
            cmbAction14.SelectedIndex = 0;
            cmbAction15.SelectedIndex = 0;
            txtActionParam1.Text = "-1";
            txtActionParam2.Text = "-1";
            txtActionParam3.Text = "-1";
            txtActionParam4.Text = "-1";
            txtActionParam5.Text = "-1";
            txtActionParam6.Text = "-1";
            txtActionParam7.Text = "-1";
            txtActionParam8.Text = "-1";
            txtActionParam9.Text = "-1";
            txtActionParam10.Text = "-1";
            txtActionParam11.Text = "-1";
            txtActionParam12.Text = "-1";
            txtActionParam13.Text = "-1";
            txtActionParam14.Text = "-1";
            txtActionParam15.Text = "-1";
        }

        private void cmbActionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbActionsList.SelectedIndex;
            Models.Action action = _wpg.ActionAt(index);
            string name = action.name;
            int[,] actions = action.actions;
            txtNewActionName.Text = name;

            cmbAction1.SelectedIndex = actions[0, 0] + 1;
            txtActionParam1.Text = Convert.ToString(actions[0, 1]);
            cmbAction2.SelectedIndex = actions[1, 0] + 1;
            txtActionParam2.Text = Convert.ToString(actions[1, 1]);
            cmbAction3.SelectedIndex = actions[2, 0] + 1;
            txtActionParam3.Text = Convert.ToString(actions[2, 1]);
            cmbAction4.SelectedIndex = actions[3, 0] + 1;
            txtActionParam4.Text = Convert.ToString(actions[3, 1]);
            cmbAction5.SelectedIndex = actions[4, 0] + 1;
            txtActionParam5.Text = Convert.ToString(actions[4, 1]);
            cmbAction6.SelectedIndex = actions[5, 0] + 1;
            txtActionParam6.Text = Convert.ToString(actions[5, 1]);
            cmbAction7.SelectedIndex = actions[6, 0] + 1;
            txtActionParam7.Text = Convert.ToString(actions[6, 1]);
            cmbAction8.SelectedIndex = actions[7, 0] + 1;
            txtActionParam8.Text = Convert.ToString(actions[7, 1]);
            cmbAction9.SelectedIndex = actions[8, 0] + 1;
            txtActionParam9.Text = Convert.ToString(actions[8, 1]);
            cmbAction10.SelectedIndex = actions[9, 0] + 1;
            txtActionParam10.Text = Convert.ToString(actions[9, 1]);
            cmbAction11.SelectedIndex = actions[10, 0] + 1;
            txtActionParam11.Text = Convert.ToString(actions[10, 1]);
            cmbAction12.SelectedIndex = actions[11, 0] + 1;
            txtActionParam12.Text = Convert.ToString(actions[11, 1]);
            cmbAction13.SelectedIndex = actions[12, 0] + 1;
            txtActionParam13.Text = Convert.ToString(actions[12, 1]);
            cmbAction14.SelectedIndex = actions[13, 0] + 1;
            txtActionParam14.Text = Convert.ToString(actions[13, 1]);
            cmbAction15.SelectedIndex = actions[14, 0] + 1;
            txtActionParam15.Text = Convert.ToString(actions[14, 1]);
        }

        private void btnSaveAction_Click(object sender, EventArgs e)
        {
            int[,] actions = new int[15, 2];

            actions[0, 0] = cmbAction1.SelectedIndex - 1;
            actions[0, 1] = Convert.ToInt16(txtActionParam1.Text);
            actions[1, 0] = cmbAction2.SelectedIndex - 1;
            actions[1, 1] = Convert.ToInt16(txtActionParam2.Text);
            actions[2, 0] = cmbAction3.SelectedIndex - 1;
            actions[2, 1] = Convert.ToInt16(txtActionParam3.Text);
            actions[3, 0] = cmbAction4.SelectedIndex - 1;
            actions[3, 1] = Convert.ToInt16(txtActionParam4.Text);
            actions[4, 0] = cmbAction5.SelectedIndex - 1;
            actions[4, 1] = Convert.ToInt16(txtActionParam5.Text);
            actions[5, 0] = cmbAction6.SelectedIndex - 1;
            actions[5, 1] = Convert.ToInt16(txtActionParam6.Text);
            actions[6, 0] = cmbAction7.SelectedIndex - 1;
            actions[6, 1] = Convert.ToInt16(txtActionParam7.Text);
            actions[7, 0] = cmbAction8.SelectedIndex - 1;
            actions[7, 1] = Convert.ToInt16(txtActionParam8.Text);
            actions[8, 0] = cmbAction9.SelectedIndex - 1;
            actions[8, 1] = Convert.ToInt16(txtActionParam9.Text);
            actions[9, 0] = cmbAction10.SelectedIndex - 1;
            actions[9, 1] = Convert.ToInt16(txtActionParam10.Text);
            actions[10, 0] = cmbAction11.SelectedIndex - 1;
            actions[10, 1] = Convert.ToInt16(txtActionParam11.Text);
            actions[11, 0] = cmbAction12.SelectedIndex - 1;
            actions[11, 1] = Convert.ToInt16(txtActionParam12.Text);
            actions[12, 0] = cmbAction13.SelectedIndex - 1;
            actions[12, 1] = Convert.ToInt16(txtActionParam13.Text);
            actions[13, 0] = cmbAction14.SelectedIndex - 1;
            actions[13, 1] = Convert.ToInt16(txtActionParam14.Text);
            actions[14, 0] = cmbAction15.SelectedIndex - 1;
            actions[14, 1] = Convert.ToInt16(txtActionParam15.Text);

            Models.Action action = new Models.Action();
            action.name = txtNewActionName.Text;
            action.actions = actions;
            _wpg.AddAction(action);
            Update_Actioncmb();
        }

        private void btnDelectAction_Click(object sender, EventArgs e)
        {
            string name = txtNewActionName.Text;
            _wpg.DeleteAction(name);
            Update_Actioncmb();
            cmbActionsList.SelectedIndex = 0;
        }

        private void cmbActionsWaypoints_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyAction_Click(object sender, EventArgs e)
        {
            string text;
            // Get action to Apply
            int index = cmbActionsWaypoints.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("No Action Selected ...", "Apply Actions");
                return;
            }
            int path_id = Globals.ActionsPath;
            if (path_id == -1)
            {
                MessageBox.Show("No Path Selected ...", "Apply Actions");
                return;
            }
            Models.Path path = _wpg.PathAt(path_id);
            LinkedList<WayPoints> waypoints = path.waypoints;

            int wpcount = waypoints.Count();

            // Get start and End waypoints

            int wp_start = Convert.ToInt16(txtWPStart.Text);
            int wp_end = Convert.ToInt16(txtWPEnd.Text);
            bool err = false;
            if (wp_start < 0 | wp_end < 0) err = true;
            if (wp_start > wpcount - 1 | wp_end > wpcount - 1) err = true;
            if (wp_start > wp_end & wp_end != 0) err = true;
            if (err)
            {
                text = "Error in start and end Way point.\n";
                MessageBox.Show(text, "Apply Actions");
                return;
            }

            Models.Action action = _wpg.ActionAt(index);
            string name = action.name;
            int[,] actions = action.actions;

            LinkedListNode<WayPoints> node = waypoints.First;
            LinkedListNode<WayPoints> nextnode;
            int count = 0;
            while (node != null)
            {
                nextnode = node.Next;
                if (count >= wp_start & count <= wp_end)
                {
                    WayPoints wppoint = new WayPoints();
                    wppoint.lat = node.Value.lat;
                    wppoint.lon = node.Value.lon;
                    wppoint.alt = node.Value.alt;
                    wppoint.head = node.Value.head;
                    wppoint.curvesize = node.Value.curvesize;
                    wppoint.rotationdir = node.Value.rotationdir;
                    wppoint.gimblemode = node.Value.gimblemode;
                    wppoint.gimblepitch = node.Value.gimblepitch;
                    wppoint.actions = actions;
                    waypoints.AddBefore(node, wppoint);
                    waypoints.Remove(node);
                }
                count++;
                node = nextnode;
            }

            // Clear for next round

            txtWPStart.Text = "0";
            txtWPEnd.Text = "0";
            cmbActionsWaypoints.SelectedIndex = 0;

            // Redo dgv

            Globals.ActionWaypoint_Handler = false;
            dgvActionsWaypoints.Rows.Clear();
            Globals.ActionWaypoint_Handler = true;
            int wp_count = waypoints.Count;
            count = 0;
            int path_wcount = waypoints.Count();
            while (count < path_wcount)
            {
                double lat = waypoints.ElementAt(count).lat;
                double lon = waypoints.ElementAt(count).lon;
                double alt = waypoints.ElementAt(count).alt;
                double head = waypoints.ElementAt(count).head;
                int gimblemode = waypoints.ElementAt(count).gimblemode;
                double gimblepitch = waypoints.ElementAt(count).gimblepitch;
                double curvesize = waypoints.ElementAt(count).curvesize;
                double rotdir = waypoints.ElementAt(count).rotationdir;
                int[,] wpactions = waypoints.ElementAt(count).actions;
                if (head < 0.0) head = head + 360.0;
                dgvActionsWaypoints.Rows.Add(count, Convert.ToString(lat), Convert.ToString(lon), Convert.ToString(alt), Convert.ToString(head),
                    Convert.ToString(curvesize), Convert.ToString(rotdir), Convert.ToString(gimblemode), Convert.ToString(gimblepitch)
                    , Convert.ToString(wpactions[0, 0]), Convert.ToString(wpactions[0, 1])
                    , Convert.ToString(wpactions[1, 0]), Convert.ToString(wpactions[1, 1])
                    , Convert.ToString(wpactions[2, 0]), Convert.ToString(wpactions[2, 1])
                    , Convert.ToString(wpactions[3, 0]), Convert.ToString(wpactions[3, 1])
                    );
                count++;
            }
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void dgvPolygons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }
        private void dgvPolygons_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.Shape_Handler)
            {
                int row = e.RowIndex;
                Models.Shape shape = _wpg.ShapeAt(row);
                _wpg.DeleteShape(shape);
                //Update_Shapecmb();
                _gmap.Delete_gMapPoly(shape);
                GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            }
        }

        private void txtPOILat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPOILat_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numeric = false;

            TextBox txt = (sender as TextBox);
            if (numeric)
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
            else
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        e.Handled = false;
                    else
                    {
                        // If the first character is a decimal point or digit, AND
                        // if the text does not contain a decimal point OR the selected text DOES contain a decimal point.
                        if ((e.KeyChar == '.' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains(".") || txt.SelectedText.Contains(".")))
                            e.Handled = false;
                        else
                            e.Handled = true;
                    }
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace OR
                    // a decimal point AND
                    // if the text does not contain a decimal point or the selected text does contain a decimal point.
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || (e.KeyChar == '.' && (!txt.Text.Contains(".") || txt.SelectedText.Contains("."))))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }

            }
        }

        private void textPosNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool numeric = false;

            TextBox txt = (sender as TextBox);
            if (numeric)
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
            else
            {
                // Test first character - either text is blank or the selection starts at first character.
                if (txt.Text == "" || txt.SelectionStart == 0)
                {
                    // If the first character is a minus or digit, AND
                    // if the text does not contain a minus OR the selected text DOES contain a minus.
                    //if ((e.KeyChar == '-' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                    if ((char.IsDigit(e.KeyChar)) && (!txt.Text.Contains("-") || txt.SelectedText.Contains("-")))
                        e.Handled = false;
                    else
                    {
                        // If the first character is a decimal point or digit, AND
                        // if the text does not contain a decimal point OR the selected text DOES contain a decimal point.
                        if ((e.KeyChar == '.' || char.IsDigit(e.KeyChar)) && (!txt.Text.Contains(".") || txt.SelectedText.Contains(".")))
                            e.Handled = false;
                        else
                            e.Handled = true;
                    }
                }
                else
                {
                    // If it's not the first character, then it must be a digit or backspace OR
                    // a decimal point AND
                    // if the text does not contain a decimal point or the selected text does contain a decimal point.
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || (e.KeyChar == '.' && (!txt.Text.Contains(".") || txt.SelectedText.Contains("."))))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }

            }
        }

        /*
        private void textNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        */
        private void txtPOILat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPOILon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCamHorAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCamVerAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtImageHorOverlap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtImageVerOverlap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtElevation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAltitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGPSRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPOIElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPOIAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPOICamAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCurrentLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCurrentlon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGridLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGridWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }


        private void dgvPOI_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int row = e.Row.Index;
            if (row == 0)
            {
                MessageBox.Show("Error : Can not delete first POI");
                e.Cancel = true;
            }
        }

        private void dgvPOI_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Globals.POIpoint_Handler)
            {
                int row = e.RowIndex;
                if (row == 0)
                {
                    MessageBox.Show("Error : Can not delete first POI");
                    return;
                }
                RemovePOI_GMapTree(row);
                _gmap.Delete_gMapPOI(_wpg.POIPointAt(row));
                GMAPTree.Update_GMapTree(_wpg, treGMap); ;
                _wpg.POIPointDeleteAt(row);
                //Globals.POIpoint_Handler = false;
                Update_POI_Dgv();
            }

        }

        private void txtGridLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGridLength_Click(object sender, EventArgs e)
        {

        }

        private void lblGridAlt_Click(object sender, EventArgs e)
        {

        }
 
        private void dgvActionsWaypoints_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            double num;
            dgvActionsWaypoints.Rows[e.RowIndex].ErrorText = String.Empty;
            // Check for value empty
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {

                dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Value must not be empty";
                e.Cancel = true;
                return;
            }
            String text = e.FormattedValue.ToString();
            // Check Cols 1 thru the end for numeric values
            if (col >= 1)
            {
                if (!double.TryParse(text, out num))
                {
                    dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Value must be numeric";
                    e.Cancel = true;
                    return;
                }
            }
            num = Convert.ToDouble(text);
            // Check Columns for positive values
            if (col == 3 | col == 5)
            {
                if (num < 0)
                {
                    dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Value must be positive";
                    e.Cancel = true;
                    return;
                }
            }
            // Check Gimble Mode, -1,0,1,2,3,4,5
            if (col == 7)
            {
                int intval;
                if (!int.TryParse(text, out intval))
                {
                    dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Value must be integer 0 or 2";
                    e.Cancel = true;
                    return;
                }
                if (intval != 0 & intval != 2)
                {
                    dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Value must be integer 0 or 2";
                    e.Cancel = true;
                    return;
                }
            }
            // Check Gimble Pitch
            if (col == 8)
            {
                if (num > 15.0 | num < -90.0)
                {
                    dgvActionsWaypoints.Rows[e.RowIndex].ErrorText =
                    "Pitch must be between -90 and 15";
                    e.Cancel = true;
                    return;
                }
            }
        }
 
        private void dgvActionsWaypoints_MouseUp(object sender, MouseEventArgs e)
        {
            if (Globals.ActionWaypoint_Handler)
            {
                Models.Path path = _wpg.PathAt(Globals.ActionsPath);
                LinkedList<WayPoints> waypoints = path.waypoints;
                int wpcount = waypoints.Count;
                if (dgvActionsWaypoints.AreAllCellsSelected(true))
                {
                    txtWPStart.Text = "0";
                    txtWPEnd.Text = Convert.ToString(wpcount - 1);
                    txtPOIWP.Text = "0";
                    txtPOIWPName.Text = "WP - 0";
                    return;
                }
                int row_start = 1000;
                int row_end = -1;
                int count = dgvActionsWaypoints.SelectedRows.Count;
                if (count == 1)
                {
                    int index = dgvActionsWaypoints.SelectedRows[0].Index;
                    txtWPStart.Text = Convert.ToString(index);
                    txtPOIWP.Text = Convert.ToString(index);
                    txtPOIWPName.Text = "WP - " + Convert.ToString(index);
                    txtWPEnd.Text = Convert.ToString(index);
                    return;
                }
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int index = dgvActionsWaypoints.SelectedRows[i].Index;
                        if (index < row_start) row_start = index;
                        if (index > row_end) row_end = index;
                    }
                    txtWPStart.Text = Convert.ToString(row_start);
                    txtPOIWP.Text = Convert.ToString(row_start);
                    txtPOIWPName.Text = "WP - " + Convert.ToString(row_start);
                    txtWPEnd.Text = Convert.ToString(row_end);
                }

            }
        }
  
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabManual_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void radioCCW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioCW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHelixEndAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void txtCombineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvOutPaths_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void trkMapSize_Scroll(object sender, EventArgs e)
        {

        }

        private string TrimTo(string text, int places)
        {
            if (!text.Contains(".")) return text;
            int index = text.IndexOf(".");
            int len = text.Length;
            if (index + places + 1 <= len) return text.Substring(0, index + places + 1);
            else return text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cmbGMapProvider.SelectedIndex;
            _gmap = new GMAP(_wpg, gMapControl, index);
            _gmap.BuildgMap();
            _gmap.SetCenter(Globals.map_center.Lat, Globals.map_center.Lng);
            //GMAPTree.Update_GMapTree(_wpg, treGMap);;
        }

        private void tabGMap_Click(object sender, EventArgs e)
        {

        }

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string marker_tag = Convert.ToString(item.Tag);
            //MessageBox.Show(marker_tag);
            int index = marker_tag.IndexOf(".");
            if (index != -1)
            {
                // Change the Selection status of the way point marker

                string button = Convert.ToString(e.Button);
                int indexwp = Convert.ToInt16(marker_tag.Substring(index + 1));
                int indexpath = Convert.ToInt16(marker_tag.Substring(0, index));
                Models.Path path = _wpg.PathAt(indexpath);
                LinkedList<WayPoints> wp_list = path.waypoints;
                LinkedListNode<WayPoints> node = wp_list.First;
                LinkedListNode<WayPoints> next_node;
                int count = 0;

                while (node != null)
                {
                    next_node = node.Next;
                    if (count == indexwp)
                    {
                        node.Value.selected = !node.Value.selected;
                        _gmap.ReDrawgMap();
                        break;
                    }
                    node = next_node;
                    count++;
                }

            }
            else
            {
                for (int i = 0; i < _wpg.POICount(); i++)
                {
                    POIPoints pnt = _wpg.POIPointAt(i);
                    if (pnt.name == marker_tag) pnt.selected = !pnt.selected;
                }
                string button = Convert.ToString(e.Button);
                string type = Convert.ToString(item.GetType());
                string name = Convert.ToString(item.Tag);
                double lat = item.Position.Lat;
                double lon = item.Position.Lng;
                string text = "Marker Type :" + type + "\n";
                text = text + "Marker Tag : " + marker_tag + "\n";
                text = text + "Path : " + name + "\n";
                text = text + "Latitude : " + Convert.ToString(lat) + "\n";
                text = text + "Longitude :" + Convert.ToString(lon) + "\n";
                //text = text + "Button : " + button + "\n";
                //MessageBox.Show(text);
            }
        }

        private void gMap_MouseUp(object sender, MouseEventArgs e)
        {
            _gmap.ReDrawgMap();
            Globals.MouseDown = false;
            //cntxtgMap.Close();
            //GMAPTree.Update_GMapTree(_wpg, treGMap);;
            Update_POI_Dgv();
        }

        private void gMap_MouseDown(object sender, MouseEventArgs e)
        {

            Globals.mouse_down_lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            Globals.mouse_down_lon = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
            int x = e.X;
            int y = e.Y;
            Globals.MouseDown = true;
            //cntxtgMap.Show(x,y);
        }

        private void cntxtgMap_MouseLeave(object sender, EventArgs e)
        {
            //cntxtgMap.Close();
        }
        private void gMap_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void gMap_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gMap_DragEnter_1(object sender, DragEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Show_gMap(TreeNode node, int index, bool visible)
        {
            TreeNode parent = node.Parent;
            string parent_tag = Convert.ToString(node.Parent.Tag);
            int tag = Convert.ToInt16(node.Tag);
            string parentname = Convert.ToString(parent.Text);
            string name = Convert.ToString(node.Text);
            int level = node.Level;
            int overcount = gMapControl.Overlays.Count();
            //MessageBox.Show("Overlay count : " + Convert.ToString(overcount));

            // Set POI Visibility

            if (parentname == "POIs")
            {

                GMapOverlay overlay = gMapControl.Overlays.ElementAt(0);
                foreach (GMarkerGoogle marker in overlay.Markers)
                {

                    string markername = Convert.ToString(marker.Tag);
                    if (markername == name)
                    {
                        marker.IsVisible = visible;

                        // Set POI visibility
                        _wpg.POIPointAt(tag).visible = visible;
                    }
                }

            }

            // Set Path Visibility

            if (parentname == "Paths")
            {
                GMapOverlay overlay = gMapControl.Overlays.ElementAt(1);
                foreach (GMapRoute path in overlay.Routes)
                {
                    int pathtag = Convert.ToInt16(path.Tag);
                    if (pathtag == tag)
                    {
                        path.IsVisible = visible;
                        Models.Path new_path = _wpg.PathAt(tag);
                        new_path.visible = visible;
                        _wpg.ReplacePath(tag, new_path);

                        foreach (PointLatLng pathpnt in path.Points)
                        {
                            double lat = pathpnt.Lat;
                            double lon = pathpnt.Lng;
                            GMapOverlay marklay = gMapControl.Overlays.ElementAt(0);
                            foreach (GMarkerGoogle marker in marklay.Markers)
                            {
                                double mlat = marker.Position.Lat;
                                double mlon = marker.Position.Lng;
                                if (lat == mlat & lon == mlon) marker.IsVisible = visible;
                            }
                        }
                    }

                }


            }

            // Set Polygon Visibility

            if (parentname == "Polygons")
            {
                GMapOverlay overlay = gMapControl.Overlays.ElementAt(2);
                foreach (GMapPolygon poly in overlay.Polygons)
                {

                    string polyname = Convert.ToString(poly.Tag);
                    if (polyname == name)
                    {
                        poly.IsVisible = visible;
                    }

                }
                int shapecount = _wpg.ShapeCount();
                for (int i = 0; i < shapecount; i++)
                {
                    if (name == _wpg.ShapeAt(i).name) _wpg.ShapeAt(i).visible = visible;
                }
            }
        }

        private void treGMap_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!Globals.TreView_Handler) return;

            Globals.TreView_Handler = false;

            TreeNode node = e.Node;
            int index = e.Node.Index;
            //MessageBox.Show("text of node is : " + e.Node.Text + ", Index is " + Convert.ToString(index));

            // Object Box

            if (e.Node.Text == "Objects")
            {
                int level1_count = treGMap.GetNodeCount(false);
                int level2_count = treGMap.Nodes[0].GetNodeCount(false);
                for (int i = 0; i < level2_count; i++)
                {
                    if (e.Node.Checked)
                    {
                        treGMap.Nodes[0].Nodes[i].Checked = true;
                        //Show_gMap(treGMap.Nodes[0].Nodes[i], true);
                    }
                    else { treGMap.Nodes[0].Nodes[i].Checked = false; }

                    int level3_count = treGMap.Nodes[0].Nodes[i].GetNodeCount(false);

                    for (int j = 0; j < level3_count; j++)
                    {
                        if (e.Node.Checked)
                        {
                            treGMap.Nodes[0].Nodes[i].Nodes[j].Checked = true;
                            Show_gMap(treGMap.Nodes[0].Nodes[i].Nodes[j], j, true);
                        }

                        else {
                            treGMap.Nodes[0].Nodes[i].Nodes[j].Checked = false;
                            Show_gMap(treGMap.Nodes[0].Nodes[i].Nodes[j], j, false);
                        }
                    }
                }
                Globals.TreView_Handler = true;
                return;
            }

            if (e.Node.Text == "POIs")
            {
                int level2_count = treGMap.Nodes[0].Nodes[0].GetNodeCount(false);
                for (int i = 0; i < level2_count; i++)
                {
                    //MessageBox.Show(Convert.ToString(treGMap.Nodes[0].Nodes[0].Nodes[0].Text));
                    if (e.Node.Checked)
                    {
                        treGMap.Nodes[0].Nodes[0].Nodes[i].Checked = true;
                        Show_gMap(treGMap.Nodes[0].Nodes[0].Nodes[i], i, true);
                    }
                    else {
                        treGMap.Nodes[0].Nodes[0].Nodes[i].Checked = false;
                        Show_gMap(treGMap.Nodes[0].Nodes[0].Nodes[i], i, false);
                    }
                }
                Globals.TreView_Handler = true;
                return;
            }

            if (e.Node.Text == "Paths")
            {
                int level2_count = treGMap.Nodes[0].Nodes[1].GetNodeCount(false);
                for (int i = 0; i < level2_count; i++)
                {
                    //MessageBox.Show(Convert.ToString(treGMap.Nodes[0].Nodes[1].Nodes[i].Text));
                    if (e.Node.Checked)
                    {
                        treGMap.Nodes[0].Nodes[1].Nodes[i].Checked = true;
                        Show_gMap(treGMap.Nodes[0].Nodes[1].Nodes[i], i, true);
                    }
                    else
                    {
                        treGMap.Nodes[0].Nodes[1].Nodes[i].Checked = false;
                        Show_gMap(treGMap.Nodes[0].Nodes[1].Nodes[i], i, false);
                    }
                }
                Globals.TreView_Handler = true;
                return;
            }

            if (e.Node.Text == "Polygons")
            {
                int level2_count = treGMap.Nodes[0].Nodes[2].GetNodeCount(false);
                for (int i = 0; i < level2_count; i++)
                {
                    //MessageBox.Show(Convert.ToString(treGMap.Nodes[0].Nodes[0].Nodes[0].Text));
                    if (e.Node.Checked)
                    {
                        treGMap.Nodes[0].Nodes[2].Nodes[i].Checked = true;
                        Show_gMap(treGMap.Nodes[0].Nodes[2].Nodes[i], i, true);
                    }
                    else
                    {
                        treGMap.Nodes[0].Nodes[2].Nodes[i].Checked = false;
                        Show_gMap(treGMap.Nodes[0].Nodes[2].Nodes[i], i, false);
                    }

                }
                Globals.TreView_Handler = true;
                return;
            }

            // Leaf node checked

            if (e.Node.Checked)
            {
                e.Node.Checked = true;
                Show_gMap(e.Node, -1, true);
            }
            else
            {
                e.Node.Checked = false;
                Show_gMap(e.Node, -1, false);
            }
            //            string tag = Convert.ToString(e.Node);
            //            MessageBox.Show(tag);


            Globals.TreView_Handler = true;
        }

        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            int[,] actions = new int[,] { { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 }, { -1, 0 } };
            double old_lat = Convert.ToDouble(txtMouseLat.Text);
            double old_lon = Convert.ToDouble(txtMouseLon.Text);
            txtMouseLat.Text = Convert.ToString(gMapControl.FromLocalToLatLng(e.X, e.Y).Lat);
            txtMouseLon.Text = Convert.ToString(gMapControl.FromLocalToLatLng(e.X, e.Y).Lng);
            double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            double lon = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
            double lat_delta = lat - old_lat;
            double lon_delta = lon - old_lon;
            Double scale = gMapControl.Zoom;
            string button = Convert.ToString(e.Button);
            trkMapScale.Value = Convert.ToInt16(scale);

            // See whether to redraw Tree View

            int path_count = _wpg.PathCount();
            //int tree_path_count = treGMap.Nodes[1].Nodes.Count;
            //GMAPTree.Update_GMapTree(_wpg, treGMap);;

            // Adjust selected waypoint

            if (Globals.MouseDown & button == "Left")
            {
                // Move Waypoints

                for (int i = 0; i < path_count; i++)
                {
                    Models.Path path = _wpg.PathAt(i);
                    LinkedList<WayPoints> wp_list = path.waypoints;
                    int wpcount = 0;
                    foreach (WayPoints wp in wp_list)
                    {
                        if (wp.selected)
                        {
                            wp.lat = wp.lat + lat_delta;
                            wp.lon = wp.lon + lon_delta;
                            _gmap.UpdateMarkerPos(i, wpcount, new PointLatLng(wp.lat, wp.lon));
                        }
                        wpcount++;
                    }

                }

                // Move POIs

                for (int i = 0; i < _wpg.POICount(); i++)
                {
                    POIPoints pnt = _wpg.POIPointAt(i);
                    if (pnt.selected)
                    {
                        pnt.lat = pnt.lat + lat_delta;
                        pnt.lon = pnt.lon + lon_delta;
                    }
                }
                _gmap.ReDrawgMap();
                return;
            }

            // Rotate WayPoints

            if (Globals.MouseDown & button == "Middle")
            {
                double bearing, distance, new_lat, new_lon;
                double dir_flag = 1.0;
                if (lat_delta < 0) dir_flag = -1.0;
                path_count = _wpg.PathCount();
                for (int i = 0; i < path_count; i++)
                {
                    // Only rotate it entire path selected
                    Models.Path path = _wpg.PathAt(i);
                    if (path.selected)
                    {
                        LinkedList<WayPoints> wp_list = path.waypoints;
                        int wpcount = wp_list.Count(); ;
                        //WayPoints wp0 = wp_list.ElementAt(0);
                        if (wpcount > 1)
                        {
                            for (int j = 0; j < wpcount; j++)
                            {
                                WayPoints wp = wp_list.ElementAt(j);


                                bearing = GPS.GPS_Bearing(Globals.mouse_down_lat, Globals.mouse_down_lon, wp.lat, wp.lon);
                                distance = GPS.GPS_Distance(Globals.mouse_down_lat, Globals.mouse_down_lon, wp.lat, wp.lon, Globals.gps_radius);
                                new_lat = GPS.GPS_Lat_BearDist(Globals.mouse_down_lat, Globals.mouse_down_lon, bearing + 1.0 * dir_flag, distance, Globals.gps_radius);
                                new_lon = GPS.GPS_Lon_BearDist(Globals.mouse_down_lat, Globals.mouse_down_lon, new_lat, bearing + 1.0 * dir_flag, distance, Globals.gps_radius);
                                wp.lat = new_lat;
                                wp.lon = new_lon;
                                _gmap.UpdateMarkerPos(i, j, new PointLatLng(wp.lat, wp.lon));
                            }
                        }
                    }

                }
                _gmap.ReDrawgMap();
            }

            // Add Waypoint to New Path

            if (Globals.path_active)
            {
                LinkedList<WayPoints> wp_list = _path.waypoints;
                wp_list.RemoveLast();
                WayPoints wp_last = wp_list.Last();
                double lat_last = wp_last.lat;
                double lon_last = wp_last.lon;
                _wp = new WayPoints();
                _wp.lat = lat;
                _wp.lon = lon;
                _wp.head = GPS.GPS_Bearing(lat_last, lon_last, lat, lon);
                _wp.visible = true;
                _wp.selected = false;
                _wp.alt = _options.def_altitude;
                _wp.actions = actions;
                wp_list.AddLast(_wp);
                _path.waypoints = wp_list;
                _gmap.ReDrawgMap();
            }
        }

        private void rtbMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMapPOI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngMapRedraw_Click(object sender, EventArgs e)
        {
            _gmap.ReDrawgMap();
            //GMAPTree.Update_GMapTree(_wpg, treGMap);;
        }

        private void treGMap_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void gMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Double Click");
        }

        private void SelectPath(Models.Path path, bool selected)
        {
            path.selected = selected;
            LinkedList<WayPoints> wp_list = path.waypoints;
            foreach (WayPoints wp in wp_list)
            {
                wp.selected = selected;
            }
            _gmap.ReDrawgMap();
        }

        private void gMap_OnRouteClick(GMapRoute item, MouseEventArgs e)
        {
            int id = Convert.ToInt16(item.Tag);
            //_path = _wpg.PathAt(id);
            bool selected = _wpg.PathAt(id).selected;
            //if(!selected)Globals.path_active = true;
            SelectPath(_wpg.PathAt(id), !selected);
        }

        private void gMap_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            string name = Convert.ToString(item.Tag);
            for (int i = 0; i < _wpg.ShapeCount(); i++)
            {
                if (name == _wpg.ShapeAt(i).name) _wpg.ShapeAt(i).selected = !_wpg.ShapeAt(i).selected;
            }
            _gmap.ReDrawgMap();
        }

        private void gMap_OnMapDrag()
        {
            Globals.map_center = gMapControl.Position;
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            //Globals.map_center = gMap.Position;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolReDrawgMap_Click(object sender, EventArgs e)
        {
            _gmap.ReDrawgMap();
        }

        private void ToolAddPOI_Click(object sender, EventArgs e)
        {
            frmAddPOI form = new frmAddPOI(_wpg, _gmap, Globals.mouse_down_lat, Globals.mouse_down_lon);
            form.ShowDialog();
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            Update_POI_Dgv();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void ToolAllPOIShow_Click(object sender, EventArgs e)
        {
            int poicount = _wpg.POICount();
            for (int i = 0; i < poicount; i++)
            {
                _wpg.POIPointAt(i).visible = true;
            }
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void ToolAllPOIHide_Click(object sender, EventArgs e)
        {
            int poicount = _wpg.POICount();
            for (int i = 0; i < poicount; i++)
            {
                _wpg.POIPointAt(i).visible = false;
            }
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void ToolAllPathShow_Click(object sender, EventArgs e)
        {
            int pathcount = _wpg.PathCount();
            for (int i = 0; i < pathcount; i++)
            {
                _wpg.PathAt(i).visible = true;
            }
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void ToolAllPathHide_Click(object sender, EventArgs e)
        {
            int pathcount = _wpg.PathCount();
            for (int i = 0; i < pathcount; i++)
            {
                _wpg.PathAt(i).visible = false;
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            _gmap.ReDrawgMap();

        }

        private void unHideAllPolygon_Click(object sender, EventArgs e)
        {
            int polycount = _wpg.ShapeCount();
            for (int i = 0; i < polycount; i++)
            {
                _wpg.ShapeAt(i).visible = true;
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            _gmap.ReDrawgMap();
        }

        private void hideAllPolygon_Click(object sender, EventArgs e)
        {
            int polycount = _wpg.ShapeCount();
            for (int i = 0; i < polycount; i++)
            {
                _wpg.ShapeAt(i).visible = false;
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            _gmap.ReDrawgMap();
        }

        private void addCircularPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogAddCircularPath dialog = new dialogAddCircularPath(_wpg, _gmap, _options, Globals.mouse_down_lat, Globals.mouse_down_lon);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void addHelicalPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogAddHelixPath dialog = new DialogAddHelixPath(_wpg, _gmap, Globals.mouse_down_lat, Globals.mouse_down_lon);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void addManualPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogAddRectPath dialog = new DialogAddRectPath(_wpg, _gmap, _options, Globals.mouse_down_lat, Globals.mouse_down_lon,
                _options.focal_angle_hor, _options.focal_angle_hor,
                _options.hor_overlap_percent, _options.ver_overlap_percent);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void addPolygonGridPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure only one polygon is selected

            int poly_count = _wpg.SelectedPolyCount();
            if (poly_count != 1)
            {
                MessageBox.Show("Select a single Polygon");
                return;
            }

            DialogAddPolyGridPath dialog = new DialogAddPolyGridPath(_wpg, _gmap, Globals.mouse_down_lat, Globals.mouse_down_lon,
                _options.focal_angle_hor, _options.focal_angle_ver,
                _options.hor_overlap_percent, _options.ver_overlap_percent);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        // Delete all selected Paths



        // Delete all selected Waypoints

        private void toolDeleteWP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                Models.Path path = _wpg.PathAt(i);
                LinkedList<WayPoints> wp_list = path.waypoints;
                for (int j = wp_list.Count - 1; j >= 0; j--)
                {
                    WayPoints wp = wp_list.ElementAt(j);
                    if (wp.selected) wp_list.Remove(wp);
                }
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            _gmap.ReDrawgMap();
        }

        private void ToolInsertWPBefore_Click(object sender, EventArgs e)
        {
            int count = _wpg.SelectedWPCount();
            if (count != 1)
            {
                MessageBox.Show("One Way Point must be Selected");
                return;
            }
            _wp.Insert_Waypoint_List(_wpg, Globals.mouse_down_lat, Globals.mouse_down_lon, true);
            _gmap.ReDrawgMap();
        }

        private void ToolInsertWPAfter_Click(object sender, EventArgs e)
        {
            int count = _wpg.SelectedWPCount();
            if (count != 1)
            {
                MessageBox.Show("One Way Point must be Selected");
                return;
            }
            _wp.Insert_Waypoint_List(_wpg, Globals.mouse_down_lat, Globals.mouse_down_lon, false);
            _gmap.ReDrawgMap();
        }

        private void ToolAddKMLPath_Click(object sender, EventArgs e)
        {
            DialogKMLPath dialog = new DialogKMLPath(_wpg, _gmap, treGMap, Globals.mouse_down_lat, Globals.mouse_down_lon);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void toolDeleteShape_Click(object sender, EventArgs e)
        {
        }

        private void kMLPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogKMLPolygon dialog = new DialogKMLPolygon(_wpg, _gmap, treGMap);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void ToolAddPolyPerimPath_Click(object sender, EventArgs e)
        {
            DialogPolyPerimPath dialog = new DialogPolyPerimPath(_wpg, _gmap, _options, treGMap);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void toolToggleCenter_Click(object sender, EventArgs e)
        {
            _gmap.ToogleCenter();
            _gmap.ReDrawgMap();
        }

        private void toolUnselectAll_Click(object sender, EventArgs e)
        {
            _wpg.UnselectAll();
            _gmap.ReDrawgMap();
        }

        private void ToolSplitBefore_Click(object sender, EventArgs e)
        {
            int count = _wpg.SelectedWPCount();
            if (count != 1)
            {
                MessageBox.Show("One Way Point must be Selected");
                return;
            }
            _wpg.SplitPath(true);
            _wpg.UnselectAll();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void ToolSplitAfter_Click(object sender, EventArgs e)
        {
            int count = _wpg.SelectedWPCount();
            if (count != 1)
            {
                MessageBox.Show("One Way Point must be Selected");
                return;
            }
            _wpg.SplitPath(false);
            _wpg.UnselectAll();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void toolJoinPaths_Click(object sender, EventArgs e)
        {
            // Make Sure on two way points are selected
            int count = _wpg.SelectedWPCount();
            if (count != 2)
            {
                MessageBox.Show("Two Way Points must be Selected");
                return;
            }
            // Get selected Waypoints
            count = 0;
            int path_id1 = -1;
            int path_id2 = -1;
            int wp_count1 = 0;
            int wp_count2 = 0;
            int wp_index1 = -1;
            int wp_index2 = -1;
            LinkedList<WayPoints> wp_list;
            Models.Path path;

            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                path = _wpg.PathAt(i);
                wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    WayPoints wp = wp_list.ElementAt(j);
                    if (wp.selected)
                    {
                        if (count == 0)
                        {
                            path_id1 = i;
                            wp_index1 = j;
                            wp_count1 = wp_list.Count;
                            count++;
                        }
                        else
                        {
                            path_id2 = i;
                            wp_index2 = j;
                            wp_count2 = wp_list.Count;
                            count++;
                        }
                    }
                }
            }
            // Make sure selected waypoints are end waypoints
            if (wp_index1 != 0 & wp_index1 != wp_count1 - 1)
            {
                MessageBox.Show("Selected Waypoints must be end Waypoints");
                return;
            }
            if (wp_index2 != 0 & wp_index2 != wp_count2 - 1)
            {
                MessageBox.Show("Selected Waypoints must be end Waypoints");
                return;
            }
            // Valid Waypoints - Join paths

            wp_list = new LinkedList<WayPoints>();

            // Copy first path waypoints
            Models.Path path1 = _wpg.PathAt(path_id1);
            string name1 = path1.name;
            LinkedList<WayPoints> wp_old_list = path1.waypoints;
            WayPoints wp_old;

            if (wp_index1 != 0)
            {
                for (int i = 0; i < wp_count1; i++)
                {
                    wp_old = wp_old_list.ElementAt(i);
                    WayPoints wp = new WayPoints();
                    wp = wp_old;
                    wp_list.AddLast(wp);
                }
            }
            else
            {
                for (int i = wp_count1 - 1; i >= 0; i--)
                {
                    wp_old = wp_old_list.ElementAt(i);
                    WayPoints wp = new WayPoints();
                    wp = wp_old;
                    wp_list.AddLast(wp);
                }
            }

            // Copy second path waypoints
            Models.Path path2 = _wpg.PathAt(path_id2);
            string name2 = path2.name;
            wp_old_list = path2.waypoints;

            if (wp_index2 == 0)
            {
                for (int i = 0; i < wp_count2; i++)
                {
                    wp_old = wp_old_list.ElementAt(i);
                    WayPoints wp = new WayPoints();
                    wp = wp_old;
                    wp_list.AddLast(wp);
                }
            }
            else
            {
                for (int i = wp_count2 - 1; i >= 0; i--)
                {
                    wp_old = wp_old_list.ElementAt(i);
                    WayPoints wp = new WayPoints();
                    wp = wp_old;
                    wp_list.AddLast(wp);
                }
            }
            // Create Path
            string new_name = name1 + " - " + name2;
            Models.Path new_path = new Models.Path();
            _path.Add_Path(_wpg, _gmap, new_name, "Combined", wp_list);

            // Delete original Path

            _wpg.DeletePath(path1);
            _wpg.DeletePath(path2);
            _wpg.UnselectAll();

            // Redraw map
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void toolReversePath_Click(object sender, EventArgs e)
        {
            int path_count = _wpg.SelectedPathCount();
            if (path_count != 1)
            {
                MessageBox.Show("One and only one path can be selected to reverse");
                return;
            }
            // Get selected path index
            path_count = _wpg.PathCount();
            for (int i = 0; i < path_count; i++)
            {
                if (_wpg.PathAt(i).selected)
                {
                    _wpg.ReversePathWP(i);
                    break;
                }
            }
            _gmap.ReDrawgMap();
        }

        // Edit single selected POI

        private void selectedPOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int poi_count = _wpg.SelectedPOICount();
            if (poi_count != 1)
            {
                MessageBox.Show("Select a single POI");
                return;
            }
            // Get Selected POI index
            for (int i = 0; i < _wpg.POICount(); i++)
            {
                if (_wpg.POIPointAt(i).selected)
                {
                    DialogEditPOI dialog = new DialogEditPOI(_wpg, _gmap, treGMap, i);
                    dialog.Show();
                    GMAPTree.Update_GMapTree(_wpg, treGMap);
                    _gmap.ReDrawgMap();
                }
            }
        }

        // Edit single selected path 

        private void selectedPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int path_count = _wpg.SelectedPathCount();
            if (path_count != 1)
            {
                MessageBox.Show("Select a single Path");
                return;
            }
            // Get Selected Path index
            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                if (_wpg.PathAt(i).selected)
                {
                    DialogEditPath dialog = new DialogEditPath(_wpg, _gmap, treGMap, i);
                    dialog.Show();
                }
            }

        }

        // Edit Single select Polygon

        private void selectedPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int poly_count = _wpg.SelectedPolyCount();
            if (poly_count != 1)
            {
                MessageBox.Show("Select a single Polygon");
                return;
            }
            for (int i = 0; i < _wpg.ShapeCount(); i++)
            {
                if (_wpg.ShapeAt(i).selected)
                {
                    DialogEditPolygon dialog = new DialogEditPolygon(_wpg, _gmap, treGMap, i);
                    dialog.Show();
                }
            }
        }

        
        private void toolAddManualPath_Click(object sender, EventArgs e)
        {
            _path = new Models.Path();
            Globals.path_active = true;
            DialogManualPath dialog = new DialogManualPath(_wpg, _gmap, treGMap, _path, _options, Globals.mouse_down_lat, Globals.mouse_down_lon);
            dialog.Show();
        }

        private void selectedWaypointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only 1 waypoint can be selected

            int wp_count = _wpg.SelectedWPCount();
            if (wp_count != 1)
            {
                MessageBox.Show("Select a single Waypoint");
                return;
            }

            // Find single selected waypoint

            Models.Path path;
            LinkedList<WayPoints> wp_list;
            int path_id = 0, wp_index = 0;

            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                path = _wpg.PathAt(i);
                wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    WayPoints wp = wp_list.ElementAt(j);
                    if (wp.selected)
                    {

                        path_id = i;
                        wp_index = j;
                        wp_count = wp_list.Count;
                    }
                }
            }

            // Edit the WayPoint

            DialogEditWP dialog = new DialogEditWP(_wpg, _gmap, path_id, wp_index);
            dialog.Show();
            //_gmap.ReDrawgMap();
        }

        private void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (Globals.path_active)
            {
                string button = Convert.ToString(e.Button);
                if (button == "Left")
                {
                    int x = e.X;
                    int y = e.Y;
                    //MessageBox.Show("X/Y :" + Convert.ToString(e.X) + " " + Convert.ToString(e.Y));
                    double lat = gMapControl.FromLocalToLatLng(x, y).Lat;
                    double lon = gMapControl.FromLocalToLatLng(x, y).Lng;
                    LinkedList<WayPoints> wp_list = _path.waypoints;
                    WayPoints wp = wp_list.Last();
                    wp.selected = false;
                    int count = wp_list.Count;
                    WayPoints new_wp = new WayPoints();
                    new_wp.lat = lat;
                    new_wp.lon = lon;
                    new_wp.head = GPS.GPS_Bearing(lat, lon, wp.lat, wp.lon);
                    new_wp.visible = true;
                    new_wp.selected = false;
                    wp_list.AddLast(new_wp);
                    for (int i = 0; i < wp_list.Count; i++)
                    {
                        wp_list.ElementAt(i).selected = false;
                    }
                    _gmap.ReDrawgMap();
                    return;
                }
                if (button == "Middle")
                {
                    LinkedList<WayPoints> wp_list = _path.waypoints;
                    wp_list.RemoveLast();
                    Globals.path_active = false;
                    _path.selected = false;
                    _gmap.ReDrawgMap();
                    return;
                }
            }
        }

        private void toolOutputPath_Click(object sender, EventArgs e)
        {
            // Make sure only one path is selected

            int path_count = _wpg.SelectedPathCount();
            if (path_count != 1)
            {
                MessageBox.Show("Select a single Path");
                return;
            }

            // Get selected Path

            Models.Path path = null;
            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                if (_wpg.PathAt(i).selected) path = _wpg.PathAt(i);
            }

            DialogOutputPath dialog = new DialogOutputPath(_options, _wpg, path);
            dialog.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        // Delete All Paths

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = _wpg.PathCount() - 1; i >= 0; i--)
            {
                Models.Path path = _wpg.PathAt(i);
                _wpg.DeletePath(path);
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        // Delete Selected Path

        private void deleteSelectedPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loop through paths to delete the selected ones

            for (int i = _wpg.PathCount() - 1; i >= 0; i--)
            {
                Models.Path path = _wpg.PathAt(i);
                if (path.selected)
                {
                    _wpg.DeletePath(path);
                    //RemovePath_GMapTree(path);
                    //_gmap.Delete_gMapPath(path);

                }
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            DialogAbout dialog = new DialogAbout();
            dialog.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMouseLon_TextChanged(object sender, EventArgs e)
        {

        }

        private void trkMapScale_Scroll(object sender, EventArgs e)
        {
            gMapControl.Zoom = Convert.ToInt16(trkMapScale.Value);
        }

        private void selectedPOIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int poi_count = _wpg.SelectedPOICount();
            if (poi_count != 1)
            {
                MessageBox.Show("Select a single POI");
                return;
            }

            // Get selected POI

            int i;
            for (i = 0; i < _wpg.POICount(); i++)
            {
                if (_wpg.POIPointAt(i).selected)
                {
                    break;
                }
            }

            POIPoints poi = _wpg.POIPointAt(i);
            string str = "POI Properties\n\n";
            str = str + "Name : " + poi.name + "\n";
            str = str + "Lat : " + Convert.ToString(poi.lat) + "\n";
            str = str + "Lon : " + Convert.ToString(poi.lon) + "\n";
            str = str + "Elevation : " + Convert.ToString(poi.elev) + "\n";
            str = str + "Altitude : " + Convert.ToString(poi.alt) + "\n";
            str = str + "Camera Altitude : " + Convert.ToString(poi.cam_alt) + "\n";
            MessageBox.Show(str);
        }

        private void selectedPathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Make sure only one path is selected

            int path_count = _wpg.SelectedPathCount();
            if (path_count != 1)
            {
                MessageBox.Show("Select a single Path");
                return;
            }

            // Get selected Path

            Models.Path path = null;
            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                if (_wpg.PathAt(i).selected)
                {
                    path = _wpg.PathAt(i);
                    break;
                }
            }

            // Calculate Path Length

            LinkedList<WayPoints> wp_list = path.waypoints;

            double dist = 0.0;
            double lat1, lon1, lat2, lon2;
            for(int i = 0; i < wp_list.Count() - 1; i++)
            {
                lat1 = wp_list.ElementAt(i).lat;
                lon1 = wp_list.ElementAt(i).lon;
                lat2 = wp_list.ElementAt(i+1).lat;
                lon2 = wp_list.ElementAt(i+1).lon;
                dist = dist + GPS.GPS_Distance(lat1, lon1, lat2, lon2, Globals.gps_radius);
            }
            string str = "Path Properties\n\n";
            str = str + "Name : " + path.name + "\n";
            str = str + "Type : " + path.type + "\n";           
            str = str + "Waypoint Count : " + Convert.ToString(wp_list.Count) + "\n";
            str = str + "Distance : " + TrimTo(Convert.ToString(dist),3) + "\n";
            MessageBox.Show(str);
        }

        private void selectedWaypointToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Only 1 waypoint can be selected

            int wp_count = _wpg.SelectedWPCount();
            if (wp_count != 1)
            {
                MessageBox.Show("Select a single Waypoint");
                return;
            }

            // Find single selected waypoint

            Models.Path path;
            LinkedList<WayPoints> wp_list;
            WayPoints wp;
            int path_id = 0, wp_index = 0;

            for (int i = 0; i < _wpg.PathCount(); i++)
            {
                path = _wpg.PathAt(i);
                wp_list = path.waypoints;
                for (int j = 0; j < wp_list.Count; j++)
                {
                    wp = wp_list.ElementAt(j);
                    if (wp.selected)
                    {

                        path_id = i;
                        wp_index = j;
                        wp_count = wp_list.Count;
                    }
                }
            }

            path = _wpg.PathAt(path_id);
            wp_list = path.waypoints;
            wp = wp_list.ElementAt(wp_index);

            string str = "Waypoint Properties\n\n";
            str = str + "Path : " + path.name + "\n";
            str = str + "Waypoint Count : " + Convert.ToString(wp_list.Count) + "\n\n";
            str = str + "Waypoint ID : " + Convert.ToString(wp_index) + "\n";
            str = str + "Latitude : " + TrimTo(Convert.ToString(wp.lat),6) + "\n";
            str = str + "Longitude : " + TrimTo(Convert.ToString(wp.lon),6) + "\n";
            str = str + "Altitude : " + Convert.ToString(wp.alt) + "\n";
            str = str + "Heading : " + TrimTo(Convert.ToString(wp.head),2) + "\n";
            str = str + "Curve Size : " + Convert.ToString(wp.curvesize) + "\n";
            str = str + "Rotation Dir : " + Convert.ToString(wp.rotationdir) + "\n";
            str = str + "Gimble Mode : " + Convert.ToString(wp.gimblemode) + "\n";
            str = str + "Gimble Pitch : " + Convert.ToString(wp.gimblepitch) + "\n";
            MessageBox.Show(str);
        }

        private void selectedPolygonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int poly_count = _wpg.SelectedPolyCount();
            if (poly_count != 1)
            {
                MessageBox.Show("Select a single Polygon");
                return;
            }
            for (int i = 0; i < _wpg.ShapeCount(); i++)
            {
                if (_wpg.ShapeAt(i).selected)
                {
                    Models.Shape shape = _wpg.ShapeAt(i);
                    string str = "Polygon Properties\n\n";
                    str = str + "Name : " + shape.name + "\n";
                    int count = shape.points.Count - 1;
                    str = str + "Number Points : " + Convert.ToString(count) + "\n";
                    MessageBox.Show(str);
                }
            }
        }

        private void txtMouseStatus_TextChanged(object sender, EventArgs e)
        {

        }

        // Delete Selected POI 

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Only 1 waypoint can be selected

            int poi_count = _wpg.SelectedPOICount();
            if (poi_count != 1)
            {
                MessageBox.Show("Select a single POI");
                return;
            }

            // Get selected POI

            for (int i = 0; i < _wpg.POICount(); i++)
            {
                if (_wpg.POIPointAt(i).selected)
                {
                    _wpg.POIPointDeleteAt(i);
                    break;
                }
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteAllPOIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = _wpg.POICount() - 1; i > 0; i--)
            {
                _wpg.POIPointDeleteAt(i);
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteAllPOIsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = _wpg.POICount() - 1; i >= 0; i--)
            {
                _wpg.POIPointDeleteAt(i);
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteSelectedPOIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only 1 waypoint can be selected

            int poi_count = _wpg.SelectedPOICount();
            if (poi_count != 1)
            {
                MessageBox.Show("Select a single POI");
                return;
            }

            // Get selected POI

            for (int i = _wpg.POICount()-1; i >= 0; i--)
            {
                if (_wpg.POIPointAt(i).selected)
                {
                    _wpg.POIPointDeleteAt(i);
                }
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteSelectedPolygonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            for (int i = _wpg.ShapeCount()-1; i >= 0; i--)
            {
                if (_wpg.ShapeAt(i).selected)
                {
                    _wpg.DeleteShape(_wpg.ShapeAt(i));
                }
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteAllPolygonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = _wpg.ShapeCount() - 1; i >= 0; i--)
            {
                    _wpg.DeleteShape(_wpg.ShapeAt(i));
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void deleteSelectedPathsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for ( int i = _wpg.PathCount() - 1; i >= 0; i--)
            {
                if (_wpg.PathAt(i).selected) _wpg.DeletePath(_wpg.PathAt(i));
            }
            GMAPTree.Update_GMapTree(_wpg, treGMap);
            _gmap.ReDrawgMap();
        }

        private void cameraToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogCamera dialog = new DialogCamera(_options);
            dialog.Show();
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.map_center = gMapControl.Position;
            dialogAddCircularPath dialog = new dialogAddCircularPath(_wpg, _gmap, _options, Globals.map_center.Lat, Globals.map_center.Lng);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void helicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.map_center = gMapControl.Position;
            DialogAddHelixPath dialog = new DialogAddHelixPath(_wpg, _gmap, Globals.map_center.Lat, Globals.map_center.Lng);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _path = new Models.Path();
            Globals.path_active = true;
            Globals.map_center = gMapControl.Position;
            DialogManualPath dialog = new DialogManualPath(_wpg, _gmap, treGMap, _path, _options, Globals.map_center.Lat, Globals.map_center.Lng);
            dialog.Show();
        }

        private void rectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.map_center = gMapControl.Position;
            DialogAddRectPath dialog = new DialogAddRectPath(_wpg, _gmap, _options, Globals.map_center.Lat, Globals.map_center.Lng,
                _options.focal_angle_hor, _options.focal_angle_hor,
                _options.hor_overlap_percent, _options.ver_overlap_percent);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void polygonGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure only one polygon is selected

            int poly_count = _wpg.SelectedPolyCount();
            if (poly_count != 1)
            {
                MessageBox.Show("Select a single Polygon");
                return;
            }

            Globals.map_center = gMapControl.Position;
            DialogAddPolyGridPath dialog = new DialogAddPolyGridPath(_wpg, _gmap, Globals.map_center.Lat, Globals.map_center.Lng,
                _options.focal_angle_hor, _options.focal_angle_ver,
                _options.hor_overlap_percent, _options.ver_overlap_percent);
            dialog.ShowDialog();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
        }

        private void polygonPerimeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogPolyPerimPath dialog = new DialogPolyPerimPath(_wpg, _gmap, _options, treGMap);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void kMLPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.map_center = gMapControl.Position;
            DialogKMLPath dialog = new DialogKMLPath(_wpg, _gmap, treGMap, Globals.map_center.Lat, Globals.map_center.Lng);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }

        private void pOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.map_center = gMapControl.Position;
            frmAddPOI form = new frmAddPOI(_wpg, _gmap, Globals.map_center.Lat, Globals.map_center.Lng);
            form.ShowDialog();
            _gmap.ReDrawgMap();
            GMAPTree.Update_GMapTree(_wpg, treGMap); ;
            Update_POI_Dgv();
        }

        private void kMLPOlygonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogKMLPolygon dialog = new DialogKMLPolygon(_wpg, _gmap, treGMap);
            dialog.Show();
            GMAPTree.Update_GMapTree(_wpg, treGMap);
        }
    }
}
