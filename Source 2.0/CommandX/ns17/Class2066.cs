using System;
using System.Collections;
using ns15;
using ns16;

namespace ns17
{
	// Token: 0x020006C1 RID: 1729
	public sealed class Class2066 : Class2059
	{
		// Token: 0x06002BA0 RID: 11168 RVA: 0x00017B9A File Offset: 0x00015D9A
		public Class2066()
		{
			this.method_10();
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000FF148 File Offset: 0x000FD348
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "Name");
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000FF168 File Offset: 0x000FD368
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "Name", int_0)));
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00100A98 File Offset: 0x000FEC98
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "EquatorialRadius");
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00100AB8 File Offset: 0x000FECB8
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "EquatorialRadius", int_0)));
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00100AE4 File Offset: 0x000FECE4
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "LayerDirectory");
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00100B04 File Offset: 0x000FED04
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "LayerDirectory", int_0)));
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00100B30 File Offset: 0x000FED30
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TerrainAccessor");
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00100B50 File Offset: 0x000FED50
		public Class2064 method_9(int int_0)
		{
			return new Class2064(base.method_1(Class2059.Enum155.const_1, "", "TerrainAccessor", int_0));
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00017BD4 File Offset: 0x00015DD4
		private void method_10()
		{
			this.class897_0.method_0(this);
			this.class899_0.method_0(this);
			this.class901_0.method_0(this);
			this.class903_0.method_0(this);
		}

		// Token: 0x04001498 RID: 5272
		public Class2066.Class897 class897_0 = new Class2066.Class897();

		// Token: 0x04001499 RID: 5273
		public Class2066.Class899 class899_0 = new Class2066.Class899();

		// Token: 0x0400149A RID: 5274
		public Class2066.Class901 class901_0 = new Class2066.Class901();

		// Token: 0x0400149B RID: 5275
		public Class2066.Class903 class903_0 = new Class2066.Class903();

		// Token: 0x020006C2 RID: 1730
		public sealed class Class897 : IEnumerable
		{
			// Token: 0x06002BAA RID: 11178 RVA: 0x00017C06 File Offset: 0x00015E06
			public void method_0(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
			}

			// Token: 0x06002BAB RID: 11179 RVA: 0x00100B78 File Offset: 0x000FED78
			public Class2066.Class898 method_1()
			{
				return new Class2066.Class898(this.class2066_0);
			}

			// Token: 0x06002BAC RID: 11180 RVA: 0x00100B94 File Offset: 0x000FED94
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400149C RID: 5276
			private Class2066 class2066_0;
		}

		// Token: 0x020006C3 RID: 1731
		public sealed class Class898 : IEnumerator
		{
			// Token: 0x17000306 RID: 774
			// (get) Token: 0x06002BAE RID: 11182 RVA: 0x00100BAC File Offset: 0x000FEDAC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002BAF RID: 11183 RVA: 0x00017C0F File Offset: 0x00015E0F
			public Class898(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
				this.int_0 = -1;
			}

			// Token: 0x06002BB0 RID: 11184 RVA: 0x00017C25 File Offset: 0x00015E25
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002BB1 RID: 11185 RVA: 0x00017C2E File Offset: 0x00015E2E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2066_0.method_2();
			}

			// Token: 0x06002BB2 RID: 11186 RVA: 0x00100BC4 File Offset: 0x000FEDC4
			public Class2050 method_0()
			{
				return this.class2066_0.method_3(this.int_0);
			}

			// Token: 0x0400149D RID: 5277
			private int int_0;

			// Token: 0x0400149E RID: 5278
			private Class2066 class2066_0;
		}

		// Token: 0x020006C4 RID: 1732
		public sealed class Class899 : IEnumerable
		{
			// Token: 0x06002BB3 RID: 11187 RVA: 0x00017C51 File Offset: 0x00015E51
			public void method_0(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
			}

			// Token: 0x06002BB4 RID: 11188 RVA: 0x00100BE4 File Offset: 0x000FEDE4
			public Class2066.Class900 method_1()
			{
				return new Class2066.Class900(this.class2066_0);
			}

			// Token: 0x06002BB5 RID: 11189 RVA: 0x00100C00 File Offset: 0x000FEE00
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400149F RID: 5279
			private Class2066 class2066_0;
		}

		// Token: 0x020006C5 RID: 1733
		public sealed class Class900 : IEnumerator
		{
			// Token: 0x17000307 RID: 775
			// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x00100C18 File Offset: 0x000FEE18
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002BB8 RID: 11192 RVA: 0x00017C5A File Offset: 0x00015E5A
			public Class900(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
				this.int_0 = -1;
			}

			// Token: 0x06002BB9 RID: 11193 RVA: 0x00017C70 File Offset: 0x00015E70
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002BBA RID: 11194 RVA: 0x00017C79 File Offset: 0x00015E79
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2066_0.method_4();
			}

			// Token: 0x06002BBB RID: 11195 RVA: 0x00100C30 File Offset: 0x000FEE30
			public Class2020 method_0()
			{
				return this.class2066_0.method_5(this.int_0);
			}

			// Token: 0x040014A0 RID: 5280
			private int int_0;

			// Token: 0x040014A1 RID: 5281
			private Class2066 class2066_0;
		}

		// Token: 0x020006C6 RID: 1734
		public sealed class Class901 : IEnumerable
		{
			// Token: 0x06002BBC RID: 11196 RVA: 0x00017C9C File Offset: 0x00015E9C
			public void method_0(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
			}

			// Token: 0x06002BBD RID: 11197 RVA: 0x00100C50 File Offset: 0x000FEE50
			public Class2066.Class902 method_1()
			{
				return new Class2066.Class902(this.class2066_0);
			}

			// Token: 0x06002BBE RID: 11198 RVA: 0x00100C6C File Offset: 0x000FEE6C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014A2 RID: 5282
			private Class2066 class2066_0;
		}

		// Token: 0x020006C7 RID: 1735
		public sealed class Class902 : IEnumerator
		{
			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x00100C84 File Offset: 0x000FEE84
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002BC1 RID: 11201 RVA: 0x00017CA5 File Offset: 0x00015EA5
			public Class902(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
				this.int_0 = -1;
			}

			// Token: 0x06002BC2 RID: 11202 RVA: 0x00017CBB File Offset: 0x00015EBB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002BC3 RID: 11203 RVA: 0x00017CC4 File Offset: 0x00015EC4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2066_0.method_6();
			}

			// Token: 0x06002BC4 RID: 11204 RVA: 0x00100C9C File Offset: 0x000FEE9C
			public Class2050 method_0()
			{
				return this.class2066_0.method_7(this.int_0);
			}

			// Token: 0x040014A3 RID: 5283
			private int int_0;

			// Token: 0x040014A4 RID: 5284
			private Class2066 class2066_0;
		}

		// Token: 0x020006C8 RID: 1736
		public sealed class Class903 : IEnumerable
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x00017CE7 File Offset: 0x00015EE7
			public void method_0(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
			}

			// Token: 0x06002BC6 RID: 11206 RVA: 0x00100CBC File Offset: 0x000FEEBC
			public Class2066.Class904 method_1()
			{
				return new Class2066.Class904(this.class2066_0);
			}

			// Token: 0x06002BC7 RID: 11207 RVA: 0x00100CD8 File Offset: 0x000FEED8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040014A5 RID: 5285
			private Class2066 class2066_0;
		}

		// Token: 0x020006C9 RID: 1737
		public sealed class Class904 : IEnumerator
		{
			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x00100CF0 File Offset: 0x000FEEF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002BCA RID: 11210 RVA: 0x00017CF0 File Offset: 0x00015EF0
			public Class904(Class2066 class2066_1)
			{
				this.class2066_0 = class2066_1;
				this.int_0 = -1;
			}

			// Token: 0x06002BCB RID: 11211 RVA: 0x00017D06 File Offset: 0x00015F06
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002BCC RID: 11212 RVA: 0x00017D0F File Offset: 0x00015F0F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2066_0.method_8();
			}

			// Token: 0x06002BCD RID: 11213 RVA: 0x00100D08 File Offset: 0x000FEF08
			public Class2064 method_0()
			{
				return this.class2066_0.method_9(this.int_0);
			}

			// Token: 0x040014A6 RID: 5286
			private int int_0;

			// Token: 0x040014A7 RID: 5287
			private Class2066 class2066_0;
		}
	}
}
