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
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialLayer : IIfcMaterialLayer
	{
		IIfcMaterial IIfcMaterialLayer.Material 
		{ 
			get
			{
				return Material;
			} 
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure IIfcMaterialLayer.LayerThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(LayerThickness);
			} 
		}
		Ifc4.MeasureResource.IfcLogical? IIfcMaterialLayer.IsVentilated 
		{ 
			get
			{
				if (!IsVentilated.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLogical(IsVentilated.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayer.Name 
		{ 
			get
			{
				//## Handle return of Name for which no match was found
			    return null;
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcMaterialLayer.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
			    return null;
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayer.Category 
		{ 
			get
			{
				//## Handle return of Category for which no match was found
			    return null;
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcMaterialLayer.Priority 
		{ 
			get
			{
				//## Handle return of Priority for which no match was found
			    return null;
			    //##
			} 
		}
		IIfcMaterialLayerSet IIfcMaterialLayer.ToMaterialLayerSet 
		{ 
			get
			{
				return Model.Instances.FirstOrDefault<IIfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this));
			} 
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterialLayer) == this);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcMaterialDefinition.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
		IEnumerable<IIfcMaterialProperties> IIfcMaterialDefinition.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialProperties>(e => (e.Material as IfcMaterialLayer) == this);
			} 
		}
	//## Custom code
	//##
	}
}