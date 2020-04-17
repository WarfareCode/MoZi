using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x020001DF RID: 479
	public sealed class Class2139 : Class2059
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x00077C00 File Offset: 0x00075E00
		public Class2139()
		{
			this.method_16();
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00077C68 File Offset: 0x00075E68
		public Class2139(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_16();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00077CD0 File Offset: 0x00075ED0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "SRS");
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00077CF0 File Offset: 0x00075EF0
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "SRS", int_0)));
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0005CF0C File Offset: 0x0005B10C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "minx");
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00077D1C File Offset: 0x00075F1C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "minx", int_0)));
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0005CF58 File Offset: 0x0005B158
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "miny");
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00077D48 File Offset: 0x00075F48
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "miny", int_0)));
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "maxx");
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00077D74 File Offset: 0x00075F74
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "maxx", int_0)));
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "maxy");
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00077DA0 File Offset: 0x00075FA0
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "maxy", int_0)));
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0005D03C File Offset: 0x0005B23C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "resx");
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00077DCC File Offset: 0x00075FCC
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "resx", int_0)));
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0005D088 File Offset: 0x0005B288
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "resy");
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00077DF8 File Offset: 0x00075FF8
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "resy", int_0)));
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00077E24 File Offset: 0x00076024
		private void method_16()
		{
			this.class1669_0.method_0(this);
			this.class1671_0.method_0(this);
			this.class1673_0.method_0(this);
			this.class1675_0.method_0(this);
			this.class1677_0.method_0(this);
			this.class1679_0.method_0(this);
			this.class1681_0.method_0(this);
		}

		// Token: 0x040004F8 RID: 1272
		public Class2139.Class1669 class1669_0 = new Class2139.Class1669();

		// Token: 0x040004F9 RID: 1273
		public Class2139.Class1671 class1671_0 = new Class2139.Class1671();

		// Token: 0x040004FA RID: 1274
		public Class2139.Class1673 class1673_0 = new Class2139.Class1673();

		// Token: 0x040004FB RID: 1275
		public Class2139.Class1675 class1675_0 = new Class2139.Class1675();

		// Token: 0x040004FC RID: 1276
		public Class2139.Class1677 class1677_0 = new Class2139.Class1677();

		// Token: 0x040004FD RID: 1277
		public Class2139.Class1679 class1679_0 = new Class2139.Class1679();

		// Token: 0x040004FE RID: 1278
		public Class2139.Class1681 class1681_0 = new Class2139.Class1681();

		// Token: 0x020001E0 RID: 480
		public sealed class Class1669 : IEnumerable
		{
			// Token: 0x06000B60 RID: 2912 RVA: 0x00009F0A File Offset: 0x0000810A
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x00077E88 File Offset: 0x00076088
			public Class2139.Class1670 method_1()
			{
				return new Class2139.Class1670(this.class2139_0);
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x00077EA4 File Offset: 0x000760A4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004FF RID: 1279
			private Class2139 class2139_0;
		}

		// Token: 0x020001E1 RID: 481
		public sealed class Class1670 : IEnumerator
		{
			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00077EBC File Offset: 0x000760BC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B65 RID: 2917 RVA: 0x00009F13 File Offset: 0x00008113
			public Class1670(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x00009F29 File Offset: 0x00008129
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x00009F32 File Offset: 0x00008132
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_2();
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x00077ED4 File Offset: 0x000760D4
			public Class2050 method_0()
			{
				return this.class2139_0.method_3(this.int_0);
			}

			// Token: 0x04000500 RID: 1280
			private int int_0;

			// Token: 0x04000501 RID: 1281
			private Class2139 class2139_0;
		}

		// Token: 0x020001E2 RID: 482
		public sealed class Class1671 : IEnumerable
		{
			// Token: 0x06000B69 RID: 2921 RVA: 0x00009F55 File Offset: 0x00008155
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x00077EF4 File Offset: 0x000760F4
			public Class2139.Class1672 method_1()
			{
				return new Class2139.Class1672(this.class2139_0);
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x00077F10 File Offset: 0x00076110
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000502 RID: 1282
			private Class2139 class2139_0;
		}

		// Token: 0x020001E3 RID: 483
		public sealed class Class1672 : IEnumerator
		{
			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00077F28 File Offset: 0x00076128
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x00009F5E File Offset: 0x0000815E
			public Class1672(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x00009F74 File Offset: 0x00008174
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x00009F7D File Offset: 0x0000817D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_4();
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x00077F40 File Offset: 0x00076140
			public Class2050 method_0()
			{
				return this.class2139_0.method_5(this.int_0);
			}

			// Token: 0x04000503 RID: 1283
			private int int_0;

			// Token: 0x04000504 RID: 1284
			private Class2139 class2139_0;
		}

		// Token: 0x020001E4 RID: 484
		public sealed class Class1673 : IEnumerable
		{
			// Token: 0x06000B72 RID: 2930 RVA: 0x00009FA0 File Offset: 0x000081A0
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x00077F60 File Offset: 0x00076160
			public Class2139.Class1674 method_1()
			{
				return new Class2139.Class1674(this.class2139_0);
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x00077F7C File Offset: 0x0007617C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000505 RID: 1285
			private Class2139 class2139_0;
		}

		// Token: 0x020001E5 RID: 485
		public sealed class Class1674 : IEnumerator
		{
			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00077F94 File Offset: 0x00076194
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B77 RID: 2935 RVA: 0x00009FA9 File Offset: 0x000081A9
			public Class1674(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B78 RID: 2936 RVA: 0x00009FBF File Offset: 0x000081BF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B79 RID: 2937 RVA: 0x00009FC8 File Offset: 0x000081C8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_6();
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x00077FAC File Offset: 0x000761AC
			public Class2050 method_0()
			{
				return this.class2139_0.method_7(this.int_0);
			}

			// Token: 0x04000506 RID: 1286
			private int int_0;

			// Token: 0x04000507 RID: 1287
			private Class2139 class2139_0;
		}

		// Token: 0x020001E6 RID: 486
		public sealed class Class1675 : IEnumerable
		{
			// Token: 0x06000B7B RID: 2939 RVA: 0x00009FEB File Offset: 0x000081EB
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x00077FCC File Offset: 0x000761CC
			public Class2139.Class1676 method_1()
			{
				return new Class2139.Class1676(this.class2139_0);
			}

			// Token: 0x06000B7D RID: 2941 RVA: 0x00077FE8 File Offset: 0x000761E8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000508 RID: 1288
			private Class2139 class2139_0;
		}

		// Token: 0x020001E7 RID: 487
		public sealed class Class1676 : IEnumerator
		{
			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00078000 File Offset: 0x00076200
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x00009FF4 File Offset: 0x000081F4
			public Class1676(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B81 RID: 2945 RVA: 0x0000A00A File Offset: 0x0000820A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B82 RID: 2946 RVA: 0x0000A013 File Offset: 0x00008213
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_8();
			}

			// Token: 0x06000B83 RID: 2947 RVA: 0x00078018 File Offset: 0x00076218
			public Class2050 method_0()
			{
				return this.class2139_0.method_9(this.int_0);
			}

			// Token: 0x04000509 RID: 1289
			private int int_0;

			// Token: 0x0400050A RID: 1290
			private Class2139 class2139_0;
		}

		// Token: 0x020001E8 RID: 488
		public sealed class Class1677 : IEnumerable
		{
			// Token: 0x06000B84 RID: 2948 RVA: 0x0000A036 File Offset: 0x00008236
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B85 RID: 2949 RVA: 0x00078038 File Offset: 0x00076238
			public Class2139.Class1678 method_1()
			{
				return new Class2139.Class1678(this.class2139_0);
			}

			// Token: 0x06000B86 RID: 2950 RVA: 0x00078054 File Offset: 0x00076254
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400050B RID: 1291
			private Class2139 class2139_0;
		}

		// Token: 0x020001E9 RID: 489
		public sealed class Class1678 : IEnumerator
		{
			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0007806C File Offset: 0x0007626C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B89 RID: 2953 RVA: 0x0000A03F File Offset: 0x0000823F
			public Class1678(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0000A055 File Offset: 0x00008255
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x0000A05E File Offset: 0x0000825E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_10();
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x00078084 File Offset: 0x00076284
			public Class2050 method_0()
			{
				return this.class2139_0.method_11(this.int_0);
			}

			// Token: 0x0400050C RID: 1292
			private int int_0;

			// Token: 0x0400050D RID: 1293
			private Class2139 class2139_0;
		}

		// Token: 0x020001EA RID: 490
		public sealed class Class1679 : IEnumerable
		{
			// Token: 0x06000B8D RID: 2957 RVA: 0x0000A081 File Offset: 0x00008281
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x000780A4 File Offset: 0x000762A4
			public Class2139.Class1680 method_1()
			{
				return new Class2139.Class1680(this.class2139_0);
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x000780C0 File Offset: 0x000762C0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400050E RID: 1294
			private Class2139 class2139_0;
		}

		// Token: 0x020001EB RID: 491
		public sealed class Class1680 : IEnumerator
		{
			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000B91 RID: 2961 RVA: 0x000780D8 File Offset: 0x000762D8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x0000A08A File Offset: 0x0000828A
			public Class1680(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x0000A0A0 File Offset: 0x000082A0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x0000A0A9 File Offset: 0x000082A9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_12();
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x000780F0 File Offset: 0x000762F0
			public Class2050 method_0()
			{
				return this.class2139_0.method_13(this.int_0);
			}

			// Token: 0x0400050F RID: 1295
			private int int_0;

			// Token: 0x04000510 RID: 1296
			private Class2139 class2139_0;
		}

		// Token: 0x020001EC RID: 492
		public sealed class Class1681 : IEnumerable
		{
			// Token: 0x06000B96 RID: 2966 RVA: 0x0000A0CC File Offset: 0x000082CC
			public void method_0(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00078110 File Offset: 0x00076310
			public Class2139.Class1682 method_1()
			{
				return new Class2139.Class1682(this.class2139_0);
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x0007812C File Offset: 0x0007632C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000511 RID: 1297
			private Class2139 class2139_0;
		}

		// Token: 0x020001ED RID: 493
		public sealed class Class1682 : IEnumerator
		{
			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00078144 File Offset: 0x00076344
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B9B RID: 2971 RVA: 0x0000A0D5 File Offset: 0x000082D5
			public Class1682(Class2139 class2139_1)
			{
				this.class2139_0 = class2139_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x0000A0EB File Offset: 0x000082EB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x0000A0F4 File Offset: 0x000082F4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2139_0.method_14();
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x0007815C File Offset: 0x0007635C
			public Class2050 method_0()
			{
				return this.class2139_0.method_15(this.int_0);
			}

			// Token: 0x04000512 RID: 1298
			private int int_0;

			// Token: 0x04000513 RID: 1299
			private Class2139 class2139_0;
		}
	}
}
