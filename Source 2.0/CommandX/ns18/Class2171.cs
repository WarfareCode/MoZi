using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x0200031B RID: 795
	public sealed class Class2171 : Class2059
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		public Class2171()
		{
			this.method_6();
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		public Class2171(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0000DB19 File Offset: 0x0000BD19
		private void method_6()
		{
			this.class1903_0.method_0(this);
			this.class1905_0.method_0(this);
		}

		// Token: 0x040007C5 RID: 1989
		public Class2171.Class1903 class1903_0 = new Class2171.Class1903();

		// Token: 0x040007C6 RID: 1990
		public Class2171.Class1905 class1905_0 = new Class2171.Class1905();

		// Token: 0x0200031C RID: 796
		public sealed class Class1903 : IEnumerable
		{
			// Token: 0x060012B8 RID: 4792 RVA: 0x0000DB33 File Offset: 0x0000BD33
			public void method_0(Class2171 class2171_1)
			{
				this.class2171_0 = class2171_1;
			}

			// Token: 0x060012B9 RID: 4793 RVA: 0x00083ADC File Offset: 0x00081CDC
			public Class2171.Class1904 method_1()
			{
				return new Class2171.Class1904(this.class2171_0);
			}

			// Token: 0x060012BA RID: 4794 RVA: 0x00083AF8 File Offset: 0x00081CF8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007C7 RID: 1991
			private Class2171 class2171_0;
		}

		// Token: 0x0200031D RID: 797
		public sealed class Class1904 : IEnumerator
		{
			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00083B10 File Offset: 0x00081D10
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060012BD RID: 4797 RVA: 0x0000DB3C File Offset: 0x0000BD3C
			public Class1904(Class2171 class2171_1)
			{
				this.class2171_0 = class2171_1;
				this.int_0 = -1;
			}

			// Token: 0x060012BE RID: 4798 RVA: 0x0000DB52 File Offset: 0x0000BD52
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060012BF RID: 4799 RVA: 0x0000DB5B File Offset: 0x0000BD5B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2171_0.method_2();
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x00083B28 File Offset: 0x00081D28
			public Class2050 method_0()
			{
				return this.class2171_0.method_3(this.int_0);
			}

			// Token: 0x040007C8 RID: 1992
			private int int_0;

			// Token: 0x040007C9 RID: 1993
			private Class2171 class2171_0;
		}

		// Token: 0x0200031E RID: 798
		public sealed class Class1905 : IEnumerable
		{
			// Token: 0x060012C1 RID: 4801 RVA: 0x0000DB7E File Offset: 0x0000BD7E
			public void method_0(Class2171 class2171_1)
			{
				this.class2171_0 = class2171_1;
			}

			// Token: 0x060012C2 RID: 4802 RVA: 0x00083B48 File Offset: 0x00081D48
			public Class2171.Class1906 method_1()
			{
				return new Class2171.Class1906(this.class2171_0);
			}

			// Token: 0x060012C3 RID: 4803 RVA: 0x00083B64 File Offset: 0x00081D64
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007CA RID: 1994
			private Class2171 class2171_0;
		}

		// Token: 0x0200031F RID: 799
		public sealed class Class1906 : IEnumerator
		{
			// Token: 0x1700019F RID: 415
			// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00083B7C File Offset: 0x00081D7C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060012C6 RID: 4806 RVA: 0x0000DB87 File Offset: 0x0000BD87
			public Class1906(Class2171 class2171_1)
			{
				this.class2171_0 = class2171_1;
				this.int_0 = -1;
			}

			// Token: 0x060012C7 RID: 4807 RVA: 0x0000DB9D File Offset: 0x0000BD9D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060012C8 RID: 4808 RVA: 0x0000DBA6 File Offset: 0x0000BDA6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2171_0.method_4();
			}

			// Token: 0x060012C9 RID: 4809 RVA: 0x00083B94 File Offset: 0x00081D94
			public Class2165 method_0()
			{
				return this.class2171_0.method_5(this.int_0);
			}

			// Token: 0x040007CB RID: 1995
			private int int_0;

			// Token: 0x040007CC RID: 1996
			private Class2171 class2171_0;
		}
	}
}
