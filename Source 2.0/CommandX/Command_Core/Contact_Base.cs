using System;
using System.Collections.Concurrent;

namespace Command_Core
{
	// 目标基类
	public class Contact_Base : Unit
	{
		// 目标类型
		public string GetContactType()
		{
			string result;
			switch (this.contactType)
			{
			case Contact_Base.ContactType.Air:
				result = "Air";
				break;
			case Contact_Base.ContactType.Missile:
				result = "Missile";
				break;
			case Contact_Base.ContactType.Surface:
				result = "Surface";
				break;
			case Contact_Base.ContactType.Submarine:
				result = "Submarine";
				break;
			case Contact_Base.ContactType.UndeterminedNaval:
				result = "Undetermined Naval";
				break;
			case Contact_Base.ContactType.Aimpoint:
				result = "Aimpoint";
				break;
			case Contact_Base.ContactType.Orbital:
				result = "Orbital";
				break;
			case Contact_Base.ContactType.Facility_Fixed:
				result = "Fixed Facility";
				break;
			case Contact_Base.ContactType.Facility_Mobile:
				result = "Mobile Unit";
				break;
			case Contact_Base.ContactType.Torpedo:
				result = "Torpedo";
				break;
			case Contact_Base.ContactType.Mine:
				result = "Mine";
				break;
			case Contact_Base.ContactType.Explosion:
				result = "Explosion";
				break;
			case Contact_Base.ContactType.Undetermined:
				result = "Undetermined";
				break;
			case Contact_Base.ContactType.Decoy_Air:
				result = "Decoy (Air)";
				break;
			case Contact_Base.ContactType.Decoy_Surface:
				result = "Decoy (Surface)";
				break;
			case Contact_Base.ContactType.Decoy_Land:
				result = "Decoy (Land)";
				break;
			case Contact_Base.ContactType.Decoy_Sub:
				result = "Decoy (Underwater)";
				break;
			case Contact_Base.ContactType.Sonobuoy:
				result = "Sonobuoy";
				break;
			case Contact_Base.ContactType.Installation:
				result = "Fixed Installation";
				break;
			case Contact_Base.ContactType.AirBase:
				result = "AirBase";
				break;
			case Contact_Base.ContactType.NavalBase:
				result = "Naval Base";
				break;
			case Contact_Base.ContactType.MobileGroup:
				result = "Mobile Group";
				break;
			case Contact_Base.ContactType.ActivationPoint:
				result = "Activation Point";
				break;
			default:
				result = this.contactType.ToString();
				break;
			}
			return result;
		}

		// Token: 0x04001E46 RID: 7750
		public Contact_Base.ContactType contactType;

		// Token: 0x04001E47 RID: 7751
		public bool SideIsKnown;

		// Token: 0x04001E48 RID: 7752
		protected ConcurrentDictionary<string, ActiveUnit> concurrentDictionary_0;

		// Token: 0x04001E49 RID: 7753
		protected int AInc;

		// Token: 0x04001E4A RID: 7754
		protected Contact_Base.IdentificationStatus identificationStatus;

		// Token: 0x04001E4B RID: 7755
		public Side OriginalDetectorSide;

		// Token: 0x04001E4C RID: 7756
		protected string OriginalDetectorSideName;

		// Token: 0x020009B3 RID: 2483
		public enum ContactType : byte
		{
			// Token: 0x04001E4E RID: 7758
			Air,
			// Token: 0x04001E4F RID: 7759
			Missile,
			// Token: 0x04001E50 RID: 7760
			Surface,
			// Token: 0x04001E51 RID: 7761
			Submarine,
			// Token: 0x04001E52 RID: 7762
			UndeterminedNaval,
			// Token: 0x04001E53 RID: 7763
			Aimpoint,
			// Token: 0x04001E54 RID: 7764
			Orbital,
			// Token: 0x04001E55 RID: 7765
			Facility_Fixed,
			// Token: 0x04001E56 RID: 7766
			Facility_Mobile,
			// Token: 0x04001E57 RID: 7767
			Torpedo,
			// Token: 0x04001E58 RID: 7768
			Mine,
			// Token: 0x04001E59 RID: 7769
			Explosion,
			// Token: 0x04001E5A RID: 7770
			Undetermined,
			// Token: 0x04001E5B RID: 7771
			Decoy_Air,
			// Token: 0x04001E5C RID: 7772
			Decoy_Surface,
			// Token: 0x04001E5D RID: 7773
			Decoy_Land,
			// Token: 0x04001E5E RID: 7774
			Decoy_Sub,
			// Token: 0x04001E5F RID: 7775
			Sonobuoy,
			// Token: 0x04001E60 RID: 7776
			Installation,
			// Token: 0x04001E61 RID: 7777
			AirBase,
			// Token: 0x04001E62 RID: 7778
			NavalBase,
			// Token: 0x04001E63 RID: 7779
			MobileGroup,
			// Token: 0x04001E64 RID: 7780
			ActivationPoint
		}

		// 识别程度
		public enum IdentificationStatus : short
		{
			// Token: 0x04001E66 RID: 7782
			Unknown,
			// Token: 0x04001E67 RID: 7783
			KnownDomain,
			// Token: 0x04001E68 RID: 7784
			KnownType,
			// Token: 0x04001E69 RID: 7785
			KnownClass,
			// Token: 0x04001E6A RID: 7786
			PreciseID
		}
	}
}
