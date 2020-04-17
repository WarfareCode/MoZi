using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;
using ns20;

namespace ns21
{
	// Token: 0x02000050 RID: 80
	public sealed class Class2105 : Class2059
	{
		// Token: 0x0600017F RID: 383 RVA: 0x000596F8 File Offset: 0x000578F8
		public Class2105()
		{
			this.method_24();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0005978C File Offset: 0x0005798C
		public Class2105(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00058E58 File Offset: 0x00057058
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Username");
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00058E78 File Offset: 0x00057078
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Username", int_0)));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00058EA4 File Offset: 0x000570A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Password");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00058EC4 File Offset: 0x000570C4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Password", int_0)));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00058EF0 File Offset: 0x000570F0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerGetMapUrl");
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00058F10 File Offset: 0x00057110
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerGetMapUrl", int_0)));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00058F3C File Offset: 0x0005713C
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Version");
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00058F5C File Offset: 0x0005715C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Version", int_0)));
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00058F88 File Offset: 0x00057188
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageFormat");
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00058FA8 File Offset: 0x000571A8
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ImageFormat", int_0)));
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00058FD4 File Offset: 0x000571D4
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerName");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00058FF4 File Offset: 0x000571F4
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerName", int_0)));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00059020 File Offset: 0x00057220
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerStyle");
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00059040 File Offset: 0x00057240
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerStyle", int_0)));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0005906C File Offset: 0x0005726C
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "UseTransparency");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0005908C File Offset: 0x0005728C
		public Class2009 method_17(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "UseTransparency", int_0)));
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000590B8 File Offset: 0x000572B8
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CacheExpirationTime");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000590D8 File Offset: 0x000572D8
		public Class2100 method_19(int int_0)
		{
			return new Class2100(base.method_1(Class2059.Enum155.const_1, "", "CacheExpirationTime", int_0));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00059100 File Offset: 0x00057300
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBoxOverlap");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00059820 File Offset: 0x00057A20
		public Class2025 method_21(int int_0)
		{
			return new Class2025(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "BoundingBoxOverlap", int_0)));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0005914C File Offset: 0x0005734C
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerLogoFilePath");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0005916C File Offset: 0x0005736C
		public Class2050 method_23(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerLogoFilePath", int_0)));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0005984C File Offset: 0x00057A4C
		private void method_24()
		{
			this.class1387_0.method_0(this);
			this.class1389_0.method_0(this);
			this.class1391_0.method_0(this);
			this.class1393_0.method_0(this);
			this.class1395_0.method_0(this);
			this.class1397_0.method_0(this);
			this.class1399_0.method_0(this);
			this.class1401_0.method_0(this);
			this.class1403_0.method_0(this);
			this.class1405_0.method_0(this);
			this.class1407_0.method_0(this);
		}

		// Token: 0x04000118 RID: 280
		public Class2105.Class1387 class1387_0 = new Class2105.Class1387();

		// Token: 0x04000119 RID: 281
		public Class2105.Class1389 class1389_0 = new Class2105.Class1389();

		// Token: 0x0400011A RID: 282
		public Class2105.Class1391 class1391_0 = new Class2105.Class1391();

		// Token: 0x0400011B RID: 283
		public Class2105.Class1393 class1393_0 = new Class2105.Class1393();

		// Token: 0x0400011C RID: 284
		public Class2105.Class1395 class1395_0 = new Class2105.Class1395();

		// Token: 0x0400011D RID: 285
		public Class2105.Class1397 class1397_0 = new Class2105.Class1397();

		// Token: 0x0400011E RID: 286
		public Class2105.Class1399 class1399_0 = new Class2105.Class1399();

		// Token: 0x0400011F RID: 287
		public Class2105.Class1401 class1401_0 = new Class2105.Class1401();

		// Token: 0x04000120 RID: 288
		public Class2105.Class1403 class1403_0 = new Class2105.Class1403();

		// Token: 0x04000121 RID: 289
		public Class2105.Class1405 class1405_0 = new Class2105.Class1405();

		// Token: 0x04000122 RID: 290
		public Class2105.Class1407 class1407_0 = new Class2105.Class1407();

		// Token: 0x02000051 RID: 81
		public sealed class Class1387 : IEnumerable
		{
			// Token: 0x06000198 RID: 408 RVA: 0x000051E9 File Offset: 0x000033E9
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x06000199 RID: 409 RVA: 0x000598E0 File Offset: 0x00057AE0
			public Class2105.Class1388 method_1()
			{
				return new Class2105.Class1388(this.class2105_0);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x000598FC File Offset: 0x00057AFC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000123 RID: 291
			private Class2105 class2105_0;
		}

		// Token: 0x02000052 RID: 82
		public sealed class Class1388 : IEnumerator
		{
			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600019C RID: 412 RVA: 0x00059914 File Offset: 0x00057B14
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600019D RID: 413 RVA: 0x000051F2 File Offset: 0x000033F2
			public Class1388(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00005208 File Offset: 0x00003408
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00005211 File Offset: 0x00003411
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_2();
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0005992C File Offset: 0x00057B2C
			public Class2050 method_0()
			{
				return this.class2105_0.method_3(this.int_0);
			}

			// Token: 0x04000124 RID: 292
			private int int_0;

			// Token: 0x04000125 RID: 293
			private Class2105 class2105_0;
		}

		// Token: 0x02000053 RID: 83
		public sealed class Class1389 : IEnumerable
		{
			// Token: 0x060001A1 RID: 417 RVA: 0x00005234 File Offset: 0x00003434
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x0005994C File Offset: 0x00057B4C
			public Class2105.Class1390 method_1()
			{
				return new Class2105.Class1390(this.class2105_0);
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00059968 File Offset: 0x00057B68
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000126 RID: 294
			private Class2105 class2105_0;
		}

		// Token: 0x02000054 RID: 84
		public sealed class Class1390 : IEnumerator
		{
			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060001A5 RID: 421 RVA: 0x00059980 File Offset: 0x00057B80
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0000523D File Offset: 0x0000343D
			public Class1390(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00005253 File Offset: 0x00003453
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x0000525C File Offset: 0x0000345C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_4();
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00059998 File Offset: 0x00057B98
			public Class2050 method_0()
			{
				return this.class2105_0.method_5(this.int_0);
			}

			// Token: 0x04000127 RID: 295
			private int int_0;

			// Token: 0x04000128 RID: 296
			private Class2105 class2105_0;
		}

		// Token: 0x02000055 RID: 85
		public sealed class Class1391 : IEnumerable
		{
			// Token: 0x060001AA RID: 426 RVA: 0x0000527F File Offset: 0x0000347F
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x000599B8 File Offset: 0x00057BB8
			public Class2105.Class1392 method_1()
			{
				return new Class2105.Class1392(this.class2105_0);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x000599D4 File Offset: 0x00057BD4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000129 RID: 297
			private Class2105 class2105_0;
		}

		// Token: 0x02000056 RID: 86
		public sealed class Class1392 : IEnumerator
		{
			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060001AE RID: 430 RVA: 0x000599EC File Offset: 0x00057BEC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00005288 File Offset: 0x00003488
			public Class1392(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0000529E File Offset: 0x0000349E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x000052A7 File Offset: 0x000034A7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_6();
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00059A04 File Offset: 0x00057C04
			public Class2050 method_0()
			{
				return this.class2105_0.method_7(this.int_0);
			}

			// Token: 0x0400012A RID: 298
			private int int_0;

			// Token: 0x0400012B RID: 299
			private Class2105 class2105_0;
		}

		// Token: 0x02000057 RID: 87
		public sealed class Class1393 : IEnumerable
		{
			// Token: 0x060001B3 RID: 435 RVA: 0x000052CA File Offset: 0x000034CA
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00059A24 File Offset: 0x00057C24
			public Class2105.Class1394 method_1()
			{
				return new Class2105.Class1394(this.class2105_0);
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00059A40 File Offset: 0x00057C40
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400012C RID: 300
			private Class2105 class2105_0;
		}

		// Token: 0x02000058 RID: 88
		public sealed class Class1394 : IEnumerator
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060001B7 RID: 439 RVA: 0x00059A58 File Offset: 0x00057C58
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x000052D3 File Offset: 0x000034D3
			public Class1394(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x000052E9 File Offset: 0x000034E9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x000052F2 File Offset: 0x000034F2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_8();
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00059A70 File Offset: 0x00057C70
			public Class2050 method_0()
			{
				return this.class2105_0.method_9(this.int_0);
			}

			// Token: 0x0400012D RID: 301
			private int int_0;

			// Token: 0x0400012E RID: 302
			private Class2105 class2105_0;
		}

		// Token: 0x02000059 RID: 89
		public sealed class Class1395 : IEnumerable
		{
			// Token: 0x060001BC RID: 444 RVA: 0x00005315 File Offset: 0x00003515
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00059A90 File Offset: 0x00057C90
			public Class2105.Class1396 method_1()
			{
				return new Class2105.Class1396(this.class2105_0);
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00059AAC File Offset: 0x00057CAC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400012F RID: 303
			private Class2105 class2105_0;
		}

		// Token: 0x0200005A RID: 90
		public sealed class Class1396 : IEnumerator
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060001C0 RID: 448 RVA: 0x00059AC4 File Offset: 0x00057CC4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x0000531E File Offset: 0x0000351E
			public Class1396(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00005334 File Offset: 0x00003534
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x0000533D File Offset: 0x0000353D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_10();
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00059ADC File Offset: 0x00057CDC
			public Class2050 method_0()
			{
				return this.class2105_0.method_11(this.int_0);
			}

			// Token: 0x04000130 RID: 304
			private int int_0;

			// Token: 0x04000131 RID: 305
			private Class2105 class2105_0;
		}

		// Token: 0x0200005B RID: 91
		public sealed class Class1397 : IEnumerable
		{
			// Token: 0x060001C5 RID: 453 RVA: 0x00005360 File Offset: 0x00003560
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00059AFC File Offset: 0x00057CFC
			public Class2105.Class1398 method_1()
			{
				return new Class2105.Class1398(this.class2105_0);
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00059B18 File Offset: 0x00057D18
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000132 RID: 306
			private Class2105 class2105_0;
		}

		// Token: 0x0200005C RID: 92
		public sealed class Class1398 : IEnumerator
		{
			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x00059B30 File Offset: 0x00057D30
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00005369 File Offset: 0x00003569
			public Class1398(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x0000537F File Offset: 0x0000357F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00005388 File Offset: 0x00003588
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_12();
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00059B48 File Offset: 0x00057D48
			public Class2050 method_0()
			{
				return this.class2105_0.method_13(this.int_0);
			}

			// Token: 0x04000133 RID: 307
			private int int_0;

			// Token: 0x04000134 RID: 308
			private Class2105 class2105_0;
		}

		// Token: 0x0200005D RID: 93
		public sealed class Class1399 : IEnumerable
		{
			// Token: 0x060001CE RID: 462 RVA: 0x000053AB File Offset: 0x000035AB
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00059B68 File Offset: 0x00057D68
			public Class2105.Class1400 method_1()
			{
				return new Class2105.Class1400(this.class2105_0);
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00059B84 File Offset: 0x00057D84
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000135 RID: 309
			private Class2105 class2105_0;
		}

		// Token: 0x0200005E RID: 94
		public sealed class Class1400 : IEnumerator
		{
			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x00059B9C File Offset: 0x00057D9C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x000053B4 File Offset: 0x000035B4
			public Class1400(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x000053CA File Offset: 0x000035CA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x000053D3 File Offset: 0x000035D3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_14();
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00059BB4 File Offset: 0x00057DB4
			public Class2050 method_0()
			{
				return this.class2105_0.method_15(this.int_0);
			}

			// Token: 0x04000136 RID: 310
			private int int_0;

			// Token: 0x04000137 RID: 311
			private Class2105 class2105_0;
		}

		// Token: 0x0200005F RID: 95
		public sealed class Class1401 : IEnumerable
		{
			// Token: 0x060001D7 RID: 471 RVA: 0x000053F6 File Offset: 0x000035F6
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00059BD4 File Offset: 0x00057DD4
			public Class2105.Class1402 method_1()
			{
				return new Class2105.Class1402(this.class2105_0);
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00059BF0 File Offset: 0x00057DF0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000138 RID: 312
			private Class2105 class2105_0;
		}

		// Token: 0x02000060 RID: 96
		public sealed class Class1402 : IEnumerator
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00059C08 File Offset: 0x00057E08
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x000053FF File Offset: 0x000035FF
			public Class1402(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00005415 File Offset: 0x00003615
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0000541E File Offset: 0x0000361E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_16();
			}

			// Token: 0x060001DF RID: 479 RVA: 0x00059C20 File Offset: 0x00057E20
			public Class2009 method_0()
			{
				return this.class2105_0.method_17(this.int_0);
			}

			// Token: 0x04000139 RID: 313
			private int int_0;

			// Token: 0x0400013A RID: 314
			private Class2105 class2105_0;
		}

		// Token: 0x02000061 RID: 97
		public sealed class Class1403 : IEnumerable
		{
			// Token: 0x060001E0 RID: 480 RVA: 0x00005441 File Offset: 0x00003641
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00059C40 File Offset: 0x00057E40
			public Class2105.Class1404 method_1()
			{
				return new Class2105.Class1404(this.class2105_0);
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00059C5C File Offset: 0x00057E5C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400013B RID: 315
			private Class2105 class2105_0;
		}

		// Token: 0x02000062 RID: 98
		public sealed class Class1404 : IEnumerator
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x00059C74 File Offset: 0x00057E74
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0000544A File Offset: 0x0000364A
			public Class1404(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00005460 File Offset: 0x00003660
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00005469 File Offset: 0x00003669
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_18();
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00059C8C File Offset: 0x00057E8C
			public Class2100 method_0()
			{
				return this.class2105_0.method_19(this.int_0);
			}

			// Token: 0x0400013C RID: 316
			private int int_0;

			// Token: 0x0400013D RID: 317
			private Class2105 class2105_0;
		}

		// Token: 0x02000063 RID: 99
		public sealed class Class1405 : IEnumerable
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x0000548C File Offset: 0x0000368C
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00059CAC File Offset: 0x00057EAC
			public Class2105.Class1406 method_1()
			{
				return new Class2105.Class1406(this.class2105_0);
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00059CC8 File Offset: 0x00057EC8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400013E RID: 318
			private Class2105 class2105_0;
		}

		// Token: 0x02000064 RID: 100
		public sealed class Class1406 : IEnumerator
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060001ED RID: 493 RVA: 0x00059CE0 File Offset: 0x00057EE0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00005495 File Offset: 0x00003695
			public Class1406(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x000054AB File Offset: 0x000036AB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x000054B4 File Offset: 0x000036B4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_20();
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00059CF8 File Offset: 0x00057EF8
			public Class2025 method_0()
			{
				return this.class2105_0.method_21(this.int_0);
			}

			// Token: 0x0400013F RID: 319
			private int int_0;

			// Token: 0x04000140 RID: 320
			private Class2105 class2105_0;
		}

		// Token: 0x02000065 RID: 101
		public sealed class Class1407 : IEnumerable
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x000054D7 File Offset: 0x000036D7
			public void method_0(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00059D18 File Offset: 0x00057F18
			public Class2105.Class1408 method_1()
			{
				return new Class2105.Class1408(this.class2105_0);
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00059D34 File Offset: 0x00057F34
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000141 RID: 321
			private Class2105 class2105_0;
		}

		// Token: 0x02000066 RID: 102
		public sealed class Class1408 : IEnumerator
		{
			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x00059D4C File Offset: 0x00057F4C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x000054E0 File Offset: 0x000036E0
			public Class1408(Class2105 class2105_1)
			{
				this.class2105_0 = class2105_1;
				this.int_0 = -1;
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x000054F6 File Offset: 0x000036F6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x000054FF File Offset: 0x000036FF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2105_0.method_22();
			}

			// Token: 0x060001FA RID: 506 RVA: 0x00059D64 File Offset: 0x00057F64
			public Class2050 method_0()
			{
				return this.class2105_0.method_23(this.int_0);
			}

			// Token: 0x04000142 RID: 322
			private int int_0;

			// Token: 0x04000143 RID: 323
			private Class2105 class2105_0;
		}
	}
}
