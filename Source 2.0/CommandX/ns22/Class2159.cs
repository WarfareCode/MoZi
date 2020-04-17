using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000273 RID: 627
	public sealed class Class2159 : Class2059
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public Class2159()
		{
			this.method_4();
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0000BBC5 File Offset: 0x00009DC5
		public Class2159(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0007B950 File Offset: 0x00079B50
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Keyword");
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0007B970 File Offset: 0x00079B70
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Keyword", int_0)));
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0000BBDF File Offset: 0x00009DDF
		private void method_4()
		{
			this.class1777_0.method_0(this);
		}

		// Token: 0x0400060A RID: 1546
		public Class2159.Class1777 class1777_0 = new Class2159.Class1777();

		// Token: 0x02000274 RID: 628
		public sealed class Class1777 : IEnumerable
		{
			// Token: 0x06000E92 RID: 3730 RVA: 0x0000BBED File Offset: 0x00009DED
			public void method_0(Class2159 class2159_1)
			{
				this.class2159_0 = class2159_1;
			}

			// Token: 0x06000E93 RID: 3731 RVA: 0x0007B99C File Offset: 0x00079B9C
			public Class2159.Class1778 method_1()
			{
				return new Class2159.Class1778(this.class2159_0);
			}

			// Token: 0x06000E94 RID: 3732 RVA: 0x0007B9B8 File Offset: 0x00079BB8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400060B RID: 1547
			private Class2159 class2159_0;
		}

		// Token: 0x02000275 RID: 629
		public sealed class Class1778 : IEnumerator
		{
			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0007B9D0 File Offset: 0x00079BD0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E97 RID: 3735 RVA: 0x0000BBF6 File Offset: 0x00009DF6
			public Class1778(Class2159 class2159_1)
			{
				this.class2159_0 = class2159_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E98 RID: 3736 RVA: 0x0000BC0C File Offset: 0x00009E0C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E99 RID: 3737 RVA: 0x0000BC15 File Offset: 0x00009E15
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2159_0.method_2();
			}

			// Token: 0x06000E9A RID: 3738 RVA: 0x0007B9E8 File Offset: 0x00079BE8
			public Class2050 method_0()
			{
				return this.class2159_0.method_3(this.int_0);
			}

			// Token: 0x0400060C RID: 1548
			private int int_0;

			// Token: 0x0400060D RID: 1549
			private Class2159 class2159_0;
		}
	}
}
