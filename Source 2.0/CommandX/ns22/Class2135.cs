using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x020001B3 RID: 435
	public sealed class Class2135 : Class2059
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x000090F5 File Offset: 0x000072F5
		public Class2135()
		{
			this.method_6();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00009119 File Offset: 0x00007319
		public Class2135(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000913E File Offset: 0x0000733E
		private void method_6()
		{
			this.class1647_0.method_0(this);
			this.class1649_0.method_0(this);
		}

		// Token: 0x040003FB RID: 1019
		public Class2135.Class1647 class1647_0 = new Class2135.Class1647();

		// Token: 0x040003FC RID: 1020
		public Class2135.Class1649 class1649_0 = new Class2135.Class1649();

		// Token: 0x020001B4 RID: 436
		public sealed class Class1647 : IEnumerable
		{
			// Token: 0x0600099A RID: 2458 RVA: 0x00009158 File Offset: 0x00007358
			public void method_0(Class2135 class2135_1)
			{
				this.class2135_0 = class2135_1;
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x0006CA10 File Offset: 0x0006AC10
			public Class2135.Class1648 method_1()
			{
				return new Class2135.Class1648(this.class2135_0);
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x0006CA2C File Offset: 0x0006AC2C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040003FD RID: 1021
			private Class2135 class2135_0;
		}

		// Token: 0x020001B5 RID: 437
		public sealed class Class1648 : IEnumerator
		{
			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x0600099E RID: 2462 RVA: 0x0006CA44 File Offset: 0x0006AC44
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x00009161 File Offset: 0x00007361
			public Class1648(Class2135 class2135_1)
			{
				this.class2135_0 = class2135_1;
				this.int_0 = -1;
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x00009177 File Offset: 0x00007377
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00009180 File Offset: 0x00007380
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2135_0.method_2();
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x0006CA5C File Offset: 0x0006AC5C
			public Class2050 method_0()
			{
				return this.class2135_0.method_3(this.int_0);
			}

			// Token: 0x040003FE RID: 1022
			private int int_0;

			// Token: 0x040003FF RID: 1023
			private Class2135 class2135_0;
		}

		// Token: 0x020001B6 RID: 438
		public sealed class Class1649 : IEnumerable
		{
			// Token: 0x060009A3 RID: 2467 RVA: 0x000091A3 File Offset: 0x000073A3
			public void method_0(Class2135 class2135_1)
			{
				this.class2135_0 = class2135_1;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x0006CA7C File Offset: 0x0006AC7C
			public Class2135.Class1650 method_1()
			{
				return new Class2135.Class1650(this.class2135_0);
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x0006CA98 File Offset: 0x0006AC98
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000400 RID: 1024
			private Class2135 class2135_0;
		}

		// Token: 0x020001B7 RID: 439
		public sealed class Class1650 : IEnumerator
		{
			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x000091AC File Offset: 0x000073AC
			public Class1650(Class2135 class2135_1)
			{
				this.class2135_0 = class2135_1;
				this.int_0 = -1;
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x000091C2 File Offset: 0x000073C2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x000091CB File Offset: 0x000073CB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2135_0.method_4();
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
			public Class2128 method_0()
			{
				return this.class2135_0.method_5(this.int_0);
			}

			// Token: 0x04000401 RID: 1025
			private int int_0;

			// Token: 0x04000402 RID: 1026
			private Class2135 class2135_0;
		}
	}
}
