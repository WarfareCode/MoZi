using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000245 RID: 581
	public sealed class Class2151 : Class2059
	{
		// Token: 0x06000D7A RID: 3450 RVA: 0x0000B116 File Offset: 0x00009316
		public Class2151()
		{
			this.method_6();
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0000B13A File Offset: 0x0000933A
		public Class2151(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0000B15F File Offset: 0x0000935F
		private void method_6()
		{
			this.class1749_0.method_0(this);
			this.class1751_0.method_0(this);
		}

		// Token: 0x040005B4 RID: 1460
		public Class2151.Class1749 class1749_0 = new Class2151.Class1749();

		// Token: 0x040005B5 RID: 1461
		public Class2151.Class1751 class1751_0 = new Class2151.Class1751();

		// Token: 0x02000246 RID: 582
		public sealed class Class1749 : IEnumerable
		{
			// Token: 0x06000D81 RID: 3457 RVA: 0x0000B179 File Offset: 0x00009379
			public void method_0(Class2151 class2151_1)
			{
				this.class2151_0 = class2151_1;
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x0007A580 File Offset: 0x00078780
			public Class2151.Class1750 method_1()
			{
				return new Class2151.Class1750(this.class2151_0);
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x0007A59C File Offset: 0x0007879C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005B6 RID: 1462
			private Class2151 class2151_0;
		}

		// Token: 0x02000247 RID: 583
		public sealed class Class1750 : IEnumerator
		{
			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0007A5B4 File Offset: 0x000787B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D86 RID: 3462 RVA: 0x0000B182 File Offset: 0x00009382
			public Class1750(Class2151 class2151_1)
			{
				this.class2151_0 = class2151_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D87 RID: 3463 RVA: 0x0000B198 File Offset: 0x00009398
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D88 RID: 3464 RVA: 0x0000B1A1 File Offset: 0x000093A1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2151_0.method_2();
			}

			// Token: 0x06000D89 RID: 3465 RVA: 0x0007A5CC File Offset: 0x000787CC
			public Class2050 method_0()
			{
				return this.class2151_0.method_3(this.int_0);
			}

			// Token: 0x040005B7 RID: 1463
			private int int_0;

			// Token: 0x040005B8 RID: 1464
			private Class2151 class2151_0;
		}

		// Token: 0x02000248 RID: 584
		public sealed class Class1751 : IEnumerable
		{
			// Token: 0x06000D8A RID: 3466 RVA: 0x0000B1C4 File Offset: 0x000093C4
			public void method_0(Class2151 class2151_1)
			{
				this.class2151_0 = class2151_1;
			}

			// Token: 0x06000D8B RID: 3467 RVA: 0x0007A5EC File Offset: 0x000787EC
			public Class2151.Class1752 method_1()
			{
				return new Class2151.Class1752(this.class2151_0);
			}

			// Token: 0x06000D8C RID: 3468 RVA: 0x0007A608 File Offset: 0x00078808
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005B9 RID: 1465
			private Class2151 class2151_0;
		}

		// Token: 0x02000249 RID: 585
		public sealed class Class1752 : IEnumerator
		{
			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0007A620 File Offset: 0x00078820
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D8F RID: 3471 RVA: 0x0000B1CD File Offset: 0x000093CD
			public Class1752(Class2151 class2151_1)
			{
				this.class2151_0 = class2151_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D90 RID: 3472 RVA: 0x0000B1E3 File Offset: 0x000093E3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D91 RID: 3473 RVA: 0x0000B1EC File Offset: 0x000093EC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2151_0.method_4();
			}

			// Token: 0x06000D92 RID: 3474 RVA: 0x0007A638 File Offset: 0x00078838
			public Class2145 method_0()
			{
				return this.class2151_0.method_5(this.int_0);
			}

			// Token: 0x040005BA RID: 1466
			private int int_0;

			// Token: 0x040005BB RID: 1467
			private Class2151 class2151_0;
		}
	}
}
