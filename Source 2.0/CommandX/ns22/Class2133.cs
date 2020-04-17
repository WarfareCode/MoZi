using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x020001A0 RID: 416
	public sealed class Class2133 : Class2059
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x00008E3A File Offset: 0x0000703A
		public Class2133()
		{
			this.method_6();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00008E5E File Offset: 0x0000705E
		public Class2133(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00008E83 File Offset: 0x00007083
		private void method_6()
		{
			this.class1631_0.method_0(this);
			this.class1633_0.method_0(this);
		}

		// Token: 0x040003DB RID: 987
		public Class2133.Class1631 class1631_0 = new Class2133.Class1631();

		// Token: 0x040003DC RID: 988
		public Class2133.Class1633 class1633_0 = new Class2133.Class1633();

		// Token: 0x020001A1 RID: 417
		public sealed class Class1631 : IEnumerable
		{
			// Token: 0x06000938 RID: 2360 RVA: 0x00008E9D File Offset: 0x0000709D
			public void method_0(Class2133 class2133_1)
			{
				this.class2133_0 = class2133_1;
			}

			// Token: 0x06000939 RID: 2361 RVA: 0x0006C4C8 File Offset: 0x0006A6C8
			public Class2133.Class1632 method_1()
			{
				return new Class2133.Class1632(this.class2133_0);
			}

			// Token: 0x0600093A RID: 2362 RVA: 0x0006C4E4 File Offset: 0x0006A6E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003DD RID: 989
			private Class2133 class2133_0;
		}

		// Token: 0x020001A2 RID: 418
		public sealed class Class1632 : IEnumerator
		{
			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x0600093C RID: 2364 RVA: 0x0006C4FC File Offset: 0x0006A6FC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600093D RID: 2365 RVA: 0x00008EA6 File Offset: 0x000070A6
			public Class1632(Class2133 class2133_1)
			{
				this.class2133_0 = class2133_1;
				this.int_0 = -1;
			}

			// Token: 0x0600093E RID: 2366 RVA: 0x00008EBC File Offset: 0x000070BC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600093F RID: 2367 RVA: 0x00008EC5 File Offset: 0x000070C5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2133_0.method_2();
			}

			// Token: 0x06000940 RID: 2368 RVA: 0x0006C514 File Offset: 0x0006A714
			public Class2050 method_0()
			{
				return this.class2133_0.method_3(this.int_0);
			}

			// Token: 0x040003DE RID: 990
			private int int_0;

			// Token: 0x040003DF RID: 991
			private Class2133 class2133_0;
		}

		// Token: 0x020001A3 RID: 419
		public sealed class Class1633 : IEnumerable
		{
			// Token: 0x06000941 RID: 2369 RVA: 0x00008EE8 File Offset: 0x000070E8
			public void method_0(Class2133 class2133_1)
			{
				this.class2133_0 = class2133_1;
			}

			// Token: 0x06000942 RID: 2370 RVA: 0x0006C534 File Offset: 0x0006A734
			public Class2133.Class1634 method_1()
			{
				return new Class2133.Class1634(this.class2133_0);
			}

			// Token: 0x06000943 RID: 2371 RVA: 0x0006C550 File Offset: 0x0006A750
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003E0 RID: 992
			private Class2133 class2133_0;
		}

		// Token: 0x020001A4 RID: 420
		public sealed class Class1634 : IEnumerator
		{
			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000945 RID: 2373 RVA: 0x0006C568 File Offset: 0x0006A768
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000946 RID: 2374 RVA: 0x00008EF1 File Offset: 0x000070F1
			public Class1634(Class2133 class2133_1)
			{
				this.class2133_0 = class2133_1;
				this.int_0 = -1;
			}

			// Token: 0x06000947 RID: 2375 RVA: 0x00008F07 File Offset: 0x00007107
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000948 RID: 2376 RVA: 0x00008F10 File Offset: 0x00007110
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2133_0.method_4();
			}

			// Token: 0x06000949 RID: 2377 RVA: 0x0006C580 File Offset: 0x0006A780
			public Class2128 method_0()
			{
				return this.class2133_0.method_5(this.int_0);
			}

			// Token: 0x040003E1 RID: 993
			private int int_0;

			// Token: 0x040003E2 RID: 994
			private Class2133 class2133_0;
		}
	}
}
