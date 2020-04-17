using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x0200016E RID: 366
	public sealed class Class2129 : Class2059
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x00008583 File Offset: 0x00006783
		public Class2129()
		{
			this.method_6();
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000085A7 File Offset: 0x000067A7
		public Class2129(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0006ABD8 File Offset: 0x00068DD8
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "DCPType");
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		public Class2114 method_5(int int_0)
		{
			return new Class2114(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "DCPType", int_0));
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000085CC File Offset: 0x000067CC
		private void method_6()
		{
			this.class1597_0.method_0(this);
			this.class1599_0.method_0(this);
		}

		// Token: 0x0400037D RID: 893
		public Class2129.Class1597 class1597_0 = new Class2129.Class1597();

		// Token: 0x0400037E RID: 894
		public Class2129.Class1599 class1599_0 = new Class2129.Class1599();

		// Token: 0x0200016F RID: 367
		public sealed class Class1597 : IEnumerable
		{
			// Token: 0x06000802 RID: 2050 RVA: 0x000085E6 File Offset: 0x000067E6
			public void method_0(Class2129 class2129_1)
			{
				this.class2129_0 = class2129_1;
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x0006AC20 File Offset: 0x00068E20
			public Class2129.Class1598 method_1()
			{
				return new Class2129.Class1598(this.class2129_0);
			}

			// Token: 0x06000804 RID: 2052 RVA: 0x0006AC3C File Offset: 0x00068E3C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400037F RID: 895
			private Class2129 class2129_0;
		}

		// Token: 0x02000170 RID: 368
		public sealed class Class1598 : IEnumerator
		{
			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x0006AC54 File Offset: 0x00068E54
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000807 RID: 2055 RVA: 0x000085EF File Offset: 0x000067EF
			public Class1598(Class2129 class2129_1)
			{
				this.class2129_0 = class2129_1;
				this.int_0 = -1;
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x00008605 File Offset: 0x00006805
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000809 RID: 2057 RVA: 0x0000860E File Offset: 0x0000680E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2129_0.method_2();
			}

			// Token: 0x0600080A RID: 2058 RVA: 0x0006AC6C File Offset: 0x00068E6C
			public Class2050 method_0()
			{
				return this.class2129_0.method_3(this.int_0);
			}

			// Token: 0x04000380 RID: 896
			private int int_0;

			// Token: 0x04000381 RID: 897
			private Class2129 class2129_0;
		}

		// Token: 0x02000171 RID: 369
		public sealed class Class1599 : IEnumerable
		{
			// Token: 0x0600080B RID: 2059 RVA: 0x00008631 File Offset: 0x00006831
			public void method_0(Class2129 class2129_1)
			{
				this.class2129_0 = class2129_1;
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x0006AC8C File Offset: 0x00068E8C
			public Class2129.Class1600 method_1()
			{
				return new Class2129.Class1600(this.class2129_0);
			}

			// Token: 0x0600080D RID: 2061 RVA: 0x0006ACA8 File Offset: 0x00068EA8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000382 RID: 898
			private Class2129 class2129_0;
		}

		// Token: 0x02000172 RID: 370
		public sealed class Class1600 : IEnumerator
		{
			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600080F RID: 2063 RVA: 0x0006ACC0 File Offset: 0x00068EC0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x0000863A File Offset: 0x0000683A
			public Class1600(Class2129 class2129_1)
			{
				this.class2129_0 = class2129_1;
				this.int_0 = -1;
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x00008650 File Offset: 0x00006850
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x00008659 File Offset: 0x00006859
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2129_0.method_4();
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x0006ACD8 File Offset: 0x00068ED8
			public Class2114 method_0()
			{
				return this.class2129_0.method_5(this.int_0);
			}

			// Token: 0x04000383 RID: 899
			private int int_0;

			// Token: 0x04000384 RID: 900
			private Class2129 class2129_0;
		}
	}
}
