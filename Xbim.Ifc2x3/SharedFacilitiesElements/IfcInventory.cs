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
using Xbim.Ifc2x3.CostResource;
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
    /// Readonly interface for IfcInventory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcInventory : IIfcGroup
	{
		IfcInventoryTypeEnum @InventoryType { get; }
		IfcActorSelect @Jurisdiction { get; }
		IEnumerable<IIfcPerson> @ResponsiblePersons { get; }
		IIfcCalendarDate @LastUpdateDate { get; }
		IIfcCostValue @CurrentValue { get; }
		IIfcCostValue @OriginalValue { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IFCINVENTORY", 768)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity, IIfcInventory, IEqualityComparer<@IfcInventory>, IEquatable<@IfcInventory>
	{
		#region IIfcInventory explicit implementation
		IfcInventoryTypeEnum IIfcInventory.InventoryType { get { return @InventoryType; } }	
		IfcActorSelect IIfcInventory.Jurisdiction { get { return @Jurisdiction; } }	
		IEnumerable<IIfcPerson> IIfcInventory.ResponsiblePersons { get { return @ResponsiblePersons; } }	
		IIfcCalendarDate IIfcInventory.LastUpdateDate { get { return @LastUpdateDate; } }	
		IIfcCostValue IIfcInventory.CurrentValue { get { return @CurrentValue; } }	
		IIfcCostValue IIfcInventory.OriginalValue { get { return @OriginalValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model) : base(model) 		{ 
			Model = model; 
			_responsiblePersons = new ItemSet<IfcPerson>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum _inventoryType;
		private IfcActorSelect _jurisdiction;
		private ItemSet<IfcPerson> _responsiblePersons;
		private IfcCalendarDate _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcInventoryTypeEnum @InventoryType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _inventoryType;
				((IPersistEntity)this).Activate(false);
				return _inventoryType;
			} 
			set
			{
				SetValue( v =>  _inventoryType = v, _inventoryType, value,  "InventoryType");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jurisdiction;
				((IPersistEntity)this).Activate(false);
				return _jurisdiction;
			} 
			set
			{
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _responsiblePersons;
				((IPersistEntity)this).Activate(false);
				return _responsiblePersons;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCalendarDate @LastUpdateDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastUpdateDate;
				((IPersistEntity)this).Activate(false);
				return _lastUpdateDate;
			} 
			set
			{
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _currentValue;
				((IPersistEntity)this).Activate(false);
				return _currentValue;
			} 
			set
			{
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _originalValue;
				((IPersistEntity)this).Activate(false);
				return _originalValue;
			} 
			set
			{
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue");
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
                    _inventoryType = (IfcInventoryTypeEnum) System.Enum.Parse(typeof (IfcInventoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_jurisdiction = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					if (_responsiblePersons == null) _responsiblePersons = new ItemSet<IfcPerson>( this );
					_responsiblePersons.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_lastUpdateDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 9: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 10: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR41:                 ))) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcInventory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcInventory
            var root = (@IfcInventory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcInventory left, @IfcInventory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcInventory left, @IfcInventory right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcInventory x, @IfcInventory y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcInventory obj)
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