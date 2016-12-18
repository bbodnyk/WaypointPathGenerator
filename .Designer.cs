namespace Waypoint_Path_Generator
{
    partial class frmAddPOI
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
            this.btnAddPOI = new System.Windows.Forms.Button();
            this.btnCancelAddPOI = new System.Windows.Forms.Button();
            this.txtAddPOIName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPOIAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddPOICamAlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddPOI = new System.Windows.Forms.Label();
            this.txtAddPOIElev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPOI
            // 
            this.btnAddPOI.Location = new System.Drawing.Point(41, 184);
            this.btnAddPOI.Name = "btnAddPOI";
            this.btnAddPOI.Size = new System.Drawing.Size(75, 23);
            this.btnAddPOI.TabIndex = 0;
            this.btnAddPOI.Text = "Add POI";
            this.btnAddPOI.UseVisualStyleBackColor = true;
            this.btnAddPOI.Click += new System.EventHandler(this.btnAddPOI_Click);
            // 
            // btnCancelAddPOI
            // 
            this.btnCancelAddPOI.Location = new System.Drawing.Point(170, 184);
            this.btnCancelAddPOI.Name = "btnCancelAddPOI";
            this.btnCancelAddPOI.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddPOI.TabIndex = 1;
            this.btnCancelAddPOI.Text = "Cancel";
            this.btnCancelAddPOI.UseVisualStyleBackColor = true;
            this.btnCancelAddPOI.Click += new System.EventHandler(this.btnCancelAddPOI_Click);
            // 
            // txtAddPOIName
            // 
            this.txtAddPOIName.Location = new System.Drawing.Point(119, 39);
            this.txtAddPOIName.Name = "txtAddPOIName";
            this.txtAddPOIName.Size = new System.Drawing.Size(100, 20);
            this.txtAddPOIName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "POI Name";
            // 
            // txtAddPOIAlt
            // 
            this.txtAddPOIAlt.Location = new System.Drawing.Point(119, 91);
            this.txtAddPOIAlt.Name = "txtAddPOIAlt";
            this.txtAddPOIAlt.Size = new System.Drawing.Size(100, 20);
            this.txtAddPOIAlt.TabIndex = 4;
            this.txtAddPOIAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPosNumeric_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "POI Altitude";
            // 
            // txtAddPOICamAlt
            // 
            this.txtAddPOICamAlt.Location = new System.Drawing.Point(119, 117);
            this.txtAddPOICamAlt.Name = "txtAddPOICamAlt";
            this.txtAddPOICamAlt.Size = new System.Drawing.Size(100, 20);
            this.txtAddPOICamAlt.TabIndex = 6;
            this.txtAddPOICamAlt.TextChanged += new System.EventHandler(this.txtAddPOICamAlt_TextChanged);
            this.txtAddPOICamAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPosNumeric_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Camera Altitude";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAddPOI
            // 
            this.lblAddPOI.AutoSize = true;
            this.lblAddPOI.Location = new System.Drawing.Point(116, 9);
            this.lblAddPOI.Name = "lblAddPOI";
            this.lblAddPOI.Size = new System.Drawing.Size(35, 13);
            this.lblAddPOI.TabIndex = 8;
            this.lblAddPOI.Text = "label4";
            // 
            // txtAddPOIElev
            // 
            this.txtAddPOIElev.Location = new System.Drawing.Point(119, 65);
            this.txtAddPOIElev.Name = "txtAddPOIElev";
            this.txtAddPOIElev.Size = new System.Drawing.Size(100, 20);
            this.txtAddPOIElev.TabIndex = 9;
            this.txtAddPOIElev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "POI Elevation";
            // 
            // frmAddPOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddPOIElev);
            this.Controls.Add(this.lblAddPOI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddPOICamAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddPOIAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddPOIName);
            this.Controls.Add(this.btnCancelAddPOI);
            this.Controls.Add(this.btnAddPOI);
            this.MaximumSize = new System.Drawing.Size(292, 239);
            this.MinimumSize = new System.Drawing.Size(292, 239);
            this.Name = "frmAddPOI";
            this.Text = "Add POI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPOI;
        private System.Windows.Forms.Button btnCancelAddPOI;
        private System.Windows.Forms.TextBox txtAddPOIName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPOIAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPOICamAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddPOI;
        private System.Windows.Forms.TextBox txtAddPOIElev;
        private System.Windows.Forms.Label label4;
    }
}