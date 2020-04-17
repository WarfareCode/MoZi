using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x02000136 RID: 310
	public sealed class Class2125 : Class2059
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x0000793F File Offset: 0x00005B3F
		public Class2125()
		{
			this.method_10();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00007979 File Offset: 0x00005B79
		public Class2125(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00069358 File Offset: 0x00067558
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "width");
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00069378 File Offset: 0x00067578
		public Class2018 method_3(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "width", int_0)));
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000693A4 File Offset: 0x000675A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "height");
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000693C4 File Offset: 0x000675C4
		public Class2018 method_5(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "height", int_0)));
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_9(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000079B4 File Offset: 0x00005BB4
		private void method_10()
		{
			this.class1561_0.method_0(this);
			this.class1563_0.method_0(this);
			this.class1565_0.method_0(this);
			this.class1567_0.method_0(this);
		}

		// Token: 0x04000310 RID: 784
		public Class2125.Class1561 class1561_0 = new Class2125.Class1561();

		// Token: 0x04000311 RID: 785
		public Class2125.Class1563 class1563_0 = new Class2125.Class1563();

		// Token: 0x04000312 RID: 786
		public Class2125.Class1565 class1565_0 = new Class2125.Class1565();

		// Token: 0x04000313 RID: 787
		public Class2125.Class1567 class1567_0 = new Class2125.Class1567();

		// Token: 0x02000137 RID: 311
		public sealed class Class1561 : IEnumerable
		{
			// Token: 0x060006BA RID: 1722 RVA: 0x000079E6 File Offset: 0x00005BE6
			public void method_0(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x000693F0 File Offset: 0x000675F0
			public Class2125.Class1562 method_1()
			{
				return new Class2125.Class1562(this.class2125_0);
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x0006940C File Offset: 0x0006760C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000314 RID: 788
			private Class2125 class2125_0;
		}

		// Token: 0x02000138 RID: 312
		public sealed class Class1562 : IEnumerator
		{
			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060006BE RID: 1726 RVA: 0x00069424 File Offset: 0x00067624
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x000079EF File Offset: 0x00005BEF
			public Class1562(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
				this.int_0 = -1;
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00007A05 File Offset: 0x00005C05
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x00007A0E File Offset: 0x00005C0E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2125_0.method_2();
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x0006943C File Offset: 0x0006763C
			public Class2018 method_0()
			{
				return this.class2125_0.method_3(this.int_0);
			}

			// Token: 0x04000315 RID: 789
			private int int_0;

			// Token: 0x04000316 RID: 790
			private Class2125 class2125_0;
		}

		// Token: 0x02000139 RID: 313
		public sealed class Class1563 : IEnumerable
		{
			// Token: 0x060006C3 RID: 1731 RVA: 0x00007A31 File Offset: 0x00005C31
			public void method_0(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x0006945C File Offset: 0x0006765C
			public Class2125.Class1564 method_1()
			{
				return new Class2125.Class1564(this.class2125_0);
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00069478 File Offset: 0x00067678
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000317 RID: 791
			private Class2125 class2125_0;
		}

		// Token: 0x0200013A RID: 314
		public sealed class Class1564 : IEnumerator
		{
			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00069490 File Offset: 0x00067690
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x00007A3A File Offset: 0x00005C3A
			public Class1564(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
				this.int_0 = -1;
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00007A50 File Offset: 0x00005C50
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x00007A59 File Offset: 0x00005C59
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2125_0.method_4();
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x000694A8 File Offset: 0x000676A8
			public Class2018 method_0()
			{
				return this.class2125_0.method_5(this.int_0);
			}

			// Token: 0x04000318 RID: 792
			private int int_0;

			// Token: 0x04000319 RID: 793
			private Class2125 class2125_0;
		}

		// Token: 0x0200013B RID: 315
		public sealed class Class1565 : IEnumerable
		{
			// Token: 0x060006CC RID: 1740 RVA: 0x00007A7C File Offset: 0x00005C7C
			public void method_0(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x000694C8 File Offset: 0x000676C8
			public Class2125.Class1566 method_1()
			{
				return new Class2125.Class1566(this.class2125_0);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x000694E4 File Offset: 0x000676E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400031A RID: 794
			private Class2125 class2125_0;
		}

		// Token: 0x0200013C RID: 316
		public sealed class Class1566 : IEnumerator
		{
			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000694FC File Offset: 0x000676FC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x00007A85 File Offset: 0x00005C85
			public Class1566(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
				this.int_0 = -1;
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x00007A9B File Offset: 0x00005C9B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060006D3 RID: 1747 RVA: 0x00007AA4 File Offset: 0x00005CA4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2125_0.method_6();
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x00069514 File Offset: 0x00067714
			public Class2050 method_0()
			{
				return this.class2125_0.method_7(this.int_0);
			}

			// Token: 0x0400031B RID: 795
			private int int_0;

			// Token: 0x0400031C RID: 796
			private Class2125 class2125_0;
		}

		// Token: 0x0200013D RID: 317
		public sealed class Class1567 : IEnumerable
		{
			// Token: 0x060006D5 RID: 1749 RVA: 0x00007AC7 File Offset: 0x00005CC7
			public void method_0(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00069534 File Offset: 0x00067734
			public Class2125.Class1568 method_1()
			{
				return new Class2125.Class1568(this.class2125_0);
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x00069550 File Offset: 0x00067750
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400031D RID: 797
			private Class2125 class2125_0;
		}

		// Token: 0x0200013E RID: 318
		public sealed class Class1568 : IEnumerator
		{
			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00069568 File Offset: 0x00067768
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00007AD0 File Offset: 0x00005CD0
			public Class1568(Class2125 class2125_1)
			{
				this.class2125_0 = class2125_1;
				this.int_0 = -1;
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x00007AE6 File Offset: 0x00005CE6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00007AEF File Offset: 0x00005CEF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2125_0.method_8();
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x00069580 File Offset: 0x00067780
			public Class2128 method_0()
			{
				return this.class2125_0.method_9(this.int_0);
			}

			// Token: 0x0400031E RID: 798
			private int int_0;

			// Token: 0x0400031F RID: 799
			private Class2125 class2125_0;
		}
	}
}
