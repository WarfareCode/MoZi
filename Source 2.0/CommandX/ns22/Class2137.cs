using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x020001D3 RID: 467
	public sealed class Class2137 : Class2059
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00009CAB File Offset: 0x00007EAB
		public Class2137()
		{
			this.method_8();
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00009CDA File Offset: 0x00007EDA
		public Class2137(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00077908 File Offset: 0x00075B08
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Title");
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00077928 File Offset: 0x00075B28
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Title", int_0)));
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0007799C File Offset: 0x00075B9C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LogoURL");
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000779BC File Offset: 0x00075BBC
		public Class2163 method_7(int int_0)
		{
			return new Class2163(base.method_1(Class2059.Enum155.const_1, "", "LogoURL", int_0));
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00009D0A File Offset: 0x00007F0A
		private void method_8()
		{
			this.class1659_0.method_0(this);
			this.class1661_0.method_0(this);
			this.class1663_0.method_0(this);
		}

		// Token: 0x040004E4 RID: 1252
		public Class2137.Class1659 class1659_0 = new Class2137.Class1659();

		// Token: 0x040004E5 RID: 1253
		public Class2137.Class1661 class1661_0 = new Class2137.Class1661();

		// Token: 0x040004E6 RID: 1254
		public Class2137.Class1663 class1663_0 = new Class2137.Class1663();

		// Token: 0x020001D4 RID: 468
		public sealed class Class1659 : IEnumerable
		{
			// Token: 0x06000B1B RID: 2843 RVA: 0x00009D30 File Offset: 0x00007F30
			public void method_0(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
			}

			// Token: 0x06000B1C RID: 2844 RVA: 0x000779E4 File Offset: 0x00075BE4
			public Class2137.Class1660 method_1()
			{
				return new Class2137.Class1660(this.class2137_0);
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x00077A00 File Offset: 0x00075C00
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004E7 RID: 1255
			private Class2137 class2137_0;
		}

		// Token: 0x020001D5 RID: 469
		public sealed class Class1660 : IEnumerator
		{
			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00077A18 File Offset: 0x00075C18
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B20 RID: 2848 RVA: 0x00009D39 File Offset: 0x00007F39
			public Class1660(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B21 RID: 2849 RVA: 0x00009D4F File Offset: 0x00007F4F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B22 RID: 2850 RVA: 0x00009D58 File Offset: 0x00007F58
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2137_0.method_2();
			}

			// Token: 0x06000B23 RID: 2851 RVA: 0x00077A30 File Offset: 0x00075C30
			public Class2050 method_0()
			{
				return this.class2137_0.method_3(this.int_0);
			}

			// Token: 0x040004E8 RID: 1256
			private int int_0;

			// Token: 0x040004E9 RID: 1257
			private Class2137 class2137_0;
		}

		// Token: 0x020001D6 RID: 470
		public sealed class Class1661 : IEnumerable
		{
			// Token: 0x06000B24 RID: 2852 RVA: 0x00009D7B File Offset: 0x00007F7B
			public void method_0(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
			}

			// Token: 0x06000B25 RID: 2853 RVA: 0x00077A50 File Offset: 0x00075C50
			public Class2137.Class1662 method_1()
			{
				return new Class2137.Class1662(this.class2137_0);
			}

			// Token: 0x06000B26 RID: 2854 RVA: 0x00077A6C File Offset: 0x00075C6C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004EA RID: 1258
			private Class2137 class2137_0;
		}

		// Token: 0x020001D7 RID: 471
		public sealed class Class1662 : IEnumerator
		{
			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00077A84 File Offset: 0x00075C84
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B29 RID: 2857 RVA: 0x00009D84 File Offset: 0x00007F84
			public Class1662(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x00009D9A File Offset: 0x00007F9A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B2B RID: 2859 RVA: 0x00009DA3 File Offset: 0x00007FA3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2137_0.method_4();
			}

			// Token: 0x06000B2C RID: 2860 RVA: 0x00077A9C File Offset: 0x00075C9C
			public Class2165 method_0()
			{
				return this.class2137_0.method_5(this.int_0);
			}

			// Token: 0x040004EB RID: 1259
			private int int_0;

			// Token: 0x040004EC RID: 1260
			private Class2137 class2137_0;
		}

		// Token: 0x020001D8 RID: 472
		public sealed class Class1663 : IEnumerable
		{
			// Token: 0x06000B2D RID: 2861 RVA: 0x00009DC6 File Offset: 0x00007FC6
			public void method_0(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
			}

			// Token: 0x06000B2E RID: 2862 RVA: 0x00077ABC File Offset: 0x00075CBC
			public Class2137.Class1664 method_1()
			{
				return new Class2137.Class1664(this.class2137_0);
			}

			// Token: 0x06000B2F RID: 2863 RVA: 0x00077AD8 File Offset: 0x00075CD8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004ED RID: 1261
			private Class2137 class2137_0;
		}

		// Token: 0x020001D9 RID: 473
		public sealed class Class1664 : IEnumerator
		{
			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00077AF0 File Offset: 0x00075CF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B32 RID: 2866 RVA: 0x00009DCF File Offset: 0x00007FCF
			public Class1664(Class2137 class2137_1)
			{
				this.class2137_0 = class2137_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x00009DE5 File Offset: 0x00007FE5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x00009DEE File Offset: 0x00007FEE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2137_0.method_6();
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x00077B08 File Offset: 0x00075D08
			public Class2163 method_0()
			{
				return this.class2137_0.method_7(this.int_0);
			}

			// Token: 0x040004EE RID: 1262
			private int int_0;

			// Token: 0x040004EF RID: 1263
			private Class2137 class2137_0;
		}
	}
}
