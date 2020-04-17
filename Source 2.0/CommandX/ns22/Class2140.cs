using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x020001EE RID: 494
	public sealed class Class2140 : Class2059
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x0007817C File Offset: 0x0007637C
		public Class2140()
		{
			this.method_12();
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000781CC File Offset: 0x000763CC
		public Class2140(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_12();
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00078220 File Offset: 0x00076420
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Request");
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00078240 File Offset: 0x00076440
		public Class2168 method_3(int int_0)
		{
			return new Class2168(base.method_1(Class2059.Enum155.const_1, "", "Request", int_0));
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00078268 File Offset: 0x00076468
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Exception");
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00078288 File Offset: 0x00076488
		public Class2148 method_5(int int_0)
		{
			return new Class2148(base.method_1(Class2059.Enum155.const_1, "", "Exception", int_0));
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000782B0 File Offset: 0x000764B0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "VendorSpecificCapabilities");
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000782D0 File Offset: 0x000764D0
		public Class2175 method_7(int int_0)
		{
			return new Class2175(base.method_1(Class2059.Enum155.const_1, "", "VendorSpecificCapabilities", int_0));
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000782F8 File Offset: 0x000764F8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "UserDefinedSymbolization");
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00078318 File Offset: 0x00076518
		public Class2174 method_9(int int_0)
		{
			return new Class2174(base.method_1(Class2059.Enum155.const_1, "", "UserDefinedSymbolization", int_0));
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00078340 File Offset: 0x00076540
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Layer");
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00078360 File Offset: 0x00076560
		public Class2161 method_11(int int_0)
		{
			return new Class2161(base.method_1(Class2059.Enum155.const_1, "", "Layer", int_0));
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000A117 File Offset: 0x00008317
		private void method_12()
		{
			this.class1683_0.method_0(this);
			this.class1685_0.method_0(this);
			this.class1687_0.method_0(this);
			this.class1689_0.method_0(this);
			this.class1691_0.method_0(this);
		}

		// Token: 0x04000514 RID: 1300
		public Class2140.Class1683 class1683_0 = new Class2140.Class1683();

		// Token: 0x04000515 RID: 1301
		public Class2140.Class1685 class1685_0 = new Class2140.Class1685();

		// Token: 0x04000516 RID: 1302
		public Class2140.Class1687 class1687_0 = new Class2140.Class1687();

		// Token: 0x04000517 RID: 1303
		public Class2140.Class1689 class1689_0 = new Class2140.Class1689();

		// Token: 0x04000518 RID: 1304
		public Class2140.Class1691 class1691_0 = new Class2140.Class1691();

		// Token: 0x020001EF RID: 495
		public sealed class Class1683 : IEnumerable
		{
			// Token: 0x06000BAC RID: 2988 RVA: 0x0000A155 File Offset: 0x00008355
			public void method_0(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00078388 File Offset: 0x00076588
			public Class2140.Class1684 method_1()
			{
				return new Class2140.Class1684(this.class2140_0);
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x000783A4 File Offset: 0x000765A4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000519 RID: 1305
			private Class2140 class2140_0;
		}

		// Token: 0x020001F0 RID: 496
		public sealed class Class1684 : IEnumerator
		{
			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000783BC File Offset: 0x000765BC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0000A15E File Offset: 0x0000835E
			public Class1684(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x0000A174 File Offset: 0x00008374
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x0000A17D File Offset: 0x0000837D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2140_0.method_2();
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x000783D4 File Offset: 0x000765D4
			public Class2168 method_0()
			{
				return this.class2140_0.method_3(this.int_0);
			}

			// Token: 0x0400051A RID: 1306
			private int int_0;

			// Token: 0x0400051B RID: 1307
			private Class2140 class2140_0;
		}

		// Token: 0x020001F1 RID: 497
		public sealed class Class1685 : IEnumerable
		{
			// Token: 0x06000BB5 RID: 2997 RVA: 0x0000A1A0 File Offset: 0x000083A0
			public void method_0(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x000783F4 File Offset: 0x000765F4
			public Class2140.Class1686 method_1()
			{
				return new Class2140.Class1686(this.class2140_0);
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x00078410 File Offset: 0x00076610
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400051C RID: 1308
			private Class2140 class2140_0;
		}

		// Token: 0x020001F2 RID: 498
		public sealed class Class1686 : IEnumerator
		{
			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00078428 File Offset: 0x00076628
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x0000A1A9 File Offset: 0x000083A9
			public Class1686(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BBB RID: 3003 RVA: 0x0000A1BF File Offset: 0x000083BF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x0000A1C8 File Offset: 0x000083C8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2140_0.method_4();
			}

			// Token: 0x06000BBD RID: 3005 RVA: 0x00078440 File Offset: 0x00076640
			public Class2148 method_0()
			{
				return this.class2140_0.method_5(this.int_0);
			}

			// Token: 0x0400051D RID: 1309
			private int int_0;

			// Token: 0x0400051E RID: 1310
			private Class2140 class2140_0;
		}

		// Token: 0x020001F3 RID: 499
		public sealed class Class1687 : IEnumerable
		{
			// Token: 0x06000BBE RID: 3006 RVA: 0x0000A1EB File Offset: 0x000083EB
			public void method_0(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
			}

			// Token: 0x06000BBF RID: 3007 RVA: 0x00078460 File Offset: 0x00076660
			public Class2140.Class1688 method_1()
			{
				return new Class2140.Class1688(this.class2140_0);
			}

			// Token: 0x06000BC0 RID: 3008 RVA: 0x0007847C File Offset: 0x0007667C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400051F RID: 1311
			private Class2140 class2140_0;
		}

		// Token: 0x020001F4 RID: 500
		public sealed class Class1688 : IEnumerator
		{
			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00078494 File Offset: 0x00076694
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BC3 RID: 3011 RVA: 0x0000A1F4 File Offset: 0x000083F4
			public Class1688(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BC4 RID: 3012 RVA: 0x0000A20A File Offset: 0x0000840A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x0000A213 File Offset: 0x00008413
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2140_0.method_6();
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x000784AC File Offset: 0x000766AC
			public Class2175 method_0()
			{
				return this.class2140_0.method_7(this.int_0);
			}

			// Token: 0x04000520 RID: 1312
			private int int_0;

			// Token: 0x04000521 RID: 1313
			private Class2140 class2140_0;
		}

		// Token: 0x020001F5 RID: 501
		public sealed class Class1689 : IEnumerable
		{
			// Token: 0x06000BC7 RID: 3015 RVA: 0x0000A236 File Offset: 0x00008436
			public void method_0(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x000784CC File Offset: 0x000766CC
			public Class2140.Class1690 method_1()
			{
				return new Class2140.Class1690(this.class2140_0);
			}

			// Token: 0x06000BC9 RID: 3017 RVA: 0x000784E8 File Offset: 0x000766E8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000522 RID: 1314
			private Class2140 class2140_0;
		}

		// Token: 0x020001F6 RID: 502
		public sealed class Class1690 : IEnumerator
		{
			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00078500 File Offset: 0x00076700
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BCC RID: 3020 RVA: 0x0000A23F File Offset: 0x0000843F
			public Class1690(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BCD RID: 3021 RVA: 0x0000A255 File Offset: 0x00008455
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BCE RID: 3022 RVA: 0x0000A25E File Offset: 0x0000845E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2140_0.method_8();
			}

			// Token: 0x06000BCF RID: 3023 RVA: 0x00078518 File Offset: 0x00076718
			public Class2174 method_0()
			{
				return this.class2140_0.method_9(this.int_0);
			}

			// Token: 0x04000523 RID: 1315
			private int int_0;

			// Token: 0x04000524 RID: 1316
			private Class2140 class2140_0;
		}

		// Token: 0x020001F7 RID: 503
		public sealed class Class1691 : IEnumerable
		{
			// Token: 0x06000BD0 RID: 3024 RVA: 0x0000A281 File Offset: 0x00008481
			public void method_0(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
			}

			// Token: 0x06000BD1 RID: 3025 RVA: 0x00078538 File Offset: 0x00076738
			public Class2140.Class1692 method_1()
			{
				return new Class2140.Class1692(this.class2140_0);
			}

			// Token: 0x06000BD2 RID: 3026 RVA: 0x00078554 File Offset: 0x00076754
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000525 RID: 1317
			private Class2140 class2140_0;
		}

		// Token: 0x020001F8 RID: 504
		public sealed class Class1692 : IEnumerator
		{
			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0007856C File Offset: 0x0007676C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000BD5 RID: 3029 RVA: 0x0000A28A File Offset: 0x0000848A
			public Class1692(Class2140 class2140_1)
			{
				this.class2140_0 = class2140_1;
				this.int_0 = -1;
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x0000A2A0 File Offset: 0x000084A0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x0000A2A9 File Offset: 0x000084A9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2140_0.method_10();
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x00078584 File Offset: 0x00076784
			public Class2161 method_0()
			{
				return this.class2140_0.method_11(this.int_0);
			}

			// Token: 0x04000526 RID: 1318
			private int int_0;

			// Token: 0x04000527 RID: 1319
			private Class2140 class2140_0;
		}
	}
}
