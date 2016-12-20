namespace Waypoint_Path_Generator
{
    partial class DialogPolyPerimPath
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
            this.txtAltPolyPath = new System.Windows.Forms.TextBox();
            this.cmbPolyPath = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.trkAltPolyPath = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkAltPolyPath)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAltPolyPath
            // 
            this.txtAltPolyPath.Location = new System.Drawing.Point(102, 53);
            this.txtAltPolyPath.Name = "txtAltPolyPath";
            this.txtAltPolyPath.Size = new System.Drawing.Size(51, 20);
            this.txtAltPolyPath.TabIndex = 56;
            this.txtAltPolyPath.Text = "30";
            this.txtAltPolyPath.TextChanged += new System.EventHandler(this.txtAltPolyPath_TextChanged);
            // 
            // cmbPolyPath
            // 
            this.cmbPolyPath.FormattingEnabled = true;
            this.cmbPolyPath.Location = new System.Drawing.Point(102, 94);
            this.cmbPolyPath.Name = "cmbPolyPath";
            this.cmbPolyPath.Size = new System.Drawing.Size(166, 21);
            this.cmbPolyPath.TabIndex = 55;
            this.cmbPolyPath.SelectedIndexChanged += new System.EventHandler(this.cmbPolyPath_SelectedIndexChanged);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(3, 9);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(277, 20);
            this.label95.TabIndex = 54;
            this.label95.Text = "Generate Polygon Perimeter Path";
            // 
            // trkAltPolyPath
            // 
            this.trkAltPolyPath.Location = new System.Drawing.Point(164, 53);
            this.trkAltPolyPath.Maximum = 129;
            this.trkAltPolyPath.Minimum = 5;
            this.trkAltPolyPath.Name = "trkAltPolyPath";
            this.trkAltPolyPath.Size = new System.Drawing.Size(104, 42);
            this.trkAltPolyPath.TabIndex = 57;
            this.trkAltPolyPath.Value = 30;
            this.trkAltPolyPath.Scroll += new System.EventHandler(this.trkAltPolyPath_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Altitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Polygon";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(19, 146);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 60;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DialogPolyPerimPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkAltPolyPath);
            this.Controls.Add(this.txtAltPolyPath);
            this.Controls.Add(this.cmbPolyPath);
            this.Controls.Add(this.label95);
            this.Name = "DialogPolyPerimPath";
            this.Text = "Add Polygon Perimeter Path";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trkAltPolyPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltPolyPath;
        private System.Windows.Forms.ComboBox cmbPolyPath;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TrackBar trkAltPolyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.Button btnCancel;
    }
}