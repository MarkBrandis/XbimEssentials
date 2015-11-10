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
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDoorStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDoorStyle : IIfcTypeProduct
	{
		IfcDoorStyleOperationEnum @OperationType { get; }
		IfcDoorStyleConstructionEnum @ConstructionType { get; }
		bool @ParameterTakesPrecedence { get; }
		bool @Sizeable { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCDOORSTYLE", 492)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorStyle : IfcTypeProduct, IInstantiableEntity, IIfcDoorStyle, IEqualityComparer<@IfcDoorStyle>, IEquatable<@IfcDoorStyle>
	{
		#region IIfcDoorStyle explicit implementation
		IfcDoorStyleOperationEnum IIfcDoorStyle.OperationType { get { return @OperationType; } }	
		IfcDoorStyleConstructionEnum IIfcDoorStyle.ConstructionType { get { return @ConstructionType; } }	
		bool IIfcDoorStyle.ParameterTakesPrecedence { get { return @ParameterTakesPrecedence; } }	
		bool IIfcDoorStyle.Sizeable { get { return @Sizeable; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDoorStyleOperationEnum _operationType;
		private IfcDoorStyleConstructionEnum _constructionType;
		private bool _parameterTakesPrecedence;
		private bool _sizeable;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorStyleOperationEnum @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorStyleConstructionEnum @ConstructionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _constructionType;
				((IPersistEntity)this).Activate(false);
				return _constructionType;
			} 
			set
			{
				SetValue( v =>  _constructionType = v, _constructionType, value,  "ConstructionType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parameterTakesPrecedence;
				((IPersistEntity)this).Activate(false);
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Sizeable 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sizeable;
				((IPersistEntity)this).Activate(false);
				return _sizeable;
			} 
			set
			{
				SetValue( v =>  _sizeable = v, _sizeable, value,  "Sizeable");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _operationType = (IfcDoorStyleOperationEnum) System.Enum.Parse(typeof (IfcDoorStyleOperationEnum), value.EnumVal, true);
					return;
				case 9: 
                    _constructionType = (IfcDoorStyleConstructionEnum) System.Enum.Parse(typeof (IfcDoorStyleConstructionEnum), value.EnumVal, true);
					return;
				case 10: 
					_parameterTakesPrecedence = value.BooleanVal;
					return;
				case 11: 
					_sizeable = value.BooleanVal;
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
        public bool Equals(@IfcDoorStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDoorStyle
            var root = (@IfcDoorStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDoorStyle left, @IfcDoorStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDoorStyle left, @IfcDoorStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDoorStyle x, @IfcDoorStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDoorStyle obj)
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