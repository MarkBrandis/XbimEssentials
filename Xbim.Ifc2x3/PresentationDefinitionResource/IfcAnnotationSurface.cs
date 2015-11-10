// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDefinitionResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAnnotationSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAnnotationSurface : IIfcGeometricRepresentationItem
	{
		IIfcGeometricRepresentationItem @Item { get; }
		IIfcTextureCoordinate @TextureCoordinates { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IFCANNOTATIONSURFACE", 731)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationSurface : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcAnnotationSurface, IEqualityComparer<@IfcAnnotationSurface>, IEquatable<@IfcAnnotationSurface>
	{
		#region IIfcAnnotationSurface explicit implementation
		IIfcGeometricRepresentationItem IIfcAnnotationSurface.Item { get { return @Item; } }	
		IIfcTextureCoordinate IIfcAnnotationSurface.TextureCoordinates { get { return @TextureCoordinates; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcGeometricRepresentationItem _item;
		private IfcTextureCoordinate _textureCoordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcGeometricRepresentationItem @Item 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _item;
				((IPersistEntity)this).Activate(false);
				return _item;
			} 
			set
			{
				SetValue( v =>  _item = v, _item, value,  "Item");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTextureCoordinate @TextureCoordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureCoordinates;
				((IPersistEntity)this).Activate(false);
				return _textureCoordinates;
			} 
			set
			{
				SetValue( v =>  _textureCoordinates = v, _textureCoordinates, value,  "TextureCoordinates");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_item = (IfcGeometricRepresentationItem)(value.EntityVal);
					return;
				case 1: 
					_textureCoordinates = (IfcTextureCoordinate)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR01:               ) >= 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAnnotationSurface
            var root = (@IfcAnnotationSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAnnotationSurface left, @IfcAnnotationSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAnnotationSurface left, @IfcAnnotationSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAnnotationSurface x, @IfcAnnotationSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAnnotationSurface obj)
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