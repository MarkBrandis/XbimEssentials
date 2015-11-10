// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProfileProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProfileProperties : IIfcExtendedProperties
	{
		IIfcProfileDef @ProfileDefinition { get; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCPROFILEPROPERTIES", 842)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProfileProperties : IfcExtendedProperties, IInstantiableEntity, IIfcProfileProperties, IEqualityComparer<@IfcProfileProperties>, IEquatable<@IfcProfileProperties>
	{
		#region IIfcProfileProperties explicit implementation
		IIfcProfileDef IIfcProfileProperties.ProfileDefinition { get { return @ProfileDefinition; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProfileProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _profileDefinition;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @ProfileDefinition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _profileDefinition;
				((IPersistEntity)this).Activate(false);
				return _profileDefinition;
			} 
			set
			{
				SetValue( v =>  _profileDefinition = v, _profileDefinition, value,  "ProfileDefinition");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_profileDefinition = (IfcProfileDef)(value.EntityVal);
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
        public bool Equals(@IfcProfileProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProfileProperties
            var root = (@IfcProfileProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProfileProperties left, @IfcProfileProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProfileProperties left, @IfcProfileProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProfileProperties x, @IfcProfileProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProfileProperties obj)
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