using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000276 RID: 630
	public sealed class Class2160 : Class2059
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x0000BC38 File Offset: 0x00009E38
		public Class2160()
		{
			this.method_10();
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0000BC72 File Offset: 0x00009E72
		public Class2160(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0005CF0C File Offset: 0x0005B10C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "minx");
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00077D1C File Offset: 0x00075F1C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "minx", int_0)));
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0005CF58 File Offset: 0x0005B158
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "miny");
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00077D48 File Offset: 0x00075F48
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "miny", int_0)));
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "maxx");
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00077D74 File Offset: 0x00075F74
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "maxx", int_0)));
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "maxy");
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00077DA0 File Offset: 0x00075FA0
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "maxy", int_0)));
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0000BCAD File Offset: 0x00009EAD
		private void method_10()
		{
			this.class1779_0.method_0(this);
			this.class1781_0.method_0(this);
			this.class1783_0.method_0(this);
			this.class1785_0.method_0(this);
		}

		// Token: 0x0400060E RID: 1550
		public Class2160.Class1779 class1779_0 = new Class2160.Class1779();

		// Token: 0x0400060F RID: 1551
		public Class2160.Class1781 class1781_0 = new Class2160.Class1781();

		// Token: 0x04000610 RID: 1552
		public Class2160.Class1783 class1783_0 = new Class2160.Class1783();

		// Token: 0x04000611 RID: 1553
		public Class2160.Class1785 class1785_0 = new Class2160.Class1785();

		// Token: 0x02000277 RID: 631
		public sealed class Class1779 : IEnumerable
		{
			// Token: 0x06000EA6 RID: 3750 RVA: 0x0000BCDF File Offset: 0x00009EDF
			public void method_0(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
			}

			// Token: 0x06000EA7 RID: 3751 RVA: 0x0007BA08 File Offset: 0x00079C08
			public Class2160.Class1780 method_1()
			{
				return new Class2160.Class1780(this.class2160_0);
			}

			// Token: 0x06000EA8 RID: 3752 RVA: 0x0007BA24 File Offset: 0x00079C24
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000612 RID: 1554
			private Class2160 class2160_0;
		}

		// Token: 0x02000278 RID: 632
		public sealed class Class1780 : IEnumerator
		{
			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0007BA3C File Offset: 0x00079C3C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000EAB RID: 3755 RVA: 0x0000BCE8 File Offset: 0x00009EE8
			public Class1780(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
				this.int_0 = -1;
			}

			// Token: 0x06000EAC RID: 3756 RVA: 0x0000BCFE File Offset: 0x00009EFE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000EAD RID: 3757 RVA: 0x0000BD07 File Offset: 0x00009F07
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2160_0.method_2();
			}

			// Token: 0x06000EAE RID: 3758 RVA: 0x0007BA54 File Offset: 0x00079C54
			public Class2050 method_0()
			{
				return this.class2160_0.method_3(this.int_0);
			}

			// Token: 0x04000613 RID: 1555
			private int int_0;

			// Token: 0x04000614 RID: 1556
			private Class2160 class2160_0;
		}

		// Token: 0x02000279 RID: 633
		public sealed class Class1781 : IEnumerable
		{
			// Token: 0x06000EAF RID: 3759 RVA: 0x0000BD2A File Offset: 0x00009F2A
			public void method_0(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
			}

			// Token: 0x06000EB0 RID: 3760 RVA: 0x0007BA74 File Offset: 0x00079C74
			public Class2160.Class1782 method_1()
			{
				return new Class2160.Class1782(this.class2160_0);
			}

			// Token: 0x06000EB1 RID: 3761 RVA: 0x0007BA90 File Offset: 0x00079C90
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000615 RID: 1557
			private Class2160 class2160_0;
		}

		// Token: 0x0200027A RID: 634
		public sealed class Class1782 : IEnumerator
		{
			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0007BAA8 File Offset: 0x00079CA8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x0000BD33 File Offset: 0x00009F33
			public Class1782(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
				this.int_0 = -1;
			}

			// Token: 0x06000EB5 RID: 3765 RVA: 0x0000BD49 File Offset: 0x00009F49
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000EB6 RID: 3766 RVA: 0x0000BD52 File Offset: 0x00009F52
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2160_0.method_4();
			}

			// Token: 0x06000EB7 RID: 3767 RVA: 0x0007BAC0 File Offset: 0x00079CC0
			public Class2050 method_0()
			{
				return this.class2160_0.method_5(this.int_0);
			}

			// Token: 0x04000616 RID: 1558
			private int int_0;

			// Token: 0x04000617 RID: 1559
			private Class2160 class2160_0;
		}

		// Token: 0x0200027B RID: 635
		public sealed class Class1783 : IEnumerable
		{
			// Token: 0x06000EB8 RID: 3768 RVA: 0x0000BD75 File Offset: 0x00009F75
			public void method_0(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
			}

			// Token: 0x06000EB9 RID: 3769 RVA: 0x0007BAE0 File Offset: 0x00079CE0
			public Class2160.Class1784 method_1()
			{
				return new Class2160.Class1784(this.class2160_0);
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x0007BAFC File Offset: 0x00079CFC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000618 RID: 1560
			private Class2160 class2160_0;
		}

		// Token: 0x0200027C RID: 636
		public sealed class Class1784 : IEnumerator
		{
			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0007BB14 File Offset: 0x00079D14
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x0000BD7E File Offset: 0x00009F7E
			public Class1784(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
				this.int_0 = -1;
			}

			// Token: 0x06000EBE RID: 3774 RVA: 0x0000BD94 File Offset: 0x00009F94
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000EBF RID: 3775 RVA: 0x0000BD9D File Offset: 0x00009F9D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2160_0.method_6();
			}

			// Token: 0x06000EC0 RID: 3776 RVA: 0x0007BB2C File Offset: 0x00079D2C
			public Class2050 method_0()
			{
				return this.class2160_0.method_7(this.int_0);
			}

			// Token: 0x04000619 RID: 1561
			private int int_0;

			// Token: 0x0400061A RID: 1562
			private Class2160 class2160_0;
		}

		// Token: 0x0200027D RID: 637
		public sealed class Class1785 : IEnumerable
		{
			// Token: 0x06000EC1 RID: 3777 RVA: 0x0000BDC0 File Offset: 0x00009FC0
			public void method_0(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
			}

			// Token: 0x06000EC2 RID: 3778 RVA: 0x0007BB4C File Offset: 0x00079D4C
			public Class2160.Class1786 method_1()
			{
				return new Class2160.Class1786(this.class2160_0);
			}

			// Token: 0x06000EC3 RID: 3779 RVA: 0x0007BB68 File Offset: 0x00079D68
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400061B RID: 1563
			private Class2160 class2160_0;
		}

		// Token: 0x0200027E RID: 638
		public sealed class Class1786 : IEnumerator
		{
			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0007BB80 File Offset: 0x00079D80
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000EC6 RID: 3782 RVA: 0x0000BDC9 File Offset: 0x00009FC9
			public Class1786(Class2160 class2160_1)
			{
				this.class2160_0 = class2160_1;
				this.int_0 = -1;
			}

			// Token: 0x06000EC7 RID: 3783 RVA: 0x0000BDDF File Offset: 0x00009FDF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000EC8 RID: 3784 RVA: 0x0000BDE8 File Offset: 0x00009FE8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2160_0.method_8();
			}

			// Token: 0x06000EC9 RID: 3785 RVA: 0x0007BB98 File Offset: 0x00079D98
			public Class2050 method_0()
			{
				return this.class2160_0.method_9(this.int_0);
			}

			// Token: 0x0400061C RID: 1564
			private int int_0;

			// Token: 0x0400061D RID: 1565
			private Class2160 class2160_0;
		}
	}
}
