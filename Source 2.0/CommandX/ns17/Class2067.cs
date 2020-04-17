using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns17
{
	// Token: 0x020006D3 RID: 1747
	public sealed class Class2067 : Class2059
	{
		// Token: 0x06002BE5 RID: 11237 RVA: 0x001010FC File Offset: 0x000FF2FC
		public Class2067()
		{
			this.method_14();
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00101158 File Offset: 0x000FF358
		public Class2067(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000FFF60 File Offset: 0x000FE160
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerUrl");
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000FFF80 File Offset: 0x000FE180
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerUrl", int_0)));
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00058F3C File Offset: 0x0005713C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Version");
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00058F5C File Offset: 0x0005715C
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Version", int_0)));
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x001011B4 File Offset: 0x000FF3B4
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "UserName");
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x001011D4 File Offset: 0x000FF3D4
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "UserName", int_0)));
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x00058EA4 File Offset: 0x000570A4
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Password");
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x00058EC4 File Offset: 0x000570C4
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Password", int_0)));
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0007D178 File Offset: 0x0007B378
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Abstract");
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0007D198 File Offset: 0x0007B398
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Abstract", int_0)));
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00101200 File Offset: 0x000FF400
		private void method_14()
		{
			this.class905_0.method_0(this);
			this.class907_0.method_0(this);
			this.class909_0.method_0(this);
			this.class911_0.method_0(this);
			this.class913_0.method_0(this);
			this.class915_0.method_0(this);
		}

		// Token: 0x040014BC RID: 5308
		public Class2067.Class905 class905_0 = new Class2067.Class905();

		// Token: 0x040014BD RID: 5309
		public Class2067.Class907 class907_0 = new Class2067.Class907();

		// Token: 0x040014BE RID: 5310
		public Class2067.Class909 class909_0 = new Class2067.Class909();

		// Token: 0x040014BF RID: 5311
		public Class2067.Class911 class911_0 = new Class2067.Class911();

		// Token: 0x040014C0 RID: 5312
		public Class2067.Class913 class913_0 = new Class2067.Class913();

		// Token: 0x040014C1 RID: 5313
		public Class2067.Class915 class915_0 = new Class2067.Class915();

		// Token: 0x020006D4 RID: 1748
		public sealed class Class905 : IEnumerable
		{
			// Token: 0x06002BF4 RID: 11252 RVA: 0x00017DA0 File Offset: 0x00015FA0
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002BF5 RID: 11253 RVA: 0x00101258 File Offset: 0x000FF458
			public Class2067.Class906 method_1()
			{
				return new Class2067.Class906(this.class2067_0);
			}

			// Token: 0x06002BF6 RID: 11254 RVA: 0x00101274 File Offset: 0x000FF474
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014C2 RID: 5314
			private Class2067 class2067_0;
		}

		// Token: 0x020006D5 RID: 1749
		public sealed class Class906 : IEnumerator
		{
			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0010128C File Offset: 0x000FF48C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002BF9 RID: 11257 RVA: 0x00017DA9 File Offset: 0x00015FA9
			public Class906(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002BFA RID: 11258 RVA: 0x00017DBF File Offset: 0x00015FBF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002BFB RID: 11259 RVA: 0x00017DC8 File Offset: 0x00015FC8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_2();
			}

			// Token: 0x06002BFC RID: 11260 RVA: 0x001012A4 File Offset: 0x000FF4A4
			public Class2050 method_0()
			{
				return this.class2067_0.method_3(this.int_0);
			}

			// Token: 0x040014C3 RID: 5315
			private int int_0;

			// Token: 0x040014C4 RID: 5316
			private Class2067 class2067_0;
		}

		// Token: 0x020006D6 RID: 1750
		public sealed class Class907 : IEnumerable
		{
			// Token: 0x06002BFD RID: 11261 RVA: 0x00017DEB File Offset: 0x00015FEB
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002BFE RID: 11262 RVA: 0x001012C4 File Offset: 0x000FF4C4
			public Class2067.Class908 method_1()
			{
				return new Class2067.Class908(this.class2067_0);
			}

			// Token: 0x06002BFF RID: 11263 RVA: 0x001012E0 File Offset: 0x000FF4E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014C5 RID: 5317
			private Class2067 class2067_0;
		}

		// Token: 0x020006D7 RID: 1751
		public sealed class Class908 : IEnumerator
		{
			// Token: 0x1700030B RID: 779
			// (get) Token: 0x06002C01 RID: 11265 RVA: 0x001012F8 File Offset: 0x000FF4F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C02 RID: 11266 RVA: 0x00017DF4 File Offset: 0x00015FF4
			public Class908(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C03 RID: 11267 RVA: 0x00017E0A File Offset: 0x0001600A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C04 RID: 11268 RVA: 0x00017E13 File Offset: 0x00016013
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_4();
			}

			// Token: 0x06002C05 RID: 11269 RVA: 0x00101310 File Offset: 0x000FF510
			public Class2050 method_0()
			{
				return this.class2067_0.method_5(this.int_0);
			}

			// Token: 0x040014C6 RID: 5318
			private int int_0;

			// Token: 0x040014C7 RID: 5319
			private Class2067 class2067_0;
		}

		// Token: 0x020006D8 RID: 1752
		public sealed class Class909 : IEnumerable
		{
			// Token: 0x06002C06 RID: 11270 RVA: 0x00017E36 File Offset: 0x00016036
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x00101330 File Offset: 0x000FF530
			public Class2067.Class910 method_1()
			{
				return new Class2067.Class910(this.class2067_0);
			}

			// Token: 0x06002C08 RID: 11272 RVA: 0x0010134C File Offset: 0x000FF54C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014C8 RID: 5320
			private Class2067 class2067_0;
		}

		// Token: 0x020006D9 RID: 1753
		public sealed class Class910 : IEnumerator
		{
			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06002C0A RID: 11274 RVA: 0x00101364 File Offset: 0x000FF564
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C0B RID: 11275 RVA: 0x00017E3F File Offset: 0x0001603F
			public Class910(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C0C RID: 11276 RVA: 0x00017E55 File Offset: 0x00016055
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C0D RID: 11277 RVA: 0x00017E5E File Offset: 0x0001605E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_6();
			}

			// Token: 0x06002C0E RID: 11278 RVA: 0x0010137C File Offset: 0x000FF57C
			public Class2050 method_0()
			{
				return this.class2067_0.method_7(this.int_0);
			}

			// Token: 0x040014C9 RID: 5321
			private int int_0;

			// Token: 0x040014CA RID: 5322
			private Class2067 class2067_0;
		}

		// Token: 0x020006DA RID: 1754
		public sealed class Class911 : IEnumerable
		{
			// Token: 0x06002C0F RID: 11279 RVA: 0x00017E81 File Offset: 0x00016081
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002C10 RID: 11280 RVA: 0x0010139C File Offset: 0x000FF59C
			public Class2067.Class912 method_1()
			{
				return new Class2067.Class912(this.class2067_0);
			}

			// Token: 0x06002C11 RID: 11281 RVA: 0x001013B8 File Offset: 0x000FF5B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014CB RID: 5323
			private Class2067 class2067_0;
		}

		// Token: 0x020006DB RID: 1755
		public sealed class Class912 : IEnumerator
		{
			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06002C13 RID: 11283 RVA: 0x001013D0 File Offset: 0x000FF5D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C14 RID: 11284 RVA: 0x00017E8A File Offset: 0x0001608A
			public Class912(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C15 RID: 11285 RVA: 0x00017EA0 File Offset: 0x000160A0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x00017EA9 File Offset: 0x000160A9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_8();
			}

			// Token: 0x06002C17 RID: 11287 RVA: 0x001013E8 File Offset: 0x000FF5E8
			public Class2050 method_0()
			{
				return this.class2067_0.method_9(this.int_0);
			}

			// Token: 0x040014CC RID: 5324
			private int int_0;

			// Token: 0x040014CD RID: 5325
			private Class2067 class2067_0;
		}

		// Token: 0x020006DC RID: 1756
		public sealed class Class913 : IEnumerable
		{
			// Token: 0x06002C18 RID: 11288 RVA: 0x00017ECC File Offset: 0x000160CC
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002C19 RID: 11289 RVA: 0x00101408 File Offset: 0x000FF608
			public Class2067.Class914 method_1()
			{
				return new Class2067.Class914(this.class2067_0);
			}

			// Token: 0x06002C1A RID: 11290 RVA: 0x00101424 File Offset: 0x000FF624
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014CE RID: 5326
			private Class2067 class2067_0;
		}

		// Token: 0x020006DD RID: 1757
		public sealed class Class914 : IEnumerator
		{
			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06002C1C RID: 11292 RVA: 0x0010143C File Offset: 0x000FF63C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C1D RID: 11293 RVA: 0x00017ED5 File Offset: 0x000160D5
			public Class914(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C1E RID: 11294 RVA: 0x00017EEB File Offset: 0x000160EB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C1F RID: 11295 RVA: 0x00017EF4 File Offset: 0x000160F4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_10();
			}

			// Token: 0x06002C20 RID: 11296 RVA: 0x00101454 File Offset: 0x000FF654
			public Class2050 method_0()
			{
				return this.class2067_0.method_11(this.int_0);
			}

			// Token: 0x040014CF RID: 5327
			private int int_0;

			// Token: 0x040014D0 RID: 5328
			private Class2067 class2067_0;
		}

		// Token: 0x020006DE RID: 1758
		public sealed class Class915 : IEnumerable
		{
			// Token: 0x06002C21 RID: 11297 RVA: 0x00017F17 File Offset: 0x00016117
			public void method_0(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
			}

			// Token: 0x06002C22 RID: 11298 RVA: 0x00101474 File Offset: 0x000FF674
			public Class2067.Class916 method_1()
			{
				return new Class2067.Class916(this.class2067_0);
			}

			// Token: 0x06002C23 RID: 11299 RVA: 0x00101490 File Offset: 0x000FF690
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014D1 RID: 5329
			private Class2067 class2067_0;
		}

		// Token: 0x020006DF RID: 1759
		public sealed class Class916 : IEnumerator
		{
			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06002C25 RID: 11301 RVA: 0x001014A8 File Offset: 0x000FF6A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C26 RID: 11302 RVA: 0x00017F20 File Offset: 0x00016120
			public Class916(Class2067 class2067_1)
			{
				this.class2067_0 = class2067_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C27 RID: 11303 RVA: 0x00017F36 File Offset: 0x00016136
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C28 RID: 11304 RVA: 0x00017F3F File Offset: 0x0001613F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2067_0.method_12();
			}

			// Token: 0x06002C29 RID: 11305 RVA: 0x001014C0 File Offset: 0x000FF6C0
			public Class2050 method_0()
			{
				return this.class2067_0.method_13(this.int_0);
			}

			// Token: 0x040014D2 RID: 5330
			private int int_0;

			// Token: 0x040014D3 RID: 5331
			private Class2067 class2067_0;
		}
	}
}
