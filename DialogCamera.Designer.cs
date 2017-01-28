namespace Waypoint_Path_Generator
{
    partial class DialogCamera
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtImageVerOverlap = new System.Windows.Forms.TextBox();
            this.txtImageHorOverlap = new System.Windows.Forms.TextBox();
            this.txtImageWidth = new System.Windows.Forms.TextBox();
            this.txtImageLength = new System.Windows.Forms.TextBox();
            this.txtCamVerAngle = new System.Windows.Forms.TextBox();
            this.txtCamHorAngle = new System.Windows.Forms.TextBox();
            this.lblImageWidth = new System.Windows.Forms.Label();
            this.lblImageLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.trkAltitude = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(181, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "Width Overlap (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Length Overlap (%)";
            // 
            // txtImageVerOverlap
            // 
            this.txtImageVerOverlap.Location = new System.Drawing.Point(201, 260);
            this.txtImageVerOverlap.Name = "txtImageVerOverlap";
            this.txtImageVerOverlap.Size = new System.Drawing.Size(100, 20);
            this.txtImageVerOverlap.TabIndex = 43;
            this.txtImageVerOverlap.Text = "15.0";
            // 
            // txtImageHorOverlap
            // 
            this.txtImageHorOverlap.Location = new System.Drawing.Point(40, 260);
            this.txtImageHorOverlap.Name = "txtImageHorOverlap";
            this.txtImageHorOverlap.Size = new System.Drawing.Size(100, 20);
            this.txtImageHorOverlap.TabIndex = 42;
            this.txtImageHorOverlap.Text = "25.0";
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(198, 188);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.ReadOnly = true;
            this.txtImageWidth.Size = new System.Drawing.Size(100, 20);
            this.txtImageWidth.TabIndex = 39;
            // 
            // txtImageLength
            // 
            this.txtImageLength.Location = new System.Drawing.Point(40, 188);
            this.txtImageLength.Name = "txtImageLength";
            this.txtImageLength.ReadOnly = true;
            this.txtImageLength.Size = new System.Drawing.Size(100, 20);
            this.txtImageLength.TabIndex = 38;
            // 
            // txtCamVerAngle
            // 
            this.txtCamVerAngle.Location = new System.Drawing.Point(193, 122);
            this.txtCamVerAngle.Name = "txtCamVerAngle";
            this.txtCamVerAngle.Size = new System.Drawing.Size(112, 20);
            this.txtCamVerAngle.TabIndex = 35;
            this.txtCamVerAngle.Text = "66";
            this.txtCamVerAngle.TextChanged += new System.EventHandler(this.txtCamVerAngle_TextChanged);
            // 
            // txtCamHorAngle
            // 
            this.txtCamHorAngle.Location = new System.Drawing.Point(37, 122);
            this.txtCamHorAngle.Name = "txtCamHorAngle";
            this.txtCamHorAngle.Size = new System.Drawing.Size(100, 20);
            this.txtCamHorAngle.TabIndex = 34;
            this.txtCamHorAngle.Text = "81";
            this.txtCamHorAngle.TextChanged += new System.EventHandler(this.txtCamHorAngle_TextChanged);
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageWidth.Location = new System.Drawing.Point(202, 172);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(99, 13);
            this.lblImageWidth.TabIndex = 41;
            this.lblImageWidth.Text = "Image Width (m)";
            // 
            // lblImageLength
            // 
            this.lblImageLength.AutoSize = true;
            this.lblImageLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageLength.Location = new System.Drawing.Point(42, 172);
            this.lblImageLength.Name = "lblImageLength";
            this.lblImageLength.Size = new System.Drawing.Size(98, 13);
            this.lblImageLength.TabIndex = 40;
            this.lblImageLength.Text = "Image Lenth (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Horizontal Angle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Vertical Angle";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(117, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 22);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Camera Configuration";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(117, 44);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(50, 20);
            this.txtAlt.TabIndex = 48;
            this.txtAlt.Text = "30";
            this.txtAlt.TextChanged += new System.EventHandler(this.txtAlt_TextChanged);
            // 
            // trkAltitude
            // 
            this.trkAltitude.Location = new System.Drawing.Point(184, 44);
            this.trkAltitude.Maximum = 129;
            this.trkAltitude.Minimum = 5;
            this.trkAltitude.Name = "trkAltitude";
            this.trkAltitude.Size = new System.Drawing.Size(121, 42);
            this.trkAltitude.TabIndex = 49;
            this.trkAltitude.TickFrequency = 10;
            this.trkAltitude.Value = 5;
            this.trkAltitude.Scroll += new System.EventHandler(this.trkAltitude_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Altitude";
            // 
            // DialogCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trkAltitude);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtImageVerOverlap);
            this.Controls.Add(this.txtImageHorOverlap);
            this.Controls.Add(this.txtImageWidth);
            this.Controls.Add(this.txtImageLength);
            this.Controls.Add(this.txtCamVerAngle);
            this.Controls.Add(this.txtCamHorAngle);
            this.Controls.Add(this.lblImageWidth);
            this.Controls.Add(this.lblImageLength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "DialogCamera";
            this.Text = "Camera Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DialogCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkAltitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtImageVerOverlap;
        private System.Windows.Forms.TextBox txtImageHorOverlap;
        public System.Windows.Forms.TextBox txtImageWidth;
        private System.Windows.Forms.TextBox txtImageLength;
        private System.Windows.Forms.TextBox txtCamVerAngle;
        private System.Windows.Forms.TextBox txtCamHorAngle;
        private System.Windows.Forms.Label lblImageWidth;
        private System.Windows.Forms.Label lblImageLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TrackBar trkAltitude;
        private System.Windows.Forms.Label label2;
    }
}