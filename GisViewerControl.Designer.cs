namespace GisViewer
{
    partial class GisViewerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GisViewerControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.map = new DotSpatial.Controls.Map();
            this.textProjection = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToMaxExtent = new System.Windows.Forms.ToolStripButton();
            this.toolInfo = new System.Windows.Forms.ToolStripButton();
            this.toolSelect = new System.Windows.Forms.ToolStripButton();
            this.tabData = new System.Windows.Forms.TabPage();
            this.attributeGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCoor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolNew = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributeGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabMap);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 471);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.map);
            this.tabMap.Controls.Add(this.textProjection);
            this.tabMap.Controls.Add(this.toolStrip1);
            this.tabMap.Location = new System.Drawing.Point(4, 4);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(801, 445);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Map";
            this.tabMap.UseVisualStyleBackColor = true;
            this.tabMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabMap_MouseDown);
            this.tabMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabMap_MouseUp);
            // 
            // map
            // 
            this.map.AllowDrop = true;
            this.map.BackColor = System.Drawing.Color.White;
            this.map.CollectAfterDraw = false;
            this.map.CollisionDetection = false;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.ExtendBuffer = false;
            this.map.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.map.IsBusy = false;
            this.map.IsZoomedToMaxExtent = false;
            this.map.Legend = null;
            this.map.Location = new System.Drawing.Point(3, 34);
            this.map.Name = "map";
            this.map.ProgressHandler = null;
            this.map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Never;
            this.map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Never;
            this.map.RedrawLayersWhileResizing = false;
            this.map.SelectionEnabled = true;
            this.map.Size = new System.Drawing.Size(795, 368);
            this.map.TabIndex = 3;
            this.map.ZoomOutFartherThanMaxExtent = false;
            this.map.GeoMouseMove += new System.EventHandler<DotSpatial.Controls.GeoMouseArgs>(this.map_GeoMouseMove);
            this.map.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_KeyDown);
            // 
            // textProjection
            // 
            this.textProjection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textProjection.Enabled = false;
            this.textProjection.Location = new System.Drawing.Point(3, 402);
            this.textProjection.Multiline = true;
            this.textProjection.Name = "textProjection";
            this.textProjection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textProjection.Size = new System.Drawing.Size(795, 40);
            this.textProjection.TabIndex = 2;
            this.textProjection.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolOpen,
            this.toolPan,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolZoomToMaxExtent,
            this.toolInfo,
            this.toolSelect});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = ((System.Drawing.Image)(resources.GetObject("toolPan.Image")));
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(28, 28);
            this.toolPan.Text = "toolStripButton1";
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomIn.Image")));
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(28, 28);
            this.toolZoomIn.Text = "toolStripButton2";
            this.toolZoomIn.ToolTipText = "Zoom In";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(28, 28);
            this.toolZoomOut.Text = "toolStripButton3";
            this.toolZoomOut.ToolTipText = "Zoom Out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolZoomToMaxExtent
            // 
            this.toolZoomToMaxExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToMaxExtent.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomToMaxExtent.Image")));
            this.toolZoomToMaxExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToMaxExtent.Name = "toolZoomToMaxExtent";
            this.toolZoomToMaxExtent.Size = new System.Drawing.Size(28, 28);
            this.toolZoomToMaxExtent.Text = "toolStripButton4";
            this.toolZoomToMaxExtent.Click += new System.EventHandler(this.toolZoomToMaxExtent_Click);
            // 
            // toolInfo
            // 
            this.toolInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolInfo.Image")));
            this.toolInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInfo.Name = "toolInfo";
            this.toolInfo.Size = new System.Drawing.Size(28, 28);
            this.toolInfo.Text = "toolStripButton5";
            this.toolInfo.ToolTipText = "Identify";
            this.toolInfo.Click += new System.EventHandler(this.toolInfo_Click);
            // 
            // toolSelect
            // 
            this.toolSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolSelect.Image")));
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(28, 28);
            this.toolSelect.Text = "toolStripButton2";
            this.toolSelect.Click += new System.EventHandler(this.toolSelect_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.attributeGridView);
            this.tabData.Location = new System.Drawing.Point(4, 4);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(801, 445);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            this.tabData.Enter += new System.EventHandler(this.tabData_Enter);
            // 
            // attributeGridView
            // 
            this.attributeGridView.AllowUserToAddRows = false;
            this.attributeGridView.AllowUserToDeleteRows = false;
            this.attributeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attributeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeGridView.Location = new System.Drawing.Point(3, 3);
            this.attributeGridView.Name = "attributeGridView";
            this.attributeGridView.ReadOnly = true;
            this.attributeGridView.RowTemplate.Height = 23;
            this.attributeGridView.Size = new System.Drawing.Size(795, 439);
            this.attributeGridView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCoor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(135, 21);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelCoor
            // 
            this.toolStripStatusLabelCoor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelCoor.Name = "toolStripStatusLabelCoor";
            this.toolStripStatusLabelCoor.Size = new System.Drawing.Size(659, 21);
            this.toolStripStatusLabelCoor.Spring = true;
            this.toolStripStatusLabelCoor.Text = "Coordinate";
            this.toolStripStatusLabelCoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpen.Image")));
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(28, 28);
            this.toolOpen.Text = "Open";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNew.Image = ((System.Drawing.Image)(resources.GetObject("toolNew.Image")));
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(28, 28);
            this.toolNew.Text = "New Shapefile";
            // 
            // GisViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Name = "GisViewerControl";
            this.Size = new System.Drawing.Size(809, 497);
            this.tabControl1.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabMap.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attributeGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMap;
        public System.Windows.Forms.TextBox textProjection;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolPan;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomToMaxExtent;
        private System.Windows.Forms.ToolStripButton toolInfo;
        private System.Windows.Forms.TabPage tabData;
        public System.Windows.Forms.DataGridView attributeGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCoor;
        private System.Windows.Forms.ToolStripButton toolSelect;
        private DotSpatial.Controls.Map map;
        private System.Windows.Forms.ToolStripButton toolNew;
        private System.Windows.Forms.ToolStripButton toolOpen;
    }
}
