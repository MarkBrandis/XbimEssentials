﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc2x3.Interfaces.Conversions
{
    internal class IfcDirectionTransient :PersistEntityTransient, Xbim.Ifc4.Interfaces.IIfcDirection
    {
        List<double> _ratios = new List<double>(){0,0,1} ;
        
        public IEnumerable<double> DirectionRatios
        {
            get { return _ratios; }
        }

        public IfcDimensionCount Dim { get { return _ratios.Count(r => !double.IsNaN(r)); } }

        public double X
        {
            get { return _ratios[0]; }
        }
        public double Y {
            get { return _ratios[1]; }
        }
        public double Z {
            get { return _ratios[2]; }
        }

        public IEnumerable<Ifc4.Interfaces.IIfcPresentationLayerAssignment> LayerAssignment
        {
            get { return Enumerable.Empty<Ifc4.Interfaces.IIfcPresentationLayerAssignment>(); }
        }

        public IEnumerable<Ifc4.Interfaces.IIfcStyledItem> StyledByItem
        {
            get { return Enumerable.Empty<Ifc4.Interfaces.IIfcStyledItem>(); }
        }
    }
}
