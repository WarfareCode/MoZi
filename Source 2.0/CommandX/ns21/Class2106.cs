using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x0200006E RID: 110
	public sealed class Class2106 : Class2059
	{
		// Token: 0x06000230 RID: 560 RVA: 0x000057C4 File Offset: 0x000039C4
		public Class2106()
		{
			this.method_8();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000057F3 File Offset: 0x000039F3
		public Class2106(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0005B2A4 File Offset: 0x000594A4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title");
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0005B2C4 File Offset: 0x000594C4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Title", int_0)));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0005B338 File Offset: 0x00059538
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LogoURL");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0005B358 File Offset: 0x00059558
		public Class2126 method_7(int int_0)
		{
			return new Class2126(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "LogoURL", int_0));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00005823 File Offset: 0x00003A23
		private void method_8()
		{
			this.class1409_0.method_0(this);
			this.class1411_0.method_0(this);
			this.class1413_0.method_0(this);
		}

		// Token: 0x0400014D RID: 333
		public Class2106.Class1409 class1409_0 = new Class2106.Class1409();

		// Token: 0x0400014E RID: 334
		public Class2106.Class1411 class1411_0 = new Class2106.Class1411();

		// Token: 0x0400014F RID: 335
		public Class2106.Class1413 class1413_0 = new Class2106.Class1413();

		// Token: 0x0200006F RID: 111
		public sealed class Class1409 : IEnumerable
		{
			// Token: 0x06000239 RID: 569 RVA: 0x00005849 File Offset: 0x00003A49
			public void method_0(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0005B380 File Offset: 0x00059580
			public Class2106.Class1410 method_1()
			{
				return new Class2106.Class1410(this.class2106_0);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0005B39C File Offset: 0x0005959C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000150 RID: 336
			private Class2106 class2106_0;
		}

		// Token: 0x02000070 RID: 112
		public sealed class Class1410 : IEnumerator
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600023D RID: 573 RVA: 0x0005B3B4 File Offset: 0x000595B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00005852 File Offset: 0x00003A52
			public Class1410(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
				this.int_0 = -1;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00005868 File Offset: 0x00003A68
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000240 RID: 576 RVA: 0x00005871 File Offset: 0x00003A71
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2106_0.method_2();
			}

			// Token: 0x06000241 RID: 577 RVA: 0x0005B3CC File Offset: 0x000595CC
			public Class2050 method_0()
			{
				return this.class2106_0.method_3(this.int_0);
			}

			// Token: 0x04000151 RID: 337
			private int int_0;

			// Token: 0x04000152 RID: 338
			private Class2106 class2106_0;
		}

		// Token: 0x02000071 RID: 113
		public sealed class Class1411 : IEnumerable
		{
			// Token: 0x06000242 RID: 578 RVA: 0x00005894 File Offset: 0x00003A94
			public void method_0(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0005B3EC File Offset: 0x000595EC
			public Class2106.Class1412 method_1()
			{
				return new Class2106.Class1412(this.class2106_0);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x0005B408 File Offset: 0x00059608
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000153 RID: 339
			private Class2106 class2106_0;
		}

		// Token: 0x02000072 RID: 114
		public sealed class Class1412 : IEnumerator
		{
			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0005B420 File Offset: 0x00059620
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000589D File Offset: 0x00003A9D
			public Class1412(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
				this.int_0 = -1;
			}

			// Token: 0x06000248 RID: 584 RVA: 0x000058B3 File Offset: 0x00003AB3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x000058BC File Offset: 0x00003ABC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2106_0.method_4();
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0005B438 File Offset: 0x00059638
			public Class2128 method_0()
			{
				return this.class2106_0.method_5(this.int_0);
			}

			// Token: 0x04000154 RID: 340
			private int int_0;

			// Token: 0x04000155 RID: 341
			private Class2106 class2106_0;
		}

		// Token: 0x02000073 RID: 115
		public sealed class Class1413 : IEnumerable
		{
			// Token: 0x0600024B RID: 587 RVA: 0x000058DF File Offset: 0x00003ADF
			public void method_0(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x0005B458 File Offset: 0x00059658
			public Class2106.Class1414 method_1()
			{
				return new Class2106.Class1414(this.class2106_0);
			}

			// Token: 0x0600024D RID: 589 RVA: 0x0005B474 File Offset: 0x00059674
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000156 RID: 342
			private Class2106 class2106_0;
		}

		// Token: 0x02000074 RID: 116
		public sealed class Class1414 : IEnumerator
		{
			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600024F RID: 591 RVA: 0x0005B48C File Offset: 0x0005968C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000250 RID: 592 RVA: 0x000058E8 File Offset: 0x00003AE8
			public Class1414(Class2106 class2106_1)
			{
				this.class2106_0 = class2106_1;
				this.int_0 = -1;
			}

			// Token: 0x06000251 RID: 593 RVA: 0x000058FE File Offset: 0x00003AFE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000252 RID: 594 RVA: 0x00005907 File Offset: 0x00003B07
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2106_0.method_6();
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0005B4A4 File Offset: 0x000596A4
			public Class2126 method_0()
			{
				return this.class2106_0.method_7(this.int_0);
			}

			// Token: 0x04000157 RID: 343
			private int int_0;

			// Token: 0x04000158 RID: 344
			private Class2106 class2106_0;
		}
	}
}
