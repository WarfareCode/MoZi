using System;
using System.Collections;

namespace ns29
{
	// Token: 0x02000140 RID: 320
	public sealed class Class2370
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x00007BED File Offset: 0x00005DED
		public Class2370()
		{
			this.hashtable_0 = this.method_4();
			this.hashtable_1 = this.method_4();
			this.method_3();
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00007C21 File Offset: 0x00005E21
		public void method_0(string string_0, bool bool_0)
		{
			this.hashtable_1[string_0] = bool_0;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00007C35 File Offset: 0x00005E35
		public bool method_1(string string_0)
		{
			return this.hashtable_1.Contains(string_0);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00007C43 File Offset: 0x00005E43
		public bool method_2(string string_0)
		{
			if (!this.hashtable_1.Contains(string_0))
			{
				throw new ArgumentException("Alias does not exist for text");
			}
			return (bool)this.hashtable_1[string_0];
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00007C6F File Offset: 0x00005E6F
		private void method_3()
		{
			this.method_0("true", true);
			this.method_0("false", false);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00069820 File Offset: 0x00067A20
		private Hashtable method_4()
		{
			return new Hashtable(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
		}

		// Token: 0x0400032A RID: 810
		private Hashtable hashtable_0 = null;

		// Token: 0x0400032B RID: 811
		private Hashtable hashtable_1 = null;
	}
}
