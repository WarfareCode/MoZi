using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x0200009F RID: 159
	public sealed class Class2110 : Class2059
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0005EF64 File Offset: 0x0005D164
		public Class2110()
		{
			this.method_14();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		public Class2110(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0005F01C File Offset: 0x0005D21C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AddressType");
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0005F03C File Offset: 0x0005D23C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AddressType", int_0)));
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0005F068 File Offset: 0x0005D268
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Address");
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0005F088 File Offset: 0x0005D288
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Address", int_0)));
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "City");
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0005F0D4 File Offset: 0x0005D2D4
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "City", int_0)));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0005F100 File Offset: 0x0005D300
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StateOrProvince");
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0005F120 File Offset: 0x0005D320
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "StateOrProvince", int_0)));
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0005F14C File Offset: 0x0005D34C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "PostCode");
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0005F16C File Offset: 0x0005D36C
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "PostCode", int_0)));
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0005F198 File Offset: 0x0005D398
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Country");
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0005F1B8 File Offset: 0x0005D3B8
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Country", int_0)));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
		private void method_14()
		{
			this.class1439_0.method_0(this);
			this.class1441_0.method_0(this);
			this.class1443_0.method_0(this);
			this.class1445_0.method_0(this);
			this.class1447_0.method_0(this);
			this.class1449_0.method_0(this);
		}

		// Token: 0x040001CB RID: 459
		public Class2110.Class1439 class1439_0 = new Class2110.Class1439();

		// Token: 0x040001CC RID: 460
		public Class2110.Class1441 class1441_0 = new Class2110.Class1441();

		// Token: 0x040001CD RID: 461
		public Class2110.Class1443 class1443_0 = new Class2110.Class1443();

		// Token: 0x040001CE RID: 462
		public Class2110.Class1445 class1445_0 = new Class2110.Class1445();

		// Token: 0x040001CF RID: 463
		public Class2110.Class1447 class1447_0 = new Class2110.Class1447();

		// Token: 0x040001D0 RID: 464
		public Class2110.Class1449 class1449_0 = new Class2110.Class1449();

		// Token: 0x020000A0 RID: 160
		public sealed class Class1439 : IEnumerable
		{
			// Token: 0x0600032F RID: 815 RVA: 0x00005F31 File Offset: 0x00004131
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x06000330 RID: 816 RVA: 0x0005F23C File Offset: 0x0005D43C
			public Class2110.Class1440 method_1()
			{
				return new Class2110.Class1440(this.class2110_0);
			}

			// Token: 0x06000331 RID: 817 RVA: 0x0005F258 File Offset: 0x0005D458
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001D1 RID: 465
			private Class2110 class2110_0;
		}

		// Token: 0x020000A1 RID: 161
		public sealed class Class1440 : IEnumerator
		{
			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0005F270 File Offset: 0x0005D470
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00005F3A File Offset: 0x0000413A
			public Class1440(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00005F50 File Offset: 0x00004150
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00005F59 File Offset: 0x00004159
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_2();
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0005F288 File Offset: 0x0005D488
			public Class2050 method_0()
			{
				return this.class2110_0.method_3(this.int_0);
			}

			// Token: 0x040001D2 RID: 466
			private int int_0;

			// Token: 0x040001D3 RID: 467
			private Class2110 class2110_0;
		}

		// Token: 0x020000A2 RID: 162
		public sealed class Class1441 : IEnumerable
		{
			// Token: 0x06000338 RID: 824 RVA: 0x00005F7C File Offset: 0x0000417C
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
			public Class2110.Class1442 method_1()
			{
				return new Class2110.Class1442(this.class2110_0);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0005F2C4 File Offset: 0x0005D4C4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001D4 RID: 468
			private Class2110 class2110_0;
		}

		// Token: 0x020000A3 RID: 163
		public sealed class Class1442 : IEnumerator
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0005F2DC File Offset: 0x0005D4DC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600033D RID: 829 RVA: 0x00005F85 File Offset: 0x00004185
			public Class1442(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x0600033E RID: 830 RVA: 0x00005F9B File Offset: 0x0000419B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600033F RID: 831 RVA: 0x00005FA4 File Offset: 0x000041A4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_4();
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
			public Class2050 method_0()
			{
				return this.class2110_0.method_5(this.int_0);
			}

			// Token: 0x040001D5 RID: 469
			private int int_0;

			// Token: 0x040001D6 RID: 470
			private Class2110 class2110_0;
		}

		// Token: 0x020000A4 RID: 164
		public sealed class Class1443 : IEnumerable
		{
			// Token: 0x06000341 RID: 833 RVA: 0x00005FC7 File Offset: 0x000041C7
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0005F314 File Offset: 0x0005D514
			public Class2110.Class1444 method_1()
			{
				return new Class2110.Class1444(this.class2110_0);
			}

			// Token: 0x06000343 RID: 835 RVA: 0x0005F330 File Offset: 0x0005D530
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001D7 RID: 471
			private Class2110 class2110_0;
		}

		// Token: 0x020000A5 RID: 165
		public sealed class Class1444 : IEnumerator
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000345 RID: 837 RVA: 0x0005F348 File Offset: 0x0005D548
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00005FD0 File Offset: 0x000041D0
			public Class1444(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00005FE6 File Offset: 0x000041E6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00005FEF File Offset: 0x000041EF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_6();
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0005F360 File Offset: 0x0005D560
			public Class2050 method_0()
			{
				return this.class2110_0.method_7(this.int_0);
			}

			// Token: 0x040001D8 RID: 472
			private int int_0;

			// Token: 0x040001D9 RID: 473
			private Class2110 class2110_0;
		}

		// Token: 0x020000A6 RID: 166
		public sealed class Class1445 : IEnumerable
		{
			// Token: 0x0600034A RID: 842 RVA: 0x00006012 File Offset: 0x00004212
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0005F380 File Offset: 0x0005D580
			public Class2110.Class1446 method_1()
			{
				return new Class2110.Class1446(this.class2110_0);
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0005F39C File Offset: 0x0005D59C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001DA RID: 474
			private Class2110 class2110_0;
		}

		// Token: 0x020000A7 RID: 167
		public sealed class Class1446 : IEnumerator
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600034E RID: 846 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000601B File Offset: 0x0000421B
			public Class1446(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x06000350 RID: 848 RVA: 0x00006031 File Offset: 0x00004231
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000351 RID: 849 RVA: 0x0000603A File Offset: 0x0000423A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_8();
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0005F3CC File Offset: 0x0005D5CC
			public Class2050 method_0()
			{
				return this.class2110_0.method_9(this.int_0);
			}

			// Token: 0x040001DB RID: 475
			private int int_0;

			// Token: 0x040001DC RID: 476
			private Class2110 class2110_0;
		}

		// Token: 0x020000A8 RID: 168
		public sealed class Class1447 : IEnumerable
		{
			// Token: 0x06000353 RID: 851 RVA: 0x0000605D File Offset: 0x0000425D
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0005F3EC File Offset: 0x0005D5EC
			public Class2110.Class1448 method_1()
			{
				return new Class2110.Class1448(this.class2110_0);
			}

			// Token: 0x06000355 RID: 853 RVA: 0x0005F408 File Offset: 0x0005D608
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001DD RID: 477
			private Class2110 class2110_0;
		}

		// Token: 0x020000A9 RID: 169
		public sealed class Class1448 : IEnumerator
		{
			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0005F420 File Offset: 0x0005D620
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000358 RID: 856 RVA: 0x00006066 File Offset: 0x00004266
			public Class1448(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0000607C File Offset: 0x0000427C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00006085 File Offset: 0x00004285
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_10();
			}

			// Token: 0x0600035B RID: 859 RVA: 0x0005F438 File Offset: 0x0005D638
			public Class2050 method_0()
			{
				return this.class2110_0.method_11(this.int_0);
			}

			// Token: 0x040001DE RID: 478
			private int int_0;

			// Token: 0x040001DF RID: 479
			private Class2110 class2110_0;
		}

		// Token: 0x020000AA RID: 170
		public sealed class Class1449 : IEnumerable
		{
			// Token: 0x0600035C RID: 860 RVA: 0x000060A8 File Offset: 0x000042A8
			public void method_0(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
			}

			// Token: 0x0600035D RID: 861 RVA: 0x0005F458 File Offset: 0x0005D658
			public Class2110.Class1450 method_1()
			{
				return new Class2110.Class1450(this.class2110_0);
			}

			// Token: 0x0600035E RID: 862 RVA: 0x0005F474 File Offset: 0x0005D674
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001E0 RID: 480
			private Class2110 class2110_0;
		}

		// Token: 0x020000AB RID: 171
		public sealed class Class1450 : IEnumerator
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0005F48C File Offset: 0x0005D68C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000361 RID: 865 RVA: 0x000060B1 File Offset: 0x000042B1
			public Class1450(Class2110 class2110_1)
			{
				this.class2110_0 = class2110_1;
				this.int_0 = -1;
			}

			// Token: 0x06000362 RID: 866 RVA: 0x000060C7 File Offset: 0x000042C7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000363 RID: 867 RVA: 0x000060D0 File Offset: 0x000042D0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2110_0.method_12();
			}

			// Token: 0x06000364 RID: 868 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
			public Class2050 method_0()
			{
				return this.class2110_0.method_13(this.int_0);
			}

			// Token: 0x040001E1 RID: 481
			private int int_0;

			// Token: 0x040001E2 RID: 482
			private Class2110 class2110_0;
		}
	}
}
