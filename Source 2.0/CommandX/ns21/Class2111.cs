using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000AC RID: 172
	public sealed class Class2111 : Class2059
	{
		// Token: 0x06000365 RID: 869 RVA: 0x0005F4C4 File Offset: 0x0005D6C4
		public Class2111()
		{
			this.method_14();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0005F520 File Offset: 0x0005D720
		public Class2111(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0005F57C File Offset: 0x0005D77C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPersonPrimary");
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0005F59C File Offset: 0x0005D79C
		public Class2112 method_3(int int_0)
		{
			return new Class2112(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPersonPrimary", int_0));
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0005F5C4 File Offset: 0x0005D7C4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPosition");
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPosition", int_0)));
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0005F610 File Offset: 0x0005D810
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactAddress");
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0005F630 File Offset: 0x0005D830
		public Class2110 method_7(int int_0)
		{
			return new Class2110(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactAddress", int_0));
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0005F658 File Offset: 0x0005D858
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactVoiceTelephone");
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0005F678 File Offset: 0x0005D878
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactVoiceTelephone", int_0)));
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0005F6A4 File Offset: 0x0005D8A4
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactFacsimileTelephone");
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0005F6C4 File Offset: 0x0005D8C4
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactFacsimileTelephone", int_0)));
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactElectronicMailAddress");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0005F710 File Offset: 0x0005D910
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactElectronicMailAddress", int_0)));
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0005F73C File Offset: 0x0005D93C
		private void method_14()
		{
			this.class1451_0.method_0(this);
			this.class1453_0.method_0(this);
			this.class1455_0.method_0(this);
			this.class1457_0.method_0(this);
			this.class1459_0.method_0(this);
			this.class1461_0.method_0(this);
		}

		// Token: 0x040001E3 RID: 483
		public Class2111.Class1451 class1451_0 = new Class2111.Class1451();

		// Token: 0x040001E4 RID: 484
		public Class2111.Class1453 class1453_0 = new Class2111.Class1453();

		// Token: 0x040001E5 RID: 485
		public Class2111.Class1455 class1455_0 = new Class2111.Class1455();

		// Token: 0x040001E6 RID: 486
		public Class2111.Class1457 class1457_0 = new Class2111.Class1457();

		// Token: 0x040001E7 RID: 487
		public Class2111.Class1459 class1459_0 = new Class2111.Class1459();

		// Token: 0x040001E8 RID: 488
		public Class2111.Class1461 class1461_0 = new Class2111.Class1461();

		// Token: 0x020000AD RID: 173
		public sealed class Class1451 : IEnumerable
		{
			// Token: 0x06000374 RID: 884 RVA: 0x000060F3 File Offset: 0x000042F3
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0005F794 File Offset: 0x0005D994
			public Class2111.Class1452 method_1()
			{
				return new Class2111.Class1452(this.class2111_0);
			}

			// Token: 0x06000376 RID: 886 RVA: 0x0005F7B0 File Offset: 0x0005D9B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001E9 RID: 489
			private Class2111 class2111_0;
		}

		// Token: 0x020000AE RID: 174
		public sealed class Class1452 : IEnumerator
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000379 RID: 889 RVA: 0x000060FC File Offset: 0x000042FC
			public Class1452(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00006112 File Offset: 0x00004312
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0000611B File Offset: 0x0000431B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_2();
			}

			// Token: 0x0600037C RID: 892 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
			public Class2112 method_0()
			{
				return this.class2111_0.method_3(this.int_0);
			}

			// Token: 0x040001EA RID: 490
			private int int_0;

			// Token: 0x040001EB RID: 491
			private Class2111 class2111_0;
		}

		// Token: 0x020000AF RID: 175
		public sealed class Class1453 : IEnumerable
		{
			// Token: 0x0600037D RID: 893 RVA: 0x0000613E File Offset: 0x0000433E
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x0005F800 File Offset: 0x0005DA00
			public Class2111.Class1454 method_1()
			{
				return new Class2111.Class1454(this.class2111_0);
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0005F81C File Offset: 0x0005DA1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001EC RID: 492
			private Class2111 class2111_0;
		}

		// Token: 0x020000B0 RID: 176
		public sealed class Class1454 : IEnumerator
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000381 RID: 897 RVA: 0x0005F834 File Offset: 0x0005DA34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00006147 File Offset: 0x00004347
			public Class1454(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000615D File Offset: 0x0000435D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00006166 File Offset: 0x00004366
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_4();
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0005F84C File Offset: 0x0005DA4C
			public Class2050 method_0()
			{
				return this.class2111_0.method_5(this.int_0);
			}

			// Token: 0x040001ED RID: 493
			private int int_0;

			// Token: 0x040001EE RID: 494
			private Class2111 class2111_0;
		}

		// Token: 0x020000B1 RID: 177
		public sealed class Class1455 : IEnumerable
		{
			// Token: 0x06000386 RID: 902 RVA: 0x00006189 File Offset: 0x00004389
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x06000387 RID: 903 RVA: 0x0005F86C File Offset: 0x0005DA6C
			public Class2111.Class1456 method_1()
			{
				return new Class2111.Class1456(this.class2111_0);
			}

			// Token: 0x06000388 RID: 904 RVA: 0x0005F888 File Offset: 0x0005DA88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001EF RID: 495
			private Class2111 class2111_0;
		}

		// Token: 0x020000B2 RID: 178
		public sealed class Class1456 : IEnumerator
		{
			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600038A RID: 906 RVA: 0x0005F8A0 File Offset: 0x0005DAA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00006192 File Offset: 0x00004392
			public Class1456(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x000061A8 File Offset: 0x000043A8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600038D RID: 909 RVA: 0x000061B1 File Offset: 0x000043B1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_6();
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0005F8B8 File Offset: 0x0005DAB8
			public Class2110 method_0()
			{
				return this.class2111_0.method_7(this.int_0);
			}

			// Token: 0x040001F0 RID: 496
			private int int_0;

			// Token: 0x040001F1 RID: 497
			private Class2111 class2111_0;
		}

		// Token: 0x020000B3 RID: 179
		public sealed class Class1457 : IEnumerable
		{
			// Token: 0x0600038F RID: 911 RVA: 0x000061D4 File Offset: 0x000043D4
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x06000390 RID: 912 RVA: 0x0005F8D8 File Offset: 0x0005DAD8
			public Class2111.Class1458 method_1()
			{
				return new Class2111.Class1458(this.class2111_0);
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001F2 RID: 498
			private Class2111 class2111_0;
		}

		// Token: 0x020000B4 RID: 180
		public sealed class Class1458 : IEnumerator
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000393 RID: 915 RVA: 0x0005F90C File Offset: 0x0005DB0C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000394 RID: 916 RVA: 0x000061DD File Offset: 0x000043DD
			public Class1458(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x06000395 RID: 917 RVA: 0x000061F3 File Offset: 0x000043F3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000396 RID: 918 RVA: 0x000061FC File Offset: 0x000043FC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_8();
			}

			// Token: 0x06000397 RID: 919 RVA: 0x0005F924 File Offset: 0x0005DB24
			public Class2050 method_0()
			{
				return this.class2111_0.method_9(this.int_0);
			}

			// Token: 0x040001F3 RID: 499
			private int int_0;

			// Token: 0x040001F4 RID: 500
			private Class2111 class2111_0;
		}

		// Token: 0x020000B5 RID: 181
		public sealed class Class1459 : IEnumerable
		{
			// Token: 0x06000398 RID: 920 RVA: 0x0000621F File Offset: 0x0000441F
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x06000399 RID: 921 RVA: 0x0005F944 File Offset: 0x0005DB44
			public Class2111.Class1460 method_1()
			{
				return new Class2111.Class1460(this.class2111_0);
			}

			// Token: 0x0600039A RID: 922 RVA: 0x0005F960 File Offset: 0x0005DB60
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001F5 RID: 501
			private Class2111 class2111_0;
		}

		// Token: 0x020000B6 RID: 182
		public sealed class Class1460 : IEnumerator
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600039C RID: 924 RVA: 0x0005F978 File Offset: 0x0005DB78
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00006228 File Offset: 0x00004428
			public Class1460(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x0600039E RID: 926 RVA: 0x0000623E File Offset: 0x0000443E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00006247 File Offset: 0x00004447
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_10();
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x0005F990 File Offset: 0x0005DB90
			public Class2050 method_0()
			{
				return this.class2111_0.method_11(this.int_0);
			}

			// Token: 0x040001F6 RID: 502
			private int int_0;

			// Token: 0x040001F7 RID: 503
			private Class2111 class2111_0;
		}

		// Token: 0x020000B7 RID: 183
		public sealed class Class1461 : IEnumerable
		{
			// Token: 0x060003A1 RID: 929 RVA: 0x0000626A File Offset: 0x0000446A
			public void method_0(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x0005F9B0 File Offset: 0x0005DBB0
			public Class2111.Class1462 method_1()
			{
				return new Class2111.Class1462(this.class2111_0);
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x0005F9CC File Offset: 0x0005DBCC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001F8 RID: 504
			private Class2111 class2111_0;
		}

		// Token: 0x020000B8 RID: 184
		public sealed class Class1462 : IEnumerator
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060003A5 RID: 933 RVA: 0x0005F9E4 File Offset: 0x0005DBE4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00006273 File Offset: 0x00004473
			public Class1462(Class2111 class2111_1)
			{
				this.class2111_0 = class2111_1;
				this.int_0 = -1;
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x00006289 File Offset: 0x00004489
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x00006292 File Offset: 0x00004492
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2111_0.method_12();
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x0005F9FC File Offset: 0x0005DBFC
			public Class2050 method_0()
			{
				return this.class2111_0.method_13(this.int_0);
			}

			// Token: 0x040001F9 RID: 505
			private int int_0;

			// Token: 0x040001FA RID: 506
			private Class2111 class2111_0;
		}
	}
}
