namespace Waypoint_Path_Generator
{
    partial class DialogAddPolyGridPath
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.chkRectHome = new System.Windows.Forms.CheckBox();
            this.lblGridAlt = new System.Windows.Forms.Label();
            this.txtGridAlt = new System.Windows.Forms.TextBox();
            this.trkAltitude = new System.Windows.Forms.TrackBar();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.trkHeading = new System.Windows.Forms.TrackBar();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPolyPathName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPoly = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(48, 189);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // chkRectHome
            // 
            this.chkRectHome.AutoSize = true;
            this.chkRectHome.Checked = true;
            this.chkRectHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRectHome.Location = new System.Drawing.Point(48, 76);
            this.chkRectHome.Name = "chkRectHome";
            this.chkRectHome.Size = new System.Drawing.Size(138, 17);
            this.chkRectHome.TabIndex = 16;
            this.chkRectHome.Text = "Output Home Start/End";
            this.chkRectHome.UseVisualStyleBackColor = true;
            this.chkRectHome.CheckedChanged += new System.EventHandler(this.chkRectHome_CheckedChanged_1);
            // 
            // lblGridAlt
            // 
            this.lblGridAlt.AutoSize = true;
            this.lblGridAlt.Location = new System.Drawing.Point(27, 108);
            this.lblGridAlt.Name = "lblGridAlt";
            this.lblGridAlt.Size = new System.Drawing.Size(59, 13);
            this.lblGridAlt.TabIndex = 23;
            this.lblGridAlt.Text = "Altitude (m)";
            // 
            // txtGridAlt
            // 
            this.txtGridAlt.Location = new System.Drawing.Point(92, 105);
            this.txtGridAlt.Name = "txtGridAlt";
            this.txtGridAlt.Size = new System.Drawing.Size(36, 20);
            this.txtGridAlt.TabIndex = 22;
            this.txtGridAlt.Text = "30";
            this.txtGridAlt.TextChanged += new System.EventHandler(this.txtGridAlt_TextChanged_1);
            this.txtGridAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGridAlt_KeyDown);
            // 
            // trkAltitude
            // 
            this.trkAltitude.Location = new System.Drawing.Point(134, 105);
            this.trkAltitude.Maximum = 129;
            this.trkAltitude.Minimum = 5;
            this.trkAltitude.Name = "trkAltitude";
            this.trkAltitude.Size = new System.Drawing.Size(104, 42);
            this.trkAltitude.TabIndex = 80;
            this.trkAltitude.TickFrequency = 10;
            this.trkAltitude.Value = 60;
            this.trkAltitude.Scroll += new System.EventHandler(this.trkAltitude_Scroll);
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(92, 141);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(36, 20);
            this.txtHeading.TabIndex = 81;
            this.txtHeading.Text = "0";
            this.txtHeading.TextChanged += new System.EventHandler(this.txtHeading_TextChanged);
            this.txtHeading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHeading_KeyDown);
            // 
            // trkHeading
            // 
            this.trkHeading.Location = new System.Drawing.Point(134, 141);
            this.trkHeading.Maximum = 360;
            this.trkHeading.Name = "trkHeading";
            this.trkHeading.Size = new System.Drawing.Size(104, 42);
            this.trkHeading.TabIndex = 82;
            this.trkHeading.TickFrequency = 45;
            this.trkHeading.Scroll += new System.EventHandler(this.trkHeading_Scroll);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Checked = true;
            this.radioVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVideo.Location = new System.Drawing.Point(168, 46);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(82, 17);
            this.radioVideo.TabIndex = 94;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video Mode";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.radioVideo_CheckedChanged);
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPhoto.Location = new System.Drawing.Point(41, 46);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(83, 17);
            this.radioPhoto.TabIndex = 93;
            this.radioPhoto.Text = "Photo Mode";
            this.radioPhoto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Path Name";
            // 
            // txtPolyPathName
            // 
            this.txtPolyPathName.Location = new System.Drawing.Point(103, 10);
            this.txtPolyPathName.Name = "txtPolyPathName";
            this.txtPolyPathName.Size = new System.Drawing.Size(162, 20);
            this.txtPolyPathName.TabIndex = 95;
            this.txtPolyPathName.Text = "Untitled - Polygon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Heading";
            // 
            // rtbPoly
            // 
            this.rtbPoly.Location = new System.Drawing.Point(12, 218);
            this.rtbPoly.Name = "rtbPoly";
            this.rtbPoly.Size = new System.Drawing.Size(268, 208);
            this.rtbPoly.TabIndex = 98;
            this.rtbPoly.Text = "";
            // 
            // DialogAddPolyGridPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 477);
            this.Controls.Add(this.rtbPoly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPolyPathName);
            this.Controls.Add(this.radioVideo);
            this.Controls.Add(this.radioPhoto);
            this.Controls.Add(this.trkHeading);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.trkAltitude);
            this.Controls.Add(this.lblGridAlt);
            this.Controls.Add(this.txtGridAlt);
            this.Controls.Add(this.chkRectHome);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.btnCancel);
            this.Name = "DialogAddPolyGridPath";
            this.Text = "Add Polygon Grid Path";
            ((System.ComponentModel.ISupportInitialize)(this.trkAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.CheckBox chkRectHome;
        private System.Windows.Forms.Label lblGridAlt;
        private System.Windows.Forms.TextBox txtGridAlt;
        private System.Windows.Forms.TrackBar trkAltitude;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.TrackBar trkHeading;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPolyPathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPoly;
    }
}