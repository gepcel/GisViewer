using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DotSpatial.Data;
using DotSpatial.Projections;
using DotSpatial.Controls;

namespace GisViewer
{
    public partial class GisViewerControl : UserControl
    {
        private string shp;
        private string prj;
        private AttributeTable atb;
        private IFeatureSet shapefile;
        private string path;
        private string name;
        private bool tnew, topen, tpan, tzoomin, tzoomout, tzoomextent, tidentify, tselect;
                
        public GisViewerControl()
        {
            InitializeComponent();
            toolPan.ToolTipText = "Pan\nShortcut: H";
            toolZoomIn.ToolTipText = "Zoom In\nShortcut: —";
            toolZoomOut.ToolTipText = "Zoom Out" + Environment.NewLine + "Shortcut: +";
            toolZoomToMaxExtent.ToolTipText = "Zoom To Full Extent\nShortcut: E";
            toolInfo.ToolTipText = "Identify\nShortcut: I (i)";

            TNew = false;
            TOpen = false;
            TSelect = false;

            //toolPan.ToolTipText = "Pan";
            //toolZoomIn.ToolTipText = "Zoom In";
            //toolZoomOut.ToolTipText = "Zoom Out";
            //toolZoomToMaxExtent.ToolTipText = "Zoom To Full Extent";
            //toolInfo.ToolTipText = "Identify";
            
        }

        //private void Map_Load(object sender, EventArgs e)
        //{
        //    map.Refresh();
        //}

        public string SHP
        {
            get { return shp; }
            set
            {
                shp = value;
                if (File.Exists(shp))
                {
                    shapefile = Shapefile.Open(shp);
                    if (shapefile.Projection.Name == null)
                    {
                        shapefile.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;
                    }
                    toolStripStatusLabel1.Text = shp;
                    name = Path.GetFileNameWithoutExtension(shp);
                    path = Path.GetDirectoryName(shp);

                    var _prj = Path.Combine(path, name + ".prj");
                    //if (File.Exists(_prj)) PRJ = _prj;
                    
                    map.AddLayer(shp);
                    

                }
            }
        }

        public string PRJ
        {
            get { return prj; }
            set
            {
                prj = value;
                if (File.Exists(prj))
                {
                    textProjection.Enabled = true;
                    textProjection.Visible = true;
                    textProjection.Text = File.ReadAllText(prj);
                }
            }
        }


        #region Set tools on and off
        public bool TNew
        {
            set
            {
                tnew = value;
                toolNew.Enabled = tnew;
                toolNew.Visible = tnew;
            }
        }

        public bool TOpen
        {
            set
            {
                topen = value;
                toolOpen.Enabled = topen;
                toolOpen.Visible = topen;
            }
        }

        public bool TPan
        {
            set
            {
                tpan = value;
                toolPan.Enabled = tpan;
                toolPan.Visible = tpan;
            }
        }

        public bool TZoomIn
        {
            set
            {
                tzoomin = value;
                toolZoomIn.Enabled = tzoomin;
                toolZoomIn.Visible = tzoomin;
            }
        }

        public bool TZoomOut
        {
            set
            {
                tzoomout = value;
                toolZoomOut.Enabled = tzoomout;
                toolZoomOut.Visible = tzoomout;
            }
        }

        public bool TZoomExtent
        {
            set
            {
                tzoomextent = value;
                toolZoomToMaxExtent.Enabled = tzoomextent;
                toolZoomToMaxExtent.Visible = tzoomextent;
            }
        }

        public bool TIdentify
        {
            set
            {
                tidentify = value;
                toolInfo.Enabled = tidentify;
                toolInfo.Visible = tidentify;
            }
        }

        public bool TSelect
        {
            set
            {
                tselect = value;
                toolSelect.Enabled = tselect;
                toolSelect.Visible = tselect;
            }
        }
        #endregion


        private void tabData_Enter(object sender, EventArgs e)
        {
            atb = new AttributeTable(SHP);
            attributeGridView.DataSource = atb.Table;
        }


        #region tools
        private void toolPan_Click(object sender, EventArgs e)
        {
            map.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            //map.ZoomIn();
            map.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            map.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        private void toolZoomToMaxExtent_Click(object sender, EventArgs e)
        {
            map.ZoomToMaxExtent();
        }

        private void toolInfo_Click(object sender, EventArgs e)
        {
            map.FunctionMode = DotSpatial.Controls.FunctionMode.Info;
        }

        private void toolSelect_Click(object sender, EventArgs e)
        {
            map.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
        }
        #endregion tools

        #region mouse events
        private void map_GeoMouseMove(object sender, DotSpatial.Controls.GeoMouseArgs e)
        {            
            toolStripStatusLabelCoor.Text = "        X: " + e.GeographicLocation.X.ToString("F6")
                + "  Y: " + e.GeographicLocation.Y.ToString("F6");
        }


        private void tabMap_MouseUp(object sender, MouseEventArgs e)
        {
            map.ZoomIn();
        }

        private void tabMap_MouseDown(object sender, MouseEventArgs e)
        {
            map.ZoomOut();
        }
        #endregion mouse events

        private void map_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.H:
                   map.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
                    break;
                case Keys.I:
                    map.FunctionMode = DotSpatial.Controls.FunctionMode.Info;
                    break;
                case Keys.E:
                    map.ZoomToMaxExtent();
                    break;
                case Keys.Escape:
                    this.OnKeyDown(e);
                    break;
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.OnKeyDown(e);
                    break;
                default:
                    if (tabControl1.SelectedTab == tabMap)
                        map_KeyDown(sender, e);  
                                      
                    break;
            }
        }
    }
}
