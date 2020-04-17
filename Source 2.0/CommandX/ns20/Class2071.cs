using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x0200072C RID: 1836
	public sealed class Class2071 : Class2059
	{
		// Token: 0x06002DA7 RID: 11687 RVA: 0x00018DB7 File Offset: 0x00016FB7
		public Class2071()
		{
			this.method_6();
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00018DDB File Offset: 0x00016FDB
		public Class2071(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00103FB0 File Offset: 0x001021B0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CaptionText");
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00103FD0 File Offset: 0x001021D0
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "CaptionText", int_0)));
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00103FFC File Offset: 0x001021FC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DisplayFont");
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0010401C File Offset: 0x0010221C
		public Class2073 method_5(int int_0)
		{
			return new Class2073(base.method_1(Class2059.Enum155.const_1, "", "DisplayFont", int_0));
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00018E00 File Offset: 0x00017000
		private void method_6()
		{
			this.class939_0.method_0(this);
			this.class941_0.method_0(this);
		}

		// Token: 0x04001552 RID: 5458
		public Class2071.Class939 class939_0 = new Class2071.Class939();

		// Token: 0x04001553 RID: 5459
		public Class2071.Class941 class941_0 = new Class2071.Class941();

		// Token: 0x0200072D RID: 1837
		public sealed class Class939 : IEnumerable
		{
			// Token: 0x06002DAE RID: 11694 RVA: 0x00018E1A File Offset: 0x0001701A
			public void method_0(Class2071 class2071_1)
			{
				this.class2071_0 = class2071_1;
			}

			// Token: 0x06002DAF RID: 11695 RVA: 0x00104044 File Offset: 0x00102244
			public Class2071.Class940 method_1()
			{
				return new Class2071.Class940(this.class2071_0);
			}

			// Token: 0x06002DB0 RID: 11696 RVA: 0x00104060 File Offset: 0x00102260
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001554 RID: 5460
			private Class2071 class2071_0;
		}

		// Token: 0x0200072E RID: 1838
		public sealed class Class940 : IEnumerator
		{
			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00104078 File Offset: 0x00102278
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x00018E23 File Offset: 0x00017023
			public Class940(Class2071 class2071_1)
			{
				this.class2071_0 = class2071_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DB4 RID: 11700 RVA: 0x00018E39 File Offset: 0x00017039
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DB5 RID: 11701 RVA: 0x00018E42 File Offset: 0x00017042
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2071_0.method_2();
			}

			// Token: 0x06002DB6 RID: 11702 RVA: 0x00104090 File Offset: 0x00102290
			public Class2050 method_0()
			{
				return this.class2071_0.method_3(this.int_0);
			}

			// Token: 0x04001555 RID: 5461
			private int int_0;

			// Token: 0x04001556 RID: 5462
			private Class2071 class2071_0;
		}

		// Token: 0x0200072F RID: 1839
		public sealed class Class941 : IEnumerable
		{
			// Token: 0x06002DB7 RID: 11703 RVA: 0x00018E65 File Offset: 0x00017065
			public void method_0(Class2071 class2071_1)
			{
				this.class2071_0 = class2071_1;
			}

			// Token: 0x06002DB8 RID: 11704 RVA: 0x001040B0 File Offset: 0x001022B0
			public Class2071.Class942 method_1()
			{
				return new Class2071.Class942(this.class2071_0);
			}

			// Token: 0x06002DB9 RID: 11705 RVA: 0x001040CC File Offset: 0x001022CC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001557 RID: 5463
			private Class2071 class2071_0;
		}

		// Token: 0x02000730 RID: 1840
		public sealed class Class942 : IEnumerator
		{
			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06002DBB RID: 11707 RVA: 0x001040E4 File Offset: 0x001022E4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DBC RID: 11708 RVA: 0x00018E6E File Offset: 0x0001706E
			public Class942(Class2071 class2071_1)
			{
				this.class2071_0 = class2071_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DBD RID: 11709 RVA: 0x00018E84 File Offset: 0x00017084
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DBE RID: 11710 RVA: 0x00018E8D File Offset: 0x0001708D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2071_0.method_4();
			}

			// Token: 0x06002DBF RID: 11711 RVA: 0x001040FC File Offset: 0x001022FC
			public Class2073 method_0()
			{
				return this.class2071_0.method_5(this.int_0);
			}

			// Token: 0x04001558 RID: 5464
			private int int_0;

			// Token: 0x04001559 RID: 5465
			private Class2071 class2071_0;
		}
	}
}
