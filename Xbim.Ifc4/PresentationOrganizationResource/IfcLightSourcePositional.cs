// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationOrganizationResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightSourcePositional
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightSourcePositional : IIfcLightSource
	{
		IIfcCartesianPoint @Position { get; }
		IfcPositiveLengthMeasure @Radius { get; }
		IfcReal @ConstantAttenuation { get; }
		IfcReal @DistanceAttenuation { get; }
		IfcReal @QuadricAttenuation { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[ExpressType("IFCLIGHTSOURCEPOSITIONAL", 733)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourcePositional : IfcLightSource, IInstantiableEntity, IIfcLightSourcePositional, IEqualityComparer<@IfcLightSourcePositional>, IEquatable<@IfcLightSourcePositional>
	{
		#region IIfcLightSourcePositional explicit implementation
		IIfcCartesianPoint IIfcLightSourcePositional.Position { get { return @Position; } }	
		IfcPositiveLengthMeasure IIfcLightSourcePositional.Radius { get { return @Radius; } }	
		IfcReal IIfcLightSourcePositional.ConstantAttenuation { get { return @ConstantAttenuation; } }	
		IfcReal IIfcLightSourcePositional.DistanceAttenuation { get { return @DistanceAttenuation; } }	
		IfcReal IIfcLightSourcePositional.QuadricAttenuation { get { return @QuadricAttenuation; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourcePositional(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _position;
		private IfcPositiveLengthMeasure _radius;
		private IfcReal _constantAttenuation;
		private IfcReal _distanceAttenuation;
		private IfcReal _quadricAttenuation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _radius;
				((IPersistEntity)this).Activate(false);
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @ConstantAttenuation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _constantAttenuation;
				((IPersistEntity)this).Activate(false);
				return _constantAttenuation;
			} 
			set
			{
				SetValue( v =>  _constantAttenuation = v, _constantAttenuation, value,  "ConstantAttenuation");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @DistanceAttenuation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _distanceAttenuation;
				((IPersistEntity)this).Activate(false);
				return _distanceAttenuation;
			} 
			set
			{
				SetValue( v =>  _distanceAttenuation = v, _distanceAttenuation, value,  "DistanceAttenuation");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal @QuadricAttenuation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _quadricAttenuation;
				((IPersistEntity)this).Activate(false);
				return _quadricAttenuation;
			} 
			set
			{
				SetValue( v =>  _quadricAttenuation = v, _quadricAttenuation, value,  "QuadricAttenuation");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_position = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_constantAttenuation = value.RealVal;
					return;
				case 7: 
					_distanceAttenuation = value.RealVal;
					return;
				case 8: 
					_quadricAttenuation = value.RealVal;
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
        public bool Equals(@IfcLightSourcePositional other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLightSourcePositional
            var root = (@IfcLightSourcePositional)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLightSourcePositional left, @IfcLightSourcePositional right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLightSourcePositional left, @IfcLightSourcePositional right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLightSourcePositional x, @IfcLightSourcePositional y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLightSourcePositional obj)
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