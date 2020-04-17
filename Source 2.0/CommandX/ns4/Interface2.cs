using System;
using System.Collections.Generic;
using Command_Core;

namespace ns4
{
	// Token: 0x02000C12 RID: 3090
	internal interface Interface2
	{
		// Token: 0x060066E5 RID: 26341
		float imethod_0();

		// Token: 0x060066E6 RID: 26342
		float imethod_1();

		// Token: 0x060066E7 RID: 26343
		List<Waypoint> imethod_2(ActiveUnit activeUnit_0, double double_0, double double_1, double double_2, double double_3, float float_0, float float_1, float float_2, ref List<ActiveUnit> list_0, ref float float_3);

		// Token: 0x060066E8 RID: 26344
		List<Waypoint> imethod_3(ActiveUnit activeUnit_0, double double_0, double double_1, double double_2, double double_3, float float_0, float float_1, float float_2, ref List<ActiveUnit> list_0, ref float float_3);
	}
}
