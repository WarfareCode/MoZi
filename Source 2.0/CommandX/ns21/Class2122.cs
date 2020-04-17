using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000F2 RID: 242
	public sealed class Class2122 : Class2059
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00006D89 File Offset: 0x00004F89
		public Class2122()
		{
			this.method_4();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00006DA2 File Offset: 0x00004FA2
		public Class2122(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00065910 File Offset: 0x00063B10
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Keyword");
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00065930 File Offset: 0x00063B30
		public Class2123 method_3(int int_0)
		{
			return new Class2123(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Keyword", int_0));
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00006DBC File Offset: 0x00004FBC
		private void method_4()
		{
			this.class1509_0.method_0(this);
		}

		// Token: 0x04000266 RID: 614
		public Class2122.Class1509 class1509_0 = new Class2122.Class1509();

		// Token: 0x020000F3 RID: 243
		public sealed class Class1509 : IEnumerable
		{
			// Token: 0x06000520 RID: 1312 RVA: 0x00006DCA File Offset: 0x00004FCA
			public void method_0(Class2122 class2122_1)
			{
				this.class2122_0 = class2122_1;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00065958 File Offset: 0x00063B58
			public Class2122.Class1510 method_1()
			{
				return new Class2122.Class1510(this.class2122_0);
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00065974 File Offset: 0x00063B74
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000267 RID: 615
			private Class2122 class2122_0;
		}

		// Token: 0x020000F4 RID: 244
		public sealed class Class1510 : IEnumerator
		{
			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000524 RID: 1316 RVA: 0x0006598C File Offset: 0x00063B8C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00006DD3 File Offset: 0x00004FD3
			public Class1510(Class2122 class2122_1)
			{
				this.class2122_0 = class2122_1;
				this.int_0 = -1;
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x00006DE9 File Offset: 0x00004FE9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00006DF2 File Offset: 0x00004FF2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2122_0.method_2();
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x000659A4 File Offset: 0x00063BA4
			public Class2123 method_0()
			{
				return this.class2122_0.method_3(this.int_0);
			}

			// Token: 0x04000268 RID: 616
			private int int_0;

			// Token: 0x04000269 RID: 617
			private Class2122 class2122_0;
		}
	}
}
