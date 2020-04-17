using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000739 RID: 1849
	public sealed class Class2073 : Class2059
	{
		// Token: 0x06002DF7 RID: 11767 RVA: 0x00019052 File Offset: 0x00017252
		public Class2073()
		{
			this.method_8();
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00019081 File Offset: 0x00017281
		public Class2073(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00104BE8 File Offset: 0x00102DE8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Family");
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00104C08 File Offset: 0x00102E08
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Family", int_0)));
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00104C34 File Offset: 0x00102E34
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Size");
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00104C54 File Offset: 0x00102E54
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Size", int_0)));
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x0007D528 File Offset: 0x0007B728
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Style");
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00104DEC File Offset: 0x00102FEC
		public Class2070 method_7(int int_0)
		{
			return new Class2070(base.method_1(Class2059.Enum155.const_1, "", "Style", int_0));
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000190B1 File Offset: 0x000172B1
		private void method_8()
		{
			this.class949_0.method_0(this);
			this.class951_0.method_0(this);
			this.class953_0.method_0(this);
		}

		// Token: 0x04001574 RID: 5492
		public Class2073.Class949 class949_0 = new Class2073.Class949();

		// Token: 0x04001575 RID: 5493
		public Class2073.Class951 class951_0 = new Class2073.Class951();

		// Token: 0x04001576 RID: 5494
		public Class2073.Class953 class953_0 = new Class2073.Class953();

		// Token: 0x0200073A RID: 1850
		public sealed class Class949 : IEnumerable
		{
			// Token: 0x06002E00 RID: 11776 RVA: 0x000190D7 File Offset: 0x000172D7
			public void method_0(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
			}

			// Token: 0x06002E01 RID: 11777 RVA: 0x00104E14 File Offset: 0x00103014
			public Class2073.Class950 method_1()
			{
				return new Class2073.Class950(this.class2073_0);
			}

			// Token: 0x06002E02 RID: 11778 RVA: 0x00104E30 File Offset: 0x00103030
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001577 RID: 5495
			private Class2073 class2073_0;
		}

		// Token: 0x0200073B RID: 1851
		public sealed class Class950 : IEnumerator
		{
			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00104E48 File Offset: 0x00103048
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E05 RID: 11781 RVA: 0x000190E0 File Offset: 0x000172E0
			public Class950(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
				this.int_0 = -1;
			}

			// Token: 0x06002E06 RID: 11782 RVA: 0x000190F6 File Offset: 0x000172F6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002E07 RID: 11783 RVA: 0x000190FF File Offset: 0x000172FF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2073_0.method_2();
			}

			// Token: 0x06002E08 RID: 11784 RVA: 0x00104E60 File Offset: 0x00103060
			public Class2050 method_0()
			{
				return this.class2073_0.method_3(this.int_0);
			}

			// Token: 0x04001578 RID: 5496
			private int int_0;

			// Token: 0x04001579 RID: 5497
			private Class2073 class2073_0;
		}

		// Token: 0x0200073C RID: 1852
		public sealed class Class951 : IEnumerable
		{
			// Token: 0x06002E09 RID: 11785 RVA: 0x00019122 File Offset: 0x00017322
			public void method_0(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
			}

			// Token: 0x06002E0A RID: 11786 RVA: 0x00104E80 File Offset: 0x00103080
			public Class2073.Class952 method_1()
			{
				return new Class2073.Class952(this.class2073_0);
			}

			// Token: 0x06002E0B RID: 11787 RVA: 0x00104E9C File Offset: 0x0010309C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400157A RID: 5498
			private Class2073 class2073_0;
		}

		// Token: 0x0200073D RID: 1853
		public sealed class Class952 : IEnumerator
		{
			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00104EB4 File Offset: 0x001030B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E0E RID: 11790 RVA: 0x0001912B File Offset: 0x0001732B
			public Class952(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
				this.int_0 = -1;
			}

			// Token: 0x06002E0F RID: 11791 RVA: 0x00019141 File Offset: 0x00017341
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002E10 RID: 11792 RVA: 0x0001914A File Offset: 0x0001734A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2073_0.method_4();
			}

			// Token: 0x06002E11 RID: 11793 RVA: 0x00104ECC File Offset: 0x001030CC
			public Class2020 method_0()
			{
				return this.class2073_0.method_5(this.int_0);
			}

			// Token: 0x0400157B RID: 5499
			private int int_0;

			// Token: 0x0400157C RID: 5500
			private Class2073 class2073_0;
		}

		// Token: 0x0200073E RID: 1854
		public sealed class Class953 : IEnumerable
		{
			// Token: 0x06002E12 RID: 11794 RVA: 0x0001916D File Offset: 0x0001736D
			public void method_0(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
			}

			// Token: 0x06002E13 RID: 11795 RVA: 0x00104EEC File Offset: 0x001030EC
			public Class2073.Class954 method_1()
			{
				return new Class2073.Class954(this.class2073_0);
			}

			// Token: 0x06002E14 RID: 11796 RVA: 0x00104F08 File Offset: 0x00103108
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400157D RID: 5501
			private Class2073 class2073_0;
		}

		// Token: 0x0200073F RID: 1855
		public sealed class Class954 : IEnumerator
		{
			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06002E16 RID: 11798 RVA: 0x00104F20 File Offset: 0x00103120
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E17 RID: 11799 RVA: 0x00019176 File Offset: 0x00017376
			public Class954(Class2073 class2073_1)
			{
				this.class2073_0 = class2073_1;
				this.int_0 = -1;
			}

			// Token: 0x06002E18 RID: 11800 RVA: 0x0001918C File Offset: 0x0001738C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002E19 RID: 11801 RVA: 0x00019195 File Offset: 0x00017395
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2073_0.method_6();
			}

			// Token: 0x06002E1A RID: 11802 RVA: 0x00104F38 File Offset: 0x00103138
			public Class2070 method_0()
			{
				return this.class2073_0.method_7(this.int_0);
			}

			// Token: 0x0400157E RID: 5502
			private int int_0;

			// Token: 0x0400157F RID: 5503
			private Class2073 class2073_0;
		}
	}
}
