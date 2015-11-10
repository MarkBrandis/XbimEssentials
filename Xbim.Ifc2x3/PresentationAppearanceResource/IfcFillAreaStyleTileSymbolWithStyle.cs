// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFillAreaStyleTileSymbolWithStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyleTileSymbolWithStyle : IIfcGeometricRepresentationItem, IfcFillAreaStyleTileShapeSelect
	{
		IIfcAnnotationSymbolOccurrence @Symbol { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCFILLAREASTYLETILESYMBOLWITHSTYLE", 726)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFillAreaStyleTileSymbolWithStyle, IEqualityComparer<@IfcFillAreaStyleTileSymbolWithStyle>, IEquatable<@IfcFillAreaStyleTileSymbolWithStyle>
	{
		#region IIfcFillAreaStyleTileSymbolWithStyle explicit implementation
		IIfcAnnotationSymbolOccurrence IIfcFillAreaStyleTileSymbolWithStyle.Symbol { get { return @Symbol; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTileSymbolWithStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAnnotationSymbolOccurrence _symbol;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAnnotationSymbolOccurrence @Symbol 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _symbol;
				((IPersistEntity)this).Activate(false);
				return _symbol;
			} 
			set
			{
				SetValue( v =>  _symbol = v, _symbol, value,  "Symbol");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_symbol = (IfcAnnotationSymbolOccurrence)(value.EntityVal);
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
        public bool Equals(@IfcFillAreaStyleTileSymbolWithStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFillAreaStyleTileSymbolWithStyle
            var root = (@IfcFillAreaStyleTileSymbolWithStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFillAreaStyleTileSymbolWithStyle left, @IfcFillAreaStyleTileSymbolWithStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFillAreaStyleTileSymbolWithStyle left, @IfcFillAreaStyleTileSymbolWithStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFillAreaStyleTileSymbolWithStyle x, @IfcFillAreaStyleTileSymbolWithStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFillAreaStyleTileSymbolWithStyle obj)
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