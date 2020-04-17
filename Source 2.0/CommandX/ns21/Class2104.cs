using System;
using System.Collections;
using ns16;
using ns17;
using ns20;

namespace ns21
{
	// Token: 0x0200002B RID: 43
	public sealed class Class2104 : Class2059
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00058DC4 File Offset: 0x00056FC4
		public Class2104()
		{
			this.method_24();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00058E58 File Offset: 0x00057058
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Username");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00058E78 File Offset: 0x00057078
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Username", int_0)));
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00058EA4 File Offset: 0x000570A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Password");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00058EC4 File Offset: 0x000570C4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Password", int_0)));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00058EF0 File Offset: 0x000570F0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerGetMapUrl");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00058F10 File Offset: 0x00057110
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerGetMapUrl", int_0)));
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00058F3C File Offset: 0x0005713C
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Version");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00058F5C File Offset: 0x0005715C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Version", int_0)));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00058F88 File Offset: 0x00057188
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageFormat");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00058FA8 File Offset: 0x000571A8
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ImageFormat", int_0)));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00058FD4 File Offset: 0x000571D4
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerName");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00058FF4 File Offset: 0x000571F4
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerName", int_0)));
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00059020 File Offset: 0x00057220
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerStyle");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00059040 File Offset: 0x00057240
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerStyle", int_0)));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0005906C File Offset: 0x0005726C
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "UseTransparency");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0005908C File Offset: 0x0005728C
		public Class2009 method_17(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "UseTransparency", int_0)));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000590B8 File Offset: 0x000572B8
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CacheExpirationTime");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000590D8 File Offset: 0x000572D8
		public Class2100 method_19(int int_0)
		{
			return new Class2100(base.method_1(Class2059.Enum155.const_1, "", "CacheExpirationTime", int_0));
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00059100 File Offset: 0x00057300
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBoxOverlap");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00059120 File Offset: 0x00057320
		public Class2024 method_21(int int_0)
		{
			return new Class2024(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "BoundingBoxOverlap", int_0)));
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0005914C File Offset: 0x0005734C
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerLogoFilePath");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0005916C File Offset: 0x0005736C
		public Class2050 method_23(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerLogoFilePath", int_0)));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00059198 File Offset: 0x00057398
		private void method_24()
		{
			this.class1365_0.method_0(this);
			this.class1367_0.method_0(this);
			this.class1369_0.method_0(this);
			this.class1371_0.method_0(this);
			this.class1373_0.method_0(this);
			this.class1375_0.method_0(this);
			this.class1377_0.method_0(this);
			this.class1379_0.method_0(this);
			this.class1381_0.method_0(this);
			this.class1383_0.method_0(this);
			this.class1385_0.method_0(this);
		}

		// Token: 0x040000AB RID: 171
		public Class2104.Class1365 class1365_0 = new Class2104.Class1365();

		// Token: 0x040000AC RID: 172
		public Class2104.Class1367 class1367_0 = new Class2104.Class1367();

		// Token: 0x040000AD RID: 173
		public Class2104.Class1369 class1369_0 = new Class2104.Class1369();

		// Token: 0x040000AE RID: 174
		public Class2104.Class1371 class1371_0 = new Class2104.Class1371();

		// Token: 0x040000AF RID: 175
		public Class2104.Class1373 class1373_0 = new Class2104.Class1373();

		// Token: 0x040000B0 RID: 176
		public Class2104.Class1375 class1375_0 = new Class2104.Class1375();

		// Token: 0x040000B1 RID: 177
		public Class2104.Class1377 class1377_0 = new Class2104.Class1377();

		// Token: 0x040000B2 RID: 178
		public Class2104.Class1379 class1379_0 = new Class2104.Class1379();

		// Token: 0x040000B3 RID: 179
		public Class2104.Class1381 class1381_0 = new Class2104.Class1381();

		// Token: 0x040000B4 RID: 180
		public Class2104.Class1383 class1383_0 = new Class2104.Class1383();

		// Token: 0x040000B5 RID: 181
		public Class2104.Class1385 class1385_0 = new Class2104.Class1385();

		// Token: 0x0200002C RID: 44
		public sealed class Class1365 : IEnumerable
		{
			// Token: 0x06000113 RID: 275 RVA: 0x00004E9A File Offset: 0x0000309A
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x0005922C File Offset: 0x0005742C
			public Class2104.Class1366 method_1()
			{
				return new Class2104.Class1366(this.class2104_0);
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00059248 File Offset: 0x00057448
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000B6 RID: 182
			private Class2104 class2104_0;
		}

		// Token: 0x0200002D RID: 45
		public sealed class Class1366 : IEnumerator
		{
			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00059260 File Offset: 0x00057460
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00004EA3 File Offset: 0x000030A3
			public Class1366(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00004EB9 File Offset: 0x000030B9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00004EC2 File Offset: 0x000030C2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_2();
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00059278 File Offset: 0x00057478
			public Class2050 method_0()
			{
				return this.class2104_0.method_3(this.int_0);
			}

			// Token: 0x040000B7 RID: 183
			private int int_0;

			// Token: 0x040000B8 RID: 184
			private Class2104 class2104_0;
		}

		// Token: 0x0200002E RID: 46
		public sealed class Class1367 : IEnumerable
		{
			// Token: 0x0600011C RID: 284 RVA: 0x00004EE5 File Offset: 0x000030E5
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00059298 File Offset: 0x00057498
			public Class2104.Class1368 method_1()
			{
				return new Class2104.Class1368(this.class2104_0);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000592B4 File Offset: 0x000574B4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000B9 RID: 185
			private Class2104 class2104_0;
		}

		// Token: 0x0200002F RID: 47
		public sealed class Class1368 : IEnumerator
		{
			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000120 RID: 288 RVA: 0x000592CC File Offset: 0x000574CC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00004EEE File Offset: 0x000030EE
			public Class1368(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00004F04 File Offset: 0x00003104
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00004F0D File Offset: 0x0000310D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_4();
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000592E4 File Offset: 0x000574E4
			public Class2050 method_0()
			{
				return this.class2104_0.method_5(this.int_0);
			}

			// Token: 0x040000BA RID: 186
			private int int_0;

			// Token: 0x040000BB RID: 187
			private Class2104 class2104_0;
		}

		// Token: 0x02000030 RID: 48
		public sealed class Class1369 : IEnumerable
		{
			// Token: 0x06000125 RID: 293 RVA: 0x00004F30 File Offset: 0x00003130
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00059304 File Offset: 0x00057504
			public Class2104.Class1370 method_1()
			{
				return new Class2104.Class1370(this.class2104_0);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00059320 File Offset: 0x00057520
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000BC RID: 188
			private Class2104 class2104_0;
		}

		// Token: 0x02000031 RID: 49
		public sealed class Class1370 : IEnumerator
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00059338 File Offset: 0x00057538
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004F39 File Offset: 0x00003139
			public Class1370(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00004F4F File Offset: 0x0000314F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00004F58 File Offset: 0x00003158
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_6();
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00059350 File Offset: 0x00057550
			public Class2050 method_0()
			{
				return this.class2104_0.method_7(this.int_0);
			}

			// Token: 0x040000BD RID: 189
			private int int_0;

			// Token: 0x040000BE RID: 190
			private Class2104 class2104_0;
		}

		// Token: 0x02000032 RID: 50
		public sealed class Class1371 : IEnumerable
		{
			// Token: 0x0600012E RID: 302 RVA: 0x00004F7B File Offset: 0x0000317B
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00059370 File Offset: 0x00057570
			public Class2104.Class1372 method_1()
			{
				return new Class2104.Class1372(this.class2104_0);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x0005938C File Offset: 0x0005758C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000BF RID: 191
			private Class2104 class2104_0;
		}

		// Token: 0x02000033 RID: 51
		public sealed class Class1372 : IEnumerator
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000132 RID: 306 RVA: 0x000593A4 File Offset: 0x000575A4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00004F84 File Offset: 0x00003184
			public Class1372(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00004F9A File Offset: 0x0000319A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00004FA3 File Offset: 0x000031A3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_8();
			}

			// Token: 0x06000136 RID: 310 RVA: 0x000593BC File Offset: 0x000575BC
			public Class2050 method_0()
			{
				return this.class2104_0.method_9(this.int_0);
			}

			// Token: 0x040000C0 RID: 192
			private int int_0;

			// Token: 0x040000C1 RID: 193
			private Class2104 class2104_0;
		}

		// Token: 0x02000034 RID: 52
		public sealed class Class1373 : IEnumerable
		{
			// Token: 0x06000137 RID: 311 RVA: 0x00004FC6 File Offset: 0x000031C6
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000138 RID: 312 RVA: 0x000593DC File Offset: 0x000575DC
			public Class2104.Class1374 method_1()
			{
				return new Class2104.Class1374(this.class2104_0);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x000593F8 File Offset: 0x000575F8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000C2 RID: 194
			private Class2104 class2104_0;
		}

		// Token: 0x02000035 RID: 53
		public sealed class Class1374 : IEnumerator
		{
			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00059410 File Offset: 0x00057610
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00004FCF File Offset: 0x000031CF
			public Class1374(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00004FE5 File Offset: 0x000031E5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00004FEE File Offset: 0x000031EE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_10();
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00059428 File Offset: 0x00057628
			public Class2050 method_0()
			{
				return this.class2104_0.method_11(this.int_0);
			}

			// Token: 0x040000C3 RID: 195
			private int int_0;

			// Token: 0x040000C4 RID: 196
			private Class2104 class2104_0;
		}

		// Token: 0x02000036 RID: 54
		public sealed class Class1375 : IEnumerable
		{
			// Token: 0x06000140 RID: 320 RVA: 0x00005011 File Offset: 0x00003211
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00059448 File Offset: 0x00057648
			public Class2104.Class1376 method_1()
			{
				return new Class2104.Class1376(this.class2104_0);
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00059464 File Offset: 0x00057664
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000C5 RID: 197
			private Class2104 class2104_0;
		}

		// Token: 0x02000037 RID: 55
		public sealed class Class1376 : IEnumerator
		{
			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000144 RID: 324 RVA: 0x0005947C File Offset: 0x0005767C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000145 RID: 325 RVA: 0x0000501A File Offset: 0x0000321A
			public Class1376(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00005030 File Offset: 0x00003230
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00005039 File Offset: 0x00003239
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_12();
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00059494 File Offset: 0x00057694
			public Class2050 method_0()
			{
				return this.class2104_0.method_13(this.int_0);
			}

			// Token: 0x040000C6 RID: 198
			private int int_0;

			// Token: 0x040000C7 RID: 199
			private Class2104 class2104_0;
		}

		// Token: 0x02000038 RID: 56
		public sealed class Class1377 : IEnumerable
		{
			// Token: 0x06000149 RID: 329 RVA: 0x0000505C File Offset: 0x0000325C
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x0600014A RID: 330 RVA: 0x000594B4 File Offset: 0x000576B4
			public Class2104.Class1378 method_1()
			{
				return new Class2104.Class1378(this.class2104_0);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000594D0 File Offset: 0x000576D0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000C8 RID: 200
			private Class2104 class2104_0;
		}

		// Token: 0x02000039 RID: 57
		public sealed class Class1378 : IEnumerator
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600014D RID: 333 RVA: 0x000594E8 File Offset: 0x000576E8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00005065 File Offset: 0x00003265
			public Class1378(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x0600014F RID: 335 RVA: 0x0000507B File Offset: 0x0000327B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00005084 File Offset: 0x00003284
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_14();
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00059500 File Offset: 0x00057700
			public Class2050 method_0()
			{
				return this.class2104_0.method_15(this.int_0);
			}

			// Token: 0x040000C9 RID: 201
			private int int_0;

			// Token: 0x040000CA RID: 202
			private Class2104 class2104_0;
		}

		// Token: 0x0200003A RID: 58
		public sealed class Class1379 : IEnumerable
		{
			// Token: 0x06000152 RID: 338 RVA: 0x000050A7 File Offset: 0x000032A7
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00059520 File Offset: 0x00057720
			public Class2104.Class1380 method_1()
			{
				return new Class2104.Class1380(this.class2104_0);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x0005953C File Offset: 0x0005773C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000CB RID: 203
			private Class2104 class2104_0;
		}

		// Token: 0x0200003B RID: 59
		public sealed class Class1380 : IEnumerator
		{
			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00059554 File Offset: 0x00057754
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000050B0 File Offset: 0x000032B0
			public Class1380(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x000050C6 File Offset: 0x000032C6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000159 RID: 345 RVA: 0x000050CF File Offset: 0x000032CF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_16();
			}

			// Token: 0x0600015A RID: 346 RVA: 0x0005956C File Offset: 0x0005776C
			public Class2009 method_0()
			{
				return this.class2104_0.method_17(this.int_0);
			}

			// Token: 0x040000CC RID: 204
			private int int_0;

			// Token: 0x040000CD RID: 205
			private Class2104 class2104_0;
		}

		// Token: 0x0200003C RID: 60
		public sealed class Class1381 : IEnumerable
		{
			// Token: 0x0600015B RID: 347 RVA: 0x000050F2 File Offset: 0x000032F2
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x0600015C RID: 348 RVA: 0x0005958C File Offset: 0x0005778C
			public Class2104.Class1382 method_1()
			{
				return new Class2104.Class1382(this.class2104_0);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x000595A8 File Offset: 0x000577A8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000CE RID: 206
			private Class2104 class2104_0;
		}

		// Token: 0x0200003D RID: 61
		public sealed class Class1382 : IEnumerator
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x0600015F RID: 351 RVA: 0x000595C0 File Offset: 0x000577C0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000160 RID: 352 RVA: 0x000050FB File Offset: 0x000032FB
			public Class1382(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00005111 File Offset: 0x00003311
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000162 RID: 354 RVA: 0x0000511A File Offset: 0x0000331A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_18();
			}

			// Token: 0x06000163 RID: 355 RVA: 0x000595D8 File Offset: 0x000577D8
			public Class2100 method_0()
			{
				return this.class2104_0.method_19(this.int_0);
			}

			// Token: 0x040000CF RID: 207
			private int int_0;

			// Token: 0x040000D0 RID: 208
			private Class2104 class2104_0;
		}

		// Token: 0x0200003E RID: 62
		public sealed class Class1383 : IEnumerable
		{
			// Token: 0x06000164 RID: 356 RVA: 0x0000513D File Offset: 0x0000333D
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x06000165 RID: 357 RVA: 0x000595F8 File Offset: 0x000577F8
			public Class2104.Class1384 method_1()
			{
				return new Class2104.Class1384(this.class2104_0);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00059614 File Offset: 0x00057814
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000D1 RID: 209
			private Class2104 class2104_0;
		}

		// Token: 0x0200003F RID: 63
		public sealed class Class1384 : IEnumerator
		{
			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000168 RID: 360 RVA: 0x0005962C File Offset: 0x0005782C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000169 RID: 361 RVA: 0x00005146 File Offset: 0x00003346
			public Class1384(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x0600016A RID: 362 RVA: 0x0000515C File Offset: 0x0000335C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00005165 File Offset: 0x00003365
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_20();
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00059644 File Offset: 0x00057844
			public Class2024 method_0()
			{
				return this.class2104_0.method_21(this.int_0);
			}

			// Token: 0x040000D2 RID: 210
			private int int_0;

			// Token: 0x040000D3 RID: 211
			private Class2104 class2104_0;
		}

		// Token: 0x02000040 RID: 64
		public sealed class Class1385 : IEnumerable
		{
			// Token: 0x0600016D RID: 365 RVA: 0x00005188 File Offset: 0x00003388
			public void method_0(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00059664 File Offset: 0x00057864
			public Class2104.Class1386 method_1()
			{
				return new Class2104.Class1386(this.class2104_0);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00059680 File Offset: 0x00057880
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040000D4 RID: 212
			private Class2104 class2104_0;
		}

		// Token: 0x02000041 RID: 65
		public sealed class Class1386 : IEnumerator
		{
			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000171 RID: 369 RVA: 0x00059698 File Offset: 0x00057898
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000172 RID: 370 RVA: 0x00005191 File Offset: 0x00003391
			public Class1386(Class2104 class2104_1)
			{
				this.class2104_0 = class2104_1;
				this.int_0 = -1;
			}

			// Token: 0x06000173 RID: 371 RVA: 0x000051A7 File Offset: 0x000033A7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x000051B0 File Offset: 0x000033B0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2104_0.method_22();
			}

			// Token: 0x06000175 RID: 373 RVA: 0x000596B0 File Offset: 0x000578B0
			public Class2050 method_0()
			{
				return this.class2104_0.method_23(this.int_0);
			}

			// Token: 0x040000D5 RID: 213
			private int int_0;

			// Token: 0x040000D6 RID: 214
			private Class2104 class2104_0;
		}
	}
}
