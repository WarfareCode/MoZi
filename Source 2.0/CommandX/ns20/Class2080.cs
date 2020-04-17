using System;
using System.Collections;
using ns16;
using ns21;

namespace ns20
{
	// Token: 0x020007C6 RID: 1990
	public sealed class Class2080 : Class2059
	{
		// Token: 0x0600314D RID: 12621 RVA: 0x0001A82A File Offset: 0x00018A2A
		public Class2080()
		{
			this.method_4();
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x0010BC44 File Offset: 0x00109E44
		public Class2043 method_3(int int_0)
		{
			return new Class2043(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x0001A843 File Offset: 0x00018A43
		private void method_4()
		{
			this.class1047_0.method_0(this);
		}

		// Token: 0x040016E7 RID: 5863
		public Class2080.Class1047 class1047_0 = new Class2080.Class1047();

		// Token: 0x020007C7 RID: 1991
		public sealed class Class1047 : IEnumerable
		{
			// Token: 0x06003151 RID: 12625 RVA: 0x0001A851 File Offset: 0x00018A51
			public void method_0(Class2080 class2080_1)
			{
				this.class2080_0 = class2080_1;
			}

			// Token: 0x06003152 RID: 12626 RVA: 0x0010BC70 File Offset: 0x00109E70
			public Class2080.Class1048 method_1()
			{
				return new Class2080.Class1048(this.class2080_0);
			}

			// Token: 0x06003153 RID: 12627 RVA: 0x0010BC8C File Offset: 0x00109E8C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016E8 RID: 5864
			private Class2080 class2080_0;
		}

		// Token: 0x020007C8 RID: 1992
		public sealed class Class1048 : IEnumerator
		{
			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06003155 RID: 12629 RVA: 0x0010BCA4 File Offset: 0x00109EA4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003156 RID: 12630 RVA: 0x0001A85A File Offset: 0x00018A5A
			public Class1048(Class2080 class2080_1)
			{
				this.class2080_0 = class2080_1;
				this.int_0 = -1;
			}

			// Token: 0x06003157 RID: 12631 RVA: 0x0001A870 File Offset: 0x00018A70
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003158 RID: 12632 RVA: 0x0001A879 File Offset: 0x00018A79
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2080_0.method_2();
			}

			// Token: 0x06003159 RID: 12633 RVA: 0x0010BCBC File Offset: 0x00109EBC
			public Class2043 method_0()
			{
				return this.class2080_0.method_3(this.int_0);
			}

			// Token: 0x040016E9 RID: 5865
			private int int_0;

			// Token: 0x040016EA RID: 5866
			private Class2080 class2080_0;
		}
	}
}
