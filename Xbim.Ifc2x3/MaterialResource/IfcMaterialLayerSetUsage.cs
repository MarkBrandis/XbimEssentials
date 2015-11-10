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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialLayerSetUsage
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialLayerSetUsage : IPersistEntity, IfcMaterialSelect
	{
		IIfcMaterialLayerSet @ForLayerSet { get; }
		IfcLayerSetDirectionEnum @LayerSetDirection { get; }
		IfcDirectionSenseEnum @DirectionSense { get; }
		IfcLengthMeasure @OffsetFromReferenceLine { get; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialResource
{
	[IndexedClass]
	[ExpressType("IFCMATERIALLAYERSETUSAGE", 165)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerSetUsage : INotifyPropertyChanged, IInstantiableEntity, IIfcMaterialLayerSetUsage, IEqualityComparer<@IfcMaterialLayerSetUsage>, IEquatable<@IfcMaterialLayerSetUsage>
	{
		#region IIfcMaterialLayerSetUsage explicit implementation
		IIfcMaterialLayerSet IIfcMaterialLayerSetUsage.ForLayerSet { get { return @ForLayerSet; } }	
		IfcLayerSetDirectionEnum IIfcMaterialLayerSetUsage.LayerSetDirection { get { return @LayerSetDirection; } }	
		IfcDirectionSenseEnum IIfcMaterialLayerSetUsage.DirectionSense { get { return @DirectionSense; } }	
		IfcLengthMeasure IIfcMaterialLayerSetUsage.OffsetFromReferenceLine { get { return @OffsetFromReferenceLine; } }	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerSetUsage(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialLayerSet _forLayerSet;
		private IfcLayerSetDirectionEnum _layerSetDirection;
		private IfcDirectionSenseEnum _directionSense;
		private IfcLengthMeasure _offsetFromReferenceLine;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterialLayerSet @ForLayerSet 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _forLayerSet;
				((IPersistEntity)this).Activate(false);
				return _forLayerSet;
			} 
			set
			{
				SetValue( v =>  _forLayerSet = v, _forLayerSet, value,  "ForLayerSet");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcLayerSetDirectionEnum @LayerSetDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _layerSetDirection;
				((IPersistEntity)this).Activate(false);
				return _layerSetDirection;
			} 
			set
			{
				SetValue( v =>  _layerSetDirection = v, _layerSetDirection, value,  "LayerSetDirection");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDirectionSenseEnum @DirectionSense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _directionSense;
				((IPersistEntity)this).Activate(false);
				return _directionSense;
			} 
			set
			{
				SetValue( v =>  _directionSense = v, _directionSense, value,  "DirectionSense");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @OffsetFromReferenceLine 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _offsetFromReferenceLine;
				((IPersistEntity)this).Activate(false);
				return _offsetFromReferenceLine;
			} 
			set
			{
				SetValue( v =>  _offsetFromReferenceLine = v, _offsetFromReferenceLine, value,  "OffsetFromReferenceLine");
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_forLayerSet = (IfcMaterialLayerSet)(value.EntityVal);
					return;
				case 1: 
                    _layerSetDirection = (IfcLayerSetDirectionEnum) System.Enum.Parse(typeof (IfcLayerSetDirectionEnum), value.EnumVal, true);
					return;
				case 2: 
                    _directionSense = (IfcDirectionSenseEnum) System.Enum.Parse(typeof (IfcDirectionSenseEnum), value.EnumVal, true);
					return;
				case 3: 
					_offsetFromReferenceLine = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayerSetUsage other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialLayerSetUsage
            var root = (@IfcMaterialLayerSetUsage)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialLayerSetUsage left, @IfcMaterialLayerSetUsage right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialLayerSetUsage left, @IfcMaterialLayerSetUsage right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialLayerSetUsage x, @IfcMaterialLayerSetUsage y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialLayerSetUsage obj)
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