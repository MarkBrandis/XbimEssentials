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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralLinearAction : IIfcStructuralLinearAction
	{
		Ifc4.StructuralAnalysisDomain.IfcProjectedOrTrueLengthEnum? IIfcStructuralCurveAction.ProjectedOrTrue 
		{ 
			get
			{
				//## Handle return of ProjectedOrTrue for which no match was found
                if (ProjectedOrTrue == IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH)
                    return Ifc4.StructuralAnalysisDomain.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
                else if (ProjectedOrTrue == IfcProjectedOrTrueLengthEnum.TRUE_LENGTH)
                    return Ifc4.StructuralAnalysisDomain.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
                else
                    return null;
				//##
			} 
		}
		Ifc4.StructuralAnalysisDomain.IfcStructuralCurveActivityTypeEnum IIfcStructuralCurveAction.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
                return  Ifc4.StructuralAnalysisDomain.IfcStructuralCurveActivityTypeEnum.NOTDEFINED;
				//##
			} 
		}
	//## Custom code
	//##
	}
}