// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFaceBasedSurfaceModel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFaceBasedSurfaceModel : IIfcGeometricRepresentationItem, IfcSurfaceOrFaceSurface
	{
		IEnumerable<IIfcConnectedFaceSet> @FbsmFaces { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCFACEBASEDSURFACEMODEL", 643)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFaceBasedSurfaceModel, IEqualityComparer<@IfcFaceBasedSurfaceModel>, IEquatable<@IfcFaceBasedSurfaceModel>
	{
		#region IIfcFaceBasedSurfaceModel explicit implementation
		IEnumerable<IIfcConnectedFaceSet> IIfcFaceBasedSurfaceModel.FbsmFaces { get { return @FbsmFaces; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFaceBasedSurfaceModel(IModel model) : base(model) 		{ 
			Model = model; 
			_fbsmFaces = new ItemSet<IfcConnectedFaceSet>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcConnectedFaceSet> _fbsmFaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcConnectedFaceSet> @FbsmFaces 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fbsmFaces;
				((IPersistEntity)this).Activate(false);
				return _fbsmFaces;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_fbsmFaces == null) _fbsmFaces = new ItemSet<IfcConnectedFaceSet>( this );
					_fbsmFaces.InternalAdd((IfcConnectedFaceSet)value.EntityVal);
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
        public bool Equals(@IfcFaceBasedSurfaceModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFaceBasedSurfaceModel
            var root = (@IfcFaceBasedSurfaceModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFaceBasedSurfaceModel left, @IfcFaceBasedSurfaceModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFaceBasedSurfaceModel left, @IfcFaceBasedSurfaceModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFaceBasedSurfaceModel x, @IfcFaceBasedSurfaceModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFaceBasedSurfaceModel obj)
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