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
    public partial class DialogGoTo : Form
    {
        Waypoint_Path_Gen _wpg;
        GMAP _gmap;
        Options _options;
        GMap.NET.PointLatLng _center;

        public DialogGoTo(Waypoint_Path_Gen wpg, GMAP gmap, Options options)
        {
            _wpg = wpg;
            _gmap = gmap;
            _options = options;

            InitializeComponent();

            _center = _gmap.GetCenter();
            txtLat.Text = Convert.ToString(_center.Lat);
            txtLon.Text = Convert.ToString(_center.Lng);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DialogGoTo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtLat.TextChanged -= txtLat_TextChanged;

            // Test first character - either text is blank or the selection starts at first character.
            TextBox txt = (sender as TextBox);

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

            if ( e.KeyChar == '\r')
            {
                e.Handled = true;
                if (txtLat.Text == "") txtLat.Text = "0";
                _center.Lat = Convert.ToDouble(txtLat.Text);
                _gmap.SetCenter(_center.Lat, _center.Lng);
                _gmap.ReDrawgMap();
            }
        }

        private void txtLon_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox txt = (sender as TextBox);

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

            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                if (txtLon.Text == "") txtLon.Text = "0";
                _center.Lng = Convert.ToDouble(txtLon.Text);
                _gmap.SetCenter(_center.Lat, _center.Lng);
                _gmap.ReDrawgMap();
            }
        }
    }
}
