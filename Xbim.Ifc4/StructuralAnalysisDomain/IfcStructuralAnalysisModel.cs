// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralAnalysisDomain;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralAnalysisModel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralAnalysisModel : IIfcSystem
	{
		IfcAnalysisModelTypeEnum @PredefinedType { get; }
		IIfcAxis2Placement3D @OrientationOf2DPlane { get; }
		IEnumerable<IIfcStructuralLoadGroup> @LoadedBy { get; }
		IEnumerable<IIfcStructuralResultGroup> @HasResults { get; }
		IIfcObjectPlacement @SharedPlacement { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALANALYSISMODEL", 1012)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralAnalysisModel : IfcSystem, IInstantiableEntity, IIfcStructuralAnalysisModel, IEqualityComparer<@IfcStructuralAnalysisModel>, IEquatable<@IfcStructuralAnalysisModel>
	{
		#region IIfcStructuralAnalysisModel explicit implementation
		IfcAnalysisModelTypeEnum IIfcStructuralAnalysisModel.PredefinedType { get { return @PredefinedType; } }	
		IIfcAxis2Placement3D IIfcStructuralAnalysisModel.OrientationOf2DPlane { get { return @OrientationOf2DPlane; } }	
		IEnumerable<IIfcStructuralLoadGroup> IIfcStructuralAnalysisModel.LoadedBy { get { return @LoadedBy; } }	
		IEnumerable<IIfcStructuralResultGroup> IIfcStructuralAnalysisModel.HasResults { get { return @HasResults; } }	
		IIfcObjectPlacement IIfcStructuralAnalysisModel.SharedPlacement { get { return @SharedPlacement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralAnalysisModel(IModel model) : base(model) 		{ 
			Model = model; 
			_loadedBy = new OptionalItemSet<IfcStructuralLoadGroup>( this, 0 );
			_hasResults = new OptionalItemSet<IfcStructuralResultGroup>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcAnalysisModelTypeEnum _predefinedType;
		private IfcAxis2Placement3D _orientationOf2DPlane;
		private OptionalItemSet<IfcStructuralLoadGroup> _loadedBy;
		private OptionalItemSet<IfcStructuralResultGroup> _hasResults;
		private IfcObjectPlacement _sharedPlacement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcAnalysisModelTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @OrientationOf2DPlane 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orientationOf2DPlane;
				((IPersistEntity)this).Activate(false);
				return _orientationOf2DPlane;
			} 
			set
			{
				SetValue( v =>  _orientationOf2DPlane = v, _orientationOf2DPlane, value,  "OrientationOf2DPlane");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcStructuralLoadGroup> @LoadedBy 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _loadedBy;
				((IPersistEntity)this).Activate(false);
				return _loadedBy;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcStructuralResultGroup> @HasResults 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasResults;
				((IPersistEntity)this).Activate(false);
				return _hasResults;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @SharedPlacement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sharedPlacement;
				((IPersistEntity)this).Activate(false);
				return _sharedPlacement;
			} 
			set
			{
				SetValue( v =>  _sharedPlacement = v, _sharedPlacement, value,  "SharedPlacement");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _predefinedType = (IfcAnalysisModelTypeEnum) System.Enum.Parse(typeof (IfcAnalysisModelTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_orientationOf2DPlane = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 7: 
					if (_loadedBy == null) _loadedBy = new OptionalItemSet<IfcStructuralLoadGroup>( this );
					_loadedBy.InternalAdd((IfcStructuralLoadGroup)value.EntityVal);
					return;
				case 8: 
					if (_hasResults == null) _hasResults = new OptionalItemSet<IfcStructuralResultGroup>( this );
					_hasResults.InternalAdd((IfcStructuralResultGroup)value.EntityVal);
					return;
				case 9: 
					_sharedPlacement = (IfcObjectPlacement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*HasObjectType:	HasObjectType : (PredefinedType <> IfcAnalysisModelTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralAnalysisModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralAnalysisModel
            var root = (@IfcStructuralAnalysisModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralAnalysisModel left, @IfcStructuralAnalysisModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralAnalysisModel left, @IfcStructuralAnalysisModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralAnalysisModel x, @IfcStructuralAnalysisModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralAnalysisModel obj)
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