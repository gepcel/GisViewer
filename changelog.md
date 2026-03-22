# What's new?

1. Two status bars to show informations:
    * The path of the shapefile
    * The x, y coordinates of of the mouse cursor.
2. Accept the `.shp.xml` file. Which means:
    * Any of the `*.shp, *.shx, *.dbf, *.prj, *.sbn, *.sbx, *.shp.xml` files can be treat as the same single shapefile.
    * Files of `*.prj, *.dbf, *.xml` alone that don't belong a shapefile will be ignored by GisViewer.
3. Set `WGS84` as the default coordinates if there's none.
4. Identify table cann't be edited.
5. Optimizations:
    1. Icons.
    2. Tooltips when point at the tools.
    3. When plugin first opened:
        * Single left click to move the layer.
        * Mouse scroll to zoom in or zoom out the layer.
    4. Columns width of the identify attribute table.
    5. When first startup, without first to choose a tool:
        * Mouse scroll to zoom in and out.
        * Click and drag to move.
6. Keyboard shortcuts (have to click the map at least once):
    1. H for pan tool
    2. +\- for zoom in and out
    3. I for identify tool
    4. E to zoom to max extent
# Change log

## 1.0.0.0

The first version of GisViewer. See [description](https://github.com/gepcel/GisViewer/blob/master/readme.md).
