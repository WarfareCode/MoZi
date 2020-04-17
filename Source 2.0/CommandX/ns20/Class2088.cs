using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x02000842 RID: 2114
	public sealed class Class2088 : Class2059
	{
		// Token: 0x0600341D RID: 13341 RVA: 0x0011AE08 File Offset: 0x00119008
		public Class2088()
		{
			this.method_24();
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0011AE9C File Offset: 0x0011909C
		public Class2088(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0011AF30 File Offset: 0x00119130
		public Class2027 method_7(int int_0)
		{
			return new Class2027(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x001065DC File Offset: 0x001047DC
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Latitude");
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x001065FC File Offset: 0x001047FC
		public Class2081 method_9(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "Latitude", int_0));
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00106624 File Offset: 0x00104824
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Longitude");
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00106644 File Offset: 0x00104844
		public Class2086 method_11(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "Longitude", int_0));
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x0011A31C File Offset: 0x0011851C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Orientation");
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x0011A33C File Offset: 0x0011853C
		public Class2090 method_13(int int_0)
		{
			return new Class2090(base.method_1(Class2059.Enum155.const_1, "", "Orientation", int_0));
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x0011A364 File Offset: 0x00118564
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ScaleFactor");
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x0011AF5C File Offset: 0x0011915C
		public Class2042 method_15(int int_0)
		{
			return new Class2042(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ScaleFactor", int_0)));
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x0011A3B0 File Offset: 0x001185B0
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinViewRange");
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x0011AF88 File Offset: 0x00119188
		public Class2040 method_17(int int_0)
		{
			return new Class2040(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinViewRange", int_0)));
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x0011A3FC File Offset: 0x001185FC
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaxViewRange");
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x0011AFB4 File Offset: 0x001191B4
		public Class2034 method_19(int int_0)
		{
			return new Class2034(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaxViewRange", int_0)));
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x0011A448 File Offset: 0x00118648
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MeshFilePath");
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x0011AFE0 File Offset: 0x001191E0
		public Class2052 method_21(int int_0)
		{
			return new Class2052(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MeshFilePath", int_0)));
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_23(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x0011B00C File Offset: 0x0011920C
		private void method_24()
		{
			this.class1117_0.method_0(this);
			this.class1119_0.method_0(this);
			this.class1121_0.method_0(this);
			this.class1123_0.method_0(this);
			this.class1125_0.method_0(this);
			this.class1127_0.method_0(this);
			this.class1129_0.method_0(this);
			this.class1131_0.method_0(this);
			this.class1133_0.method_0(this);
			this.class1135_0.method_0(this);
			this.class1137_0.method_0(this);
		}

		// Token: 0x04001830 RID: 6192
		public Class2088.Class1117 class1117_0 = new Class2088.Class1117();

		// Token: 0x04001831 RID: 6193
		public Class2088.Class1119 class1119_0 = new Class2088.Class1119();

		// Token: 0x04001832 RID: 6194
		public Class2088.Class1121 class1121_0 = new Class2088.Class1121();

		// Token: 0x04001833 RID: 6195
		public Class2088.Class1123 class1123_0 = new Class2088.Class1123();

		// Token: 0x04001834 RID: 6196
		public Class2088.Class1125 class1125_0 = new Class2088.Class1125();

		// Token: 0x04001835 RID: 6197
		public Class2088.Class1127 class1127_0 = new Class2088.Class1127();

		// Token: 0x04001836 RID: 6198
		public Class2088.Class1129 class1129_0 = new Class2088.Class1129();

		// Token: 0x04001837 RID: 6199
		public Class2088.Class1131 class1131_0 = new Class2088.Class1131();

		// Token: 0x04001838 RID: 6200
		public Class2088.Class1133 class1133_0 = new Class2088.Class1133();

		// Token: 0x04001839 RID: 6201
		public Class2088.Class1135 class1135_0 = new Class2088.Class1135();

		// Token: 0x0400183A RID: 6202
		public Class2088.Class1137 class1137_0 = new Class2088.Class1137();

		// Token: 0x02000843 RID: 2115
		public sealed class Class1117 : IEnumerable
		{
			// Token: 0x06003436 RID: 13366 RVA: 0x0001BDC0 File Offset: 0x00019FC0
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003437 RID: 13367 RVA: 0x0011B0A0 File Offset: 0x001192A0
			public Class2088.Class1118 method_1()
			{
				return new Class2088.Class1118(this.class2088_0);
			}

			// Token: 0x06003438 RID: 13368 RVA: 0x0011B0BC File Offset: 0x001192BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400183B RID: 6203
			private Class2088 class2088_0;
		}

		// Token: 0x02000844 RID: 2116
		public sealed class Class1118 : IEnumerator
		{
			// Token: 0x1700039B RID: 923
			// (get) Token: 0x0600343A RID: 13370 RVA: 0x0011B0D4 File Offset: 0x001192D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600343B RID: 13371 RVA: 0x0001BDC9 File Offset: 0x00019FC9
			public Class1118(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x0600343C RID: 13372 RVA: 0x0001BDDF File Offset: 0x00019FDF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x0001BDE8 File Offset: 0x00019FE8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_2();
			}

			// Token: 0x0600343E RID: 13374 RVA: 0x0011B0EC File Offset: 0x001192EC
			public Class2009 method_0()
			{
				return this.class2088_0.method_3(this.int_0);
			}

			// Token: 0x0400183C RID: 6204
			private int int_0;

			// Token: 0x0400183D RID: 6205
			private Class2088 class2088_0;
		}

		// Token: 0x02000845 RID: 2117
		public sealed class Class1119 : IEnumerable
		{
			// Token: 0x0600343F RID: 13375 RVA: 0x0001BE0B File Offset: 0x0001A00B
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003440 RID: 13376 RVA: 0x0011B10C File Offset: 0x0011930C
			public Class2088.Class1120 method_1()
			{
				return new Class2088.Class1120(this.class2088_0);
			}

			// Token: 0x06003441 RID: 13377 RVA: 0x0011B128 File Offset: 0x00119328
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400183E RID: 6206
			private Class2088 class2088_0;
		}

		// Token: 0x02000846 RID: 2118
		public sealed class Class1120 : IEnumerator
		{
			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06003443 RID: 13379 RVA: 0x0011B140 File Offset: 0x00119340
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003444 RID: 13380 RVA: 0x0001BE14 File Offset: 0x0001A014
			public Class1120(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003445 RID: 13381 RVA: 0x0001BE2A File Offset: 0x0001A02A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003446 RID: 13382 RVA: 0x0001BE33 File Offset: 0x0001A033
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_4();
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x0011B158 File Offset: 0x00119358
			public Class2050 method_0()
			{
				return this.class2088_0.method_5(this.int_0);
			}

			// Token: 0x0400183F RID: 6207
			private int int_0;

			// Token: 0x04001840 RID: 6208
			private Class2088 class2088_0;
		}

		// Token: 0x02000847 RID: 2119
		public sealed class Class1121 : IEnumerable
		{
			// Token: 0x06003448 RID: 13384 RVA: 0x0001BE56 File Offset: 0x0001A056
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003449 RID: 13385 RVA: 0x0011B178 File Offset: 0x00119378
			public Class2088.Class1122 method_1()
			{
				return new Class2088.Class1122(this.class2088_0);
			}

			// Token: 0x0600344A RID: 13386 RVA: 0x0011B194 File Offset: 0x00119394
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001841 RID: 6209
			private Class2088 class2088_0;
		}

		// Token: 0x02000848 RID: 2120
		public sealed class Class1122 : IEnumerator
		{
			// Token: 0x1700039D RID: 925
			// (get) Token: 0x0600344C RID: 13388 RVA: 0x0011B1AC File Offset: 0x001193AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600344D RID: 13389 RVA: 0x0001BE5F File Offset: 0x0001A05F
			public Class1122(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x0600344E RID: 13390 RVA: 0x0001BE75 File Offset: 0x0001A075
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600344F RID: 13391 RVA: 0x0001BE7E File Offset: 0x0001A07E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_6();
			}

			// Token: 0x06003450 RID: 13392 RVA: 0x0011B1C4 File Offset: 0x001193C4
			public Class2027 method_0()
			{
				return this.class2088_0.method_7(this.int_0);
			}

			// Token: 0x04001842 RID: 6210
			private int int_0;

			// Token: 0x04001843 RID: 6211
			private Class2088 class2088_0;
		}

		// Token: 0x02000849 RID: 2121
		public sealed class Class1123 : IEnumerable
		{
			// Token: 0x06003451 RID: 13393 RVA: 0x0001BEA1 File Offset: 0x0001A0A1
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003452 RID: 13394 RVA: 0x0011B1E4 File Offset: 0x001193E4
			public Class2088.Class1124 method_1()
			{
				return new Class2088.Class1124(this.class2088_0);
			}

			// Token: 0x06003453 RID: 13395 RVA: 0x0011B200 File Offset: 0x00119400
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001844 RID: 6212
			private Class2088 class2088_0;
		}

		// Token: 0x0200084A RID: 2122
		public sealed class Class1124 : IEnumerator
		{
			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06003455 RID: 13397 RVA: 0x0011B218 File Offset: 0x00119418
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003456 RID: 13398 RVA: 0x0001BEAA File Offset: 0x0001A0AA
			public Class1124(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003457 RID: 13399 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003458 RID: 13400 RVA: 0x0001BEC9 File Offset: 0x0001A0C9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_8();
			}

			// Token: 0x06003459 RID: 13401 RVA: 0x0011B230 File Offset: 0x00119430
			public Class2081 method_0()
			{
				return this.class2088_0.method_9(this.int_0);
			}

			// Token: 0x04001845 RID: 6213
			private int int_0;

			// Token: 0x04001846 RID: 6214
			private Class2088 class2088_0;
		}

		// Token: 0x0200084B RID: 2123
		public sealed class Class1125 : IEnumerable
		{
			// Token: 0x0600345A RID: 13402 RVA: 0x0001BEEC File Offset: 0x0001A0EC
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x0600345B RID: 13403 RVA: 0x0011B250 File Offset: 0x00119450
			public Class2088.Class1126 method_1()
			{
				return new Class2088.Class1126(this.class2088_0);
			}

			// Token: 0x0600345C RID: 13404 RVA: 0x0011B26C File Offset: 0x0011946C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001847 RID: 6215
			private Class2088 class2088_0;
		}

		// Token: 0x0200084C RID: 2124
		public sealed class Class1126 : IEnumerator
		{
			// Token: 0x1700039F RID: 927
			// (get) Token: 0x0600345E RID: 13406 RVA: 0x0011B284 File Offset: 0x00119484
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600345F RID: 13407 RVA: 0x0001BEF5 File Offset: 0x0001A0F5
			public Class1126(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003460 RID: 13408 RVA: 0x0001BF0B File Offset: 0x0001A10B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003461 RID: 13409 RVA: 0x0001BF14 File Offset: 0x0001A114
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_10();
			}

			// Token: 0x06003462 RID: 13410 RVA: 0x0011B29C File Offset: 0x0011949C
			public Class2086 method_0()
			{
				return this.class2088_0.method_11(this.int_0);
			}

			// Token: 0x04001848 RID: 6216
			private int int_0;

			// Token: 0x04001849 RID: 6217
			private Class2088 class2088_0;
		}

		// Token: 0x0200084D RID: 2125
		public sealed class Class1127 : IEnumerable
		{
			// Token: 0x06003463 RID: 13411 RVA: 0x0001BF37 File Offset: 0x0001A137
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003464 RID: 13412 RVA: 0x0011B2BC File Offset: 0x001194BC
			public Class2088.Class1128 method_1()
			{
				return new Class2088.Class1128(this.class2088_0);
			}

			// Token: 0x06003465 RID: 13413 RVA: 0x0011B2D8 File Offset: 0x001194D8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400184A RID: 6218
			private Class2088 class2088_0;
		}

		// Token: 0x0200084E RID: 2126
		public sealed class Class1128 : IEnumerator
		{
			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06003467 RID: 13415 RVA: 0x0011B2F0 File Offset: 0x001194F0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003468 RID: 13416 RVA: 0x0001BF40 File Offset: 0x0001A140
			public Class1128(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003469 RID: 13417 RVA: 0x0001BF56 File Offset: 0x0001A156
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600346A RID: 13418 RVA: 0x0001BF5F File Offset: 0x0001A15F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_12();
			}

			// Token: 0x0600346B RID: 13419 RVA: 0x0011B308 File Offset: 0x00119508
			public Class2090 method_0()
			{
				return this.class2088_0.method_13(this.int_0);
			}

			// Token: 0x0400184B RID: 6219
			private int int_0;

			// Token: 0x0400184C RID: 6220
			private Class2088 class2088_0;
		}

		// Token: 0x0200084F RID: 2127
		public sealed class Class1129 : IEnumerable
		{
			// Token: 0x0600346C RID: 13420 RVA: 0x0001BF82 File Offset: 0x0001A182
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x0600346D RID: 13421 RVA: 0x0011B328 File Offset: 0x00119528
			public Class2088.Class1130 method_1()
			{
				return new Class2088.Class1130(this.class2088_0);
			}

			// Token: 0x0600346E RID: 13422 RVA: 0x0011B344 File Offset: 0x00119544
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400184D RID: 6221
			private Class2088 class2088_0;
		}

		// Token: 0x02000850 RID: 2128
		public sealed class Class1130 : IEnumerator
		{
			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06003470 RID: 13424 RVA: 0x0011B35C File Offset: 0x0011955C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003471 RID: 13425 RVA: 0x0001BF8B File Offset: 0x0001A18B
			public Class1130(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003472 RID: 13426 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003473 RID: 13427 RVA: 0x0001BFAA File Offset: 0x0001A1AA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_14();
			}

			// Token: 0x06003474 RID: 13428 RVA: 0x0011B374 File Offset: 0x00119574
			public Class2042 method_0()
			{
				return this.class2088_0.method_15(this.int_0);
			}

			// Token: 0x0400184E RID: 6222
			private int int_0;

			// Token: 0x0400184F RID: 6223
			private Class2088 class2088_0;
		}

		// Token: 0x02000851 RID: 2129
		public sealed class Class1131 : IEnumerable
		{
			// Token: 0x06003475 RID: 13429 RVA: 0x0001BFCD File Offset: 0x0001A1CD
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003476 RID: 13430 RVA: 0x0011B394 File Offset: 0x00119594
			public Class2088.Class1132 method_1()
			{
				return new Class2088.Class1132(this.class2088_0);
			}

			// Token: 0x06003477 RID: 13431 RVA: 0x0011B3B0 File Offset: 0x001195B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001850 RID: 6224
			private Class2088 class2088_0;
		}

		// Token: 0x02000852 RID: 2130
		public sealed class Class1132 : IEnumerator
		{
			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06003479 RID: 13433 RVA: 0x0011B3C8 File Offset: 0x001195C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600347A RID: 13434 RVA: 0x0001BFD6 File Offset: 0x0001A1D6
			public Class1132(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x0600347B RID: 13435 RVA: 0x0001BFEC File Offset: 0x0001A1EC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600347C RID: 13436 RVA: 0x0001BFF5 File Offset: 0x0001A1F5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_16();
			}

			// Token: 0x0600347D RID: 13437 RVA: 0x0011B3E0 File Offset: 0x001195E0
			public Class2040 method_0()
			{
				return this.class2088_0.method_17(this.int_0);
			}

			// Token: 0x04001851 RID: 6225
			private int int_0;

			// Token: 0x04001852 RID: 6226
			private Class2088 class2088_0;
		}

		// Token: 0x02000853 RID: 2131
		public sealed class Class1133 : IEnumerable
		{
			// Token: 0x0600347E RID: 13438 RVA: 0x0001C018 File Offset: 0x0001A218
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x0600347F RID: 13439 RVA: 0x0011B400 File Offset: 0x00119600
			public Class2088.Class1134 method_1()
			{
				return new Class2088.Class1134(this.class2088_0);
			}

			// Token: 0x06003480 RID: 13440 RVA: 0x0011B41C File Offset: 0x0011961C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001853 RID: 6227
			private Class2088 class2088_0;
		}

		// Token: 0x02000854 RID: 2132
		public sealed class Class1134 : IEnumerator
		{
			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06003482 RID: 13442 RVA: 0x0011B434 File Offset: 0x00119634
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003483 RID: 13443 RVA: 0x0001C021 File Offset: 0x0001A221
			public Class1134(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003484 RID: 13444 RVA: 0x0001C037 File Offset: 0x0001A237
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003485 RID: 13445 RVA: 0x0001C040 File Offset: 0x0001A240
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_18();
			}

			// Token: 0x06003486 RID: 13446 RVA: 0x0011B44C File Offset: 0x0011964C
			public Class2034 method_0()
			{
				return this.class2088_0.method_19(this.int_0);
			}

			// Token: 0x04001854 RID: 6228
			private int int_0;

			// Token: 0x04001855 RID: 6229
			private Class2088 class2088_0;
		}

		// Token: 0x02000855 RID: 2133
		public sealed class Class1135 : IEnumerable
		{
			// Token: 0x06003487 RID: 13447 RVA: 0x0001C063 File Offset: 0x0001A263
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003488 RID: 13448 RVA: 0x0011B46C File Offset: 0x0011966C
			public Class2088.Class1136 method_1()
			{
				return new Class2088.Class1136(this.class2088_0);
			}

			// Token: 0x06003489 RID: 13449 RVA: 0x0011B488 File Offset: 0x00119688
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001856 RID: 6230
			private Class2088 class2088_0;
		}

		// Token: 0x02000856 RID: 2134
		public sealed class Class1136 : IEnumerator
		{
			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x0600348B RID: 13451 RVA: 0x0011B4A0 File Offset: 0x001196A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600348C RID: 13452 RVA: 0x0001C06C File Offset: 0x0001A26C
			public Class1136(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x0600348D RID: 13453 RVA: 0x0001C082 File Offset: 0x0001A282
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600348E RID: 13454 RVA: 0x0001C08B File Offset: 0x0001A28B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_20();
			}

			// Token: 0x0600348F RID: 13455 RVA: 0x0011B4B8 File Offset: 0x001196B8
			public Class2052 method_0()
			{
				return this.class2088_0.method_21(this.int_0);
			}

			// Token: 0x04001857 RID: 6231
			private int int_0;

			// Token: 0x04001858 RID: 6232
			private Class2088 class2088_0;
		}

		// Token: 0x02000857 RID: 2135
		public sealed class Class1137 : IEnumerable
		{
			// Token: 0x06003490 RID: 13456 RVA: 0x0001C0AE File Offset: 0x0001A2AE
			public void method_0(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
			}

			// Token: 0x06003491 RID: 13457 RVA: 0x0011B4D8 File Offset: 0x001196D8
			public Class2088.Class1138 method_1()
			{
				return new Class2088.Class1138(this.class2088_0);
			}

			// Token: 0x06003492 RID: 13458 RVA: 0x0011B4F4 File Offset: 0x001196F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001859 RID: 6233
			private Class2088 class2088_0;
		}

		// Token: 0x02000858 RID: 2136
		public sealed class Class1138 : IEnumerator
		{
			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06003494 RID: 13460 RVA: 0x0011B50C File Offset: 0x0011970C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003495 RID: 13461 RVA: 0x0001C0B7 File Offset: 0x0001A2B7
			public Class1138(Class2088 class2088_1)
			{
				this.class2088_0 = class2088_1;
				this.int_0 = -1;
			}

			// Token: 0x06003496 RID: 13462 RVA: 0x0001C0CD File Offset: 0x0001A2CD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003497 RID: 13463 RVA: 0x0001C0D6 File Offset: 0x0001A2D6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2088_0.method_22();
			}

			// Token: 0x06003498 RID: 13464 RVA: 0x0011B524 File Offset: 0x00119724
			public Class2074 method_0()
			{
				return this.class2088_0.method_23(this.int_0);
			}

			// Token: 0x0400185A RID: 6234
			private int int_0;

			// Token: 0x0400185B RID: 6235
			private Class2088 class2088_0;
		}
	}
}
