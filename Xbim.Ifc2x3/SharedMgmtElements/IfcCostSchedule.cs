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
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedMgmtElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCostSchedule
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCostSchedule : IIfcControl
	{
		IfcActorSelect @SubmittedBy { get; }
		IfcActorSelect @PreparedBy { get; }
		IfcDateTimeSelect @SubmittedOn { get; }
		IfcLabel? @Status { get; }
		IEnumerable<IfcActorSelect> @TargetUsers { get; }
		IfcDateTimeSelect @UpdateDate { get; }
		IfcIdentifier @ID { get; }
		IfcCostScheduleTypeEnum @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IFCCOSTSCHEDULE", 695)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostSchedule : IfcControl, IInstantiableEntity, IIfcCostSchedule, IEqualityComparer<@IfcCostSchedule>, IEquatable<@IfcCostSchedule>
	{
		#region IIfcCostSchedule explicit implementation
		IfcActorSelect IIfcCostSchedule.SubmittedBy { get { return @SubmittedBy; } }	
		IfcActorSelect IIfcCostSchedule.PreparedBy { get { return @PreparedBy; } }	
		IfcDateTimeSelect IIfcCostSchedule.SubmittedOn { get { return @SubmittedOn; } }	
		IfcLabel? IIfcCostSchedule.Status { get { return @Status; } }	
		IEnumerable<IfcActorSelect> IIfcCostSchedule.TargetUsers { get { return @TargetUsers; } }	
		IfcDateTimeSelect IIfcCostSchedule.UpdateDate { get { return @UpdateDate; } }	
		IfcIdentifier IIfcCostSchedule.ID { get { return @ID; } }	
		IfcCostScheduleTypeEnum IIfcCostSchedule.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostSchedule(IModel model) : base(model) 		{ 
			Model = model; 
			_targetUsers = new OptionalItemSet<IfcActorSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcActorSelect _submittedBy;
		private IfcActorSelect _preparedBy;
		private IfcDateTimeSelect _submittedOn;
		private IfcLabel? _status;
		private OptionalItemSet<IfcActorSelect> _targetUsers;
		private IfcDateTimeSelect _updateDate;
		private IfcIdentifier _iD;
		private IfcCostScheduleTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @SubmittedBy 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _submittedBy;
				((IPersistEntity)this).Activate(false);
				return _submittedBy;
			} 
			set
			{
				SetValue( v =>  _submittedBy = v, _submittedBy, value,  "SubmittedBy");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @PreparedBy 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _preparedBy;
				((IPersistEntity)this).Activate(false);
				return _preparedBy;
			} 
			set
			{
				SetValue( v =>  _preparedBy = v, _preparedBy, value,  "PreparedBy");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @SubmittedOn 
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
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
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
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcActorSelect> @TargetUsers 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _targetUsers;
				((IPersistEntity)this).Activate(false);
				return _targetUsers;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDateTimeSelect @UpdateDate 
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
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @ID 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _iD;
				((IPersistEntity)this).Activate(false);
				return _iD;
			} 
			set
			{
				SetValue( v =>  _iD = v, _iD, value,  "ID");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcCostScheduleTypeEnum @PredefinedType 
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
					_submittedBy = (IfcActorSelect)(value.EntityVal);
					return;
				case 6: 
					_preparedBy = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					_submittedOn = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 8: 
					_status = value.StringVal;
					return;
				case 9: 
					if (_targetUsers == null) _targetUsers = new OptionalItemSet<IfcActorSelect>( this );
					_targetUsers.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_updateDate = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 11: 
					_iD = value.StringVal;
					return;
				case 12: 
                    _predefinedType = (IfcCostScheduleTypeEnum) System.Enum.Parse(typeof (IfcCostScheduleTypeEnum), value.EnumVal, true);
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