# GisViewer: A lister plugin for Total Commander
<!-- TOC depthFrom:1 depthTo:6 withLinks:1 updateOnSave:1 orderedList:0 -->

- [What's this and Why?](#whats-this-and-why)
- [Features](#features)
- [How to use?](#how-to-use)
- [Installation](#installation)
- [Changes log](#change-log)
- [Contact](#contact)

<!-- /TOC -->

# What's this and Why?

[GisViewer](https://github.com/gepcel/GisViewer) is a lister plugin for [Total Commander](https://www.ghisler.com/) to view [shapefiles](https://en.wikipedia.org/wiki/Shapefile).

I often need to view an ESRI shapefile before I add it to ArcMap. No better ways than view it via a Lister plugin in Total Commander.

There is an plugin: [GisLister](https://totalcmd.net/plugring/GisLister.html), without x64 versions.

# Features

1. Accept a collection of files as a single shapefile. As the [wikipedia](https://en.wikipedia.org/wiki/Shapefile), a shapefile is not a single file, but a collection of files with a common filename prefix, and some or all of the following extensions: `.shp, .shx, .dbf, .prj, .sbn, .sbx, .shp.xml`. You don't need to carefully select out the specific `*.shp` file to view.
2. View the feature geometry in the `Map` tab, with the following tools:
    * Pan to move (Shortcut: H, the default when lister first opened)
    * Select to ZoomIn, ZoomOut (Shortcut: +\-)
    * Mouse wheel to zoom in and out
    * Identify features (Shortcut: I)
    * Zoom to Max Extent (Shortcut: E)
    * Select tools (**Not implemented yet**)
3. Show the projection at the bottom of `Map` tab if there's any.
5. View the attribute data in the `Data` tab.
6. x64 supported.

# How to use?

After installed, move the cursor to a shapefile (any file of a collection), press `Ctrl+Q` or `F3`. That's it.

# Installation

GisViewer is written in C#, with and wrapped by [.Net Interface 1.4](https://sourceforge.net/projects/tcdotnetinterface/) into a Total Commander lister plugin. So you will need to install the interface and .net frameworks. These only needs to be installed once, skip if you've already have these.

1. Install .Net Framework(>=4.5.2), refer to [.Net Official Site](https://www.microsoft.com/net)
2. Install the interface. You can download and run from [this repository](https://github.com/gepcel/GisViewer/blob/master/TcPluginSetup.msi), or from the [official website](https://sourceforge.net/projects/tcdotnetinterface/)
3. Download and install the GisViewer itself. Follow [TotalcmdWiki](http://www.ghisler.ch/wiki/index.php?title=Plugin#Plugin_installation) if you don't know how.

# Change log

[Find changes log here](https://github.com/gepcel/GisViewer/blob/master/changelog.md)

# Contact

This plugin is published at [totalcmd.net](http://totalcmd.net/plugring/GisViewer.html), you can also download from there. And there are many wonderful plugins, including the .Net Interface for Total Commander.

For unknown reasons, I cannot post topics in ghisler.ch forum (the official forum). So I cannot share it there. If any know why or how to help, please let me know.

Any problems, questions, suggestions, please file an issue.
