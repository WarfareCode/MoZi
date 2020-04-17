using System;
using System.IO;
using ns28;

namespace ns29
{
	// Token: 0x0200015E RID: 350
	public sealed class Class2372 : Class2371
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x0000828F File Offset: 0x0000648F
		public Class2372()
		{
			this.class2365_0 = new Class2365();
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000082B7 File Offset: 0x000064B7
		public Class2372(string string_1)
		{
			this.method_2(string_1);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000082DB File Offset: 0x000064DB
		public bool method_1()
		{
			return this.bool_1;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000082E3 File Offset: 0x000064E3
		public void method_2(string string_1)
		{
			this.method_3(new StreamReader(string_1));
			this.string_0 = string_1;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000082F8 File Offset: 0x000064F8
		public void method_3(TextReader textReader_0)
		{
			this.method_4(new Class2365(textReader_0));
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00008306 File Offset: 0x00006506
		public void method_4(Class2365 class2365_1)
		{
			base.GetConfigList().Clear();
			base.vmethod_0(this);
			this.class2365_0 = class2365_1;
			this.method_9();
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00008327 File Offset: 0x00006527
		public override void imethod_3()
		{
			if (!this.method_10())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.method_6();
			this.class2365_0.method_4(this.string_0);
			base.imethod_3();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00008359 File Offset: 0x00006559
		public void method_5(string string_1)
		{
			this.string_0 = string_1;
			this.imethod_3();
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0006A314 File Offset: 0x00068514
		public override string ToString()
		{
			this.method_6();
			StringWriter stringWriter = new StringWriter();
			this.class2365_0.method_3(stringWriter);
			return stringWriter.ToString();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0006A344 File Offset: 0x00068544
		private void method_6()
		{
			this.method_7();
			foreach (IConfig config in base.GetConfigList())
			{
				string[] array = config.imethod_3();
				if (this.class2365_0.method_2()[config.imethod_0()] == null)
				{
					Class2367 class2367_ = new Class2367(config.imethod_0());
					this.class2365_0.method_2().method_0(class2367_);
				}
				this.method_8(config.imethod_0());
				for (int i = 0; i < array.Length; i++)
				{
					this.class2365_0.method_2()[config.imethod_0()].method_8(array[i], config.GetValue(array[i]));
				}
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0006A434 File Offset: 0x00068634
		private void method_7()
		{
			for (int i = 0; i < this.class2365_0.method_2().Count; i++)
			{
				Class2367 @class = this.class2365_0.method_2()[i];
				if (base.GetConfigList()[@class.method_0()] == null)
				{
					this.class2365_0.method_2().method_1(@class.method_0());
				}
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0006A4A0 File Offset: 0x000686A0
		private void method_8(string string_1)
		{
			Class2367 @class = this.class2365_0.method_2()[string_1];
			if (@class != null)
			{
				string[] array = @class.method_5();
				for (int i = 0; i < array.Length; i++)
				{
					string string_2 = array[i];
					if (base.GetConfigList()[string_1].GetValue(string_2) == null)
					{
						@class.method_10(string_2);
					}
				}
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0006A504 File Offset: 0x00068704
		private void method_9()
		{
			for (int i = 0; i < this.class2365_0.method_2().Count; i++)
			{
				Class2367 @class = this.class2365_0.method_2()[i];
				Class2374 class2 = new Class2374(@class.method_0(), this);
				for (int j = 0; j < @class.method_2(); j++)
				{
					Class2366 class3 = @class.method_4(j);
					if (class3.method_0() == Enum171.const_1)
					{
						class2.method_0(class3.method_1(), class3.Value);
					}
				}
				base.GetConfigList().method_0(class2);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00008368 File Offset: 0x00006568
		private bool method_10()
		{
			return this.string_0 != null;
		}

		// Token: 0x0400035E RID: 862
		private Class2365 class2365_0 = null;

		// Token: 0x0400035F RID: 863
		private string string_0 = null;

		// Token: 0x04000360 RID: 864
		private bool bool_1 = true;
	}
}
