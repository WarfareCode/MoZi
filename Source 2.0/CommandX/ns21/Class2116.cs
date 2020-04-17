using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000D5 RID: 213
	public sealed class Class2116 : Class2059
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00006753 File Offset: 0x00004953
		public Class2116()
		{
			this.method_4();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000676C File Offset: 0x0000496C
		public Class2116(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00006786 File Offset: 0x00004986
		private void method_4()
		{
			this.class1487_0.method_0(this);
		}

		// Token: 0x0400022B RID: 555
		public Class2116.Class1487 class1487_0 = new Class2116.Class1487();

		// Token: 0x020000D6 RID: 214
		public sealed class Class1487 : IEnumerable
		{
			// Token: 0x06000441 RID: 1089 RVA: 0x00006794 File Offset: 0x00004994
			public void method_0(Class2116 class2116_1)
			{
				this.class2116_0 = class2116_1;
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x00060374 File Offset: 0x0005E574
			public Class2116.Class1488 method_1()
			{
				return new Class2116.Class1488(this.class2116_0);
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00060390 File Offset: 0x0005E590
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400022C RID: 556
			private Class2116 class2116_0;
		}

		// Token: 0x020000D7 RID: 215
		public sealed class Class1488 : IEnumerator
		{
			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000603A8 File Offset: 0x0005E5A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x0000679D File Offset: 0x0000499D
			public Class1488(Class2116 class2116_1)
			{
				this.class2116_0 = class2116_1;
				this.int_0 = -1;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x000067B3 File Offset: 0x000049B3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x000067BC File Offset: 0x000049BC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2116_0.method_2();
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000603C0 File Offset: 0x0005E5C0
			public Class2050 method_0()
			{
				return this.class2116_0.method_3(this.int_0);
			}

			// Token: 0x0400022D RID: 557
			private int int_0;

			// Token: 0x0400022E RID: 558
			private Class2116 class2116_0;
		}
	}
}
