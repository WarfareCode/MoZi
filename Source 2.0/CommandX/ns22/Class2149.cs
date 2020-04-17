using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000236 RID: 566
	public sealed class Class2149 : Class2059
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x0000ADFB File Offset: 0x00008FFB
		public Class2149()
		{
			this.method_8();
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0000AE2A File Offset: 0x0000902A
		public Class2149(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "name");
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0005B4E4 File Offset: 0x000596E4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "name", int_0)));
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0005FEEC File Offset: 0x0005E0EC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "default");
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0005FF0C File Offset: 0x0005E10C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "default", int_0)));
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0005FF84 File Offset: 0x0005E184
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "nearestValue");
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0007A0AC File Offset: 0x000782AC
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "nearestValue", int_0)));
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0000AE5A File Offset: 0x0000905A
		private void method_8()
		{
			this.class1739_0.method_0(this);
			this.class1741_0.method_0(this);
			this.class1743_0.method_0(this);
		}

		// Token: 0x0400059B RID: 1435
		public Class2149.Class1739 class1739_0 = new Class2149.Class1739();

		// Token: 0x0400059C RID: 1436
		public Class2149.Class1741 class1741_0 = new Class2149.Class1741();

		// Token: 0x0400059D RID: 1437
		public Class2149.Class1743 class1743_0 = new Class2149.Class1743();

		// Token: 0x02000237 RID: 567
		public sealed class Class1739 : IEnumerable
		{
			// Token: 0x06000D33 RID: 3379 RVA: 0x0000AE80 File Offset: 0x00009080
			public void method_0(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x0007A0D8 File Offset: 0x000782D8
			public Class2149.Class1740 method_1()
			{
				return new Class2149.Class1740(this.class2149_0);
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x0007A0F4 File Offset: 0x000782F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400059E RID: 1438
			private Class2149 class2149_0;
		}

		// Token: 0x02000238 RID: 568
		public sealed class Class1740 : IEnumerator
		{
			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0007A10C File Offset: 0x0007830C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x0000AE89 File Offset: 0x00009089
			public Class1740(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x0000AE9F File Offset: 0x0000909F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x0000AEA8 File Offset: 0x000090A8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2149_0.method_2();
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x0007A124 File Offset: 0x00078324
			public Class2050 method_0()
			{
				return this.class2149_0.method_3(this.int_0);
			}

			// Token: 0x0400059F RID: 1439
			private int int_0;

			// Token: 0x040005A0 RID: 1440
			private Class2149 class2149_0;
		}

		// Token: 0x02000239 RID: 569
		public sealed class Class1741 : IEnumerable
		{
			// Token: 0x06000D3C RID: 3388 RVA: 0x0000AECB File Offset: 0x000090CB
			public void method_0(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x0007A144 File Offset: 0x00078344
			public Class2149.Class1742 method_1()
			{
				return new Class2149.Class1742(this.class2149_0);
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x0007A160 File Offset: 0x00078360
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005A1 RID: 1441
			private Class2149 class2149_0;
		}

		// Token: 0x0200023A RID: 570
		public sealed class Class1742 : IEnumerator
		{
			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0007A178 File Offset: 0x00078378
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x0000AED4 File Offset: 0x000090D4
			public Class1742(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x0000AEEA File Offset: 0x000090EA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x0000AEF3 File Offset: 0x000090F3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2149_0.method_4();
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x0007A190 File Offset: 0x00078390
			public Class2050 method_0()
			{
				return this.class2149_0.method_5(this.int_0);
			}

			// Token: 0x040005A2 RID: 1442
			private int int_0;

			// Token: 0x040005A3 RID: 1443
			private Class2149 class2149_0;
		}

		// Token: 0x0200023B RID: 571
		public sealed class Class1743 : IEnumerable
		{
			// Token: 0x06000D45 RID: 3397 RVA: 0x0000AF16 File Offset: 0x00009116
			public void method_0(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x0007A1B0 File Offset: 0x000783B0
			public Class2149.Class1744 method_1()
			{
				return new Class2149.Class1744(this.class2149_0);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0007A1CC File Offset: 0x000783CC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005A4 RID: 1444
			private Class2149 class2149_0;
		}

		// Token: 0x0200023C RID: 572
		public sealed class Class1744 : IEnumerator
		{
			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0007A1E4 File Offset: 0x000783E4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x0000AF1F File Offset: 0x0000911F
			public Class1744(Class2149 class2149_1)
			{
				this.class2149_0 = class2149_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x0000AF35 File Offset: 0x00009135
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x0000AF3E File Offset: 0x0000913E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2149_0.method_6();
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x0007A1FC File Offset: 0x000783FC
			public Class2050 method_0()
			{
				return this.class2149_0.method_7(this.int_0);
			}

			// Token: 0x040005A5 RID: 1445
			private int int_0;

			// Token: 0x040005A6 RID: 1446
			private Class2149 class2149_0;
		}
	}
}
