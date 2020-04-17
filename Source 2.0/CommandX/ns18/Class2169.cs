using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x02000302 RID: 770
	public sealed class Class2169 : Class2059
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x0000D634 File Offset: 0x0000B834
		public Class2169()
		{
			this.method_6();
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000D658 File Offset: 0x0000B858
		public Class2169(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000816B8 File Offset: 0x0007F8B8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "min");
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000816D8 File Offset: 0x0007F8D8
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "min", int_0)));
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00081704 File Offset: 0x0007F904
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "max");
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00081724 File Offset: 0x0007F924
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "max", int_0)));
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0000D67D File Offset: 0x0000B87D
		private void method_6()
		{
			this.class1883_0.method_0(this);
			this.class1885_0.method_0(this);
		}

		// Token: 0x04000762 RID: 1890
		public Class2169.Class1883 class1883_0 = new Class2169.Class1883();

		// Token: 0x04000763 RID: 1891
		public Class2169.Class1885 class1885_0 = new Class2169.Class1885();

		// Token: 0x02000303 RID: 771
		public sealed class Class1883 : IEnumerable
		{
			// Token: 0x060011FB RID: 4603 RVA: 0x0000D697 File Offset: 0x0000B897
			public void method_0(Class2169 class2169_1)
			{
				this.class2169_0 = class2169_1;
			}

			// Token: 0x060011FC RID: 4604 RVA: 0x00081750 File Offset: 0x0007F950
			public Class2169.Class1884 method_1()
			{
				return new Class2169.Class1884(this.class2169_0);
			}

			// Token: 0x060011FD RID: 4605 RVA: 0x0008176C File Offset: 0x0007F96C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000764 RID: 1892
			private Class2169 class2169_0;
		}

		// Token: 0x02000304 RID: 772
		public sealed class Class1884 : IEnumerator
		{
			// Token: 0x17000192 RID: 402
			// (get) Token: 0x060011FF RID: 4607 RVA: 0x00081784 File Offset: 0x0007F984
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
			public Class1884(Class2169 class2169_1)
			{
				this.class2169_0 = class2169_1;
				this.int_0 = -1;
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x0000D6B6 File Offset: 0x0000B8B6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001202 RID: 4610 RVA: 0x0000D6BF File Offset: 0x0000B8BF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2169_0.method_2();
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x0008179C File Offset: 0x0007F99C
			public Class2050 method_0()
			{
				return this.class2169_0.method_3(this.int_0);
			}

			// Token: 0x04000765 RID: 1893
			private int int_0;

			// Token: 0x04000766 RID: 1894
			private Class2169 class2169_0;
		}

		// Token: 0x02000305 RID: 773
		public sealed class Class1885 : IEnumerable
		{
			// Token: 0x06001204 RID: 4612 RVA: 0x0000D6E2 File Offset: 0x0000B8E2
			public void method_0(Class2169 class2169_1)
			{
				this.class2169_0 = class2169_1;
			}

			// Token: 0x06001205 RID: 4613 RVA: 0x000817BC File Offset: 0x0007F9BC
			public Class2169.Class1886 method_1()
			{
				return new Class2169.Class1886(this.class2169_0);
			}

			// Token: 0x06001206 RID: 4614 RVA: 0x000817D8 File Offset: 0x0007F9D8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000767 RID: 1895
			private Class2169 class2169_0;
		}

		// Token: 0x02000306 RID: 774
		public sealed class Class1886 : IEnumerator
		{
			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06001208 RID: 4616 RVA: 0x000817F0 File Offset: 0x0007F9F0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001209 RID: 4617 RVA: 0x0000D6EB File Offset: 0x0000B8EB
			public Class1886(Class2169 class2169_1)
			{
				this.class2169_0 = class2169_1;
				this.int_0 = -1;
			}

			// Token: 0x0600120A RID: 4618 RVA: 0x0000D701 File Offset: 0x0000B901
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600120B RID: 4619 RVA: 0x0000D70A File Offset: 0x0000B90A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2169_0.method_4();
			}

			// Token: 0x0600120C RID: 4620 RVA: 0x00081808 File Offset: 0x0007FA08
			public Class2050 method_0()
			{
				return this.class2169_0.method_5(this.int_0);
			}

			// Token: 0x04000768 RID: 1896
			private int int_0;

			// Token: 0x04000769 RID: 1897
			private Class2169 class2169_0;
		}
	}
}
