// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialPropertyResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFuelProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFuelProperties : IIfcMaterialProperties
	{
		IfcThermodynamicTemperatureMeasure? @CombustionTemperature { get; }
		IfcPositiveRatioMeasure? @CarbonContent { get; }
		IfcHeatingValueMeasure? @LowerHeatingValue { get; }
		IfcHeatingValueMeasure? @HigherHeatingValue { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IFCFUELPROPERTIES", 715)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFuelProperties : IfcMaterialProperties, IInstantiableEntity, IIfcFuelProperties, IEqualityComparer<@IfcFuelProperties>, IEquatable<@IfcFuelProperties>
	{
		#region IIfcFuelProperties explicit implementation
		IfcThermodynamicTemperatureMeasure? IIfcFuelProperties.CombustionTemperature { get { return @CombustionTemperature; } }	
		IfcPositiveRatioMeasure? IIfcFuelProperties.CarbonContent { get { return @CarbonContent; } }	
		IfcHeatingValueMeasure? IIfcFuelProperties.LowerHeatingValue { get { return @LowerHeatingValue; } }	
		IfcHeatingValueMeasure? IIfcFuelProperties.HigherHeatingValue { get { return @HigherHeatingValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFuelProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _combustionTemperature;
		private IfcPositiveRatioMeasure? _carbonContent;
		private IfcHeatingValueMeasure? _lowerHeatingValue;
		private IfcHeatingValueMeasure? _higherHeatingValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @CombustionTemperature 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _combustionTemperature;
				((IPersistEntity)this).Activate(false);
				return _combustionTemperature;
			} 
			set
			{
				SetValue( v =>  _combustionTemperature = v, _combustionTemperature, value,  "CombustionTemperature");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveRatioMeasure? @CarbonContent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _carbonContent;
				((IPersistEntity)this).Activate(false);
				return _carbonContent;
			} 
			set
			{
				SetValue( v =>  _carbonContent = v, _carbonContent, value,  "CarbonContent");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcHeatingValueMeasure? @LowerHeatingValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerHeatingValue;
				((IPersistEntity)this).Activate(false);
				return _lowerHeatingValue;
			} 
			set
			{
				SetValue( v =>  _lowerHeatingValue = v, _lowerHeatingValue, value,  "LowerHeatingValue");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcHeatingValueMeasure? @HigherHeatingValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _higherHeatingValue;
				((IPersistEntity)this).Activate(false);
				return _higherHeatingValue;
			} 
			set
			{
				SetValue( v =>  _higherHeatingValue = v, _higherHeatingValue, value,  "HigherHeatingValue");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_combustionTemperature = value.RealVal;
					return;
				case 2: 
					_carbonContent = value.RealVal;
					return;
				case 3: 
					_lowerHeatingValue = value.RealVal;
					return;
				case 4: 
					_higherHeatingValue = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFuelProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFuelProperties
            var root = (@IfcFuelProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFuelProperties left, @IfcFuelProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFuelProperties left, @IfcFuelProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFuelProperties x, @IfcFuelProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFuelProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}