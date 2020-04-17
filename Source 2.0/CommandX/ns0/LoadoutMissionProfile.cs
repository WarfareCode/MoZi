using System;
using Command_Core;

namespace ns0
{
	// Token: 0x020009BD RID: 2493
	public sealed class LoadoutMissionProfile
	{
		// Token: 0x04001ED4 RID: 7892
		public short DBID;

		// Token: 0x04001ED5 RID: 7893
		public string strDescription;

		// Token: 0x04001ED6 RID: 7894
		public int FormUpTime;

		// Token: 0x04001ED7 RID: 7895
		public float FormUpAltitude;

		// Token: 0x04001ED8 RID: 7896
		public float CruiseAltitudeIngress;

		// Token: 0x04001ED9 RID: 7897
		public bool CruiseAltitudeIngressTerrainFollowing;

		// Token: 0x04001EDA RID: 7898
		public float CruiseAltitudeEgress;

		// Token: 0x04001EDB RID: 7899
		public bool CruiseAltitudeEgressTerrainFollowing;

		// Token: 0x04001EDC RID: 7900
		public ActiveUnit.Throttle CruiseThrottleSettingIngress;

		// Token: 0x04001EDD RID: 7901
		public ActiveUnit.Throttle CruiseThrottleSettingEgress;

		// Token: 0x04001EDE RID: 7902
		public bool CruiseOneWayOnly;

		// Token: 0x04001EDF RID: 7903
		public bool CruiseAtOptimumAltitude;

		// Token: 0x04001EE0 RID: 7904
		public float AttackAltitudeIngress;

		// Token: 0x04001EE1 RID: 7905
		public bool AttackAltitudeIngressTerrainFollowing;

		// Token: 0x04001EE2 RID: 7906
		public float AttackAltitudeEgress = 0f;

		// Token: 0x04001EE3 RID: 7907
		public bool AttackAltitudeEgressTerrainFollowing;

		// Token: 0x04001EE4 RID: 7908
		public ActiveUnit.Throttle AttackThrottleSetting;

		// Token: 0x04001EE5 RID: 7909
		public int AttackDistanceIngress;

		// Token: 0x04001EE6 RID: 7910
		public int AttackDistanceEgress;

		// Token: 0x04001EE7 RID: 7911
		public bool DropBombsAtMaxRange;

		// Token: 0x04001EE8 RID: 7912
		public float StationAltitude;

		// Token: 0x04001EE9 RID: 7913
		public bool StationAltitudeTerrainFollowing;

		// Token: 0x04001EEA RID: 7914
		public ActiveUnit.Throttle StationThrottleSetting;

		// Token: 0x04001EEB RID: 7915
		public int ReservePercentage;

		// Token: 0x04001EEC RID: 7916
		public int ReserveLoiterTime;

		// Token: 0x04001EED RID: 7917
		public float ReserveLoiterAltitude;
	}
}
