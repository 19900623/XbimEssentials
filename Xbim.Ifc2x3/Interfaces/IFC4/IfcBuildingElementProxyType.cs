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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcBuildingElementProxyType : IIfcBuildingElementProxyType
	{
		Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum IIfcBuildingElementProxyType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcBuildingElementProxyTypeEnum.USERDEFINED:
						return Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum.USERDEFINED;
					
					case IfcBuildingElementProxyTypeEnum.NOTDEFINED:
						return Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}