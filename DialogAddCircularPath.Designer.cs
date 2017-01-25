namespace Waypoint_Path_Generator
{
    partial class dialogAddCircularPath
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
            this.btnAddCircPath = new System.Windows.Forms.Button();
            this.btnCancelAddCircPath = new System.Windows.Forms.Button();
            this.txtDiaAddCircPathAlt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaAddCircPathRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCW = new System.Windows.Forms.RadioButton();
            this.radioCCW = new System.Windows.Forms.RadioButton();
            this.txtCircNumPoints = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkFullCircle = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCircSpan = new System.Windows.Forms.TextBox();
            this.txtCircStartAngle = new System.Windows.Forms.TextBox();
            this.chkCircHome = new System.Windows.Forms.CheckBox();
            this.txtDiaAddCircPathName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCircPOI = new System.Windows.Forms.ComboBox();
            this.chkCircPOI = new System.Windows.Forms.CheckBox();
            this.trkRadius = new System.Windows.Forms.TrackBar();
            this.trkNumPoints = new System.Windows.Forms.TrackBar();
            this.trkstartangle = new System.Windows.Forms.TrackBar();
            this.trkendangle = new System.Windows.Forms.TrackBar();
            this.trkAlt = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkstartangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkendangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCircPath
            // 
            this.btnAddCircPath.Location = new System.Drawing.Point(25, 403);
            this.btnAddCircPath.Name = "btnAddCircPath";
            this.btnAddCircPath.Size = new System.Drawing.Size(121, 23);
            this.btnAddCircPath.TabIndex = 0;
            this.btnAddCircPath.Text = "Add Circular Path";
            this.btnAddCircPath.UseVisualStyleBackColor = true;
            this.btnAddCircPath.Click += new System.EventHandler(this.btnAddCircPath_Click);
            // 
            // btnCancelAddCircPath
            // 
            this.btnCancelAddCircPath.Location = new System.Drawing.Point(232, 403);
            this.btnCancelAddCircPath.Name = "btnCancelAddCircPath";
            this.btnCancelAddCircPath.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCircPath.TabIndex = 1;
            this.btnCancelAddCircPath.Text = "Cancel";
            this.btnCancelAddCircPath.UseVisualStyleBackColor = true;
            this.btnCancelAddCircPath.Click += new System.EventHandler(this.bnCancelAddCircPath_Click);
            // 
            // txtDiaAddCircPathAlt
            // 
            this.txtDiaAddCircPathAlt.Location = new System.Drawing.Point(145, 129);
            this.txtDiaAddCircPathAlt.Name = "txtDiaAddCircPathAlt";
            this.txtDiaAddCircPathAlt.Size = new System.Drawing.Size(32, 20);
            this.txtDiaAddCircPathAlt.TabIndex = 2;
            this.txtDiaAddCircPathAlt.Text = "30";
            this.txtDiaAddCircPathAlt.TextChanged += new System.EventHandler(this.txtDiaAddCircPathAlt_TextChanged);
            this.txtDiaAddCircPathAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaAddCircPathAlt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altitude";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaAddCircPathRadius
            // 
            this.txtDiaAddCircPathRadius.Location = new System.Drawing.Point(145, 165);
            this.txtDiaAddCircPathRadius.Name = "txtDiaAddCircPathRadius";
            this.txtDiaAddCircPathRadius.Size = new System.Drawing.Size(32, 20);
            this.txtDiaAddCircPathRadius.TabIndex = 4;
            this.txtDiaAddCircPathRadius.Text = "30";
            this.txtDiaAddCircPathRadius.TextChanged += new System.EventHandler(this.txtDiaAddCircPathRadius_TextChanged);
            this.txtDiaAddCircPathRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaAddCircPathRadius_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Radius";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCW);
            this.groupBox1.Controls.Add(this.radioCCW);
            this.groupBox1.Location = new System.Drawing.Point(66, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 57;
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
            // txtCircNumPoints
            // 
            this.txtCircNumPoints.Location = new System.Drawing.Point(145, 200);
            this.txtCircNumPoints.Name = "txtCircNumPoints";
            this.txtCircNumPoints.Size = new System.Drawing.Size(32, 20);
            this.txtCircNumPoints.TabIndex = 59;
            this.txtCircNumPoints.Text = "16";
            this.txtCircNumPoints.TextChanged += new System.EventHandler(this.txtCircNumPoints_TextChanged);
            this.txtCircNumPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCircNumPoints_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Number of Segments";
            // 
            // chkFullCircle
            // 
            this.chkFullCircle.AutoSize = true;
            this.chkFullCircle.Checked = true;
            this.chkFullCircle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFullCircle.Location = new System.Drawing.Point(145, 237);
            this.chkFullCircle.Name = "chkFullCircle";
            this.chkFullCircle.Size = new System.Drawing.Size(71, 17);
            this.chkFullCircle.TabIndex = 60;
            this.chkFullCircle.Text = "Full Circle";
            this.chkFullCircle.UseVisualStyleBackColor = true;
            this.chkFullCircle.CheckedChanged += new System.EventHandler(this.chkFullCircle_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Circle Span (degrees)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Start Angle (degrees) ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCircSpan
            // 
            this.txtCircSpan.Location = new System.Drawing.Point(146, 307);
            this.txtCircSpan.Name = "txtCircSpan";
            this.txtCircSpan.Size = new System.Drawing.Size(42, 20);
            this.txtCircSpan.TabIndex = 62;
            this.txtCircSpan.Text = "360.0";
            this.txtCircSpan.TextChanged += new System.EventHandler(this.txtCircEndAngle_TextChanged);
            this.txtCircSpan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCircSpan_KeyDown);
            // 
            // txtCircStartAngle
            // 
            this.txtCircStartAngle.Location = new System.Drawing.Point(145, 269);
            this.txtCircStartAngle.Name = "txtCircStartAngle";
            this.txtCircStartAngle.Size = new System.Drawing.Size(43, 20);
            this.txtCircStartAngle.TabIndex = 61;
            this.txtCircStartAngle.Text = "0.0";
            this.txtCircStartAngle.TextChanged += new System.EventHandler(this.txtCircStartAngle_TextChanged);
            this.txtCircStartAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCircStartAngle_KeyDown);
            // 
            // chkCircHome
            // 
            this.chkCircHome.AutoSize = true;
            this.chkCircHome.Checked = true;
            this.chkCircHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCircHome.Location = new System.Drawing.Point(145, 346);
            this.chkCircHome.Name = "chkCircHome";
            this.chkCircHome.Size = new System.Drawing.Size(103, 17);
            this.chkCircHome.TabIndex = 65;
            this.chkCircHome.Text = "Home Start/End";
            this.chkCircHome.UseVisualStyleBackColor = true;
            this.chkCircHome.CheckedChanged += new System.EventHandler(this.chkCircHome_CheckedChanged);
            // 
            // txtDiaAddCircPathName
            // 
            this.txtDiaAddCircPathName.Location = new System.Drawing.Point(145, 94);
            this.txtDiaAddCircPathName.Name = "txtDiaAddCircPathName";
            this.txtDiaAddCircPathName.Size = new System.Drawing.Size(100, 20);
            this.txtDiaAddCircPathName.TabIndex = 67;
            this.txtDiaAddCircPathName.Text = "Untitled - Circular";
            this.txtDiaAddCircPathName.TextChanged += new System.EventHandler(this.txtDiaAddCircPathName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Path Name";
            // 
            // cmbCircPOI
            // 
            this.cmbCircPOI.FormattingEnabled = true;
            this.cmbCircPOI.Location = new System.Drawing.Point(146, 369);
            this.cmbCircPOI.Name = "cmbCircPOI";
            this.cmbCircPOI.Size = new System.Drawing.Size(173, 21);
            this.cmbCircPOI.TabIndex = 70;
            this.cmbCircPOI.SelectedIndexChanged += new System.EventHandler(this.cmbCircPOI_SelectedIndexChanged);
            // 
            // chkCircPOI
            // 
            this.chkCircPOI.AutoSize = true;
            this.chkCircPOI.Location = new System.Drawing.Point(59, 369);
            this.chkCircPOI.Name = "chkCircPOI";
            this.chkCircPOI.Size = new System.Drawing.Size(74, 17);
            this.chkCircPOI.TabIndex = 69;
            this.chkCircPOI.Text = "POI Mode";
            this.chkCircPOI.UseVisualStyleBackColor = true;
            this.chkCircPOI.CheckedChanged += new System.EventHandler(this.chkCircPOI_CheckedChanged);
            // 
            // trkRadius
            // 
            this.trkRadius.Location = new System.Drawing.Point(183, 165);
            this.trkRadius.Maximum = 500;
            this.trkRadius.Minimum = 5;
            this.trkRadius.Name = "trkRadius";
            this.trkRadius.Size = new System.Drawing.Size(104, 42);
            this.trkRadius.TabIndex = 71;
            this.trkRadius.TickFrequency = 10;
            this.trkRadius.Value = 30;
            this.trkRadius.Scroll += new System.EventHandler(this.trkRadius_Scroll);
            // 
            // trkNumPoints
            // 
            this.trkNumPoints.Location = new System.Drawing.Point(183, 200);
            this.trkNumPoints.Maximum = 32;
            this.trkNumPoints.Minimum = 3;
            this.trkNumPoints.Name = "trkNumPoints";
            this.trkNumPoints.Size = new System.Drawing.Size(104, 42);
            this.trkNumPoints.TabIndex = 72;
            this.trkNumPoints.Value = 16;
            this.trkNumPoints.Scroll += new System.EventHandler(this.trkNumPoints_Scroll);
            // 
            // trkstartangle
            // 
            this.trkstartangle.Location = new System.Drawing.Point(194, 269);
            this.trkstartangle.Maximum = 360;
            this.trkstartangle.Name = "trkstartangle";
            this.trkstartangle.Size = new System.Drawing.Size(104, 42);
            this.trkstartangle.TabIndex = 73;
            this.trkstartangle.TickFrequency = 45;
            this.trkstartangle.Scroll += new System.EventHandler(this.trkstartangle_Scroll);
            // 
            // trkendangle
            // 
            this.trkendangle.Location = new System.Drawing.Point(194, 307);
            this.trkendangle.Maximum = 360;
            this.trkendangle.Minimum = 15;
            this.trkendangle.Name = "trkendangle";
            this.trkendangle.Size = new System.Drawing.Size(104, 42);
            this.trkendangle.TabIndex = 74;
            this.trkendangle.TickFrequency = 45;
            this.trkendangle.Value = 360;
            this.trkendangle.Scroll += new System.EventHandler(this.trkendangle_Scroll);
            // 
            // trkAlt
            // 
            this.trkAlt.Location = new System.Drawing.Point(183, 129);
            this.trkAlt.Maximum = 129;
            this.trkAlt.Minimum = 5;
            this.trkAlt.Name = "trkAlt";
            this.trkAlt.Size = new System.Drawing.Size(104, 42);
            this.trkAlt.TabIndex = 75;
            this.trkAlt.TickFrequency = 10;
            this.trkAlt.Value = 5;
            this.trkAlt.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // dialogAddCircularPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 439);
            this.Controls.Add(this.trkAlt);
            this.Controls.Add(this.trkendangle);
            this.Controls.Add(this.trkstartangle);
            this.Controls.Add(this.trkNumPoints);
            this.Controls.Add(this.txtCircNumPoints);
            this.Controls.Add(this.trkRadius);
            this.Controls.Add(this.cmbCircPOI);
            this.Controls.Add(this.chkCircPOI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaAddCircPathName);
            this.Controls.Add(this.chkCircHome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCircSpan);
            this.Controls.Add(this.txtCircStartAngle);
            this.Controls.Add(this.chkFullCircle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiaAddCircPathRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaAddCircPathAlt);
            this.Controls.Add(this.btnCancelAddCircPath);
            this.Controls.Add(this.btnAddCircPath);
            this.Name = "dialogAddCircularPath";
            this.Text = "Add Circular Path";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dialogAddCircularPath_FormClosed);
            this.Load += new System.EventHandler(this.dialogAddCircularPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkstartangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkendangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCircPath;
        private System.Windows.Forms.Button btnCancelAddCircPath;
        private System.Windows.Forms.TextBox txtDiaAddCircPathAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaAddCircPathRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCW;
        private System.Windows.Forms.RadioButton radioCCW;
        private System.Windows.Forms.TextBox txtCircNumPoints;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkFullCircle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCircSpan;
        private System.Windows.Forms.TextBox txtCircStartAngle;
        private System.Windows.Forms.CheckBox chkCircHome;
        private System.Windows.Forms.TextBox txtDiaAddCircPathName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCircPOI;
        private System.Windows.Forms.CheckBox chkCircPOI;
        private System.Windows.Forms.TrackBar trkRadius;
        private System.Windows.Forms.TrackBar trkNumPoints;
        private System.Windows.Forms.TrackBar trkstartangle;
        private System.Windows.Forms.TrackBar trkendangle;
        private System.Windows.Forms.TrackBar trkAlt;
    }
}