using System;
using System.Runtime.CompilerServices;
using Command;
using Command_Core;
using ns32;

namespace ns33
{
	// Token: 0x0200064D RID: 1613
	public sealed class Class2476
	{
		// Token: 0x0600295E RID: 10590 RVA: 0x00016A48 File Offset: 0x00014C48
		public Class2476()
		{
			this.method_1(true);
			this.class2474_0 = new Class2474();
			this.class2475_0 = new Class2475();
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00016A6D File Offset: 0x00014C6D
		[CompilerGenerated]
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00016A75 File Offset: 0x00014C75
		[CompilerGenerated]
		public void method_1(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00016A2B File Offset: 0x00014C2B
		public void method_2(Scenario scenario_0, Side side_0, Unit unit_0, bool bool_1)
		{
			Class2476.smethod_0();
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00016A2B File Offset: 0x00014C2B
		internal void method_3(Unit unit_0, Unit unit_1)
		{
			Class2476.smethod_0();
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00016A7E File Offset: 0x00014C7E
		public static void smethod_0()
		{
			if (Client.GetClientSide() != null && Client.GetHookedUnit() != null)
			{
				((RightColumnWPF)Client.elementHost.Child).method_2(Client.GetClientScenario(), Client.GetClientSide(), Client.GetHookedUnit());
			}
		}

		// Token: 0x040013CE RID: 5070
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040013CF RID: 5071
		public Class2474 class2474_0;

		// Token: 0x040013D0 RID: 5072
		public Class2475 class2475_0;
	}
}
