using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns18
{
	// Token: 0x020002EA RID: 746
	public sealed class Class2167 : Class2059
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x0000D2CE File Offset: 0x0000B4CE
		public Class2167()
		{
			this.method_6();
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		public Class2167(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0000D317 File Offset: 0x0000B517
		private void method_6()
		{
			this.class1865_0.method_0(this);
			this.class1867_0.method_0(this);
		}

		// Token: 0x04000708 RID: 1800
		public Class2167.Class1865 class1865_0 = new Class2167.Class1865();

		// Token: 0x04000709 RID: 1801
		public Class2167.Class1867 class1867_0 = new Class2167.Class1867();

		// Token: 0x020002EB RID: 747
		public sealed class Class1865 : IEnumerable
		{
			// Token: 0x06001170 RID: 4464 RVA: 0x0000D331 File Offset: 0x0000B531
			public void method_0(Class2167 class2167_1)
			{
				this.class2167_0 = class2167_1;
			}

			// Token: 0x06001171 RID: 4465 RVA: 0x0007FA98 File Offset: 0x0007DC98
			public Class2167.Class1866 method_1()
			{
				return new Class2167.Class1866(this.class2167_0);
			}

			// Token: 0x06001172 RID: 4466 RVA: 0x0007FAB4 File Offset: 0x0007DCB4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400070A RID: 1802
			private Class2167 class2167_0;
		}

		// Token: 0x020002EC RID: 748
		public sealed class Class1866 : IEnumerator
		{
			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06001174 RID: 4468 RVA: 0x0007FACC File Offset: 0x0007DCCC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001175 RID: 4469 RVA: 0x0000D33A File Offset: 0x0000B53A
			public Class1866(Class2167 class2167_1)
			{
				this.class2167_0 = class2167_1;
				this.int_0 = -1;
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x0000D350 File Offset: 0x0000B550
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x0000D359 File Offset: 0x0000B559
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2167_0.method_2();
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
			public Class2050 method_0()
			{
				return this.class2167_0.method_3(this.int_0);
			}

			// Token: 0x0400070B RID: 1803
			private int int_0;

			// Token: 0x0400070C RID: 1804
			private Class2167 class2167_0;
		}

		// Token: 0x020002ED RID: 749
		public sealed class Class1867 : IEnumerable
		{
			// Token: 0x06001179 RID: 4473 RVA: 0x0000D37C File Offset: 0x0000B57C
			public void method_0(Class2167 class2167_1)
			{
				this.class2167_0 = class2167_1;
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x0007FB04 File Offset: 0x0007DD04
			public Class2167.Class1868 method_1()
			{
				return new Class2167.Class1868(this.class2167_0);
			}

			// Token: 0x0600117B RID: 4475 RVA: 0x0007FB20 File Offset: 0x0007DD20
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400070D RID: 1805
			private Class2167 class2167_0;
		}

		// Token: 0x020002EE RID: 750
		public sealed class Class1868 : IEnumerator
		{
			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600117D RID: 4477 RVA: 0x0007FB38 File Offset: 0x0007DD38
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600117E RID: 4478 RVA: 0x0000D385 File Offset: 0x0000B585
			public Class1868(Class2167 class2167_1)
			{
				this.class2167_0 = class2167_1;
				this.int_0 = -1;
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x0000D39B File Offset: 0x0000B59B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001180 RID: 4480 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2167_0.method_4();
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x0007FB50 File Offset: 0x0007DD50
			public Class2145 method_0()
			{
				return this.class2167_0.method_5(this.int_0);
			}

			// Token: 0x0400070E RID: 1806
			private int int_0;

			// Token: 0x0400070F RID: 1807
			private Class2167 class2167_0;
		}
	}
}
