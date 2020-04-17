using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x020008FE RID: 2302
	public sealed class Class2098 : Class2059
	{
		// Token: 0x060038A9 RID: 14505 RVA: 0x00121540 File Offset: 0x0011F740
		public Class2098()
		{
			this.method_32();
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00121600 File Offset: 0x0011F800
		public Class2098(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_32();
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00120BC8 File Offset: 0x0011EDC8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MasterFilePath");
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00120BE8 File Offset: 0x0011EDE8
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MasterFilePath", int_0)));
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00120C14 File Offset: 0x0011EE14
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinimumViewAltitude");
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00120C34 File Offset: 0x0011EE34
		public Class2020 method_11(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinimumViewAltitude", int_0)));
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00120C60 File Offset: 0x0011EE60
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaximumViewAltitude");
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00120C80 File Offset: 0x0011EE80
		public Class2020 method_13(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaximumViewAltitude", int_0)));
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00120CAC File Offset: 0x0011EEAC
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ShowPoints");
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00120CCC File Offset: 0x0011EECC
		public Class2009 method_15(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ShowPoints", int_0)));
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00120CF8 File Offset: 0x0011EEF8
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ShowBoundaries");
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00120D18 File Offset: 0x0011EF18
		public Class2009 method_17(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ShowBoundaries", int_0)));
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00120D44 File Offset: 0x0011EF44
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ShowFilledRegions");
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00120D64 File Offset: 0x0011EF64
		public Class2009 method_19(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ShowFilledRegions", int_0)));
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00120D90 File Offset: 0x0011EF90
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ScalarKey");
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00120DB0 File Offset: 0x0011EFB0
		public Class2050 method_21(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ScalarKey", int_0)));
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00120DDC File Offset: 0x0011EFDC
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ShowScalarValues");
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00120DFC File Offset: 0x0011EFFC
		public Class2009 method_23(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ShowScalarValues", int_0)));
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00103FFC File Offset: 0x001021FC
		public int method_24()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DisplayFont");
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0010401C File Offset: 0x0010221C
		public Class2073 method_25(int int_0)
		{
			return new Class2073(base.method_1(Class2059.Enum155.const_1, "", "DisplayFont", int_0));
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0011CE08 File Offset: 0x0011B008
		public int method_26()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RGBColor");
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0011CE28 File Offset: 0x0011B028
		public Class2096 method_27(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "RGBColor", int_0));
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x0011CE50 File Offset: 0x0011B050
		public int method_28()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WinColorName");
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x0011CE70 File Offset: 0x0011B070
		public Class2050 method_29(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WinColorName", int_0)));
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_30()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_31(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x001216C0 File Offset: 0x0011F8C0
		private void method_32()
		{
			this.class1269_0.method_0(this);
			this.class1271_0.method_0(this);
			this.class1273_0.method_0(this);
			this.class1275_0.method_0(this);
			this.class1277_0.method_0(this);
			this.class1279_0.method_0(this);
			this.class1281_0.method_0(this);
			this.class1283_0.method_0(this);
			this.class1285_0.method_0(this);
			this.class1287_0.method_0(this);
			this.class1289_0.method_0(this);
			this.class1291_0.method_0(this);
			this.class1293_0.method_0(this);
			this.class1295_0.method_0(this);
			this.class1297_0.method_0(this);
		}

		// Token: 0x04001A0C RID: 6668
		public Class2098.Class1269 class1269_0 = new Class2098.Class1269();

		// Token: 0x04001A0D RID: 6669
		public Class2098.Class1271 class1271_0 = new Class2098.Class1271();

		// Token: 0x04001A0E RID: 6670
		public Class2098.Class1273 class1273_0 = new Class2098.Class1273();

		// Token: 0x04001A0F RID: 6671
		public Class2098.Class1275 class1275_0 = new Class2098.Class1275();

		// Token: 0x04001A10 RID: 6672
		public Class2098.Class1277 class1277_0 = new Class2098.Class1277();

		// Token: 0x04001A11 RID: 6673
		public Class2098.Class1279 class1279_0 = new Class2098.Class1279();

		// Token: 0x04001A12 RID: 6674
		public Class2098.Class1281 class1281_0 = new Class2098.Class1281();

		// Token: 0x04001A13 RID: 6675
		public Class2098.Class1283 class1283_0 = new Class2098.Class1283();

		// Token: 0x04001A14 RID: 6676
		public Class2098.Class1285 class1285_0 = new Class2098.Class1285();

		// Token: 0x04001A15 RID: 6677
		public Class2098.Class1287 class1287_0 = new Class2098.Class1287();

		// Token: 0x04001A16 RID: 6678
		public Class2098.Class1289 class1289_0 = new Class2098.Class1289();

		// Token: 0x04001A17 RID: 6679
		public Class2098.Class1291 class1291_0 = new Class2098.Class1291();

		// Token: 0x04001A18 RID: 6680
		public Class2098.Class1293 class1293_0 = new Class2098.Class1293();

		// Token: 0x04001A19 RID: 6681
		public Class2098.Class1295 class1295_0 = new Class2098.Class1295();

		// Token: 0x04001A1A RID: 6682
		public Class2098.Class1297 class1297_0 = new Class2098.Class1297();

		// Token: 0x020008FF RID: 2303
		public sealed class Class1269 : IEnumerable
		{
			// Token: 0x060038CA RID: 14538 RVA: 0x0001E294 File Offset: 0x0001C494
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038CB RID: 14539 RVA: 0x00121784 File Offset: 0x0011F984
			public Class2098.Class1270 method_1()
			{
				return new Class2098.Class1270(this.class2098_0);
			}

			// Token: 0x060038CC RID: 14540 RVA: 0x001217A0 File Offset: 0x0011F9A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A1B RID: 6683
			private Class2098 class2098_0;
		}

		// Token: 0x02000900 RID: 2304
		public sealed class Class1270 : IEnumerator
		{
			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x060038CE RID: 14542 RVA: 0x001217B8 File Offset: 0x0011F9B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038CF RID: 14543 RVA: 0x0001E29D File Offset: 0x0001C49D
			public Class1270(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038D0 RID: 14544 RVA: 0x0001E2B3 File Offset: 0x0001C4B3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038D1 RID: 14545 RVA: 0x0001E2BC File Offset: 0x0001C4BC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_2();
			}

			// Token: 0x060038D2 RID: 14546 RVA: 0x001217D0 File Offset: 0x0011F9D0
			public Class2009 method_0()
			{
				return this.class2098_0.method_3(this.int_0);
			}

			// Token: 0x04001A1C RID: 6684
			private int int_0;

			// Token: 0x04001A1D RID: 6685
			private Class2098 class2098_0;
		}

		// Token: 0x02000901 RID: 2305
		public sealed class Class1271 : IEnumerable
		{
			// Token: 0x060038D3 RID: 14547 RVA: 0x0001E2DF File Offset: 0x0001C4DF
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038D4 RID: 14548 RVA: 0x001217F0 File Offset: 0x0011F9F0
			public Class2098.Class1272 method_1()
			{
				return new Class2098.Class1272(this.class2098_0);
			}

			// Token: 0x060038D5 RID: 14549 RVA: 0x0012180C File Offset: 0x0011FA0C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A1E RID: 6686
			private Class2098 class2098_0;
		}

		// Token: 0x02000902 RID: 2306
		public sealed class Class1272 : IEnumerator
		{
			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00121824 File Offset: 0x0011FA24
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038D8 RID: 14552 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
			public Class1272(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038D9 RID: 14553 RVA: 0x0001E2FE File Offset: 0x0001C4FE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038DA RID: 14554 RVA: 0x0001E307 File Offset: 0x0001C507
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_4();
			}

			// Token: 0x060038DB RID: 14555 RVA: 0x0012183C File Offset: 0x0011FA3C
			public Class2050 method_0()
			{
				return this.class2098_0.method_5(this.int_0);
			}

			// Token: 0x04001A1F RID: 6687
			private int int_0;

			// Token: 0x04001A20 RID: 6688
			private Class2098 class2098_0;
		}

		// Token: 0x02000903 RID: 2307
		public sealed class Class1273 : IEnumerable
		{
			// Token: 0x060038DC RID: 14556 RVA: 0x0001E32A File Offset: 0x0001C52A
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038DD RID: 14557 RVA: 0x0012185C File Offset: 0x0011FA5C
			public Class2098.Class1274 method_1()
			{
				return new Class2098.Class1274(this.class2098_0);
			}

			// Token: 0x060038DE RID: 14558 RVA: 0x00121878 File Offset: 0x0011FA78
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A21 RID: 6689
			private Class2098 class2098_0;
		}

		// Token: 0x02000904 RID: 2308
		public sealed class Class1274 : IEnumerator
		{
			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x060038E0 RID: 14560 RVA: 0x00121890 File Offset: 0x0011FA90
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038E1 RID: 14561 RVA: 0x0001E333 File Offset: 0x0001C533
			public Class1274(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038E2 RID: 14562 RVA: 0x0001E349 File Offset: 0x0001C549
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038E3 RID: 14563 RVA: 0x0001E352 File Offset: 0x0001C552
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_6();
			}

			// Token: 0x060038E4 RID: 14564 RVA: 0x001218A8 File Offset: 0x0011FAA8
			public Class2020 method_0()
			{
				return this.class2098_0.method_7(this.int_0);
			}

			// Token: 0x04001A22 RID: 6690
			private int int_0;

			// Token: 0x04001A23 RID: 6691
			private Class2098 class2098_0;
		}

		// Token: 0x02000905 RID: 2309
		public sealed class Class1275 : IEnumerable
		{
			// Token: 0x060038E5 RID: 14565 RVA: 0x0001E375 File Offset: 0x0001C575
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038E6 RID: 14566 RVA: 0x001218C8 File Offset: 0x0011FAC8
			public Class2098.Class1276 method_1()
			{
				return new Class2098.Class1276(this.class2098_0);
			}

			// Token: 0x060038E7 RID: 14567 RVA: 0x001218E4 File Offset: 0x0011FAE4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A24 RID: 6692
			private Class2098 class2098_0;
		}

		// Token: 0x02000906 RID: 2310
		public sealed class Class1276 : IEnumerator
		{
			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x060038E9 RID: 14569 RVA: 0x001218FC File Offset: 0x0011FAFC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038EA RID: 14570 RVA: 0x0001E37E File Offset: 0x0001C57E
			public Class1276(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038EB RID: 14571 RVA: 0x0001E394 File Offset: 0x0001C594
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038EC RID: 14572 RVA: 0x0001E39D File Offset: 0x0001C59D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_8();
			}

			// Token: 0x060038ED RID: 14573 RVA: 0x00121914 File Offset: 0x0011FB14
			public Class2050 method_0()
			{
				return this.class2098_0.method_9(this.int_0);
			}

			// Token: 0x04001A25 RID: 6693
			private int int_0;

			// Token: 0x04001A26 RID: 6694
			private Class2098 class2098_0;
		}

		// Token: 0x02000907 RID: 2311
		public sealed class Class1277 : IEnumerable
		{
			// Token: 0x060038EE RID: 14574 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038EF RID: 14575 RVA: 0x00121934 File Offset: 0x0011FB34
			public Class2098.Class1278 method_1()
			{
				return new Class2098.Class1278(this.class2098_0);
			}

			// Token: 0x060038F0 RID: 14576 RVA: 0x00121950 File Offset: 0x0011FB50
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A27 RID: 6695
			private Class2098 class2098_0;
		}

		// Token: 0x02000908 RID: 2312
		public sealed class Class1278 : IEnumerator
		{
			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x060038F2 RID: 14578 RVA: 0x00121968 File Offset: 0x0011FB68
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038F3 RID: 14579 RVA: 0x0001E3C9 File Offset: 0x0001C5C9
			public Class1278(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038F4 RID: 14580 RVA: 0x0001E3DF File Offset: 0x0001C5DF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038F5 RID: 14581 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_10();
			}

			// Token: 0x060038F6 RID: 14582 RVA: 0x00121980 File Offset: 0x0011FB80
			public Class2020 method_0()
			{
				return this.class2098_0.method_11(this.int_0);
			}

			// Token: 0x04001A28 RID: 6696
			private int int_0;

			// Token: 0x04001A29 RID: 6697
			private Class2098 class2098_0;
		}

		// Token: 0x02000909 RID: 2313
		public sealed class Class1279 : IEnumerable
		{
			// Token: 0x060038F7 RID: 14583 RVA: 0x0001E40B File Offset: 0x0001C60B
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x060038F8 RID: 14584 RVA: 0x001219A0 File Offset: 0x0011FBA0
			public Class2098.Class1280 method_1()
			{
				return new Class2098.Class1280(this.class2098_0);
			}

			// Token: 0x060038F9 RID: 14585 RVA: 0x001219BC File Offset: 0x0011FBBC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A2A RID: 6698
			private Class2098 class2098_0;
		}

		// Token: 0x0200090A RID: 2314
		public sealed class Class1280 : IEnumerator
		{
			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x060038FB RID: 14587 RVA: 0x001219D4 File Offset: 0x0011FBD4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060038FC RID: 14588 RVA: 0x0001E414 File Offset: 0x0001C614
			public Class1280(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x060038FD RID: 14589 RVA: 0x0001E42A File Offset: 0x0001C62A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060038FE RID: 14590 RVA: 0x0001E433 File Offset: 0x0001C633
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_12();
			}

			// Token: 0x060038FF RID: 14591 RVA: 0x001219EC File Offset: 0x0011FBEC
			public Class2020 method_0()
			{
				return this.class2098_0.method_13(this.int_0);
			}

			// Token: 0x04001A2B RID: 6699
			private int int_0;

			// Token: 0x04001A2C RID: 6700
			private Class2098 class2098_0;
		}

		// Token: 0x0200090B RID: 2315
		public sealed class Class1281 : IEnumerable
		{
			// Token: 0x06003900 RID: 14592 RVA: 0x0001E456 File Offset: 0x0001C656
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003901 RID: 14593 RVA: 0x00121A0C File Offset: 0x0011FC0C
			public Class2098.Class1282 method_1()
			{
				return new Class2098.Class1282(this.class2098_0);
			}

			// Token: 0x06003902 RID: 14594 RVA: 0x00121A28 File Offset: 0x0011FC28
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A2D RID: 6701
			private Class2098 class2098_0;
		}

		// Token: 0x0200090C RID: 2316
		public sealed class Class1282 : IEnumerator
		{
			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06003904 RID: 14596 RVA: 0x00121A40 File Offset: 0x0011FC40
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003905 RID: 14597 RVA: 0x0001E45F File Offset: 0x0001C65F
			public Class1282(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x06003906 RID: 14598 RVA: 0x0001E475 File Offset: 0x0001C675
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x0001E47E File Offset: 0x0001C67E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_14();
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x00121A58 File Offset: 0x0011FC58
			public Class2009 method_0()
			{
				return this.class2098_0.method_15(this.int_0);
			}

			// Token: 0x04001A2E RID: 6702
			private int int_0;

			// Token: 0x04001A2F RID: 6703
			private Class2098 class2098_0;
		}

		// Token: 0x0200090D RID: 2317
		public sealed class Class1283 : IEnumerable
		{
			// Token: 0x06003909 RID: 14601 RVA: 0x0001E4A1 File Offset: 0x0001C6A1
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x0600390A RID: 14602 RVA: 0x00121A78 File Offset: 0x0011FC78
			public Class2098.Class1284 method_1()
			{
				return new Class2098.Class1284(this.class2098_0);
			}

			// Token: 0x0600390B RID: 14603 RVA: 0x00121A94 File Offset: 0x0011FC94
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A30 RID: 6704
			private Class2098 class2098_0;
		}

		// Token: 0x0200090E RID: 2318
		public sealed class Class1284 : IEnumerator
		{
			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x0600390D RID: 14605 RVA: 0x00121AAC File Offset: 0x0011FCAC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600390E RID: 14606 RVA: 0x0001E4AA File Offset: 0x0001C6AA
			public Class1284(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x0600390F RID: 14607 RVA: 0x0001E4C0 File Offset: 0x0001C6C0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003910 RID: 14608 RVA: 0x0001E4C9 File Offset: 0x0001C6C9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_16();
			}

			// Token: 0x06003911 RID: 14609 RVA: 0x00121AC4 File Offset: 0x0011FCC4
			public Class2009 method_0()
			{
				return this.class2098_0.method_17(this.int_0);
			}

			// Token: 0x04001A31 RID: 6705
			private int int_0;

			// Token: 0x04001A32 RID: 6706
			private Class2098 class2098_0;
		}

		// Token: 0x0200090F RID: 2319
		public sealed class Class1285 : IEnumerable
		{
			// Token: 0x06003912 RID: 14610 RVA: 0x0001E4EC File Offset: 0x0001C6EC
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003913 RID: 14611 RVA: 0x00121AE4 File Offset: 0x0011FCE4
			public Class2098.Class1286 method_1()
			{
				return new Class2098.Class1286(this.class2098_0);
			}

			// Token: 0x06003914 RID: 14612 RVA: 0x00121B00 File Offset: 0x0011FD00
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A33 RID: 6707
			private Class2098 class2098_0;
		}

		// Token: 0x02000910 RID: 2320
		public sealed class Class1286 : IEnumerator
		{
			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06003916 RID: 14614 RVA: 0x00121B18 File Offset: 0x0011FD18
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003917 RID: 14615 RVA: 0x0001E4F5 File Offset: 0x0001C6F5
			public Class1286(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x06003918 RID: 14616 RVA: 0x0001E50B File Offset: 0x0001C70B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x0001E514 File Offset: 0x0001C714
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_18();
			}

			// Token: 0x0600391A RID: 14618 RVA: 0x00121B30 File Offset: 0x0011FD30
			public Class2009 method_0()
			{
				return this.class2098_0.method_19(this.int_0);
			}

			// Token: 0x04001A34 RID: 6708
			private int int_0;

			// Token: 0x04001A35 RID: 6709
			private Class2098 class2098_0;
		}

		// Token: 0x02000911 RID: 2321
		public sealed class Class1287 : IEnumerable
		{
			// Token: 0x0600391B RID: 14619 RVA: 0x0001E537 File Offset: 0x0001C737
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x0600391C RID: 14620 RVA: 0x00121B50 File Offset: 0x0011FD50
			public Class2098.Class1288 method_1()
			{
				return new Class2098.Class1288(this.class2098_0);
			}

			// Token: 0x0600391D RID: 14621 RVA: 0x00121B6C File Offset: 0x0011FD6C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A36 RID: 6710
			private Class2098 class2098_0;
		}

		// Token: 0x02000912 RID: 2322
		public sealed class Class1288 : IEnumerator
		{
			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x0600391F RID: 14623 RVA: 0x00121B84 File Offset: 0x0011FD84
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003920 RID: 14624 RVA: 0x0001E540 File Offset: 0x0001C740
			public Class1288(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x06003921 RID: 14625 RVA: 0x0001E556 File Offset: 0x0001C756
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003922 RID: 14626 RVA: 0x0001E55F File Offset: 0x0001C75F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_20();
			}

			// Token: 0x06003923 RID: 14627 RVA: 0x00121B9C File Offset: 0x0011FD9C
			public Class2050 method_0()
			{
				return this.class2098_0.method_21(this.int_0);
			}

			// Token: 0x04001A37 RID: 6711
			private int int_0;

			// Token: 0x04001A38 RID: 6712
			private Class2098 class2098_0;
		}

		// Token: 0x02000913 RID: 2323
		public sealed class Class1289 : IEnumerable
		{
			// Token: 0x06003924 RID: 14628 RVA: 0x0001E582 File Offset: 0x0001C782
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003925 RID: 14629 RVA: 0x00121BBC File Offset: 0x0011FDBC
			public Class2098.Class1290 method_1()
			{
				return new Class2098.Class1290(this.class2098_0);
			}

			// Token: 0x06003926 RID: 14630 RVA: 0x00121BD8 File Offset: 0x0011FDD8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A39 RID: 6713
			private Class2098 class2098_0;
		}

		// Token: 0x02000914 RID: 2324
		public sealed class Class1290 : IEnumerator
		{
			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06003928 RID: 14632 RVA: 0x00121BF0 File Offset: 0x0011FDF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003929 RID: 14633 RVA: 0x0001E58B File Offset: 0x0001C78B
			public Class1290(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x0600392A RID: 14634 RVA: 0x0001E5A1 File Offset: 0x0001C7A1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600392B RID: 14635 RVA: 0x0001E5AA File Offset: 0x0001C7AA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_22();
			}

			// Token: 0x0600392C RID: 14636 RVA: 0x00121C08 File Offset: 0x0011FE08
			public Class2009 method_0()
			{
				return this.class2098_0.method_23(this.int_0);
			}

			// Token: 0x04001A3A RID: 6714
			private int int_0;

			// Token: 0x04001A3B RID: 6715
			private Class2098 class2098_0;
		}

		// Token: 0x02000915 RID: 2325
		public sealed class Class1291 : IEnumerable
		{
			// Token: 0x0600392D RID: 14637 RVA: 0x0001E5CD File Offset: 0x0001C7CD
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x0600392E RID: 14638 RVA: 0x00121C28 File Offset: 0x0011FE28
			public Class2098.Class1292 method_1()
			{
				return new Class2098.Class1292(this.class2098_0);
			}

			// Token: 0x0600392F RID: 14639 RVA: 0x00121C44 File Offset: 0x0011FE44
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A3C RID: 6716
			private Class2098 class2098_0;
		}

		// Token: 0x02000916 RID: 2326
		public sealed class Class1292 : IEnumerator
		{
			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06003931 RID: 14641 RVA: 0x00121C5C File Offset: 0x0011FE5C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003932 RID: 14642 RVA: 0x0001E5D6 File Offset: 0x0001C7D6
			public Class1292(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x06003933 RID: 14643 RVA: 0x0001E5EC File Offset: 0x0001C7EC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003934 RID: 14644 RVA: 0x0001E5F5 File Offset: 0x0001C7F5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_24();
			}

			// Token: 0x06003935 RID: 14645 RVA: 0x00121C74 File Offset: 0x0011FE74
			public Class2073 method_0()
			{
				return this.class2098_0.method_25(this.int_0);
			}

			// Token: 0x04001A3D RID: 6717
			private int int_0;

			// Token: 0x04001A3E RID: 6718
			private Class2098 class2098_0;
		}

		// Token: 0x02000917 RID: 2327
		public sealed class Class1293 : IEnumerable
		{
			// Token: 0x06003936 RID: 14646 RVA: 0x0001E618 File Offset: 0x0001C818
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003937 RID: 14647 RVA: 0x00121C94 File Offset: 0x0011FE94
			public Class2098.Class1294 method_1()
			{
				return new Class2098.Class1294(this.class2098_0);
			}

			// Token: 0x06003938 RID: 14648 RVA: 0x00121CB0 File Offset: 0x0011FEB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A3F RID: 6719
			private Class2098 class2098_0;
		}

		// Token: 0x02000918 RID: 2328
		public sealed class Class1294 : IEnumerator
		{
			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x0600393A RID: 14650 RVA: 0x00121CC8 File Offset: 0x0011FEC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600393B RID: 14651 RVA: 0x0001E621 File Offset: 0x0001C821
			public Class1294(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x0600393C RID: 14652 RVA: 0x0001E637 File Offset: 0x0001C837
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600393D RID: 14653 RVA: 0x0001E640 File Offset: 0x0001C840
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_26();
			}

			// Token: 0x0600393E RID: 14654 RVA: 0x00121CE0 File Offset: 0x0011FEE0
			public Class2096 method_0()
			{
				return this.class2098_0.method_27(this.int_0);
			}

			// Token: 0x04001A40 RID: 6720
			private int int_0;

			// Token: 0x04001A41 RID: 6721
			private Class2098 class2098_0;
		}

		// Token: 0x02000919 RID: 2329
		public sealed class Class1295 : IEnumerable
		{
			// Token: 0x0600393F RID: 14655 RVA: 0x0001E663 File Offset: 0x0001C863
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003940 RID: 14656 RVA: 0x00121D00 File Offset: 0x0011FF00
			public Class2098.Class1296 method_1()
			{
				return new Class2098.Class1296(this.class2098_0);
			}

			// Token: 0x06003941 RID: 14657 RVA: 0x00121D1C File Offset: 0x0011FF1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A42 RID: 6722
			private Class2098 class2098_0;
		}

		// Token: 0x0200091A RID: 2330
		public sealed class Class1296 : IEnumerator
		{
			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06003943 RID: 14659 RVA: 0x00121D34 File Offset: 0x0011FF34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003944 RID: 14660 RVA: 0x0001E66C File Offset: 0x0001C86C
			public Class1296(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x06003945 RID: 14661 RVA: 0x0001E682 File Offset: 0x0001C882
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003946 RID: 14662 RVA: 0x0001E68B File Offset: 0x0001C88B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_28();
			}

			// Token: 0x06003947 RID: 14663 RVA: 0x00121D4C File Offset: 0x0011FF4C
			public Class2050 method_0()
			{
				return this.class2098_0.method_29(this.int_0);
			}

			// Token: 0x04001A43 RID: 6723
			private int int_0;

			// Token: 0x04001A44 RID: 6724
			private Class2098 class2098_0;
		}

		// Token: 0x0200091B RID: 2331
		public sealed class Class1297 : IEnumerable
		{
			// Token: 0x06003948 RID: 14664 RVA: 0x0001E6AE File Offset: 0x0001C8AE
			public void method_0(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
			}

			// Token: 0x06003949 RID: 14665 RVA: 0x00121D6C File Offset: 0x0011FF6C
			public Class2098.Class1298 method_1()
			{
				return new Class2098.Class1298(this.class2098_0);
			}

			// Token: 0x0600394A RID: 14666 RVA: 0x00121D88 File Offset: 0x0011FF88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A45 RID: 6725
			private Class2098 class2098_0;
		}

		// Token: 0x0200091C RID: 2332
		public sealed class Class1298 : IEnumerator
		{
			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x0600394C RID: 14668 RVA: 0x00121DA0 File Offset: 0x0011FFA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x0001E6B7 File Offset: 0x0001C8B7
			public Class1298(Class2098 class2098_1)
			{
				this.class2098_0 = class2098_1;
				this.int_0 = -1;
			}

			// Token: 0x0600394E RID: 14670 RVA: 0x0001E6CD File Offset: 0x0001C8CD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600394F RID: 14671 RVA: 0x0001E6D6 File Offset: 0x0001C8D6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2098_0.method_30();
			}

			// Token: 0x06003950 RID: 14672 RVA: 0x00121DB8 File Offset: 0x0011FFB8
			public Class2074 method_0()
			{
				return this.class2098_0.method_31(this.int_0);
			}

			// Token: 0x04001A46 RID: 6726
			private int int_0;

			// Token: 0x04001A47 RID: 6727
			private Class2098 class2098_0;
		}
	}
}
