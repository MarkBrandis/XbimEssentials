﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IBoundary.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System.Collections.Generic;

#endregion

namespace Xbim.XbimExtensions
{
    public interface IBoundary
    {
        IEnumerable<IVertex3D> ClockWiseVertices { get; }
        bool IsOuterBound { get; }
    }
}