namespace Waypoint_Path_Generator
{
    partial class DialogAddMathPath
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
            this.cmbPathType = new System.Windows.Forms.ComboBox();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.trkAngle = new System.Windows.Forms.TrackBar();
            this.lbltrkAngleValue = new System.Windows.Forms.Label();
            this.lbltrkNumPoints = new System.Windows.Forms.Label();
            this.trkNumPoints = new System.Windows.Forms.TrackBar();
            this.trkAlt1 = new System.Windows.Forms.TrackBar();
            this.lbltrkAlt1 = new System.Windows.Forms.Label();
            this.rtbMathPath = new System.Windows.Forms.RichTextBox();
            this.trkSize = new System.Windows.Forms.TrackBar();
            this.lbltrkSize = new System.Windows.Forms.Label();
            this.txtPathName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.trkScaleX = new System.Windows.Forms.TrackBar();
            this.trkScaleY = new System.Windows.Forms.TrackBar();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trkStartAngle = new System.Windows.Forms.TrackBar();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.trkRadius1 = new System.Windows.Forms.TrackBar();
            this.trkRadius2 = new System.Windows.Forms.TrackBar();
            this.lblRadius1 = new System.Windows.Forms.Label();
            this.lblRadius2 = new System.Windows.Forms.Label();
            this.chkPOI = new System.Windows.Forms.CheckBox();
            this.cmbPOI = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPathType
            // 
            this.cmbPathType.FormattingEnabled = true;
            this.cmbPathType.Items.AddRange(new object[] {
            "",
            "Eliptical",
            "Parabolic",
            "Cubic",
            "Trisectrix",
            "Botanic-1",
            "Botanic-2",
            "Strophoid",
            "Folium"});
            this.cmbPathType.Location = new System.Drawing.Point(90, 48);
            this.cmbPathType.Name = "cmbPathType";
            this.cmbPathType.Size = new System.Drawing.Size(121, 21);
            this.cmbPathType.TabIndex = 0;
            this.cmbPathType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(12, 650);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 650);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // trkAngle
            // 
            this.trkAngle.Location = new System.Drawing.Point(94, 176);
            this.trkAngle.Maximum = 360;
            this.trkAngle.Name = "trkAngle";
            this.trkAngle.Size = new System.Drawing.Size(104, 42);
            this.trkAngle.TabIndex = 3;
            this.trkAngle.TickFrequency = 10;
            this.trkAngle.Scroll += new System.EventHandler(this.trkAngle_Scroll);
            // 
            // lbltrkAngleValue
            // 
            this.lbltrkAngleValue.AutoSize = true;
            this.lbltrkAngleValue.Location = new System.Drawing.Point(9, 176);
            this.lbltrkAngleValue.Name = "lbltrkAngleValue";
            this.lbltrkAngleValue.Size = new System.Drawing.Size(35, 13);
            this.lbltrkAngleValue.TabIndex = 4;
            this.lbltrkAngleValue.Text = "label1";
            this.lbltrkAngleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltrkAngleValue.Click += new System.EventHandler(this.lbltrkValue_Click);
            // 
            // lbltrkNumPoints
            // 
            this.lbltrkNumPoints.AutoSize = true;
            this.lbltrkNumPoints.Location = new System.Drawing.Point(9, 268);
            this.lbltrkNumPoints.Name = "lbltrkNumPoints";
            this.lbltrkNumPoints.Size = new System.Drawing.Size(35, 13);
            this.lbltrkNumPoints.TabIndex = 5;
            this.lbltrkNumPoints.Text = "label1";
            this.lbltrkNumPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trkNumPoints
            // 
            this.trkNumPoints.Location = new System.Drawing.Point(90, 268);
            this.trkNumPoints.Maximum = 64;
            this.trkNumPoints.Minimum = 3;
            this.trkNumPoints.Name = "trkNumPoints";
            this.trkNumPoints.Size = new System.Drawing.Size(104, 42);
            this.trkNumPoints.TabIndex = 6;
            this.trkNumPoints.TickFrequency = 2;
            this.trkNumPoints.Value = 32;
            this.trkNumPoints.Scroll += new System.EventHandler(this.trkNumPoints_Scroll);
            // 
            // trkAlt1
            // 
            this.trkAlt1.Location = new System.Drawing.Point(94, 97);
            this.trkAlt1.Maximum = 129;
            this.trkAlt1.Minimum = 5;
            this.trkAlt1.Name = "trkAlt1";
            this.trkAlt1.Size = new System.Drawing.Size(104, 42);
            this.trkAlt1.TabIndex = 7;
            this.trkAlt1.TickFrequency = 10;
            this.trkAlt1.Value = 30;
            this.trkAlt1.Scroll += new System.EventHandler(this.trkAlt1_Scroll);
            // 
            // lbltrkAlt1
            // 
            this.lbltrkAlt1.AutoSize = true;
            this.lbltrkAlt1.Location = new System.Drawing.Point(9, 97);
            this.lbltrkAlt1.Name = "lbltrkAlt1";
            this.lbltrkAlt1.Size = new System.Drawing.Size(35, 13);
            this.lbltrkAlt1.TabIndex = 8;
            this.lbltrkAlt1.Text = "label1";
            this.lbltrkAlt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltrkAlt1.Click += new System.EventHandler(this.lbltrkAlt1_Click);
            // 
            // rtbMathPath
            // 
            this.rtbMathPath.Location = new System.Drawing.Point(12, 492);
            this.rtbMathPath.Name = "rtbMathPath";
            this.rtbMathPath.Size = new System.Drawing.Size(389, 143);
            this.rtbMathPath.TabIndex = 9;
            this.rtbMathPath.Text = "";
            // 
            // trkSize
            // 
            this.trkSize.Location = new System.Drawing.Point(94, 135);
            this.trkSize.Maximum = 500;
            this.trkSize.Minimum = 10;
            this.trkSize.Name = "trkSize";
            this.trkSize.Size = new System.Drawing.Size(104, 42);
            this.trkSize.TabIndex = 10;
            this.trkSize.TickFrequency = 10;
            this.trkSize.Value = 30;
            this.trkSize.Scroll += new System.EventHandler(this.trkSize_Scroll);
            // 
            // lbltrkSize
            // 
            this.lbltrkSize.AutoSize = true;
            this.lbltrkSize.Location = new System.Drawing.Point(9, 135);
            this.lbltrkSize.Name = "lbltrkSize";
            this.lbltrkSize.Size = new System.Drawing.Size(35, 13);
            this.lbltrkSize.TabIndex = 11;
            this.lbltrkSize.Text = "label1";
            this.lbltrkSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltrkSize.Click += new System.EventHandler(this.lbltrkSize_Click);
            // 
            // txtPathName
            // 
            this.txtPathName.Location = new System.Drawing.Point(94, 12);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.Size = new System.Drawing.Size(100, 20);
            this.txtPathName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Path Name";
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(85, 316);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(41, 20);
            this.txtScaleX.TabIndex = 14;
            // 
            // trkScaleX
            // 
            this.trkScaleX.Location = new System.Drawing.Point(133, 316);
            this.trkScaleX.Minimum = 1;
            this.trkScaleX.Name = "trkScaleX";
            this.trkScaleX.Size = new System.Drawing.Size(104, 42);
            this.trkScaleX.TabIndex = 15;
            this.trkScaleX.Value = 1;
            this.trkScaleX.Scroll += new System.EventHandler(this.trkScaleX_Scroll);
            // 
            // trkScaleY
            // 
            this.trkScaleY.Location = new System.Drawing.Point(133, 364);
            this.trkScaleY.Maximum = 100;
            this.trkScaleY.Minimum = 1;
            this.trkScaleY.Name = "trkScaleY";
            this.trkScaleY.Size = new System.Drawing.Size(104, 42);
            this.trkScaleY.TabIndex = 17;
            this.trkScaleY.Value = 1;
            this.trkScaleY.Scroll += new System.EventHandler(this.trkScaleY_Scroll);
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(85, 364);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(41, 20);
            this.txtScaleY.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "X Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Y Scale";
            // 
            // trkStartAngle
            // 
            this.trkStartAngle.Location = new System.Drawing.Point(94, 224);
            this.trkStartAngle.Maximum = 360;
            this.trkStartAngle.Name = "trkStartAngle";
            this.trkStartAngle.Size = new System.Drawing.Size(104, 42);
            this.trkStartAngle.TabIndex = 20;
            this.trkStartAngle.TickFrequency = 10;
            this.trkStartAngle.Scroll += new System.EventHandler(this.trkStartAngle_Scroll);
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(9, 224);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(35, 13);
            this.lblStartAngle.TabIndex = 21;
            this.lblStartAngle.Text = "label4";
            this.lblStartAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trkRadius1
            // 
            this.trkRadius1.Location = new System.Drawing.Point(297, 97);
            this.trkRadius1.Maximum = 500;
            this.trkRadius1.Minimum = 5;
            this.trkRadius1.Name = "trkRadius1";
            this.trkRadius1.Size = new System.Drawing.Size(104, 42);
            this.trkRadius1.TabIndex = 22;
            this.trkRadius1.Value = 5;
            this.trkRadius1.Scroll += new System.EventHandler(this.trkRadius1_Scroll);
            // 
            // trkRadius2
            // 
            this.trkRadius2.Location = new System.Drawing.Point(297, 135);
            this.trkRadius2.Maximum = 500;
            this.trkRadius2.Minimum = 5;
            this.trkRadius2.Name = "trkRadius2";
            this.trkRadius2.Size = new System.Drawing.Size(104, 42);
            this.trkRadius2.TabIndex = 23;
            this.trkRadius2.Value = 5;
            this.trkRadius2.Scroll += new System.EventHandler(this.trkRadius2_Scroll);
            // 
            // lblRadius1
            // 
            this.lblRadius1.AutoSize = true;
            this.lblRadius1.Location = new System.Drawing.Point(204, 97);
            this.lblRadius1.Name = "lblRadius1";
            this.lblRadius1.Size = new System.Drawing.Size(35, 13);
            this.lblRadius1.TabIndex = 24;
            this.lblRadius1.Text = "label4";
            // 
            // lblRadius2
            // 
            this.lblRadius2.AutoSize = true;
            this.lblRadius2.Location = new System.Drawing.Point(204, 135);
            this.lblRadius2.Name = "lblRadius2";
            this.lblRadius2.Size = new System.Drawing.Size(35, 13);
            this.lblRadius2.TabIndex = 25;
            this.lblRadius2.Text = "label5";
            // 
            // chkPOI
            // 
            this.chkPOI.AutoSize = true;
            this.chkPOI.Location = new System.Drawing.Point(43, 415);
            this.chkPOI.Name = "chkPOI";
            this.chkPOI.Size = new System.Drawing.Size(74, 17);
            this.chkPOI.TabIndex = 26;
            this.chkPOI.Text = "POI Mode";
            this.chkPOI.UseVisualStyleBackColor = true;
            this.chkPOI.CheckedChanged += new System.EventHandler(this.chkPOI_CheckedChanged);
            // 
            // cmbPOI
            // 
            this.cmbPOI.FormattingEnabled = true;
            this.cmbPOI.Location = new System.Drawing.Point(133, 413);
            this.cmbPOI.Name = "cmbPOI";
            this.cmbPOI.Size = new System.Drawing.Size(121, 21);
            this.cmbPOI.TabIndex = 27;
            this.cmbPOI.SelectedIndexChanged += new System.EventHandler(this.cmbPOI_SelectedIndexChanged);
            // 
            // DialogAddMathPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 681);
            this.Controls.Add(this.cmbPOI);
            this.Controls.Add(this.chkPOI);
            this.Controls.Add(this.lblRadius2);
            this.Controls.Add(this.lblRadius1);
            this.Controls.Add(this.trkRadius2);
            this.Controls.Add(this.trkRadius1);
            this.Controls.Add(this.lblStartAngle);
            this.Controls.Add(this.trkStartAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trkScaleY);
            this.Controls.Add(this.txtScaleY);
            this.Controls.Add(this.trkScaleX);
            this.Controls.Add(this.txtScaleX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathName);
            this.Controls.Add(this.lbltrkSize);
            this.Controls.Add(this.trkSize);
            this.Controls.Add(this.rtbMathPath);
            this.Controls.Add(this.lbltrkAlt1);
            this.Controls.Add(this.trkAlt1);
            this.Controls.Add(this.trkNumPoints);
            this.Controls.Add(this.lbltrkNumPoints);
            this.Controls.Add(this.lbltrkAngleValue);
            this.Controls.Add(this.trkAngle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.cmbPathType);
            this.Name = "DialogAddMathPath";
            this.Text = "Mathamatical Path";
            this.Load += new System.EventHandler(this.DialogAddMathPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStartAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPathType;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar trkAngle;
        private System.Windows.Forms.Label lbltrkAngleValue;
        private System.Windows.Forms.Label lbltrkNumPoints;
        private System.Windows.Forms.TrackBar trkNumPoints;
        private System.Windows.Forms.TrackBar trkAlt1;
        private System.Windows.Forms.Label lbltrkAlt1;
        private System.Windows.Forms.RichTextBox rtbMathPath;
        private System.Windows.Forms.TrackBar trkSize;
        private System.Windows.Forms.Label lbltrkSize;
        private System.Windows.Forms.TextBox txtPathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.TrackBar trkScaleX;
        private System.Windows.Forms.TrackBar trkScaleY;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkStartAngle;
        private System.Windows.Forms.Label lblStartAngle;
        private System.Windows.Forms.TrackBar trkRadius1;
        private System.Windows.Forms.TrackBar trkRadius2;
        private System.Windows.Forms.Label lblRadius1;
        private System.Windows.Forms.Label lblRadius2;
        private System.Windows.Forms.CheckBox chkPOI;
        private System.Windows.Forms.ComboBox cmbPOI;
    }
}