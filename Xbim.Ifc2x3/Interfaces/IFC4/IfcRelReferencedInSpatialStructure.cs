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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelReferencedInSpatialStructure : IIfcRelReferencedInSpatialStructure
	{
		IEnumerable<IIfcProduct> IIfcRelReferencedInSpatialStructure.RelatedElements 
		{ 
			get
			{
				foreach (var member in RelatedElements)
				{
					yield return member as IIfcProduct;
				}
			} 
		}
		IIfcSpatialElement IIfcRelReferencedInSpatialStructure.RelatingStructure 
		{ 
			get
			{
				return RelatingStructure as IIfcSpatialElement;
			} 
		}
	//## Custom code
	//##
	}
}