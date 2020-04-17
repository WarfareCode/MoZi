using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x02000142 RID: 322
	public sealed class Class2126 : Class2059
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00007C89 File Offset: 0x00005E89
		public Class2126()
		{
			this.method_10();
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00007CC3 File Offset: 0x00005EC3
		public Class2126(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00069358 File Offset: 0x00067558
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "width");
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00069378 File Offset: 0x00067578
		public Class2018 method_3(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "width", int_0)));
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000693A4 File Offset: 0x000675A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "height");
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000693C4 File Offset: 0x000675C4
		public Class2018 method_5(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "height", int_0)));
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_9(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00007CFE File Offset: 0x00005EFE
		private void method_10()
		{
			this.class1569_0.method_0(this);
			this.class1571_0.method_0(this);
			this.class1573_0.method_0(this);
			this.class1575_0.method_0(this);
		}

		// Token: 0x0400032C RID: 812
		public Class2126.Class1569 class1569_0 = new Class2126.Class1569();

		// Token: 0x0400032D RID: 813
		public Class2126.Class1571 class1571_0 = new Class2126.Class1571();

		// Token: 0x0400032E RID: 814
		public Class2126.Class1573 class1573_0 = new Class2126.Class1573();

		// Token: 0x0400032F RID: 815
		public Class2126.Class1575 class1575_0 = new Class2126.Class1575();

		// Token: 0x02000143 RID: 323
		public sealed class Class1569 : IEnumerable
		{
			// Token: 0x06000705 RID: 1797 RVA: 0x00007D30 File Offset: 0x00005F30
			public void method_0(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x00069840 File Offset: 0x00067A40
			public Class2126.Class1570 method_1()
			{
				return new Class2126.Class1570(this.class2126_0);
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x0006985C File Offset: 0x00067A5C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000330 RID: 816
			private Class2126 class2126_0;
		}

		// Token: 0x02000144 RID: 324
		public sealed class Class1570 : IEnumerator
		{
			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x00069874 File Offset: 0x00067A74
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x00007D39 File Offset: 0x00005F39
			public Class1570(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
				this.int_0 = -1;
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x00007D4F File Offset: 0x00005F4F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x00007D58 File Offset: 0x00005F58
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2126_0.method_2();
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x0006988C File Offset: 0x00067A8C
			public Class2018 method_0()
			{
				return this.class2126_0.method_3(this.int_0);
			}

			// Token: 0x04000331 RID: 817
			private int int_0;

			// Token: 0x04000332 RID: 818
			private Class2126 class2126_0;
		}

		// Token: 0x02000145 RID: 325
		public sealed class Class1571 : IEnumerable
		{
			// Token: 0x0600070E RID: 1806 RVA: 0x00007D7B File Offset: 0x00005F7B
			public void method_0(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x000698AC File Offset: 0x00067AAC
			public Class2126.Class1572 method_1()
			{
				return new Class2126.Class1572(this.class2126_0);
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x000698C8 File Offset: 0x00067AC8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000333 RID: 819
			private Class2126 class2126_0;
		}

		// Token: 0x02000146 RID: 326
		public sealed class Class1572 : IEnumerator
		{
			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x000698E0 File Offset: 0x00067AE0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000713 RID: 1811 RVA: 0x00007D84 File Offset: 0x00005F84
			public Class1572(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
				this.int_0 = -1;
			}

			// Token: 0x06000714 RID: 1812 RVA: 0x00007D9A File Offset: 0x00005F9A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00007DA3 File Offset: 0x00005FA3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2126_0.method_4();
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x000698F8 File Offset: 0x00067AF8
			public Class2018 method_0()
			{
				return this.class2126_0.method_5(this.int_0);
			}

			// Token: 0x04000334 RID: 820
			private int int_0;

			// Token: 0x04000335 RID: 821
			private Class2126 class2126_0;
		}

		// Token: 0x02000147 RID: 327
		public sealed class Class1573 : IEnumerable
		{
			// Token: 0x06000717 RID: 1815 RVA: 0x00007DC6 File Offset: 0x00005FC6
			public void method_0(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
			}

			// Token: 0x06000718 RID: 1816 RVA: 0x00069918 File Offset: 0x00067B18
			public Class2126.Class1574 method_1()
			{
				return new Class2126.Class1574(this.class2126_0);
			}

			// Token: 0x06000719 RID: 1817 RVA: 0x00069934 File Offset: 0x00067B34
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000336 RID: 822
			private Class2126 class2126_0;
		}

		// Token: 0x02000148 RID: 328
		public sealed class Class1574 : IEnumerator
		{
			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600071B RID: 1819 RVA: 0x0006994C File Offset: 0x00067B4C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x00007DCF File Offset: 0x00005FCF
			public Class1574(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
				this.int_0 = -1;
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x00007DE5 File Offset: 0x00005FE5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x00007DEE File Offset: 0x00005FEE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2126_0.method_6();
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x00069964 File Offset: 0x00067B64
			public Class2050 method_0()
			{
				return this.class2126_0.method_7(this.int_0);
			}

			// Token: 0x04000337 RID: 823
			private int int_0;

			// Token: 0x04000338 RID: 824
			private Class2126 class2126_0;
		}

		// Token: 0x02000149 RID: 329
		public sealed class Class1575 : IEnumerable
		{
			// Token: 0x06000720 RID: 1824 RVA: 0x00007E11 File Offset: 0x00006011
			public void method_0(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
			}

			// Token: 0x06000721 RID: 1825 RVA: 0x00069984 File Offset: 0x00067B84
			public Class2126.Class1576 method_1()
			{
				return new Class2126.Class1576(this.class2126_0);
			}

			// Token: 0x06000722 RID: 1826 RVA: 0x000699A0 File Offset: 0x00067BA0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000339 RID: 825
			private Class2126 class2126_0;
		}

		// Token: 0x0200014A RID: 330
		public sealed class Class1576 : IEnumerator
		{
			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000724 RID: 1828 RVA: 0x000699B8 File Offset: 0x00067BB8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x00007E1A File Offset: 0x0000601A
			public Class1576(Class2126 class2126_1)
			{
				this.class2126_0 = class2126_1;
				this.int_0 = -1;
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00007E30 File Offset: 0x00006030
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x00007E39 File Offset: 0x00006039
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2126_0.method_8();
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x000699D0 File Offset: 0x00067BD0
			public Class2128 method_0()
			{
				return this.class2126_0.method_9(this.int_0);
			}

			// Token: 0x0400033A RID: 826
			private int int_0;

			// Token: 0x0400033B RID: 827
			private Class2126 class2126_0;
		}
	}
}
