// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
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
    /// Readonly interface for IfcDerivedProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDerivedProfileDef : IIfcProfileDef
	{
		IIfcProfileDef @ParentProfile { get; }
		IIfcCartesianTransformationOperator2D @Operator { get; }
		IfcLabel? @Label { get; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCDERIVEDPROFILEDEF", 560)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDerivedProfileDef : IfcProfileDef, IInstantiableEntity, IIfcDerivedProfileDef, IEqualityComparer<@IfcDerivedProfileDef>, IEquatable<@IfcDerivedProfileDef>
	{
		#region IIfcDerivedProfileDef explicit implementation
		IIfcProfileDef IIfcDerivedProfileDef.ParentProfile { get { return @ParentProfile; } }	
		IIfcCartesianTransformationOperator2D IIfcDerivedProfileDef.Operator { get { return @Operator; } }	
		IfcLabel? IIfcDerivedProfileDef.Label { get { return @Label; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _parentProfile;
		private IfcCartesianTransformationOperator2D _operator;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @ParentProfile 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parentProfile;
				((IPersistEntity)this).Activate(false);
				return _parentProfile;
			} 
			set
			{
				SetValue( v =>  _parentProfile = v, _parentProfile, value,  "ParentProfile");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public virtual IfcCartesianTransformationOperator2D @Operator 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operator;
				((IPersistEntity)this).Activate(false);
				return _operator;
			} 
			set
			{
				SetValue( v =>  _operator = v, _operator, value,  "Operator");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _label;
				((IPersistEntity)this).Activate(false);
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label");
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
					_parentProfile = (IfcProfileDef)(value.EntityVal);
					return;
				case 3: 
					_operator = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				case 4: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*InvariantProfileType:	InvariantProfileType : SELF\IfcProfileDef.ProfileType = ParentProfile.ProfileType;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDerivedProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDerivedProfileDef
            var root = (@IfcDerivedProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDerivedProfileDef left, @IfcDerivedProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDerivedProfileDef left, @IfcDerivedProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDerivedProfileDef x, @IfcDerivedProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDerivedProfileDef obj)
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