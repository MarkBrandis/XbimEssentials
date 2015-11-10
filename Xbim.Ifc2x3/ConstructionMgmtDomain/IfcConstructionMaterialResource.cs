// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstructionMgmtDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstructionMaterialResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstructionMaterialResource : IIfcConstructionResource
	{
		IEnumerable<IfcActorSelect> @Suppliers { get; }
		IfcRatioMeasure? @UsageRatio { get; }
	
	}
}

namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	[ExpressType("IFCCONSTRUCTIONMATERIALRESOURCE", 243)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConstructionMaterialResource : IfcConstructionResource, IInstantiableEntity, IIfcConstructionMaterialResource, IEqualityComparer<@IfcConstructionMaterialResource>, IEquatable<@IfcConstructionMaterialResource>
	{
		#region IIfcConstructionMaterialResource explicit implementation
		IEnumerable<IfcActorSelect> IIfcConstructionMaterialResource.Suppliers { get { return @Suppliers; } }	
		IfcRatioMeasure? IIfcConstructionMaterialResource.UsageRatio { get { return @UsageRatio; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionMaterialResource(IModel model) : base(model) 		{ 
			Model = model; 
			_suppliers = new OptionalItemSet<IfcActorSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcActorSelect> _suppliers;
		private IfcRatioMeasure? _usageRatio;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcActorSelect> @Suppliers 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _suppliers;
				((IPersistEntity)this).Activate(false);
				return _suppliers;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcRatioMeasure? @UsageRatio 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usageRatio;
				((IPersistEntity)this).Activate(false);
				return _usageRatio;
			} 
			set
			{
				SetValue( v =>  _usageRatio = v, _usageRatio, value,  "UsageRatio");
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
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					if (_suppliers == null) _suppliers = new OptionalItemSet<IfcActorSelect>( this );
					_suppliers.InternalAdd((IfcActorSelect)value.EntityVal);
					return;
				case 10: 
					_usageRatio = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(SELF\IfcResource.ResourceOf) <=1;*/
		/*WR2:            (SELF\IfcResource.ResourceOf[1].RelatedObjectsType = IfcObjectTypeEnum.PRODUCT);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstructionMaterialResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConstructionMaterialResource
            var root = (@IfcConstructionMaterialResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConstructionMaterialResource left, @IfcConstructionMaterialResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConstructionMaterialResource left, @IfcConstructionMaterialResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConstructionMaterialResource x, @IfcConstructionMaterialResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConstructionMaterialResource obj)
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