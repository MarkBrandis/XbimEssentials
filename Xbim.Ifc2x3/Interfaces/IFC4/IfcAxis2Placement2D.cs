// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcAxis2Placement2D : IIfcAxis2Placement2D
	{
		IIfcDirection IIfcAxis2Placement2D.RefDirection 
		{ 
			get
			{
				return RefDirection;
			} 
		}
		List<Common.Geometry.XbimVector3D> Ifc4.GeometryResource.IfcAxis2Placement.P 
		{
			get 
			{
				//## Getter for P in an interface
				//TODO: Implement getter for derived attribute P in an interface
				throw new System.NotImplementedException();
				//##
			}
		}

	//## Custom code
        Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometryResource.IfcAxis2Placement.Dim
        {
            get { return (this as IIfcPlacement).Dim; }
        }
	//##
	}
}