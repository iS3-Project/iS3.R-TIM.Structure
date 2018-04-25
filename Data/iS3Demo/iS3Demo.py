# -*- coding:gb2312 -*-
import is3

from System.Collections.ObjectModel import ObservableCollection
from System.Windows.Media import Colors

def LoadPrj():
    is3.mainframe.LoadProject('iS3Demo.xml')
    is3.prj = is3.mainframe.prj
    is3.MainframeWrapper.loadDomainPanels()
    return
    
def add3dview():
    is3.addView3d('Map3D', '1.unity3d')
    is3.addView3d('Map3D', '2.unity3d')

##def addBaseMap():
##    emap = is3.EngineeringMap('BaseMap',
##                              10835179,4992323,10835531,4992459, 0.1)
##    emap.MapType = is3.EngineeringMapType.FootPrintMap
##    emap.LocalTileFileName1 = 'iS3Demo.tpk'
##    emap.LocalGeoDbFileName = 'iS3Demo.geodatabase'
##
##    viewWP = is3.MainframeWrapper.addView(emap)
##    return viewWP

##def addObjLayer(viewWP): 
##    layerDef = is3.LayerDef()
##    layerDef.Name = 'MonPoint'
##    layerDef.GeometryType = is3.GeometryType.Polygon
##    layerDef.Color = Colors.Green
##    layerDef.FillStyle = is3.SimpleFillStyle.Solid
##    layerDef.EnableLabel = True
##    layerDef.LabelTextExpression = '[Name]'
##    layerWrapper = is3.addGdbLayer(viewWP, layerDef)
##	
##    layerDef = is3.LayerDef()
##    layerDef.Name = 'GeoBorehole'
##    layerDef.GeometryType = is3.GeometryType.Point
##    layerDef.Color = Colors.Blue
##    layerDef.LineWidth = 3
##    layerDef.EnableLabel = True
##    layerDef.LabelTextExpression = '[Name]'  
##    layerWrapper = is3.addGdbLayer(viewWP, layerDef)
##
##    return layerWrapper

def Load():
    global viewWP1, viewWP2, viewWP3
    LoadPrj()
    
##    print("--- Add base map ---")
##    viewWP1 = addBaseMap()
##    objwp=addObjLayer(viewWP1)
	
    print ("--- Add 3D map ---")
    viewWP3 = add3dview()

Load()
