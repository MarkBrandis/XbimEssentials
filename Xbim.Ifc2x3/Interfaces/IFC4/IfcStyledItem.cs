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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcStyledItem : IIfcStyledItem
	{
		IIfcRepresentationItem IIfcStyledItem.Item 
		{ 
			get
			{
				return Item;
			} 
		}
		IEnumerable<Xbim.Ifc4.PresentationAppearanceResource.IfcStyleAssignmentSelect> IIfcStyledItem.Styles 
		{ 
			get
			{
				foreach (var member in Styles)
				{
					yield return member;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcStyledItem.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
		}
	//## Custom code
	//##
	}
}