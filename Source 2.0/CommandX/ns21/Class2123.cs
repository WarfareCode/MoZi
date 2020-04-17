using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000F5 RID: 245
	public sealed class Class2123 : Class2059
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0005FD64 File Offset: 0x0005DF64
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00006533 File Offset: 0x00004733
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

		// Token: 0x0600052B RID: 1323 RVA: 0x00006E15 File Offset: 0x00005015
		public Class2123()
		{
			this.method_4();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00006E2E File Offset: 0x0000502E
		public Class2123(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000659C4 File Offset: 0x00063BC4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "vocabulary");
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000659E4 File Offset: 0x00063BE4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "vocabulary", int_0)));
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00006E48 File Offset: 0x00005048
		private void method_4()
		{
			this.class1511_0.method_0(this);
		}

		// Token: 0x0400026A RID: 618
		public Class2123.Class1511 class1511_0 = new Class2123.Class1511();

		// Token: 0x020000F6 RID: 246
		public sealed class Class1511 : IEnumerable
		{
			// Token: 0x06000530 RID: 1328 RVA: 0x00006E56 File Offset: 0x00005056
			public void method_0(Class2123 class2123_1)
			{
				this.class2123_0 = class2123_1;
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00065A10 File Offset: 0x00063C10
			public Class2123.Class1512 method_1()
			{
				return new Class2123.Class1512(this.class2123_0);
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00065A2C File Offset: 0x00063C2C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400026B RID: 619
			private Class2123 class2123_0;
		}

		// Token: 0x020000F7 RID: 247
		public sealed class Class1512 : IEnumerator
		{
			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x00065A44 File Offset: 0x00063C44
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00006E5F File Offset: 0x0000505F
			public Class1512(Class2123 class2123_1)
			{
				this.class2123_0 = class2123_1;
				this.int_0 = -1;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00006E75 File Offset: 0x00005075
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00006E7E File Offset: 0x0000507E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2123_0.method_2();
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x00065A5C File Offset: 0x00063C5C
			public Class2050 method_0()
			{
				return this.class2123_0.method_3(this.int_0);
			}

			// Token: 0x0400026C RID: 620
			private int int_0;

			// Token: 0x0400026D RID: 621
			private Class2123 class2123_0;
		}
	}
}
