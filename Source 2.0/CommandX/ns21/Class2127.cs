using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x02000153 RID: 339
	public sealed class Class2127 : Class2059
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x00007F75 File Offset: 0x00006175
		public Class2127()
		{
			this.method_8();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00007FA4 File Offset: 0x000061A4
		public Class2127(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00069CD8 File Offset: 0x00067ED8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "type");
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00069CF8 File Offset: 0x00067EF8
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "type", int_0)));
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_7(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00007FD4 File Offset: 0x000061D4
		private void method_8()
		{
			this.class1577_0.method_0(this);
			this.class1579_0.method_0(this);
			this.class1581_0.method_0(this);
		}

		// Token: 0x0400034A RID: 842
		public Class2127.Class1577 class1577_0 = new Class2127.Class1577();

		// Token: 0x0400034B RID: 843
		public Class2127.Class1579 class1579_0 = new Class2127.Class1579();

		// Token: 0x0400034C RID: 844
		public Class2127.Class1581 class1581_0 = new Class2127.Class1581();

		// Token: 0x02000154 RID: 340
		public sealed class Class1577 : IEnumerable
		{
			// Token: 0x06000758 RID: 1880 RVA: 0x00007FFA File Offset: 0x000061FA
			public void method_0(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x00069D24 File Offset: 0x00067F24
			public Class2127.Class1578 method_1()
			{
				return new Class2127.Class1578(this.class2127_0);
			}

			// Token: 0x0600075A RID: 1882 RVA: 0x00069D40 File Offset: 0x00067F40
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400034D RID: 845
			private Class2127 class2127_0;
		}

		// Token: 0x02000155 RID: 341
		public sealed class Class1578 : IEnumerator
		{
			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x00069D58 File Offset: 0x00067F58
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600075D RID: 1885 RVA: 0x00008003 File Offset: 0x00006203
			public Class1578(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
				this.int_0 = -1;
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x00008019 File Offset: 0x00006219
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600075F RID: 1887 RVA: 0x00008022 File Offset: 0x00006222
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2127_0.method_2();
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x00069D70 File Offset: 0x00067F70
			public Class2050 method_0()
			{
				return this.class2127_0.method_3(this.int_0);
			}

			// Token: 0x0400034E RID: 846
			private int int_0;

			// Token: 0x0400034F RID: 847
			private Class2127 class2127_0;
		}

		// Token: 0x02000156 RID: 342
		public sealed class Class1579 : IEnumerable
		{
			// Token: 0x06000761 RID: 1889 RVA: 0x00008045 File Offset: 0x00006245
			public void method_0(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00069D90 File Offset: 0x00067F90
			public Class2127.Class1580 method_1()
			{
				return new Class2127.Class1580(this.class2127_0);
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x00069DAC File Offset: 0x00067FAC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000350 RID: 848
			private Class2127 class2127_0;
		}

		// Token: 0x02000157 RID: 343
		public sealed class Class1580 : IEnumerator
		{
			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000765 RID: 1893 RVA: 0x00069DC4 File Offset: 0x00067FC4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000766 RID: 1894 RVA: 0x0000804E File Offset: 0x0000624E
			public Class1580(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
				this.int_0 = -1;
			}

			// Token: 0x06000767 RID: 1895 RVA: 0x00008064 File Offset: 0x00006264
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x0000806D File Offset: 0x0000626D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2127_0.method_4();
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x00069DDC File Offset: 0x00067FDC
			public Class2050 method_0()
			{
				return this.class2127_0.method_5(this.int_0);
			}

			// Token: 0x04000351 RID: 849
			private int int_0;

			// Token: 0x04000352 RID: 850
			private Class2127 class2127_0;
		}

		// Token: 0x02000158 RID: 344
		public sealed class Class1581 : IEnumerable
		{
			// Token: 0x0600076A RID: 1898 RVA: 0x00008090 File Offset: 0x00006290
			public void method_0(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
			}

			// Token: 0x0600076B RID: 1899 RVA: 0x00069DFC File Offset: 0x00067FFC
			public Class2127.Class1582 method_1()
			{
				return new Class2127.Class1582(this.class2127_0);
			}

			// Token: 0x0600076C RID: 1900 RVA: 0x00069E18 File Offset: 0x00068018
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000353 RID: 851
			private Class2127 class2127_0;
		}

		// Token: 0x02000159 RID: 345
		public sealed class Class1582 : IEnumerator
		{
			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x00069E30 File Offset: 0x00068030
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x00008099 File Offset: 0x00006299
			public Class1582(Class2127 class2127_1)
			{
				this.class2127_0 = class2127_1;
				this.int_0 = -1;
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x000080AF File Offset: 0x000062AF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000771 RID: 1905 RVA: 0x000080B8 File Offset: 0x000062B8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2127_0.method_6();
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00069E48 File Offset: 0x00068048
			public Class2128 method_0()
			{
				return this.class2127_0.method_7(this.int_0);
			}

			// Token: 0x04000354 RID: 852
			private int int_0;

			// Token: 0x04000355 RID: 853
			private Class2127 class2127_0;
		}
	}
}
