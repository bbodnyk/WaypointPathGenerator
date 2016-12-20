namespace Waypoint_Path_Generator
{
    partial class DialogKMLPolygon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadKMLPoly = new System.Windows.Forms.Button();
            this.label77 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnReadKMLPoly
            // 
            this.btnReadKMLPoly.Location = new System.Drawing.Point(44, 89);
            this.btnReadKMLPoly.Name = "btnReadKMLPoly";
            this.btnReadKMLPoly.Size = new System.Drawing.Size(186, 23);
            this.btnReadKMLPoly.TabIndex = 42;
            this.btnReadKMLPoly.Text = "Select KML File";
            this.btnReadKMLPoly.UseVisualStyleBackColor = true;
            this.btnReadKMLPoly.Click += new System.EventHandler(this.btnReadKMLPoly_Click);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(52, 38);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(169, 20);
            this.label77.TabIndex = 41;
            this.label77.Text = "Import KML Polygon";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DialogKMLPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 254);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReadKMLPoly);
            this.Controls.Add(this.label77);
            this.Name = "DialogKMLPolygon";
            this.Text = "Add KML Polygon";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadKMLPoly;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}