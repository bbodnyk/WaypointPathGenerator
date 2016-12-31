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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkGenCamRect
            // 
            this.chkGenCamRect.AutoSize = true;
            this.chkGenCamRect.Location = new System.Drawing.Point(114, 25);
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
            this.txtKMLPath.Location = new System.Drawing.Point(114, 59);
            this.txtKMLPath.Name = "txtKMLPath";
            this.txtKMLPath.Size = new System.Drawing.Size(150, 20);
            this.txtKMLPath.TabIndex = 21;
            // 
            // txtKMLFilePath
            // 
            this.txtKMLFilePath.Location = new System.Drawing.Point(114, 98);
            this.txtKMLFilePath.Name = "txtKMLFilePath";
            this.txtKMLFilePath.Size = new System.Drawing.Size(150, 20);
            this.txtKMLFilePath.TabIndex = 18;
            // 
            // txtCSVFilePath
            // 
            this.txtCSVFilePath.Location = new System.Drawing.Point(114, 44);
            this.txtCSVFilePath.Name = "txtCSVFilePath";
            this.txtCSVFilePath.Size = new System.Drawing.Size(150, 20);
            this.txtCSVFilePath.TabIndex = 15;
            // 
            // btnOutputKML
            // 
            this.btnOutputKML.Location = new System.Drawing.Point(114, 133);
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
            this.btnOutputCVS.Location = new System.Drawing.Point(114, 70);
            this.btnOutputCVS.Name = "btnOutputCVS";
            this.btnOutputCVS.Size = new System.Drawing.Size(150, 23);
            this.btnOutputCVS.TabIndex = 17;
            this.btnOutputCVS.Text = "Output CSV File";
            this.btnOutputCVS.UseVisualStyleBackColor = true;
            this.btnOutputCVS.Click += new System.EventHandler(this.btnOutputCVS_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = " CSV File Path";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 321);
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
            this.groupBox1.Size = new System.Drawing.Size(286, 107);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKMLPath);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.btnOutputKML);
            this.groupBox2.Controls.Add(this.chkGenCamRect);
            this.groupBox2.Controls.Add(this.txtKMLFilePath);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 178);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KML Output";
            // 
            // DialogOutputPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 351);
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
    }
}