using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x02000263 RID: 611
	public sealed class Class2156 : Class2059
	{
		// Token: 0x06000E31 RID: 3633 RVA: 0x0000B820 File Offset: 0x00009A20
		public Class2156()
		{
			this.method_4();
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0000B839 File Offset: 0x00009A39
		public Class2156(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_3(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0000B853 File Offset: 0x00009A53
		private void method_4()
		{
			this.class1769_0.method_0(this);
		}

		// Token: 0x040005E8 RID: 1512
		public Class2156.Class1769 class1769_0 = new Class2156.Class1769();

		// Token: 0x02000264 RID: 612
		public sealed class Class1769 : IEnumerable
		{
			// Token: 0x06000E36 RID: 3638 RVA: 0x0000B861 File Offset: 0x00009A61
			public void method_0(Class2156 class2156_1)
			{
				this.class2156_0 = class2156_1;
			}

			// Token: 0x06000E37 RID: 3639 RVA: 0x0007B178 File Offset: 0x00079378
			public Class2156.Class1770 method_1()
			{
				return new Class2156.Class1770(this.class2156_0);
			}

			// Token: 0x06000E38 RID: 3640 RVA: 0x0007B194 File Offset: 0x00079394
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005E9 RID: 1513
			private Class2156 class2156_0;
		}

		// Token: 0x02000265 RID: 613
		public sealed class Class1770 : IEnumerator
		{
			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0007B1AC File Offset: 0x000793AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E3B RID: 3643 RVA: 0x0000B86A File Offset: 0x00009A6A
			public Class1770(Class2156 class2156_1)
			{
				this.class2156_0 = class2156_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E3C RID: 3644 RVA: 0x0000B880 File Offset: 0x00009A80
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E3D RID: 3645 RVA: 0x0000B889 File Offset: 0x00009A89
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2156_0.method_2();
			}

			// Token: 0x06000E3E RID: 3646 RVA: 0x0007B1C4 File Offset: 0x000793C4
			public Class2165 method_0()
			{
				return this.class2156_0.method_3(this.int_0);
			}

			// Token: 0x040005EA RID: 1514
			private int int_0;

			// Token: 0x040005EB RID: 1515
			private Class2156 class2156_0;
		}
	}
}
