using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x0200022B RID: 555
	public sealed class Class2147 : Class2059
	{
		// Token: 0x06000CF7 RID: 3319 RVA: 0x0000AC09 File Offset: 0x00008E09
		public Class2147()
		{
			this.method_8();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0000AC38 File Offset: 0x00008E38
		public Class2147(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "name");
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0005B4E4 File Offset: 0x000596E4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "name", int_0)));
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0005FE54 File Offset: 0x0005E054
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "units");
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0005FE74 File Offset: 0x0005E074
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "units", int_0)));
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0005FEA0 File Offset: 0x0005E0A0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "unitSymbol");
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "unitSymbol", int_0)));
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0000AC68 File Offset: 0x00008E68
		private void method_8()
		{
			this.class1731_0.method_0(this);
			this.class1733_0.method_0(this);
			this.class1735_0.method_0(this);
		}

		// Token: 0x0400058B RID: 1419
		public Class2147.Class1731 class1731_0 = new Class2147.Class1731();

		// Token: 0x0400058C RID: 1420
		public Class2147.Class1733 class1733_0 = new Class2147.Class1733();

		// Token: 0x0400058D RID: 1421
		public Class2147.Class1735 class1735_0 = new Class2147.Class1735();

		// Token: 0x0200022C RID: 556
		public sealed class Class1731 : IEnumerable
		{
			// Token: 0x06000D00 RID: 3328 RVA: 0x0000AC8E File Offset: 0x00008E8E
			public void method_0(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
			}

			// Token: 0x06000D01 RID: 3329 RVA: 0x00079EFC File Offset: 0x000780FC
			public Class2147.Class1732 method_1()
			{
				return new Class2147.Class1732(this.class2147_0);
			}

			// Token: 0x06000D02 RID: 3330 RVA: 0x00079F18 File Offset: 0x00078118
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400058E RID: 1422
			private Class2147 class2147_0;
		}

		// Token: 0x0200022D RID: 557
		public sealed class Class1732 : IEnumerator
		{
			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00079F30 File Offset: 0x00078130
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x0000AC97 File Offset: 0x00008E97
			public Class1732(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x0000ACAD File Offset: 0x00008EAD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D07 RID: 3335 RVA: 0x0000ACB6 File Offset: 0x00008EB6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2147_0.method_2();
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x00079F48 File Offset: 0x00078148
			public Class2050 method_0()
			{
				return this.class2147_0.method_3(this.int_0);
			}

			// Token: 0x0400058F RID: 1423
			private int int_0;

			// Token: 0x04000590 RID: 1424
			private Class2147 class2147_0;
		}

		// Token: 0x0200022E RID: 558
		public sealed class Class1733 : IEnumerable
		{
			// Token: 0x06000D09 RID: 3337 RVA: 0x0000ACD9 File Offset: 0x00008ED9
			public void method_0(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00079F68 File Offset: 0x00078168
			public Class2147.Class1734 method_1()
			{
				return new Class2147.Class1734(this.class2147_0);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x00079F84 File Offset: 0x00078184
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000591 RID: 1425
			private Class2147 class2147_0;
		}

		// Token: 0x0200022F RID: 559
		public sealed class Class1734 : IEnumerator
		{
			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00079F9C File Offset: 0x0007819C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x0000ACE2 File Offset: 0x00008EE2
			public Class1734(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x0000ACF8 File Offset: 0x00008EF8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x0000AD01 File Offset: 0x00008F01
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2147_0.method_4();
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x00079FB4 File Offset: 0x000781B4
			public Class2050 method_0()
			{
				return this.class2147_0.method_5(this.int_0);
			}

			// Token: 0x04000592 RID: 1426
			private int int_0;

			// Token: 0x04000593 RID: 1427
			private Class2147 class2147_0;
		}

		// Token: 0x02000230 RID: 560
		public sealed class Class1735 : IEnumerable
		{
			// Token: 0x06000D12 RID: 3346 RVA: 0x0000AD24 File Offset: 0x00008F24
			public void method_0(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
			}

			// Token: 0x06000D13 RID: 3347 RVA: 0x00079FD4 File Offset: 0x000781D4
			public Class2147.Class1736 method_1()
			{
				return new Class2147.Class1736(this.class2147_0);
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x00079FF0 File Offset: 0x000781F0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000594 RID: 1428
			private Class2147 class2147_0;
		}

		// Token: 0x02000231 RID: 561
		public sealed class Class1736 : IEnumerator
		{
			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0007A008 File Offset: 0x00078208
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D17 RID: 3351 RVA: 0x0000AD2D File Offset: 0x00008F2D
			public Class1736(Class2147 class2147_1)
			{
				this.class2147_0 = class2147_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D18 RID: 3352 RVA: 0x0000AD43 File Offset: 0x00008F43
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D19 RID: 3353 RVA: 0x0000AD4C File Offset: 0x00008F4C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2147_0.method_6();
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x0007A020 File Offset: 0x00078220
			public Class2050 method_0()
			{
				return this.class2147_0.method_7(this.int_0);
			}

			// Token: 0x04000595 RID: 1429
			private int int_0;

			// Token: 0x04000596 RID: 1430
			private Class2147 class2147_0;
		}
	}
}
