using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000221 RID: 545
	public sealed class Class2145 : Class2059
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x0000AA18 File Offset: 0x00008C18
		public Class2145()
		{
			this.method_4();
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0000AA31 File Offset: 0x00008C31
		public Class2145(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00079B10 File Offset: 0x00077D10
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "HTTP");
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00079B30 File Offset: 0x00077D30
		public Class2157 method_3(int int_0)
		{
			return new Class2157(base.method_1(Class2059.Enum155.const_1, "", "HTTP", int_0));
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0000AA4B File Offset: 0x00008C4B
		private void method_4()
		{
			this.class1725_0.method_0(this);
		}

		// Token: 0x0400057B RID: 1403
		public Class2145.Class1725 class1725_0 = new Class2145.Class1725();

		// Token: 0x02000222 RID: 546
		public sealed class Class1725 : IEnumerable
		{
			// Token: 0x06000CC7 RID: 3271 RVA: 0x0000AA59 File Offset: 0x00008C59
			public void method_0(Class2145 class2145_1)
			{
				this.class2145_0 = class2145_1;
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00079B58 File Offset: 0x00077D58
			public Class2145.Class1726 method_1()
			{
				return new Class2145.Class1726(this.class2145_0);
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x00079B74 File Offset: 0x00077D74
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400057C RID: 1404
			private Class2145 class2145_0;
		}

		// Token: 0x02000223 RID: 547
		public sealed class Class1726 : IEnumerator
		{
			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00079B8C File Offset: 0x00077D8C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x0000AA62 File Offset: 0x00008C62
			public Class1726(Class2145 class2145_1)
			{
				this.class2145_0 = class2145_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x0000AA78 File Offset: 0x00008C78
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x0000AA81 File Offset: 0x00008C81
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2145_0.method_2();
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00079BA4 File Offset: 0x00077DA4
			public Class2157 method_0()
			{
				return this.class2145_0.method_3(this.int_0);
			}

			// Token: 0x0400057D RID: 1405
			private int int_0;

			// Token: 0x0400057E RID: 1406
			private Class2145 class2145_0;
		}
	}
}
