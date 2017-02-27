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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("POI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Paths");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Polygons");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Objects", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
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
            this.addMathamaticalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedWaypointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditPathAlt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolInsertWP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolInsertWPBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolInsertWPAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolJoinPaths = new System.Windows.Forms.ToolStripMenuItem();
            this.keepOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOriginalPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSplitatWP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSplitBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSplitAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReversePath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUnselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedPOIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllPOIsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteWP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteShape = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedPolygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllPolygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.POI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPOIShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPOIHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPathShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAllPathHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.unHideAllPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPOIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedWaypointToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedPolygonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.distanceBetweenWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOutputPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolToggleCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReDrawgMap = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonPerimeterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathamaticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLPOlygonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathWaypointPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helicalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonGridPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathamaticalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabGMap = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treGMap = new System.Windows.Forms.TreeView();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGMapProvider = new System.Windows.Forms.ComboBox();
            this.label109 = new System.Windows.Forms.Label();
            this.trkMapScale = new System.Windows.Forms.TrackBar();
            this.btngMapRedraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMouseLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMouseLon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabControl();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.redefineCircularPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefineHelicalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mathamaticalPathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtgMap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabGMap.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMapScale)).BeginInit();
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
            this.toolStripMenuItem10,
            this.toolStripSeparator10,
            this.toolStripMenuItem5,
            this.toolEditPathAlt,
            this.toolStripSeparator4,
            this.toolInsertWP,
            this.toolJoinPaths,
            this.toolSplitatWP,
            this.toolReversePath,
            this.toolStripSeparator7,
            this.toolStripMenuItem9,
            this.toolUnselectAll,
            this.toolStripSeparator6,
            this.toolStripMenuItem6,
            this.toolStripMenuItem3,
            this.toolDeleteWP,
            this.toolDeleteShape,
            this.toolStripSeparator2,
            this.POI,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem7,
            this.toolStripSeparator3,
            this.toolStripMenuItem8,
            this.toolStripSeparator9,
            this.toolOutputPath,
            this.toolStripSeparator5,
            this.toolToggleCenter,
            this.toolReDrawgMap});
            this.cntxtgMap.Name = "cntxtgMap";
            this.cntxtgMap.Size = new System.Drawing.Size(204, 592);
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
            this.ToolAddPolyPerimPath,
            this.addMathamaticalPathToolStripMenuItem});
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
            // addMathamaticalPathToolStripMenuItem
            // 
            this.addMathamaticalPathToolStripMenuItem.Name = "addMathamaticalPathToolStripMenuItem";
            this.addMathamaticalPathToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addMathamaticalPathToolStripMenuItem.Text = "Add Mathamatical Path";
            this.addMathamaticalPathToolStripMenuItem.Click += new System.EventHandler(this.addMathamaticalPathToolStripMenuItem_Click);
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
            this.toolStripMenuItem5.Text = "Edit Properties";
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
            // toolEditPathAlt
            // 
            this.toolEditPathAlt.Name = "toolEditPathAlt";
            this.toolEditPathAlt.Size = new System.Drawing.Size(203, 22);
            this.toolEditPathAlt.Text = "Edit Path Parameters";
            this.toolEditPathAlt.Click += new System.EventHandler(this.toolEditPathAlt_Click);
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
            this.toolJoinPaths.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keepOriginalToolStripMenuItem,
            this.deleteOriginalPathsToolStripMenuItem});
            this.toolJoinPaths.Name = "toolJoinPaths";
            this.toolJoinPaths.Size = new System.Drawing.Size(203, 22);
            this.toolJoinPaths.Text = "Join Paths";
            // 
            // keepOriginalToolStripMenuItem
            // 
            this.keepOriginalToolStripMenuItem.Name = "keepOriginalToolStripMenuItem";
            this.keepOriginalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.keepOriginalToolStripMenuItem.Text = "Keep Original Paths";
            this.keepOriginalToolStripMenuItem.Click += new System.EventHandler(this.keepOriginalToolStripMenuItem_Click);
            // 
            // deleteOriginalPathsToolStripMenuItem
            // 
            this.deleteOriginalPathsToolStripMenuItem.Name = "deleteOriginalPathsToolStripMenuItem";
            this.deleteOriginalPathsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteOriginalPathsToolStripMenuItem.Text = "Delete Original Paths";
            this.deleteOriginalPathsToolStripMenuItem.Click += new System.EventHandler(this.deleteOriginalPathsToolStripMenuItem_Click);
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
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem9.Text = "Select Waypoint Path";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
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
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedPOIsToolStripMenuItem,
            this.deleteAllPOIsToolStripMenuItem1});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem6.Text = "Delete  POI";
            // 
            // deleteSelectedPOIsToolStripMenuItem
            // 
            this.deleteSelectedPOIsToolStripMenuItem.Name = "deleteSelectedPOIsToolStripMenuItem";
            this.deleteSelectedPOIsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteSelectedPOIsToolStripMenuItem.Text = "Delete Selected POI";
            this.deleteSelectedPOIsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedPOIsToolStripMenuItem_Click);
            // 
            // deleteAllPOIsToolStripMenuItem1
            // 
            this.deleteAllPOIsToolStripMenuItem1.Name = "deleteAllPOIsToolStripMenuItem1";
            this.deleteAllPOIsToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.deleteAllPOIsToolStripMenuItem1.Text = "Delete All POIs";
            this.deleteAllPOIsToolStripMenuItem1.Click += new System.EventHandler(this.deleteAllPOIsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedPathsToolStripMenuItem,
            this.allToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem3.Text = "Delete Path";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // deleteSelectedPathsToolStripMenuItem
            // 
            this.deleteSelectedPathsToolStripMenuItem.Name = "deleteSelectedPathsToolStripMenuItem";
            this.deleteSelectedPathsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteSelectedPathsToolStripMenuItem.Text = "Delete Selected Paths";
            this.deleteSelectedPathsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedPathsToolStripMenuItem_Click_1);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.allToolStripMenuItem.Text = "Delete All Paths";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
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
            this.toolDeleteShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedPolygonsToolStripMenuItem,
            this.deleteAllPolygonsToolStripMenuItem});
            this.toolDeleteShape.Name = "toolDeleteShape";
            this.toolDeleteShape.Size = new System.Drawing.Size(203, 22);
            this.toolDeleteShape.Text = "Delete Polygons";
            this.toolDeleteShape.Click += new System.EventHandler(this.toolDeleteShape_Click);
            // 
            // deleteSelectedPolygonsToolStripMenuItem
            // 
            this.deleteSelectedPolygonsToolStripMenuItem.Name = "deleteSelectedPolygonsToolStripMenuItem";
            this.deleteSelectedPolygonsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteSelectedPolygonsToolStripMenuItem.Text = "Delete Selected Polygons";
            this.deleteSelectedPolygonsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedPolygonsToolStripMenuItem_Click);
            // 
            // deleteAllPolygonsToolStripMenuItem
            // 
            this.deleteAllPolygonsToolStripMenuItem.Name = "deleteAllPolygonsToolStripMenuItem";
            this.deleteAllPolygonsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteAllPolygonsToolStripMenuItem.Text = "Delete All Polygons";
            this.deleteAllPolygonsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllPolygonsToolStripMenuItem_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distanceBetweenWaypointsToolStripMenuItem});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem8.Text = "Measure";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // distanceBetweenWaypointsToolStripMenuItem
            // 
            this.distanceBetweenWaypointsToolStripMenuItem.Name = "distanceBetweenWaypointsToolStripMenuItem";
            this.distanceBetweenWaypointsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.distanceBetweenWaypointsToolStripMenuItem.Text = "Distance between Waypoints";
            this.distanceBetweenWaypointsToolStripMenuItem.Click += new System.EventHandler(this.distanceBetweenWaypointsToolStripMenuItem_Click);
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
            this.toolStripMenuItem1,
            this.cameraToolStripMenu,
            this.actionsToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.editToolStripMenuItem,
            this.redefineToolStripMenuItem});
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
            // cameraToolStripMenu
            // 
            this.cameraToolStripMenu.Name = "cameraToolStripMenu";
            this.cameraToolStripMenu.Size = new System.Drawing.Size(56, 20);
            this.cameraToolStripMenu.Text = "Camera";
            this.cameraToolStripMenu.Click += new System.EventHandler(this.cameraToolStripMenu_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOIToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            this.pOIToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pOIToolStripMenuItem.Text = "POI";
            this.pOIToolStripMenuItem.Click += new System.EventHandler(this.pOIToolStripMenuItem_Click);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.circularToolStripMenuItem,
            this.helicalToolStripMenuItem,
            this.rectangularToolStripMenuItem,
            this.polygonGridToolStripMenuItem,
            this.polygonPerimeterToolStripMenuItem,
            this.kMLPathToolStripMenuItem,
            this.mathamaticalToolStripMenuItem});
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pathToolStripMenuItem.Text = "Path";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // circularToolStripMenuItem
            // 
            this.circularToolStripMenuItem.Name = "circularToolStripMenuItem";
            this.circularToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.circularToolStripMenuItem.Text = "Circular";
            this.circularToolStripMenuItem.Click += new System.EventHandler(this.circularToolStripMenuItem_Click);
            // 
            // helicalToolStripMenuItem
            // 
            this.helicalToolStripMenuItem.Name = "helicalToolStripMenuItem";
            this.helicalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.helicalToolStripMenuItem.Text = "Helical";
            this.helicalToolStripMenuItem.Click += new System.EventHandler(this.helicalToolStripMenuItem_Click);
            // 
            // rectangularToolStripMenuItem
            // 
            this.rectangularToolStripMenuItem.Name = "rectangularToolStripMenuItem";
            this.rectangularToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rectangularToolStripMenuItem.Text = "Rectangular";
            this.rectangularToolStripMenuItem.Click += new System.EventHandler(this.rectangularToolStripMenuItem_Click);
            // 
            // polygonGridToolStripMenuItem
            // 
            this.polygonGridToolStripMenuItem.Name = "polygonGridToolStripMenuItem";
            this.polygonGridToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.polygonGridToolStripMenuItem.Text = "Polygon Grid";
            this.polygonGridToolStripMenuItem.Click += new System.EventHandler(this.polygonGridToolStripMenuItem_Click);
            // 
            // polygonPerimeterToolStripMenuItem
            // 
            this.polygonPerimeterToolStripMenuItem.Name = "polygonPerimeterToolStripMenuItem";
            this.polygonPerimeterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.polygonPerimeterToolStripMenuItem.Text = "Polygon Perimeter";
            this.polygonPerimeterToolStripMenuItem.Click += new System.EventHandler(this.polygonPerimeterToolStripMenuItem_Click);
            // 
            // kMLPathToolStripMenuItem
            // 
            this.kMLPathToolStripMenuItem.Name = "kMLPathToolStripMenuItem";
            this.kMLPathToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.kMLPathToolStripMenuItem.Text = "KML Path";
            this.kMLPathToolStripMenuItem.Click += new System.EventHandler(this.kMLPathToolStripMenuItem_Click);
            // 
            // mathamaticalToolStripMenuItem
            // 
            this.mathamaticalToolStripMenuItem.Name = "mathamaticalToolStripMenuItem";
            this.mathamaticalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mathamaticalToolStripMenuItem.Text = "Mathamatical";
            this.mathamaticalToolStripMenuItem.Click += new System.EventHandler(this.mathamaticalToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kMLPOlygonToolStripMenuItem1});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // kMLPOlygonToolStripMenuItem1
            // 
            this.kMLPOlygonToolStripMenuItem1.Name = "kMLPOlygonToolStripMenuItem1";
            this.kMLPOlygonToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.kMLPOlygonToolStripMenuItem1.Text = "KML Polygon";
            this.kMLPOlygonToolStripMenuItem1.Click += new System.EventHandler(this.kMLPOlygonToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOIPropertiesToolStripMenuItem,
            this.pathPropertiesToolStripMenuItem,
            this.polygonPropertiesToolStripMenuItem,
            this.pathWaypointPropertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pOIPropertiesToolStripMenuItem
            // 
            this.pOIPropertiesToolStripMenuItem.Name = "pOIPropertiesToolStripMenuItem";
            this.pOIPropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pOIPropertiesToolStripMenuItem.Text = "POI Properties";
            this.pOIPropertiesToolStripMenuItem.Click += new System.EventHandler(this.pOIPropertiesToolStripMenuItem_Click);
            // 
            // pathPropertiesToolStripMenuItem
            // 
            this.pathPropertiesToolStripMenuItem.Name = "pathPropertiesToolStripMenuItem";
            this.pathPropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pathPropertiesToolStripMenuItem.Text = "Path Properties";
            this.pathPropertiesToolStripMenuItem.Click += new System.EventHandler(this.pathPropertiesToolStripMenuItem_Click);
            // 
            // polygonPropertiesToolStripMenuItem
            // 
            this.polygonPropertiesToolStripMenuItem.Name = "polygonPropertiesToolStripMenuItem";
            this.polygonPropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.polygonPropertiesToolStripMenuItem.Text = "Polygon Properties";
            this.polygonPropertiesToolStripMenuItem.Click += new System.EventHandler(this.polygonPropertiesToolStripMenuItem_Click);
            // 
            // pathWaypointPropertiesToolStripMenuItem
            // 
            this.pathWaypointPropertiesToolStripMenuItem.Name = "pathWaypointPropertiesToolStripMenuItem";
            this.pathWaypointPropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pathWaypointPropertiesToolStripMenuItem.Text = "Path Waypoint Properties";
            this.pathWaypointPropertiesToolStripMenuItem.Click += new System.EventHandler(this.pathWaypointPropertiesToolStripMenuItem_Click);
            // 
            // redefineToolStripMenuItem
            // 
            this.redefineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circularPathToolStripMenuItem,
            this.helicalPathToolStripMenuItem,
            this.rectangularPathToolStripMenuItem,
            this.polygonGridPathToolStripMenuItem,
            this.mathamaticalPathToolStripMenuItem});
            this.redefineToolStripMenuItem.Name = "redefineToolStripMenuItem";
            this.redefineToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.redefineToolStripMenuItem.Text = "Redefine";
            // 
            // circularPathToolStripMenuItem
            // 
            this.circularPathToolStripMenuItem.Name = "circularPathToolStripMenuItem";
            this.circularPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.circularPathToolStripMenuItem.Text = "Circular Path";
            this.circularPathToolStripMenuItem.Click += new System.EventHandler(this.circularPathToolStripMenuItem_Click);
            // 
            // helicalPathToolStripMenuItem
            // 
            this.helicalPathToolStripMenuItem.Name = "helicalPathToolStripMenuItem";
            this.helicalPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.helicalPathToolStripMenuItem.Text = "Helical Path";
            this.helicalPathToolStripMenuItem.Click += new System.EventHandler(this.helicalPathToolStripMenuItem_Click);
            // 
            // rectangularPathToolStripMenuItem
            // 
            this.rectangularPathToolStripMenuItem.Name = "rectangularPathToolStripMenuItem";
            this.rectangularPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rectangularPathToolStripMenuItem.Text = "Rectangular Path";
            this.rectangularPathToolStripMenuItem.Click += new System.EventHandler(this.rectangularPathToolStripMenuItem_Click);
            // 
            // polygonGridPathToolStripMenuItem
            // 
            this.polygonGridPathToolStripMenuItem.Name = "polygonGridPathToolStripMenuItem";
            this.polygonGridPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.polygonGridPathToolStripMenuItem.Text = "Polygon Grid Path";
            this.polygonGridPathToolStripMenuItem.Click += new System.EventHandler(this.polygonGridPathToolStripMenuItem_Click);
            // 
            // mathamaticalPathToolStripMenuItem
            // 
            this.mathamaticalPathToolStripMenuItem.Name = "mathamaticalPathToolStripMenuItem";
            this.mathamaticalPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.mathamaticalPathToolStripMenuItem.Text = "Mathamatical Path";
            this.mathamaticalPathToolStripMenuItem.Click += new System.EventHandler(this.mathamaticalPathToolStripMenuItem_Click);
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
            this.tabGMap.Controls.Add(this.panel2);
            this.tabGMap.Controls.Add(this.panel1);
            this.tabGMap.Location = new System.Drawing.Point(4, 25);
            this.tabGMap.Name = "tabGMap";
            this.tabGMap.Size = new System.Drawing.Size(852, 868);
            this.tabGMap.TabIndex = 16;
            this.tabGMap.Text = "Path Preview";
            this.tabGMap.UseVisualStyleBackColor = true;
            this.tabGMap.Click += new System.EventHandler(this.tabGMap_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 638);
            this.panel2.TabIndex = 38;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treGMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl);
            this.splitContainer1.Size = new System.Drawing.Size(852, 638);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // treGMap
            // 
            this.treGMap.CheckBoxes = true;
            this.treGMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.treGMap.Location = new System.Drawing.Point(0, 0);
            this.treGMap.Name = "treGMap";
            treeNode5.Name = "POI";
            treeNode5.Text = "POI";
            treeNode6.Name = "Paths";
            treeNode6.Text = "Paths";
            treeNode7.Name = "Polygons";
            treeNode7.Text = "Polygons";
            treeNode8.Name = "GMap";
            treeNode8.Text = "Objects";
            this.treGMap.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treGMap.Size = new System.Drawing.Size(159, 634);
            this.treGMap.TabIndex = 25;
            this.treGMap.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treGMap_AfterCheck);
            this.treGMap.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treGMap_NodeMouseClick);
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
            this.gMapControl.Location = new System.Drawing.Point(-5, -2);
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
            this.gMapControl.Size = new System.Drawing.Size(685, 638);
            this.gMapControl.TabIndex = 16;
            this.gMapControl.Zoom = 13D;
            this.gMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMap_OnMarkerClick);
            this.gMapControl.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gMap_OnRouteClick);
            this.gMapControl.OnMapDrag += new GMap.NET.MapDrag(this.gMap_OnMapDrag);
            this.gMapControl.Load += new System.EventHandler(this.gMapControl_Load_1);
            this.gMapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseClick);
            this.gMapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            this.gMapControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbGMapProvider);
            this.panel1.Controls.Add(this.label109);
            this.panel1.Controls.Add(this.trkMapScale);
            this.panel1.Controls.Add(this.btngMapRedraw);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMouseLat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMouseLon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 106);
            this.panel1.TabIndex = 37;
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
            this.cmbGMapProvider.Location = new System.Drawing.Point(324, 12);
            this.cmbGMapProvider.Name = "cmbGMapProvider";
            this.cmbGMapProvider.Size = new System.Drawing.Size(215, 24);
            this.cmbGMapProvider.TabIndex = 15;
            this.cmbGMapProvider.Text = "Bing Satellite";
            this.cmbGMapProvider.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(218, 15);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(89, 16);
            this.label109.TabIndex = 16;
            this.label109.Text = "Map Provider";
            // 
            // trkMapScale
            // 
            this.trkMapScale.Location = new System.Drawing.Point(543, 53);
            this.trkMapScale.Maximum = 24;
            this.trkMapScale.Minimum = 1;
            this.trkMapScale.Name = "trkMapScale";
            this.trkMapScale.Size = new System.Drawing.Size(104, 42);
            this.trkMapScale.TabIndex = 35;
            this.trkMapScale.Value = 10;
            this.trkMapScale.Scroll += new System.EventHandler(this.trkMapScale_Scroll);
            // 
            // btngMapRedraw
            // 
            this.btngMapRedraw.Location = new System.Drawing.Point(569, 12);
            this.btngMapRedraw.Name = "btngMapRedraw";
            this.btngMapRedraw.Size = new System.Drawing.Size(137, 23);
            this.btngMapRedraw.TabIndex = 27;
            this.btngMapRedraw.Text = "Redraw Map";
            this.btngMapRedraw.UseVisualStyleBackColor = true;
            this.btngMapRedraw.Click += new System.EventHandler(this.btngMapRedraw_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Scale";
            // 
            // txtMouseLat
            // 
            this.txtMouseLat.Location = new System.Drawing.Point(188, 53);
            this.txtMouseLat.Name = "txtMouseLat";
            this.txtMouseLat.Size = new System.Drawing.Size(100, 22);
            this.txtMouseLat.TabIndex = 25;
            this.txtMouseLat.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Longitude";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // txtMouseLon
            // 
            this.txtMouseLon.Location = new System.Drawing.Point(377, 53);
            this.txtMouseLon.Name = "txtMouseLon";
            this.txtMouseLon.Size = new System.Drawing.Size(100, 22);
            this.txtMouseLon.TabIndex = 26;
            this.txtMouseLon.Text = "0.0";
            this.txtMouseLon.TextChanged += new System.EventHandler(this.txtMouseLon_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Latitude";
            // 
            // tabLocation
            // 
            this.tabLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLocation.Controls.Add(this.tabGMap);
            this.tabLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocation.Location = new System.Drawing.Point(0, 27);
            this.tabLocation.Multiline = true;
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.SelectedIndex = 0;
            this.tabLocation.Size = new System.Drawing.Size(860, 897);
            this.tabLocation.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabLocation.TabIndex = 2;
            this.tabLocation.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "WP Count";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Path";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Action Param 4";
            this.Column17.Name = "Column17";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Action Type 4";
            this.Column16.Name = "Column16";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Action Param 3";
            this.Column15.Name = "Column15";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Action Type 3";
            this.Column14.Name = "Column14";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Action Param 2";
            this.Column13.Name = "Column13";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Action Type 2";
            this.Column12.Name = "Column12";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Action Param 1";
            this.Column11.Name = "Column11";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Action Type 1";
            this.Column10.Name = "Column10";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Gimble Pitch";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Gimble Mode";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Rotation Dir";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Curve Size";
            this.Column8.Name = "Column8";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Heading";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Altitude";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Waypoint";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redefineCircularPathToolStripMenuItem,
            this.redefineHelicalPathToolStripMenuItem,
            this.rectangularPathToolStripMenuItem1,
            this.polygonToolStripMenuItem1,
            this.mathamaticalPathToolStripMenuItem1});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem10.Text = "Redefine";
            // 
            // redefineCircularPathToolStripMenuItem
            // 
            this.redefineCircularPathToolStripMenuItem.Name = "redefineCircularPathToolStripMenuItem";
            this.redefineCircularPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.redefineCircularPathToolStripMenuItem.Text = "Circular Path";
            this.redefineCircularPathToolStripMenuItem.Click += new System.EventHandler(this.circularPathToolStripMenuItem_Click);
            // 
            // redefineHelicalPathToolStripMenuItem
            // 
            this.redefineHelicalPathToolStripMenuItem.Name = "redefineHelicalPathToolStripMenuItem";
            this.redefineHelicalPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.redefineHelicalPathToolStripMenuItem.Text = "Helical Path";
            this.redefineHelicalPathToolStripMenuItem.Click += new System.EventHandler(this.helicalPathToolStripMenuItem_Click);
            // 
            // rectangularPathToolStripMenuItem1
            // 
            this.rectangularPathToolStripMenuItem1.Name = "rectangularPathToolStripMenuItem1";
            this.rectangularPathToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.rectangularPathToolStripMenuItem1.Text = "Rectangular Path";
            this.rectangularPathToolStripMenuItem1.Click += new System.EventHandler(this.rectangularPathToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem1
            // 
            this.polygonToolStripMenuItem1.Name = "polygonToolStripMenuItem1";
            this.polygonToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.polygonToolStripMenuItem1.Text = "Polygon";
            this.polygonToolStripMenuItem1.Click += new System.EventHandler(this.polygonGridToolStripMenuItem_Click);
            // 
            // mathamaticalPathToolStripMenuItem1
            // 
            this.mathamaticalPathToolStripMenuItem1.Name = "mathamaticalPathToolStripMenuItem1";
            this.mathamaticalPathToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.mathamaticalPathToolStripMenuItem1.Text = "Mathamatical Path";
            this.mathamaticalPathToolStripMenuItem1.Click += new System.EventHandler(this.mathamaticalPathToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 795);
            this.Controls.Add(this.tabLocation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Waypoint Path Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.cntxtgMap.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabGMap.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMapScale)).EndInit();
            this.tabLocation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip cntxtgMap;
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
        private System.Windows.Forms.TabControl tabLocation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolAddManualPath;
        private System.Windows.Forms.ToolStripMenuItem selectedWaypointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem toolOutputPath;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem selectedPOIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedPathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedWaypointToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedPolygonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedPOIsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllPOIsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedPolygonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllPolygonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonPerimeterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMLPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMLPOlygonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOIPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathWaypointPropertiesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripMenuItem redefineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helicalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOriginalPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonGridPathToolStripMenuItem;
        private System.Windows.Forms.TreeView treGMap;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGMapProvider;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TrackBar trkMapScale;
        private System.Windows.Forms.Button btngMapRedraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMouseLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMouseLon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem mathamaticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathamaticalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolEditPathAlt;
        private System.Windows.Forms.ToolStripMenuItem addMathamaticalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem distanceBetweenWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem redefineCircularPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redefineHelicalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularPathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mathamaticalPathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}

