namespace Waypoint_Path_Generator
{
    partial class DialogEditWP
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
            this.txtwplat = new System.Windows.Forms.TextBox();
            this.txtwplon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwpalt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtwphead = new System.Windows.Forms.TextBox();
            this.txtwpcurvesize = new System.Windows.Forms.TextBox();
            this.txtwprotdirection = new System.Windows.Forms.TextBox();
            this.txtwpgimblemode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgimblepitch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.trkHeading = new System.Windows.Forms.TrackBar();
            this.trkCurveSize = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCurveSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtwplat
            // 
            this.txtwplat.Location = new System.Drawing.Point(87, 16);
            this.txtwplat.Name = "txtwplat";
            this.txtwplat.ReadOnly = true;
            this.txtwplat.Size = new System.Drawing.Size(100, 20);
            this.txtwplat.TabIndex = 0;
            // 
            // txtwplon
            // 
            this.txtwplon.Location = new System.Drawing.Point(87, 42);
            this.txtwplon.Name = "txtwplon";
            this.txtwplon.ReadOnly = true;
            this.txtwplon.Size = new System.Drawing.Size(100, 20);
            this.txtwplon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logitude";
            // 
            // txtwpalt
            // 
            this.txtwpalt.Location = new System.Drawing.Point(87, 68);
            this.txtwpalt.Name = "txtwpalt";
            this.txtwpalt.Size = new System.Drawing.Size(100, 20);
            this.txtwpalt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altitude";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(21, 342);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(103, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept Changes";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtwphead
            // 
            this.txtwphead.Location = new System.Drawing.Point(87, 94);
            this.txtwphead.Name = "txtwphead";
            this.txtwphead.Size = new System.Drawing.Size(37, 20);
            this.txtwphead.TabIndex = 8;
            this.txtwphead.TextChanged += new System.EventHandler(this.txtwphead_TextChanged);
            // 
            // txtwpcurvesize
            // 
            this.txtwpcurvesize.Location = new System.Drawing.Point(87, 129);
            this.txtwpcurvesize.Name = "txtwpcurvesize";
            this.txtwpcurvesize.Size = new System.Drawing.Size(37, 20);
            this.txtwpcurvesize.TabIndex = 9;
            this.txtwpcurvesize.TextChanged += new System.EventHandler(this.txtwpcurvesize_TextChanged);
            // 
            // txtwprotdirection
            // 
            this.txtwprotdirection.Location = new System.Drawing.Point(87, 164);
            this.txtwprotdirection.Name = "txtwprotdirection";
            this.txtwprotdirection.Size = new System.Drawing.Size(100, 20);
            this.txtwprotdirection.TabIndex = 10;
            // 
            // txtwpgimblemode
            // 
            this.txtwpgimblemode.Location = new System.Drawing.Point(87, 200);
            this.txtwpgimblemode.Name = "txtwpgimblemode";
            this.txtwpgimblemode.Size = new System.Drawing.Size(100, 20);
            this.txtwpgimblemode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Heading";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Curve Size";
            // 
            // txtgimblepitch
            // 
            this.txtgimblepitch.Location = new System.Drawing.Point(87, 234);
            this.txtgimblepitch.Name = "txtgimblepitch";
            this.txtgimblepitch.Size = new System.Drawing.Size(37, 20);
            this.txtgimblepitch.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rotation Dir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gimble Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gimble Pitch";
            // 
            // cmbActions
            // 
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.Location = new System.Drawing.Point(87, 270);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(121, 21);
            this.cmbActions.TabIndex = 18;
            // 
            // trkHeading
            // 
            this.trkHeading.Location = new System.Drawing.Point(130, 94);
            this.trkHeading.Maximum = 360;
            this.trkHeading.Name = "trkHeading";
            this.trkHeading.Size = new System.Drawing.Size(104, 42);
            this.trkHeading.TabIndex = 19;
            this.trkHeading.Scroll += new System.EventHandler(this.trkHeading_Scroll);
            // 
            // trkCurveSize
            // 
            this.trkCurveSize.Location = new System.Drawing.Point(130, 129);
            this.trkCurveSize.Maximum = 30;
            this.trkCurveSize.Name = "trkCurveSize";
            this.trkCurveSize.Size = new System.Drawing.Size(104, 42);
            this.trkCurveSize.TabIndex = 20;
            this.trkCurveSize.Scroll += new System.EventHandler(this.trkCurceSize_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Actions";
            // 
            // DialogEditWP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 391);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtwprotdirection);
            this.Controls.Add(this.trkCurveSize);
            this.Controls.Add(this.txtwpcurvesize);
            this.Controls.Add(this.trkHeading);
            this.Controls.Add(this.cmbActions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgimblepitch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtwpgimblemode);
            this.Controls.Add(this.txtwphead);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtwpalt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwplon);
            this.Controls.Add(this.txtwplat);
            this.Name = "DialogEditWP";
            this.Text = "Edit Waypoint";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trkHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCurveSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwplat;
        private System.Windows.Forms.TextBox txtwplon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtwpalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtwphead;
        private System.Windows.Forms.TextBox txtwpcurvesize;
        private System.Windows.Forms.TextBox txtwprotdirection;
        private System.Windows.Forms.TextBox txtwpgimblemode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgimblepitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbActions;
        private System.Windows.Forms.TrackBar trkHeading;
        private System.Windows.Forms.TrackBar trkCurveSize;
        private System.Windows.Forms.Label label9;
    }
}