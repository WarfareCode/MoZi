using System;
using Command_Core;

namespace ns4
{
	// Token: 0x02000C94 RID: 3220
	public sealed class Class363
	{
		// Token: 0x06006AB9 RID: 27321 RVA: 0x003A0848 File Offset: 0x0039EA48
		public static float smethod_0(Unit unit_0, ref float float_0)
		{
			return Class363.smethod_2(unit_0.GetAntennaHeight(unit_0), float_0);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x003A0868 File Offset: 0x0039EA68
		public static float smethod_1(Unit unit_0, Unit unit_1)
		{
			float antennaAltitude_ASL = unit_0.GetAntennaAltitude_ASL(unit_1);
			return Class363.smethod_2(unit_0.GetAntennaHeight(unit_0), antennaAltitude_ASL);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x003A088C File Offset: 0x0039EA8C
		public static float smethod_2(float float_0, float float_1)
		{
			return (float)(ECM.smethod_5((double)float_0, (double)float_1, 39.0) * 1000.0 / 1852.0);
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x003A08C4 File Offset: 0x0039EAC4
		public static float smethod_3(Unit ParentPlatform_, ref float TargetAltitude_ASL)
		{
			return Class363.smethod_4(ParentPlatform_.GetCurrentAltitude_ASL(false) + (float)ParentPlatform_.GetTargetVisualSize(), TargetAltitude_ASL);
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x003A08EC File Offset: 0x0039EAEC
		public static float smethod_4(float float_0, float float_1)
		{
			float num = (float)Math.Sqrt(12742000.0 * (double)float_0 + Math.Pow((double)float_0, 2.0));
			double num2 = Math.Sqrt(12742000.0 * (double)float_1 + Math.Pow((double)float_1, 2.0));
			return (float)(((double)num + num2) / 1852.0);
		}
	}
}
