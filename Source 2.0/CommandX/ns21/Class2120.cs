using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns21
{
	// Token: 0x020000EA RID: 234
	public sealed class Class2120 : Class2059
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00006C04 File Offset: 0x00004E04
		public Class2120()
		{
			this.method_6();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00006C28 File Offset: 0x00004E28
		public Class2120(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000656F0 File Offset: 0x000638F0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Get");
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00065710 File Offset: 0x00063910
		public Class2119 method_3(int int_0)
		{
			return new Class2119(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Get", int_0));
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00065738 File Offset: 0x00063938
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Post");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00065758 File Offset: 0x00063958
		public Class2130 method_5(int int_0)
		{
			return new Class2130(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Post", int_0));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00006C4D File Offset: 0x00004E4D
		private void method_6()
		{
			this.class1503_0.method_0(this);
			this.class1505_0.method_0(this);
		}

		// Token: 0x0400025A RID: 602
		public Class2120.Class1503 class1503_0 = new Class2120.Class1503();

		// Token: 0x0400025B RID: 603
		public Class2120.Class1505 class1505_0 = new Class2120.Class1505();

		// Token: 0x020000EB RID: 235
		public sealed class Class1503 : IEnumerable
		{
			// Token: 0x060004F9 RID: 1273 RVA: 0x00006C67 File Offset: 0x00004E67
			public void method_0(Class2120 class2120_1)
			{
				this.class2120_0 = class2120_1;
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x00065780 File Offset: 0x00063980
			public Class2120.Class1504 method_1()
			{
				return new Class2120.Class1504(this.class2120_0);
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0006579C File Offset: 0x0006399C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400025C RID: 604
			private Class2120 class2120_0;
		}

		// Token: 0x020000EC RID: 236
		public sealed class Class1504 : IEnumerator
		{
			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060004FD RID: 1277 RVA: 0x000657B4 File Offset: 0x000639B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00006C70 File Offset: 0x00004E70
			public Class1504(Class2120 class2120_1)
			{
				this.class2120_0 = class2120_1;
				this.int_0 = -1;
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00006C86 File Offset: 0x00004E86
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00006C8F File Offset: 0x00004E8F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2120_0.method_2();
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x000657CC File Offset: 0x000639CC
			public Class2119 method_0()
			{
				return this.class2120_0.method_3(this.int_0);
			}

			// Token: 0x0400025D RID: 605
			private int int_0;

			// Token: 0x0400025E RID: 606
			private Class2120 class2120_0;
		}

		// Token: 0x020000ED RID: 237
		public sealed class Class1505 : IEnumerable
		{
			// Token: 0x06000502 RID: 1282 RVA: 0x00006CB2 File Offset: 0x00004EB2
			public void method_0(Class2120 class2120_1)
			{
				this.class2120_0 = class2120_1;
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x000657EC File Offset: 0x000639EC
			public Class2120.Class1506 method_1()
			{
				return new Class2120.Class1506(this.class2120_0);
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x00065808 File Offset: 0x00063A08
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400025F RID: 607
			private Class2120 class2120_0;
		}

		// Token: 0x020000EE RID: 238
		public sealed class Class1506 : IEnumerator
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000506 RID: 1286 RVA: 0x00065820 File Offset: 0x00063A20
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x00006CBB File Offset: 0x00004EBB
			public Class1506(Class2120 class2120_1)
			{
				this.class2120_0 = class2120_1;
				this.int_0 = -1;
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00006CD1 File Offset: 0x00004ED1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00006CDA File Offset: 0x00004EDA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2120_0.method_4();
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00065838 File Offset: 0x00063A38
			public Class2130 method_0()
			{
				return this.class2120_0.method_5(this.int_0);
			}

			// Token: 0x04000260 RID: 608
			private int int_0;

			// Token: 0x04000261 RID: 609
			private Class2120 class2120_0;
		}
	}
}
