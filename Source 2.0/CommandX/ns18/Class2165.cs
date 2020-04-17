using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x020002E0 RID: 736
	public sealed class Class2165 : Class2059
	{
		// Token: 0x06001137 RID: 4407 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		public Class2165()
		{
			this.method_8();
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0000D10B File Offset: 0x0000B30B
		public Class2165(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0007F804 File Offset: 0x0007DA04
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "xmlns:xlink");
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0007F824 File Offset: 0x0007DA24
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "xmlns:xlink", int_0)));
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0007F850 File Offset: 0x0007DA50
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "xlink:type");
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0007F870 File Offset: 0x0007DA70
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "xlink:type", int_0)));
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0007F89C File Offset: 0x0007DA9C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "xlink:href");
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0007F8BC File Offset: 0x0007DABC
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "xlink:href", int_0)));
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0000D13B File Offset: 0x0000B33B
		private void method_8()
		{
			this.class1857_0.method_0(this);
			this.class1859_0.method_0(this);
			this.class1861_0.method_0(this);
		}

		// Token: 0x040006F8 RID: 1784
		public Class2165.Class1857 class1857_0 = new Class2165.Class1857();

		// Token: 0x040006F9 RID: 1785
		public Class2165.Class1859 class1859_0 = new Class2165.Class1859();

		// Token: 0x040006FA RID: 1786
		public Class2165.Class1861 class1861_0 = new Class2165.Class1861();

		// Token: 0x020002E1 RID: 737
		public sealed class Class1857 : IEnumerable
		{
			// Token: 0x06001140 RID: 4416 RVA: 0x0000D161 File Offset: 0x0000B361
			public void method_0(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
			}

			// Token: 0x06001141 RID: 4417 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
			public Class2165.Class1858 method_1()
			{
				return new Class2165.Class1858(this.class2165_0);
			}

			// Token: 0x06001142 RID: 4418 RVA: 0x0007F904 File Offset: 0x0007DB04
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006FB RID: 1787
			private Class2165 class2165_0;
		}

		// Token: 0x020002E2 RID: 738
		public sealed class Class1858 : IEnumerator
		{
			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06001144 RID: 4420 RVA: 0x0007F91C File Offset: 0x0007DB1C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001145 RID: 4421 RVA: 0x0000D16A File Offset: 0x0000B36A
			public Class1858(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
				this.int_0 = -1;
			}

			// Token: 0x06001146 RID: 4422 RVA: 0x0000D180 File Offset: 0x0000B380
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001147 RID: 4423 RVA: 0x0000D189 File Offset: 0x0000B389
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2165_0.method_2();
			}

			// Token: 0x06001148 RID: 4424 RVA: 0x0007F934 File Offset: 0x0007DB34
			public Class2050 method_0()
			{
				return this.class2165_0.method_3(this.int_0);
			}

			// Token: 0x040006FC RID: 1788
			private int int_0;

			// Token: 0x040006FD RID: 1789
			private Class2165 class2165_0;
		}

		// Token: 0x020002E3 RID: 739
		public sealed class Class1859 : IEnumerable
		{
			// Token: 0x06001149 RID: 4425 RVA: 0x0000D1AC File Offset: 0x0000B3AC
			public void method_0(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
			}

			// Token: 0x0600114A RID: 4426 RVA: 0x0007F954 File Offset: 0x0007DB54
			public Class2165.Class1860 method_1()
			{
				return new Class2165.Class1860(this.class2165_0);
			}

			// Token: 0x0600114B RID: 4427 RVA: 0x0007F970 File Offset: 0x0007DB70
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006FE RID: 1790
			private Class2165 class2165_0;
		}

		// Token: 0x020002E4 RID: 740
		public sealed class Class1860 : IEnumerator
		{
			// Token: 0x17000184 RID: 388
			// (get) Token: 0x0600114D RID: 4429 RVA: 0x0007F988 File Offset: 0x0007DB88
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600114E RID: 4430 RVA: 0x0000D1B5 File Offset: 0x0000B3B5
			public Class1860(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
				this.int_0 = -1;
			}

			// Token: 0x0600114F RID: 4431 RVA: 0x0000D1CB File Offset: 0x0000B3CB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001150 RID: 4432 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2165_0.method_4();
			}

			// Token: 0x06001151 RID: 4433 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
			public Class2050 method_0()
			{
				return this.class2165_0.method_5(this.int_0);
			}

			// Token: 0x040006FF RID: 1791
			private int int_0;

			// Token: 0x04000700 RID: 1792
			private Class2165 class2165_0;
		}

		// Token: 0x020002E5 RID: 741
		public sealed class Class1861 : IEnumerable
		{
			// Token: 0x06001152 RID: 4434 RVA: 0x0000D1F7 File Offset: 0x0000B3F7
			public void method_0(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
			}

			// Token: 0x06001153 RID: 4435 RVA: 0x0007F9C0 File Offset: 0x0007DBC0
			public Class2165.Class1862 method_1()
			{
				return new Class2165.Class1862(this.class2165_0);
			}

			// Token: 0x06001154 RID: 4436 RVA: 0x0007F9DC File Offset: 0x0007DBDC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000701 RID: 1793
			private Class2165 class2165_0;
		}

		// Token: 0x020002E6 RID: 742
		public sealed class Class1862 : IEnumerator
		{
			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06001156 RID: 4438 RVA: 0x0007F9F4 File Offset: 0x0007DBF4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001157 RID: 4439 RVA: 0x0000D200 File Offset: 0x0000B400
			public Class1862(Class2165 class2165_1)
			{
				this.class2165_0 = class2165_1;
				this.int_0 = -1;
			}

			// Token: 0x06001158 RID: 4440 RVA: 0x0000D216 File Offset: 0x0000B416
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001159 RID: 4441 RVA: 0x0000D21F File Offset: 0x0000B41F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2165_0.method_6();
			}

			// Token: 0x0600115A RID: 4442 RVA: 0x0007FA0C File Offset: 0x0007DC0C
			public Class2050 method_0()
			{
				return this.class2165_0.method_7(this.int_0);
			}

			// Token: 0x04000702 RID: 1794
			private int int_0;

			// Token: 0x04000703 RID: 1795
			private Class2165 class2165_0;
		}
	}
}
