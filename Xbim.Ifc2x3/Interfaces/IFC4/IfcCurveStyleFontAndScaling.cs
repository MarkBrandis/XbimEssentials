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
	public partial class @IfcCurveStyleFontAndScaling : IIfcCurveStyleFontAndScaling
	{
		Ifc4.MeasureResource.IfcLabel? IIfcCurveStyleFontAndScaling.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
		}
		Ifc4.PresentationAppearanceResource.IfcCurveStyleFontSelect IIfcCurveStyleFontAndScaling.CurveFont 
		{ 
			get
			{
				if (CurveFont == null) return null;
				var ifcpredefinedcurvefont = CurveFont as IfcPreDefinedCurveFont;
				if (ifcpredefinedcurvefont != null) 
					return ifcpredefinedcurvefont;
				var ifccurvestylefont = CurveFont as IfcCurveStyleFont;
				if (ifccurvestylefont != null) 
					return ifccurvestylefont;
				return null;
			} 
		}
		Ifc4.MeasureResource.IfcPositiveRatioMeasure IIfcCurveStyleFontAndScaling.CurveFontScaling 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(CurveFontScaling);
			} 
		}
	//## Custom code
	//##
	}
}