// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByTemplate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByTemplate : IIfcRelDefines
	{
		IEnumerable<IIfcPropertySetDefinition> @RelatedPropertySets { get; }
		IIfcPropertySetTemplate @RelatingTemplate { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELDEFINESBYTEMPLATE", 934)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByTemplate : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByTemplate, IEqualityComparer<@IfcRelDefinesByTemplate>, IEquatable<@IfcRelDefinesByTemplate>
	{
		#region IIfcRelDefinesByTemplate explicit implementation
		IEnumerable<IIfcPropertySetDefinition> IIfcRelDefinesByTemplate.RelatedPropertySets { get { return @RelatedPropertySets; } }	
		IIfcPropertySetTemplate IIfcRelDefinesByTemplate.RelatingTemplate { get { return @RelatingTemplate; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedPropertySets = new ItemSet<IfcPropertySetDefinition>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPropertySetDefinition> _relatedPropertySets;
		private IfcPropertySetTemplate _relatingTemplate;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcPropertySetDefinition> @RelatedPropertySets 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedPropertySets;
				((IPersistEntity)this).Activate(false);
				return _relatedPropertySets;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPropertySetTemplate @RelatingTemplate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingTemplate;
				((IPersistEntity)this).Activate(false);
				return _relatingTemplate;
			} 
			set
			{
				SetValue( v =>  _relatingTemplate = v, _relatingTemplate, value,  "RelatingTemplate");
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
					if (_relatedPropertySets == null) _relatedPropertySets = new ItemSet<IfcPropertySetDefinition>( this );
					_relatedPropertySets.InternalAdd((IfcPropertySetDefinition)value.EntityVal);
					return;
				case 5: 
					_relatingTemplate = (IfcPropertySetTemplate)(value.EntityVal);
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
        public bool Equals(@IfcRelDefinesByTemplate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDefinesByTemplate
            var root = (@IfcRelDefinesByTemplate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDefinesByTemplate left, @IfcRelDefinesByTemplate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDefinesByTemplate left, @IfcRelDefinesByTemplate right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelDefinesByTemplate x, @IfcRelDefinesByTemplate y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelDefinesByTemplate obj)
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