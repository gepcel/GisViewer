# GisViewer: A lister plugin for Total Commander
<!-- TOC depthFrom:1 depthTo:6 withLinks:1 updateOnSave:1 orderedList:0 -->

- [What's this and Why?](#whats-this-and-why)
- [Features](#features)
- [How to use?](#how-to-use)
- [Installation](#installation)
- [Changes log](#change-log)

<!-- /TOC -->

# What's this and Why?

[GisViewer](https://github.com/gepcel/GisViewer) is a lister plugin for [Total Commander](https://www.ghisler.com/) to view [shapefiles](https://en.wikipedia.org/wiki/Shapefile).

I often need to view an ESRI shapefile before adding it to ArcMap. There's no better way than viewing it via a lister plugin in Total Commander.

An existing plugin, [GisLister](https://totalcmd.net/plugring/GisLister.html), does not have x64 versions.

# Features

1. Accepts a collection of files as a single shapefile. As described on [Wikipedia](https://en.wikipedia.org/wiki/Shapefile), a shapefile is not a single file, but a collection of files with a common filename prefix and some or all of the following extensions: `.shp, .shx, .dbf, .prj, .sbn, .sbx, .shp.xml`. You don't need to carefully select the specific `*.shp` file to view. Simply focus on any of the above files and press `F3` (or `Ctrl+Q`) to quick view it. When viewing a `.dbf` or `.shp.xml` file, other lister plugins may take precedence over this one. In that case, you can either adjust the plugin order or view another file in the collection, such as `.shp, .shx, .prj, .sbn, .sbx`.
2. Views feature geometry in the `Map` tab, with the following tools:
    * Pan to move (Shortcut: H, default when lister first opens)
    * Select to Zoom In, Zoom Out (Shortcut: +/−)
    * Mouse wheel to zoom in and out
    * Identify features (Shortcut: I)
    * Zoom to Max Extent (Shortcut: E)
    * Select tools (**Not implemented yet**)
3. Displays the projection at the bottom of the `Map` tab if available.
4. Views attribute data in the `Data` tab.
5. Supports x64.

# How to use?

After installation, move the cursor to a shapefile (any file in the collection) and press `Ctrl+Q` or `F3`. That's it.

# Installation

GisViewer is written in C# and wrapped with the [.Net Interface 1.4](https://sourceforge.net/projects/tcdotnetinterface/) into a Total Commander lister plugin. Therefore, you need to install the interface and .NET frameworks. This only needs to be done once; skip if you already have them.

1. Install .NET Framework (>=4.5.2). Refer to the [.NET Official Site](https://www.microsoft.com/net).
2. Install the interface. You can download and run it from [this repository](https://github.com/gepcel/GisViewer/blob/master/TcPluginSetup.msi) or from the [official website](https://sourceforge.net/projects/tcdotnetinterface/).
3. Download and install GisViewer itself. Follow the [TotalcmdWiki](http://www.ghisler.ch/wiki/index.php?title=Plugin#Plugin_installation) if you are unsure how.

# Change log

[Find changes log here](https://github.com/gepcel/GisViewer/blob/master/changelog.md)