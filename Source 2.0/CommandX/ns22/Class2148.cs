using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000232 RID: 562
	public sealed class Class2148 : Class2059
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0000AD6F File Offset: 0x00008F6F
		public Class2148()
		{
			this.method_4();
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000AD88 File Offset: 0x00008F88
		public Class2148(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0000ADA2 File Offset: 0x00008FA2
		private void method_4()
		{
			this.class1737_0.method_0(this);
		}

		// Token: 0x04000597 RID: 1431
		public Class2148.Class1737 class1737_0 = new Class2148.Class1737();

		// Token: 0x02000233 RID: 563
		public sealed class Class1737 : IEnumerable
		{
			// Token: 0x06000D20 RID: 3360 RVA: 0x0000ADB0 File Offset: 0x00008FB0
			public void method_0(Class2148 class2148_1)
			{
				this.class2148_0 = class2148_1;
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x0007A040 File Offset: 0x00078240
			public Class2148.Class1738 method_1()
			{
				return new Class2148.Class1738(this.class2148_0);
			}

			// Token: 0x06000D22 RID: 3362 RVA: 0x0007A05C File Offset: 0x0007825C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000598 RID: 1432
			private Class2148 class2148_0;
		}

		// Token: 0x02000234 RID: 564
		public sealed class Class1738 : IEnumerator
		{
			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0007A074 File Offset: 0x00078274
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x0000ADB9 File Offset: 0x00008FB9
			public Class1738(Class2148 class2148_1)
			{
				this.class2148_0 = class2148_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D26 RID: 3366 RVA: 0x0000ADCF File Offset: 0x00008FCF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D27 RID: 3367 RVA: 0x0000ADD8 File Offset: 0x00008FD8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2148_0.method_2();
			}

			// Token: 0x06000D28 RID: 3368 RVA: 0x0007A08C File Offset: 0x0007828C
			public Class2050 method_0()
			{
				return this.class2148_0.method_3(this.int_0);
			}

			// Token: 0x04000599 RID: 1433
			private int int_0;

			// Token: 0x0400059A RID: 1434
			private Class2148 class2148_0;
		}
	}
}
