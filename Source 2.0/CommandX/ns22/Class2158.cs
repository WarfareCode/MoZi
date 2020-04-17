using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x0200026D RID: 621
	public sealed class Class2158 : Class2059
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x0000B9A5 File Offset: 0x00009BA5
		public Class2158()
		{
			this.method_4();
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0000B9BE File Offset: 0x00009BBE
		public Class2158(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00065858 File Offset: 0x00063A58
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "authority");
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00065878 File Offset: 0x00063A78
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "authority", int_0)));
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0000B9D8 File Offset: 0x00009BD8
		private void method_4()
		{
			this.class1775_0.method_0(this);
		}

		// Token: 0x040005FF RID: 1535
		public Class2158.Class1775 class1775_0 = new Class2158.Class1775();

		// Token: 0x0200026E RID: 622
		public sealed class Class1775 : IEnumerable
		{
			// Token: 0x06000E5D RID: 3677 RVA: 0x0000B9E6 File Offset: 0x00009BE6
			public void method_0(Class2158 class2158_1)
			{
				this.class2158_0 = class2158_1;
			}

			// Token: 0x06000E5E RID: 3678 RVA: 0x0007B34C File Offset: 0x0007954C
			public Class2158.Class1776 method_1()
			{
				return new Class2158.Class1776(this.class2158_0);
			}

			// Token: 0x06000E5F RID: 3679 RVA: 0x0007B368 File Offset: 0x00079568
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000600 RID: 1536
			private Class2158 class2158_0;
		}

		// Token: 0x0200026F RID: 623
		public sealed class Class1776 : IEnumerator
		{
			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0007B380 File Offset: 0x00079580
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E62 RID: 3682 RVA: 0x0000B9EF File Offset: 0x00009BEF
			public Class1776(Class2158 class2158_1)
			{
				this.class2158_0 = class2158_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E63 RID: 3683 RVA: 0x0000BA05 File Offset: 0x00009C05
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E64 RID: 3684 RVA: 0x0000BA0E File Offset: 0x00009C0E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2158_0.method_2();
			}

			// Token: 0x06000E65 RID: 3685 RVA: 0x0007B398 File Offset: 0x00079598
			public Class2050 method_0()
			{
				return this.class2158_0.method_3(this.int_0);
			}

			// Token: 0x04000601 RID: 1537
			private int int_0;

			// Token: 0x04000602 RID: 1538
			private Class2158 class2158_0;
		}
	}
}
