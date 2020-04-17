using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x02000185 RID: 389
	public sealed class Class2132 : Class2059
	{
		// Token: 0x060008A8 RID: 2216 RVA: 0x0006BC78 File Offset: 0x00069E78
		public Class2132()
		{
			this.method_24();
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0006BD0C File Offset: 0x00069F0C
		public Class2132(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0006812C File Offset: 0x0006632C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name");
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0006BDA0 File Offset: 0x00069FA0
		public Class2055 method_3(int int_0)
		{
			return new Class2055(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Name", int_0)));
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0005B2A4 File Offset: 0x000594A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title");
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0005B2C4 File Offset: 0x000594C4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title", int_0)));
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00068178 File Offset: 0x00066378
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract");
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00068198 File Offset: 0x00066398
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Abstract", int_0)));
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000681C4 File Offset: 0x000663C4
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "KeywordList");
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000681E4 File Offset: 0x000663E4
		public Class2122 method_9(int int_0)
		{
			return new Class2122(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "KeywordList", int_0));
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_11(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0006BDCC File Offset: 0x00069FCC
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactInformation");
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0006BDEC File Offset: 0x00069FEC
		public Class2111 method_13(int int_0)
		{
			return new Class2111(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactInformation", int_0));
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0006BE14 File Offset: 0x0006A014
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Fees");
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0006BE34 File Offset: 0x0006A034
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Fees", int_0)));
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0006BE60 File Offset: 0x0006A060
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AccessConstraints");
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0006BE80 File Offset: 0x0006A080
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "AccessConstraints", int_0)));
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0006BEAC File Offset: 0x0006A0AC
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LayerLimit");
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0006BECC File Offset: 0x0006A0CC
		public Class2018 method_19(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LayerLimit", int_0)));
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0006BEF8 File Offset: 0x0006A0F8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxWidth");
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0006BF18 File Offset: 0x0006A118
		public Class2018 method_21(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxWidth", int_0)));
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0006BF44 File Offset: 0x0006A144
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxHeight");
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0006BF64 File Offset: 0x0006A164
		public Class2018 method_23(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "MaxHeight", int_0)));
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0006BF90 File Offset: 0x0006A190
		private void method_24()
		{
			this.class1609_0.method_0(this);
			this.class1611_0.method_0(this);
			this.class1613_0.method_0(this);
			this.class1615_0.method_0(this);
			this.class1617_0.method_0(this);
			this.class1619_0.method_0(this);
			this.class1621_0.method_0(this);
			this.class1623_0.method_0(this);
			this.class1625_0.method_0(this);
			this.class1627_0.method_0(this);
			this.class1629_0.method_0(this);
		}

		// Token: 0x040003AF RID: 943
		public Class2132.Class1609 class1609_0 = new Class2132.Class1609();

		// Token: 0x040003B0 RID: 944
		public Class2132.Class1611 class1611_0 = new Class2132.Class1611();

		// Token: 0x040003B1 RID: 945
		public Class2132.Class1613 class1613_0 = new Class2132.Class1613();

		// Token: 0x040003B2 RID: 946
		public Class2132.Class1615 class1615_0 = new Class2132.Class1615();

		// Token: 0x040003B3 RID: 947
		public Class2132.Class1617 class1617_0 = new Class2132.Class1617();

		// Token: 0x040003B4 RID: 948
		public Class2132.Class1619 class1619_0 = new Class2132.Class1619();

		// Token: 0x040003B5 RID: 949
		public Class2132.Class1621 class1621_0 = new Class2132.Class1621();

		// Token: 0x040003B6 RID: 950
		public Class2132.Class1623 class1623_0 = new Class2132.Class1623();

		// Token: 0x040003B7 RID: 951
		public Class2132.Class1625 class1625_0 = new Class2132.Class1625();

		// Token: 0x040003B8 RID: 952
		public Class2132.Class1627 class1627_0 = new Class2132.Class1627();

		// Token: 0x040003B9 RID: 953
		public Class2132.Class1629 class1629_0 = new Class2132.Class1629();

		// Token: 0x02000186 RID: 390
		public sealed class Class1609 : IEnumerable
		{
			// Token: 0x060008C1 RID: 2241 RVA: 0x00008B01 File Offset: 0x00006D01
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008C2 RID: 2242 RVA: 0x0006C024 File Offset: 0x0006A224
			public Class2132.Class1610 method_1()
			{
				return new Class2132.Class1610(this.class2132_0);
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x0006C040 File Offset: 0x0006A240
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003BA RID: 954
			private Class2132 class2132_0;
		}

		// Token: 0x02000187 RID: 391
		public sealed class Class1610 : IEnumerator
		{
			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0006C058 File Offset: 0x0006A258
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008C6 RID: 2246 RVA: 0x00008B0A File Offset: 0x00006D0A
			public Class1610(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008C7 RID: 2247 RVA: 0x00008B20 File Offset: 0x00006D20
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008C8 RID: 2248 RVA: 0x00008B29 File Offset: 0x00006D29
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_2();
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x0006C070 File Offset: 0x0006A270
			public Class2055 method_0()
			{
				return this.class2132_0.method_3(this.int_0);
			}

			// Token: 0x040003BB RID: 955
			private int int_0;

			// Token: 0x040003BC RID: 956
			private Class2132 class2132_0;
		}

		// Token: 0x02000188 RID: 392
		public sealed class Class1611 : IEnumerable
		{
			// Token: 0x060008CA RID: 2250 RVA: 0x00008B4C File Offset: 0x00006D4C
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x0006C090 File Offset: 0x0006A290
			public Class2132.Class1612 method_1()
			{
				return new Class2132.Class1612(this.class2132_0);
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x0006C0AC File Offset: 0x0006A2AC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003BD RID: 957
			private Class2132 class2132_0;
		}

		// Token: 0x02000189 RID: 393
		public sealed class Class1612 : IEnumerator
		{
			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060008CE RID: 2254 RVA: 0x0006C0C4 File Offset: 0x0006A2C4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x00008B55 File Offset: 0x00006D55
			public Class1612(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x00008B6B File Offset: 0x00006D6B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x00008B74 File Offset: 0x00006D74
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_4();
			}

			// Token: 0x060008D2 RID: 2258 RVA: 0x0006C0DC File Offset: 0x0006A2DC
			public Class2050 method_0()
			{
				return this.class2132_0.method_5(this.int_0);
			}

			// Token: 0x040003BE RID: 958
			private int int_0;

			// Token: 0x040003BF RID: 959
			private Class2132 class2132_0;
		}

		// Token: 0x0200018A RID: 394
		public sealed class Class1613 : IEnumerable
		{
			// Token: 0x060008D3 RID: 2259 RVA: 0x00008B97 File Offset: 0x00006D97
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x0006C0FC File Offset: 0x0006A2FC
			public Class2132.Class1614 method_1()
			{
				return new Class2132.Class1614(this.class2132_0);
			}

			// Token: 0x060008D5 RID: 2261 RVA: 0x0006C118 File Offset: 0x0006A318
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003C0 RID: 960
			private Class2132 class2132_0;
		}

		// Token: 0x0200018B RID: 395
		public sealed class Class1614 : IEnumerator
		{
			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0006C130 File Offset: 0x0006A330
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008D8 RID: 2264 RVA: 0x00008BA0 File Offset: 0x00006DA0
			public Class1614(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008D9 RID: 2265 RVA: 0x00008BB6 File Offset: 0x00006DB6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008DA RID: 2266 RVA: 0x00008BBF File Offset: 0x00006DBF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_6();
			}

			// Token: 0x060008DB RID: 2267 RVA: 0x0006C148 File Offset: 0x0006A348
			public Class2050 method_0()
			{
				return this.class2132_0.method_7(this.int_0);
			}

			// Token: 0x040003C1 RID: 961
			private int int_0;

			// Token: 0x040003C2 RID: 962
			private Class2132 class2132_0;
		}

		// Token: 0x0200018C RID: 396
		public sealed class Class1615 : IEnumerable
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x00008BE2 File Offset: 0x00006DE2
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008DD RID: 2269 RVA: 0x0006C168 File Offset: 0x0006A368
			public Class2132.Class1616 method_1()
			{
				return new Class2132.Class1616(this.class2132_0);
			}

			// Token: 0x060008DE RID: 2270 RVA: 0x0006C184 File Offset: 0x0006A384
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003C3 RID: 963
			private Class2132 class2132_0;
		}

		// Token: 0x0200018D RID: 397
		public sealed class Class1616 : IEnumerator
		{
			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0006C19C File Offset: 0x0006A39C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x00008BEB File Offset: 0x00006DEB
			public Class1616(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008E2 RID: 2274 RVA: 0x00008C01 File Offset: 0x00006E01
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x00008C0A File Offset: 0x00006E0A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_8();
			}

			// Token: 0x060008E4 RID: 2276 RVA: 0x0006C1B4 File Offset: 0x0006A3B4
			public Class2122 method_0()
			{
				return this.class2132_0.method_9(this.int_0);
			}

			// Token: 0x040003C4 RID: 964
			private int int_0;

			// Token: 0x040003C5 RID: 965
			private Class2132 class2132_0;
		}

		// Token: 0x0200018E RID: 398
		public sealed class Class1617 : IEnumerable
		{
			// Token: 0x060008E5 RID: 2277 RVA: 0x00008C2D File Offset: 0x00006E2D
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008E6 RID: 2278 RVA: 0x0006C1D4 File Offset: 0x0006A3D4
			public Class2132.Class1618 method_1()
			{
				return new Class2132.Class1618(this.class2132_0);
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003C6 RID: 966
			private Class2132 class2132_0;
		}

		// Token: 0x0200018F RID: 399
		public sealed class Class1618 : IEnumerator
		{
			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0006C208 File Offset: 0x0006A408
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x00008C36 File Offset: 0x00006E36
			public Class1618(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x00008C4C File Offset: 0x00006E4C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008EC RID: 2284 RVA: 0x00008C55 File Offset: 0x00006E55
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_10();
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x0006C220 File Offset: 0x0006A420
			public Class2128 method_0()
			{
				return this.class2132_0.method_11(this.int_0);
			}

			// Token: 0x040003C7 RID: 967
			private int int_0;

			// Token: 0x040003C8 RID: 968
			private Class2132 class2132_0;
		}

		// Token: 0x02000190 RID: 400
		public sealed class Class1619 : IEnumerable
		{
			// Token: 0x060008EE RID: 2286 RVA: 0x00008C78 File Offset: 0x00006E78
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x0006C240 File Offset: 0x0006A440
			public Class2132.Class1620 method_1()
			{
				return new Class2132.Class1620(this.class2132_0);
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x0006C25C File Offset: 0x0006A45C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003C9 RID: 969
			private Class2132 class2132_0;
		}

		// Token: 0x02000191 RID: 401
		public sealed class Class1620 : IEnumerator
		{
			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0006C274 File Offset: 0x0006A474
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008F3 RID: 2291 RVA: 0x00008C81 File Offset: 0x00006E81
			public Class1620(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x00008C97 File Offset: 0x00006E97
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x00008CA0 File Offset: 0x00006EA0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_12();
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x0006C28C File Offset: 0x0006A48C
			public Class2111 method_0()
			{
				return this.class2132_0.method_13(this.int_0);
			}

			// Token: 0x040003CA RID: 970
			private int int_0;

			// Token: 0x040003CB RID: 971
			private Class2132 class2132_0;
		}

		// Token: 0x02000192 RID: 402
		public sealed class Class1621 : IEnumerable
		{
			// Token: 0x060008F7 RID: 2295 RVA: 0x00008CC3 File Offset: 0x00006EC3
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x0006C2AC File Offset: 0x0006A4AC
			public Class2132.Class1622 method_1()
			{
				return new Class2132.Class1622(this.class2132_0);
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x0006C2C8 File Offset: 0x0006A4C8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003CC RID: 972
			private Class2132 class2132_0;
		}

		// Token: 0x02000193 RID: 403
		public sealed class Class1622 : IEnumerator
		{
			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060008FB RID: 2299 RVA: 0x0006C2E0 File Offset: 0x0006A4E0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x00008CCC File Offset: 0x00006ECC
			public Class1622(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x00008CE2 File Offset: 0x00006EE2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x00008CEB File Offset: 0x00006EEB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_14();
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x0006C2F8 File Offset: 0x0006A4F8
			public Class2050 method_0()
			{
				return this.class2132_0.method_15(this.int_0);
			}

			// Token: 0x040003CD RID: 973
			private int int_0;

			// Token: 0x040003CE RID: 974
			private Class2132 class2132_0;
		}

		// Token: 0x02000194 RID: 404
		public sealed class Class1623 : IEnumerable
		{
			// Token: 0x06000900 RID: 2304 RVA: 0x00008D0E File Offset: 0x00006F0E
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x06000901 RID: 2305 RVA: 0x0006C318 File Offset: 0x0006A518
			public Class2132.Class1624 method_1()
			{
				return new Class2132.Class1624(this.class2132_0);
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x0006C334 File Offset: 0x0006A534
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003CF RID: 975
			private Class2132 class2132_0;
		}

		// Token: 0x02000195 RID: 405
		public sealed class Class1624 : IEnumerator
		{
			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000904 RID: 2308 RVA: 0x0006C34C File Offset: 0x0006A54C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x00008D17 File Offset: 0x00006F17
			public Class1624(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00008D2D File Offset: 0x00006F2D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00008D36 File Offset: 0x00006F36
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_16();
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x0006C364 File Offset: 0x0006A564
			public Class2050 method_0()
			{
				return this.class2132_0.method_17(this.int_0);
			}

			// Token: 0x040003D0 RID: 976
			private int int_0;

			// Token: 0x040003D1 RID: 977
			private Class2132 class2132_0;
		}

		// Token: 0x02000196 RID: 406
		public sealed class Class1625 : IEnumerable
		{
			// Token: 0x06000909 RID: 2313 RVA: 0x00008D59 File Offset: 0x00006F59
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x0006C384 File Offset: 0x0006A584
			public Class2132.Class1626 method_1()
			{
				return new Class2132.Class1626(this.class2132_0);
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x0006C3A0 File Offset: 0x0006A5A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003D2 RID: 978
			private Class2132 class2132_0;
		}

		// Token: 0x02000197 RID: 407
		public sealed class Class1626 : IEnumerator
		{
			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600090D RID: 2317 RVA: 0x0006C3B8 File Offset: 0x0006A5B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00008D62 File Offset: 0x00006F62
			public Class1626(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x00008D78 File Offset: 0x00006F78
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x00008D81 File Offset: 0x00006F81
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_18();
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x0006C3D0 File Offset: 0x0006A5D0
			public Class2018 method_0()
			{
				return this.class2132_0.method_19(this.int_0);
			}

			// Token: 0x040003D3 RID: 979
			private int int_0;

			// Token: 0x040003D4 RID: 980
			private Class2132 class2132_0;
		}

		// Token: 0x02000198 RID: 408
		public sealed class Class1627 : IEnumerable
		{
			// Token: 0x06000912 RID: 2322 RVA: 0x00008DA4 File Offset: 0x00006FA4
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0006C3F0 File Offset: 0x0006A5F0
			public Class2132.Class1628 method_1()
			{
				return new Class2132.Class1628(this.class2132_0);
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0006C40C File Offset: 0x0006A60C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003D5 RID: 981
			private Class2132 class2132_0;
		}

		// Token: 0x02000199 RID: 409
		public sealed class Class1628 : IEnumerator
		{
			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000916 RID: 2326 RVA: 0x0006C424 File Offset: 0x0006A624
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x00008DAD File Offset: 0x00006FAD
			public Class1628(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x00008DC3 File Offset: 0x00006FC3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x00008DCC File Offset: 0x00006FCC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_20();
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x0006C43C File Offset: 0x0006A63C
			public Class2018 method_0()
			{
				return this.class2132_0.method_21(this.int_0);
			}

			// Token: 0x040003D6 RID: 982
			private int int_0;

			// Token: 0x040003D7 RID: 983
			private Class2132 class2132_0;
		}

		// Token: 0x0200019A RID: 410
		public sealed class Class1629 : IEnumerable
		{
			// Token: 0x0600091B RID: 2331 RVA: 0x00008DEF File Offset: 0x00006FEF
			public void method_0(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
			}

			// Token: 0x0600091C RID: 2332 RVA: 0x0006C45C File Offset: 0x0006A65C
			public Class2132.Class1630 method_1()
			{
				return new Class2132.Class1630(this.class2132_0);
			}

			// Token: 0x0600091D RID: 2333 RVA: 0x0006C478 File Offset: 0x0006A678
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003D8 RID: 984
			private Class2132 class2132_0;
		}

		// Token: 0x0200019B RID: 411
		public sealed class Class1630 : IEnumerator
		{
			// Token: 0x170000DF RID: 223
			// (get) Token: 0x0600091F RID: 2335 RVA: 0x0006C490 File Offset: 0x0006A690
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x00008DF8 File Offset: 0x00006FF8
			public Class1630(Class2132 class2132_1)
			{
				this.class2132_0 = class2132_1;
				this.int_0 = -1;
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00008E0E File Offset: 0x0000700E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x00008E17 File Offset: 0x00007017
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2132_0.method_22();
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x0006C4A8 File Offset: 0x0006A6A8
			public Class2018 method_0()
			{
				return this.class2132_0.method_23(this.int_0);
			}

			// Token: 0x040003D9 RID: 985
			private int int_0;

			// Token: 0x040003DA RID: 986
			private Class2132 class2132_0;
		}
	}
}
