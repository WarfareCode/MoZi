using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x0200089E RID: 2206
	public sealed class Class2093 : Class2059
	{
		// Token: 0x06003655 RID: 13909 RVA: 0x0011E314 File Offset: 0x0011C514
		public Class2093()
		{
			this.method_22();
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0007D2A0 File Offset: 0x0007B4A0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBox");
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0010A638 File Offset: 0x00108838
		public Class2083 method_9(int int_0)
		{
			return new Class2083(base.method_1(Class2059.Enum155.const_1, "", "BoundingBox", int_0));
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0010A6F8 File Offset: 0x001088F8
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TerrainMapped");
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0010A718 File Offset: 0x00108918
		public Class2009 method_11(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TerrainMapped", int_0)));
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0011E39C File Offset: 0x0011C59C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageAccessor");
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x0011E3BC File Offset: 0x0011C5BC
		public Class2076 method_13(int int_0)
		{
			return new Class2076(base.method_1(Class2059.Enum155.const_1, "", "ImageAccessor", int_0));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0011E3E4 File Offset: 0x0011C5E4
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TileDrawDistanceFactor");
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0011E404 File Offset: 0x0011C604
		public Class2020 method_15(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TileDrawDistanceFactor", int_0)));
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0011E430 File Offset: 0x0011C630
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TileSpreadFactor");
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0011E450 File Offset: 0x0011C650
		public Class2020 method_17(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TileSpreadFactor", int_0)));
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_19(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0010A7D8 File Offset: 0x001089D8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TransparentColor");
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0010A7F8 File Offset: 0x001089F8
		public Class2096 method_21(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "TransparentColor", int_0));
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0011E47C File Offset: 0x0011C67C
		private void method_22()
		{
			this.class1187_0.method_0(this);
			this.class1189_0.method_0(this);
			this.class1191_0.method_0(this);
			this.class1193_0.method_0(this);
			this.class1195_0.method_0(this);
			this.class1197_0.method_0(this);
			this.class1199_0.method_0(this);
			this.class1201_0.method_0(this);
			this.class1203_0.method_0(this);
			this.class1205_0.method_0(this);
		}

		// Token: 0x0400190B RID: 6411
		public Class2093.Class1187 class1187_0 = new Class2093.Class1187();

		// Token: 0x0400190C RID: 6412
		public Class2093.Class1189 class1189_0 = new Class2093.Class1189();

		// Token: 0x0400190D RID: 6413
		public Class2093.Class1191 class1191_0 = new Class2093.Class1191();

		// Token: 0x0400190E RID: 6414
		public Class2093.Class1193 class1193_0 = new Class2093.Class1193();

		// Token: 0x0400190F RID: 6415
		public Class2093.Class1195 class1195_0 = new Class2093.Class1195();

		// Token: 0x04001910 RID: 6416
		public Class2093.Class1197 class1197_0 = new Class2093.Class1197();

		// Token: 0x04001911 RID: 6417
		public Class2093.Class1199 class1199_0 = new Class2093.Class1199();

		// Token: 0x04001912 RID: 6418
		public Class2093.Class1201 class1201_0 = new Class2093.Class1201();

		// Token: 0x04001913 RID: 6419
		public Class2093.Class1203 class1203_0 = new Class2093.Class1203();

		// Token: 0x04001914 RID: 6420
		public Class2093.Class1205 class1205_0 = new Class2093.Class1205();

		// Token: 0x0200089F RID: 2207
		public sealed class Class1187 : IEnumerable
		{
			// Token: 0x0600366B RID: 13931 RVA: 0x0001CFB3 File Offset: 0x0001B1B3
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x0600366C RID: 13932 RVA: 0x0011E504 File Offset: 0x0011C704
			public Class2093.Class1188 method_1()
			{
				return new Class2093.Class1188(this.class2093_0);
			}

			// Token: 0x0600366D RID: 13933 RVA: 0x0011E520 File Offset: 0x0011C720
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001915 RID: 6421
			private Class2093 class2093_0;
		}

		// Token: 0x020008A0 RID: 2208
		public sealed class Class1188 : IEnumerator
		{
			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x0600366F RID: 13935 RVA: 0x0011E538 File Offset: 0x0011C738
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003670 RID: 13936 RVA: 0x0001CFBC File Offset: 0x0001B1BC
			public Class1188(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x06003671 RID: 13937 RVA: 0x0001CFD2 File Offset: 0x0001B1D2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003672 RID: 13938 RVA: 0x0001CFDB File Offset: 0x0001B1DB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_2();
			}

			// Token: 0x06003673 RID: 13939 RVA: 0x0011E550 File Offset: 0x0011C750
			public Class2009 method_0()
			{
				return this.class2093_0.method_3(this.int_0);
			}

			// Token: 0x04001916 RID: 6422
			private int int_0;

			// Token: 0x04001917 RID: 6423
			private Class2093 class2093_0;
		}

		// Token: 0x020008A1 RID: 2209
		public sealed class Class1189 : IEnumerable
		{
			// Token: 0x06003674 RID: 13940 RVA: 0x0001CFFE File Offset: 0x0001B1FE
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x06003675 RID: 13941 RVA: 0x0011E570 File Offset: 0x0011C770
			public Class2093.Class1190 method_1()
			{
				return new Class2093.Class1190(this.class2093_0);
			}

			// Token: 0x06003676 RID: 13942 RVA: 0x0011E58C File Offset: 0x0011C78C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001918 RID: 6424
			private Class2093 class2093_0;
		}

		// Token: 0x020008A2 RID: 2210
		public sealed class Class1190 : IEnumerator
		{
			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06003678 RID: 13944 RVA: 0x0011E5A4 File Offset: 0x0011C7A4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003679 RID: 13945 RVA: 0x0001D007 File Offset: 0x0001B207
			public Class1190(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x0600367A RID: 13946 RVA: 0x0001D01D File Offset: 0x0001B21D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600367B RID: 13947 RVA: 0x0001D026 File Offset: 0x0001B226
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_4();
			}

			// Token: 0x0600367C RID: 13948 RVA: 0x0011E5BC File Offset: 0x0011C7BC
			public Class2050 method_0()
			{
				return this.class2093_0.method_5(this.int_0);
			}

			// Token: 0x04001919 RID: 6425
			private int int_0;

			// Token: 0x0400191A RID: 6426
			private Class2093 class2093_0;
		}

		// Token: 0x020008A3 RID: 2211
		public sealed class Class1191 : IEnumerable
		{
			// Token: 0x0600367D RID: 13949 RVA: 0x0001D049 File Offset: 0x0001B249
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x0600367E RID: 13950 RVA: 0x0011E5DC File Offset: 0x0011C7DC
			public Class2093.Class1192 method_1()
			{
				return new Class2093.Class1192(this.class2093_0);
			}

			// Token: 0x0600367F RID: 13951 RVA: 0x0011E5F8 File Offset: 0x0011C7F8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400191B RID: 6427
			private Class2093 class2093_0;
		}

		// Token: 0x020008A4 RID: 2212
		public sealed class Class1192 : IEnumerator
		{
			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06003681 RID: 13953 RVA: 0x0011E610 File Offset: 0x0011C810
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003682 RID: 13954 RVA: 0x0001D052 File Offset: 0x0001B252
			public Class1192(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x06003683 RID: 13955 RVA: 0x0001D068 File Offset: 0x0001B268
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003684 RID: 13956 RVA: 0x0001D071 File Offset: 0x0001B271
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_6();
			}

			// Token: 0x06003685 RID: 13957 RVA: 0x0011E628 File Offset: 0x0011C828
			public Class2020 method_0()
			{
				return this.class2093_0.method_7(this.int_0);
			}

			// Token: 0x0400191C RID: 6428
			private int int_0;

			// Token: 0x0400191D RID: 6429
			private Class2093 class2093_0;
		}

		// Token: 0x020008A5 RID: 2213
		public sealed class Class1193 : IEnumerable
		{
			// Token: 0x06003686 RID: 13958 RVA: 0x0001D094 File Offset: 0x0001B294
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x06003687 RID: 13959 RVA: 0x0011E648 File Offset: 0x0011C848
			public Class2093.Class1194 method_1()
			{
				return new Class2093.Class1194(this.class2093_0);
			}

			// Token: 0x06003688 RID: 13960 RVA: 0x0011E664 File Offset: 0x0011C864
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400191E RID: 6430
			private Class2093 class2093_0;
		}

		// Token: 0x020008A6 RID: 2214
		public sealed class Class1194 : IEnumerator
		{
			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x0600368A RID: 13962 RVA: 0x0011E67C File Offset: 0x0011C87C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600368B RID: 13963 RVA: 0x0001D09D File Offset: 0x0001B29D
			public Class1194(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x0600368C RID: 13964 RVA: 0x0001D0B3 File Offset: 0x0001B2B3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600368D RID: 13965 RVA: 0x0001D0BC File Offset: 0x0001B2BC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_8();
			}

			// Token: 0x0600368E RID: 13966 RVA: 0x0011E694 File Offset: 0x0011C894
			public Class2083 method_0()
			{
				return this.class2093_0.method_9(this.int_0);
			}

			// Token: 0x0400191F RID: 6431
			private int int_0;

			// Token: 0x04001920 RID: 6432
			private Class2093 class2093_0;
		}

		// Token: 0x020008A7 RID: 2215
		public sealed class Class1195 : IEnumerable
		{
			// Token: 0x0600368F RID: 13967 RVA: 0x0001D0DF File Offset: 0x0001B2DF
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x06003690 RID: 13968 RVA: 0x0011E6B4 File Offset: 0x0011C8B4
			public Class2093.Class1196 method_1()
			{
				return new Class2093.Class1196(this.class2093_0);
			}

			// Token: 0x06003691 RID: 13969 RVA: 0x0011E6D0 File Offset: 0x0011C8D0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001921 RID: 6433
			private Class2093 class2093_0;
		}

		// Token: 0x020008A8 RID: 2216
		public sealed class Class1196 : IEnumerator
		{
			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06003693 RID: 13971 RVA: 0x0011E6E8 File Offset: 0x0011C8E8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003694 RID: 13972 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
			public Class1196(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x06003695 RID: 13973 RVA: 0x0001D0FE File Offset: 0x0001B2FE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003696 RID: 13974 RVA: 0x0001D107 File Offset: 0x0001B307
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_10();
			}

			// Token: 0x06003697 RID: 13975 RVA: 0x0011E700 File Offset: 0x0011C900
			public Class2009 method_0()
			{
				return this.class2093_0.method_11(this.int_0);
			}

			// Token: 0x04001922 RID: 6434
			private int int_0;

			// Token: 0x04001923 RID: 6435
			private Class2093 class2093_0;
		}

		// Token: 0x020008A9 RID: 2217
		public sealed class Class1197 : IEnumerable
		{
			// Token: 0x06003698 RID: 13976 RVA: 0x0001D12A File Offset: 0x0001B32A
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x06003699 RID: 13977 RVA: 0x0011E720 File Offset: 0x0011C920
			public Class2093.Class1198 method_1()
			{
				return new Class2093.Class1198(this.class2093_0);
			}

			// Token: 0x0600369A RID: 13978 RVA: 0x0011E73C File Offset: 0x0011C93C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001924 RID: 6436
			private Class2093 class2093_0;
		}

		// Token: 0x020008AA RID: 2218
		public sealed class Class1198 : IEnumerator
		{
			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x0600369C RID: 13980 RVA: 0x0011E754 File Offset: 0x0011C954
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600369D RID: 13981 RVA: 0x0001D133 File Offset: 0x0001B333
			public Class1198(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x0600369E RID: 13982 RVA: 0x0001D149 File Offset: 0x0001B349
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600369F RID: 13983 RVA: 0x0001D152 File Offset: 0x0001B352
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_12();
			}

			// Token: 0x060036A0 RID: 13984 RVA: 0x0011E76C File Offset: 0x0011C96C
			public Class2076 method_0()
			{
				return this.class2093_0.method_13(this.int_0);
			}

			// Token: 0x04001925 RID: 6437
			private int int_0;

			// Token: 0x04001926 RID: 6438
			private Class2093 class2093_0;
		}

		// Token: 0x020008AB RID: 2219
		public sealed class Class1199 : IEnumerable
		{
			// Token: 0x060036A1 RID: 13985 RVA: 0x0001D175 File Offset: 0x0001B375
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x060036A2 RID: 13986 RVA: 0x0011E78C File Offset: 0x0011C98C
			public Class2093.Class1200 method_1()
			{
				return new Class2093.Class1200(this.class2093_0);
			}

			// Token: 0x060036A3 RID: 13987 RVA: 0x0011E7A8 File Offset: 0x0011C9A8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001927 RID: 6439
			private Class2093 class2093_0;
		}

		// Token: 0x020008AC RID: 2220
		public sealed class Class1200 : IEnumerator
		{
			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x060036A5 RID: 13989 RVA: 0x0011E7C0 File Offset: 0x0011C9C0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036A6 RID: 13990 RVA: 0x0001D17E File Offset: 0x0001B37E
			public Class1200(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x060036A7 RID: 13991 RVA: 0x0001D194 File Offset: 0x0001B394
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036A8 RID: 13992 RVA: 0x0001D19D File Offset: 0x0001B39D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_14();
			}

			// Token: 0x060036A9 RID: 13993 RVA: 0x0011E7D8 File Offset: 0x0011C9D8
			public Class2020 method_0()
			{
				return this.class2093_0.method_15(this.int_0);
			}

			// Token: 0x04001928 RID: 6440
			private int int_0;

			// Token: 0x04001929 RID: 6441
			private Class2093 class2093_0;
		}

		// Token: 0x020008AD RID: 2221
		public sealed class Class1201 : IEnumerable
		{
			// Token: 0x060036AA RID: 13994 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x060036AB RID: 13995 RVA: 0x0011E7F8 File Offset: 0x0011C9F8
			public Class2093.Class1202 method_1()
			{
				return new Class2093.Class1202(this.class2093_0);
			}

			// Token: 0x060036AC RID: 13996 RVA: 0x0011E814 File Offset: 0x0011CA14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400192A RID: 6442
			private Class2093 class2093_0;
		}

		// Token: 0x020008AE RID: 2222
		public sealed class Class1202 : IEnumerator
		{
			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x060036AE RID: 13998 RVA: 0x0011E82C File Offset: 0x0011CA2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036AF RID: 13999 RVA: 0x0001D1C9 File Offset: 0x0001B3C9
			public Class1202(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x060036B0 RID: 14000 RVA: 0x0001D1DF File Offset: 0x0001B3DF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036B1 RID: 14001 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_16();
			}

			// Token: 0x060036B2 RID: 14002 RVA: 0x0011E844 File Offset: 0x0011CA44
			public Class2020 method_0()
			{
				return this.class2093_0.method_17(this.int_0);
			}

			// Token: 0x0400192B RID: 6443
			private int int_0;

			// Token: 0x0400192C RID: 6444
			private Class2093 class2093_0;
		}

		// Token: 0x020008AF RID: 2223
		public sealed class Class1203 : IEnumerable
		{
			// Token: 0x060036B3 RID: 14003 RVA: 0x0001D20B File Offset: 0x0001B40B
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x060036B4 RID: 14004 RVA: 0x0011E864 File Offset: 0x0011CA64
			public Class2093.Class1204 method_1()
			{
				return new Class2093.Class1204(this.class2093_0);
			}

			// Token: 0x060036B5 RID: 14005 RVA: 0x0011E880 File Offset: 0x0011CA80
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400192D RID: 6445
			private Class2093 class2093_0;
		}

		// Token: 0x020008B0 RID: 2224
		public sealed class Class1204 : IEnumerator
		{
			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x060036B7 RID: 14007 RVA: 0x0011E898 File Offset: 0x0011CA98
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036B8 RID: 14008 RVA: 0x0001D214 File Offset: 0x0001B414
			public Class1204(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x060036B9 RID: 14009 RVA: 0x0001D22A File Offset: 0x0001B42A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036BA RID: 14010 RVA: 0x0001D233 File Offset: 0x0001B433
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_18();
			}

			// Token: 0x060036BB RID: 14011 RVA: 0x0011E8B0 File Offset: 0x0011CAB0
			public Class2074 method_0()
			{
				return this.class2093_0.method_19(this.int_0);
			}

			// Token: 0x0400192E RID: 6446
			private int int_0;

			// Token: 0x0400192F RID: 6447
			private Class2093 class2093_0;
		}

		// Token: 0x020008B1 RID: 2225
		public sealed class Class1205 : IEnumerable
		{
			// Token: 0x060036BC RID: 14012 RVA: 0x0001D256 File Offset: 0x0001B456
			public void method_0(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
			}

			// Token: 0x060036BD RID: 14013 RVA: 0x0011E8D0 File Offset: 0x0011CAD0
			public Class2093.Class1206 method_1()
			{
				return new Class2093.Class1206(this.class2093_0);
			}

			// Token: 0x060036BE RID: 14014 RVA: 0x0011E8EC File Offset: 0x0011CAEC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001930 RID: 6448
			private Class2093 class2093_0;
		}

		// Token: 0x020008B2 RID: 2226
		public sealed class Class1206 : IEnumerator
		{
			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x060036C0 RID: 14016 RVA: 0x0011E904 File Offset: 0x0011CB04
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060036C1 RID: 14017 RVA: 0x0001D25F File Offset: 0x0001B45F
			public Class1206(Class2093 class2093_1)
			{
				this.class2093_0 = class2093_1;
				this.int_0 = -1;
			}

			// Token: 0x060036C2 RID: 14018 RVA: 0x0001D275 File Offset: 0x0001B475
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060036C3 RID: 14019 RVA: 0x0001D27E File Offset: 0x0001B47E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2093_0.method_20();
			}

			// Token: 0x060036C4 RID: 14020 RVA: 0x0011E91C File Offset: 0x0011CB1C
			public Class2096 method_0()
			{
				return this.class2093_0.method_21(this.int_0);
			}

			// Token: 0x04001931 RID: 6449
			private int int_0;

			// Token: 0x04001932 RID: 6450
			private Class2093 class2093_0;
		}
	}
}
