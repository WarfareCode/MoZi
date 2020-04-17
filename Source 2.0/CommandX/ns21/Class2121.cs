using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000EF RID: 239
	public sealed class Class2121 : Class2059
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0005FD64 File Offset: 0x0005DF64
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00006533 File Offset: 0x00004733
		public Class2050 Value
		{
			get
			{
				return new Class2050(Class2059.smethod_0(this.xmlNode_0));
			}
			set
			{
				Class2059.smethod_1(this.xmlNode_0, value.ToString());
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00006CFD File Offset: 0x00004EFD
		public Class2121()
		{
			this.method_4();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00006D16 File Offset: 0x00004F16
		public Class2121(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00065858 File Offset: 0x00063A58
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "authority");
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00065878 File Offset: 0x00063A78
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "authority", int_0)));
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00006D30 File Offset: 0x00004F30
		private void method_4()
		{
			this.class1507_0.method_0(this);
		}

		// Token: 0x04000262 RID: 610
		public Class2121.Class1507 class1507_0 = new Class2121.Class1507();

		// Token: 0x020000F0 RID: 240
		public sealed class Class1507 : IEnumerable
		{
			// Token: 0x06000512 RID: 1298 RVA: 0x00006D3E File Offset: 0x00004F3E
			public void method_0(Class2121 class2121_1)
			{
				this.class2121_0 = class2121_1;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x000658A4 File Offset: 0x00063AA4
			public Class2121.Class1508 method_1()
			{
				return new Class2121.Class1508(this.class2121_0);
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x000658C0 File Offset: 0x00063AC0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000263 RID: 611
			private Class2121 class2121_0;
		}

		// Token: 0x020000F1 RID: 241
		public sealed class Class1508 : IEnumerator
		{
			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x000658D8 File Offset: 0x00063AD8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00006D47 File Offset: 0x00004F47
			public Class1508(Class2121 class2121_1)
			{
				this.class2121_0 = class2121_1;
				this.int_0 = -1;
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x00006D5D File Offset: 0x00004F5D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x00006D66 File Offset: 0x00004F66
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2121_0.method_2();
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x000658F0 File Offset: 0x00063AF0
			public Class2050 method_0()
			{
				return this.class2121_0.method_3(this.int_0);
			}

			// Token: 0x04000264 RID: 612
			private int int_0;

			// Token: 0x04000265 RID: 613
			private Class2121 class2121_0;
		}
	}
}
