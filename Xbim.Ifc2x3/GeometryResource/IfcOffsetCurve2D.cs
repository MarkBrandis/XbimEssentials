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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOffsetCurve2D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOffsetCurve2D : IIfcCurve
	{
		IIfcCurve @BasisCurve { get; }
		IfcLengthMeasure @Distance { get; }
		bool? @SelfIntersect { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCOFFSETCURVE2D", 687)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOffsetCurve2D : IfcCurve, IInstantiableEntity, IIfcOffsetCurve2D, IEqualityComparer<@IfcOffsetCurve2D>, IEquatable<@IfcOffsetCurve2D>
	{
		#region IIfcOffsetCurve2D explicit implementation
		IIfcCurve IIfcOffsetCurve2D.BasisCurve { get { return @BasisCurve; } }	
		IfcLengthMeasure IIfcOffsetCurve2D.Distance { get { return @Distance; } }	
		bool? IIfcOffsetCurve2D.SelfIntersect { get { return @SelfIntersect; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOffsetCurve2D(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private IfcLengthMeasure _distance;
		private bool? _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisCurve;
				((IPersistEntity)this).Activate(false);
				return _basisCurve;
			} 
			set
			{
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Distance 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _distance;
				((IPersistEntity)this).Activate(false);
				return _distance;
			} 
			set
			{
				SetValue( v =>  _distance = v, _distance, value,  "Distance");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool? @SelfIntersect 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfIntersect;
				((IPersistEntity)this).Activate(false);
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_distance = value.RealVal;
					return;
				case 2: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : BasisCurve.Dim = 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOffsetCurve2D other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOffsetCurve2D
            var root = (@IfcOffsetCurve2D)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOffsetCurve2D left, @IfcOffsetCurve2D right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOffsetCurve2D left, @IfcOffsetCurve2D right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOffsetCurve2D x, @IfcOffsetCurve2D y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOffsetCurve2D obj)
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