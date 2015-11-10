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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyReferenceValue : IIfcPropertyReferenceValue
	{
		Ifc4.MeasureResource.IfcText? IIfcPropertyReferenceValue.UsageName 
		{ 
			get
			{
				if (!UsageName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(UsageName.Value);
			} 
		}
		Ifc4.PropertyResource.IfcObjectReferenceSelect IIfcPropertyReferenceValue.PropertyReference 
		{ 
			get
			{
				if (PropertyReference == null) return null;
				var ifcmaterial = PropertyReference as MaterialResource.IfcMaterial;
				if (ifcmaterial != null) 
					//## Handle entity IfcMaterial which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return (IIfcMaterialDefinition)ifcmaterial;
					//##
				var ifcperson = PropertyReference as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcdateandtime = PropertyReference as DateTimeResource.IfcDateAndTime;
				if (ifcdateandtime != null) 
					//## Handle entity IfcDateAndTime which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return null;
					//##
				var ifcmateriallist = PropertyReference as MaterialResource.IfcMaterialList;
				if (ifcmateriallist != null) 
					//## Handle entity IfcMaterialList which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return (IIfcMaterialDefinition)ifcmateriallist;
					//##
				var ifcorganization = PropertyReference as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifccalendardate = PropertyReference as DateTimeResource.IfcCalendarDate;
				if (ifccalendardate != null) 
					//## Handle entity IfcCalendarDate which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return null;
					//##
				var ifclocaltime = PropertyReference as DateTimeResource.IfcLocalTime;
				if (ifclocaltime != null) 
					//## Handle entity IfcLocalTime which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return null;
					//##
				var ifcpersonandorganization = PropertyReference as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				var ifcmateriallayer = PropertyReference as MaterialResource.IfcMaterialLayer;
				if (ifcmateriallayer != null) 
					//## Handle entity IfcMaterialLayer which is not a part of the target select interface Ifc4.PropertyResource.IfcObjectReferenceSelect in property PropertyReference
                    return (IIfcMaterialDefinition)ifcmateriallayer;
					//##
				var ifcexternalreference = PropertyReference as ExternalReferenceResource.IfcExternalReference;
				if (ifcexternalreference != null) 
					return ifcexternalreference;
				var ifctimeseries = PropertyReference as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
					return ifctimeseries;
				var ifcaddress = PropertyReference as ActorResource.IfcAddress;
				if (ifcaddress != null) 
					return ifcaddress;
				var ifcappliedvalue = PropertyReference as CostResource.IfcAppliedValue;
				if (ifcappliedvalue != null) 
					return ifcappliedvalue;
				return null;
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