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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.trkAngle = new System.Windows.Forms.TrackBar();
            this.lbltrkAngleValue = new System.Windows.Forms.Label();
            this.lbltrkNumPoints = new System.Windows.Forms.Label();
            this.trkNumPoints = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Parabolic"});
            this.comboBox1.Location = new System.Drawing.Point(97, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(12, 237);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // trkAngle
            // 
            this.trkAngle.Location = new System.Drawing.Point(97, 66);
            this.trkAngle.Maximum = 360;
            this.trkAngle.Minimum = 90;
            this.trkAngle.Name = "trkAngle";
            this.trkAngle.Size = new System.Drawing.Size(104, 42);
            this.trkAngle.TabIndex = 3;
            this.trkAngle.TickFrequency = 10;
            this.trkAngle.Value = 180;
            this.trkAngle.Scroll += new System.EventHandler(this.trkAngle_Scroll);
            // 
            // lbltrkAngleValue
            // 
            this.lbltrkAngleValue.AutoSize = true;
            this.lbltrkAngleValue.Location = new System.Drawing.Point(128, 50);
            this.lbltrkAngleValue.Name = "lbltrkAngleValue";
            this.lbltrkAngleValue.Size = new System.Drawing.Size(35, 13);
            this.lbltrkAngleValue.TabIndex = 4;
            this.lbltrkAngleValue.Text = "label1";
            this.lbltrkAngleValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltrkAngleValue.Click += new System.EventHandler(this.lbltrkValue_Click);
            // 
            // lbltrkNumPoints
            // 
            this.lbltrkNumPoints.AutoSize = true;
            this.lbltrkNumPoints.Location = new System.Drawing.Point(128, 111);
            this.lbltrkNumPoints.Name = "lbltrkNumPoints";
            this.lbltrkNumPoints.Size = new System.Drawing.Size(35, 13);
            this.lbltrkNumPoints.TabIndex = 5;
            this.lbltrkNumPoints.Text = "label1";
            this.lbltrkNumPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trkNumPoints
            // 
            this.trkNumPoints.Location = new System.Drawing.Point(97, 127);
            this.trkNumPoints.Maximum = 64;
            this.trkNumPoints.Minimum = 3;
            this.trkNumPoints.Name = "trkNumPoints";
            this.trkNumPoints.Size = new System.Drawing.Size(104, 42);
            this.trkNumPoints.TabIndex = 6;
            this.trkNumPoints.Value = 32;
            this.trkNumPoints.Scroll += new System.EventHandler(this.trkNumPoints_Scroll);
            // 
            // DialogAddMathPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.trkNumPoints);
            this.Controls.Add(this.lbltrkNumPoints);
            this.Controls.Add(this.lbltrkAngleValue);
            this.Controls.Add(this.trkAngle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.comboBox1);
            this.Name = "DialogAddMathPath";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DialogAddMathPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar trkAngle;
        private System.Windows.Forms.Label lbltrkAngleValue;
        private System.Windows.Forms.Label lbltrkNumPoints;
        private System.Windows.Forms.TrackBar trkNumPoints;
    }
}