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
using Xbim.Ifc2x3.PresentationResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPlanarBox
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPlanarBox : IIfcPlanarExtent
	{
		IfcAxis2Placement @Placement { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationResource
{
	[ExpressType("IFCPLANARBOX", 762)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPlanarBox : IfcPlanarExtent, IInstantiableEntity, IIfcPlanarBox, IEqualityComparer<@IfcPlanarBox>, IEquatable<@IfcPlanarBox>
	{
		#region IIfcPlanarBox explicit implementation
		IfcAxis2Placement IIfcPlanarBox.Placement { get { return @Placement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlanarBox(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _placement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @Placement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _placement;
				((IPersistEntity)this).Activate(false);
				return _placement;
			} 
			set
			{
				SetValue( v =>  _placement = v, _placement, value,  "Placement");
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
					_placement = (IfcAxis2Placement)(value.EntityVal);
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
        public bool Equals(@IfcPlanarBox other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPlanarBox
            var root = (@IfcPlanarBox)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPlanarBox left, @IfcPlanarBox right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPlanarBox left, @IfcPlanarBox right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPlanarBox x, @IfcPlanarBox y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPlanarBox obj)
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