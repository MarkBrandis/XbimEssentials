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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcElectricFlowStorageDeviceType : IIfcElectricFlowStorageDeviceType
	{
		Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum IIfcElectricFlowStorageDeviceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElectricFlowStorageDeviceTypeEnum.BATTERY:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.BATTERY;
					
					case IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK;
					
					case IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER;
					
					case IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK;
					
					case IfcElectricFlowStorageDeviceTypeEnum.UPS:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.UPS;
					
					case IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED;
					
					case IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}