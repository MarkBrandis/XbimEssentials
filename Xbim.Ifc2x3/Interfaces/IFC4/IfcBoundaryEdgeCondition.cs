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
	public partial class @IfcBoundaryEdgeCondition : IIfcBoundaryEdgeCondition
	{
		Ifc4.StructuralLoadResource.IfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthX 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByLengthX for which no match was found
			    var value = LinearStiffnessByLengthX;
			    if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure(value.Value);
			    //##
			} 
		}
		Ifc4.StructuralLoadResource.IfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthY 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByLengthY for which no match was found
                var value = LinearStiffnessByLengthY;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure(value.Value);
				//##
			} 
		}
		Ifc4.StructuralLoadResource.IfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthZ 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByLengthZ for which no match was found
                var value = LinearStiffnessByLengthZ;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure(value.Value);
				//##
			} 
		}
		Ifc4.StructuralLoadResource.IfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthX 
		{ 
			get
			{
 
				if(!RotationalStiffnessByLengthX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure(RotationalStiffnessByLengthX.Value);
			} 
		}
		Ifc4.StructuralLoadResource.IfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthY 
		{ 
			get
			{
 
				if(!RotationalStiffnessByLengthY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure(RotationalStiffnessByLengthY.Value);
			} 
		}
		Ifc4.StructuralLoadResource.IfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthZ 
		{ 
			get
			{
 
				if(!RotationalStiffnessByLengthZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure(RotationalStiffnessByLengthZ.Value);
			} 
		}
	//## Custom code
	//##
	}
}