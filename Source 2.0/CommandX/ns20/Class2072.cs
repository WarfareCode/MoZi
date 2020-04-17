using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x02000732 RID: 1842
	public sealed class Class2072 : Class2059
	{
		// Token: 0x06002DD4 RID: 11732 RVA: 0x00018F1C File Offset: 0x0001711C
		public Class2072()
		{
			this.method_8();
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00104BE8 File Offset: 0x00102DE8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Family");
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00104C08 File Offset: 0x00102E08
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Family", int_0)));
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00104C34 File Offset: 0x00102E34
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Size");
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00104C54 File Offset: 0x00102E54
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Size", int_0)));
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0007D528 File Offset: 0x0007B728
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Style");
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00104C80 File Offset: 0x00102E80
		public Class2069 method_7(int int_0)
		{
			return new Class2069(base.method_1(Class2059.Enum155.const_1, "", "Style", int_0));
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00018F4B File Offset: 0x0001714B
		private void method_8()
		{
			this.class943_0.method_0(this);
			this.class945_0.method_0(this);
			this.class947_0.method_0(this);
		}

		// Token: 0x04001568 RID: 5480
		public Class2072.Class943 class943_0 = new Class2072.Class943();

		// Token: 0x04001569 RID: 5481
		public Class2072.Class945 class945_0 = new Class2072.Class945();

		// Token: 0x0400156A RID: 5482
		public Class2072.Class947 class947_0 = new Class2072.Class947();

		// Token: 0x02000733 RID: 1843
		public sealed class Class943 : IEnumerable
		{
			// Token: 0x06002DDC RID: 11740 RVA: 0x00018F71 File Offset: 0x00017171
			public void method_0(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
			}

			// Token: 0x06002DDD RID: 11741 RVA: 0x00104CA8 File Offset: 0x00102EA8
			public Class2072.Class944 method_1()
			{
				return new Class2072.Class944(this.class2072_0);
			}

			// Token: 0x06002DDE RID: 11742 RVA: 0x00104CC4 File Offset: 0x00102EC4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400156B RID: 5483
			private Class2072 class2072_0;
		}

		// Token: 0x02000734 RID: 1844
		public sealed class Class944 : IEnumerator
		{
			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x00104CDC File Offset: 0x00102EDC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DE1 RID: 11745 RVA: 0x00018F7A File Offset: 0x0001717A
			public Class944(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DE2 RID: 11746 RVA: 0x00018F90 File Offset: 0x00017190
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DE3 RID: 11747 RVA: 0x00018F99 File Offset: 0x00017199
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2072_0.method_2();
			}

			// Token: 0x06002DE4 RID: 11748 RVA: 0x00104CF4 File Offset: 0x00102EF4
			public Class2050 method_0()
			{
				return this.class2072_0.method_3(this.int_0);
			}

			// Token: 0x0400156C RID: 5484
			private int int_0;

			// Token: 0x0400156D RID: 5485
			private Class2072 class2072_0;
		}

		// Token: 0x02000735 RID: 1845
		public sealed class Class945 : IEnumerable
		{
			// Token: 0x06002DE5 RID: 11749 RVA: 0x00018FBC File Offset: 0x000171BC
			public void method_0(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
			}

			// Token: 0x06002DE6 RID: 11750 RVA: 0x00104D14 File Offset: 0x00102F14
			public Class2072.Class946 method_1()
			{
				return new Class2072.Class946(this.class2072_0);
			}

			// Token: 0x06002DE7 RID: 11751 RVA: 0x00104D30 File Offset: 0x00102F30
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400156E RID: 5486
			private Class2072 class2072_0;
		}

		// Token: 0x02000736 RID: 1846
		public sealed class Class946 : IEnumerator
		{
			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x00104D48 File Offset: 0x00102F48
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DEA RID: 11754 RVA: 0x00018FC5 File Offset: 0x000171C5
			public Class946(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DEB RID: 11755 RVA: 0x00018FDB File Offset: 0x000171DB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DEC RID: 11756 RVA: 0x00018FE4 File Offset: 0x000171E4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2072_0.method_4();
			}

			// Token: 0x06002DED RID: 11757 RVA: 0x00104D60 File Offset: 0x00102F60
			public Class2020 method_0()
			{
				return this.class2072_0.method_5(this.int_0);
			}

			// Token: 0x0400156F RID: 5487
			private int int_0;

			// Token: 0x04001570 RID: 5488
			private Class2072 class2072_0;
		}

		// Token: 0x02000737 RID: 1847
		public sealed class Class947 : IEnumerable
		{
			// Token: 0x06002DEE RID: 11758 RVA: 0x00019007 File Offset: 0x00017207
			public void method_0(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
			}

			// Token: 0x06002DEF RID: 11759 RVA: 0x00104D80 File Offset: 0x00102F80
			public Class2072.Class948 method_1()
			{
				return new Class2072.Class948(this.class2072_0);
			}

			// Token: 0x06002DF0 RID: 11760 RVA: 0x00104D9C File Offset: 0x00102F9C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001571 RID: 5489
			private Class2072 class2072_0;
		}

		// Token: 0x02000738 RID: 1848
		public sealed class Class948 : IEnumerator
		{
			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00104DB4 File Offset: 0x00102FB4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DF3 RID: 11763 RVA: 0x00019010 File Offset: 0x00017210
			public Class948(Class2072 class2072_1)
			{
				this.class2072_0 = class2072_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DF4 RID: 11764 RVA: 0x00019026 File Offset: 0x00017226
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DF5 RID: 11765 RVA: 0x0001902F File Offset: 0x0001722F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2072_0.method_6();
			}

			// Token: 0x06002DF6 RID: 11766 RVA: 0x00104DCC File Offset: 0x00102FCC
			public Class2069 method_0()
			{
				return this.class2072_0.method_7(this.int_0);
			}

			// Token: 0x04001572 RID: 5490
			private int int_0;

			// Token: 0x04001573 RID: 5491
			private Class2072 class2072_0;
		}
	}
}
