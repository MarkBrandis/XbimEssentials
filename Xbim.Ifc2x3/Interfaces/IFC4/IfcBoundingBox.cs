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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcBoundingBox : IIfcBoundingBox
	{
		IIfcCartesianPoint IIfcBoundingBox.Corner 
		{ 
			get
			{
				return Corner;
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.XDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(XDim);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.YDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YDim);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.ZDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(ZDim);
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcBoundingBox.Dim 
		{
			get 
			{
				//## Getter for Dim in an interface
				//TODO: Implement getter for derived attribute Dim in an interface
				throw new System.NotImplementedException();
				//##
			}
		}

	//## Custom code
	//##
	}
}