using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000257 RID: 599
	public sealed class Class2154 : Class2059
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x0000B62E File Offset: 0x0000982E
		public Class2154()
		{
			this.method_6();
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0000B652 File Offset: 0x00009852
		public Class2154(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0000B677 File Offset: 0x00009877
		private void method_6()
		{
			this.class1761_0.method_0(this);
			this.class1763_0.method_0(this);
		}

		// Token: 0x040005D8 RID: 1496
		public Class2154.Class1761 class1761_0 = new Class2154.Class1761();

		// Token: 0x040005D9 RID: 1497
		public Class2154.Class1763 class1763_0 = new Class2154.Class1763();

		// Token: 0x02000258 RID: 600
		public sealed class Class1761 : IEnumerable
		{
			// Token: 0x06000DFF RID: 3583 RVA: 0x0000B691 File Offset: 0x00009891
			public void method_0(Class2154 class2154_1)
			{
				this.class2154_0 = class2154_1;
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x0007AEF0 File Offset: 0x000790F0
			public Class2154.Class1762 method_1()
			{
				return new Class2154.Class1762(this.class2154_0);
			}

			// Token: 0x06000E01 RID: 3585 RVA: 0x0007AF0C File Offset: 0x0007910C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005DA RID: 1498
			private Class2154 class2154_0;
		}

		// Token: 0x02000259 RID: 601
		public sealed class Class1762 : IEnumerator
		{
			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0007AF24 File Offset: 0x00079124
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E04 RID: 3588 RVA: 0x0000B69A File Offset: 0x0000989A
			public Class1762(Class2154 class2154_1)
			{
				this.class2154_0 = class2154_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x0000B6B0 File Offset: 0x000098B0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E06 RID: 3590 RVA: 0x0000B6B9 File Offset: 0x000098B9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2154_0.method_2();
			}

			// Token: 0x06000E07 RID: 3591 RVA: 0x0007AF3C File Offset: 0x0007913C
			public Class2050 method_0()
			{
				return this.class2154_0.method_3(this.int_0);
			}

			// Token: 0x040005DB RID: 1499
			private int int_0;

			// Token: 0x040005DC RID: 1500
			private Class2154 class2154_0;
		}

		// Token: 0x0200025A RID: 602
		public sealed class Class1763 : IEnumerable
		{
			// Token: 0x06000E08 RID: 3592 RVA: 0x0000B6DC File Offset: 0x000098DC
			public void method_0(Class2154 class2154_1)
			{
				this.class2154_0 = class2154_1;
			}

			// Token: 0x06000E09 RID: 3593 RVA: 0x0007AF5C File Offset: 0x0007915C
			public Class2154.Class1764 method_1()
			{
				return new Class2154.Class1764(this.class2154_0);
			}

			// Token: 0x06000E0A RID: 3594 RVA: 0x0007AF78 File Offset: 0x00079178
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040005DD RID: 1501
			private Class2154 class2154_0;
		}

		// Token: 0x0200025B RID: 603
		public sealed class Class1764 : IEnumerator
		{
			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0007AF90 File Offset: 0x00079190
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000E0D RID: 3597 RVA: 0x0000B6E5 File Offset: 0x000098E5
			public Class1764(Class2154 class2154_1)
			{
				this.class2154_0 = class2154_1;
				this.int_0 = -1;
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x0000B6FB File Offset: 0x000098FB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000E0F RID: 3599 RVA: 0x0000B704 File Offset: 0x00009904
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2154_0.method_4();
			}

			// Token: 0x06000E10 RID: 3600 RVA: 0x0007AFA8 File Offset: 0x000791A8
			public Class2145 method_0()
			{
				return this.class2154_0.method_5(this.int_0);
			}

			// Token: 0x040005DE RID: 1502
			private int int_0;

			// Token: 0x040005DF RID: 1503
			private Class2154 class2154_0;
		}
	}
}
