using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;
using ns21;

namespace ns20
{
	// Token: 0x02000807 RID: 2055
	public sealed class Class2084 : Class2059
	{
		// Token: 0x060032C3 RID: 12995 RVA: 0x00118EE8 File Offset: 0x001170E8
		public Class2084()
		{
			this.method_26();
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00118F88 File Offset: 0x00117188
		public Class2084(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_26();
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000FF148 File Offset: 0x000FD348
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "Name");
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00119028 File Offset: 0x00117228
		public Class2054 method_3(int int_0)
		{
			return new Class2054(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "Name", int_0)));
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00119054 File Offset: 0x00117254
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowOnlyOneLayer");
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00119074 File Offset: 0x00117274
		public Class2009 method_5(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowOnlyOneLayer", int_0)));
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00106590 File Offset: 0x00104790
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_7(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x001190A0 File Offset: 0x001172A0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageLayer");
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x001190C0 File Offset: 0x001172C0
		public Class2077 method_9(int int_0)
		{
			return new Class2077(base.method_1(Class2059.Enum155.const_1, "", "ImageLayer", int_0));
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x001190E8 File Offset: 0x001172E8
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "QuadTileSet");
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00119108 File Offset: 0x00117308
		public Class2094 method_11(int int_0)
		{
			return new Class2094(base.method_1(Class2059.Enum155.const_1, "", "QuadTileSet", int_0));
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00119130 File Offset: 0x00117330
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ShapeFileLayer");
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00119150 File Offset: 0x00117350
		public Class2098 method_13(int int_0)
		{
			return new Class2098(base.method_1(Class2059.Enum155.const_1, "", "ShapeFileLayer", int_0));
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00119178 File Offset: 0x00117378
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MeshLayer");
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00119198 File Offset: 0x00117398
		public Class2088 method_15(int int_0)
		{
			return new Class2088(base.method_1(Class2059.Enum155.const_1, "", "MeshLayer", int_0));
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001191C0 File Offset: 0x001173C0
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PathList");
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x001191E0 File Offset: 0x001173E0
		public Class2092 method_17(int int_0)
		{
			return new Class2092(base.method_1(Class2059.Enum155.const_1, "", "PathList", int_0));
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00119208 File Offset: 0x00117408
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Icon");
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x00119228 File Offset: 0x00117428
		public Class2075 method_19(int int_0)
		{
			return new Class2075(base.method_1(Class2059.Enum155.const_1, "", "Icon", int_0));
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00119250 File Offset: 0x00117450
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TiledPlacenameSet");
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00119270 File Offset: 0x00117470
		public Class2102 method_21(int int_0)
		{
			return new Class2102(base.method_1(Class2059.Enum155.const_1, "", "TiledPlacenameSet", int_0));
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00119298 File Offset: 0x00117498
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ChildLayerSet");
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x001192B8 File Offset: 0x001174B8
		public Class2084 method_23(int int_0)
		{
			return new Class2084(base.method_1(Class2059.Enum155.const_1, "", "ChildLayerSet", int_0));
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_24()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_25(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x001192E0 File Offset: 0x001174E0
		private void method_26()
		{
			this.class1067_0.method_0(this);
			this.class1069_0.method_0(this);
			this.class1071_0.method_0(this);
			this.class1073_0.method_0(this);
			this.class1075_0.method_0(this);
			this.class1077_0.method_0(this);
			this.class1079_0.method_0(this);
			this.class1081_0.method_0(this);
			this.class1083_0.method_0(this);
			this.class1085_0.method_0(this);
			this.class1087_0.method_0(this);
			this.class1089_0.method_0(this);
		}

		// Token: 0x040017A0 RID: 6048
		public Class2084.Class1067 class1067_0 = new Class2084.Class1067();

		// Token: 0x040017A1 RID: 6049
		public Class2084.Class1069 class1069_0 = new Class2084.Class1069();

		// Token: 0x040017A2 RID: 6050
		public Class2084.Class1071 class1071_0 = new Class2084.Class1071();

		// Token: 0x040017A3 RID: 6051
		public Class2084.Class1073 class1073_0 = new Class2084.Class1073();

		// Token: 0x040017A4 RID: 6052
		public Class2084.Class1075 class1075_0 = new Class2084.Class1075();

		// Token: 0x040017A5 RID: 6053
		public Class2084.Class1077 class1077_0 = new Class2084.Class1077();

		// Token: 0x040017A6 RID: 6054
		public Class2084.Class1079 class1079_0 = new Class2084.Class1079();

		// Token: 0x040017A7 RID: 6055
		public Class2084.Class1081 class1081_0 = new Class2084.Class1081();

		// Token: 0x040017A8 RID: 6056
		public Class2084.Class1083 class1083_0 = new Class2084.Class1083();

		// Token: 0x040017A9 RID: 6057
		public Class2084.Class1085 class1085_0 = new Class2084.Class1085();

		// Token: 0x040017AA RID: 6058
		public Class2084.Class1087 class1087_0 = new Class2084.Class1087();

		// Token: 0x040017AB RID: 6059
		public Class2084.Class1089 class1089_0 = new Class2084.Class1089();

		// Token: 0x02000808 RID: 2056
		public sealed class Class1067 : IEnumerable
		{
			// Token: 0x060032DE RID: 13022 RVA: 0x0001B372 File Offset: 0x00019572
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x060032DF RID: 13023 RVA: 0x00119380 File Offset: 0x00117580
			public Class2084.Class1068 method_1()
			{
				return new Class2084.Class1068(this.class2084_0);
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x0011939C File Offset: 0x0011759C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017AC RID: 6060
			private Class2084 class2084_0;
		}

		// Token: 0x02000809 RID: 2057
		public sealed class Class1068 : IEnumerator
		{
			// Token: 0x17000375 RID: 885
			// (get) Token: 0x060032E2 RID: 13026 RVA: 0x001193B4 File Offset: 0x001175B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060032E3 RID: 13027 RVA: 0x0001B37B File Offset: 0x0001957B
			public Class1068(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x060032E4 RID: 13028 RVA: 0x0001B391 File Offset: 0x00019591
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060032E5 RID: 13029 RVA: 0x0001B39A File Offset: 0x0001959A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_2();
			}

			// Token: 0x060032E6 RID: 13030 RVA: 0x001193CC File Offset: 0x001175CC
			public Class2054 method_0()
			{
				return this.class2084_0.method_3(this.int_0);
			}

			// Token: 0x040017AD RID: 6061
			private int int_0;

			// Token: 0x040017AE RID: 6062
			private Class2084 class2084_0;
		}

		// Token: 0x0200080A RID: 2058
		public sealed class Class1069 : IEnumerable
		{
			// Token: 0x060032E7 RID: 13031 RVA: 0x0001B3BD File Offset: 0x000195BD
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x060032E8 RID: 13032 RVA: 0x001193EC File Offset: 0x001175EC
			public Class2084.Class1070 method_1()
			{
				return new Class2084.Class1070(this.class2084_0);
			}

			// Token: 0x060032E9 RID: 13033 RVA: 0x00119408 File Offset: 0x00117608
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017AF RID: 6063
			private Class2084 class2084_0;
		}

		// Token: 0x0200080B RID: 2059
		public sealed class Class1070 : IEnumerator
		{
			// Token: 0x17000376 RID: 886
			// (get) Token: 0x060032EB RID: 13035 RVA: 0x00119420 File Offset: 0x00117620
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060032EC RID: 13036 RVA: 0x0001B3C6 File Offset: 0x000195C6
			public Class1070(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x060032ED RID: 13037 RVA: 0x0001B3DC File Offset: 0x000195DC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060032EE RID: 13038 RVA: 0x0001B3E5 File Offset: 0x000195E5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_4();
			}

			// Token: 0x060032EF RID: 13039 RVA: 0x00119438 File Offset: 0x00117638
			public Class2009 method_0()
			{
				return this.class2084_0.method_5(this.int_0);
			}

			// Token: 0x040017B0 RID: 6064
			private int int_0;

			// Token: 0x040017B1 RID: 6065
			private Class2084 class2084_0;
		}

		// Token: 0x0200080C RID: 2060
		public sealed class Class1071 : IEnumerable
		{
			// Token: 0x060032F0 RID: 13040 RVA: 0x0001B408 File Offset: 0x00019608
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x060032F1 RID: 13041 RVA: 0x00119458 File Offset: 0x00117658
			public Class2084.Class1072 method_1()
			{
				return new Class2084.Class1072(this.class2084_0);
			}

			// Token: 0x060032F2 RID: 13042 RVA: 0x00119474 File Offset: 0x00117674
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017B2 RID: 6066
			private Class2084 class2084_0;
		}

		// Token: 0x0200080D RID: 2061
		public sealed class Class1072 : IEnumerator
		{
			// Token: 0x17000377 RID: 887
			// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0011948C File Offset: 0x0011768C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060032F5 RID: 13045 RVA: 0x0001B411 File Offset: 0x00019611
			public Class1072(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x060032F6 RID: 13046 RVA: 0x0001B427 File Offset: 0x00019627
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060032F7 RID: 13047 RVA: 0x0001B430 File Offset: 0x00019630
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_6();
			}

			// Token: 0x060032F8 RID: 13048 RVA: 0x001194A4 File Offset: 0x001176A4
			public Class2009 method_0()
			{
				return this.class2084_0.method_7(this.int_0);
			}

			// Token: 0x040017B3 RID: 6067
			private int int_0;

			// Token: 0x040017B4 RID: 6068
			private Class2084 class2084_0;
		}

		// Token: 0x0200080E RID: 2062
		public sealed class Class1073 : IEnumerable
		{
			// Token: 0x060032F9 RID: 13049 RVA: 0x0001B453 File Offset: 0x00019653
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x060032FA RID: 13050 RVA: 0x001194C4 File Offset: 0x001176C4
			public Class2084.Class1074 method_1()
			{
				return new Class2084.Class1074(this.class2084_0);
			}

			// Token: 0x060032FB RID: 13051 RVA: 0x001194E0 File Offset: 0x001176E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017B5 RID: 6069
			private Class2084 class2084_0;
		}

		// Token: 0x0200080F RID: 2063
		public sealed class Class1074 : IEnumerator
		{
			// Token: 0x17000378 RID: 888
			// (get) Token: 0x060032FD RID: 13053 RVA: 0x001194F8 File Offset: 0x001176F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060032FE RID: 13054 RVA: 0x0001B45C File Offset: 0x0001965C
			public Class1074(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x060032FF RID: 13055 RVA: 0x0001B472 File Offset: 0x00019672
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003300 RID: 13056 RVA: 0x0001B47B File Offset: 0x0001967B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_8();
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x00119510 File Offset: 0x00117710
			public Class2077 method_0()
			{
				return this.class2084_0.method_9(this.int_0);
			}

			// Token: 0x040017B6 RID: 6070
			private int int_0;

			// Token: 0x040017B7 RID: 6071
			private Class2084 class2084_0;
		}

		// Token: 0x02000810 RID: 2064
		public sealed class Class1075 : IEnumerable
		{
			// Token: 0x06003302 RID: 13058 RVA: 0x0001B49E File Offset: 0x0001969E
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003303 RID: 13059 RVA: 0x00119530 File Offset: 0x00117730
			public Class2084.Class1076 method_1()
			{
				return new Class2084.Class1076(this.class2084_0);
			}

			// Token: 0x06003304 RID: 13060 RVA: 0x0011954C File Offset: 0x0011774C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017B8 RID: 6072
			private Class2084 class2084_0;
		}

		// Token: 0x02000811 RID: 2065
		public sealed class Class1076 : IEnumerator
		{
			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06003306 RID: 13062 RVA: 0x00119564 File Offset: 0x00117764
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003307 RID: 13063 RVA: 0x0001B4A7 File Offset: 0x000196A7
			public Class1076(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x06003308 RID: 13064 RVA: 0x0001B4BD File Offset: 0x000196BD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003309 RID: 13065 RVA: 0x0001B4C6 File Offset: 0x000196C6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_10();
			}

			// Token: 0x0600330A RID: 13066 RVA: 0x0011957C File Offset: 0x0011777C
			public Class2094 method_0()
			{
				return this.class2084_0.method_11(this.int_0);
			}

			// Token: 0x040017B9 RID: 6073
			private int int_0;

			// Token: 0x040017BA RID: 6074
			private Class2084 class2084_0;
		}

		// Token: 0x02000812 RID: 2066
		public sealed class Class1077 : IEnumerable
		{
			// Token: 0x0600330B RID: 13067 RVA: 0x0001B4E9 File Offset: 0x000196E9
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x0600330C RID: 13068 RVA: 0x0011959C File Offset: 0x0011779C
			public Class2084.Class1078 method_1()
			{
				return new Class2084.Class1078(this.class2084_0);
			}

			// Token: 0x0600330D RID: 13069 RVA: 0x001195B8 File Offset: 0x001177B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017BB RID: 6075
			private Class2084 class2084_0;
		}

		// Token: 0x02000813 RID: 2067
		public sealed class Class1078 : IEnumerator
		{
			// Token: 0x1700037A RID: 890
			// (get) Token: 0x0600330F RID: 13071 RVA: 0x001195D0 File Offset: 0x001177D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003310 RID: 13072 RVA: 0x0001B4F2 File Offset: 0x000196F2
			public Class1078(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x06003311 RID: 13073 RVA: 0x0001B508 File Offset: 0x00019708
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003312 RID: 13074 RVA: 0x0001B511 File Offset: 0x00019711
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_12();
			}

			// Token: 0x06003313 RID: 13075 RVA: 0x001195E8 File Offset: 0x001177E8
			public Class2098 method_0()
			{
				return this.class2084_0.method_13(this.int_0);
			}

			// Token: 0x040017BC RID: 6076
			private int int_0;

			// Token: 0x040017BD RID: 6077
			private Class2084 class2084_0;
		}

		// Token: 0x02000814 RID: 2068
		public sealed class Class1079 : IEnumerable
		{
			// Token: 0x06003314 RID: 13076 RVA: 0x0001B534 File Offset: 0x00019734
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003315 RID: 13077 RVA: 0x00119608 File Offset: 0x00117808
			public Class2084.Class1080 method_1()
			{
				return new Class2084.Class1080(this.class2084_0);
			}

			// Token: 0x06003316 RID: 13078 RVA: 0x00119624 File Offset: 0x00117824
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017BE RID: 6078
			private Class2084 class2084_0;
		}

		// Token: 0x02000815 RID: 2069
		public sealed class Class1080 : IEnumerator
		{
			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06003318 RID: 13080 RVA: 0x0011963C File Offset: 0x0011783C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003319 RID: 13081 RVA: 0x0001B53D File Offset: 0x0001973D
			public Class1080(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x0600331A RID: 13082 RVA: 0x0001B553 File Offset: 0x00019753
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600331B RID: 13083 RVA: 0x0001B55C File Offset: 0x0001975C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_14();
			}

			// Token: 0x0600331C RID: 13084 RVA: 0x00119654 File Offset: 0x00117854
			public Class2088 method_0()
			{
				return this.class2084_0.method_15(this.int_0);
			}

			// Token: 0x040017BF RID: 6079
			private int int_0;

			// Token: 0x040017C0 RID: 6080
			private Class2084 class2084_0;
		}

		// Token: 0x02000816 RID: 2070
		public sealed class Class1081 : IEnumerable
		{
			// Token: 0x0600331D RID: 13085 RVA: 0x0001B57F File Offset: 0x0001977F
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x0600331E RID: 13086 RVA: 0x00119674 File Offset: 0x00117874
			public Class2084.Class1082 method_1()
			{
				return new Class2084.Class1082(this.class2084_0);
			}

			// Token: 0x0600331F RID: 13087 RVA: 0x00119690 File Offset: 0x00117890
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017C1 RID: 6081
			private Class2084 class2084_0;
		}

		// Token: 0x02000817 RID: 2071
		public sealed class Class1082 : IEnumerator
		{
			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06003321 RID: 13089 RVA: 0x001196A8 File Offset: 0x001178A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003322 RID: 13090 RVA: 0x0001B588 File Offset: 0x00019788
			public Class1082(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x06003323 RID: 13091 RVA: 0x0001B59E File Offset: 0x0001979E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003324 RID: 13092 RVA: 0x0001B5A7 File Offset: 0x000197A7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_16();
			}

			// Token: 0x06003325 RID: 13093 RVA: 0x001196C0 File Offset: 0x001178C0
			public Class2092 method_0()
			{
				return this.class2084_0.method_17(this.int_0);
			}

			// Token: 0x040017C2 RID: 6082
			private int int_0;

			// Token: 0x040017C3 RID: 6083
			private Class2084 class2084_0;
		}

		// Token: 0x02000818 RID: 2072
		public sealed class Class1083 : IEnumerable
		{
			// Token: 0x06003326 RID: 13094 RVA: 0x0001B5CA File Offset: 0x000197CA
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003327 RID: 13095 RVA: 0x001196E0 File Offset: 0x001178E0
			public Class2084.Class1084 method_1()
			{
				return new Class2084.Class1084(this.class2084_0);
			}

			// Token: 0x06003328 RID: 13096 RVA: 0x001196FC File Offset: 0x001178FC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017C4 RID: 6084
			private Class2084 class2084_0;
		}

		// Token: 0x02000819 RID: 2073
		public sealed class Class1084 : IEnumerator
		{
			// Token: 0x1700037D RID: 893
			// (get) Token: 0x0600332A RID: 13098 RVA: 0x00119714 File Offset: 0x00117914
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600332B RID: 13099 RVA: 0x0001B5D3 File Offset: 0x000197D3
			public Class1084(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x0600332C RID: 13100 RVA: 0x0001B5E9 File Offset: 0x000197E9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600332D RID: 13101 RVA: 0x0001B5F2 File Offset: 0x000197F2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_18();
			}

			// Token: 0x0600332E RID: 13102 RVA: 0x0011972C File Offset: 0x0011792C
			public Class2075 method_0()
			{
				return this.class2084_0.method_19(this.int_0);
			}

			// Token: 0x040017C5 RID: 6085
			private int int_0;

			// Token: 0x040017C6 RID: 6086
			private Class2084 class2084_0;
		}

		// Token: 0x0200081A RID: 2074
		public sealed class Class1085 : IEnumerable
		{
			// Token: 0x0600332F RID: 13103 RVA: 0x0001B615 File Offset: 0x00019815
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003330 RID: 13104 RVA: 0x0011974C File Offset: 0x0011794C
			public Class2084.Class1086 method_1()
			{
				return new Class2084.Class1086(this.class2084_0);
			}

			// Token: 0x06003331 RID: 13105 RVA: 0x00119768 File Offset: 0x00117968
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017C7 RID: 6087
			private Class2084 class2084_0;
		}

		// Token: 0x0200081B RID: 2075
		public sealed class Class1086 : IEnumerator
		{
			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06003333 RID: 13107 RVA: 0x00119780 File Offset: 0x00117980
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003334 RID: 13108 RVA: 0x0001B61E File Offset: 0x0001981E
			public Class1086(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x06003335 RID: 13109 RVA: 0x0001B634 File Offset: 0x00019834
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003336 RID: 13110 RVA: 0x0001B63D File Offset: 0x0001983D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_20();
			}

			// Token: 0x06003337 RID: 13111 RVA: 0x00119798 File Offset: 0x00117998
			public Class2102 method_0()
			{
				return this.class2084_0.method_21(this.int_0);
			}

			// Token: 0x040017C8 RID: 6088
			private int int_0;

			// Token: 0x040017C9 RID: 6089
			private Class2084 class2084_0;
		}

		// Token: 0x0200081C RID: 2076
		public sealed class Class1087 : IEnumerable
		{
			// Token: 0x06003338 RID: 13112 RVA: 0x0001B660 File Offset: 0x00019860
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003339 RID: 13113 RVA: 0x001197B8 File Offset: 0x001179B8
			public Class2084.Class1088 method_1()
			{
				return new Class2084.Class1088(this.class2084_0);
			}

			// Token: 0x0600333A RID: 13114 RVA: 0x001197D4 File Offset: 0x001179D4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017CA RID: 6090
			private Class2084 class2084_0;
		}

		// Token: 0x0200081D RID: 2077
		public sealed class Class1088 : IEnumerator
		{
			// Token: 0x1700037F RID: 895
			// (get) Token: 0x0600333C RID: 13116 RVA: 0x001197EC File Offset: 0x001179EC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600333D RID: 13117 RVA: 0x0001B669 File Offset: 0x00019869
			public Class1088(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x0600333E RID: 13118 RVA: 0x0001B67F File Offset: 0x0001987F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600333F RID: 13119 RVA: 0x0001B688 File Offset: 0x00019888
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_22();
			}

			// Token: 0x06003340 RID: 13120 RVA: 0x00119804 File Offset: 0x00117A04
			public Class2084 method_0()
			{
				return this.class2084_0.method_23(this.int_0);
			}

			// Token: 0x040017CB RID: 6091
			private int int_0;

			// Token: 0x040017CC RID: 6092
			private Class2084 class2084_0;
		}

		// Token: 0x0200081E RID: 2078
		public sealed class Class1089 : IEnumerable
		{
			// Token: 0x06003341 RID: 13121 RVA: 0x0001B6AB File Offset: 0x000198AB
			public void method_0(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
			}

			// Token: 0x06003342 RID: 13122 RVA: 0x00119824 File Offset: 0x00117A24
			public Class2084.Class1090 method_1()
			{
				return new Class2084.Class1090(this.class2084_0);
			}

			// Token: 0x06003343 RID: 13123 RVA: 0x00119840 File Offset: 0x00117A40
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017CD RID: 6093
			private Class2084 class2084_0;
		}

		// Token: 0x0200081F RID: 2079
		public sealed class Class1090 : IEnumerator
		{
			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06003345 RID: 13125 RVA: 0x00119858 File Offset: 0x00117A58
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003346 RID: 13126 RVA: 0x0001B6B4 File Offset: 0x000198B4
			public Class1090(Class2084 class2084_1)
			{
				this.class2084_0 = class2084_1;
				this.int_0 = -1;
			}

			// Token: 0x06003347 RID: 13127 RVA: 0x0001B6CA File Offset: 0x000198CA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003348 RID: 13128 RVA: 0x0001B6D3 File Offset: 0x000198D3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2084_0.method_24();
			}

			// Token: 0x06003349 RID: 13129 RVA: 0x00119870 File Offset: 0x00117A70
			public Class2074 method_0()
			{
				return this.class2084_0.method_25(this.int_0);
			}

			// Token: 0x040017CE RID: 6094
			private int int_0;

			// Token: 0x040017CF RID: 6095
			private Class2084 class2084_0;
		}
	}
}
