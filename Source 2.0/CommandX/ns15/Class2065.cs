using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns15
{
	// Token: 0x020006A3 RID: 1699
	public sealed class Class2065 : Class2059
	{
		// Token: 0x06002B0D RID: 11021 RVA: 0x000FFE78 File Offset: 0x000FE078
		public Class2065()
		{
			this.method_18();
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000FFEEC File Offset: 0x000FE0EC
		public Class2065(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_18();
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000FFF60 File Offset: 0x000FE160
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerUrl");
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000FFF80 File Offset: 0x000FE180
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerUrl", int_0)));
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000FFFAC File Offset: 0x000FE1AC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DataSetName");
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000FFFCC File Offset: 0x000FE1CC
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DataSetName", int_0)));
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000FFFF8 File Offset: 0x000FE1F8
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LevelZeroTileSizeDegrees");
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00100018 File Offset: 0x000FE218
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "LevelZeroTileSizeDegrees", int_0)));
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00100044 File Offset: 0x000FE244
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "NumberLevels");
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00100064 File Offset: 0x000FE264
		public Class2010 method_9(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "NumberLevels", int_0)));
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000FDE5C File Offset: 0x000FC05C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "SamplesPerTile");
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000FDE7C File Offset: 0x000FC07C
		public Class2010 method_11(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "SamplesPerTile", int_0)));
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00100090 File Offset: 0x000FE290
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DataFormat");
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x001000B0 File Offset: 0x000FE2B0
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DataFormat", int_0)));
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x001000DC File Offset: 0x000FE2DC
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "FileExtension");
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x001000FC File Offset: 0x000FE2FC
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "FileExtension", int_0)));
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00100128 File Offset: 0x000FE328
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CompressonType");
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00100148 File Offset: 0x000FE348
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "CompressonType", int_0)));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00100174 File Offset: 0x000FE374
		private void method_18()
		{
			this.class881_0.method_0(this);
			this.class883_0.method_0(this);
			this.class885_0.method_0(this);
			this.class887_0.method_0(this);
			this.class889_0.method_0(this);
			this.class891_0.method_0(this);
			this.class893_0.method_0(this);
			this.class895_0.method_0(this);
		}

		// Token: 0x04001470 RID: 5232
		public Class2065.Class881 class881_0 = new Class2065.Class881();

		// Token: 0x04001471 RID: 5233
		public Class2065.Class883 class883_0 = new Class2065.Class883();

		// Token: 0x04001472 RID: 5234
		public Class2065.Class885 class885_0 = new Class2065.Class885();

		// Token: 0x04001473 RID: 5235
		public Class2065.Class887 class887_0 = new Class2065.Class887();

		// Token: 0x04001474 RID: 5236
		public Class2065.Class889 class889_0 = new Class2065.Class889();

		// Token: 0x04001475 RID: 5237
		public Class2065.Class891 class891_0 = new Class2065.Class891();

		// Token: 0x04001476 RID: 5238
		public Class2065.Class893 class893_0 = new Class2065.Class893();

		// Token: 0x04001477 RID: 5239
		public Class2065.Class895 class895_0 = new Class2065.Class895();

		// Token: 0x020006A4 RID: 1700
		public sealed class Class881 : IEnumerable
		{
			// Token: 0x06002B20 RID: 11040 RVA: 0x0001778C File Offset: 0x0001598C
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x001001E4 File Offset: 0x000FE3E4
			public Class2065.Class882 method_1()
			{
				return new Class2065.Class882(this.class2065_0);
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x00100200 File Offset: 0x000FE400
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001478 RID: 5240
			private Class2065 class2065_0;
		}

		// Token: 0x020006A5 RID: 1701
		public sealed class Class882 : IEnumerator
		{
			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06002B24 RID: 11044 RVA: 0x00100218 File Offset: 0x000FE418
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B25 RID: 11045 RVA: 0x00017795 File Offset: 0x00015995
			public Class882(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B26 RID: 11046 RVA: 0x000177AB File Offset: 0x000159AB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B27 RID: 11047 RVA: 0x000177B4 File Offset: 0x000159B4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_2();
			}

			// Token: 0x06002B28 RID: 11048 RVA: 0x00100230 File Offset: 0x000FE430
			public Class2050 method_0()
			{
				return this.class2065_0.method_3(this.int_0);
			}

			// Token: 0x04001479 RID: 5241
			private int int_0;

			// Token: 0x0400147A RID: 5242
			private Class2065 class2065_0;
		}

		// Token: 0x020006A6 RID: 1702
		public sealed class Class883 : IEnumerable
		{
			// Token: 0x06002B29 RID: 11049 RVA: 0x000177D7 File Offset: 0x000159D7
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B2A RID: 11050 RVA: 0x00100250 File Offset: 0x000FE450
			public Class2065.Class884 method_1()
			{
				return new Class2065.Class884(this.class2065_0);
			}

			// Token: 0x06002B2B RID: 11051 RVA: 0x0010026C File Offset: 0x000FE46C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400147B RID: 5243
			private Class2065 class2065_0;
		}

		// Token: 0x020006A7 RID: 1703
		public sealed class Class884 : IEnumerator
		{
			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06002B2D RID: 11053 RVA: 0x00100284 File Offset: 0x000FE484
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B2E RID: 11054 RVA: 0x000177E0 File Offset: 0x000159E0
			public Class884(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B2F RID: 11055 RVA: 0x000177F6 File Offset: 0x000159F6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B30 RID: 11056 RVA: 0x000177FF File Offset: 0x000159FF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_4();
			}

			// Token: 0x06002B31 RID: 11057 RVA: 0x0010029C File Offset: 0x000FE49C
			public Class2050 method_0()
			{
				return this.class2065_0.method_5(this.int_0);
			}

			// Token: 0x0400147C RID: 5244
			private int int_0;

			// Token: 0x0400147D RID: 5245
			private Class2065 class2065_0;
		}

		// Token: 0x020006A8 RID: 1704
		public sealed class Class885 : IEnumerable
		{
			// Token: 0x06002B32 RID: 11058 RVA: 0x00017822 File Offset: 0x00015A22
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B33 RID: 11059 RVA: 0x001002BC File Offset: 0x000FE4BC
			public Class2065.Class886 method_1()
			{
				return new Class2065.Class886(this.class2065_0);
			}

			// Token: 0x06002B34 RID: 11060 RVA: 0x001002D8 File Offset: 0x000FE4D8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400147E RID: 5246
			private Class2065 class2065_0;
		}

		// Token: 0x020006A9 RID: 1705
		public sealed class Class886 : IEnumerator
		{
			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06002B36 RID: 11062 RVA: 0x001002F0 File Offset: 0x000FE4F0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B37 RID: 11063 RVA: 0x0001782B File Offset: 0x00015A2B
			public Class886(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B38 RID: 11064 RVA: 0x00017841 File Offset: 0x00015A41
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B39 RID: 11065 RVA: 0x0001784A File Offset: 0x00015A4A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_6();
			}

			// Token: 0x06002B3A RID: 11066 RVA: 0x00100308 File Offset: 0x000FE508
			public Class2020 method_0()
			{
				return this.class2065_0.method_7(this.int_0);
			}

			// Token: 0x0400147F RID: 5247
			private int int_0;

			// Token: 0x04001480 RID: 5248
			private Class2065 class2065_0;
		}

		// Token: 0x020006AA RID: 1706
		public sealed class Class887 : IEnumerable
		{
			// Token: 0x06002B3B RID: 11067 RVA: 0x0001786D File Offset: 0x00015A6D
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B3C RID: 11068 RVA: 0x00100328 File Offset: 0x000FE528
			public Class2065.Class888 method_1()
			{
				return new Class2065.Class888(this.class2065_0);
			}

			// Token: 0x06002B3D RID: 11069 RVA: 0x00100344 File Offset: 0x000FE544
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001481 RID: 5249
			private Class2065 class2065_0;
		}

		// Token: 0x020006AB RID: 1707
		public sealed class Class888 : IEnumerator
		{
			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0010035C File Offset: 0x000FE55C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B40 RID: 11072 RVA: 0x00017876 File Offset: 0x00015A76
			public Class888(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B41 RID: 11073 RVA: 0x0001788C File Offset: 0x00015A8C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B42 RID: 11074 RVA: 0x00017895 File Offset: 0x00015A95
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_8();
			}

			// Token: 0x06002B43 RID: 11075 RVA: 0x00100374 File Offset: 0x000FE574
			public Class2010 method_0()
			{
				return this.class2065_0.method_9(this.int_0);
			}

			// Token: 0x04001482 RID: 5250
			private int int_0;

			// Token: 0x04001483 RID: 5251
			private Class2065 class2065_0;
		}

		// Token: 0x020006AC RID: 1708
		public sealed class Class889 : IEnumerable
		{
			// Token: 0x06002B44 RID: 11076 RVA: 0x000178B8 File Offset: 0x00015AB8
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B45 RID: 11077 RVA: 0x00100394 File Offset: 0x000FE594
			public Class2065.Class890 method_1()
			{
				return new Class2065.Class890(this.class2065_0);
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x001003B0 File Offset: 0x000FE5B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001484 RID: 5252
			private Class2065 class2065_0;
		}

		// Token: 0x020006AD RID: 1709
		public sealed class Class890 : IEnumerator
		{
			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06002B48 RID: 11080 RVA: 0x001003C8 File Offset: 0x000FE5C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B49 RID: 11081 RVA: 0x000178C1 File Offset: 0x00015AC1
			public Class890(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B4A RID: 11082 RVA: 0x000178D7 File Offset: 0x00015AD7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B4B RID: 11083 RVA: 0x000178E0 File Offset: 0x00015AE0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_10();
			}

			// Token: 0x06002B4C RID: 11084 RVA: 0x001003E0 File Offset: 0x000FE5E0
			public Class2010 method_0()
			{
				return this.class2065_0.method_11(this.int_0);
			}

			// Token: 0x04001485 RID: 5253
			private int int_0;

			// Token: 0x04001486 RID: 5254
			private Class2065 class2065_0;
		}

		// Token: 0x020006AE RID: 1710
		public sealed class Class891 : IEnumerable
		{
			// Token: 0x06002B4D RID: 11085 RVA: 0x00017903 File Offset: 0x00015B03
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B4E RID: 11086 RVA: 0x00100400 File Offset: 0x000FE600
			public Class2065.Class892 method_1()
			{
				return new Class2065.Class892(this.class2065_0);
			}

			// Token: 0x06002B4F RID: 11087 RVA: 0x0010041C File Offset: 0x000FE61C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001487 RID: 5255
			private Class2065 class2065_0;
		}

		// Token: 0x020006AF RID: 1711
		public sealed class Class892 : IEnumerator
		{
			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00100434 File Offset: 0x000FE634
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B52 RID: 11090 RVA: 0x0001790C File Offset: 0x00015B0C
			public Class892(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B53 RID: 11091 RVA: 0x00017922 File Offset: 0x00015B22
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B54 RID: 11092 RVA: 0x0001792B File Offset: 0x00015B2B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_12();
			}

			// Token: 0x06002B55 RID: 11093 RVA: 0x0010044C File Offset: 0x000FE64C
			public Class2050 method_0()
			{
				return this.class2065_0.method_13(this.int_0);
			}

			// Token: 0x04001488 RID: 5256
			private int int_0;

			// Token: 0x04001489 RID: 5257
			private Class2065 class2065_0;
		}

		// Token: 0x020006B0 RID: 1712
		public sealed class Class893 : IEnumerable
		{
			// Token: 0x06002B56 RID: 11094 RVA: 0x0001794E File Offset: 0x00015B4E
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B57 RID: 11095 RVA: 0x0010046C File Offset: 0x000FE66C
			public Class2065.Class894 method_1()
			{
				return new Class2065.Class894(this.class2065_0);
			}

			// Token: 0x06002B58 RID: 11096 RVA: 0x00100488 File Offset: 0x000FE688
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400148A RID: 5258
			private Class2065 class2065_0;
		}

		// Token: 0x020006B1 RID: 1713
		public sealed class Class894 : IEnumerator
		{
			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06002B5A RID: 11098 RVA: 0x001004A0 File Offset: 0x000FE6A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B5B RID: 11099 RVA: 0x00017957 File Offset: 0x00015B57
			public Class894(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B5C RID: 11100 RVA: 0x0001796D File Offset: 0x00015B6D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B5D RID: 11101 RVA: 0x00017976 File Offset: 0x00015B76
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_14();
			}

			// Token: 0x06002B5E RID: 11102 RVA: 0x001004B8 File Offset: 0x000FE6B8
			public Class2050 method_0()
			{
				return this.class2065_0.method_15(this.int_0);
			}

			// Token: 0x0400148B RID: 5259
			private int int_0;

			// Token: 0x0400148C RID: 5260
			private Class2065 class2065_0;
		}

		// Token: 0x020006B2 RID: 1714
		public sealed class Class895 : IEnumerable
		{
			// Token: 0x06002B5F RID: 11103 RVA: 0x00017999 File Offset: 0x00015B99
			public void method_0(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
			}

			// Token: 0x06002B60 RID: 11104 RVA: 0x001004D8 File Offset: 0x000FE6D8
			public Class2065.Class896 method_1()
			{
				return new Class2065.Class896(this.class2065_0);
			}

			// Token: 0x06002B61 RID: 11105 RVA: 0x001004F4 File Offset: 0x000FE6F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400148D RID: 5261
			private Class2065 class2065_0;
		}

		// Token: 0x020006B3 RID: 1715
		public sealed class Class896 : IEnumerator
		{
			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06002B63 RID: 11107 RVA: 0x0010050C File Offset: 0x000FE70C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002B64 RID: 11108 RVA: 0x000179A2 File Offset: 0x00015BA2
			public Class896(Class2065 class2065_1)
			{
				this.class2065_0 = class2065_1;
				this.int_0 = -1;
			}

			// Token: 0x06002B65 RID: 11109 RVA: 0x000179B8 File Offset: 0x00015BB8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x000179C1 File Offset: 0x00015BC1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2065_0.method_16();
			}

			// Token: 0x06002B67 RID: 11111 RVA: 0x00100524 File Offset: 0x000FE724
			public Class2050 method_0()
			{
				return this.class2065_0.method_17(this.int_0);
			}

			// Token: 0x0400148E RID: 5262
			private int int_0;

			// Token: 0x0400148F RID: 5263
			private Class2065 class2065_0;
		}
	}
}
