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
	public partial class @IfcElectricApplianceType : IIfcElectricApplianceType
	{
		Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum IIfcElectricApplianceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElectricApplianceTypeEnum.COMPUTER:
						//## Handle translation of COMPUTER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.DIRECTWATERHEATER:
						//## Handle translation of DIRECTWATERHEATER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.DISHWASHER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.DISHWASHER;
					
					case IfcElectricApplianceTypeEnum.ELECTRICCOOKER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.ELECTRICCOOKER;
					
					case IfcElectricApplianceTypeEnum.ELECTRICHEATER:
						//## Handle translation of ELECTRICHEATER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.FACSIMILE:
						//## Handle translation of FACSIMILE member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.FREESTANDINGFAN:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.FREESTANDINGFAN;
					
					case IfcElectricApplianceTypeEnum.FREEZER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.FREEZER;
					
					case IfcElectricApplianceTypeEnum.FRIDGE_FREEZER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.FRIDGE_FREEZER;
					
					case IfcElectricApplianceTypeEnum.HANDDRYER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.HANDDRYER;
					
					case IfcElectricApplianceTypeEnum.INDIRECTWATERHEATER:
						//## Handle translation of INDIRECTWATERHEATER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.MICROWAVE:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.MICROWAVE;
					
					case IfcElectricApplianceTypeEnum.PHOTOCOPIER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.PHOTOCOPIER;
					
					case IfcElectricApplianceTypeEnum.PRINTER:
						//## Handle translation of PRINTER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.REFRIGERATOR:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.REFRIGERATOR;
					
					case IfcElectricApplianceTypeEnum.RADIANTHEATER:
						//## Handle translation of RADIANTHEATER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.SCANNER:
						//## Handle translation of SCANNER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.TELEPHONE:
						//## Handle translation of TELEPHONE member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.TUMBLEDRYER:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.TUMBLEDRYER;
					
					case IfcElectricApplianceTypeEnum.TV:
						//## Handle translation of TV member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.VENDINGMACHINE:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.VENDINGMACHINE;
					
					case IfcElectricApplianceTypeEnum.WASHINGMACHINE:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.WASHINGMACHINE;
					
					case IfcElectricApplianceTypeEnum.WATERHEATER:
						//## Handle translation of WATERHEATER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.WATERCOOLER:
						//## Handle translation of WATERCOOLER member from IfcElectricApplianceTypeEnum in property PredefinedType
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
						//##
										
					case IfcElectricApplianceTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.USERDEFINED;
					
					case IfcElectricApplianceTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricApplianceTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
        Ifc4.MeasureResource.IfcLabel? IIfcElementType.ElementType
        {
            get
            {
                switch (PredefinedType)
                {
                    case IfcElectricApplianceTypeEnum.COMPUTER:
                    case IfcElectricApplianceTypeEnum.DIRECTWATERHEATER:
                    case IfcElectricApplianceTypeEnum.ELECTRICHEATER:
                    case IfcElectricApplianceTypeEnum.FACSIMILE:
                    case IfcElectricApplianceTypeEnum.INDIRECTWATERHEATER:
                    case IfcElectricApplianceTypeEnum.PRINTER:
                    case IfcElectricApplianceTypeEnum.RADIANTHEATER:
                    case IfcElectricApplianceTypeEnum.SCANNER:
                    case IfcElectricApplianceTypeEnum.TELEPHONE:
                    case IfcElectricApplianceTypeEnum.TV:
                    case IfcElectricApplianceTypeEnum.WATERHEATER:
                    case IfcElectricApplianceTypeEnum.WATERCOOLER:
                        return new Ifc4.MeasureResource.IfcLabel(System.Enum.GetName(typeof(IfcElectricApplianceTypeEnum), PredefinedType));
                }
                return !ElementType.HasValue ? null : new Ifc4.MeasureResource.IfcLabel(ElementType.Value);
            }
        }
	//##
	}
}