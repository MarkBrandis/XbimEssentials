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
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcStructuralLoadSingleForce : IIfcStructuralLoadSingleForce
	{
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceX 
		{ 
			get
			{
				if (!ForceX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceX.Value);
			} 
		}
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceY 
		{ 
			get
			{
				if (!ForceY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceY.Value);
			} 
		}
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceZ 
		{ 
			get
			{
				if (!ForceZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceZ.Value);
			} 
		}
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentX 
		{ 
			get
			{
				if (!MomentX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentX.Value);
			} 
		}
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentY 
		{ 
			get
			{
				if (!MomentY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentY.Value);
			} 
		}
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentZ 
		{ 
			get
			{
				if (!MomentZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentZ.Value);
			} 
		}
	//## Custom code
	//##
	}
}