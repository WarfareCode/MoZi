using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000C3 RID: 195
	public sealed class Class2114 : Class2059
	{
		// Token: 0x060003DC RID: 988 RVA: 0x000064A7 File Offset: 0x000046A7
		public Class2114()
		{
			this.method_4();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000064C0 File Offset: 0x000046C0
		public Class2114(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0005FCB0 File Offset: 0x0005DEB0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "HTTP");
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		public Class2120 method_3(int int_0)
		{
			return new Class2120(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "HTTP", int_0));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000064DA File Offset: 0x000046DA
		private void method_4()
		{
			this.class1471_0.method_0(this);
		}

		// Token: 0x0400020B RID: 523
		public Class2114.Class1471 class1471_0 = new Class2114.Class1471();

		// Token: 0x020000C4 RID: 196
		public sealed class Class1471 : IEnumerable
		{
			// Token: 0x060003E1 RID: 993 RVA: 0x000064E8 File Offset: 0x000046E8
			public void method_0(Class2114 class2114_1)
			{
				this.class2114_0 = class2114_1;
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0005FCF8 File Offset: 0x0005DEF8
			public Class2114.Class1472 method_1()
			{
				return new Class2114.Class1472(this.class2114_0);
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0005FD14 File Offset: 0x0005DF14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400020C RID: 524
			private Class2114 class2114_0;
		}

		// Token: 0x020000C5 RID: 197
		public sealed class Class1472 : IEnumerator
		{
			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x0005FD2C File Offset: 0x0005DF2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x000064F1 File Offset: 0x000046F1
			public Class1472(Class2114 class2114_1)
			{
				this.class2114_0 = class2114_1;
				this.int_0 = -1;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00006507 File Offset: 0x00004707
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00006510 File Offset: 0x00004710
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2114_0.method_2();
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x0005FD44 File Offset: 0x0005DF44
			public Class2120 method_0()
			{
				return this.class2114_0.method_3(this.int_0);
			}

			// Token: 0x0400020D RID: 525
			private int int_0;

			// Token: 0x0400020E RID: 526
			private Class2114 class2114_0;
		}
	}
}
