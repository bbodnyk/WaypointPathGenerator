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
    public partial class DialogActions : Form
    {
        private Waypoint_Path_Gen _wpg;

        public DialogActions(Waypoint_Path_Gen wpg)
        {
            _wpg = wpg;
            InitializeComponent();
            int count = _wpg.ActionCount();
            Models.Action action;
            string name;
            cmbActionsList.Items.Clear();
            //cmbActionsWaypoints.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                action = _wpg.ActionAt(i);
                name = action.name;

                cmbActionsList.Items.Add(name);
                //cmbActionsWaypoints.Items.Add(name);
            }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelectAction_Click(object sender, EventArgs e)
        {
            string name = txtNewActionName.Text;
            _wpg.DeleteAction(name);
            Update_Actioncmb();
            cmbActionsList.SelectedIndex = 0;
        }

        private void Update_Actioncmb()
        {
            int count = _wpg.ActionCount();
            Models.Action action;
            string name;
            cmbActionsList.Items.Clear();
            //cmbActionsWaypoints.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                action = _wpg.ActionAt(i);
                name = action.name;

                cmbActionsList.Items.Add(name);
                //cmbActionsWaypoints.Items.Add(name);
            }
            //cmbActionsList.SelectedIndex = 0;
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
    }
}
