// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProcessExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEventType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEventType : IIfcTypeProcess
	{
		IfcEventTypeEnum @PredefinedType { get; }
		IfcEventTriggerTypeEnum @EventTriggerType { get; }
		IfcLabel? @UserDefinedEventTriggerType { get; }
	
	}
}

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IFCEVENTTYPE", 630)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEventType : IfcTypeProcess, IInstantiableEntity, IIfcEventType, IEqualityComparer<@IfcEventType>, IEquatable<@IfcEventType>
	{
		#region IIfcEventType explicit implementation
		IfcEventTypeEnum IIfcEventType.PredefinedType { get { return @PredefinedType; } }	
		IfcEventTriggerTypeEnum IIfcEventType.EventTriggerType { get { return @EventTriggerType; } }	
		IfcLabel? IIfcEventType.UserDefinedEventTriggerType { get { return @UserDefinedEventTriggerType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEventType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEventTypeEnum _predefinedType;
		private IfcEventTriggerTypeEnum _eventTriggerType;
		private IfcLabel? _userDefinedEventTriggerType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcEventTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcEventTriggerTypeEnum @EventTriggerType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _eventTriggerType;
				((IPersistEntity)this).Activate(false);
				return _eventTriggerType;
			} 
			set
			{
				SetValue( v =>  _eventTriggerType = v, _eventTriggerType, value,  "EventTriggerType");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedEventTriggerType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedEventTriggerType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedEventTriggerType;
			} 
			set
			{
				SetValue( v =>  _userDefinedEventTriggerType = v, _userDefinedEventTriggerType, value,  "UserDefinedEventTriggerType");
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcEventTypeEnum) System.Enum.Parse(typeof (IfcEventTypeEnum), value.EnumVal, true);
					return;
				case 10: 
                    _eventTriggerType = (IfcEventTriggerTypeEnum) System.Enum.Parse(typeof (IfcEventTriggerTypeEnum), value.EnumVal, true);
					return;
				case 11: 
					_userDefinedEventTriggerType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:	CorrectPredefinedType : (PredefinedType <> IfcEventTypeEnum.USERDEFINED) OR ((PredefinedType = IfcEventTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcTypeProcess.ProcessType));*/
		/*CorrectEventTriggerType:	CorrectEventTriggerType : (EventTriggerType <> IfcEventTriggerTypeEnum.USERDEFINED) OR ((EventTriggerType = IfcEventTriggerTypeEnum.USERDEFINED) AND EXISTS(UserDefinedEventTriggerType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEventType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEventType
            var root = (@IfcEventType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEventType left, @IfcEventType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEventType left, @IfcEventType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcEventType x, @IfcEventType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcEventType obj)
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