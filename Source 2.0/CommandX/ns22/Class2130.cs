using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x02000173 RID: 371
	public sealed class Class2130 : Class2059
	{
		// Token: 0x06000814 RID: 2068 RVA: 0x0000867C File Offset: 0x0000687C
		public Class2130()
		{
			this.method_4();
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00008695 File Offset: 0x00006895
		public Class2130(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_3(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000086AF File Offset: 0x000068AF
		private void method_4()
		{
			this.class1601_0.method_0(this);
		}

		// Token: 0x04000385 RID: 901
		public Class2130.Class1601 class1601_0 = new Class2130.Class1601();

		// Token: 0x02000174 RID: 372
		public sealed class Class1601 : IEnumerable
		{
			// Token: 0x06000819 RID: 2073 RVA: 0x000086BD File Offset: 0x000068BD
			public void method_0(Class2130 class2130_1)
			{
				this.class2130_0 = class2130_1;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x0006ACF8 File Offset: 0x00068EF8
			public Class2130.Class1602 method_1()
			{
				return new Class2130.Class1602(this.class2130_0);
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x0006AD14 File Offset: 0x00068F14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000386 RID: 902
			private Class2130 class2130_0;
		}

		// Token: 0x02000175 RID: 373
		public sealed class Class1602 : IEnumerator
		{
			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600081D RID: 2077 RVA: 0x0006AD2C File Offset: 0x00068F2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x000086C6 File Offset: 0x000068C6
			public Class1602(Class2130 class2130_1)
			{
				this.class2130_0 = class2130_1;
				this.int_0 = -1;
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x000086DC File Offset: 0x000068DC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000820 RID: 2080 RVA: 0x000086E5 File Offset: 0x000068E5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2130_0.method_2();
			}

			// Token: 0x06000821 RID: 2081 RVA: 0x0006AD44 File Offset: 0x00068F44
			public Class2128 method_0()
			{
				return this.class2130_0.method_3(this.int_0);
			}

			// Token: 0x04000387 RID: 903
			private int int_0;

			// Token: 0x04000388 RID: 904
			private Class2130 class2130_0;
		}
	}
}
