using System;
using System.Collections;
using ns28;

namespace ns29
{
	// Token: 0x02000133 RID: 307
	public sealed class Class2367
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00007855 File Offset: 0x00005A55
		public Class2367(string string_2, string string_3)
		{
			this.string_0 = string_2;
			this.string_1 = string_3;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000788F File Offset: 0x00005A8F
		public Class2367(string string_2) : this(string_2, null)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00069110 File Offset: 0x00067310
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00069128 File Offset: 0x00067328
		public string method_1()
		{
			return this.string_1;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00069140 File Offset: 0x00067340
		public int method_2()
		{
			return this.class2376_0.Count;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0006915C File Offset: 0x0006735C
		public string method_3(string string_2)
		{
			string result = null;
			if (this.method_6(string_2))
			{
				Class2366 @class = (Class2366)this.class2376_0[string_2];
				result = @class.Value;
			}
			return result;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00069194 File Offset: 0x00067394
		public Class2366 method_4(int int_1)
		{
			return (Class2366)this.class2376_0[int_1];
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000691B4 File Offset: 0x000673B4
		public string[] method_5()
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < this.class2376_0.Count; i++)
			{
				Class2366 @class = (Class2366)this.class2376_0[i];
				if (@class.method_0() == Enum171.const_1)
				{
					arrayList.Add(@class.method_1());
				}
			}
			string[] array = new string[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00007899 File Offset: 0x00005A99
		public bool method_6(string string_2)
		{
			return this.class2376_0[string_2] != null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00069228 File Offset: 0x00067428
		public void method_7(string string_2, string string_3, string string_4)
		{
			if (this.method_6(string_2))
			{
				Class2366 @class = (Class2366)this.class2376_0[string_2];
				@class.Value = string_3;
				@class.method_3(string_4);
			}
			else
			{
				Class2366 @class = new Class2366(string_2, string_3, Enum171.const_1, string_4);
				this.class2376_0.Add(string_2, @class);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000078AD File Offset: 0x00005AAD
		public void method_8(string string_2, string string_3)
		{
			this.method_7(string_2, string_3, null);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0006927C File Offset: 0x0006747C
		public void method_9(string string_2)
		{
			string text = "#comment" + this.int_0;
			Class2366 value = new Class2366(text, null, Enum171.const_2, string_2);
			this.class2376_0.Add(text, value);
			this.int_0++;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000078B8 File Offset: 0x00005AB8
		public void method_10(string string_2)
		{
			if (this.method_6(string_2))
			{
				this.class2376_0.Remove(string_2);
			}
		}

		// Token: 0x04000306 RID: 774
		private Class2376 class2376_0 = new Class2376();

		// Token: 0x04000307 RID: 775
		private string string_0 = "";

		// Token: 0x04000308 RID: 776
		private string string_1 = null;

		// Token: 0x04000309 RID: 777
		private int int_0 = 0;
	}
}
