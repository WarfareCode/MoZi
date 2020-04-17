using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x02000268 RID: 616
	public sealed class Class2157 : Class2059
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x0000B8AC File Offset: 0x00009AAC
		public Class2157()
		{
			this.method_6();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public Class2157(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0007B1E4 File Offset: 0x000793E4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Get");
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0007B204 File Offset: 0x00079404
		public Class2156 method_3(int int_0)
		{
			return new Class2156(base.method_1(Class2059.Enum155.const_1, "", "Get", int_0));
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0007B22C File Offset: 0x0007942C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Post");
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0007B24C File Offset: 0x0007944C
		public Class2166 method_5(int int_0)
		{
			return new Class2166(base.method_1(Class2059.Enum155.const_1, "", "Post", int_0));
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0000B8F5 File Offset: 0x00009AF5
		private void method_6()
		{
			this.class1771_0.method_0(this);
			this.class1773_0.method_0(this);
		}

		// Token: 0x040005F7 RID: 1527
		public Class2157.Class1771 class1771_0 = new Class2157.Class1771();

		// Token: 0x040005F8 RID: 1528
		public Class2157.Class1773 class1773_0 = new Class2157.Class1773();

		// Token: 0x02000269 RID: 617
		public sealed class Class1771 : IEnumerable
		{
			// Token: 0x06000E46 RID: 3654 RVA: 0x0000B90F File Offset: 0x00009B0F
			public void method_0(Class2157 class2157_1)
			{
				this.class2157_0 = class2157_1;
			}

			// Token: 0x06000E47 RID: 3655 RVA: 0x0007B274 File Offset: 0x00079474
			public Class2157.Class1772 method_1()
			{
				return new Class2157.Class1772(this.class2157_0);
			}

			// Token: 0x06000E48 RID: 3656 RVA: 0x0007B290 File Offset: 0x00079490
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005F9 RID: 1529
			private Class2157 class2157_0;
		}

		// Token: 0x0200026A RID: 618
		public sealed class Class1772 : IEnumerator
		{
			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0007B2A8 File Offset: 0x000794A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x0000B918 File Offset: 0x00009B18
			public Class1772(Class2157 class2157_1)
			{
				this.class2157_0 = class2157_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E4C RID: 3660 RVA: 0x0000B92E File Offset: 0x00009B2E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E4D RID: 3661 RVA: 0x0000B937 File Offset: 0x00009B37
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2157_0.method_2();
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x0007B2C0 File Offset: 0x000794C0
			public Class2156 method_0()
			{
				return this.class2157_0.method_3(this.int_0);
			}

			// Token: 0x040005FA RID: 1530
			private int int_0;

			// Token: 0x040005FB RID: 1531
			private Class2157 class2157_0;
		}

		// Token: 0x0200026B RID: 619
		public sealed class Class1773 : IEnumerable
		{
			// Token: 0x06000E4F RID: 3663 RVA: 0x0000B95A File Offset: 0x00009B5A
			public void method_0(Class2157 class2157_1)
			{
				this.class2157_0 = class2157_1;
			}

			// Token: 0x06000E50 RID: 3664 RVA: 0x0007B2E0 File Offset: 0x000794E0
			public Class2157.Class1774 method_1()
			{
				return new Class2157.Class1774(this.class2157_0);
			}

			// Token: 0x06000E51 RID: 3665 RVA: 0x0007B2FC File Offset: 0x000794FC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005FC RID: 1532
			private Class2157 class2157_0;
		}

		// Token: 0x0200026C RID: 620
		public sealed class Class1774 : IEnumerator
		{
			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0007B314 File Offset: 0x00079514
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E54 RID: 3668 RVA: 0x0000B963 File Offset: 0x00009B63
			public Class1774(Class2157 class2157_1)
			{
				this.class2157_0 = class2157_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E55 RID: 3669 RVA: 0x0000B979 File Offset: 0x00009B79
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E56 RID: 3670 RVA: 0x0000B982 File Offset: 0x00009B82
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2157_0.method_4();
			}

			// Token: 0x06000E57 RID: 3671 RVA: 0x0007B32C File Offset: 0x0007952C
			public Class2166 method_0()
			{
				return this.class2157_0.method_5(this.int_0);
			}

			// Token: 0x040005FD RID: 1533
			private int int_0;

			// Token: 0x040005FE RID: 1534
			private Class2157 class2157_0;
		}
	}
}
