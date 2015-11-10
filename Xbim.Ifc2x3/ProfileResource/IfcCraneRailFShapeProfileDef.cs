// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCraneRailFShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCraneRailFShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @OverallHeight { get; }
		IfcPositiveLengthMeasure @HeadWidth { get; }
		IfcPositiveLengthMeasure? @Radius { get; }
		IfcPositiveLengthMeasure @HeadDepth2 { get; }
		IfcPositiveLengthMeasure @HeadDepth3 { get; }
		IfcPositiveLengthMeasure @WebThickness { get; }
		IfcPositiveLengthMeasure @BaseDepth1 { get; }
		IfcPositiveLengthMeasure @BaseDepth2 { get; }
		IfcPositiveLengthMeasure? @CentreOfGravityInY { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IFCCRANERAILFSHAPEPROFILEDEF", 112)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcCraneRailFShapeProfileDef, IEqualityComparer<@IfcCraneRailFShapeProfileDef>, IEquatable<@IfcCraneRailFShapeProfileDef>
	{
		#region IIfcCraneRailFShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.OverallHeight { get { return @OverallHeight; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.HeadWidth { get { return @HeadWidth; } }	
		IfcPositiveLengthMeasure? IIfcCraneRailFShapeProfileDef.Radius { get { return @Radius; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.HeadDepth2 { get { return @HeadDepth2; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.HeadDepth3 { get { return @HeadDepth3; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.WebThickness { get { return @WebThickness; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.BaseDepth1 { get { return @BaseDepth1; } }	
		IfcPositiveLengthMeasure IIfcCraneRailFShapeProfileDef.BaseDepth2 { get { return @BaseDepth2; } }	
		IfcPositiveLengthMeasure? IIfcCraneRailFShapeProfileDef.CentreOfGravityInY { get { return @CentreOfGravityInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCraneRailFShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallHeight;
		private IfcPositiveLengthMeasure _headWidth;
		private IfcPositiveLengthMeasure? _radius;
		private IfcPositiveLengthMeasure _headDepth2;
		private IfcPositiveLengthMeasure _headDepth3;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _baseDepth1;
		private IfcPositiveLengthMeasure _baseDepth2;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallHeight;
				((IPersistEntity)this).Activate(false);
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headWidth;
				((IPersistEntity)this).Activate(false);
				return _headWidth;
			} 
			set
			{
				SetValue( v =>  _headWidth = v, _headWidth, value,  "HeadWidth");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Radius 
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
		public IfcPositiveLengthMeasure @HeadDepth2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headDepth2;
				((IPersistEntity)this).Activate(false);
				return _headDepth2;
			} 
			set
			{
				SetValue( v =>  _headDepth2 = v, _headDepth2, value,  "HeadDepth2");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadDepth3 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headDepth3;
				((IPersistEntity)this).Activate(false);
				return _headDepth3;
			} 
			set
			{
				SetValue( v =>  _headDepth3 = v, _headDepth3, value,  "HeadDepth3");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _webThickness;
				((IPersistEntity)this).Activate(false);
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseDepth1;
				((IPersistEntity)this).Activate(false);
				return _baseDepth1;
			} 
			set
			{
				SetValue( v =>  _baseDepth1 = v, _baseDepth1, value,  "BaseDepth1");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseDepth2;
				((IPersistEntity)this).Activate(false);
				return _baseDepth2;
			} 
			set
			{
				SetValue( v =>  _baseDepth2 = v, _baseDepth2, value,  "BaseDepth2");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInY;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
					_overallHeight = value.RealVal;
					return;
				case 4: 
					_headWidth = value.RealVal;
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_headDepth2 = value.RealVal;
					return;
				case 7: 
					_headDepth3 = value.RealVal;
					return;
				case 8: 
					_webThickness = value.RealVal;
					return;
				case 9: 
					_baseDepth1 = value.RealVal;
					return;
				case 10: 
					_baseDepth2 = value.RealVal;
					return;
				case 11: 
					_centreOfGravityInY = value.RealVal;
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
        public bool Equals(@IfcCraneRailFShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCraneRailFShapeProfileDef
            var root = (@IfcCraneRailFShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCraneRailFShapeProfileDef left, @IfcCraneRailFShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCraneRailFShapeProfileDef left, @IfcCraneRailFShapeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCraneRailFShapeProfileDef x, @IfcCraneRailFShapeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCraneRailFShapeProfileDef obj)
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