using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns20
{
	// Token: 0x02000823 RID: 2083
	public sealed class Class2086 : Class2059
	{
		// Token: 0x06003357 RID: 13143 RVA: 0x0001B768 File Offset: 0x00019968
		public Class2086()
		{
			this.method_4();
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0001B781 File Offset: 0x00019981
		public Class2086(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00119928 File Offset: 0x00117B28
		public Class2046 method_3(int int_0)
		{
			return new Class2046(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0001B79B File Offset: 0x0001999B
		private void method_4()
		{
			this.class1093_0.method_0(this);
		}

		// Token: 0x040017D4 RID: 6100
		public Class2086.Class1093 class1093_0 = new Class2086.Class1093();

		// Token: 0x02000824 RID: 2084
		public sealed class Class1093 : IEnumerable
		{
			// Token: 0x0600335C RID: 13148 RVA: 0x0001B7A9 File Offset: 0x000199A9
			public void method_0(Class2086 class2086_1)
			{
				this.class2086_0 = class2086_1;
			}

			// Token: 0x0600335D RID: 13149 RVA: 0x00119954 File Offset: 0x00117B54
			public Class2086.Class1094 method_1()
			{
				return new Class2086.Class1094(this.class2086_0);
			}

			// Token: 0x0600335E RID: 13150 RVA: 0x00119970 File Offset: 0x00117B70
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017D5 RID: 6101
			private Class2086 class2086_0;
		}

		// Token: 0x02000825 RID: 2085
		public sealed class Class1094 : IEnumerator
		{
			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06003360 RID: 13152 RVA: 0x00119988 File Offset: 0x00117B88
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003361 RID: 13153 RVA: 0x0001B7B2 File Offset: 0x000199B2
			public Class1094(Class2086 class2086_1)
			{
				this.class2086_0 = class2086_1;
				this.int_0 = -1;
			}

			// Token: 0x06003362 RID: 13154 RVA: 0x0001B7C8 File Offset: 0x000199C8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003363 RID: 13155 RVA: 0x0001B7D1 File Offset: 0x000199D1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2086_0.method_2();
			}

			// Token: 0x06003364 RID: 13156 RVA: 0x001199A0 File Offset: 0x00117BA0
			public Class2046 method_0()
			{
				return this.class2086_0.method_3(this.int_0);
			}

			// Token: 0x040017D6 RID: 6102
			private int int_0;

			// Token: 0x040017D7 RID: 6103
			private Class2086 class2086_0;
		}
	}
}
