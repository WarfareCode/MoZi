using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000177 RID: 375
	public sealed class Class2131 : Class2059
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x000087A2 File Offset: 0x000069A2
		public Class2131()
		{
			this.method_8();
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000087D1 File Offset: 0x000069D1
		public Class2131(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0006AFB8 File Offset: 0x000691B8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetCapabilities");
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0006AFD8 File Offset: 0x000691D8
		public Class2129 method_3(int int_0)
		{
			return new Class2129(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetCapabilities", int_0));
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0006B000 File Offset: 0x00069200
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetMap");
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0006B020 File Offset: 0x00069220
		public Class2129 method_5(int int_0)
		{
			return new Class2129(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetMap", int_0));
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0006B048 File Offset: 0x00069248
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetFeatureInfo");
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0006B068 File Offset: 0x00069268
		public Class2129 method_7(int int_0)
		{
			return new Class2129(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "GetFeatureInfo", int_0));
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00008801 File Offset: 0x00006A01
		private void method_8()
		{
			this.class1603_0.method_0(this);
			this.class1605_0.method_0(this);
			this.class1607_0.method_0(this);
		}

		// Token: 0x0400038B RID: 907
		public Class2131.Class1603 class1603_0 = new Class2131.Class1603();

		// Token: 0x0400038C RID: 908
		public Class2131.Class1605 class1605_0 = new Class2131.Class1605();

		// Token: 0x0400038D RID: 909
		public Class2131.Class1607 class1607_0 = new Class2131.Class1607();

		// Token: 0x02000178 RID: 376
		public sealed class Class1603 : IEnumerable
		{
			// Token: 0x06000840 RID: 2112 RVA: 0x00008827 File Offset: 0x00006A27
			public void method_0(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
			}

			// Token: 0x06000841 RID: 2113 RVA: 0x0006B090 File Offset: 0x00069290
			public Class2131.Class1604 method_1()
			{
				return new Class2131.Class1604(this.class2131_0);
			}

			// Token: 0x06000842 RID: 2114 RVA: 0x0006B0AC File Offset: 0x000692AC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400038E RID: 910
			private Class2131 class2131_0;
		}

		// Token: 0x02000179 RID: 377
		public sealed class Class1604 : IEnumerator
		{
			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000844 RID: 2116 RVA: 0x0006B0C4 File Offset: 0x000692C4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000845 RID: 2117 RVA: 0x00008830 File Offset: 0x00006A30
			public Class1604(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
				this.int_0 = -1;
			}

			// Token: 0x06000846 RID: 2118 RVA: 0x00008846 File Offset: 0x00006A46
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000847 RID: 2119 RVA: 0x0000884F File Offset: 0x00006A4F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2131_0.method_2();
			}

			// Token: 0x06000848 RID: 2120 RVA: 0x0006B0DC File Offset: 0x000692DC
			public Class2129 method_0()
			{
				return this.class2131_0.method_3(this.int_0);
			}

			// Token: 0x0400038F RID: 911
			private int int_0;

			// Token: 0x04000390 RID: 912
			private Class2131 class2131_0;
		}

		// Token: 0x0200017A RID: 378
		public sealed class Class1605 : IEnumerable
		{
			// Token: 0x06000849 RID: 2121 RVA: 0x00008872 File Offset: 0x00006A72
			public void method_0(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
			}

			// Token: 0x0600084A RID: 2122 RVA: 0x0006B0FC File Offset: 0x000692FC
			public Class2131.Class1606 method_1()
			{
				return new Class2131.Class1606(this.class2131_0);
			}

			// Token: 0x0600084B RID: 2123 RVA: 0x0006B118 File Offset: 0x00069318
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000391 RID: 913
			private Class2131 class2131_0;
		}

		// Token: 0x0200017B RID: 379
		public sealed class Class1606 : IEnumerator
		{
			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600084D RID: 2125 RVA: 0x0006B130 File Offset: 0x00069330
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x0000887B File Offset: 0x00006A7B
			public Class1606(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
				this.int_0 = -1;
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x00008891 File Offset: 0x00006A91
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000850 RID: 2128 RVA: 0x0000889A File Offset: 0x00006A9A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2131_0.method_4();
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x0006B148 File Offset: 0x00069348
			public Class2129 method_0()
			{
				return this.class2131_0.method_5(this.int_0);
			}

			// Token: 0x04000392 RID: 914
			private int int_0;

			// Token: 0x04000393 RID: 915
			private Class2131 class2131_0;
		}

		// Token: 0x0200017C RID: 380
		public sealed class Class1607 : IEnumerable
		{
			// Token: 0x06000852 RID: 2130 RVA: 0x000088BD File Offset: 0x00006ABD
			public void method_0(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x0006B168 File Offset: 0x00069368
			public Class2131.Class1608 method_1()
			{
				return new Class2131.Class1608(this.class2131_0);
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x0006B184 File Offset: 0x00069384
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000394 RID: 916
			private Class2131 class2131_0;
		}

		// Token: 0x0200017D RID: 381
		public sealed class Class1608 : IEnumerator
		{
			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000856 RID: 2134 RVA: 0x0006B19C File Offset: 0x0006939C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x000088C6 File Offset: 0x00006AC6
			public Class1608(Class2131 class2131_1)
			{
				this.class2131_0 = class2131_1;
				this.int_0 = -1;
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x000088DC File Offset: 0x00006ADC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000859 RID: 2137 RVA: 0x000088E5 File Offset: 0x00006AE5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2131_0.method_6();
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x0006B1B4 File Offset: 0x000693B4
			public Class2129 method_0()
			{
				return this.class2131_0.method_7(this.int_0);
			}

			// Token: 0x04000395 RID: 917
			private int int_0;

			// Token: 0x04000396 RID: 918
			private Class2131 class2131_0;
		}
	}
}
