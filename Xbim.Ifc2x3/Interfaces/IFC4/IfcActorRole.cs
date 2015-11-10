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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcActorRole : IIfcActorRole
	{
		Ifc4.ActorResource.IfcRoleEnum IIfcActorRole.Role 
		{ 
			get
			{
				switch (Role)
				{
					case IfcRoleEnum.SUPPLIER:
						return Ifc4.ActorResource.IfcRoleEnum.SUPPLIER;
					
					case IfcRoleEnum.MANUFACTURER:
						return Ifc4.ActorResource.IfcRoleEnum.MANUFACTURER;
					
					case IfcRoleEnum.CONTRACTOR:
						return Ifc4.ActorResource.IfcRoleEnum.CONTRACTOR;
					
					case IfcRoleEnum.SUBCONTRACTOR:
						return Ifc4.ActorResource.IfcRoleEnum.SUBCONTRACTOR;
					
					case IfcRoleEnum.ARCHITECT:
						return Ifc4.ActorResource.IfcRoleEnum.ARCHITECT;
					
					case IfcRoleEnum.STRUCTURALENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.STRUCTURALENGINEER;
					
					case IfcRoleEnum.COSTENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.COSTENGINEER;
					
					case IfcRoleEnum.CLIENT:
						return Ifc4.ActorResource.IfcRoleEnum.CLIENT;
					
					case IfcRoleEnum.BUILDINGOWNER:
						return Ifc4.ActorResource.IfcRoleEnum.BUILDINGOWNER;
					
					case IfcRoleEnum.BUILDINGOPERATOR:
						return Ifc4.ActorResource.IfcRoleEnum.BUILDINGOPERATOR;
					
					case IfcRoleEnum.MECHANICALENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.MECHANICALENGINEER;
					
					case IfcRoleEnum.ELECTRICALENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.ELECTRICALENGINEER;
					
					case IfcRoleEnum.PROJECTMANAGER:
						return Ifc4.ActorResource.IfcRoleEnum.PROJECTMANAGER;
					
					case IfcRoleEnum.FACILITIESMANAGER:
						return Ifc4.ActorResource.IfcRoleEnum.FACILITIESMANAGER;
					
					case IfcRoleEnum.CIVILENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.CIVILENGINEER;
					
					case IfcRoleEnum.COMISSIONINGENGINEER:
						//## Handle translation of COMISSIONINGENGINEER member from IfcRoleEnum in property Role
						return Ifc4.ActorResource.IfcRoleEnum.COMMISSIONINGENGINEER;
						//##
										
					case IfcRoleEnum.ENGINEER:
						return Ifc4.ActorResource.IfcRoleEnum.ENGINEER;
					
					case IfcRoleEnum.OWNER:
						return Ifc4.ActorResource.IfcRoleEnum.OWNER;
					
					case IfcRoleEnum.CONSULTANT:
						return Ifc4.ActorResource.IfcRoleEnum.CONSULTANT;
					
					case IfcRoleEnum.CONSTRUCTIONMANAGER:
						return Ifc4.ActorResource.IfcRoleEnum.CONSTRUCTIONMANAGER;
					
					case IfcRoleEnum.FIELDCONSTRUCTIONMANAGER:
						return Ifc4.ActorResource.IfcRoleEnum.FIELDCONSTRUCTIONMANAGER;
					
					case IfcRoleEnum.RESELLER:
						return Ifc4.ActorResource.IfcRoleEnum.RESELLER;
					
					case IfcRoleEnum.USERDEFINED:
						return Ifc4.ActorResource.IfcRoleEnum.USERDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcActorRole.UserDefinedRole 
		{ 
			get
			{
				if (!UserDefinedRole.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedRole.Value);
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcActorRole.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcActorRole.HasExternalReference 
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