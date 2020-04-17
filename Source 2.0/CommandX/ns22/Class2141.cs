using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x020001F9 RID: 505
	public sealed class Class2141 : Class2059
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x000785A4 File Offset: 0x000767A4
		public Class2141()
		{
			this.method_14();
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00078600 File Offset: 0x00076800
		public Class2141(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0007865C File Offset: 0x0007685C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "AddressType");
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0007867C File Offset: 0x0007687C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "AddressType", int_0)));
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000786A8 File Offset: 0x000768A8
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Address");
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000786C8 File Offset: 0x000768C8
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Address", int_0)));
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000786F4 File Offset: 0x000768F4
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "City");
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00078714 File Offset: 0x00076914
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "City", int_0)));
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00078740 File Offset: 0x00076940
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "StateOrProvince");
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00078760 File Offset: 0x00076960
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "StateOrProvince", int_0)));
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0007878C File Offset: 0x0007698C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PostCode");
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000787AC File Offset: 0x000769AC
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "PostCode", int_0)));
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000787D8 File Offset: 0x000769D8
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Country");
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000787F8 File Offset: 0x000769F8
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Country", int_0)));
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00078824 File Offset: 0x00076A24
		private void method_14()
		{
			this.class1693_0.method_0(this);
			this.class1695_0.method_0(this);
			this.class1697_0.method_0(this);
			this.class1699_0.method_0(this);
			this.class1701_0.method_0(this);
			this.class1703_0.method_0(this);
		}

		// Token: 0x04000528 RID: 1320
		public Class2141.Class1693 class1693_0 = new Class2141.Class1693();

		// Token: 0x04000529 RID: 1321
		public Class2141.Class1695 class1695_0 = new Class2141.Class1695();

		// Token: 0x0400052A RID: 1322
		public Class2141.Class1697 class1697_0 = new Class2141.Class1697();

		// Token: 0x0400052B RID: 1323
		public Class2141.Class1699 class1699_0 = new Class2141.Class1699();

		// Token: 0x0400052C RID: 1324
		public Class2141.Class1701 class1701_0 = new Class2141.Class1701();

		// Token: 0x0400052D RID: 1325
		public Class2141.Class1703 class1703_0 = new Class2141.Class1703();

		// Token: 0x020001FA RID: 506
		public sealed class Class1693 : IEnumerable
		{
			// Token: 0x06000BE8 RID: 3048 RVA: 0x0000A2CC File Offset: 0x000084CC
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x0007887C File Offset: 0x00076A7C
			public Class2141.Class1694 method_1()
			{
				return new Class2141.Class1694(this.class2141_0);
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x00078898 File Offset: 0x00076A98
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400052E RID: 1326
			private Class2141 class2141_0;
		}

		// Token: 0x020001FB RID: 507
		public sealed class Class1694 : IEnumerator
		{
			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000788B0 File Offset: 0x00076AB0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x0000A2D5 File Offset: 0x000084D5
			public Class1694(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BEE RID: 3054 RVA: 0x0000A2EB File Offset: 0x000084EB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BEF RID: 3055 RVA: 0x0000A2F4 File Offset: 0x000084F4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_2();
			}

			// Token: 0x06000BF0 RID: 3056 RVA: 0x000788C8 File Offset: 0x00076AC8
			public Class2050 method_0()
			{
				return this.class2141_0.method_3(this.int_0);
			}

			// Token: 0x0400052F RID: 1327
			private int int_0;

			// Token: 0x04000530 RID: 1328
			private Class2141 class2141_0;
		}

		// Token: 0x020001FC RID: 508
		public sealed class Class1695 : IEnumerable
		{
			// Token: 0x06000BF1 RID: 3057 RVA: 0x0000A317 File Offset: 0x00008517
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000BF2 RID: 3058 RVA: 0x000788E8 File Offset: 0x00076AE8
			public Class2141.Class1696 method_1()
			{
				return new Class2141.Class1696(this.class2141_0);
			}

			// Token: 0x06000BF3 RID: 3059 RVA: 0x00078904 File Offset: 0x00076B04
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000531 RID: 1329
			private Class2141 class2141_0;
		}

		// Token: 0x020001FD RID: 509
		public sealed class Class1696 : IEnumerator
		{
			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0007891C File Offset: 0x00076B1C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BF6 RID: 3062 RVA: 0x0000A320 File Offset: 0x00008520
			public Class1696(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x0000A336 File Offset: 0x00008536
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x0000A33F File Offset: 0x0000853F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_4();
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00078934 File Offset: 0x00076B34
			public Class2050 method_0()
			{
				return this.class2141_0.method_5(this.int_0);
			}

			// Token: 0x04000532 RID: 1330
			private int int_0;

			// Token: 0x04000533 RID: 1331
			private Class2141 class2141_0;
		}

		// Token: 0x020001FE RID: 510
		public sealed class Class1697 : IEnumerable
		{
			// Token: 0x06000BFA RID: 3066 RVA: 0x0000A362 File Offset: 0x00008562
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00078954 File Offset: 0x00076B54
			public Class2141.Class1698 method_1()
			{
				return new Class2141.Class1698(this.class2141_0);
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x00078970 File Offset: 0x00076B70
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000534 RID: 1332
			private Class2141 class2141_0;
		}

		// Token: 0x020001FF RID: 511
		public sealed class Class1698 : IEnumerator
		{
			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00078988 File Offset: 0x00076B88
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x0000A36B File Offset: 0x0000856B
			public Class1698(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C00 RID: 3072 RVA: 0x0000A381 File Offset: 0x00008581
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x0000A38A File Offset: 0x0000858A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_6();
			}

			// Token: 0x06000C02 RID: 3074 RVA: 0x000789A0 File Offset: 0x00076BA0
			public Class2050 method_0()
			{
				return this.class2141_0.method_7(this.int_0);
			}

			// Token: 0x04000535 RID: 1333
			private int int_0;

			// Token: 0x04000536 RID: 1334
			private Class2141 class2141_0;
		}

		// Token: 0x02000200 RID: 512
		public sealed class Class1699 : IEnumerable
		{
			// Token: 0x06000C03 RID: 3075 RVA: 0x0000A3AD File Offset: 0x000085AD
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000C04 RID: 3076 RVA: 0x000789C0 File Offset: 0x00076BC0
			public Class2141.Class1700 method_1()
			{
				return new Class2141.Class1700(this.class2141_0);
			}

			// Token: 0x06000C05 RID: 3077 RVA: 0x000789DC File Offset: 0x00076BDC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000537 RID: 1335
			private Class2141 class2141_0;
		}

		// Token: 0x02000201 RID: 513
		public sealed class Class1700 : IEnumerator
		{
			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000789F4 File Offset: 0x00076BF4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C08 RID: 3080 RVA: 0x0000A3B6 File Offset: 0x000085B6
			public Class1700(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C09 RID: 3081 RVA: 0x0000A3CC File Offset: 0x000085CC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C0A RID: 3082 RVA: 0x0000A3D5 File Offset: 0x000085D5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_8();
			}

			// Token: 0x06000C0B RID: 3083 RVA: 0x00078A0C File Offset: 0x00076C0C
			public Class2050 method_0()
			{
				return this.class2141_0.method_9(this.int_0);
			}

			// Token: 0x04000538 RID: 1336
			private int int_0;

			// Token: 0x04000539 RID: 1337
			private Class2141 class2141_0;
		}

		// Token: 0x02000202 RID: 514
		public sealed class Class1701 : IEnumerable
		{
			// Token: 0x06000C0C RID: 3084 RVA: 0x0000A3F8 File Offset: 0x000085F8
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00078A2C File Offset: 0x00076C2C
			public Class2141.Class1702 method_1()
			{
				return new Class2141.Class1702(this.class2141_0);
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00078A48 File Offset: 0x00076C48
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400053A RID: 1338
			private Class2141 class2141_0;
		}

		// Token: 0x02000203 RID: 515
		public sealed class Class1702 : IEnumerator
		{
			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00078A60 File Offset: 0x00076C60
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C11 RID: 3089 RVA: 0x0000A401 File Offset: 0x00008601
			public Class1702(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x0000A417 File Offset: 0x00008617
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C13 RID: 3091 RVA: 0x0000A420 File Offset: 0x00008620
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_10();
			}

			// Token: 0x06000C14 RID: 3092 RVA: 0x00078A78 File Offset: 0x00076C78
			public Class2050 method_0()
			{
				return this.class2141_0.method_11(this.int_0);
			}

			// Token: 0x0400053B RID: 1339
			private int int_0;

			// Token: 0x0400053C RID: 1340
			private Class2141 class2141_0;
		}

		// Token: 0x02000204 RID: 516
		public sealed class Class1703 : IEnumerable
		{
			// Token: 0x06000C15 RID: 3093 RVA: 0x0000A443 File Offset: 0x00008643
			public void method_0(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x00078A98 File Offset: 0x00076C98
			public Class2141.Class1704 method_1()
			{
				return new Class2141.Class1704(this.class2141_0);
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x00078AB4 File Offset: 0x00076CB4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400053D RID: 1341
			private Class2141 class2141_0;
		}

		// Token: 0x02000205 RID: 517
		public sealed class Class1704 : IEnumerator
		{
			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00078ACC File Offset: 0x00076CCC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x0000A44C File Offset: 0x0000864C
			public Class1704(Class2141 class2141_1)
			{
				this.class2141_0 = class2141_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x0000A462 File Offset: 0x00008662
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x0000A46B File Offset: 0x0000866B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2141_0.method_12();
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00078AE4 File Offset: 0x00076CE4
			public Class2050 method_0()
			{
				return this.class2141_0.method_13(this.int_0);
			}

			// Token: 0x0400053E RID: 1342
			private int int_0;

			// Token: 0x0400053F RID: 1343
			private Class2141 class2141_0;
		}
	}
}
