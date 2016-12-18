namespace Waypoint_Path_Generator
{
    partial class DialogAddRectPath
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtRectPathName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGridRotation = new System.Windows.Forms.TextBox();
            this.lblGridWidth = new System.Windows.Forms.Label();
            this.lblGridLength = new System.Windows.Forms.Label();
            this.txtGridWidth = new System.Windows.Forms.TextBox();
            this.txtGridLength = new System.Windows.Forms.TextBox();
            this.grpStartLoc = new System.Windows.Forms.GroupBox();
            this.radioLowRight = new System.Windows.Forms.RadioButton();
            this.radioUpRight = new System.Windows.Forms.RadioButton();
            this.radioLowLeft = new System.Windows.Forms.RadioButton();
            this.radioUpLeft = new System.Windows.Forms.RadioButton();
            this.trkRectHeading = new System.Windows.Forms.TrackBar();
            this.trkRectLength = new System.Windows.Forms.TrackBar();
            this.trkRectWidth = new System.Windows.Forms.TrackBar();
            this.btnCancelAddRectPath = new System.Windows.Forms.Button();
            this.btnAddRectPath = new System.Windows.Forms.Button();
            this.chkRectHome = new System.Windows.Forms.CheckBox();
            this.cmbRectCamPOI = new System.Windows.Forms.ComboBox();
            this.chkRectCamPOI = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOnePass = new System.Windows.Forms.CheckBox();
            this.trkRectAlt = new System.Windows.Forms.TrackBar();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
            this.grpStartLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Path Name";
            // 
            // txtRectPathName
            // 
            this.txtRectPathName.Location = new System.Drawing.Point(134, 11);
            this.txtRectPathName.Name = "txtRectPathName";
            this.txtRectPathName.Size = new System.Drawing.Size(162, 20);
            this.txtRectPathName.TabIndex = 71;
            this.txtRectPathName.Text = "Untitled - Rectangular";
            this.txtRectPathName.TextChanged += new System.EventHandler(this.txtRectPathName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Altitude";
            // 
            // txtPathAlt
            // 
            this.txtPathAlt.Location = new System.Drawing.Point(130, 104);
            this.txtPathAlt.Name = "txtPathAlt";
            this.txtPathAlt.Size = new System.Drawing.Size(45, 20);
            this.txtPathAlt.TabIndex = 69;
            this.txtPathAlt.Text = "30";
            this.txtPathAlt.TextChanged += new System.EventHandler(this.txtPathAlt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Heading";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGridRotation
            // 
            this.txtGridRotation.Location = new System.Drawing.Point(130, 139);
            this.txtGridRotation.Name = "txtGridRotation";
            this.txtGridRotation.Size = new System.Drawing.Size(45, 20);
            this.txtGridRotation.TabIndex = 77;
            this.txtGridRotation.Text = "0.0";
            this.txtGridRotation.TextChanged += new System.EventHandler(this.txtGridRotation_TextChanged);
            // 
            // lblGridWidth
            // 
            this.lblGridWidth.AutoSize = true;
            this.lblGridWidth.Location = new System.Drawing.Point(57, 220);
            this.lblGridWidth.Name = "lblGridWidth";
            this.lblGridWidth.Size = new System.Drawing.Size(52, 13);
            this.lblGridWidth.TabIndex = 76;
            this.lblGridWidth.Text = "Width (m)";
            this.lblGridWidth.Click += new System.EventHandler(this.lblGridWidth_Click);
            // 
            // lblGridLength
            // 
            this.lblGridLength.AutoSize = true;
            this.lblGridLength.Location = new System.Drawing.Point(54, 178);
            this.lblGridLength.Name = "lblGridLength";
            this.lblGridLength.Size = new System.Drawing.Size(57, 13);
            this.lblGridLength.TabIndex = 75;
            this.lblGridLength.Text = "Length (m)";
            this.lblGridLength.Click += new System.EventHandler(this.lblGridLength_Click);
            // 
            // txtGridWidth
            // 
            this.txtGridWidth.Location = new System.Drawing.Point(130, 217);
            this.txtGridWidth.Name = "txtGridWidth";
            this.txtGridWidth.Size = new System.Drawing.Size(45, 20);
            this.txtGridWidth.TabIndex = 74;
            this.txtGridWidth.Text = "150";
            this.txtGridWidth.TextChanged += new System.EventHandler(this.txtGridWidth_TextChanged);
            // 
            // txtGridLength
            // 
            this.txtGridLength.Location = new System.Drawing.Point(130, 178);
            this.txtGridLength.Name = "txtGridLength";
            this.txtGridLength.Size = new System.Drawing.Size(45, 20);
            this.txtGridLength.TabIndex = 73;
            this.txtGridLength.Text = "120";
            this.txtGridLength.TextChanged += new System.EventHandler(this.txtGridLength_TextChanged);
            // 
            // grpStartLoc
            // 
            this.grpStartLoc.Controls.Add(this.radioLowRight);
            this.grpStartLoc.Controls.Add(this.radioUpRight);
            this.grpStartLoc.Controls.Add(this.radioLowLeft);
            this.grpStartLoc.Controls.Add(this.radioUpLeft);
            this.grpStartLoc.Location = new System.Drawing.Point(25, 252);
            this.grpStartLoc.Name = "grpStartLoc";
            this.grpStartLoc.Size = new System.Drawing.Size(322, 78);
            this.grpStartLoc.TabIndex = 79;
            this.grpStartLoc.TabStop = false;
            this.grpStartLoc.Text = "Rectangular Start Location";
            this.grpStartLoc.Enter += new System.EventHandler(this.grpStartLoc_Enter);
            // 
            // radioLowRight
            // 
            this.radioLowRight.AutoSize = true;
            this.radioLowRight.Location = new System.Drawing.Point(192, 47);
            this.radioLowRight.Name = "radioLowRight";
            this.radioLowRight.Size = new System.Drawing.Size(82, 17);
            this.radioLowRight.TabIndex = 3;
            this.radioLowRight.Text = "Lower Right";
            this.radioLowRight.UseVisualStyleBackColor = true;
            this.radioLowRight.CheckedChanged += new System.EventHandler(this.radioLowRight_CheckedChanged);
            // 
            // radioUpRight
            // 
            this.radioUpRight.AutoSize = true;
            this.radioUpRight.Location = new System.Drawing.Point(192, 21);
            this.radioUpRight.Name = "radioUpRight";
            this.radioUpRight.Size = new System.Drawing.Size(82, 17);
            this.radioUpRight.TabIndex = 2;
            this.radioUpRight.Text = "Upper Right";
            this.radioUpRight.UseVisualStyleBackColor = true;
            this.radioUpRight.CheckedChanged += new System.EventHandler(this.radioUpRight_CheckedChanged);
            // 
            // radioLowLeft
            // 
            this.radioLowLeft.AutoSize = true;
            this.radioLowLeft.Checked = true;
            this.radioLowLeft.Location = new System.Drawing.Point(52, 47);
            this.radioLowLeft.Name = "radioLowLeft";
            this.radioLowLeft.Size = new System.Drawing.Size(75, 17);
            this.radioLowLeft.TabIndex = 1;
            this.radioLowLeft.TabStop = true;
            this.radioLowLeft.Text = "Lower Left";
            this.radioLowLeft.UseVisualStyleBackColor = true;
            this.radioLowLeft.CheckedChanged += new System.EventHandler(this.radioLowLeft_CheckedChanged);
            // 
            // radioUpLeft
            // 
            this.radioUpLeft.AutoSize = true;
            this.radioUpLeft.Location = new System.Drawing.Point(54, 21);
            this.radioUpLeft.Name = "radioUpLeft";
            this.radioUpLeft.Size = new System.Drawing.Size(75, 17);
            this.radioUpLeft.TabIndex = 0;
            this.radioUpLeft.Text = "Upper Left";
            this.radioUpLeft.UseVisualStyleBackColor = true;
            this.radioUpLeft.CheckedChanged += new System.EventHandler(this.radioUpLeft_CheckedChanged);
            // 
            // trkRectHeading
            // 
            this.trkRectHeading.Location = new System.Drawing.Point(195, 139);
            this.trkRectHeading.Maximum = 360;
            this.trkRectHeading.Name = "trkRectHeading";
            this.trkRectHeading.Size = new System.Drawing.Size(104, 42);
            this.trkRectHeading.TabIndex = 80;
            this.trkRectHeading.Scroll += new System.EventHandler(this.trkRectHeading_Scroll);
            // 
            // trkRectLength
            // 
            this.trkRectLength.Location = new System.Drawing.Point(195, 178);
            this.trkRectLength.Maximum = 1000;
            this.trkRectLength.Minimum = 10;
            this.trkRectLength.Name = "trkRectLength";
            this.trkRectLength.Size = new System.Drawing.Size(104, 42);
            this.trkRectLength.TabIndex = 81;
            this.trkRectLength.Value = 10;
            this.trkRectLength.Scroll += new System.EventHandler(this.trkRectLength_Scroll);
            // 
            // trkRectWidth
            // 
            this.trkRectWidth.Location = new System.Drawing.Point(195, 217);
            this.trkRectWidth.Maximum = 1000;
            this.trkRectWidth.Minimum = 10;
            this.trkRectWidth.Name = "trkRectWidth";
            this.trkRectWidth.Size = new System.Drawing.Size(104, 42);
            this.trkRectWidth.TabIndex = 82;
            this.trkRectWidth.Value = 10;
            this.trkRectWidth.Scroll += new System.EventHandler(this.trkRectWidth_Scroll);
            // 
            // btnCancelAddRectPath
            // 
            this.btnCancelAddRectPath.Location = new System.Drawing.Point(221, 442);
            this.btnCancelAddRectPath.Name = "btnCancelAddRectPath";
            this.btnCancelAddRectPath.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddRectPath.TabIndex = 83;
            this.btnCancelAddRectPath.Text = "Cancel";
            this.btnCancelAddRectPath.UseVisualStyleBackColor = true;
            this.btnCancelAddRectPath.Click += new System.EventHandler(this.btnCancelAddRectPath_Click);
            // 
            // btnAddRectPath
            // 
            this.btnAddRectPath.Location = new System.Drawing.Point(47, 442);
            this.btnAddRectPath.Name = "btnAddRectPath";
            this.btnAddRectPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddRectPath.TabIndex = 84;
            this.btnAddRectPath.Text = "Add Path";
            this.btnAddRectPath.UseVisualStyleBackColor = true;
            this.btnAddRectPath.Click += new System.EventHandler(this.btnAddRectPath_Click);
            // 
            // chkRectHome
            // 
            this.chkRectHome.AutoSize = true;
            this.chkRectHome.Checked = true;
            this.chkRectHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRectHome.Location = new System.Drawing.Point(134, 71);
            this.chkRectHome.Name = "chkRectHome";
            this.chkRectHome.Size = new System.Drawing.Size(138, 17);
            this.chkRectHome.TabIndex = 85;
            this.chkRectHome.Text = "Output Home Start/End";
            this.chkRectHome.UseVisualStyleBackColor = true;
            this.chkRectHome.CheckedChanged += new System.EventHandler(this.chkRectHome_CheckedChanged);
            // 
            // cmbRectCamPOI
            // 
            this.cmbRectCamPOI.FormattingEnabled = true;
            this.cmbRectCamPOI.Location = new System.Drawing.Point(119, 399);
            this.cmbRectCamPOI.Name = "cmbRectCamPOI";
            this.cmbRectCamPOI.Size = new System.Drawing.Size(152, 21);
            this.cmbRectCamPOI.TabIndex = 87;
            // 
            // chkRectCamPOI
            // 
            this.chkRectCamPOI.AutoSize = true;
            this.chkRectCamPOI.Location = new System.Drawing.Point(119, 359);
            this.chkRectCamPOI.Name = "chkRectCamPOI";
            this.chkRectCamPOI.Size = new System.Drawing.Size(74, 17);
            this.chkRectCamPOI.TabIndex = 86;
            this.chkRectCamPOI.Text = "POI Mode";
            this.chkRectCamPOI.UseVisualStyleBackColor = true;
            this.chkRectCamPOI.CheckedChanged += new System.EventHandler(this.chkRectCamPOI_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Camera POI";
            // 
            // chkOnePass
            // 
            this.chkOnePass.AutoSize = true;
            this.chkOnePass.Location = new System.Drawing.Point(119, 336);
            this.chkOnePass.Name = "chkOnePass";
            this.chkOnePass.Size = new System.Drawing.Size(111, 17);
            this.chkOnePass.TabIndex = 89;
            this.chkOnePass.Text = "Force Single Pass";
            this.chkOnePass.UseVisualStyleBackColor = true;
            this.chkOnePass.CheckedChanged += new System.EventHandler(this.chkOnePass_CheckedChanged);
            // 
            // trkRectAlt
            // 
            this.trkRectAlt.Location = new System.Drawing.Point(195, 104);
            this.trkRectAlt.Maximum = 129;
            this.trkRectAlt.Minimum = 5;
            this.trkRectAlt.Name = "trkRectAlt";
            this.trkRectAlt.Size = new System.Drawing.Size(104, 42);
            this.trkRectAlt.TabIndex = 90;
            this.trkRectAlt.Value = 5;
            this.trkRectAlt.Scroll += new System.EventHandler(this.trkRectAlt_Scroll);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Checked = true;
            this.radioVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVideo.Location = new System.Drawing.Point(207, 48);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(82, 17);
            this.radioVideo.TabIndex = 92;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video Mode";
            this.radioVideo.UseVisualStyleBackColor = true;
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPhoto.Location = new System.Drawing.Point(80, 48);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(83, 17);
            this.radioPhoto.TabIndex = 91;
            this.radioPhoto.Text = "Photo Mode";
            this.radioPhoto.UseVisualStyleBackColor = true;
            this.radioPhoto.CheckedChanged += new System.EventHandler(this.radioPhoto_CheckedChanged);
            // 
            // DialogAddRectPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 481);
            this.Controls.Add(this.radioVideo);
            this.Controls.Add(this.radioPhoto);
            this.Controls.Add(this.trkRectHeading);
            this.Controls.Add(this.trkRectAlt);
            this.Controls.Add(this.chkOnePass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRectCamPOI);
            this.Controls.Add(this.chkRectCamPOI);
            this.Controls.Add(this.chkRectHome);
            this.Controls.Add(this.btnAddRectPath);
            this.Controls.Add(this.btnCancelAddRectPath);
            this.Controls.Add(this.grpStartLoc);
            this.Controls.Add(this.trkRectWidth);
            this.Controls.Add(this.trkRectLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGridRotation);
            this.Controls.Add(this.lblGridWidth);
            this.Controls.Add(this.lblGridLength);
            this.Controls.Add(this.txtGridWidth);
            this.Controls.Add(this.txtGridLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRectPathName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathAlt);
            this.Name = "DialogAddRectPath";
            this.Text = "Add Rectangular Path";
            this.Load += new System.EventHandler(this.DialogAddRectPath_Load);
            this.grpStartLoc.ResumeLayout(false);
            this.grpStartLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRectAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRectPathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGridRotation;
        private System.Windows.Forms.Label lblGridWidth;
        private System.Windows.Forms.Label lblGridLength;
        private System.Windows.Forms.TextBox txtGridWidth;
        private System.Windows.Forms.TextBox txtGridLength;
        private System.Windows.Forms.GroupBox grpStartLoc;
        private System.Windows.Forms.RadioButton radioLowRight;
        private System.Windows.Forms.RadioButton radioUpRight;
        private System.Windows.Forms.RadioButton radioLowLeft;
        private System.Windows.Forms.RadioButton radioUpLeft;
        private System.Windows.Forms.TrackBar trkRectHeading;
        private System.Windows.Forms.TrackBar trkRectLength;
        private System.Windows.Forms.TrackBar trkRectWidth;
        private System.Windows.Forms.Button btnCancelAddRectPath;
        private System.Windows.Forms.Button btnAddRectPath;
        private System.Windows.Forms.CheckBox chkRectHome;
        private System.Windows.Forms.ComboBox cmbRectCamPOI;
        private System.Windows.Forms.CheckBox chkRectCamPOI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOnePass;
        private System.Windows.Forms.TrackBar trkRectAlt;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioPhoto;
    }
}