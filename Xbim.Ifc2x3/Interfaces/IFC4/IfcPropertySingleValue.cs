// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertySingleValue : IIfcPropertySingleValue
	{
		Ifc4.MeasureResource.IfcValue IIfcPropertySingleValue.NominalValue 
		{ 
			get
			{
				if (NominalValue == null) return null;
				if (NominalValue is MeasureResource.IfcVolumeMeasure) 
					return new Ifc4.MeasureResource.IfcVolumeMeasure((double)(MeasureResource.IfcVolumeMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcTimeMeasure) 
					return new Ifc4.MeasureResource.IfcTimeMeasure((double)(MeasureResource.IfcTimeMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcThermodynamicTemperatureMeasure) 
					return new Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure((double)(MeasureResource.IfcThermodynamicTemperatureMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSolidAngleMeasure) 
					return new Ifc4.MeasureResource.IfcSolidAngleMeasure((double)(MeasureResource.IfcSolidAngleMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPositiveRatioMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(MeasureResource.IfcPositiveRatioMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((double)(MeasureResource.IfcRatioMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPositivePlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)(MeasureResource.IfcPositivePlaneAngleMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcPlaneAngleMeasure((double)(MeasureResource.IfcPlaneAngleMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcParameterValue) 
					return new Ifc4.MeasureResource.IfcParameterValue((double)(MeasureResource.IfcParameterValue)NominalValue);
				if (NominalValue is MeasureResource.IfcNumericMeasure) 
					return new Ifc4.MeasureResource.IfcNumericMeasure((double)(MeasureResource.IfcNumericMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMassMeasure) 
					return new Ifc4.MeasureResource.IfcMassMeasure((double)(MeasureResource.IfcMassMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(MeasureResource.IfcPositiveLengthMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLengthMeasure) 
					return new Ifc4.MeasureResource.IfcLengthMeasure((double)(MeasureResource.IfcLengthMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricCurrentMeasure) 
					return new Ifc4.MeasureResource.IfcElectricCurrentMeasure((double)(MeasureResource.IfcElectricCurrentMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcDescriptiveMeasure) 
					return new Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(MeasureResource.IfcDescriptiveMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcCountMeasure) 
					return new Ifc4.MeasureResource.IfcCountMeasure((double)(MeasureResource.IfcCountMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcContextDependentMeasure) 
					return new Ifc4.MeasureResource.IfcContextDependentMeasure((double)(MeasureResource.IfcContextDependentMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcAreaMeasure) 
					return new Ifc4.MeasureResource.IfcAreaMeasure((double)(MeasureResource.IfcAreaMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcAmountOfSubstanceMeasure) 
					return new Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure((double)(MeasureResource.IfcAmountOfSubstanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLuminousIntensityMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousIntensityMeasure((double)(MeasureResource.IfcLuminousIntensityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(MeasureResource.IfcNormalisedRatioMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcComplexNumber) 
					return new Ifc4.MeasureResource.IfcComplexNumber((List<double>)(MeasureResource.IfcComplexNumber)NominalValue);
				if (NominalValue is MeasureResource.IfcInteger) 
					return new Ifc4.MeasureResource.IfcInteger((long)(MeasureResource.IfcInteger)NominalValue);
				if (NominalValue is MeasureResource.IfcReal) 
					return new Ifc4.MeasureResource.IfcReal((double)(MeasureResource.IfcReal)NominalValue);
				if (NominalValue is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((bool)(MeasureResource.IfcBoolean)NominalValue);
				if (NominalValue is MeasureResource.IfcIdentifier) 
					return new Ifc4.MeasureResource.IfcIdentifier((string)(MeasureResource.IfcIdentifier)NominalValue);
				if (NominalValue is MeasureResource.IfcText) 
					return new Ifc4.MeasureResource.IfcText((string)(MeasureResource.IfcText)NominalValue);
				if (NominalValue is MeasureResource.IfcLabel) 
					return new Ifc4.MeasureResource.IfcLabel((string)(MeasureResource.IfcLabel)NominalValue);
				if (NominalValue is MeasureResource.IfcLogical) 
					return new Ifc4.MeasureResource.IfcLogical((bool?)(MeasureResource.IfcLogical)NominalValue);
				if (NominalValue is MeasureResource.IfcVolumetricFlowRateMeasure) 
					return new Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure((double)(MeasureResource.IfcVolumetricFlowRateMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcTimeStamp) 
					return new Ifc4.DateTimeResource.IfcTimeStamp((long)(MeasureResource.IfcTimeStamp)NominalValue);
				if (NominalValue is MeasureResource.IfcThermalTransmittanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalTransmittanceMeasure((double)(MeasureResource.IfcThermalTransmittanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcThermalResistanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalResistanceMeasure((double)(MeasureResource.IfcThermalResistanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcThermalAdmittanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalAdmittanceMeasure((double)(MeasureResource.IfcThermalAdmittanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPressureMeasure) 
					return new Ifc4.MeasureResource.IfcPressureMeasure((double)(MeasureResource.IfcPressureMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPowerMeasure) 
					return new Ifc4.MeasureResource.IfcPowerMeasure((double)(MeasureResource.IfcPowerMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMassFlowRateMeasure) 
					return new Ifc4.MeasureResource.IfcMassFlowRateMeasure((double)(MeasureResource.IfcMassFlowRateMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMassDensityMeasure) 
					return new Ifc4.MeasureResource.IfcMassDensityMeasure((double)(MeasureResource.IfcMassDensityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLinearVelocityMeasure) 
					return new Ifc4.MeasureResource.IfcLinearVelocityMeasure((double)(MeasureResource.IfcLinearVelocityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcKinematicViscosityMeasure) 
					return new Ifc4.MeasureResource.IfcKinematicViscosityMeasure((double)(MeasureResource.IfcKinematicViscosityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcIntegerCountRateMeasure) 
					return new Ifc4.MeasureResource.IfcIntegerCountRateMeasure((long)(MeasureResource.IfcIntegerCountRateMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcHeatFluxDensityMeasure) 
					return new Ifc4.MeasureResource.IfcHeatFluxDensityMeasure((double)(MeasureResource.IfcHeatFluxDensityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcFrequencyMeasure) 
					return new Ifc4.MeasureResource.IfcFrequencyMeasure((double)(MeasureResource.IfcFrequencyMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcEnergyMeasure) 
					return new Ifc4.MeasureResource.IfcEnergyMeasure((double)(MeasureResource.IfcEnergyMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricVoltageMeasure) 
					return new Ifc4.MeasureResource.IfcElectricVoltageMeasure((double)(MeasureResource.IfcElectricVoltageMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcDynamicViscosityMeasure) 
					return new Ifc4.MeasureResource.IfcDynamicViscosityMeasure((double)(MeasureResource.IfcDynamicViscosityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcCompoundPlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure((List<long>)(MeasureResource.IfcCompoundPlaneAngleMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcAngularVelocityMeasure) 
					return new Ifc4.MeasureResource.IfcAngularVelocityMeasure((double)(MeasureResource.IfcAngularVelocityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcThermalConductivityMeasure) 
					return new Ifc4.MeasureResource.IfcThermalConductivityMeasure((double)(MeasureResource.IfcThermalConductivityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMolecularWeightMeasure) 
					return new Ifc4.MeasureResource.IfcMolecularWeightMeasure((double)(MeasureResource.IfcMolecularWeightMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcVaporPermeabilityMeasure) 
					return new Ifc4.MeasureResource.IfcVaporPermeabilityMeasure((double)(MeasureResource.IfcVaporPermeabilityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMoistureDiffusivityMeasure) 
					return new Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure((double)(MeasureResource.IfcMoistureDiffusivityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcIsothermalMoistureCapacityMeasure) 
					return new Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure((double)(MeasureResource.IfcIsothermalMoistureCapacityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSpecificHeatCapacityMeasure) 
					return new Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure((double)(MeasureResource.IfcSpecificHeatCapacityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMonetaryMeasure) 
					return new Ifc4.MeasureResource.IfcMonetaryMeasure((double)(MeasureResource.IfcMonetaryMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMagneticFluxDensityMeasure) 
					return new Ifc4.MeasureResource.IfcMagneticFluxDensityMeasure((double)(MeasureResource.IfcMagneticFluxDensityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMagneticFluxMeasure) 
					return new Ifc4.MeasureResource.IfcMagneticFluxMeasure((double)(MeasureResource.IfcMagneticFluxMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLuminousFluxMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousFluxMeasure((double)(MeasureResource.IfcLuminousFluxMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcForceMeasure) 
					return new Ifc4.MeasureResource.IfcForceMeasure((double)(MeasureResource.IfcForceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcInductanceMeasure) 
					return new Ifc4.MeasureResource.IfcInductanceMeasure((double)(MeasureResource.IfcInductanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcIlluminanceMeasure) 
					return new Ifc4.MeasureResource.IfcIlluminanceMeasure((double)(MeasureResource.IfcIlluminanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricResistanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricResistanceMeasure((double)(MeasureResource.IfcElectricResistanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricConductanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricConductanceMeasure((double)(MeasureResource.IfcElectricConductanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricChargeMeasure) 
					return new Ifc4.MeasureResource.IfcElectricChargeMeasure((double)(MeasureResource.IfcElectricChargeMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcDoseEquivalentMeasure) 
					return new Ifc4.MeasureResource.IfcDoseEquivalentMeasure((double)(MeasureResource.IfcDoseEquivalentMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcElectricCapacitanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricCapacitanceMeasure((double)(MeasureResource.IfcElectricCapacitanceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcAbsorbedDoseMeasure) 
					return new Ifc4.MeasureResource.IfcAbsorbedDoseMeasure((double)(MeasureResource.IfcAbsorbedDoseMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcRadioActivityMeasure) 
					return new Ifc4.MeasureResource.IfcRadioActivityMeasure((double)(MeasureResource.IfcRadioActivityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcRotationalFrequencyMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalFrequencyMeasure((double)(MeasureResource.IfcRotationalFrequencyMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcTorqueMeasure) 
					return new Ifc4.MeasureResource.IfcTorqueMeasure((double)(MeasureResource.IfcTorqueMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcAccelerationMeasure) 
					return new Ifc4.MeasureResource.IfcAccelerationMeasure((double)(MeasureResource.IfcAccelerationMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLinearForceMeasure) 
					return new Ifc4.MeasureResource.IfcLinearForceMeasure((double)(MeasureResource.IfcLinearForceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLinearStiffnessMeasure) 
					return new Ifc4.MeasureResource.IfcLinearStiffnessMeasure((double)(MeasureResource.IfcLinearStiffnessMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcModulusOfSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfSubgradeReactionMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcModulusOfElasticityMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfElasticityMeasure((double)(MeasureResource.IfcModulusOfElasticityMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMomentOfInertiaMeasure) 
					return new Ifc4.MeasureResource.IfcMomentOfInertiaMeasure((double)(MeasureResource.IfcMomentOfInertiaMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPlanarForceMeasure) 
					return new Ifc4.MeasureResource.IfcPlanarForceMeasure((double)(MeasureResource.IfcPlanarForceMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcRotationalStiffnessMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalStiffnessMeasure((double)(MeasureResource.IfcRotationalStiffnessMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcShearModulusMeasure) 
					return new Ifc4.MeasureResource.IfcShearModulusMeasure((double)(MeasureResource.IfcShearModulusMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLinearMomentMeasure) 
					return new Ifc4.MeasureResource.IfcLinearMomentMeasure((double)(MeasureResource.IfcLinearMomentMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcLuminousIntensityDistributionMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure((double)(MeasureResource.IfcLuminousIntensityDistributionMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcCurvatureMeasure) 
					return new Ifc4.MeasureResource.IfcCurvatureMeasure((double)(MeasureResource.IfcCurvatureMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcMassPerLengthMeasure) 
					return new Ifc4.MeasureResource.IfcMassPerLengthMeasure((double)(MeasureResource.IfcMassPerLengthMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcRotationalMassMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalMassMeasure((double)(MeasureResource.IfcRotationalMassMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSectionalAreaIntegralMeasure) 
					return new Ifc4.MeasureResource.IfcSectionalAreaIntegralMeasure((double)(MeasureResource.IfcSectionalAreaIntegralMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSectionModulusMeasure) 
					return new Ifc4.MeasureResource.IfcSectionModulusMeasure((double)(MeasureResource.IfcSectionModulusMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcTemperatureGradientMeasure) 
					return new Ifc4.MeasureResource.IfcTemperatureGradientMeasure((double)(MeasureResource.IfcTemperatureGradientMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcThermalExpansionCoefficientMeasure) 
					return new Ifc4.MeasureResource.IfcThermalExpansionCoefficientMeasure((double)(MeasureResource.IfcThermalExpansionCoefficientMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcWarpingConstantMeasure) 
					return new Ifc4.MeasureResource.IfcWarpingConstantMeasure((double)(MeasureResource.IfcWarpingConstantMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcWarpingMomentMeasure) 
					return new Ifc4.MeasureResource.IfcWarpingMomentMeasure((double)(MeasureResource.IfcWarpingMomentMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSoundPowerMeasure) 
					return new Ifc4.MeasureResource.IfcSoundPowerMeasure((double)(MeasureResource.IfcSoundPowerMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcSoundPressureMeasure) 
					return new Ifc4.MeasureResource.IfcSoundPressureMeasure((double)(MeasureResource.IfcSoundPressureMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcHeatingValueMeasure) 
					return new Ifc4.MeasureResource.IfcHeatingValueMeasure((double)(MeasureResource.IfcHeatingValueMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcPHMeasure) 
					return new Ifc4.MeasureResource.IfcPHMeasure((double)(MeasureResource.IfcPHMeasure)NominalValue);
				if (NominalValue is MeasureResource.IfcIonConcentrationMeasure) 
					return new Ifc4.MeasureResource.IfcIonConcentrationMeasure((double)(MeasureResource.IfcIonConcentrationMeasure)NominalValue);
				return null;
			} 
		}
		Ifc4.MeasureResource.IfcUnit IIfcPropertySingleValue.Unit 
		{ 
			get
			{
				if (Unit == null) return null;
				var ifcderivedunit = Unit as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = Unit as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = Unit as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	//## Custom code
	//##
	}
}