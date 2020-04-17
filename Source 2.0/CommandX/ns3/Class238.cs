using System;

namespace ns3
{
	// Token: 0x02000BBA RID: 3002
	public sealed class Class238
	{
		// Token: 0x0600635C RID: 25436 RVA: 0x00313CDC File Offset: 0x00311EDC
		public static void smethod_0(ref Class242.Struct26 struct26_0, ref Class242.Struct26 struct26_1)
		{
			for (int i = 0; i < 3; i++)
			{
				struct26_0.double_0[i] = struct26_0.double_0[i] * 6378.135;
				struct26_1.double_0[i] = struct26_1.double_0[i] * 6378.135 / 60.0;
			}
			Class244.smethod_4(ref struct26_0);
			Class244.smethod_4(ref struct26_1);
		}
	}
}
