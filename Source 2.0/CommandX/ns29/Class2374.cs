using System;

namespace ns29
{
	// Token: 0x0200015D RID: 349
	public sealed class Class2374 : Class2373
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00008252 File Offset: 0x00006452
		public Class2374(string string_1, Interface49 interface49_1) : base(string_1, interface49_1)
		{
			this.class2372_0 = (Class2372)interface49_1;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0006A260 File Offset: 0x00068460
		public override string GetValue(string string_1)
		{
			if (!this.class2372_0.method_1())
			{
				string_1 = this.method_3(string_1);
			}
			return base.GetValue(string_1);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000826F File Offset: 0x0000646F
		public override void SetValueString(string string_1, object object_0)
		{
			if (!this.class2372_0.method_1())
			{
				string_1 = this.method_3(string_1);
			}
			base.SetValueString(string_1, object_0);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0006A28C File Offset: 0x0006848C
		private string method_3(string string_1)
		{
			string text = null;
			string b = string_1.ToLower();
			foreach (string text2 in this.class2376_0.Keys)
			{
				if (text2.ToLower() == b)
				{
					text = text2;
					break;
				}
			}
			return (text == null) ? string_1 : text;
		}

		// Token: 0x0400035D RID: 861
		private Class2372 class2372_0 = null;
	}
}
