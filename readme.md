# GisViewer Lister plugin for Total Commander

version: 0.0.0.1

## Why GisViewer?

1. I often need to view an ESRI shapefile before I add it to ArcMap. No better ways than view it via a Lister plugin in Total Commander.
2. Need x64 support. There existed an plugin: [GisLister](https://totalcmd.net/plugring/GisLister.html), without x64 versions.

## What can GisViewer do?

1. View ESRI shapefiles (Ctrl+Q, or F3). Only viewing, non and no plan of any editing functions.
2. For a shape file, there might be some or all of the following files with the same name and different extension: *.shp, *.shx, *.dbf, *.prj, *sbn, *.sbx. View any of these files, GisViewer will treat them as the same *shapefile*. No need to cautiously pick the exact `*.shp` file.

    > So if there's already other plugins to view files (like *.dbf), you might want to pay attension to the plugin orders.
    > *.dbf files which is not part of a shapefile will be ignored.
    > To avoid confusing with normal xml file, GisViewer doesn't accept *.shp.xml file for now. (Planning for the next version)

3. View the feature geometry in the `Map` tab.
4. View the coordinate system projection information at the bottom of `Map` tab if there is any.
4. GisViewer can let you pick the coordinate system if there is not any.
5. View the attribute data in the `Data` tab.

## How GisViewer works?

It is programed in C# with library [DotSpatial](https://github.com/DotSpatial/DotSpatial).

"GisViewer.wlx" and "GisViewer.wlx64" are the plugin file for x32 and x64 Total Commander. All the folders and files with name starts with "DotSpatial.*" are for [DotSpatial](https://github.com/DotSpatial/DotSpatial).

## And

I'm no expert on programming. Welcome to any feedbacks.

email: wayangel@outlook.com