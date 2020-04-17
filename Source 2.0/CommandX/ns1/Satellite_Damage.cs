using System;
using Command_Core;

namespace ns1
{
	// Token: 0x02000A80 RID: 2688
	public sealed class Satellite_Damage : ActiveUnit_Damage
	{
		// Token: 0x06005507 RID: 21767 RVA: 0x000247CD File Offset: 0x000229CD
		public Satellite_Damage(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x000271A5 File Offset: 0x000253A5
		protected override void vmethod_10(Weapon weapon_0, GeoPoint geoPoint_0, float float_1, float float_2, ref ActiveUnit activeUnit_1, double? nullable_0, double? nullable_1, float? nullable_2)
		{
			this.activeUnit.SetDamagePts(false, -1f);
			this.activeUnit.m_Scenario.RemoveUnit(this.activeUnit);
		}
	}
}
