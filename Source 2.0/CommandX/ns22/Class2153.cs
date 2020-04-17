using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000251 RID: 593
	public sealed class Class2153 : Class2059
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x0000B483 File Offset: 0x00009683
		public Class2153()
		{
			this.method_6();
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000B4A7 File Offset: 0x000096A7
		public Class2153(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000B4CC File Offset: 0x000096CC
		private void method_6()
		{
			this.class1757_0.method_0(this);
			this.class1759_0.method_0(this);
		}

		// Token: 0x040005CB RID: 1483
		public Class2153.Class1757 class1757_0 = new Class2153.Class1757();

		// Token: 0x040005CC RID: 1484
		public Class2153.Class1759 class1759_0 = new Class2153.Class1759();

		// Token: 0x02000252 RID: 594
		public sealed class Class1757 : IEnumerable
		{
			// Token: 0x06000DDA RID: 3546 RVA: 0x0000B4E6 File Offset: 0x000096E6
			public void method_0(Class2153 class2153_1)
			{
				this.class2153_0 = class2153_1;
			}

			// Token: 0x06000DDB RID: 3547 RVA: 0x0007ACC8 File Offset: 0x00078EC8
			public Class2153.Class1758 method_1()
			{
				return new Class2153.Class1758(this.class2153_0);
			}

			// Token: 0x06000DDC RID: 3548 RVA: 0x0007ACE4 File Offset: 0x00078EE4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005CD RID: 1485
			private Class2153 class2153_0;
		}

		// Token: 0x02000253 RID: 595
		public sealed class Class1758 : IEnumerator
		{
			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0007ACFC File Offset: 0x00078EFC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000DDF RID: 3551 RVA: 0x0000B4EF File Offset: 0x000096EF
			public Class1758(Class2153 class2153_1)
			{
				this.class2153_0 = class2153_1;
				this.int_0 = -1;
			}

			// Token: 0x06000DE0 RID: 3552 RVA: 0x0000B505 File Offset: 0x00009705
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x0000B50E File Offset: 0x0000970E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2153_0.method_2();
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x0007AD14 File Offset: 0x00078F14
			public Class2050 method_0()
			{
				return this.class2153_0.method_3(this.int_0);
			}

			// Token: 0x040005CE RID: 1486
			private int int_0;

			// Token: 0x040005CF RID: 1487
			private Class2153 class2153_0;
		}

		// Token: 0x02000254 RID: 596
		public sealed class Class1759 : IEnumerable
		{
			// Token: 0x06000DE3 RID: 3555 RVA: 0x0000B531 File Offset: 0x00009731
			public void method_0(Class2153 class2153_1)
			{
				this.class2153_0 = class2153_1;
			}

			// Token: 0x06000DE4 RID: 3556 RVA: 0x0007AD34 File Offset: 0x00078F34
			public Class2153.Class1760 method_1()
			{
				return new Class2153.Class1760(this.class2153_0);
			}

			// Token: 0x06000DE5 RID: 3557 RVA: 0x0007AD50 File Offset: 0x00078F50
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005D0 RID: 1488
			private Class2153 class2153_0;
		}

		// Token: 0x02000255 RID: 597
		public sealed class Class1760 : IEnumerator
		{
			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0007AD68 File Offset: 0x00078F68
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000DE8 RID: 3560 RVA: 0x0000B53A File Offset: 0x0000973A
			public Class1760(Class2153 class2153_1)
			{
				this.class2153_0 = class2153_1;
				this.int_0 = -1;
			}

			// Token: 0x06000DE9 RID: 3561 RVA: 0x0000B550 File Offset: 0x00009750
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000DEA RID: 3562 RVA: 0x0000B559 File Offset: 0x00009759
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2153_0.method_4();
			}

			// Token: 0x06000DEB RID: 3563 RVA: 0x0007AD80 File Offset: 0x00078F80
			public Class2145 method_0()
			{
				return this.class2153_0.method_5(this.int_0);
			}

			// Token: 0x040005D1 RID: 1489
			private int int_0;

			// Token: 0x040005D2 RID: 1490
			private Class2153 class2153_0;
		}
	}
}
