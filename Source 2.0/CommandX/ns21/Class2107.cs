using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x02000075 RID: 117
	public sealed class Class2107 : Class2059
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000592A File Offset: 0x00003B2A
		public Class2107()
		{
			this.method_6();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000594E File Offset: 0x00003B4E
		public Class2107(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "name");
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0005B4E4 File Offset: 0x000596E4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "name", int_0)));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00005973 File Offset: 0x00003B73
		private void method_6()
		{
			this.class1415_0.method_0(this);
			this.class1417_0.method_0(this);
		}

		// Token: 0x04000159 RID: 345
		public Class2107.Class1415 class1415_0 = new Class2107.Class1415();

		// Token: 0x0400015A RID: 346
		public Class2107.Class1417 class1417_0 = new Class2107.Class1417();

		// Token: 0x02000076 RID: 118
		public sealed class Class1415 : IEnumerable
		{
			// Token: 0x0600025B RID: 603 RVA: 0x0000598D File Offset: 0x00003B8D
			public void method_0(Class2107 class2107_1)
			{
				this.class2107_0 = class2107_1;
			}

			// Token: 0x0600025C RID: 604 RVA: 0x0005B510 File Offset: 0x00059710
			public Class2107.Class1416 method_1()
			{
				return new Class2107.Class1416(this.class2107_0);
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0005B52C File Offset: 0x0005972C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400015B RID: 347
			private Class2107 class2107_0;
		}

		// Token: 0x02000077 RID: 119
		public sealed class Class1416 : IEnumerator
		{
			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600025F RID: 607 RVA: 0x0005B544 File Offset: 0x00059744
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00005996 File Offset: 0x00003B96
			public Class1416(Class2107 class2107_1)
			{
				this.class2107_0 = class2107_1;
				this.int_0 = -1;
			}

			// Token: 0x06000261 RID: 609 RVA: 0x000059AC File Offset: 0x00003BAC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000262 RID: 610 RVA: 0x000059B5 File Offset: 0x00003BB5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2107_0.method_2();
			}

			// Token: 0x06000263 RID: 611 RVA: 0x0005B55C File Offset: 0x0005975C
			public Class2050 method_0()
			{
				return this.class2107_0.method_3(this.int_0);
			}

			// Token: 0x0400015C RID: 348
			private int int_0;

			// Token: 0x0400015D RID: 349
			private Class2107 class2107_0;
		}

		// Token: 0x02000078 RID: 120
		public sealed class Class1417 : IEnumerable
		{
			// Token: 0x06000264 RID: 612 RVA: 0x000059D8 File Offset: 0x00003BD8
			public void method_0(Class2107 class2107_1)
			{
				this.class2107_0 = class2107_1;
			}

			// Token: 0x06000265 RID: 613 RVA: 0x0005B57C File Offset: 0x0005977C
			public Class2107.Class1418 method_1()
			{
				return new Class2107.Class1418(this.class2107_0);
			}

			// Token: 0x06000266 RID: 614 RVA: 0x0005B598 File Offset: 0x00059798
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400015E RID: 350
			private Class2107 class2107_0;
		}

		// Token: 0x02000079 RID: 121
		public sealed class Class1418 : IEnumerator
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0005B5B0 File Offset: 0x000597B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000269 RID: 617 RVA: 0x000059E1 File Offset: 0x00003BE1
			public Class1418(Class2107 class2107_1)
			{
				this.class2107_0 = class2107_1;
				this.int_0 = -1;
			}

			// Token: 0x0600026A RID: 618 RVA: 0x000059F7 File Offset: 0x00003BF7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00005A00 File Offset: 0x00003C00
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2107_0.method_4();
			}

			// Token: 0x0600026C RID: 620 RVA: 0x0005B5C8 File Offset: 0x000597C8
			public Class2128 method_0()
			{
				return this.class2107_0.method_5(this.int_0);
			}

			// Token: 0x0400015F RID: 351
			private int int_0;

			// Token: 0x04000160 RID: 352
			private Class2107 class2107_0;
		}
	}
}
