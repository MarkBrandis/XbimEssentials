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
namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	public partial class @IfcReinforcementBarProperties : IIfcReinforcementBarProperties
	{
		Ifc4.MeasureResource.IfcAreaMeasure IIfcReinforcementBarProperties.TotalCrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(TotalCrossSectionArea);
			} 
		}
		Ifc4.MeasureResource.IfcLabel IIfcReinforcementBarProperties.SteelGrade 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(SteelGrade);
			} 
		}
		Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum? IIfcReinforcementBarProperties.BarSurface 
		{ 
			get
			{
				switch (BarSurface)
				{
					case IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum.PLAIN;
					
					case IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.ProfileResource.IfcReinforcingBarSurfaceEnum.TEXTURED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcReinforcementBarProperties.EffectiveDepth 
		{ 
			get
			{
				if (!EffectiveDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(EffectiveDepth.Value);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcementBarProperties.NominalBarDiameter 
		{ 
			get
			{
				if (!NominalBarDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalBarDiameter.Value);
			} 
		}
		Ifc4.MeasureResource.IfcCountMeasure? IIfcReinforcementBarProperties.BarCount 
		{ 
			get
			{
				if (!BarCount.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCountMeasure(BarCount.Value);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	//## Custom code
	//##
	}
}