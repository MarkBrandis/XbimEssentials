// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PropertyResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyBoundedValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyBoundedValue : IIfcSimpleProperty
	{
		IfcValue @UpperBoundValue { get; }
		IfcValue @LowerBoundValue { get; }
		IfcUnit @Unit { get; }
	
	}
}

namespace Xbim.Ifc2x3.PropertyResource
{
	[ExpressType("IFCPROPERTYBOUNDEDVALUE", 3)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyBoundedValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyBoundedValue, IEqualityComparer<@IfcPropertyBoundedValue>, IEquatable<@IfcPropertyBoundedValue>
	{
		#region IIfcPropertyBoundedValue explicit implementation
		IfcValue IIfcPropertyBoundedValue.UpperBoundValue { get { return @UpperBoundValue; } }	
		IfcValue IIfcPropertyBoundedValue.LowerBoundValue { get { return @LowerBoundValue; } }	
		IfcUnit IIfcPropertyBoundedValue.Unit { get { return @Unit; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyBoundedValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _upperBoundValue;
		private IfcValue _lowerBoundValue;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @UpperBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _upperBoundValue;
				((IPersistEntity)this).Activate(false);
				return _upperBoundValue;
			} 
			set
			{
				SetValue( v =>  _upperBoundValue = v, _upperBoundValue, value,  "UpperBoundValue");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @LowerBoundValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lowerBoundValue;
				((IPersistEntity)this).Activate(false);
				return _lowerBoundValue;
			} 
			set
			{
				SetValue( v =>  _lowerBoundValue = v, _lowerBoundValue, value,  "LowerBoundValue");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_upperBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_lowerBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 4: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));*/
		/*WR22:	WR22 : EXISTS(UpperBoundValue) OR EXISTS(LowerBoundValue);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyBoundedValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyBoundedValue
            var root = (@IfcPropertyBoundedValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyBoundedValue left, @IfcPropertyBoundedValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyBoundedValue x, @IfcPropertyBoundedValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyBoundedValue obj)
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