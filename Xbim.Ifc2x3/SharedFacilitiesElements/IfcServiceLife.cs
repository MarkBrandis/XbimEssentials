// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedFacilitiesElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcServiceLife
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcServiceLife : IIfcControl
	{
		IfcServiceLifeTypeEnum @ServiceLifeType { get; }
		IfcTimeMeasure @ServiceLifeDuration { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IFCSERVICELIFE", 769)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcServiceLife : IfcControl, IInstantiableEntity, IIfcServiceLife, IEqualityComparer<@IfcServiceLife>, IEquatable<@IfcServiceLife>
	{
		#region IIfcServiceLife explicit implementation
		IfcServiceLifeTypeEnum IIfcServiceLife.ServiceLifeType { get { return @ServiceLifeType; } }	
		IfcTimeMeasure IIfcServiceLife.ServiceLifeDuration { get { return @ServiceLifeDuration; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLife(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcServiceLifeTypeEnum _serviceLifeType;
		private IfcTimeMeasure _serviceLifeDuration;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcServiceLifeTypeEnum @ServiceLifeType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _serviceLifeType;
				((IPersistEntity)this).Activate(false);
				return _serviceLifeType;
			} 
			set
			{
				SetValue( v =>  _serviceLifeType = v, _serviceLifeType, value,  "ServiceLifeType");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure @ServiceLifeDuration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _serviceLifeDuration;
				((IPersistEntity)this).Activate(false);
				return _serviceLifeDuration;
			} 
			set
			{
				SetValue( v =>  _serviceLifeDuration = v, _serviceLifeDuration, value,  "ServiceLifeDuration");
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
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _serviceLifeType = (IfcServiceLifeTypeEnum) System.Enum.Parse(typeof (IfcServiceLifeTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_serviceLifeDuration = value.RealVal;
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
        public bool Equals(@IfcServiceLife other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcServiceLife
            var root = (@IfcServiceLife)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcServiceLife left, @IfcServiceLife right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcServiceLife left, @IfcServiceLife right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcServiceLife x, @IfcServiceLife y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcServiceLife obj)
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