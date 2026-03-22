using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OY.TotalCommander.TcPluginInterface;
using OY.TotalCommander.TcPluginInterface.Lister;
using System.IO;
using System.Windows.Forms;

namespace GisViewer
{
    public class GisViewer : ListerPlugin
    {
        public GisViewer(StringDictionary pluginSettings) : base(pluginSettings)
        {
            if (String.IsNullOrEmpty(Title))
                Title = "GisViewer";
            DetectString = "EXT=\"SHP\" | EXT=\"SHX\" | EXT=\"DBF\" | EXT=\"PRJ\" | EXT=\"SBN\" | EXT=\"SBX\" | EXT=\"XML\"";
        }

        public const string AllowedExtensionsOnForceShow = ".SHP,.SHX,.PRJ,.DBF,.SBN,.SBX,.XML";
        public override object Load(string fileToLoad, ShowFlags showFlags)
        {
            GisViewerControl gc = null;
            if (String.IsNullOrEmpty(fileToLoad))
                return null;

            string ext = Path.GetExtension(fileToLoad);
            if (AllowedExtensionsOnForceShow.IndexOf(ext, StringComparison.InvariantCultureIgnoreCase) < 0)
                return null;
            string name = Path.GetFileNameWithoutExtension(fileToLoad);
            string path = Path.GetDirectoryName(fileToLoad);
            if (ext.Equals(".xml", StringComparison.InvariantCultureIgnoreCase))
            {
                if (!fileToLoad.EndsWith(".shp.xml", StringComparison.InvariantCultureIgnoreCase))
                    return null;
                else
                    name = name.Remove(name.Length - 4);
            }
            string shp = Path.Combine(path, name + ".shp");
            if (!File.Exists(shp))
                return null;

            gc = new GisViewerControl();
            gc.SHP = shp;

            FocusedControl = gc;

            return gc;
        }
    }
}
