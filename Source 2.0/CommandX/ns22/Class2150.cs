using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x02000240 RID: 576
	public sealed class Class2150 : Class2059
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x0000B01D File Offset: 0x0000921D
		public Class2150()
		{
			this.method_6();
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0000B041 File Offset: 0x00009241
		public Class2150(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0000B066 File Offset: 0x00009266
		private void method_6()
		{
			this.class1745_0.method_0(this);
			this.class1747_0.method_0(this);
		}

		// Token: 0x040005AC RID: 1452
		public Class2150.Class1745 class1745_0 = new Class2150.Class1745();

		// Token: 0x040005AD RID: 1453
		public Class2150.Class1747 class1747_0 = new Class2150.Class1747();

		// Token: 0x02000241 RID: 577
		public sealed class Class1745 : IEnumerable
		{
			// Token: 0x06000D68 RID: 3432 RVA: 0x0000B080 File Offset: 0x00009280
			public void method_0(Class2150 class2150_1)
			{
				this.class2150_0 = class2150_1;
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x0007A4A8 File Offset: 0x000786A8
			public Class2150.Class1746 method_1()
			{
				return new Class2150.Class1746(this.class2150_0);
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x0007A4C4 File Offset: 0x000786C4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005AE RID: 1454
			private Class2150 class2150_0;
		}

		// Token: 0x02000242 RID: 578
		public sealed class Class1746 : IEnumerator
		{
			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0007A4DC File Offset: 0x000786DC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D6D RID: 3437 RVA: 0x0000B089 File Offset: 0x00009289
			public Class1746(Class2150 class2150_1)
			{
				this.class2150_0 = class2150_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D6E RID: 3438 RVA: 0x0000B09F File Offset: 0x0000929F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D6F RID: 3439 RVA: 0x0000B0A8 File Offset: 0x000092A8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2150_0.method_2();
			}

			// Token: 0x06000D70 RID: 3440 RVA: 0x0007A4F4 File Offset: 0x000786F4
			public Class2050 method_0()
			{
				return this.class2150_0.method_3(this.int_0);
			}

			// Token: 0x040005AF RID: 1455
			private int int_0;

			// Token: 0x040005B0 RID: 1456
			private Class2150 class2150_0;
		}

		// Token: 0x02000243 RID: 579
		public sealed class Class1747 : IEnumerable
		{
			// Token: 0x06000D71 RID: 3441 RVA: 0x0000B0CB File Offset: 0x000092CB
			public void method_0(Class2150 class2150_1)
			{
				this.class2150_0 = class2150_1;
			}

			// Token: 0x06000D72 RID: 3442 RVA: 0x0007A514 File Offset: 0x00078714
			public Class2150.Class1748 method_1()
			{
				return new Class2150.Class1748(this.class2150_0);
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x0007A530 File Offset: 0x00078730
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005B1 RID: 1457
			private Class2150 class2150_0;
		}

		// Token: 0x02000244 RID: 580
		public sealed class Class1748 : IEnumerator
		{
			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0007A548 File Offset: 0x00078748
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x0000B0D4 File Offset: 0x000092D4
			public Class1748(Class2150 class2150_1)
			{
				this.class2150_0 = class2150_1;
				this.int_0 = -1;
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x0000B0EA File Offset: 0x000092EA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x0000B0F3 File Offset: 0x000092F3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2150_0.method_4();
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x0007A560 File Offset: 0x00078760
			public Class2165 method_0()
			{
				return this.class2150_0.method_5(this.int_0);
			}

			// Token: 0x040005B2 RID: 1458
			private int int_0;

			// Token: 0x040005B3 RID: 1459
			private Class2150 class2150_0;
		}
	}
}
