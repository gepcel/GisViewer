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
        * Drag to move the layer (No need to select the Pan tool first).
        * Mouse scroll to zoom in or zoom out the layer.
    4. Better layout of the FeatureIdentify form.
6. Keyboard shortcuts:
    1. H for pan tool
    2. +\- for zoom in and out
    3. I for identify tool
    4. E to zoom to max extent
    5. Esc to close (Esc to quit FeatureIdentify form if it's focused).
# Change log

## 1.0.0.0

The first version of GisViewer. See [description](https://github.com/gepcel/GisViewer/blob/master/readme.md).
