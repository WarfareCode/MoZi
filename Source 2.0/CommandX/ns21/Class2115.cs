using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000C6 RID: 198
	public sealed class Class2115 : Class2059
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0005FD64 File Offset: 0x0005DF64
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00006533 File Offset: 0x00004733
		public Class2050 Value
		{
			get
			{
				return new Class2050(Class2059.smethod_0(this.xmlNode_0));
			}
			set
			{
				Class2059.smethod_1(this.xmlNode_0, value.ToString());
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0005FD84 File Offset: 0x0005DF84
		public Class2115()
		{
			this.method_16();
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0005FDEC File Offset: 0x0005DFEC
		public Class2115(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_16();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "name");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0005B4E4 File Offset: 0x000596E4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "name", int_0)));
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0005FE54 File Offset: 0x0005E054
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "units");
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0005FE74 File Offset: 0x0005E074
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "units", int_0)));
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0005FEA0 File Offset: 0x0005E0A0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "unitSymbol");
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "unitSymbol", int_0)));
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0005FEEC File Offset: 0x0005E0EC
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "default");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0005FF0C File Offset: 0x0005E10C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "default", int_0)));
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0005FF38 File Offset: 0x0005E138
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "multipleValues");
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0005FF58 File Offset: 0x0005E158
		public Class2009 method_11(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "multipleValues", int_0)));
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0005FF84 File Offset: 0x0005E184
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "nearestValue");
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0005FFA4 File Offset: 0x0005E1A4
		public Class2009 method_13(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "nearestValue", int_0)));
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0005FFD0 File Offset: 0x0005E1D0
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "current");
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0005FFF0 File Offset: 0x0005E1F0
		public Class2009 method_15(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "current", int_0)));
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0006001C File Offset: 0x0005E21C
		private void method_16()
		{
			this.class1473_0.method_0(this);
			this.class1475_0.method_0(this);
			this.class1477_0.method_0(this);
			this.class1479_0.method_0(this);
			this.class1481_0.method_0(this);
			this.class1483_0.method_0(this);
			this.class1485_0.method_0(this);
		}

		// Token: 0x0400020F RID: 527
		public Class2115.Class1473 class1473_0 = new Class2115.Class1473();

		// Token: 0x04000210 RID: 528
		public Class2115.Class1475 class1475_0 = new Class2115.Class1475();

		// Token: 0x04000211 RID: 529
		public Class2115.Class1477 class1477_0 = new Class2115.Class1477();

		// Token: 0x04000212 RID: 530
		public Class2115.Class1479 class1479_0 = new Class2115.Class1479();

		// Token: 0x04000213 RID: 531
		public Class2115.Class1481 class1481_0 = new Class2115.Class1481();

		// Token: 0x04000214 RID: 532
		public Class2115.Class1483 class1483_0 = new Class2115.Class1483();

		// Token: 0x04000215 RID: 533
		public Class2115.Class1485 class1485_0 = new Class2115.Class1485();

		// Token: 0x020000C7 RID: 199
		public sealed class Class1473 : IEnumerable
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00006546 File Offset: 0x00004746
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00060080 File Offset: 0x0005E280
			public Class2115.Class1474 method_1()
			{
				return new Class2115.Class1474(this.class2115_0);
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0006009C File Offset: 0x0005E29C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000216 RID: 534
			private Class2115 class2115_0;
		}

		// Token: 0x020000C8 RID: 200
		public sealed class Class1474 : IEnumerator
		{
			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x000600B4 File Offset: 0x0005E2B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000654F File Offset: 0x0000474F
			public Class1474(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00006565 File Offset: 0x00004765
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x0000656E File Offset: 0x0000476E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_2();
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x000600CC File Offset: 0x0005E2CC
			public Class2050 method_0()
			{
				return this.class2115_0.method_3(this.int_0);
			}

			// Token: 0x04000217 RID: 535
			private int int_0;

			// Token: 0x04000218 RID: 536
			private Class2115 class2115_0;
		}

		// Token: 0x020000C9 RID: 201
		public sealed class Class1475 : IEnumerable
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x00006591 File Offset: 0x00004791
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x000600EC File Offset: 0x0005E2EC
			public Class2115.Class1476 method_1()
			{
				return new Class2115.Class1476(this.class2115_0);
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00060108 File Offset: 0x0005E308
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000219 RID: 537
			private Class2115 class2115_0;
		}

		// Token: 0x020000CA RID: 202
		public sealed class Class1476 : IEnumerator
		{
			// Token: 0x17000067 RID: 103
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x00060120 File Offset: 0x0005E320
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0000659A File Offset: 0x0000479A
			public Class1476(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x000065B0 File Offset: 0x000047B0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x000065B9 File Offset: 0x000047B9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_4();
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00060138 File Offset: 0x0005E338
			public Class2050 method_0()
			{
				return this.class2115_0.method_5(this.int_0);
			}

			// Token: 0x0400021A RID: 538
			private int int_0;

			// Token: 0x0400021B RID: 539
			private Class2115 class2115_0;
		}

		// Token: 0x020000CB RID: 203
		public sealed class Class1477 : IEnumerable
		{
			// Token: 0x0600040F RID: 1039 RVA: 0x000065DC File Offset: 0x000047DC
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x00060158 File Offset: 0x0005E358
			public Class2115.Class1478 method_1()
			{
				return new Class2115.Class1478(this.class2115_0);
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x00060174 File Offset: 0x0005E374
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400021C RID: 540
			private Class2115 class2115_0;
		}

		// Token: 0x020000CC RID: 204
		public sealed class Class1478 : IEnumerator
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x0006018C File Offset: 0x0005E38C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000065E5 File Offset: 0x000047E5
			public Class1478(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x000065FB File Offset: 0x000047FB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00006604 File Offset: 0x00004804
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_6();
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x000601A4 File Offset: 0x0005E3A4
			public Class2050 method_0()
			{
				return this.class2115_0.method_7(this.int_0);
			}

			// Token: 0x0400021D RID: 541
			private int int_0;

			// Token: 0x0400021E RID: 542
			private Class2115 class2115_0;
		}

		// Token: 0x020000CD RID: 205
		public sealed class Class1479 : IEnumerable
		{
			// Token: 0x06000418 RID: 1048 RVA: 0x00006627 File Offset: 0x00004827
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x000601C4 File Offset: 0x0005E3C4
			public Class2115.Class1480 method_1()
			{
				return new Class2115.Class1480(this.class2115_0);
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x000601E0 File Offset: 0x0005E3E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400021F RID: 543
			private Class2115 class2115_0;
		}

		// Token: 0x020000CE RID: 206
		public sealed class Class1480 : IEnumerator
		{
			// Token: 0x17000069 RID: 105
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x000601F8 File Offset: 0x0005E3F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00006630 File Offset: 0x00004830
			public Class1480(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00006646 File Offset: 0x00004846
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x0000664F File Offset: 0x0000484F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_8();
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00060210 File Offset: 0x0005E410
			public Class2050 method_0()
			{
				return this.class2115_0.method_9(this.int_0);
			}

			// Token: 0x04000220 RID: 544
			private int int_0;

			// Token: 0x04000221 RID: 545
			private Class2115 class2115_0;
		}

		// Token: 0x020000CF RID: 207
		public sealed class Class1481 : IEnumerable
		{
			// Token: 0x06000421 RID: 1057 RVA: 0x00006672 File Offset: 0x00004872
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x00060230 File Offset: 0x0005E430
			public Class2115.Class1482 method_1()
			{
				return new Class2115.Class1482(this.class2115_0);
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x0006024C File Offset: 0x0005E44C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000222 RID: 546
			private Class2115 class2115_0;
		}

		// Token: 0x020000D0 RID: 208
		public sealed class Class1482 : IEnumerator
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000425 RID: 1061 RVA: 0x00060264 File Offset: 0x0005E464
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x0000667B File Offset: 0x0000487B
			public Class1482(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00006691 File Offset: 0x00004891
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x0000669A File Offset: 0x0000489A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_10();
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x0006027C File Offset: 0x0005E47C
			public Class2009 method_0()
			{
				return this.class2115_0.method_11(this.int_0);
			}

			// Token: 0x04000223 RID: 547
			private int int_0;

			// Token: 0x04000224 RID: 548
			private Class2115 class2115_0;
		}

		// Token: 0x020000D1 RID: 209
		public sealed class Class1483 : IEnumerable
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x000066BD File Offset: 0x000048BD
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0006029C File Offset: 0x0005E49C
			public Class2115.Class1484 method_1()
			{
				return new Class2115.Class1484(this.class2115_0);
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x000602B8 File Offset: 0x0005E4B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000225 RID: 549
			private Class2115 class2115_0;
		}

		// Token: 0x020000D2 RID: 210
		public sealed class Class1484 : IEnumerator
		{
			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x000602D0 File Offset: 0x0005E4D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x000066C6 File Offset: 0x000048C6
			public Class1484(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x000066DC File Offset: 0x000048DC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x000066E5 File Offset: 0x000048E5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_12();
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x000602E8 File Offset: 0x0005E4E8
			public Class2009 method_0()
			{
				return this.class2115_0.method_13(this.int_0);
			}

			// Token: 0x04000226 RID: 550
			private int int_0;

			// Token: 0x04000227 RID: 551
			private Class2115 class2115_0;
		}

		// Token: 0x020000D3 RID: 211
		public sealed class Class1485 : IEnumerable
		{
			// Token: 0x06000433 RID: 1075 RVA: 0x00006708 File Offset: 0x00004908
			public void method_0(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00060308 File Offset: 0x0005E508
			public Class2115.Class1486 method_1()
			{
				return new Class2115.Class1486(this.class2115_0);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00060324 File Offset: 0x0005E524
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000228 RID: 552
			private Class2115 class2115_0;
		}

		// Token: 0x020000D4 RID: 212
		public sealed class Class1486 : IEnumerator
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0006033C File Offset: 0x0005E53C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00006711 File Offset: 0x00004911
			public Class1486(Class2115 class2115_1)
			{
				this.class2115_0 = class2115_1;
				this.int_0 = -1;
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00006727 File Offset: 0x00004927
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x00006730 File Offset: 0x00004930
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2115_0.method_14();
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00060354 File Offset: 0x0005E554
			public Class2009 method_0()
			{
				return this.class2115_0.method_15(this.int_0);
			}

			// Token: 0x04000229 RID: 553
			private int int_0;

			// Token: 0x0400022A RID: 554
			private Class2115 class2115_0;
		}
	}
}
