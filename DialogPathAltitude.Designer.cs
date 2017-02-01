namespace Waypoint_Path_Generator
{
    partial class DialogPathAltitude
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnClose = new System.Windows.Forms.Button();
            this.chartAlt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trkAlt1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlt1 = new System.Windows.Forms.TextBox();
            this.trkWP1 = new System.Windows.Forms.TrackBar();
            this.lblwp1 = new System.Windows.Forms.Label();
            this.txtAlt2 = new System.Windows.Forms.TextBox();
            this.trkAlt2 = new System.Windows.Forms.TrackBar();
            this.trkWP2 = new System.Windows.Forms.TrackBar();
            this.lblwp2 = new System.Windows.Forms.Label();
            this.chkSingleAlt = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(540, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chartAlt
            // 
            chartArea5.Name = "ChartArea1";
            this.chartAlt.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartAlt.Legends.Add(legend5);
            this.chartAlt.Location = new System.Drawing.Point(51, 225);
            this.chartAlt.Name = "chartAlt";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Altitude";
            this.chartAlt.Series.Add(series5);
            this.chartAlt.Size = new System.Drawing.Size(1080, 250);
            this.chartAlt.TabIndex = 1;
            this.chartAlt.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Path Altitude";
            this.chartAlt.Titles.Add(title5);
            this.chartAlt.Click += new System.EventHandler(this.chartAlt_Click);
            // 
            // trkAlt1
            // 
            this.trkAlt1.Location = new System.Drawing.Point(462, 83);
            this.trkAlt1.Maximum = 129;
            this.trkAlt1.Minimum = 5;
            this.trkAlt1.Name = "trkAlt1";
            this.trkAlt1.Size = new System.Drawing.Size(104, 42);
            this.trkAlt1.TabIndex = 2;
            this.trkAlt1.Value = 30;
            this.trkAlt1.Scroll += new System.EventHandler(this.trkAlt1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altitude";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAlt1
            // 
            this.txtAlt1.Location = new System.Drawing.Point(407, 83);
            this.txtAlt1.Name = "txtAlt1";
            this.txtAlt1.Size = new System.Drawing.Size(49, 20);
            this.txtAlt1.TabIndex = 5;
            // 
            // trkWP1
            // 
            this.trkWP1.Location = new System.Drawing.Point(572, 83);
            this.trkWP1.Name = "trkWP1";
            this.trkWP1.Size = new System.Drawing.Size(104, 42);
            this.trkWP1.TabIndex = 6;
            this.trkWP1.Scroll += new System.EventHandler(this.trkWP1_Scroll);
            // 
            // lblwp1
            // 
            this.lblwp1.AutoSize = true;
            this.lblwp1.Location = new System.Drawing.Point(594, 67);
            this.lblwp1.Name = "lblwp1";
            this.lblwp1.Size = new System.Drawing.Size(65, 13);
            this.lblwp1.TabIndex = 7;
            this.lblwp1.Text = "Waypoint xx";
            // 
            // txtAlt2
            // 
            this.txtAlt2.Location = new System.Drawing.Point(407, 142);
            this.txtAlt2.Name = "txtAlt2";
            this.txtAlt2.Size = new System.Drawing.Size(49, 20);
            this.txtAlt2.TabIndex = 8;
            // 
            // trkAlt2
            // 
            this.trkAlt2.Location = new System.Drawing.Point(462, 142);
            this.trkAlt2.Maximum = 129;
            this.trkAlt2.Minimum = 5;
            this.trkAlt2.Name = "trkAlt2";
            this.trkAlt2.Size = new System.Drawing.Size(104, 42);
            this.trkAlt2.TabIndex = 9;
            this.trkAlt2.Value = 30;
            this.trkAlt2.Scroll += new System.EventHandler(this.trkAlt2_Scroll);
            // 
            // trkWP2
            // 
            this.trkWP2.Location = new System.Drawing.Point(572, 142);
            this.trkWP2.Name = "trkWP2";
            this.trkWP2.Size = new System.Drawing.Size(104, 42);
            this.trkWP2.TabIndex = 10;
            this.trkWP2.Scroll += new System.EventHandler(this.trkWP2_Scroll);
            // 
            // lblwp2
            // 
            this.lblwp2.AutoSize = true;
            this.lblwp2.Location = new System.Drawing.Point(594, 126);
            this.lblwp2.Name = "lblwp2";
            this.lblwp2.Size = new System.Drawing.Size(65, 13);
            this.lblwp2.TabIndex = 11;
            this.lblwp2.Text = "Waypoint xx";
            // 
            // chkSingleAlt
            // 
            this.chkSingleAlt.AutoSize = true;
            this.chkSingleAlt.Checked = true;
            this.chkSingleAlt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSingleAlt.Location = new System.Drawing.Point(471, 32);
            this.chkSingleAlt.Name = "chkSingleAlt";
            this.chkSingleAlt.Size = new System.Drawing.Size(93, 17);
            this.chkSingleAlt.TabIndex = 13;
            this.chkSingleAlt.Text = "Single Altitude";
            this.chkSingleAlt.UseVisualStyleBackColor = true;
            this.chkSingleAlt.CheckedChanged += new System.EventHandler(this.chkSingleAlt_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(540, 190);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // DialogPathAltitude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 547);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.chkSingleAlt);
            this.Controls.Add(this.lblwp2);
            this.Controls.Add(this.trkWP2);
            this.Controls.Add(this.trkAlt2);
            this.Controls.Add(this.txtAlt2);
            this.Controls.Add(this.lblwp1);
            this.Controls.Add(this.trkWP1);
            this.Controls.Add(this.txtAlt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkAlt1);
            this.Controls.Add(this.chartAlt);
            this.Controls.Add(this.btnClose);
            this.Name = "DialogPathAltitude";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DialogPathAltitude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlt;
        private System.Windows.Forms.TrackBar trkAlt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlt1;
        private System.Windows.Forms.TrackBar trkWP1;
        private System.Windows.Forms.Label lblwp1;
        private System.Windows.Forms.TextBox txtAlt2;
        private System.Windows.Forms.TrackBar trkAlt2;
        private System.Windows.Forms.TrackBar trkWP2;
        private System.Windows.Forms.Label lblwp2;
        private System.Windows.Forms.CheckBox chkSingleAlt;
        private System.Windows.Forms.Button btnApply;
    }
}