using System;
using System.Collections;
using ns16;

namespace ns17
{
	// Token: 0x020006E0 RID: 1760
	public sealed class Class2068 : Class2059
	{
		// Token: 0x06002C2A RID: 11306 RVA: 0x00017F62 File Offset: 0x00016162
		public Class2068()
		{
			this.method_4();
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x001014E0 File Offset: 0x000FF6E0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Server");
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00101500 File Offset: 0x000FF700
		public Class2067 method_3(int int_0)
		{
			return new Class2067(base.method_1(Class2059.Enum155.const_1, "", "Server", int_0));
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00017F7B File Offset: 0x0001617B
		private void method_4()
		{
			this.class917_0.method_0(this);
		}

		// Token: 0x040014D4 RID: 5332
		public Class2068.Class917 class917_0 = new Class2068.Class917();

		// Token: 0x020006E1 RID: 1761
		public sealed class Class917 : IEnumerable
		{
			// Token: 0x06002C2E RID: 11310 RVA: 0x00017F89 File Offset: 0x00016189
			public void method_0(Class2068 class2068_1)
			{
				this.class2068_0 = class2068_1;
			}

			// Token: 0x06002C2F RID: 11311 RVA: 0x00101528 File Offset: 0x000FF728
			public Class2068.Class918 method_1()
			{
				return new Class2068.Class918(this.class2068_0);
			}

			// Token: 0x06002C30 RID: 11312 RVA: 0x00101544 File Offset: 0x000FF744
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014D5 RID: 5333
			private Class2068 class2068_0;
		}

		// Token: 0x020006E2 RID: 1762
		public sealed class Class918 : IEnumerator
		{
			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06002C32 RID: 11314 RVA: 0x0010155C File Offset: 0x000FF75C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002C33 RID: 11315 RVA: 0x00017F92 File Offset: 0x00016192
			public Class918(Class2068 class2068_1)
			{
				this.class2068_0 = class2068_1;
				this.int_0 = -1;
			}

			// Token: 0x06002C34 RID: 11316 RVA: 0x00017FA8 File Offset: 0x000161A8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002C35 RID: 11317 RVA: 0x00017FB1 File Offset: 0x000161B1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2068_0.method_2();
			}

			// Token: 0x06002C36 RID: 11318 RVA: 0x00101574 File Offset: 0x000FF774
			public Class2067 method_0()
			{
				return this.class2068_0.method_3(this.int_0);
			}

			// Token: 0x040014D6 RID: 5334
			private int int_0;

			// Token: 0x040014D7 RID: 5335
			private Class2068 class2068_0;
		}
	}
}
