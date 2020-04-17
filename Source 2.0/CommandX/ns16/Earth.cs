using System;
using System.Windows.Forms;
using Microsoft.DirectX;
using ns19;

namespace ns16
{
	// Token: 0x020004BC RID: 1212
	internal static class Earth
	{
		// Token: 0x06001FAA RID: 8106 RVA: 0x000D0D2C File Offset: 0x000CEF2C
		public static World CreateEarth()
		{
			return new World("Earth", new Vector3(1f, 1f, 1f), new Quaternion(1f, 1f, 1f, 0f), 6378137.0, Application.StartupPath + "\\WW\\Cache", null);
		}
	}
}
