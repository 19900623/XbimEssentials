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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcEvaporativeCoolerType : IIfcEvaporativeCoolerType
	{
		Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum IIfcEvaporativeCoolerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER;
					
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL;
					
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER;
					
					case IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION;
					
					case IfcEvaporativeCoolerTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.USERDEFINED;
					
					case IfcEvaporativeCoolerTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}