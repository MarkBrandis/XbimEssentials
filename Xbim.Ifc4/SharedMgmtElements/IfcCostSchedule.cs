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
using Xbim.Ifc4.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedMgmtElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCostSchedule
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCostSchedule : IIfcControl
	{
		IfcCostScheduleTypeEnum? @PredefinedType { get; }
		IfcLabel? @Status { get; }
		IfcDateTime? @SubmittedOn { get; }
		IfcDateTime? @UpdateDate { get; }
	
	}
}

namespace Xbim.Ifc4.SharedMgmtElements
{
	[ExpressType("IFCCOSTSCHEDULE", 539)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostSchedule : IfcControl, IInstantiableEntity, IIfcCostSchedule, IEqualityComparer<@IfcCostSchedule>, IEquatable<@IfcCostSchedule>
	{
		#region IIfcCostSchedule explicit implementation
		IfcCostScheduleTypeEnum? IIfcCostSchedule.PredefinedType { get { return @PredefinedType; } }	
		IfcLabel? IIfcCostSchedule.Status { get { return @Status; } }	
		IfcDateTime? IIfcCostSchedule.SubmittedOn { get { return @SubmittedOn; } }	
		IfcDateTime? IIfcCostSchedule.UpdateDate { get { return @UpdateDate; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostSchedule(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCostScheduleTypeEnum? _predefinedType;
		private IfcLabel? _status;
		private IfcDateTime? _submittedOn;
		private IfcDateTime? _updateDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcCostScheduleTypeEnum? @PredefinedType 
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
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @SubmittedOn 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _submittedOn;
				((IPersistEntity)this).Activate(false);
				return _submittedOn;
			} 
			set
			{
				SetValue( v =>  _submittedOn = v, _submittedOn, value,  "SubmittedOn");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDateTime? @UpdateDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _updateDate;
				((IPersistEntity)this).Activate(false);
				return _updateDate;
			} 
			set
			{
				SetValue( v =>  _updateDate = v, _updateDate, value,  "UpdateDate");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcCostScheduleTypeEnum) System.Enum.Parse(typeof (IfcCostScheduleTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_status = value.StringVal;
					return;
				case 8: 
					_submittedOn = value.StringVal;
					return;
				case 9: 
					_updateDate = value.StringVal;
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
        public bool Equals(@IfcCostSchedule other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCostSchedule
            var root = (@IfcCostSchedule)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCostSchedule left, @IfcCostSchedule right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCostSchedule left, @IfcCostSchedule right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCostSchedule x, @IfcCostSchedule y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCostSchedule obj)
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