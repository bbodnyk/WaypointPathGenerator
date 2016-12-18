namespace Waypoint_Path_Generator
{
    partial class DialogKMLPath
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
            this.label76 = new System.Windows.Forms.Label();
            this.btnSelectKMLFile = new System.Windows.Forms.Button();
            this.cmbKLMPOI = new System.Windows.Forms.ComboBox();
            this.chKLMPOI = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddKML = new System.Windows.Forms.Button();
            this.txtKMLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKMLRead = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(69, 9);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(143, 20);
            this.label76.TabIndex = 35;
            this.label76.Text = "Import KML Path";
            // 
            // btnSelectKMLFile
            // 
            this.btnSelectKMLFile.Location = new System.Drawing.Point(39, 59);
            this.btnSelectKMLFile.Name = "btnSelectKMLFile";
            this.btnSelectKMLFile.Size = new System.Drawing.Size(189, 23);
            this.btnSelectKMLFile.TabIndex = 34;
            this.btnSelectKMLFile.Text = "Select KML FIle";
            this.btnSelectKMLFile.UseVisualStyleBackColor = true;
            this.btnSelectKMLFile.Click += new System.EventHandler(this.btnSelectKMLFile_Click);
            // 
            // cmbKLMPOI
            // 
            this.cmbKLMPOI.FormattingEnabled = true;
            this.cmbKLMPOI.Location = new System.Drawing.Point(39, 132);
            this.cmbKLMPOI.Name = "cmbKLMPOI";
            this.cmbKLMPOI.Size = new System.Drawing.Size(189, 21);
            this.cmbKLMPOI.TabIndex = 37;
            this.cmbKLMPOI.SelectedIndexChanged += new System.EventHandler(this.cmbKLMPOI_SelectedIndexChanged);
            // 
            // chKLMPOI
            // 
            this.chKLMPOI.AutoSize = true;
            this.chKLMPOI.Location = new System.Drawing.Point(86, 99);
            this.chKLMPOI.Name = "chKLMPOI";
            this.chKLMPOI.Size = new System.Drawing.Size(74, 17);
            this.chKLMPOI.TabIndex = 36;
            this.chKLMPOI.Text = "POI Mode";
            this.chKLMPOI.UseVisualStyleBackColor = true;
            this.chKLMPOI.CheckedChanged += new System.EventHandler(this.chKLMPOI_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddKML
            // 
            this.btnAddKML.Location = new System.Drawing.Point(19, 396);
            this.btnAddKML.Name = "btnAddKML";
            this.btnAddKML.Size = new System.Drawing.Size(75, 23);
            this.btnAddKML.TabIndex = 39;
            this.btnAddKML.Text = "Add KML Path";
            this.btnAddKML.UseVisualStyleBackColor = true;
            this.btnAddKML.Click += new System.EventHandler(this.btnAddKML_Click);
            // 
            // txtKMLName
            // 
            this.txtKMLName.Location = new System.Drawing.Point(39, 187);
            this.txtKMLName.Name = "txtKMLName";
            this.txtKMLName.Size = new System.Drawing.Size(189, 20);
            this.txtKMLName.TabIndex = 40;
            this.txtKMLName.TextChanged += new System.EventHandler(this.txtKMLName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Path Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbKMLRead
            // 
            this.rtbKMLRead.Location = new System.Drawing.Point(12, 232);
            this.rtbKMLRead.Name = "rtbKMLRead";
            this.rtbKMLRead.Size = new System.Drawing.Size(268, 158);
            this.rtbKMLRead.TabIndex = 42;
            this.rtbKMLRead.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DialogKMLPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 431);
            this.Controls.Add(this.rtbKMLRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKMLName);
            this.Controls.Add(this.btnAddKML);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbKLMPOI);
            this.Controls.Add(this.chKLMPOI);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.btnSelectKMLFile);
            this.Name = "DialogKMLPath";
            this.Text = "Import KML Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Button btnSelectKMLFile;
        private System.Windows.Forms.ComboBox cmbKLMPOI;
        private System.Windows.Forms.CheckBox chKLMPOI;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddKML;
        private System.Windows.Forms.TextBox txtKMLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbKMLRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}