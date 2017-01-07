namespace Waypoint_Path_Generator
{
    partial class DialogAddHelixPath
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
            this.bnCancelAddCircPath = new System.Windows.Forms.Button();
            this.btnAddHelixPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCW = new System.Windows.Forms.RadioButton();
            this.radioCCW = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddHelixPathName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHelixEndRadius = new System.Windows.Forms.TextBox();
            this.txtHelixStartRadius = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHelixEndAlt = new System.Windows.Forms.TextBox();
            this.txtHelixStartAlt = new System.Windows.Forms.TextBox();
            this.trkStartAlt = new System.Windows.Forms.TrackBar();
            this.trkEndAlt = new System.Windows.Forms.TrackBar();
            this.trkStartRad = new System.Windows.Forms.TrackBar();
            this.trkEndRad = new System.Windows.Forms.TrackBar();
            this.txtHelixSpan = new System.Windows.Forms.TextBox();
            this.txtHelixStartAngle = new System.Windows.Forms.TextBox();
            this.trkStartAngle = new System.Windows.Forms.TrackBar();
            this.trkHelixSpan = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trkNumPoints = new System.Windows.Forms.TrackBar();
            this.txtHelixNumPoints = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbHelixPOI = new System.Windows.Forms.ComboBox();
            this.chkHelixPOI = new System.Windows.Forms.CheckBox();
            this.chkHelicalHome = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHelixSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCancelAddCircPath
            // 
            this.bnCancelAddCircPath.Location = new System.Drawing.Point(238, 538);
            this.bnCancelAddCircPath.Name = "bnCancelAddCircPath";
            this.bnCancelAddCircPath.Size = new System.Drawing.Size(75, 23);
            this.bnCancelAddCircPath.TabIndex = 3;
            this.bnCancelAddCircPath.Text = "Cancel";
            this.bnCancelAddCircPath.UseVisualStyleBackColor = true;
            this.bnCancelAddCircPath.Click += new System.EventHandler(this.bnCancelAddCircPath_Click);
            // 
            // btnAddHelixPath
            // 
            this.btnAddHelixPath.Location = new System.Drawing.Point(31, 538);
            this.btnAddHelixPath.Name = "btnAddHelixPath";
            this.btnAddHelixPath.Size = new System.Drawing.Size(121, 23);
            this.btnAddHelixPath.TabIndex = 2;
            this.btnAddHelixPath.Text = "Add Helical Path";
            this.btnAddHelixPath.UseVisualStyleBackColor = true;
            this.btnAddHelixPath.Click += new System.EventHandler(this.btnAddHelixPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCW);
            this.groupBox1.Controls.Add(this.radioCCW);
            this.groupBox1.Location = new System.Drawing.Point(70, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioCW
            // 
            this.radioCW.AutoSize = true;
            this.radioCW.Checked = true;
            this.radioCW.Location = new System.Drawing.Point(79, 12);
            this.radioCW.Name = "radioCW";
            this.radioCW.Size = new System.Drawing.Size(43, 17);
            this.radioCW.TabIndex = 20;
            this.radioCW.TabStop = true;
            this.radioCW.Text = "CW";
            this.radioCW.UseVisualStyleBackColor = true;
            this.radioCW.CheckedChanged += new System.EventHandler(this.radioCW_CheckedChanged);
            // 
            // radioCCW
            // 
            this.radioCCW.AutoSize = true;
            this.radioCCW.Location = new System.Drawing.Point(79, 38);
            this.radioCCW.Name = "radioCCW";
            this.radioCCW.Size = new System.Drawing.Size(50, 17);
            this.radioCCW.TabIndex = 21;
            this.radioCCW.Text = "CCW";
            this.radioCCW.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Path Name";
            // 
            // txtAddHelixPathName
            // 
            this.txtAddHelixPathName.Location = new System.Drawing.Point(149, 93);
            this.txtAddHelixPathName.Name = "txtAddHelixPathName";
            this.txtAddHelixPathName.Size = new System.Drawing.Size(100, 20);
            this.txtAddHelixPathName.TabIndex = 69;
            this.txtAddHelixPathName.Text = "Untitled - Helical";
            this.txtAddHelixPathName.TextChanged += new System.EventHandler(this.txtAddHelixPathName_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 78;
            this.label22.Text = "Radius";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 77;
            this.label21.Text = "Altitude";
            // 
            // txtHelixEndRadius
            // 
            this.txtHelixEndRadius.Location = new System.Drawing.Point(213, 180);
            this.txtHelixEndRadius.Name = "txtHelixEndRadius";
            this.txtHelixEndRadius.Size = new System.Drawing.Size(36, 20);
            this.txtHelixEndRadius.TabIndex = 76;
            this.txtHelixEndRadius.Text = "10";
            this.txtHelixEndRadius.TextChanged += new System.EventHandler(this.txtHelixEndRadius_TextChanged);
            // 
            // txtHelixStartRadius
            // 
            this.txtHelixStartRadius.Location = new System.Drawing.Point(70, 180);
            this.txtHelixStartRadius.Name = "txtHelixStartRadius";
            this.txtHelixStartRadius.Size = new System.Drawing.Size(38, 20);
            this.txtHelixStartRadius.TabIndex = 75;
            this.txtHelixStartRadius.Text = "50";
            this.txtHelixStartRadius.TextChanged += new System.EventHandler(this.txtHelixStartRadius_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(210, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "End";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(67, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 73;
            this.label19.Text = "Start";
            // 
            // txtHelixEndAlt
            // 
            this.txtHelixEndAlt.Location = new System.Drawing.Point(213, 132);
            this.txtHelixEndAlt.Name = "txtHelixEndAlt";
            this.txtHelixEndAlt.Size = new System.Drawing.Size(34, 20);
            this.txtHelixEndAlt.TabIndex = 72;
            this.txtHelixEndAlt.Text = "10";
            this.txtHelixEndAlt.TextChanged += new System.EventHandler(this.txtHelixEndAlt_TextChanged);
            // 
            // txtHelixStartAlt
            // 
            this.txtHelixStartAlt.Location = new System.Drawing.Point(70, 132);
            this.txtHelixStartAlt.Name = "txtHelixStartAlt";
            this.txtHelixStartAlt.Size = new System.Drawing.Size(29, 20);
            this.txtHelixStartAlt.TabIndex = 71;
            this.txtHelixStartAlt.Text = "60";
            this.txtHelixStartAlt.TextChanged += new System.EventHandler(this.txtHelixStartAlt_TextChanged);
            // 
            // trkStartAlt
            // 
            this.trkStartAlt.Location = new System.Drawing.Point(103, 132);
            this.trkStartAlt.Maximum = 129;
            this.trkStartAlt.Minimum = 5;
            this.trkStartAlt.Name = "trkStartAlt";
            this.trkStartAlt.Size = new System.Drawing.Size(104, 42);
            this.trkStartAlt.TabIndex = 79;
            this.trkStartAlt.TickFrequency = 10;
            this.trkStartAlt.Value = 60;
            this.trkStartAlt.Scroll += new System.EventHandler(this.trkStartAlt_Scroll);
            // 
            // trkEndAlt
            // 
            this.trkEndAlt.Location = new System.Drawing.Point(249, 132);
            this.trkEndAlt.Maximum = 129;
            this.trkEndAlt.Minimum = 5;
            this.trkEndAlt.Name = "trkEndAlt";
            this.trkEndAlt.Size = new System.Drawing.Size(104, 42);
            this.trkEndAlt.TabIndex = 80;
            this.trkEndAlt.TickFrequency = 10;
            this.trkEndAlt.Value = 10;
            this.trkEndAlt.Scroll += new System.EventHandler(this.trkEndAlt_Scroll);
            // 
            // trkStartRad
            // 
            this.trkStartRad.Location = new System.Drawing.Point(103, 180);
            this.trkStartRad.Maximum = 500;
            this.trkStartRad.Minimum = 3;
            this.trkStartRad.Name = "trkStartRad";
            this.trkStartRad.Size = new System.Drawing.Size(104, 42);
            this.trkStartRad.TabIndex = 81;
            this.trkStartRad.TickFrequency = 10;
            this.trkStartRad.Value = 50;
            this.trkStartRad.Scroll += new System.EventHandler(this.trkStartRad_Scroll);
            // 
            // trkEndRad
            // 
            this.trkEndRad.Location = new System.Drawing.Point(249, 180);
            this.trkEndRad.Maximum = 500;
            this.trkEndRad.Minimum = 3;
            this.trkEndRad.Name = "trkEndRad";
            this.trkEndRad.Size = new System.Drawing.Size(104, 42);
            this.trkEndRad.TabIndex = 82;
            this.trkEndRad.TickFrequency = 10;
            this.trkEndRad.Value = 10;
            this.trkEndRad.Scroll += new System.EventHandler(this.trkEndRad_Scroll);
            // 
            // txtHelixSpan
            // 
            this.txtHelixSpan.Location = new System.Drawing.Point(126, 254);
            this.txtHelixSpan.Name = "txtHelixSpan";
            this.txtHelixSpan.Size = new System.Drawing.Size(34, 20);
            this.txtHelixSpan.TabIndex = 84;
            this.txtHelixSpan.Text = "360.0";
            this.txtHelixSpan.TextChanged += new System.EventHandler(this.txtHelixEndAngle_TextChanged);
            // 
            // txtHelixStartAngle
            // 
            this.txtHelixStartAngle.Location = new System.Drawing.Point(126, 218);
            this.txtHelixStartAngle.Name = "txtHelixStartAngle";
            this.txtHelixStartAngle.Size = new System.Drawing.Size(38, 20);
            this.txtHelixStartAngle.TabIndex = 83;
            this.txtHelixStartAngle.Text = "0.0";
            this.txtHelixStartAngle.TextChanged += new System.EventHandler(this.txtHelixStartAngle_TextChanged);
            // 
            // trkStartAngle
            // 
            this.trkStartAngle.Location = new System.Drawing.Point(159, 218);
            this.trkStartAngle.Maximum = 360;
            this.trkStartAngle.Name = "trkStartAngle";
            this.trkStartAngle.Size = new System.Drawing.Size(104, 42);
            this.trkStartAngle.TabIndex = 85;
            this.trkStartAngle.TickFrequency = 10;
            this.trkStartAngle.Scroll += new System.EventHandler(this.trkStartAngle_Scroll);
            // 
            // trkHelixSpan
            // 
            this.trkHelixSpan.Location = new System.Drawing.Point(166, 252);
            this.trkHelixSpan.Maximum = 1080;
            this.trkHelixSpan.Minimum = 45;
            this.trkHelixSpan.Name = "trkHelixSpan";
            this.trkHelixSpan.Size = new System.Drawing.Size(104, 42);
            this.trkHelixSpan.TabIndex = 86;
            this.trkHelixSpan.TickFrequency = 100;
            this.trkHelixSpan.Value = 360;
            this.trkHelixSpan.Scroll += new System.EventHandler(this.trkEndAngle_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Angle";
            // 
            // trkNumPoints
            // 
            this.trkNumPoints.Location = new System.Drawing.Point(166, 300);
            this.trkNumPoints.Maximum = 64;
            this.trkNumPoints.Minimum = 4;
            this.trkNumPoints.Name = "trkNumPoints";
            this.trkNumPoints.Size = new System.Drawing.Size(104, 42);
            this.trkNumPoints.TabIndex = 90;
            this.trkNumPoints.TickFrequency = 2;
            this.trkNumPoints.Value = 16;
            this.trkNumPoints.Scroll += new System.EventHandler(this.trkNumPoints_Scroll);
            // 
            // txtHelixNumPoints
            // 
            this.txtHelixNumPoints.Location = new System.Drawing.Point(128, 300);
            this.txtHelixNumPoints.Name = "txtHelixNumPoints";
            this.txtHelixNumPoints.Size = new System.Drawing.Size(32, 20);
            this.txtHelixNumPoints.TabIndex = 89;
            this.txtHelixNumPoints.Text = "16";
            this.txtHelixNumPoints.TextChanged += new System.EventHandler(this.txtHelixNumPoints_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Number of Waypoints";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(49, 407);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(64, 13);
            this.label46.TabIndex = 93;
            this.label46.Text = "Camera POI";
            // 
            // cmbHelixPOI
            // 
            this.cmbHelixPOI.FormattingEnabled = true;
            this.cmbHelixPOI.Location = new System.Drawing.Point(119, 404);
            this.cmbHelixPOI.Name = "cmbHelixPOI";
            this.cmbHelixPOI.Size = new System.Drawing.Size(176, 21);
            this.cmbHelixPOI.TabIndex = 92;
            // 
            // chkHelixPOI
            // 
            this.chkHelixPOI.AutoSize = true;
            this.chkHelixPOI.Location = new System.Drawing.Point(153, 381);
            this.chkHelixPOI.Name = "chkHelixPOI";
            this.chkHelixPOI.Size = new System.Drawing.Size(74, 17);
            this.chkHelixPOI.TabIndex = 91;
            this.chkHelixPOI.Text = "POI Mode";
            this.chkHelixPOI.UseVisualStyleBackColor = true;
            this.chkHelixPOI.CheckedChanged += new System.EventHandler(this.chkHelixPOI_CheckedChanged);
            // 
            // chkHelicalHome
            // 
            this.chkHelicalHome.AutoSize = true;
            this.chkHelicalHome.Checked = true;
            this.chkHelicalHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHelicalHome.Location = new System.Drawing.Point(153, 350);
            this.chkHelicalHome.Name = "chkHelicalHome";
            this.chkHelicalHome.Size = new System.Drawing.Size(103, 17);
            this.chkHelicalHome.TabIndex = 94;
            this.chkHelicalHome.Text = "Home Start/End";
            this.chkHelicalHome.UseVisualStyleBackColor = true;
            this.chkHelicalHome.CheckedChanged += new System.EventHandler(this.chkHelicalHome_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Helix Span";
            // 
            // DialogAddHelixPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHelicalHome);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.cmbHelixPOI);
            this.Controls.Add(this.chkHelixPOI);
            this.Controls.Add(this.trkNumPoints);
            this.Controls.Add(this.txtHelixNumPoints);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkHelixSpan);
            this.Controls.Add(this.trkStartAngle);
            this.Controls.Add(this.txtHelixSpan);
            this.Controls.Add(this.txtHelixStartAngle);
            this.Controls.Add(this.trkEndRad);
            this.Controls.Add(this.trkStartRad);
            this.Controls.Add(this.trkEndAlt);
            this.Controls.Add(this.trkStartAlt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtHelixEndRadius);
            this.Controls.Add(this.txtHelixStartRadius);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtHelixEndAlt);
            this.Controls.Add(this.txtHelixStartAlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddHelixPathName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnCancelAddCircPath);
            this.Controls.Add(this.btnAddHelixPath);
            this.Name = "DialogAddHelixPath";
            this.Text = "Add Helical Path";
            this.Load += new System.EventHandler(this.DialogAddHelixPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEndRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHelixSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancelAddCircPath;
        private System.Windows.Forms.Button btnAddHelixPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCW;
        private System.Windows.Forms.RadioButton radioCCW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddHelixPathName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHelixEndRadius;
        private System.Windows.Forms.TextBox txtHelixStartRadius;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHelixEndAlt;
        private System.Windows.Forms.TextBox txtHelixStartAlt;
        private System.Windows.Forms.TrackBar trkStartAlt;
        private System.Windows.Forms.TrackBar trkEndAlt;
        private System.Windows.Forms.TrackBar trkStartRad;
        private System.Windows.Forms.TrackBar trkEndRad;
        private System.Windows.Forms.TextBox txtHelixSpan;
        private System.Windows.Forms.TextBox txtHelixStartAngle;
        private System.Windows.Forms.TrackBar trkStartAngle;
        private System.Windows.Forms.TrackBar trkHelixSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkNumPoints;
        private System.Windows.Forms.TextBox txtHelixNumPoints;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox cmbHelixPOI;
        private System.Windows.Forms.CheckBox chkHelixPOI;
        private System.Windows.Forms.CheckBox chkHelicalHome;
        private System.Windows.Forms.Label label2;
    }
}