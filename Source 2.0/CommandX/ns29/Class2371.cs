using System;
using System.Collections;

namespace ns29
{
	// Token: 0x0200014B RID: 331
	public abstract class Class2371 : Interface49
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x00007E5C File Offset: 0x0000605C
		public Class2371()
		{
			this.class2375_0 = new Class2375(this);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000699F0 File Offset: 0x00067BF0
		public Class2375 GetConfigList()
		{
			return this.class2375_0;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00007E94 File Offset: 0x00006094
		public bool imethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00069A08 File Offset: 0x00067C08
		public Class2370 imethod_2()
		{
			return this.class2370_0;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00069A20 File Offset: 0x00067C20
		public void vmethod_0(Interface49 interface49_0)
		{
			if (!this.arrayList_0.Contains(interface49_0))
			{
				this.arrayList_0.Add(interface49_0);
			}
			foreach (IConfig interface50_ in interface49_0.GetConfigList())
			{
				this.GetConfigList().method_0(interface50_);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00069AA0 File Offset: 0x00067CA0
		public virtual IConfig GetConfig(string string_0)
		{
			return this.class2375_0.method_1(string_0);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00007E9C File Offset: 0x0000609C
		public virtual void imethod_3()
		{
			this.method_0(new EventArgs());
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00007EA9 File Offset: 0x000060A9
		protected void method_0(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x0400033C RID: 828
		private ArrayList arrayList_0 = new ArrayList();

		// Token: 0x0400033D RID: 829
		private Class2375 class2375_0 = null;

		// Token: 0x0400033E RID: 830
		private bool bool_0 = false;

		// Token: 0x0400033F RID: 831
		private Class2370 class2370_0 = new Class2370();

		// Token: 0x04000340 RID: 832
		private EventHandler eventHandler_0;
	}
}
