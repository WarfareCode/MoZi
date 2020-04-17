using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x020001A6 RID: 422
	public sealed class Class2134 : Class2059
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
		public Class2134()
		{
			this.method_14();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0006C5FC File Offset: 0x0006A7FC
		public Class2134(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0006812C File Offset: 0x0006632C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name");
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0006814C File Offset: 0x0006634C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name", int_0)));
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0005B2A4 File Offset: 0x000594A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title");
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0005B2C4 File Offset: 0x000594C4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title", int_0)));
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00068178 File Offset: 0x00066378
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract");
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00068198 File Offset: 0x00066398
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract", int_0)));
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0006C658 File Offset: 0x0006A858
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LegendURL");
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0006C678 File Offset: 0x0006A878
		public Class2125 method_9(int int_0)
		{
			return new Class2125(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LegendURL", int_0));
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0006C6A0 File Offset: 0x0006A8A0
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StyleSheetURL");
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0006C6C0 File Offset: 0x0006A8C0
		public Class2133 method_11(int int_0)
		{
			return new Class2133(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StyleSheetURL", int_0));
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0006C6E8 File Offset: 0x0006A8E8
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StyleURL");
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0006C708 File Offset: 0x0006A908
		public Class2135 method_13(int int_0)
		{
			return new Class2135(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StyleURL", int_0));
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0006C730 File Offset: 0x0006A930
		private void method_14()
		{
			this.class1635_0.method_0(this);
			this.class1637_0.method_0(this);
			this.class1639_0.method_0(this);
			this.class1641_0.method_0(this);
			this.class1643_0.method_0(this);
			this.class1645_0.method_0(this);
		}

		// Token: 0x040003E3 RID: 995
		public Class2134.Class1635 class1635_0 = new Class2134.Class1635();

		// Token: 0x040003E4 RID: 996
		public Class2134.Class1637 class1637_0 = new Class2134.Class1637();

		// Token: 0x040003E5 RID: 997
		public Class2134.Class1639 class1639_0 = new Class2134.Class1639();

		// Token: 0x040003E6 RID: 998
		public Class2134.Class1641 class1641_0 = new Class2134.Class1641();

		// Token: 0x040003E7 RID: 999
		public Class2134.Class1643 class1643_0 = new Class2134.Class1643();

		// Token: 0x040003E8 RID: 1000
		public Class2134.Class1645 class1645_0 = new Class2134.Class1645();

		// Token: 0x020001A7 RID: 423
		public sealed class Class1635 : IEnumerable
		{
			// Token: 0x0600095D RID: 2397 RVA: 0x00008F33 File Offset: 0x00007133
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x0006C788 File Offset: 0x0006A988
			public Class2134.Class1636 method_1()
			{
				return new Class2134.Class1636(this.class2134_0);
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x0006C7A4 File Offset: 0x0006A9A4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003E9 RID: 1001
			private Class2134 class2134_0;
		}

		// Token: 0x020001A8 RID: 424
		public sealed class Class1636 : IEnumerator
		{
			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000961 RID: 2401 RVA: 0x0006C7BC File Offset: 0x0006A9BC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000962 RID: 2402 RVA: 0x00008F3C File Offset: 0x0000713C
			public Class1636(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x00008F52 File Offset: 0x00007152
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x00008F5B File Offset: 0x0000715B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_2();
			}

			// Token: 0x06000965 RID: 2405 RVA: 0x0006C7D4 File Offset: 0x0006A9D4
			public Class2050 method_0()
			{
				return this.class2134_0.method_3(this.int_0);
			}

			// Token: 0x040003EA RID: 1002
			private int int_0;

			// Token: 0x040003EB RID: 1003
			private Class2134 class2134_0;
		}

		// Token: 0x020001A9 RID: 425
		public sealed class Class1637 : IEnumerable
		{
			// Token: 0x06000966 RID: 2406 RVA: 0x00008F7E File Offset: 0x0000717E
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x06000967 RID: 2407 RVA: 0x0006C7F4 File Offset: 0x0006A9F4
			public Class2134.Class1638 method_1()
			{
				return new Class2134.Class1638(this.class2134_0);
			}

			// Token: 0x06000968 RID: 2408 RVA: 0x0006C810 File Offset: 0x0006AA10
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003EC RID: 1004
			private Class2134 class2134_0;
		}

		// Token: 0x020001AA RID: 426
		public sealed class Class1638 : IEnumerator
		{
			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600096A RID: 2410 RVA: 0x0006C828 File Offset: 0x0006AA28
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600096B RID: 2411 RVA: 0x00008F87 File Offset: 0x00007187
			public Class1638(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x00008F9D File Offset: 0x0000719D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x00008FA6 File Offset: 0x000071A6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_4();
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x0006C840 File Offset: 0x0006AA40
			public Class2050 method_0()
			{
				return this.class2134_0.method_5(this.int_0);
			}

			// Token: 0x040003ED RID: 1005
			private int int_0;

			// Token: 0x040003EE RID: 1006
			private Class2134 class2134_0;
		}

		// Token: 0x020001AB RID: 427
		public sealed class Class1639 : IEnumerable
		{
			// Token: 0x0600096F RID: 2415 RVA: 0x00008FC9 File Offset: 0x000071C9
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x06000970 RID: 2416 RVA: 0x0006C860 File Offset: 0x0006AA60
			public Class2134.Class1640 method_1()
			{
				return new Class2134.Class1640(this.class2134_0);
			}

			// Token: 0x06000971 RID: 2417 RVA: 0x0006C87C File Offset: 0x0006AA7C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003EF RID: 1007
			private Class2134 class2134_0;
		}

		// Token: 0x020001AC RID: 428
		public sealed class Class1640 : IEnumerator
		{
			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000973 RID: 2419 RVA: 0x0006C894 File Offset: 0x0006AA94
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x00008FD2 File Offset: 0x000071D2
			public Class1640(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x00008FE8 File Offset: 0x000071E8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x00008FF1 File Offset: 0x000071F1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_6();
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x0006C8AC File Offset: 0x0006AAAC
			public Class2050 method_0()
			{
				return this.class2134_0.method_7(this.int_0);
			}

			// Token: 0x040003F0 RID: 1008
			private int int_0;

			// Token: 0x040003F1 RID: 1009
			private Class2134 class2134_0;
		}

		// Token: 0x020001AD RID: 429
		public sealed class Class1641 : IEnumerable
		{
			// Token: 0x06000978 RID: 2424 RVA: 0x00009014 File Offset: 0x00007214
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x0006C8CC File Offset: 0x0006AACC
			public Class2134.Class1642 method_1()
			{
				return new Class2134.Class1642(this.class2134_0);
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003F2 RID: 1010
			private Class2134 class2134_0;
		}

		// Token: 0x020001AE RID: 430
		public sealed class Class1642 : IEnumerator
		{
			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x0600097C RID: 2428 RVA: 0x0006C900 File Offset: 0x0006AB00
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600097D RID: 2429 RVA: 0x0000901D File Offset: 0x0000721D
			public Class1642(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x00009033 File Offset: 0x00007233
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600097F RID: 2431 RVA: 0x0000903C File Offset: 0x0000723C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_8();
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x0006C918 File Offset: 0x0006AB18
			public Class2125 method_0()
			{
				return this.class2134_0.method_9(this.int_0);
			}

			// Token: 0x040003F3 RID: 1011
			private int int_0;

			// Token: 0x040003F4 RID: 1012
			private Class2134 class2134_0;
		}

		// Token: 0x020001AF RID: 431
		public sealed class Class1643 : IEnumerable
		{
			// Token: 0x06000981 RID: 2433 RVA: 0x0000905F File Offset: 0x0000725F
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x0006C938 File Offset: 0x0006AB38
			public Class2134.Class1644 method_1()
			{
				return new Class2134.Class1644(this.class2134_0);
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x0006C954 File Offset: 0x0006AB54
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003F5 RID: 1013
			private Class2134 class2134_0;
		}

		// Token: 0x020001B0 RID: 432
		public sealed class Class1644 : IEnumerator
		{
			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000985 RID: 2437 RVA: 0x0006C96C File Offset: 0x0006AB6C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x00009068 File Offset: 0x00007268
			public Class1644(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x0000907E File Offset: 0x0000727E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x00009087 File Offset: 0x00007287
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_10();
			}

			// Token: 0x06000989 RID: 2441 RVA: 0x0006C984 File Offset: 0x0006AB84
			public Class2133 method_0()
			{
				return this.class2134_0.method_11(this.int_0);
			}

			// Token: 0x040003F6 RID: 1014
			private int int_0;

			// Token: 0x040003F7 RID: 1015
			private Class2134 class2134_0;
		}

		// Token: 0x020001B1 RID: 433
		public sealed class Class1645 : IEnumerable
		{
			// Token: 0x0600098A RID: 2442 RVA: 0x000090AA File Offset: 0x000072AA
			public void method_0(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x0006C9A4 File Offset: 0x0006ABA4
			public Class2134.Class1646 method_1()
			{
				return new Class2134.Class1646(this.class2134_0);
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003F8 RID: 1016
			private Class2134 class2134_0;
		}

		// Token: 0x020001B2 RID: 434
		public sealed class Class1646 : IEnumerator
		{
			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x0600098E RID: 2446 RVA: 0x0006C9D8 File Offset: 0x0006ABD8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x000090B3 File Offset: 0x000072B3
			public Class1646(Class2134 class2134_1)
			{
				this.class2134_0 = class2134_1;
				this.int_0 = -1;
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x000090C9 File Offset: 0x000072C9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x000090D2 File Offset: 0x000072D2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2134_0.method_12();
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x0006C9F0 File Offset: 0x0006ABF0
			public Class2135 method_0()
			{
				return this.class2134_0.method_13(this.int_0);
			}

			// Token: 0x040003F9 RID: 1017
			private int int_0;

			// Token: 0x040003FA RID: 1018
			private Class2134 class2134_0;
		}
	}
}
