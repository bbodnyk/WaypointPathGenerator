namespace Waypoint_Path_Generator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("POI");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Polygons");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Objects", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.cntxtgMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolAddPOI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAddPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddManualPath = new System.Windows.Forms.ToolStripMenuItem();
            this.addCircularPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHelicalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addManualPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonGridPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAddKMLPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAddPolyPerimPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedWaypointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolInsertWP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolInsertWPBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolInsertWPAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolJoinPaths = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSplitatWP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSplitBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSplitAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReversePath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUnselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteWP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteShape = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.POI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPOIShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPOIHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPathShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPathHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.unHideAllPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPOIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedWaypointToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPolygonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOutputPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolToggleCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReDrawgMap = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadStartXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imperialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabGMap = new System.Windows.Forms.TabPage();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.trkMapScale = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMouseLon = new System.Windows.Forms.TextBox();
            this.txtMouseLat = new System.Windows.Forms.TextBox();
            this.btngMapRedraw = new System.Windows.Forms.Button();
            this.treGMap = new System.Windows.Forms.TreeView();
            this.label109 = new System.Windows.Forms.Label();
            this.cmbGMapProvider = new System.Windows.Forms.ComboBox();
            this.tabWayActions = new System.Windows.Forms.TabPage();
            this.btnCreatePOIWP = new System.Windows.Forms.Button();
            this.label101 = new System.Windows.Forms.Label();
            this.txtPOIWPName = new System.Windows.Forms.TextBox();
            this.txtPOIWP = new System.Windows.Forms.TextBox();
            this.txtWPEnd = new System.Windows.Forms.TextBox();
            this.txtWPStart = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.btnApplyAction = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.cmbActionsWaypoints = new System.Windows.Forms.ComboBox();
            this.dgvActionsWaypoints = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.dgvActionsPath = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.label71 = new System.Windows.Forms.Label();
            this.btnSaveAction = new System.Windows.Forms.Button();
            this.btnDelectAction = new System.Windows.Forms.Button();
            this.btnClearActionsGUI = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.txtNewActionName = new System.Windows.Forms.TextBox();
            this.txtActionParam12 = new System.Windows.Forms.TextBox();
            this.txtActionParam13 = new System.Windows.Forms.TextBox();
            this.txtActionParam14 = new System.Windows.Forms.TextBox();
            this.txtActionParam15 = new System.Windows.Forms.TextBox();
            this.txtActionParam11 = new System.Windows.Forms.TextBox();
            this.txtActionParam7 = new System.Windows.Forms.TextBox();
            this.txtActionParam8 = new System.Windows.Forms.TextBox();
            this.txtActionParam9 = new System.Windows.Forms.TextBox();
            this.txtActionParam10 = new System.Windows.Forms.TextBox();
            this.txtActionParam6 = new System.Windows.Forms.TextBox();
            this.txtActionParam2 = new System.Windows.Forms.TextBox();
            this.txtActionParam3 = new System.Windows.Forms.TextBox();
            this.txtActionParam4 = new System.Windows.Forms.TextBox();
            this.txtActionParam5 = new System.Windows.Forms.TextBox();
            this.txtActionParam1 = new System.Windows.Forms.TextBox();
            this.cmbAction12 = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbAction13 = new System.Windows.Forms.ComboBox();
            this.label66 = new System.Windows.Forms.Label();
            this.cmbAction14 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.cmbAction15 = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cmbAction11 = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            this.cmbAction7 = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cmbAction8 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.cmbAction9 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.cmbAction10 = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.cmbAction6 = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.cmbAction2 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.cmbAction3 = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.cmbAction4 = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cmbAction5 = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.cmbAction1 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.cmbActionsList = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
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
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEarthRadius = new System.Windows.Forms.TextBox();
            this.txtGPSRadius = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.txtCenterLon = new System.Windows.Forms.TextBox();
            this.txtCenterLat = new System.Windows.Forms.TextBox();
            this.lblEarthRadius = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabControl();
            this.cntxtgMap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabGMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMapScale)).BeginInit();
            this.tabWayActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionsWaypoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionsPath)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntxtgMap
            // 
            this.cntxtgMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAddPOI,
            this.ToolAddPath,
            this.toolAddPoly,
            this.toolStripSeparator8,
            this.toolStripMenuItem5,
            this.toolStripSeparator4,
            this.toolInsertWP,
            this.toolJoinPaths,
            this.toolSplitatWP,
            this.toolReversePath,
            this.toolStripSeparator7,
            this.toolUnselectAll,
            this.toolStripSeparator6,
            this.toolStripMenuItem6,
            this.toolStripMenuItem3,
            this.toolDeleteWP,
            this.toolDeleteShape,
            this.toolStripSeparator2,
            this.POI,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripSeparator3,
            this.toolStripMenuItem4,
            this.toolStripSeparator10,
            this.toolStripMenuItem7,
            this.toolStripSeparator9,
            this.toolOutputPath,
            this.toolStripSeparator5,
            this.toolToggleCenter,
            this.toolReDrawgMap});
            this.cntxtgMap.Name = "cntxtgMap";
            this.cntxtgMap.Size = new System.Drawing.Size(204, 504);
            this.cntxtgMap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.cntxtgMap.MouseLeave += new System.EventHandler(this.cntxtgMap_MouseLeave);
            // 
            // ToolAddPOI
            // 
            this.ToolAddPOI.Name = "ToolAddPOI";
            this.ToolAddPOI.Size = new System.Drawing.Size(203, 22);
            this.ToolAddPOI.Text = "Add POI";
            this.ToolAddPOI.Click += new System.EventHandler(this.ToolAddPOI_Click);
            // 
            // ToolAddPath
            // 
            this.ToolAddPath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddManualPath,
            this.addCircularPathToolStripMenuItem,
            this.addHelicalPathToolStripMenuItem,
            this.addManualPathToolStripMenuItem,
            this.addPolygonGridPathToolStripMenuItem,
            this.ToolAddKMLPath,
            this.ToolAddPolyPerimPath});
            this.ToolAddPath.Name = "ToolAddPath";
            this.ToolAddPath.Size = new System.Drawing.Size(203, 22);
            this.ToolAddPath.Text = "Add Path";
            // 
            // toolAddManualPath
            // 
            this.toolAddManualPath.Name = "toolAddManualPath";
            this.toolAddManualPath.Size = new System.Drawing.Size(208, 22);
            this.toolAddManualPath.Text = "Add Manual Path";
            this.toolAddManualPath.Click += new System.EventHandler(this.toolAddManualPath_Click);
            // 
            // addCircularPathToolStripMenuItem
            // 
            this.addCircularPathToolStripMenuItem.Name = "addCircularPathToolStripMenuItem";
            this.addCircularPathToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addCircularPathToolStripMenuItem.Text = "Add Circular Path";
            this.addCircularPathToolStripMenuItem.Click += new System.EventHandler(this.addCircularPathToolStripMenuItem_Click);
            // 
            // addHelicalPathToolStripMenuItem
            // 
            this.addHelicalPathToolStripMenuItem.Name = "addHelicalPathToolStripMenuItem";
            this.addHelicalPathToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addHelicalPathToolStripMenuItem.Text = "Add Helical Path";
            this.addHelicalPathToolStripMenuItem.Click += new System.EventHandler(this.addHelicalPathToolStripMenuItem_Click);
            // 
            // addManualPathToolStripMenuItem
            // 
            this.addManualPathToolStripMenuItem.Name = "addManualPathToolStripMenuItem";
            this.addManualPathToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addManualPathToolStripMenuItem.Text = "Add Rectangular Path";
            this.addManualPathToolStripMenuItem.Click += new System.EventHandler(this.addManualPathToolStripMenuItem_Click);
            // 
            // addPolygonGridPathToolStripMenuItem
            // 
            this.addPolygonGridPathToolStripMenuItem.Name = "addPolygonGridPathToolStripMenuItem";
            this.addPolygonGridPathToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addPolygonGridPathToolStripMenuItem.Text = "Add Polygon Grid Path";
            this.addPolygonGridPathToolStripMenuItem.Click += new System.EventHandler(this.addPolygonGridPathToolStripMenuItem_Click);
            // 
            // ToolAddKMLPath
            // 
            this.ToolAddKMLPath.Name = "ToolAddKMLPath";
            this.ToolAddKMLPath.Size = new System.Drawing.Size(208, 22);
            this.ToolAddKMLPath.Text = "Add KML Path";
            this.ToolAddKMLPath.Click += new System.EventHandler(this.ToolAddKMLPath_Click);
            // 
            // ToolAddPolyPerimPath
            // 
            this.ToolAddPolyPerimPath.Name = "ToolAddPolyPerimPath";
            this.ToolAddPolyPerimPath.Size = new System.Drawing.Size(208, 22);
            this.ToolAddPolyPerimPath.Text = "Add Polygon Perimeter Path";
            this.ToolAddPolyPerimPath.Click += new System.EventHandler(this.ToolAddPolyPerimPath_Click);
            // 
            // toolAddPoly
            // 
            this.toolAddPoly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kMLPolygonToolStripMenuItem});
            this.toolAddPoly.Name = "toolAddPoly";
            this.toolAddPoly.Size = new System.Drawing.Size(203, 22);
            this.toolAddPoly.Text = "Add Polygon";
            // 
            // kMLPolygonToolStripMenuItem
            // 
            this.kMLPolygonToolStripMenuItem.Name = "kMLPolygonToolStripMenuItem";
            this.kMLPolygonToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kMLPolygonToolStripMenuItem.Text = "KML Polygon";
            this.kMLPolygonToolStripMenuItem.Click += new System.EventHandler(this.kMLPolygonToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedPOIToolStripMenuItem,
            this.selectedPathToolStripMenuItem,
            this.selectedPolygonToolStripMenuItem,
            this.selectedWaypointToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem5.Text = "Edit Attributes";
            // 
            // selectedPOIToolStripMenuItem
            // 
            this.selectedPOIToolStripMenuItem.Name = "selectedPOIToolStripMenuItem";
            this.selectedPOIToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedPOIToolStripMenuItem.Text = "Selected POI";
            this.selectedPOIToolStripMenuItem.Click += new System.EventHandler(this.selectedPOIToolStripMenuItem_Click);
            // 
            // selectedPathToolStripMenuItem
            // 
            this.selectedPathToolStripMenuItem.Name = "selectedPathToolStripMenuItem";
            this.selectedPathToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedPathToolStripMenuItem.Text = "Selected Path";
            this.selectedPathToolStripMenuItem.Click += new System.EventHandler(this.selectedPathToolStripMenuItem_Click);
            // 
            // selectedPolygonToolStripMenuItem
            // 
            this.selectedPolygonToolStripMenuItem.Name = "selectedPolygonToolStripMenuItem";
            this.selectedPolygonToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedPolygonToolStripMenuItem.Text = "Selected Polygon";
            this.selectedPolygonToolStripMenuItem.Click += new System.EventHandler(this.selectedPolygonToolStripMenuItem_Click);
            // 
            // selectedWaypointToolStripMenuItem
            // 
            this.selectedWaypointToolStripMenuItem.Name = "selectedWaypointToolStripMenuItem";
            this.selectedWaypointToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedWaypointToolStripMenuItem.Text = "Selected Waypoint";
            this.selectedWaypointToolStripMenuItem.Click += new System.EventHandler(this.selectedWaypointToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // toolInsertWP
            // 
            this.toolInsertWP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolInsertWPBefore,
            this.ToolInsertWPAfter});
            this.toolInsertWP.Name = "toolInsertWP";
            this.toolInsertWP.Size = new System.Drawing.Size(203, 22);
            this.toolInsertWP.Text = "Insert Waypoint";
            // 
            // ToolInsertWPBefore
            // 
            this.ToolInsertWPBefore.Name = "ToolInsertWPBefore";
            this.ToolInsertWPBefore.Size = new System.Drawing.Size(199, 22);
            this.ToolInsertWPBefore.Text = "Before Selected Waypoint";
            this.ToolInsertWPBefore.Click += new System.EventHandler(this.ToolInsertWPBefore_Click);
            // 
            // ToolInsertWPAfter
            // 
            this.ToolInsertWPAfter.Name = "ToolInsertWPAfter";
            this.ToolInsertWPAfter.Size = new System.Drawing.Size(199, 22);
            this.ToolInsertWPAfter.Text = "After Selected Waypoint";
            this.ToolInsertWPAfter.Click += new System.EventHandler(this.ToolInsertWPAfter_Click);
            // 
            // toolJoinPaths
            // 
            this.toolJoinPaths.Name = "toolJoinPaths";
            this.toolJoinPaths.Size = new System.Drawing.Size(203, 22);
            this.toolJoinPaths.Text = "Join Paths";
            this.toolJoinPaths.Click += new System.EventHandler(this.toolJoinPaths_Click);
            // 
            // toolSplitatWP
            // 
            this.toolSplitatWP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSplitBefore,
            this.ToolSplitAfter});
            this.toolSplitatWP.Name = "toolSplitatWP";
            this.toolSplitatWP.Size = new System.Drawing.Size(203, 22);
            this.toolSplitatWP.Text = "Split Path";
            // 
            // ToolSplitBefore
            // 
            this.ToolSplitBefore.Name = "ToolSplitBefore";
            this.ToolSplitBefore.Size = new System.Drawing.Size(199, 22);
            this.ToolSplitBefore.Text = "Before Selected Waypoint";
            this.ToolSplitBefore.Click += new System.EventHandler(this.ToolSplitBefore_Click);
            // 
            // ToolSplitAfter
            // 
            this.ToolSplitAfter.Name = "ToolSplitAfter";
            this.ToolSplitAfter.Size = new System.Drawing.Size(199, 22);
            this.ToolSplitAfter.Text = "After Selected Waypoint";
            this.ToolSplitAfter.Click += new System.EventHandler(this.ToolSplitAfter_Click);
            // 
            // toolReversePath
            // 
            this.toolReversePath.Name = "toolReversePath";
            this.toolReversePath.Size = new System.Drawing.Size(203, 22);
            this.toolReversePath.Text = "Reverse Path";
            this.toolReversePath.Click += new System.EventHandler(this.toolReversePath_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(200, 6);
            // 
            // toolUnselectAll
            // 
            this.toolUnselectAll.Name = "toolUnselectAll";
            this.toolUnselectAll.Size = new System.Drawing.Size(203, 22);
            this.toolUnselectAll.Text = "Unselect All";
            this.toolUnselectAll.Click += new System.EventHandler(this.toolUnselectAll_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem6.Text = "Delete Seleted POI";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.deleteSelectedPathsToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem3.Text = "Delete Selected Path";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.allToolStripMenuItem.Text = "Delete All Paths";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // deleteSelectedPathsToolStripMenuItem
            // 
            this.deleteSelectedPathsToolStripMenuItem.Name = "deleteSelectedPathsToolStripMenuItem";
            this.deleteSelectedPathsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteSelectedPathsToolStripMenuItem.Text = "Delete Selected Paths";
            this.deleteSelectedPathsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedPathsToolStripMenuItem_Click);
            // 
            // toolDeleteWP
            // 
            this.toolDeleteWP.Name = "toolDeleteWP";
            this.toolDeleteWP.Size = new System.Drawing.Size(203, 22);
            this.toolDeleteWP.Text = "Delete Selected Waypoints";
            this.toolDeleteWP.Click += new System.EventHandler(this.toolDeleteWP_Click);
            // 
            // toolDeleteShape
            // 
            this.toolDeleteShape.Name = "toolDeleteShape";
            this.toolDeleteShape.Size = new System.Drawing.Size(203, 22);
            this.toolDeleteShape.Text = "Delete Selected Polygons";
            this.toolDeleteShape.Click += new System.EventHandler(this.toolDeleteShape_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // POI
            // 
            this.POI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAllPOIShow,
            this.ToolAllPOIHide});
            this.POI.Name = "POI";
            this.POI.Size = new System.Drawing.Size(203, 22);
            this.POI.Text = "POI Visibility";
            // 
            // ToolAllPOIShow
            // 
            this.ToolAllPOIShow.Margin = new System.Windows.Forms.Padding(-1, 0, 0, 0);
            this.ToolAllPOIShow.Name = "ToolAllPOIShow";
            this.ToolAllPOIShow.Size = new System.Drawing.Size(122, 22);
            this.ToolAllPOIShow.Text = "UnHide All";
            this.ToolAllPOIShow.Click += new System.EventHandler(this.ToolAllPOIShow_Click);
            // 
            // ToolAllPOIHide
            // 
            this.ToolAllPOIHide.Name = "ToolAllPOIHide";
            this.ToolAllPOIHide.Size = new System.Drawing.Size(122, 22);
            this.ToolAllPOIHide.Text = "Hide All";
            this.ToolAllPOIHide.Click += new System.EventHandler(this.ToolAllPOIHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAllPathShow,
            this.ToolAllPathHide});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem2.Text = "Path Visibility";
            // 
            // ToolAllPathShow
            // 
            this.ToolAllPathShow.Name = "ToolAllPathShow";
            this.ToolAllPathShow.Size = new System.Drawing.Size(121, 22);
            this.ToolAllPathShow.Text = "Unhide All";
            this.ToolAllPathShow.Click += new System.EventHandler(this.ToolAllPathShow_Click);
            // 
            // ToolAllPathHide
            // 
            this.ToolAllPathHide.Name = "ToolAllPathHide";
            this.ToolAllPathHide.Size = new System.Drawing.Size(121, 22);
            this.ToolAllPathHide.Text = "Hide All";
            this.ToolAllPathHide.Click += new System.EventHandler(this.ToolAllPathHide_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unHideAllPolygon,
            this.hideAllPolygon});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem4.Text = "Polygon Visibility";
            // 
            // unHideAllPolygon
            // 
            this.unHideAllPolygon.Name = "unHideAllPolygon";
            this.unHideAllPolygon.Size = new System.Drawing.Size(122, 22);
            this.unHideAllPolygon.Text = "UnHide All";
            this.unHideAllPolygon.Click += new System.EventHandler(this.unHideAllPolygon_Click);
            // 
            // hideAllPolygon
            // 
            this.hideAllPolygon.Name = "hideAllPolygon";
            this.hideAllPolygon.Size = new System.Drawing.Size(122, 22);
            this.hideAllPolygon.Text = "Hide All";
            this.hideAllPolygon.Click += new System.EventHandler(this.hideAllPolygon_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedPOIToolStripMenuItem1,
            this.selectedPathToolStripMenuItem1,
            this.selectedWaypointToolStripMenuItem1,
            this.selectedPolygonToolStripMenuItem1});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem7.Text = "Properties";
            // 
            // selectedPOIToolStripMenuItem1
            // 
            this.selectedPOIToolStripMenuItem1.Name = "selectedPOIToolStripMenuItem1";
            this.selectedPOIToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectedPOIToolStripMenuItem1.Text = "Selected POI";
            this.selectedPOIToolStripMenuItem1.Click += new System.EventHandler(this.selectedPOIToolStripMenuItem1_Click);
            // 
            // selectedPathToolStripMenuItem1
            // 
            this.selectedPathToolStripMenuItem1.Name = "selectedPathToolStripMenuItem1";
            this.selectedPathToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectedPathToolStripMenuItem1.Text = "Selected Path";
            this.selectedPathToolStripMenuItem1.Click += new System.EventHandler(this.selectedPathToolStripMenuItem1_Click);
            // 
            // selectedWaypointToolStripMenuItem1
            // 
            this.selectedWaypointToolStripMenuItem1.Name = "selectedWaypointToolStripMenuItem1";
            this.selectedWaypointToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectedWaypointToolStripMenuItem1.Text = "Selected Waypoint";
            this.selectedWaypointToolStripMenuItem1.Click += new System.EventHandler(this.selectedWaypointToolStripMenuItem1_Click);
            // 
            // selectedPolygonToolStripMenuItem1
            // 
            this.selectedPolygonToolStripMenuItem1.Name = "selectedPolygonToolStripMenuItem1";
            this.selectedPolygonToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.selectedPolygonToolStripMenuItem1.Text = "Selected Polygon";
            this.selectedPolygonToolStripMenuItem1.Click += new System.EventHandler(this.selectedPolygonToolStripMenuItem1_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(200, 6);
            // 
            // toolOutputPath
            // 
            this.toolOutputPath.Name = "toolOutputPath";
            this.toolOutputPath.Size = new System.Drawing.Size(203, 22);
            this.toolOutputPath.Text = "Output Selected Path";
            this.toolOutputPath.Click += new System.EventHandler(this.toolOutputPath_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(200, 6);
            // 
            // toolToggleCenter
            // 
            this.toolToggleCenter.Name = "toolToggleCenter";
            this.toolToggleCenter.Size = new System.Drawing.Size(203, 22);
            this.toolToggleCenter.Text = "Toggle Map Center";
            this.toolToggleCenter.Click += new System.EventHandler(this.toolToggleCenter_Click);
            // 
            // toolReDrawgMap
            // 
            this.toolReDrawgMap.Name = "toolReDrawgMap";
            this.toolReDrawgMap.Size = new System.Drawing.Size(203, 22);
            this.toolReDrawgMap.Text = "Redraw Map";
            this.toolReDrawgMap.Click += new System.EventHandler(this.toolReDrawgMap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(229, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(379, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "Waypoint Path Generator";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadStartXMLToolStripMenuItem,
            this.saveXMLToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolAbout,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // reloadStartXMLToolStripMenuItem
            // 
            this.reloadStartXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupXMLToolStripMenuItem,
            this.browseXMLToolStripMenuItem});
            this.reloadStartXMLToolStripMenuItem.Name = "reloadStartXMLToolStripMenuItem";
            this.reloadStartXMLToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.reloadStartXMLToolStripMenuItem.Text = "Open XML";
            // 
            // startupXMLToolStripMenuItem
            // 
            this.startupXMLToolStripMenuItem.Name = "startupXMLToolStripMenuItem";
            this.startupXMLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startupXMLToolStripMenuItem.Text = "Startup XML";
            this.startupXMLToolStripMenuItem.Click += new System.EventHandler(this.startupXMLToolStripMenuItem_Click);
            // 
            // browseXMLToolStripMenuItem
            // 
            this.browseXMLToolStripMenuItem.Name = "browseXMLToolStripMenuItem";
            this.browseXMLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.browseXMLToolStripMenuItem.Text = "Browse XML";
            this.browseXMLToolStripMenuItem.Click += new System.EventHandler(this.browseXMLToolStripMenuItem_Click);
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.saveXMLToolStripMenuItem.Text = "Save XML";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitsToolStripMenuItem,
            this.cameraToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imperialToolStripMenuItem,
            this.metricToolStripMenuItem});
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.unitsToolStripMenuItem.Text = "Units";
            // 
            // imperialToolStripMenuItem
            // 
            this.imperialToolStripMenuItem.Name = "imperialToolStripMenuItem";
            this.imperialToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.imperialToolStripMenuItem.Text = "Imperial";
            this.imperialToolStripMenuItem.Click += new System.EventHandler(this.imperialToolStripMenuItem_Click);
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.metricToolStripMenuItem.Text = "Metric";
            this.metricToolStripMenuItem.Click += new System.EventHandler(this.metricToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(229, 22);
            this.toolAbout.Text = "About Waypoint Path Generator";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // tabGMap
            // 
            this.tabGMap.Controls.Add(this.gMapControl);
            this.tabGMap.Controls.Add(this.trkMapScale);
            this.tabGMap.Controls.Add(this.label5);
            this.tabGMap.Controls.Add(this.label4);
            this.tabGMap.Controls.Add(this.label3);
            this.tabGMap.Controls.Add(this.txtMouseLon);
            this.tabGMap.Controls.Add(this.txtMouseLat);
            this.tabGMap.Controls.Add(this.btngMapRedraw);
            this.tabGMap.Controls.Add(this.treGMap);
            this.tabGMap.Controls.Add(this.label109);
            this.tabGMap.Controls.Add(this.cmbGMapProvider);
            this.tabGMap.Location = new System.Drawing.Point(4, 25);
            this.tabGMap.Name = "tabGMap";
            this.tabGMap.Size = new System.Drawing.Size(852, 902);
            this.tabGMap.TabIndex = 16;
            this.tabGMap.Text = "Path Preview";
            this.tabGMap.UseVisualStyleBackColor = true;
            this.tabGMap.Click += new System.EventHandler(this.tabGMap_Click);
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.AutoSize = true;
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.ContextMenuStrip = this.cntxtgMap;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(140, 97);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 18;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(680, 647);
            this.gMapControl.TabIndex = 14;
            this.gMapControl.Zoom = 13D;
            this.gMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            this.gMapControl.OnPolygonClick += new GMap.NET.WindowsForms.PolygonClick(this.gMap_OnPolygonClick);
            this.gMapControl.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gMap_OnRouteClick);
            this.gMapControl.OnMapDrag += new GMap.NET.MapDrag(this.gMap_OnMapDrag);
            this.gMapControl.Load += new System.EventHandler(this.gMap_Load);
            this.gMapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseClick);
            this.gMapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDoubleClick);
            this.gMapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            this.gMapControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseUp);
            // 
            // trkMapScale
            // 
            this.trkMapScale.Location = new System.Drawing.Point(560, 58);
            this.trkMapScale.Maximum = 24;
            this.trkMapScale.Minimum = 1;
            this.trkMapScale.Name = "trkMapScale";
            this.trkMapScale.Size = new System.Drawing.Size(104, 42);
            this.trkMapScale.TabIndex = 35;
            this.trkMapScale.Value = 10;
            this.trkMapScale.Scroll += new System.EventHandler(this.trkMapScale_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Scale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Longitude";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Latitude";
            // 
            // txtMouseLon
            // 
            this.txtMouseLon.Location = new System.Drawing.Point(394, 58);
            this.txtMouseLon.Name = "txtMouseLon";
            this.txtMouseLon.Size = new System.Drawing.Size(100, 22);
            this.txtMouseLon.TabIndex = 26;
            this.txtMouseLon.Text = "0.0";
            this.txtMouseLon.TextChanged += new System.EventHandler(this.txtMouseLon_TextChanged);
            // 
            // txtMouseLat
            // 
            this.txtMouseLat.Location = new System.Drawing.Point(205, 58);
            this.txtMouseLat.Name = "txtMouseLat";
            this.txtMouseLat.Size = new System.Drawing.Size(100, 22);
            this.txtMouseLat.TabIndex = 25;
            this.txtMouseLat.Text = "0.0";
            // 
            // btngMapRedraw
            // 
            this.btngMapRedraw.Location = new System.Drawing.Point(586, 17);
            this.btngMapRedraw.Name = "btngMapRedraw";
            this.btngMapRedraw.Size = new System.Drawing.Size(137, 23);
            this.btngMapRedraw.TabIndex = 27;
            this.btngMapRedraw.Text = "Redraw Map";
            this.btngMapRedraw.UseVisualStyleBackColor = true;
            this.btngMapRedraw.Click += new System.EventHandler(this.btngMapRedraw_Click);
            // 
            // treGMap
            // 
            this.treGMap.CheckBoxes = true;
            this.treGMap.Location = new System.Drawing.Point(8, 97);
            this.treGMap.Name = "treGMap";
            treeNode1.Name = "POI";
            treeNode1.Text = "POI";
            treeNode2.Name = "Paths";
            treeNode2.Text = "Paths";
            treeNode3.Name = "Polygons";
            treeNode3.Text = "Polygons";
            treeNode4.Name = "GMap";
            treeNode4.Text = "Objects";
            this.treGMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treGMap.Size = new System.Drawing.Size(121, 281);
            this.treGMap.TabIndex = 24;
            this.treGMap.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treGMap_AfterCheck);
            this.treGMap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treGMap_AfterSelect);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(235, 20);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(89, 16);
            this.label109.TabIndex = 16;
            this.label109.Text = "Map Provider";
            // 
            // cmbGMapProvider
            // 
            this.cmbGMapProvider.FormattingEnabled = true;
            this.cmbGMapProvider.Items.AddRange(new object[] {
            "Bing Satellite",
            "Google Map",
            "Google Terrain",
            "Google Hybrid",
            "Google China Satellite",
            "ArcGIS Topological",
            "YahooSatellite"});
            this.cmbGMapProvider.Location = new System.Drawing.Point(341, 17);
            this.cmbGMapProvider.Name = "cmbGMapProvider";
            this.cmbGMapProvider.Size = new System.Drawing.Size(215, 24);
            this.cmbGMapProvider.TabIndex = 15;
            this.cmbGMapProvider.Text = "Bing Satellite";
            this.cmbGMapProvider.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabWayActions
            // 
            this.tabWayActions.Controls.Add(this.btnCreatePOIWP);
            this.tabWayActions.Controls.Add(this.label101);
            this.tabWayActions.Controls.Add(this.txtPOIWPName);
            this.tabWayActions.Controls.Add(this.txtPOIWP);
            this.tabWayActions.Controls.Add(this.txtWPEnd);
            this.tabWayActions.Controls.Add(this.txtWPStart);
            this.tabWayActions.Controls.Add(this.label100);
            this.tabWayActions.Controls.Add(this.label99);
            this.tabWayActions.Controls.Add(this.label98);
            this.tabWayActions.Controls.Add(this.btnApplyAction);
            this.tabWayActions.Controls.Add(this.label74);
            this.tabWayActions.Controls.Add(this.label73);
            this.tabWayActions.Controls.Add(this.label72);
            this.tabWayActions.Controls.Add(this.cmbActionsWaypoints);
            this.tabWayActions.Controls.Add(this.dgvActionsWaypoints);
            this.tabWayActions.Controls.Add(this.label49);
            this.tabWayActions.Controls.Add(this.label50);
            this.tabWayActions.Controls.Add(this.dgvActionsPath);
            this.tabWayActions.Location = new System.Drawing.Point(4, 25);
            this.tabWayActions.Name = "tabWayActions";
            this.tabWayActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabWayActions.Size = new System.Drawing.Size(852, 902);
            this.tabWayActions.TabIndex = 8;
            this.tabWayActions.Text = "Edit Segment Waypoints";
            this.tabWayActions.UseVisualStyleBackColor = true;
            this.tabWayActions.Click += new System.EventHandler(this.tabActions_Click);
            // 
            // btnCreatePOIWP
            // 
            this.btnCreatePOIWP.Location = new System.Drawing.Point(311, 705);
            this.btnCreatePOIWP.Name = "btnCreatePOIWP";
            this.btnCreatePOIWP.Size = new System.Drawing.Size(160, 23);
            this.btnCreatePOIWP.TabIndex = 30;
            this.btnCreatePOIWP.Text = "Create POI";
            this.btnCreatePOIWP.UseVisualStyleBackColor = true;
            this.btnCreatePOIWP.Click += new System.EventHandler(this.btnCreatePOIWP_Click);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(307, 668);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(70, 16);
            this.label101.TabIndex = 29;
            this.label101.Text = "POI Name";
            // 
            // txtPOIWPName
            // 
            this.txtPOIWPName.Location = new System.Drawing.Point(383, 665);
            this.txtPOIWPName.Name = "txtPOIWPName";
            this.txtPOIWPName.Size = new System.Drawing.Size(100, 22);
            this.txtPOIWPName.TabIndex = 28;
            // 
            // txtPOIWP
            // 
            this.txtPOIWP.Location = new System.Drawing.Point(383, 625);
            this.txtPOIWP.Name = "txtPOIWP";
            this.txtPOIWP.Size = new System.Drawing.Size(100, 22);
            this.txtPOIWP.TabIndex = 26;
            // 
            // txtWPEnd
            // 
            this.txtWPEnd.Location = new System.Drawing.Point(562, 545);
            this.txtWPEnd.Name = "txtWPEnd";
            this.txtWPEnd.Size = new System.Drawing.Size(100, 22);
            this.txtWPEnd.TabIndex = 21;
            this.txtWPEnd.Text = "0";
            this.txtWPEnd.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            this.txtWPEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInteger_KeyPress);
            // 
            // txtWPStart
            // 
            this.txtWPStart.Location = new System.Drawing.Point(383, 545);
            this.txtWPStart.Name = "txtWPStart";
            this.txtWPStart.Size = new System.Drawing.Size(100, 22);
            this.txtWPStart.TabIndex = 20;
            this.txtWPStart.Text = "0";
            this.txtWPStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textInteger_KeyPress);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(307, 628);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(65, 16);
            this.label100.TabIndex = 27;
            this.label100.Text = "Waypoint";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(294, 589);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(218, 20);
            this.label99.TabIndex = 25;
            this.label99.Text = "Create POI from Waypoint";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(294, 499);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(227, 20);
            this.label98.TabIndex = 24;
            this.label98.Text = "Apply Actions to Waypoints";
            // 
            // btnApplyAction
            // 
            this.btnApplyAction.Location = new System.Drawing.Point(697, 546);
            this.btnApplyAction.Name = "btnApplyAction";
            this.btnApplyAction.Size = new System.Drawing.Size(75, 23);
            this.btnApplyAction.TabIndex = 23;
            this.btnApplyAction.Text = "Apply";
            this.btnApplyAction.UseVisualStyleBackColor = true;
            this.btnApplyAction.Click += new System.EventHandler(this.btnApplyAction_Click);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(493, 551);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(57, 16);
            this.label74.TabIndex = 22;
            this.label74.Text = "End WP";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(317, 548);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(60, 16);
            this.label73.TabIndex = 19;
            this.label73.Text = "Start WP";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(56, 547);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(83, 16);
            this.label72.TabIndex = 18;
            this.label72.Text = "Apply Action";
            // 
            // cmbActionsWaypoints
            // 
            this.cmbActionsWaypoints.FormattingEnabled = true;
            this.cmbActionsWaypoints.Location = new System.Drawing.Point(143, 545);
            this.cmbActionsWaypoints.Name = "cmbActionsWaypoints";
            this.cmbActionsWaypoints.Size = new System.Drawing.Size(170, 24);
            this.cmbActionsWaypoints.TabIndex = 17;
            this.cmbActionsWaypoints.SelectedIndexChanged += new System.EventHandler(this.cmbActionsWaypoints_SelectedIndexChanged);
            // 
            // dgvActionsWaypoints
            // 
            this.dgvActionsWaypoints.AllowDrop = true;
            this.dgvActionsWaypoints.AllowUserToAddRows = false;
            this.dgvActionsWaypoints.AllowUserToResizeRows = false;
            this.dgvActionsWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionsWaypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgvActionsWaypoints.Location = new System.Drawing.Point(36, 208);
            this.dgvActionsWaypoints.Name = "dgvActionsWaypoints";
            this.dgvActionsWaypoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvActionsWaypoints.Size = new System.Drawing.Size(746, 249);
            this.dgvActionsWaypoints.TabIndex = 16;
            this.dgvActionsWaypoints.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvActionsWaypoints_CellValidating);
            this.dgvActionsWaypoints.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWayActionsPath_CellValueChanged);
            this.dgvActionsWaypoints.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvActionsWaypoints_RowsRemoved);
            this.dgvActionsWaypoints.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvActionsWaypoints_MouseUp);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Waypoint";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Altitude";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Heading";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Curve Size";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Rotation Dir";
            this.Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Gimble Mode";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Gimble Pitch";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Action Type 1";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Action Param 1";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Action Type 2";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Action Param 2";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Action Type 3";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Action Param 3";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Action Type 4";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Action Param 4";
            this.Column17.Name = "Column17";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(306, 8);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(165, 24);
            this.label49.TabIndex = 15;
            this.label49.Text = "Generated Paths";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(333, 181);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(106, 24);
            this.label50.TabIndex = 14;
            this.label50.Text = "Waypoints";
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // dgvActionsPath
            // 
            this.dgvActionsPath.AllowUserToAddRows = false;
            this.dgvActionsPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionsPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvActionsPath.Location = new System.Drawing.Point(127, 35);
            this.dgvActionsPath.Name = "dgvActionsPath";
            this.dgvActionsPath.Size = new System.Drawing.Size(519, 127);
            this.dgvActionsPath.TabIndex = 12;
            this.dgvActionsPath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionsPath_CellClick);
            this.dgvActionsPath.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionsPath_CellValueChanged);
            this.dgvActionsPath.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvActionsPath_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Path";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "WP Count";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 73;
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.label71);
            this.tabActions.Controls.Add(this.btnSaveAction);
            this.tabActions.Controls.Add(this.btnDelectAction);
            this.tabActions.Controls.Add(this.btnClearActionsGUI);
            this.tabActions.Controls.Add(this.label70);
            this.tabActions.Controls.Add(this.txtNewActionName);
            this.tabActions.Controls.Add(this.txtActionParam12);
            this.tabActions.Controls.Add(this.txtActionParam13);
            this.tabActions.Controls.Add(this.txtActionParam14);
            this.tabActions.Controls.Add(this.txtActionParam15);
            this.tabActions.Controls.Add(this.txtActionParam11);
            this.tabActions.Controls.Add(this.txtActionParam7);
            this.tabActions.Controls.Add(this.txtActionParam8);
            this.tabActions.Controls.Add(this.txtActionParam9);
            this.tabActions.Controls.Add(this.txtActionParam10);
            this.tabActions.Controls.Add(this.txtActionParam6);
            this.tabActions.Controls.Add(this.txtActionParam2);
            this.tabActions.Controls.Add(this.txtActionParam3);
            this.tabActions.Controls.Add(this.txtActionParam4);
            this.tabActions.Controls.Add(this.txtActionParam5);
            this.tabActions.Controls.Add(this.txtActionParam1);
            this.tabActions.Controls.Add(this.cmbAction12);
            this.tabActions.Controls.Add(this.label65);
            this.tabActions.Controls.Add(this.cmbAction13);
            this.tabActions.Controls.Add(this.label66);
            this.tabActions.Controls.Add(this.cmbAction14);
            this.tabActions.Controls.Add(this.label67);
            this.tabActions.Controls.Add(this.cmbAction15);
            this.tabActions.Controls.Add(this.label68);
            this.tabActions.Controls.Add(this.cmbAction11);
            this.tabActions.Controls.Add(this.label69);
            this.tabActions.Controls.Add(this.cmbAction7);
            this.tabActions.Controls.Add(this.label56);
            this.tabActions.Controls.Add(this.cmbAction8);
            this.tabActions.Controls.Add(this.label61);
            this.tabActions.Controls.Add(this.cmbAction9);
            this.tabActions.Controls.Add(this.label62);
            this.tabActions.Controls.Add(this.cmbAction10);
            this.tabActions.Controls.Add(this.label63);
            this.tabActions.Controls.Add(this.cmbAction6);
            this.tabActions.Controls.Add(this.label64);
            this.tabActions.Controls.Add(this.cmbAction2);
            this.tabActions.Controls.Add(this.label60);
            this.tabActions.Controls.Add(this.cmbAction3);
            this.tabActions.Controls.Add(this.label59);
            this.tabActions.Controls.Add(this.cmbAction4);
            this.tabActions.Controls.Add(this.label58);
            this.tabActions.Controls.Add(this.cmbAction5);
            this.tabActions.Controls.Add(this.label57);
            this.tabActions.Controls.Add(this.cmbAction1);
            this.tabActions.Controls.Add(this.label55);
            this.tabActions.Controls.Add(this.cmbActionsList);
            this.tabActions.Location = new System.Drawing.Point(4, 25);
            this.tabActions.Name = "tabActions";
            this.tabActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabActions.Size = new System.Drawing.Size(852, 902);
            this.tabActions.TabIndex = 11;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(286, 21);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(112, 16);
            this.label71.TabIndex = 54;
            this.label71.Text = "Waypoint Actions";
            // 
            // btnSaveAction
            // 
            this.btnSaveAction.Location = new System.Drawing.Point(485, 347);
            this.btnSaveAction.Name = "btnSaveAction";
            this.btnSaveAction.Size = new System.Drawing.Size(159, 23);
            this.btnSaveAction.TabIndex = 53;
            this.btnSaveAction.Text = "Save Action";
            this.btnSaveAction.UseVisualStyleBackColor = true;
            this.btnSaveAction.Click += new System.EventHandler(this.btnSaveAction_Click);
            // 
            // btnDelectAction
            // 
            this.btnDelectAction.Location = new System.Drawing.Point(204, 347);
            this.btnDelectAction.Name = "btnDelectAction";
            this.btnDelectAction.Size = new System.Drawing.Size(198, 23);
            this.btnDelectAction.TabIndex = 52;
            this.btnDelectAction.Text = "Delete Action";
            this.btnDelectAction.UseVisualStyleBackColor = true;
            this.btnDelectAction.Click += new System.EventHandler(this.btnDelectAction_Click);
            // 
            // btnClearActionsGUI
            // 
            this.btnClearActionsGUI.Location = new System.Drawing.Point(338, 97);
            this.btnClearActionsGUI.Name = "btnClearActionsGUI";
            this.btnClearActionsGUI.Size = new System.Drawing.Size(178, 23);
            this.btnClearActionsGUI.TabIndex = 51;
            this.btnClearActionsGUI.Text = "Reset Actions";
            this.btnClearActionsGUI.UseVisualStyleBackColor = true;
            this.btnClearActionsGUI.Click += new System.EventHandler(this.btnClearActionsGUI_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(294, 146);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(85, 16);
            this.label70.TabIndex = 50;
            this.label70.Text = "Action Name";
            // 
            // txtNewActionName
            // 
            this.txtNewActionName.Location = new System.Drawing.Point(427, 143);
            this.txtNewActionName.Name = "txtNewActionName";
            this.txtNewActionName.Size = new System.Drawing.Size(239, 22);
            this.txtNewActionName.TabIndex = 49;
            // 
            // txtActionParam12
            // 
            this.txtActionParam12.Location = new System.Drawing.Point(737, 210);
            this.txtActionParam12.Name = "txtActionParam12";
            this.txtActionParam12.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam12.TabIndex = 48;
            // 
            // txtActionParam13
            // 
            this.txtActionParam13.Location = new System.Drawing.Point(737, 238);
            this.txtActionParam13.Name = "txtActionParam13";
            this.txtActionParam13.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam13.TabIndex = 45;
            // 
            // txtActionParam14
            // 
            this.txtActionParam14.Location = new System.Drawing.Point(737, 266);
            this.txtActionParam14.Name = "txtActionParam14";
            this.txtActionParam14.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam14.TabIndex = 42;
            this.txtActionParam14.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtActionParam15
            // 
            this.txtActionParam15.Location = new System.Drawing.Point(737, 297);
            this.txtActionParam15.Name = "txtActionParam15";
            this.txtActionParam15.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam15.TabIndex = 39;
            // 
            // txtActionParam11
            // 
            this.txtActionParam11.Location = new System.Drawing.Point(737, 182);
            this.txtActionParam11.Name = "txtActionParam11";
            this.txtActionParam11.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam11.TabIndex = 36;
            // 
            // txtActionParam7
            // 
            this.txtActionParam7.Location = new System.Drawing.Point(465, 210);
            this.txtActionParam7.Name = "txtActionParam7";
            this.txtActionParam7.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam7.TabIndex = 33;
            // 
            // txtActionParam8
            // 
            this.txtActionParam8.Location = new System.Drawing.Point(465, 238);
            this.txtActionParam8.Name = "txtActionParam8";
            this.txtActionParam8.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam8.TabIndex = 30;
            // 
            // txtActionParam9
            // 
            this.txtActionParam9.Location = new System.Drawing.Point(465, 266);
            this.txtActionParam9.Name = "txtActionParam9";
            this.txtActionParam9.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam9.TabIndex = 27;
            // 
            // txtActionParam10
            // 
            this.txtActionParam10.Location = new System.Drawing.Point(465, 297);
            this.txtActionParam10.Name = "txtActionParam10";
            this.txtActionParam10.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam10.TabIndex = 24;
            // 
            // txtActionParam6
            // 
            this.txtActionParam6.Location = new System.Drawing.Point(465, 182);
            this.txtActionParam6.Name = "txtActionParam6";
            this.txtActionParam6.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam6.TabIndex = 21;
            // 
            // txtActionParam2
            // 
            this.txtActionParam2.Location = new System.Drawing.Point(204, 210);
            this.txtActionParam2.Name = "txtActionParam2";
            this.txtActionParam2.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam2.TabIndex = 18;
            // 
            // txtActionParam3
            // 
            this.txtActionParam3.Location = new System.Drawing.Point(204, 238);
            this.txtActionParam3.Name = "txtActionParam3";
            this.txtActionParam3.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam3.TabIndex = 15;
            // 
            // txtActionParam4
            // 
            this.txtActionParam4.Location = new System.Drawing.Point(204, 266);
            this.txtActionParam4.Name = "txtActionParam4";
            this.txtActionParam4.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam4.TabIndex = 12;
            // 
            // txtActionParam5
            // 
            this.txtActionParam5.Location = new System.Drawing.Point(204, 297);
            this.txtActionParam5.Name = "txtActionParam5";
            this.txtActionParam5.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam5.TabIndex = 9;
            // 
            // txtActionParam1
            // 
            this.txtActionParam1.Location = new System.Drawing.Point(204, 182);
            this.txtActionParam1.Name = "txtActionParam1";
            this.txtActionParam1.Size = new System.Drawing.Size(63, 22);
            this.txtActionParam1.TabIndex = 3;
            // 
            // cmbAction12
            // 
            this.cmbAction12.FormattingEnabled = true;
            this.cmbAction12.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction12.Location = new System.Drawing.Point(610, 210);
            this.cmbAction12.Name = "cmbAction12";
            this.cmbAction12.Size = new System.Drawing.Size(121, 24);
            this.cmbAction12.TabIndex = 47;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(549, 213);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(62, 16);
            this.label65.TabIndex = 46;
            this.label65.Text = "Action 12";
            // 
            // cmbAction13
            // 
            this.cmbAction13.FormattingEnabled = true;
            this.cmbAction13.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction13.Location = new System.Drawing.Point(610, 238);
            this.cmbAction13.Name = "cmbAction13";
            this.cmbAction13.Size = new System.Drawing.Size(121, 24);
            this.cmbAction13.TabIndex = 44;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(549, 241);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(62, 16);
            this.label66.TabIndex = 43;
            this.label66.Text = "Action 13";
            // 
            // cmbAction14
            // 
            this.cmbAction14.FormattingEnabled = true;
            this.cmbAction14.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction14.Location = new System.Drawing.Point(610, 266);
            this.cmbAction14.Name = "cmbAction14";
            this.cmbAction14.Size = new System.Drawing.Size(121, 24);
            this.cmbAction14.TabIndex = 41;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(549, 269);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(62, 16);
            this.label67.TabIndex = 40;
            this.label67.Text = "Action 14";
            // 
            // cmbAction15
            // 
            this.cmbAction15.FormattingEnabled = true;
            this.cmbAction15.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction15.Location = new System.Drawing.Point(610, 297);
            this.cmbAction15.Name = "cmbAction15";
            this.cmbAction15.Size = new System.Drawing.Size(121, 24);
            this.cmbAction15.TabIndex = 38;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(549, 300);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(62, 16);
            this.label68.TabIndex = 37;
            this.label68.Text = "Action 15";
            // 
            // cmbAction11
            // 
            this.cmbAction11.FormattingEnabled = true;
            this.cmbAction11.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction11.Location = new System.Drawing.Point(610, 182);
            this.cmbAction11.Name = "cmbAction11";
            this.cmbAction11.Size = new System.Drawing.Size(121, 24);
            this.cmbAction11.TabIndex = 35;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(549, 185);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(62, 16);
            this.label69.TabIndex = 34;
            this.label69.Text = "Action 11";
            // 
            // cmbAction7
            // 
            this.cmbAction7.FormattingEnabled = true;
            this.cmbAction7.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction7.Location = new System.Drawing.Point(338, 210);
            this.cmbAction7.Name = "cmbAction7";
            this.cmbAction7.Size = new System.Drawing.Size(121, 24);
            this.cmbAction7.TabIndex = 32;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(277, 213);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(55, 16);
            this.label56.TabIndex = 31;
            this.label56.Text = "Action 7";
            // 
            // cmbAction8
            // 
            this.cmbAction8.FormattingEnabled = true;
            this.cmbAction8.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction8.Location = new System.Drawing.Point(338, 238);
            this.cmbAction8.Name = "cmbAction8";
            this.cmbAction8.Size = new System.Drawing.Size(121, 24);
            this.cmbAction8.TabIndex = 29;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(277, 241);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(55, 16);
            this.label61.TabIndex = 28;
            this.label61.Text = "Action 8";
            // 
            // cmbAction9
            // 
            this.cmbAction9.FormattingEnabled = true;
            this.cmbAction9.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction9.Location = new System.Drawing.Point(338, 266);
            this.cmbAction9.Name = "cmbAction9";
            this.cmbAction9.Size = new System.Drawing.Size(121, 24);
            this.cmbAction9.TabIndex = 26;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(277, 269);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(55, 16);
            this.label62.TabIndex = 25;
            this.label62.Text = "Action 9";
            // 
            // cmbAction10
            // 
            this.cmbAction10.FormattingEnabled = true;
            this.cmbAction10.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction10.Location = new System.Drawing.Point(338, 297);
            this.cmbAction10.Name = "cmbAction10";
            this.cmbAction10.Size = new System.Drawing.Size(121, 24);
            this.cmbAction10.TabIndex = 23;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(277, 300);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(62, 16);
            this.label63.TabIndex = 22;
            this.label63.Text = "Action 10";
            // 
            // cmbAction6
            // 
            this.cmbAction6.FormattingEnabled = true;
            this.cmbAction6.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction6.Location = new System.Drawing.Point(338, 182);
            this.cmbAction6.Name = "cmbAction6";
            this.cmbAction6.Size = new System.Drawing.Size(121, 24);
            this.cmbAction6.TabIndex = 20;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(277, 185);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(55, 16);
            this.label64.TabIndex = 19;
            this.label64.Text = "Action 6";
            // 
            // cmbAction2
            // 
            this.cmbAction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction2.FormattingEnabled = true;
            this.cmbAction2.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction2.Location = new System.Drawing.Point(77, 210);
            this.cmbAction2.Name = "cmbAction2";
            this.cmbAction2.Size = new System.Drawing.Size(121, 24);
            this.cmbAction2.TabIndex = 17;
            this.cmbAction2.SelectedIndexChanged += new System.EventHandler(this.cmbAction2_SelectedIndexChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(16, 213);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(55, 16);
            this.label60.TabIndex = 16;
            this.label60.Text = "Action 2";
            // 
            // cmbAction3
            // 
            this.cmbAction3.FormattingEnabled = true;
            this.cmbAction3.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction3.Location = new System.Drawing.Point(77, 238);
            this.cmbAction3.Name = "cmbAction3";
            this.cmbAction3.Size = new System.Drawing.Size(121, 24);
            this.cmbAction3.TabIndex = 14;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(16, 241);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(55, 16);
            this.label59.TabIndex = 13;
            this.label59.Text = "Action 3";
            // 
            // cmbAction4
            // 
            this.cmbAction4.FormattingEnabled = true;
            this.cmbAction4.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction4.Location = new System.Drawing.Point(77, 266);
            this.cmbAction4.Name = "cmbAction4";
            this.cmbAction4.Size = new System.Drawing.Size(121, 24);
            this.cmbAction4.TabIndex = 11;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(16, 269);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(55, 16);
            this.label58.TabIndex = 10;
            this.label58.Text = "Action 4";
            // 
            // cmbAction5
            // 
            this.cmbAction5.FormattingEnabled = true;
            this.cmbAction5.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction5.Location = new System.Drawing.Point(77, 297);
            this.cmbAction5.Name = "cmbAction5";
            this.cmbAction5.Size = new System.Drawing.Size(121, 24);
            this.cmbAction5.TabIndex = 8;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(16, 300);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(55, 16);
            this.label57.TabIndex = 7;
            this.label57.Text = "Action 5";
            // 
            // cmbAction1
            // 
            this.cmbAction1.DisplayMember = "None";
            this.cmbAction1.FormattingEnabled = true;
            this.cmbAction1.Items.AddRange(new object[] {
            "None",
            "Stay For",
            "Take Photo",
            "Start Recoding",
            "Stop Recording",
            "Rotate Aircraft",
            "Tilt Camera"});
            this.cmbAction1.Location = new System.Drawing.Point(77, 182);
            this.cmbAction1.Name = "cmbAction1";
            this.cmbAction1.Size = new System.Drawing.Size(121, 24);
            this.cmbAction1.TabIndex = 2;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(16, 185);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 16);
            this.label55.TabIndex = 1;
            this.label55.Text = "Action 1";
            // 
            // cmbActionsList
            // 
            this.cmbActionsList.FormattingEnabled = true;
            this.cmbActionsList.Location = new System.Drawing.Point(404, 18);
            this.cmbActionsList.Name = "cmbActionsList";
            this.cmbActionsList.Size = new System.Drawing.Size(185, 24);
            this.cmbActionsList.TabIndex = 0;
            this.cmbActionsList.SelectedIndexChanged += new System.EventHandler(this.cmbActionsList_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.radioVideo);
            this.tabPage7.Controls.Add(this.radioPhoto);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.txtImageVerOverlap);
            this.tabPage7.Controls.Add(this.txtImageHorOverlap);
            this.tabPage7.Controls.Add(this.txtImageWidth);
            this.tabPage7.Controls.Add(this.txtImageLength);
            this.tabPage7.Controls.Add(this.txtCamVerAngle);
            this.tabPage7.Controls.Add(this.txtCamHorAngle);
            this.tabPage7.Controls.Add(this.lblImageWidth);
            this.tabPage7.Controls.Add(this.lblImageLength);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(852, 902);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Camera";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Checked = true;
            this.radioVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVideo.Location = new System.Drawing.Point(426, 73);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(110, 20);
            this.radioVideo.TabIndex = 35;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video Mode";
            this.radioVideo.UseVisualStyleBackColor = true;
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPhoto.Location = new System.Drawing.Point(299, 73);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(109, 20);
            this.radioPhoto.TabIndex = 34;
            this.radioPhoto.Text = "Photo Mode";
            this.radioPhoto.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(414, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Width Overlap (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(260, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Length Overlap (%)";
            // 
            // txtImageVerOverlap
            // 
            this.txtImageVerOverlap.Location = new System.Drawing.Point(434, 269);
            this.txtImageVerOverlap.Name = "txtImageVerOverlap";
            this.txtImageVerOverlap.Size = new System.Drawing.Size(100, 22);
            this.txtImageVerOverlap.TabIndex = 31;
            this.txtImageVerOverlap.Text = "15.0";
            this.txtImageVerOverlap.TextChanged += new System.EventHandler(this.txtImageVerOverlap_TextChanged);
            this.txtImageVerOverlap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeric_KeyPress);
            // 
            // txtImageHorOverlap
            // 
            this.txtImageHorOverlap.Location = new System.Drawing.Point(273, 269);
            this.txtImageHorOverlap.Name = "txtImageHorOverlap";
            this.txtImageHorOverlap.Size = new System.Drawing.Size(100, 22);
            this.txtImageHorOverlap.TabIndex = 30;
            this.txtImageHorOverlap.Text = "25.0";
            this.txtImageHorOverlap.TextChanged += new System.EventHandler(this.txtImageHorOverlap_TextChanged);
            this.txtImageHorOverlap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeric_KeyPress);
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(431, 197);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.ReadOnly = true;
            this.txtImageWidth.Size = new System.Drawing.Size(100, 22);
            this.txtImageWidth.TabIndex = 27;
            // 
            // txtImageLength
            // 
            this.txtImageLength.Location = new System.Drawing.Point(273, 197);
            this.txtImageLength.Name = "txtImageLength";
            this.txtImageLength.ReadOnly = true;
            this.txtImageLength.Size = new System.Drawing.Size(100, 22);
            this.txtImageLength.TabIndex = 26;
            // 
            // txtCamVerAngle
            // 
            this.txtCamVerAngle.Location = new System.Drawing.Point(426, 131);
            this.txtCamVerAngle.Name = "txtCamVerAngle";
            this.txtCamVerAngle.Size = new System.Drawing.Size(112, 22);
            this.txtCamVerAngle.TabIndex = 23;
            this.txtCamVerAngle.Text = "66";
            this.txtCamVerAngle.TextChanged += new System.EventHandler(this.txtCamVerAngle_TextChanged);
            this.txtCamVerAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeric_KeyPress);
            // 
            // txtCamHorAngle
            // 
            this.txtCamHorAngle.Location = new System.Drawing.Point(270, 131);
            this.txtCamHorAngle.Name = "txtCamHorAngle";
            this.txtCamHorAngle.Size = new System.Drawing.Size(100, 22);
            this.txtCamHorAngle.TabIndex = 22;
            this.txtCamHorAngle.Text = "81";
            this.txtCamHorAngle.TextChanged += new System.EventHandler(this.txtCamHorAngle_TextChanged);
            this.txtCamHorAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeric_KeyPress);
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageWidth.Location = new System.Drawing.Point(435, 181);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(99, 13);
            this.lblImageWidth.TabIndex = 29;
            this.lblImageWidth.Text = "Image Width (m)";
            // 
            // lblImageLength
            // 
            this.lblImageLength.AutoSize = true;
            this.lblImageLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageLength.Location = new System.Drawing.Point(275, 181);
            this.lblImageLength.Name = "lblImageLength";
            this.lblImageLength.Size = new System.Drawing.Size(98, 13);
            this.lblImageLength.TabIndex = 28;
            this.lblImageLength.Text = "Image Lenth (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Horizontal Angle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Vertical Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Camera";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEarthRadius);
            this.tabPage1.Controls.Add(this.txtGPSRadius);
            this.tabPage1.Controls.Add(this.txtAltitude);
            this.tabPage1.Controls.Add(this.txtElevation);
            this.tabPage1.Controls.Add(this.txtCenterLon);
            this.tabPage1.Controls.Add(this.txtCenterLat);
            this.tabPage1.Controls.Add(this.lblEarthRadius);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.label51);
            this.tabPage1.Controls.Add(this.cmbLocation);
            this.tabPage1.Controls.Add(this.lblAltitude);
            this.tabPage1.Controls.Add(this.lblElevation);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 902);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Location";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtEarthRadius
            // 
            this.txtEarthRadius.Location = new System.Drawing.Point(354, 230);
            this.txtEarthRadius.Name = "txtEarthRadius";
            this.txtEarthRadius.Size = new System.Drawing.Size(100, 22);
            this.txtEarthRadius.TabIndex = 25;
            // 
            // txtGPSRadius
            // 
            this.txtGPSRadius.Location = new System.Drawing.Point(354, 263);
            this.txtGPSRadius.Name = "txtGPSRadius";
            this.txtGPSRadius.ReadOnly = true;
            this.txtGPSRadius.Size = new System.Drawing.Size(100, 22);
            this.txtGPSRadius.TabIndex = 22;
            this.txtGPSRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPosNumeric_KeyPress);
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(354, 192);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(100, 22);
            this.txtAltitude.TabIndex = 6;
            this.txtAltitude.TextChanged += new System.EventHandler(this.txtAltitude_TextChanged);
            this.txtAltitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPosNumeric_KeyPress);
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(354, 154);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.ReadOnly = true;
            this.txtElevation.Size = new System.Drawing.Size(100, 22);
            this.txtElevation.TabIndex = 4;
            this.txtElevation.TextChanged += new System.EventHandler(this.txtElevation_TextChanged);
            this.txtElevation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPosNumeric_KeyPress);
            // 
            // txtCenterLon
            // 
            this.txtCenterLon.Location = new System.Drawing.Point(354, 117);
            this.txtCenterLon.Name = "txtCenterLon";
            this.txtCenterLon.ReadOnly = true;
            this.txtCenterLon.Size = new System.Drawing.Size(100, 22);
            this.txtCenterLon.TabIndex = 2;
            // 
            // txtCenterLat
            // 
            this.txtCenterLat.Location = new System.Drawing.Point(354, 80);
            this.txtCenterLat.Name = "txtCenterLat";
            this.txtCenterLat.ReadOnly = true;
            this.txtCenterLat.Size = new System.Drawing.Size(100, 22);
            this.txtCenterLat.TabIndex = 0;
            // 
            // lblEarthRadius
            // 
            this.lblEarthRadius.AutoSize = true;
            this.lblEarthRadius.Location = new System.Drawing.Point(244, 230);
            this.lblEarthRadius.Name = "lblEarthRadius";
            this.lblEarthRadius.Size = new System.Drawing.Size(104, 16);
            this.lblEarthRadius.TabIndex = 24;
            this.lblEarthRadius.Text = "Earth Radius(m)";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(244, 266);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(104, 16);
            this.label54.TabIndex = 23;
            this.label54.Text = "GPS Radius (m)";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(239, 43);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(109, 16);
            this.label51.TabIndex = 21;
            this.label51.Text = "Saved Locations";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(354, 40);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(250, 24);
            this.cmbLocation.TabIndex = 20;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(274, 195);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(74, 16);
            this.lblAltitude.TabIndex = 7;
            this.lblAltitude.Text = "Altitude (m)";
            this.lblAltitude.Click += new System.EventHandler(this.lblAltitude_Click);
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(262, 157);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(86, 16);
            this.lblElevation.TabIndex = 5;
            this.lblElevation.Text = "Elevation (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitude";
            // 
            // tabLocation
            // 
            this.tabLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLocation.Controls.Add(this.tabPage1);
            this.tabLocation.Controls.Add(this.tabPage7);
            this.tabLocation.Controls.Add(this.tabActions);
            this.tabLocation.Controls.Add(this.tabWayActions);
            this.tabLocation.Controls.Add(this.tabGMap);
            this.tabLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(0, 70);
            this.tabLocation.Multiline = true;
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.SelectedIndex = 0;
            this.tabLocation.Size = new System.Drawing.Size(860, 931);
            this.tabLocation.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLocation.TabIndex = 2;
            this.tabLocation.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 872);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabLocation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Waypoint Path Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cntxtgMap.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabGMap.ResumeLayout(false);
            this.tabGMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMapScale)).EndInit();
            this.tabWayActions.ResumeLayout(false);
            this.tabWayActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionsWaypoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionsPath)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabLocation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reloadStartXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imperialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip cntxtgMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolAddPOI;
        private System.Windows.Forms.ToolStripMenuItem ToolAddPath;
        private System.Windows.Forms.ToolStripMenuItem toolReDrawgMap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem POI;
        private System.Windows.Forms.ToolStripMenuItem ToolAllPOIShow;
        private System.Windows.Forms.ToolStripMenuItem ToolAllPOIHide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolAllPathShow;
        private System.Windows.Forms.ToolStripMenuItem ToolAllPathHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addCircularPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHelicalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addManualPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolygonGridPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem unHideAllPolygon;
        private System.Windows.Forms.ToolStripMenuItem hideAllPolygon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolDeleteWP;
        private System.Windows.Forms.ToolStripMenuItem toolInsertWP;
        private System.Windows.Forms.ToolStripMenuItem ToolInsertWPBefore;
        private System.Windows.Forms.ToolStripMenuItem ToolInsertWPAfter;
        private System.Windows.Forms.ToolStripMenuItem ToolAddKMLPath;
        private System.Windows.Forms.ToolStripMenuItem toolSplitatWP;
        private System.Windows.Forms.ToolStripMenuItem ToolSplitBefore;
        private System.Windows.Forms.ToolStripMenuItem ToolSplitAfter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolDeleteShape;
        private System.Windows.Forms.ToolStripMenuItem toolAddPoly;
        private System.Windows.Forms.ToolStripMenuItem kMLPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolAddPolyPerimPath;
        private System.Windows.Forms.ToolStripMenuItem toolToggleCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolUnselectAll;
        private System.Windows.Forms.ToolStripMenuItem toolJoinPaths;
        private System.Windows.Forms.ToolStripMenuItem toolReversePath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectedPOIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedPolygonToolStripMenuItem;
        private System.Windows.Forms.TabPage tabGMap;
        private System.Windows.Forms.TextBox txtMouseLon;
        private System.Windows.Forms.TextBox txtMouseLat;
        private System.Windows.Forms.Button btngMapRedraw;
        private System.Windows.Forms.TreeView treGMap;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox cmbGMapProvider;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.TabPage tabWayActions;
        private System.Windows.Forms.Button btnCreatePOIWP;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txtPOIWPName;
        private System.Windows.Forms.TextBox txtPOIWP;
        private System.Windows.Forms.TextBox txtWPEnd;
        private System.Windows.Forms.TextBox txtWPStart;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Button btnApplyAction;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox cmbActionsWaypoints;
        private System.Windows.Forms.DataGridView dgvActionsWaypoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.DataGridView dgvActionsPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Button btnSaveAction;
        private System.Windows.Forms.Button btnDelectAction;
        private System.Windows.Forms.Button btnClearActionsGUI;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtNewActionName;
        private System.Windows.Forms.TextBox txtActionParam12;
        private System.Windows.Forms.TextBox txtActionParam13;
        private System.Windows.Forms.TextBox txtActionParam14;
        private System.Windows.Forms.TextBox txtActionParam15;
        private System.Windows.Forms.TextBox txtActionParam11;
        private System.Windows.Forms.TextBox txtActionParam7;
        private System.Windows.Forms.TextBox txtActionParam8;
        private System.Windows.Forms.TextBox txtActionParam9;
        private System.Windows.Forms.TextBox txtActionParam10;
        private System.Windows.Forms.TextBox txtActionParam6;
        private System.Windows.Forms.TextBox txtActionParam2;
        private System.Windows.Forms.TextBox txtActionParam3;
        private System.Windows.Forms.TextBox txtActionParam4;
        private System.Windows.Forms.TextBox txtActionParam5;
        private System.Windows.Forms.TextBox txtActionParam1;
        private System.Windows.Forms.ComboBox cmbAction12;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cmbAction13;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ComboBox cmbAction14;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.ComboBox cmbAction15;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.ComboBox cmbAction11;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox cmbAction7;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox cmbAction8;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cmbAction9;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox cmbAction10;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.ComboBox cmbAction6;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cmbAction2;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox cmbAction3;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox cmbAction4;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ComboBox cmbAction5;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox cmbAction1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox cmbActionsList;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioPhoto;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEarthRadius;
        private System.Windows.Forms.TextBox txtGPSRadius;
        public System.Windows.Forms.TextBox txtAltitude;
        public System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.TextBox txtCenterLon;
        private System.Windows.Forms.TextBox txtCenterLat;
        private System.Windows.Forms.Label lblEarthRadius;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabLocation;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolAddManualPath;
        private System.Windows.Forms.ToolStripMenuItem selectedWaypointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolOutputPath;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkMapScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem selectedPOIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedPathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedWaypointToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedPolygonToolStripMenuItem1;
    }
}

