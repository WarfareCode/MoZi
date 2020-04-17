using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x0200024A RID: 586
	public sealed class Class2152 : Class2059
	{
		// Token: 0x06000D93 RID: 3475 RVA: 0x0000B20F File Offset: 0x0000940F
		public Class2152()
		{
			this.method_6();
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0000B233 File Offset: 0x00009433
		public Class2152(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0000B258 File Offset: 0x00009458
		private void method_6()
		{
			this.class1753_0.method_0(this);
			this.class1755_0.method_0(this);
		}

		// Token: 0x040005BC RID: 1468
		public Class2152.Class1753 class1753_0 = new Class2152.Class1753();

		// Token: 0x040005BD RID: 1469
		public Class2152.Class1755 class1755_0 = new Class2152.Class1755();

		// Token: 0x0200024B RID: 587
		public sealed class Class1753 : IEnumerable
		{
			// Token: 0x06000D9A RID: 3482 RVA: 0x0000B272 File Offset: 0x00009472
			public void method_0(Class2152 class2152_1)
			{
				this.class2152_0 = class2152_1;
			}

			// Token: 0x06000D9B RID: 3483 RVA: 0x0007A658 File Offset: 0x00078858
			public Class2152.Class1754 method_1()
			{
				return new Class2152.Class1754(this.class2152_0);
			}

			// Token: 0x06000D9C RID: 3484 RVA: 0x0007A674 File Offset: 0x00078874
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005BE RID: 1470
			private Class2152 class2152_0;
		}

		// Token: 0x0200024C RID: 588
		public sealed class Class1754 : IEnumerator
		{
			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0007A68C File Offset: 0x0007888C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000D9F RID: 3487 RVA: 0x0000B27B File Offset: 0x0000947B
			public Class1754(Class2152 class2152_1)
			{
				this.class2152_0 = class2152_1;
				this.int_0 = -1;
			}

			// Token: 0x06000DA0 RID: 3488 RVA: 0x0000B291 File Offset: 0x00009491
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000DA1 RID: 3489 RVA: 0x0000B29A File Offset: 0x0000949A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2152_0.method_2();
			}

			// Token: 0x06000DA2 RID: 3490 RVA: 0x0007A6A4 File Offset: 0x000788A4
			public Class2050 method_0()
			{
				return this.class2152_0.method_3(this.int_0);
			}

			// Token: 0x040005BF RID: 1471
			private int int_0;

			// Token: 0x040005C0 RID: 1472
			private Class2152 class2152_0;
		}

		// Token: 0x0200024D RID: 589
		public sealed class Class1755 : IEnumerable
		{
			// Token: 0x06000DA3 RID: 3491 RVA: 0x0000B2BD File Offset: 0x000094BD
			public void method_0(Class2152 class2152_1)
			{
				this.class2152_0 = class2152_1;
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x0007A6C4 File Offset: 0x000788C4
			public Class2152.Class1756 method_1()
			{
				return new Class2152.Class1756(this.class2152_0);
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x0007A6E0 File Offset: 0x000788E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005C1 RID: 1473
			private Class2152 class2152_0;
		}

		// Token: 0x0200024E RID: 590
		public sealed class Class1756 : IEnumerator
		{
			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0007A6F8 File Offset: 0x000788F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000DA8 RID: 3496 RVA: 0x0000B2C6 File Offset: 0x000094C6
			public Class1756(Class2152 class2152_1)
			{
				this.class2152_0 = class2152_1;
				this.int_0 = -1;
			}

			// Token: 0x06000DA9 RID: 3497 RVA: 0x0000B2DC File Offset: 0x000094DC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000DAA RID: 3498 RVA: 0x0000B2E5 File Offset: 0x000094E5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2152_0.method_4();
			}

			// Token: 0x06000DAB RID: 3499 RVA: 0x0007A710 File Offset: 0x00078910
			public Class2145 method_0()
			{
				return this.class2152_0.method_5(this.int_0);
			}

			// Token: 0x040005C2 RID: 1474
			private int int_0;

			// Token: 0x040005C3 RID: 1475
			private Class2152 class2152_0;
		}
	}
}
