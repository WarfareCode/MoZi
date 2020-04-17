using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x0200025E RID: 606
	public sealed class Class2155 : Class2059
	{
		// Token: 0x06000E18 RID: 3608 RVA: 0x0000B727 File Offset: 0x00009927
		public Class2155()
		{
			this.method_6();
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000B74B File Offset: 0x0000994B
		public Class2155(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0000B770 File Offset: 0x00009970
		private void method_6()
		{
			this.class1765_0.method_0(this);
			this.class1767_0.method_0(this);
		}

		// Token: 0x040005E0 RID: 1504
		public Class2155.Class1765 class1765_0 = new Class2155.Class1765();

		// Token: 0x040005E1 RID: 1505
		public Class2155.Class1767 class1767_0 = new Class2155.Class1767();

		// Token: 0x0200025F RID: 607
		public sealed class Class1765 : IEnumerable
		{
			// Token: 0x06000E1F RID: 3615 RVA: 0x0000B78A File Offset: 0x0000998A
			public void method_0(Class2155 class2155_1)
			{
				this.class2155_0 = class2155_1;
			}

			// Token: 0x06000E20 RID: 3616 RVA: 0x0007B0A0 File Offset: 0x000792A0
			public Class2155.Class1766 method_1()
			{
				return new Class2155.Class1766(this.class2155_0);
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x0007B0BC File Offset: 0x000792BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005E2 RID: 1506
			private Class2155 class2155_0;
		}

		// Token: 0x02000260 RID: 608
		public sealed class Class1766 : IEnumerator
		{
			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0007B0D4 File Offset: 0x000792D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E24 RID: 3620 RVA: 0x0000B793 File Offset: 0x00009993
			public Class1766(Class2155 class2155_1)
			{
				this.class2155_0 = class2155_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E25 RID: 3621 RVA: 0x0000B7A9 File Offset: 0x000099A9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E26 RID: 3622 RVA: 0x0000B7B2 File Offset: 0x000099B2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2155_0.method_2();
			}

			// Token: 0x06000E27 RID: 3623 RVA: 0x0007B0EC File Offset: 0x000792EC
			public Class2050 method_0()
			{
				return this.class2155_0.method_3(this.int_0);
			}

			// Token: 0x040005E3 RID: 1507
			private int int_0;

			// Token: 0x040005E4 RID: 1508
			private Class2155 class2155_0;
		}

		// Token: 0x02000261 RID: 609
		public sealed class Class1767 : IEnumerable
		{
			// Token: 0x06000E28 RID: 3624 RVA: 0x0000B7D5 File Offset: 0x000099D5
			public void method_0(Class2155 class2155_1)
			{
				this.class2155_0 = class2155_1;
			}

			// Token: 0x06000E29 RID: 3625 RVA: 0x0007B10C File Offset: 0x0007930C
			public Class2155.Class1768 method_1()
			{
				return new Class2155.Class1768(this.class2155_0);
			}

			// Token: 0x06000E2A RID: 3626 RVA: 0x0007B128 File Offset: 0x00079328
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005E5 RID: 1509
			private Class2155 class2155_0;
		}

		// Token: 0x02000262 RID: 610
		public sealed class Class1768 : IEnumerator
		{
			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0007B140 File Offset: 0x00079340
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x0000B7DE File Offset: 0x000099DE
			public Class1768(Class2155 class2155_1)
			{
				this.class2155_0 = class2155_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E2E RID: 3630 RVA: 0x0000B7F4 File Offset: 0x000099F4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E2F RID: 3631 RVA: 0x0000B7FD File Offset: 0x000099FD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2155_0.method_4();
			}

			// Token: 0x06000E30 RID: 3632 RVA: 0x0007B158 File Offset: 0x00079358
			public Class2145 method_0()
			{
				return this.class2155_0.method_5(this.int_0);
			}

			// Token: 0x040005E6 RID: 1510
			private int int_0;

			// Token: 0x040005E7 RID: 1511
			private Class2155 class2155_0;
		}
	}
}
