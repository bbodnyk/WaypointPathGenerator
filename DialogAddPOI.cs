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
using Waypoint_Path_Generator;

namespace Waypoint_Path_Generator
{

    

    public partial class frmAddPOI : Form
    {
        private double _lat;
        private double _lon;
        private Waypoint_Path_Gen _wpg;
        private GMAP _gmap;

        public frmAddPOI(Waypoint_Path_Gen wpg, GMAP gmap, double lat, double lon)
        {
            _lat = lat;
            _lon = lon;
            _wpg = wpg;
            _gmap = gmap;
            InitializeComponent();
            lblAddPOI.Text = "Location : " + Convert.ToString(lat) + ", " + Convert.ToString(lon);
            txtAddPOIAlt.Text = "30";
            txtAddPOICamAlt.Text = "5";
            txtAddPOIElev.Text = "150";
        }

        private void btnCancelAddPOI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add POI at this location

        private void btnAddPOI_Click(object sender, EventArgs e)
        {
            string poi_name = txtAddPOIName.Text;
            if(poi_name == null | poi_name == "")
            {
                MessageBox.Show("Enter a POI Name");
                return;
            }

            POIPoints poipoint = new POIPoints();
            poipoint.name = poi_name;
            poipoint.lat = _lat;
            poipoint.lon = _lon;
            poipoint.elev = Convert.ToDouble(txtAddPOIElev.Text);
            poipoint.alt = Convert.ToDouble(txtAddPOIAlt.Text);
            poipoint.cam_alt = Convert.ToDouble(txtAddPOICamAlt.Text);
            poipoint.visible = true;
            poipoint.selected = false;
            _wpg.AddPOI(poipoint);
            _gmap.Add_gMapPOI(poipoint);
            //_gmap.ReDrawgMap();
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPOICamAlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
