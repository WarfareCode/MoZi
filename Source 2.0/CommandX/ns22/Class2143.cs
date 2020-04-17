using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000216 RID: 534
	public sealed class Class2143 : Class2059
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x0000A7FA File Offset: 0x000089FA
		public Class2143()
		{
			this.method_6();
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0000A81E File Offset: 0x00008A1E
		public Class2143(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00079864 File Offset: 0x00077A64
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactPerson");
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00079884 File Offset: 0x00077A84
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactPerson", int_0)));
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000798B0 File Offset: 0x00077AB0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactOrganization");
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000798D0 File Offset: 0x00077AD0
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactOrganization", int_0)));
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0000A843 File Offset: 0x00008A43
		private void method_6()
		{
			this.class1717_0.method_0(this);
			this.class1719_0.method_0(this);
		}

		// Token: 0x0400056A RID: 1386
		public Class2143.Class1717 class1717_0 = new Class2143.Class1717();

		// Token: 0x0400056B RID: 1387
		public Class2143.Class1719 class1719_0 = new Class2143.Class1719();

		// Token: 0x02000217 RID: 535
		public sealed class Class1717 : IEnumerable
		{
			// Token: 0x06000C94 RID: 3220 RVA: 0x0000A85D File Offset: 0x00008A5D
			public void method_0(Class2143 class2143_1)
			{
				this.class2143_0 = class2143_1;
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x000798FC File Offset: 0x00077AFC
			public Class2143.Class1718 method_1()
			{
				return new Class2143.Class1718(this.class2143_0);
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00079918 File Offset: 0x00077B18
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400056C RID: 1388
			private Class2143 class2143_0;
		}

		// Token: 0x02000218 RID: 536
		public sealed class Class1718 : IEnumerator
		{
			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00079930 File Offset: 0x00077B30
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x0000A866 File Offset: 0x00008A66
			public Class1718(Class2143 class2143_1)
			{
				this.class2143_0 = class2143_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x0000A87C File Offset: 0x00008A7C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x0000A885 File Offset: 0x00008A85
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2143_0.method_2();
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x00079948 File Offset: 0x00077B48
			public Class2050 method_0()
			{
				return this.class2143_0.method_3(this.int_0);
			}

			// Token: 0x0400056D RID: 1389
			private int int_0;

			// Token: 0x0400056E RID: 1390
			private Class2143 class2143_0;
		}

		// Token: 0x02000219 RID: 537
		public sealed class Class1719 : IEnumerable
		{
			// Token: 0x06000C9D RID: 3229 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			public void method_0(Class2143 class2143_1)
			{
				this.class2143_0 = class2143_1;
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00079968 File Offset: 0x00077B68
			public Class2143.Class1720 method_1()
			{
				return new Class2143.Class1720(this.class2143_0);
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x00079984 File Offset: 0x00077B84
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400056F RID: 1391
			private Class2143 class2143_0;
		}

		// Token: 0x0200021A RID: 538
		public sealed class Class1720 : IEnumerator
		{
			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0007999C File Offset: 0x00077B9C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x0000A8B1 File Offset: 0x00008AB1
			public Class1720(Class2143 class2143_1)
			{
				this.class2143_0 = class2143_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x0000A8C7 File Offset: 0x00008AC7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x0000A8D0 File Offset: 0x00008AD0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2143_0.method_4();
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x000799B4 File Offset: 0x00077BB4
			public Class2050 method_0()
			{
				return this.class2143_0.method_5(this.int_0);
			}

			// Token: 0x04000570 RID: 1392
			private int int_0;

			// Token: 0x04000571 RID: 1393
			private Class2143 class2143_0;
		}
	}
}
