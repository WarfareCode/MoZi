using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns15
{
	// Token: 0x0200064E RID: 1614
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	public sealed class Class836
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x00004A21 File Offset: 0x00002C21
		internal Class836()
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000FD57C File Offset: 0x000FB77C
		internal static ResourceManager smethod_0()
		{
			if (object.ReferenceEquals(Class836.resourceManager_0, null))
			{
				Class836.resourceManager_0 = new ResourceManager("ns15.Class836", typeof(Class836).Assembly);
			}
			return Class836.resourceManager_0;
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000FD5C0 File Offset: 0x000FB7C0
		internal static string smethod_1()
		{
			return Class836.smethod_0().GetString("ReadOnly", Class836.cultureInfo_0);
		}

		// Token: 0x040013D1 RID: 5073
		private static ResourceManager resourceManager_0;

		// Token: 0x040013D2 RID: 5074
		private static CultureInfo cultureInfo_0;
	}
}
