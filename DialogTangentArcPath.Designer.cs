namespace Waypoint_Path_Generator
{
    partial class DialogTangentArcPath
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.trkRadius = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioCCW = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.trkAngle = new System.Windows.Forms.TrackBar();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPoints = new System.Windows.Forms.TextBox();
            this.trkNumPoints = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Enabled = false;
            this.txtRadius.Location = new System.Drawing.Point(86, 118);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(40, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // trkRadius
            // 
            this.trkRadius.Location = new System.Drawing.Point(141, 118);
            this.trkRadius.Maximum = 500;
            this.trkRadius.Minimum = 3;
            this.trkRadius.Name = "trkRadius";
            this.trkRadius.Size = new System.Drawing.Size(104, 42);
            this.trkRadius.TabIndex = 2;
            this.trkRadius.TickFrequency = 25;
            this.trkRadius.Value = 100;
            this.trkRadius.Scroll += new System.EventHandler(this.trkRadius_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioCCW);
            this.groupBox1.Location = new System.Drawing.Point(61, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "CW";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioCCW
            // 
            this.radioCCW.AutoSize = true;
            this.radioCCW.Checked = true;
            this.radioCCW.Location = new System.Drawing.Point(80, 19);
            this.radioCCW.Name = "radioCCW";
            this.radioCCW.Size = new System.Drawing.Size(50, 17);
            this.radioCCW.TabIndex = 0;
            this.radioCCW.TabStop = true;
            this.radioCCW.Text = "CCW";
            this.radioCCW.UseVisualStyleBackColor = true;
            this.radioCCW.CheckedChanged += new System.EventHandler(this.radioCW_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Enabled = false;
            this.txtAngle.Location = new System.Drawing.Point(86, 169);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(40, 20);
            this.txtAngle.TabIndex = 5;
            // 
            // trkAngle
            // 
            this.trkAngle.Location = new System.Drawing.Point(141, 166);
            this.trkAngle.Maximum = 360;
            this.trkAngle.Minimum = 5;
            this.trkAngle.Name = "trkAngle";
            this.trkAngle.Size = new System.Drawing.Size(104, 42);
            this.trkAngle.TabIndex = 6;
            this.trkAngle.TickFrequency = 10;
            this.trkAngle.Value = 90;
            this.trkAngle.Scroll += new System.EventHandler(this.trkAngle_Scroll);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(21, 260);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Num Points";
            // 
            // txtNumPoints
            // 
            this.txtNumPoints.Enabled = false;
            this.txtNumPoints.Location = new System.Drawing.Point(86, 212);
            this.txtNumPoints.Name = "txtNumPoints";
            this.txtNumPoints.Size = new System.Drawing.Size(40, 20);
            this.txtNumPoints.TabIndex = 10;
            // 
            // trkNumPoints
            // 
            this.trkNumPoints.Location = new System.Drawing.Point(141, 212);
            this.trkNumPoints.Maximum = 16;
            this.trkNumPoints.Minimum = 3;
            this.trkNumPoints.Name = "trkNumPoints";
            this.trkNumPoints.Size = new System.Drawing.Size(104, 42);
            this.trkNumPoints.TabIndex = 11;
            this.trkNumPoints.Value = 8;
            this.trkNumPoints.Scroll += new System.EventHandler(this.trkNumPoints_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 13;
            // 
            // DialogTangentArcPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 306);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkNumPoints);
            this.Controls.Add(this.txtNumPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.trkAngle);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trkRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogTangentArcPath";
            this.Text = "Tangent Path";
            ((System.ComponentModel.ISupportInitialize)(this.trkRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TrackBar trkRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioCCW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.TrackBar trkAngle;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumPoints;
        private System.Windows.Forms.TrackBar trkNumPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
    }
}