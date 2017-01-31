namespace Waypoint_Path_Generator
{
    partial class DialogOutputPath
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
            this.chkGenCamRect = new System.Windows.Forms.CheckBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtKMLPath = new System.Windows.Forms.TextBox();
            this.txtKMLFilePath = new System.Windows.Forms.TextBox();
            this.txtCSVFilePath = new System.Windows.Forms.TextBox();
            this.btnOutputKML = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnOutputCVS = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOutputMissionPlanner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMissionPlanner = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkGenCamRect
            // 
            this.chkGenCamRect.AutoSize = true;
            this.chkGenCamRect.Location = new System.Drawing.Point(145, 24);
            this.chkGenCamRect.Name = "chkGenCamRect";
            this.chkGenCamRect.Size = new System.Drawing.Size(146, 17);
            this.chkGenCamRect.TabIndex = 23;
            this.chkGenCamRect.Text = "Generate Camera Images";
            this.chkGenCamRect.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(4, 63);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(85, 13);
            this.label52.TabIndex = 22;
            this.label52.Text = "KML Path Name";
            // 
            // txtKMLPath
            // 
            this.txtKMLPath.Location = new System.Drawing.Point(145, 58);
            this.txtKMLPath.Name = "txtKMLPath";
            this.txtKMLPath.Size = new System.Drawing.Size(150, 20);
            this.txtKMLPath.TabIndex = 21;
            // 
            // txtKMLFilePath
            // 
            this.txtKMLFilePath.Location = new System.Drawing.Point(145, 97);
            this.txtKMLFilePath.Name = "txtKMLFilePath";
            this.txtKMLFilePath.Size = new System.Drawing.Size(150, 20);
            this.txtKMLFilePath.TabIndex = 18;
            // 
            // txtCSVFilePath
            // 
            this.txtCSVFilePath.Location = new System.Drawing.Point(144, 41);
            this.txtCSVFilePath.Name = "txtCSVFilePath";
            this.txtCSVFilePath.Size = new System.Drawing.Size(150, 20);
            this.txtCSVFilePath.TabIndex = 15;
            // 
            // btnOutputKML
            // 
            this.btnOutputKML.Location = new System.Drawing.Point(145, 123);
            this.btnOutputKML.Name = "btnOutputKML";
            this.btnOutputKML.Size = new System.Drawing.Size(150, 23);
            this.btnOutputKML.TabIndex = 20;
            this.btnOutputKML.Text = "Output KML File";
            this.btnOutputKML.UseVisualStyleBackColor = true;
            this.btnOutputKML.Click += new System.EventHandler(this.btnOutputKML_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "KML File Path";
            // 
            // btnOutputCVS
            // 
            this.btnOutputCVS.Location = new System.Drawing.Point(144, 67);
            this.btnOutputCVS.Name = "btnOutputCVS";
            this.btnOutputCVS.Size = new System.Drawing.Size(150, 23);
            this.btnOutputCVS.TabIndex = 17;
            this.btnOutputCVS.Text = "Output for Mission Hub";
            this.btnOutputCVS.UseVisualStyleBackColor = true;
            this.btnOutputCVS.Click += new System.EventHandler(this.btnOutputCVS_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "Mission Hub File Path";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOutputCVS);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtCSVFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 107);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mission Hub - Litchi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKMLPath);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.btnOutputKML);
            this.groupBox2.Controls.Add(this.chkGenCamRect);
            this.groupBox2.Controls.Add(this.txtKMLFilePath);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 178);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KML Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOutputMissionPlanner);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMissionPlanner);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 107);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mission Planner - Arducopter";
            // 
            // btnOutputMissionPlanner
            // 
            this.btnOutputMissionPlanner.Location = new System.Drawing.Point(144, 60);
            this.btnOutputMissionPlanner.Name = "btnOutputMissionPlanner";
            this.btnOutputMissionPlanner.Size = new System.Drawing.Size(150, 23);
            this.btnOutputMissionPlanner.TabIndex = 17;
            this.btnOutputMissionPlanner.Text = "Output for Mission Planner";
            this.btnOutputMissionPlanner.UseVisualStyleBackColor = true;
            this.btnOutputMissionPlanner.Click += new System.EventHandler(this.btnOutputMissionPlanner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mission Planner File Path";
            // 
            // txtMissionPlanner
            // 
            this.txtMissionPlanner.Location = new System.Drawing.Point(144, 34);
            this.txtMissionPlanner.Name = "txtMissionPlanner";
            this.txtMissionPlanner.Size = new System.Drawing.Size(150, 20);
            this.txtMissionPlanner.TabIndex = 15;
            // 
            // DialogOutputPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Name = "DialogOutputPath";
            this.Text = "Output Path";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGenCamRect;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtKMLPath;
        private System.Windows.Forms.TextBox txtKMLFilePath;
        private System.Windows.Forms.TextBox txtCSVFilePath;
        private System.Windows.Forms.Button btnOutputKML;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnOutputCVS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOutputMissionPlanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMissionPlanner;
    }
}