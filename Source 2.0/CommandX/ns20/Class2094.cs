using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x020008B5 RID: 2229
	public sealed class Class2094 : Class2059
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x0011EA28 File Offset: 0x0011CC28
		public Class2094()
		{
			this.method_22();
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0011EAB0 File Offset: 0x0011CCB0
		public Class2094(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_22();
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0007D2A0 File Offset: 0x0007B4A0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBox");
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x0010A638 File Offset: 0x00108838
		public Class2083 method_9(int int_0)
		{
			return new Class2083(base.method_1(Class2059.Enum155.const_1, "", "BoundingBox", int_0));
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x0010A6F8 File Offset: 0x001088F8
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TerrainMapped");
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0010A718 File Offset: 0x00108918
		public Class2009 method_11(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TerrainMapped", int_0)));
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0011E39C File Offset: 0x0011C59C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageAccessor");
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0011E3BC File Offset: 0x0011C5BC
		public Class2076 method_13(int int_0)
		{
			return new Class2076(base.method_1(Class2059.Enum155.const_1, "", "ImageAccessor", int_0));
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0011E3E4 File Offset: 0x0011C5E4
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TileDrawDistanceFactor");
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0011E404 File Offset: 0x0011C604
		public Class2020 method_15(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TileDrawDistanceFactor", int_0)));
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0011E430 File Offset: 0x0011C630
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TileSpreadFactor");
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0011E450 File Offset: 0x0011C650
		public Class2020 method_17(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TileSpreadFactor", int_0)));
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_19(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0010A7D8 File Offset: 0x001089D8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TransparentColor");
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x0010A7F8 File Offset: 0x001089F8
		public Class2096 method_21(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "TransparentColor", int_0));
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x0011EB38 File Offset: 0x0011CD38
		private void method_22()
		{
			this.class1207_0.method_0(this);
			this.class1209_0.method_0(this);
			this.class1211_0.method_0(this);
			this.class1213_0.method_0(this);
			this.class1215_0.method_0(this);
			this.class1217_0.method_0(this);
			this.class1219_0.method_0(this);
			this.class1221_0.method_0(this);
			this.class1223_0.method_0(this);
			this.class1225_0.method_0(this);
		}

		// Token: 0x04001938 RID: 6456
		public Class2094.Class1207 class1207_0 = new Class2094.Class1207();

		// Token: 0x04001939 RID: 6457
		public Class2094.Class1209 class1209_0 = new Class2094.Class1209();

		// Token: 0x0400193A RID: 6458
		public Class2094.Class1211 class1211_0 = new Class2094.Class1211();

		// Token: 0x0400193B RID: 6459
		public Class2094.Class1213 class1213_0 = new Class2094.Class1213();

		// Token: 0x0400193C RID: 6460
		public Class2094.Class1215 class1215_0 = new Class2094.Class1215();

		// Token: 0x0400193D RID: 6461
		public Class2094.Class1217 class1217_0 = new Class2094.Class1217();

		// Token: 0x0400193E RID: 6462
		public Class2094.Class1219 class1219_0 = new Class2094.Class1219();

		// Token: 0x0400193F RID: 6463
		public Class2094.Class1221 class1221_0 = new Class2094.Class1221();

		// Token: 0x04001940 RID: 6464
		public Class2094.Class1223 class1223_0 = new Class2094.Class1223();

		// Token: 0x04001941 RID: 6465
		public Class2094.Class1225 class1225_0 = new Class2094.Class1225();

		// Token: 0x020008B6 RID: 2230
		public sealed class Class1207 : IEnumerable
		{
			// Token: 0x060036E5 RID: 14053 RVA: 0x0001D2F9 File Offset: 0x0001B4F9
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x060036E6 RID: 14054 RVA: 0x0011EBC0 File Offset: 0x0011CDC0
			public Class2094.Class1208 method_1()
			{
				return new Class2094.Class1208(this.class2094_0);
			}

			// Token: 0x060036E7 RID: 14055 RVA: 0x0011EBDC File Offset: 0x0011CDDC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001942 RID: 6466
			private Class2094 class2094_0;
		}

		// Token: 0x020008B7 RID: 2231
		public sealed class Class1208 : IEnumerator
		{
			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0011EBF4 File Offset: 0x0011CDF4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036EA RID: 14058 RVA: 0x0001D302 File Offset: 0x0001B502
			public Class1208(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x060036EB RID: 14059 RVA: 0x0001D318 File Offset: 0x0001B518
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036EC RID: 14060 RVA: 0x0001D321 File Offset: 0x0001B521
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_2();
			}

			// Token: 0x060036ED RID: 14061 RVA: 0x0011EC0C File Offset: 0x0011CE0C
			public Class2009 method_0()
			{
				return this.class2094_0.method_3(this.int_0);
			}

			// Token: 0x04001943 RID: 6467
			private int int_0;

			// Token: 0x04001944 RID: 6468
			private Class2094 class2094_0;
		}

		// Token: 0x020008B8 RID: 2232
		public sealed class Class1209 : IEnumerable
		{
			// Token: 0x060036EE RID: 14062 RVA: 0x0001D344 File Offset: 0x0001B544
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x060036EF RID: 14063 RVA: 0x0011EC2C File Offset: 0x0011CE2C
			public Class2094.Class1210 method_1()
			{
				return new Class2094.Class1210(this.class2094_0);
			}

			// Token: 0x060036F0 RID: 14064 RVA: 0x0011EC48 File Offset: 0x0011CE48
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001945 RID: 6469
			private Class2094 class2094_0;
		}

		// Token: 0x020008B9 RID: 2233
		public sealed class Class1210 : IEnumerator
		{
			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x060036F2 RID: 14066 RVA: 0x0011EC60 File Offset: 0x0011CE60
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036F3 RID: 14067 RVA: 0x0001D34D File Offset: 0x0001B54D
			public Class1210(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x060036F4 RID: 14068 RVA: 0x0001D363 File Offset: 0x0001B563
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036F5 RID: 14069 RVA: 0x0001D36C File Offset: 0x0001B56C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_4();
			}

			// Token: 0x060036F6 RID: 14070 RVA: 0x0011EC78 File Offset: 0x0011CE78
			public Class2050 method_0()
			{
				return this.class2094_0.method_5(this.int_0);
			}

			// Token: 0x04001946 RID: 6470
			private int int_0;

			// Token: 0x04001947 RID: 6471
			private Class2094 class2094_0;
		}

		// Token: 0x020008BA RID: 2234
		public sealed class Class1211 : IEnumerable
		{
			// Token: 0x060036F7 RID: 14071 RVA: 0x0001D38F File Offset: 0x0001B58F
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x060036F8 RID: 14072 RVA: 0x0011EC98 File Offset: 0x0011CE98
			public Class2094.Class1212 method_1()
			{
				return new Class2094.Class1212(this.class2094_0);
			}

			// Token: 0x060036F9 RID: 14073 RVA: 0x0011ECB4 File Offset: 0x0011CEB4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001948 RID: 6472
			private Class2094 class2094_0;
		}

		// Token: 0x020008BB RID: 2235
		public sealed class Class1212 : IEnumerator
		{
			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x060036FB RID: 14075 RVA: 0x0011ECCC File Offset: 0x0011CECC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036FC RID: 14076 RVA: 0x0001D398 File Offset: 0x0001B598
			public Class1212(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x060036FD RID: 14077 RVA: 0x0001D3AE File Offset: 0x0001B5AE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036FE RID: 14078 RVA: 0x0001D3B7 File Offset: 0x0001B5B7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_6();
			}

			// Token: 0x060036FF RID: 14079 RVA: 0x0011ECE4 File Offset: 0x0011CEE4
			public Class2020 method_0()
			{
				return this.class2094_0.method_7(this.int_0);
			}

			// Token: 0x04001949 RID: 6473
			private int int_0;

			// Token: 0x0400194A RID: 6474
			private Class2094 class2094_0;
		}

		// Token: 0x020008BC RID: 2236
		public sealed class Class1213 : IEnumerable
		{
			// Token: 0x06003700 RID: 14080 RVA: 0x0001D3DA File Offset: 0x0001B5DA
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x06003701 RID: 14081 RVA: 0x0011ED04 File Offset: 0x0011CF04
			public Class2094.Class1214 method_1()
			{
				return new Class2094.Class1214(this.class2094_0);
			}

			// Token: 0x06003702 RID: 14082 RVA: 0x0011ED20 File Offset: 0x0011CF20
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400194B RID: 6475
			private Class2094 class2094_0;
		}

		// Token: 0x020008BD RID: 2237
		public sealed class Class1214 : IEnumerator
		{
			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06003704 RID: 14084 RVA: 0x0011ED38 File Offset: 0x0011CF38
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003705 RID: 14085 RVA: 0x0001D3E3 File Offset: 0x0001B5E3
			public Class1214(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x06003706 RID: 14086 RVA: 0x0001D3F9 File Offset: 0x0001B5F9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003707 RID: 14087 RVA: 0x0001D402 File Offset: 0x0001B602
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_8();
			}

			// Token: 0x06003708 RID: 14088 RVA: 0x0011ED50 File Offset: 0x0011CF50
			public Class2083 method_0()
			{
				return this.class2094_0.method_9(this.int_0);
			}

			// Token: 0x0400194C RID: 6476
			private int int_0;

			// Token: 0x0400194D RID: 6477
			private Class2094 class2094_0;
		}

		// Token: 0x020008BE RID: 2238
		public sealed class Class1215 : IEnumerable
		{
			// Token: 0x06003709 RID: 14089 RVA: 0x0001D425 File Offset: 0x0001B625
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x0600370A RID: 14090 RVA: 0x0011ED70 File Offset: 0x0011CF70
			public Class2094.Class1216 method_1()
			{
				return new Class2094.Class1216(this.class2094_0);
			}

			// Token: 0x0600370B RID: 14091 RVA: 0x0011ED8C File Offset: 0x0011CF8C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400194E RID: 6478
			private Class2094 class2094_0;
		}

		// Token: 0x020008BF RID: 2239
		public sealed class Class1216 : IEnumerator
		{
			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x0600370D RID: 14093 RVA: 0x0011EDA4 File Offset: 0x0011CFA4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600370E RID: 14094 RVA: 0x0001D42E File Offset: 0x0001B62E
			public Class1216(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x0600370F RID: 14095 RVA: 0x0001D444 File Offset: 0x0001B644
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003710 RID: 14096 RVA: 0x0001D44D File Offset: 0x0001B64D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_10();
			}

			// Token: 0x06003711 RID: 14097 RVA: 0x0011EDBC File Offset: 0x0011CFBC
			public Class2009 method_0()
			{
				return this.class2094_0.method_11(this.int_0);
			}

			// Token: 0x0400194F RID: 6479
			private int int_0;

			// Token: 0x04001950 RID: 6480
			private Class2094 class2094_0;
		}

		// Token: 0x020008C0 RID: 2240
		public sealed class Class1217 : IEnumerable
		{
			// Token: 0x06003712 RID: 14098 RVA: 0x0001D470 File Offset: 0x0001B670
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x06003713 RID: 14099 RVA: 0x0011EDDC File Offset: 0x0011CFDC
			public Class2094.Class1218 method_1()
			{
				return new Class2094.Class1218(this.class2094_0);
			}

			// Token: 0x06003714 RID: 14100 RVA: 0x0011EDF8 File Offset: 0x0011CFF8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001951 RID: 6481
			private Class2094 class2094_0;
		}

		// Token: 0x020008C1 RID: 2241
		public sealed class Class1218 : IEnumerator
		{
			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06003716 RID: 14102 RVA: 0x0011EE10 File Offset: 0x0011D010
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003717 RID: 14103 RVA: 0x0001D479 File Offset: 0x0001B679
			public Class1218(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x06003718 RID: 14104 RVA: 0x0001D48F File Offset: 0x0001B68F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003719 RID: 14105 RVA: 0x0001D498 File Offset: 0x0001B698
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_12();
			}

			// Token: 0x0600371A RID: 14106 RVA: 0x0011EE28 File Offset: 0x0011D028
			public Class2076 method_0()
			{
				return this.class2094_0.method_13(this.int_0);
			}

			// Token: 0x04001952 RID: 6482
			private int int_0;

			// Token: 0x04001953 RID: 6483
			private Class2094 class2094_0;
		}

		// Token: 0x020008C2 RID: 2242
		public sealed class Class1219 : IEnumerable
		{
			// Token: 0x0600371B RID: 14107 RVA: 0x0001D4BB File Offset: 0x0001B6BB
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x0600371C RID: 14108 RVA: 0x0011EE48 File Offset: 0x0011D048
			public Class2094.Class1220 method_1()
			{
				return new Class2094.Class1220(this.class2094_0);
			}

			// Token: 0x0600371D RID: 14109 RVA: 0x0011EE64 File Offset: 0x0011D064
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001954 RID: 6484
			private Class2094 class2094_0;
		}

		// Token: 0x020008C3 RID: 2243
		public sealed class Class1220 : IEnumerator
		{
			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x0600371F RID: 14111 RVA: 0x0011EE7C File Offset: 0x0011D07C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003720 RID: 14112 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
			public Class1220(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x06003721 RID: 14113 RVA: 0x0001D4DA File Offset: 0x0001B6DA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003722 RID: 14114 RVA: 0x0001D4E3 File Offset: 0x0001B6E3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_14();
			}

			// Token: 0x06003723 RID: 14115 RVA: 0x0011EE94 File Offset: 0x0011D094
			public Class2020 method_0()
			{
				return this.class2094_0.method_15(this.int_0);
			}

			// Token: 0x04001955 RID: 6485
			private int int_0;

			// Token: 0x04001956 RID: 6486
			private Class2094 class2094_0;
		}

		// Token: 0x020008C4 RID: 2244
		public sealed class Class1221 : IEnumerable
		{
			// Token: 0x06003724 RID: 14116 RVA: 0x0001D506 File Offset: 0x0001B706
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x06003725 RID: 14117 RVA: 0x0011EEB4 File Offset: 0x0011D0B4
			public Class2094.Class1222 method_1()
			{
				return new Class2094.Class1222(this.class2094_0);
			}

			// Token: 0x06003726 RID: 14118 RVA: 0x0011EED0 File Offset: 0x0011D0D0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001957 RID: 6487
			private Class2094 class2094_0;
		}

		// Token: 0x020008C5 RID: 2245
		public sealed class Class1222 : IEnumerator
		{
			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06003728 RID: 14120 RVA: 0x0011EEE8 File Offset: 0x0011D0E8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003729 RID: 14121 RVA: 0x0001D50F File Offset: 0x0001B70F
			public Class1222(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x0600372A RID: 14122 RVA: 0x0001D525 File Offset: 0x0001B725
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600372B RID: 14123 RVA: 0x0001D52E File Offset: 0x0001B72E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_16();
			}

			// Token: 0x0600372C RID: 14124 RVA: 0x0011EF00 File Offset: 0x0011D100
			public Class2020 method_0()
			{
				return this.class2094_0.method_17(this.int_0);
			}

			// Token: 0x04001958 RID: 6488
			private int int_0;

			// Token: 0x04001959 RID: 6489
			private Class2094 class2094_0;
		}

		// Token: 0x020008C6 RID: 2246
		public sealed class Class1223 : IEnumerable
		{
			// Token: 0x0600372D RID: 14125 RVA: 0x0001D551 File Offset: 0x0001B751
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x0600372E RID: 14126 RVA: 0x0011EF20 File Offset: 0x0011D120
			public Class2094.Class1224 method_1()
			{
				return new Class2094.Class1224(this.class2094_0);
			}

			// Token: 0x0600372F RID: 14127 RVA: 0x0011EF3C File Offset: 0x0011D13C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400195A RID: 6490
			private Class2094 class2094_0;
		}

		// Token: 0x020008C7 RID: 2247
		public sealed class Class1224 : IEnumerator
		{
			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06003731 RID: 14129 RVA: 0x0011EF54 File Offset: 0x0011D154
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003732 RID: 14130 RVA: 0x0001D55A File Offset: 0x0001B75A
			public Class1224(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x06003733 RID: 14131 RVA: 0x0001D570 File Offset: 0x0001B770
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003734 RID: 14132 RVA: 0x0001D579 File Offset: 0x0001B779
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_18();
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x0011EF6C File Offset: 0x0011D16C
			public Class2074 method_0()
			{
				return this.class2094_0.method_19(this.int_0);
			}

			// Token: 0x0400195B RID: 6491
			private int int_0;

			// Token: 0x0400195C RID: 6492
			private Class2094 class2094_0;
		}

		// Token: 0x020008C8 RID: 2248
		public sealed class Class1225 : IEnumerable
		{
			// Token: 0x06003736 RID: 14134 RVA: 0x0001D59C File Offset: 0x0001B79C
			public void method_0(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x0011EF8C File Offset: 0x0011D18C
			public Class2094.Class1226 method_1()
			{
				return new Class2094.Class1226(this.class2094_0);
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x0011EFA8 File Offset: 0x0011D1A8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400195D RID: 6493
			private Class2094 class2094_0;
		}

		// Token: 0x020008C9 RID: 2249
		public sealed class Class1226 : IEnumerator
		{
			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x0600373A RID: 14138 RVA: 0x0011EFC0 File Offset: 0x0011D1C0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600373B RID: 14139 RVA: 0x0001D5A5 File Offset: 0x0001B7A5
			public Class1226(Class2094 class2094_1)
			{
				this.class2094_0 = class2094_1;
				this.int_0 = -1;
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x0001D5BB File Offset: 0x0001B7BB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600373D RID: 14141 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2094_0.method_20();
			}

			// Token: 0x0600373E RID: 14142 RVA: 0x0011EFD8 File Offset: 0x0011D1D8
			public Class2096 method_0()
			{
				return this.class2094_0.method_21(this.int_0);
			}

			// Token: 0x0400195E RID: 6494
			private int int_0;

			// Token: 0x0400195F RID: 6495
			private Class2094 class2094_0;
		}
	}
}
