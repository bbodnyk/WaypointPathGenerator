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
    public partial class DialogEditWPActions : Form
    {
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;
        private Path _path;

        public DialogEditWPActions(Waypoint_Path_Gen wpg, GMAP gmap, Path path)
        {
            _wpg = wpg;
            _gmap = gmap;
            _path = path;
            InitializeComponent();

            // Fill Actions CMB

            Update_Actioncmb();

            // Fill Data grid view with Waypoints

            int path_id = _path.id;
            string path_name = _path.name;
            string path_type = _path.type;
            LinkedList<WayPoints> waypoints = _path.waypoints;
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
            foreach (DataGridViewColumn dgvc in dgvActionsWaypoints.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void DialogEditWPActions_Load(object sender, EventArgs e)
        {

        }

        private void dgvActionsWaypoints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore event if turned off

            //if (!Globals.ActionWaypoint_Handler) return;

            // Get row & col

            int row = e.RowIndex;
            if (row == -1) return;
            int col = e.ColumnIndex;
            double cell_value = Convert.ToDouble(dgvActionsWaypoints.Rows[row].Cells[col].Value.ToString());

            // Find Waypoint Record

            LinkedList<WayPoints> waypoints = _path.waypoints;

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

        private void Update_Actioncmb()
        {
            int count = _wpg.ActionCount();
            Models.Action action;
            string name;
            cmbActionsWaypoints.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                action = _wpg.ActionAt(i);
                name = action.name;

                cmbActionsWaypoints.Items.Add(name);
            }
            //cmbActionsList.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _gmap.ReDrawgMap();
            this.Close();
        }

        private void dgvActionsWaypoints_MouseUp(object sender, MouseEventArgs e)
        {
            //if (Globals.ActionWaypoint_Handler)
            //{
            LinkedList<WayPoints> waypoints = _path.waypoints;
            int wpcount = waypoints.Count;
            if (dgvActionsWaypoints.AreAllCellsSelected(true))
            {
                txtWPStart.Text = "0";
                txtWPEnd.Text = Convert.ToString(wpcount - 1);
                return;
            }
            int row_start = 1000;
            int row_end = -1;
            int count = dgvActionsWaypoints.SelectedRows.Count;
            if (count == 1)
            {
                int index = dgvActionsWaypoints.SelectedRows[0].Index;
                txtWPStart.Text = Convert.ToString(index);
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
                txtWPEnd.Text = Convert.ToString(row_end);
            }

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

            LinkedList<WayPoints> waypoints = _path.waypoints;

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

            //Globals.ActionWaypoint_Handler = false;
            dgvActionsWaypoints.Rows.Clear();
            //Globals.ActionWaypoint_Handler = true;
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

        //}
    }


}
