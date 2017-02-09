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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSwapAlt = new System.Windows.Forms.Button();
            this.chkSetAlt = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAllWP = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSinglePitch = new System.Windows.Forms.CheckBox();
            this.trkPitch2 = new System.Windows.Forms.TrackBar();
            this.trkPitch1 = new System.Windows.Forms.TrackBar();
            this.txtPitch2 = new System.Windows.Forms.TextBox();
            this.txtPitch1 = new System.Windows.Forms.TextBox();
            this.chkPOIMode = new System.Windows.Forms.CheckBox();
            this.cmbPOI = new System.Windows.Forms.ComboBox();
            this.chkSetPOI = new System.Windows.Forms.CheckBox();
            this.chkShowAlt = new System.Windows.Forms.CheckBox();
            this.chkShowHeading = new System.Windows.Forms.CheckBox();
            this.chkShowPitch = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trkWPDist = new System.Windows.Forms.TrackBar();
            this.txtWPDist = new System.Windows.Forms.TextBox();
            this.chkRemoveWP = new System.Windows.Forms.CheckBox();
            this.chkSHowDist = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkWPDist)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 673);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chartAlt
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAlt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAlt.Legends.Add(legend1);
            this.chartAlt.Location = new System.Drawing.Point(12, 417);
            this.chartAlt.Name = "chartAlt";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Altitude";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Heading";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Pitch";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Distance";
            this.chartAlt.Series.Add(series1);
            this.chartAlt.Series.Add(series2);
            this.chartAlt.Series.Add(series3);
            this.chartAlt.Series.Add(series4);
            this.chartAlt.Size = new System.Drawing.Size(791, 250);
            this.chartAlt.TabIndex = 1;
            this.chartAlt.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Path Altitude";
            this.chartAlt.Titles.Add(title1);
            this.chartAlt.Click += new System.EventHandler(this.chartAlt_Click);
            // 
            // trkAlt1
            // 
            this.trkAlt1.Location = new System.Drawing.Point(104, 100);
            this.trkAlt1.Maximum = 129;
            this.trkAlt1.Minimum = 5;
            this.trkAlt1.Name = "trkAlt1";
            this.trkAlt1.Size = new System.Drawing.Size(104, 42);
            this.trkAlt1.TabIndex = 2;
            this.trkAlt1.TickFrequency = 10;
            this.trkAlt1.Value = 30;
            this.trkAlt1.Scroll += new System.EventHandler(this.trkAlt1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altitude";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAlt1
            // 
            this.txtAlt1.Location = new System.Drawing.Point(22, 100);
            this.txtAlt1.Name = "txtAlt1";
            this.txtAlt1.Size = new System.Drawing.Size(49, 20);
            this.txtAlt1.TabIndex = 5;
            this.txtAlt1.TextChanged += new System.EventHandler(this.txtAlt1_TextChanged);
            // 
            // trkWP1
            // 
            this.trkWP1.Location = new System.Drawing.Point(128, 25);
            this.trkWP1.Name = "trkWP1";
            this.trkWP1.Size = new System.Drawing.Size(104, 42);
            this.trkWP1.TabIndex = 6;
            this.trkWP1.Scroll += new System.EventHandler(this.trkWP1_Scroll);
            // 
            // lblwp1
            // 
            this.lblwp1.AutoSize = true;
            this.lblwp1.Location = new System.Drawing.Point(150, 9);
            this.lblwp1.Name = "lblwp1";
            this.lblwp1.Size = new System.Drawing.Size(65, 13);
            this.lblwp1.TabIndex = 7;
            this.lblwp1.Text = "Waypoint xx";
            // 
            // txtAlt2
            // 
            this.txtAlt2.Location = new System.Drawing.Point(22, 148);
            this.txtAlt2.Name = "txtAlt2";
            this.txtAlt2.Size = new System.Drawing.Size(49, 20);
            this.txtAlt2.TabIndex = 8;
            this.txtAlt2.TextChanged += new System.EventHandler(this.txtAlt2_TextChanged);
            // 
            // trkAlt2
            // 
            this.trkAlt2.Location = new System.Drawing.Point(104, 148);
            this.trkAlt2.Maximum = 129;
            this.trkAlt2.Minimum = 5;
            this.trkAlt2.Name = "trkAlt2";
            this.trkAlt2.Size = new System.Drawing.Size(104, 42);
            this.trkAlt2.TabIndex = 9;
            this.trkAlt2.TickFrequency = 10;
            this.trkAlt2.Value = 30;
            this.trkAlt2.Scroll += new System.EventHandler(this.trkAlt2_Scroll);
            // 
            // trkWP2
            // 
            this.trkWP2.Location = new System.Drawing.Point(274, 25);
            this.trkWP2.Name = "trkWP2";
            this.trkWP2.Size = new System.Drawing.Size(104, 42);
            this.trkWP2.TabIndex = 10;
            this.trkWP2.Scroll += new System.EventHandler(this.trkWP2_Scroll);
            // 
            // lblwp2
            // 
            this.lblwp2.AutoSize = true;
            this.lblwp2.Location = new System.Drawing.Point(296, 9);
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
            this.chkSingleAlt.Location = new System.Drawing.Point(14, 65);
            this.chkSingleAlt.Name = "chkSingleAlt";
            this.chkSingleAlt.Size = new System.Drawing.Size(93, 17);
            this.chkSingleAlt.TabIndex = 13;
            this.chkSingleAlt.Text = "Single Altitude";
            this.chkSingleAlt.UseVisualStyleBackColor = true;
            this.chkSingleAlt.CheckedChanged += new System.EventHandler(this.chkSingleAlt_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(332, 340);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(149, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSwapAlt);
            this.groupBox1.Controls.Add(this.chkSetAlt);
            this.groupBox1.Controls.Add(this.chkSingleAlt);
            this.groupBox1.Controls.Add(this.trkAlt2);
            this.groupBox1.Controls.Add(this.txtAlt1);
            this.groupBox1.Controls.Add(this.txtAlt2);
            this.groupBox1.Controls.Add(this.trkAlt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 223);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altitude";
            // 
            // btnSwapAlt
            // 
            this.btnSwapAlt.Location = new System.Drawing.Point(113, 61);
            this.btnSwapAlt.Name = "btnSwapAlt";
            this.btnSwapAlt.Size = new System.Drawing.Size(120, 23);
            this.btnSwapAlt.TabIndex = 15;
            this.btnSwapAlt.Text = "Swap Altitude";
            this.btnSwapAlt.UseVisualStyleBackColor = true;
            this.btnSwapAlt.Click += new System.EventHandler(this.btnSwapAlt_Click);
            // 
            // chkSetAlt
            // 
            this.chkSetAlt.AutoSize = true;
            this.chkSetAlt.Location = new System.Drawing.Point(14, 33);
            this.chkSetAlt.Name = "chkSetAlt";
            this.chkSetAlt.Size = new System.Drawing.Size(80, 17);
            this.chkSetAlt.TabIndex = 14;
            this.chkSetAlt.Text = "Set Altitude";
            this.chkSetAlt.UseVisualStyleBackColor = true;
            this.chkSetAlt.CheckedChanged += new System.EventHandler(this.chkSetAlt_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAllWP);
            this.groupBox2.Controls.Add(this.lblwp1);
            this.groupBox2.Controls.Add(this.trkWP1);
            this.groupBox2.Controls.Add(this.trkWP2);
            this.groupBox2.Controls.Add(this.lblwp2);
            this.groupBox2.Location = new System.Drawing.Point(188, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 73);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Way Points";
            // 
            // chkAllWP
            // 
            this.chkAllWP.AutoSize = true;
            this.chkAllWP.Checked = true;
            this.chkAllWP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllWP.Location = new System.Drawing.Point(13, 25);
            this.chkAllWP.Name = "chkAllWP";
            this.chkAllWP.Size = new System.Drawing.Size(90, 17);
            this.chkAllWP.TabIndex = 12;
            this.chkAllWP.Text = "All Waypoints";
            this.chkAllWP.UseVisualStyleBackColor = true;
            this.chkAllWP.CheckedChanged += new System.EventHandler(this.chkAllWP_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSinglePitch);
            this.groupBox3.Controls.Add(this.trkPitch2);
            this.groupBox3.Controls.Add(this.trkPitch1);
            this.groupBox3.Controls.Add(this.txtPitch2);
            this.groupBox3.Controls.Add(this.txtPitch1);
            this.groupBox3.Controls.Add(this.chkPOIMode);
            this.groupBox3.Controls.Add(this.cmbPOI);
            this.groupBox3.Controls.Add(this.chkSetPOI);
            this.groupBox3.Location = new System.Drawing.Point(270, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 223);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // chkSinglePitch
            // 
            this.chkSinglePitch.AutoSize = true;
            this.chkSinglePitch.Checked = true;
            this.chkSinglePitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSinglePitch.Location = new System.Drawing.Point(22, 100);
            this.chkSinglePitch.Name = "chkSinglePitch";
            this.chkSinglePitch.Size = new System.Drawing.Size(82, 17);
            this.chkSinglePitch.TabIndex = 8;
            this.chkSinglePitch.Text = "Single Pitch";
            this.chkSinglePitch.UseVisualStyleBackColor = true;
            this.chkSinglePitch.CheckedChanged += new System.EventHandler(this.chkSinglePitch_CheckedChanged);
            // 
            // trkPitch2
            // 
            this.trkPitch2.Location = new System.Drawing.Point(91, 175);
            this.trkPitch2.Maximum = 15;
            this.trkPitch2.Minimum = -90;
            this.trkPitch2.Name = "trkPitch2";
            this.trkPitch2.Size = new System.Drawing.Size(104, 42);
            this.trkPitch2.TabIndex = 7;
            this.trkPitch2.TickFrequency = 10;
            this.trkPitch2.Scroll += new System.EventHandler(this.trkPitch2_Scroll);
            // 
            // trkPitch1
            // 
            this.trkPitch1.Location = new System.Drawing.Point(91, 136);
            this.trkPitch1.Maximum = 15;
            this.trkPitch1.Minimum = -90;
            this.trkPitch1.Name = "trkPitch1";
            this.trkPitch1.Size = new System.Drawing.Size(104, 42);
            this.trkPitch1.TabIndex = 6;
            this.trkPitch1.TickFrequency = 10;
            this.trkPitch1.Scroll += new System.EventHandler(this.trkPitch1_Scroll);
            // 
            // txtPitch2
            // 
            this.txtPitch2.Location = new System.Drawing.Point(18, 175);
            this.txtPitch2.Name = "txtPitch2";
            this.txtPitch2.Size = new System.Drawing.Size(58, 20);
            this.txtPitch2.TabIndex = 5;
            // 
            // txtPitch1
            // 
            this.txtPitch1.Location = new System.Drawing.Point(18, 136);
            this.txtPitch1.Name = "txtPitch1";
            this.txtPitch1.Size = new System.Drawing.Size(58, 20);
            this.txtPitch1.TabIndex = 4;
            // 
            // chkPOIMode
            // 
            this.chkPOIMode.AutoSize = true;
            this.chkPOIMode.Location = new System.Drawing.Point(22, 69);
            this.chkPOIMode.Name = "chkPOIMode";
            this.chkPOIMode.Size = new System.Drawing.Size(74, 17);
            this.chkPOIMode.TabIndex = 3;
            this.chkPOIMode.Text = "POI Mode";
            this.chkPOIMode.UseVisualStyleBackColor = true;
            this.chkPOIMode.CheckedChanged += new System.EventHandler(this.chkPOIMode_CheckedChanged);
            // 
            // cmbPOI
            // 
            this.cmbPOI.FormattingEnabled = true;
            this.cmbPOI.Location = new System.Drawing.Point(102, 69);
            this.cmbPOI.Name = "cmbPOI";
            this.cmbPOI.Size = new System.Drawing.Size(104, 21);
            this.cmbPOI.TabIndex = 1;
            // 
            // chkSetPOI
            // 
            this.chkSetPOI.AutoSize = true;
            this.chkSetPOI.Location = new System.Drawing.Point(22, 33);
            this.chkSetPOI.Name = "chkSetPOI";
            this.chkSetPOI.Size = new System.Drawing.Size(98, 17);
            this.chkSetPOI.TabIndex = 0;
            this.chkSetPOI.Text = "Adjust Heading";
            this.chkSetPOI.UseVisualStyleBackColor = true;
            this.chkSetPOI.CheckedChanged += new System.EventHandler(this.chkSetPOI_CheckedChanged);
            // 
            // chkShowAlt
            // 
            this.chkShowAlt.AutoSize = true;
            this.chkShowAlt.Checked = true;
            this.chkShowAlt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAlt.Location = new System.Drawing.Point(221, 381);
            this.chkShowAlt.Name = "chkShowAlt";
            this.chkShowAlt.Size = new System.Drawing.Size(61, 17);
            this.chkShowAlt.TabIndex = 18;
            this.chkShowAlt.Text = "Altitude";
            this.chkShowAlt.UseVisualStyleBackColor = true;
            // 
            // chkShowHeading
            // 
            this.chkShowHeading.AutoSize = true;
            this.chkShowHeading.Location = new System.Drawing.Point(332, 381);
            this.chkShowHeading.Name = "chkShowHeading";
            this.chkShowHeading.Size = new System.Drawing.Size(66, 17);
            this.chkShowHeading.TabIndex = 19;
            this.chkShowHeading.Text = "Heading";
            this.chkShowHeading.UseVisualStyleBackColor = true;
            this.chkShowHeading.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkShowPitch
            // 
            this.chkShowPitch.AutoSize = true;
            this.chkShowPitch.Location = new System.Drawing.Point(433, 381);
            this.chkShowPitch.Name = "chkShowPitch";
            this.chkShowPitch.Size = new System.Drawing.Size(50, 17);
            this.chkShowPitch.TabIndex = 20;
            this.chkShowPitch.Text = "Pitch";
            this.chkShowPitch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trkWPDist);
            this.groupBox4.Controls.Add(this.txtWPDist);
            this.groupBox4.Controls.Add(this.chkRemoveWP);
            this.groupBox4.Location = new System.Drawing.Point(531, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 107);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minimum WP Distance";
            // 
            // trkWPDist
            // 
            this.trkWPDist.Location = new System.Drawing.Point(107, 69);
            this.trkWPDist.Maximum = 30;
            this.trkWPDist.Minimum = 1;
            this.trkWPDist.Name = "trkWPDist";
            this.trkWPDist.Size = new System.Drawing.Size(118, 42);
            this.trkWPDist.TabIndex = 2;
            this.trkWPDist.Value = 3;
            this.trkWPDist.Scroll += new System.EventHandler(this.trkWPDist_Scroll);
            // 
            // txtWPDist
            // 
            this.txtWPDist.Location = new System.Drawing.Point(27, 69);
            this.txtWPDist.Name = "txtWPDist";
            this.txtWPDist.Size = new System.Drawing.Size(49, 20);
            this.txtWPDist.TabIndex = 1;
            // 
            // chkRemoveWP
            // 
            this.chkRemoveWP.AutoSize = true;
            this.chkRemoveWP.Location = new System.Drawing.Point(27, 33);
            this.chkRemoveWP.Name = "chkRemoveWP";
            this.chkRemoveWP.Size = new System.Drawing.Size(87, 17);
            this.chkRemoveWP.TabIndex = 0;
            this.chkRemoveWP.Text = "Remove WP";
            this.chkRemoveWP.UseVisualStyleBackColor = true;
            // 
            // chkSHowDist
            // 
            this.chkSHowDist.AutoSize = true;
            this.chkSHowDist.Location = new System.Drawing.Point(527, 381);
            this.chkSHowDist.Name = "chkSHowDist";
            this.chkSHowDist.Size = new System.Drawing.Size(68, 17);
            this.chkSHowDist.TabIndex = 22;
            this.chkSHowDist.Text = "Distance";
            this.chkSHowDist.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.cmbActions);
            this.groupBox5.Controls.Add(this.chkAction);
            this.groupBox5.Location = new System.Drawing.Point(531, 227);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 100);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Waypoint Actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Action";
            // 
            // cmbActions
            // 
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.Location = new System.Drawing.Point(104, 52);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(121, 21);
            this.cmbActions.TabIndex = 1;
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.Location = new System.Drawing.Point(27, 25);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(75, 17);
            this.chkAction.TabIndex = 0;
            this.chkAction.Text = "Set Action";
            this.chkAction.UseVisualStyleBackColor = true;
            // 
            // DialogPathAltitude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 715);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chkSHowDist);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chkShowPitch);
            this.Controls.Add(this.chkShowHeading);
            this.Controls.Add(this.chkShowAlt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.chartAlt);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPathAltitude";
            this.Text = "Edit Path Altitude";
            this.Load += new System.EventHandler(this.DialogPathAltitude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkWP2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkWPDist)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSetAlt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAllWP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkPOIMode;
        private System.Windows.Forms.ComboBox cmbPOI;
        private System.Windows.Forms.CheckBox chkSetPOI;
        private System.Windows.Forms.CheckBox chkShowAlt;
        private System.Windows.Forms.CheckBox chkShowHeading;
        private System.Windows.Forms.CheckBox chkShowPitch;
        private System.Windows.Forms.CheckBox chkSinglePitch;
        private System.Windows.Forms.TrackBar trkPitch2;
        private System.Windows.Forms.TrackBar trkPitch1;
        private System.Windows.Forms.TextBox txtPitch2;
        private System.Windows.Forms.TextBox txtPitch1;
        private System.Windows.Forms.Button btnSwapAlt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trkWPDist;
        private System.Windows.Forms.TextBox txtWPDist;
        private System.Windows.Forms.CheckBox chkRemoveWP;
        private System.Windows.Forms.CheckBox chkSHowDist;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbActions;
        private System.Windows.Forms.CheckBox chkAction;
    }
}