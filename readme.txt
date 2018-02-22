# GisViewer Lister plugin for Total Commander

version: 0.0.0.1

## Why GisViewer?

1. Occasionally, I want to view an ESRI shapefile before I add it into ArcMap.
2. There's a plugin [GisLister](https://totalcmd.net/plugring/GisLister.html), without x64 version.

## What can GisViewer do?

1. Using F3 or Ctrl + Q in Total Commander to view ESRI shapefiles.
2. For a shape file, there might be some or all of the following files with the same name and different extension: *.shp, *.shx, *.dbf, *.prj, *sbn, *.sbx. View any of these files, GisViewer will treat them as the same *shapefile*. Saves time to cautiously picking of the `*.shp` file.

    > So if there's already other plugins to view files (like *.dfb), you might want to pay attension to the orders.
    > To avoid confusing with normal xml file, GisViewer doesn't accept *.shp.xml file for now.

3. GisViewer can view the feature geometry in the `Map` tab.
4. GisViewer can view the coordinate system projection information at the bottom of `Map` tab if there's any.
5. Gisviewer can view the attribute data in the `Data` tab.

## How GisViewer works?

It is programed in C# with library [DotSpatial](https://github.com/DotSpatial/DotSpatial).

"GisViewer.wlx" and "GisViewer.wlx64" are the plugin file for x32 and x64 Total Commander. All the folders and files with name starts with "DotSpatial.*" are for [DotSpatial](https://github.com/DotSpatial/DotSpatial).

## And

I'm no expert on programming. Welcome to any feedback.

email: wayangel@outlook.com