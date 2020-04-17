using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x020002D8 RID: 728
	public sealed class Class2164 : Class2059
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x0000CF25 File Offset: 0x0000B125
		public Class2164()
		{
			this.method_8();
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0000CF54 File Offset: 0x0000B154
		public Class2164(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00069CD8 File Offset: 0x00067ED8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "type");
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00069CF8 File Offset: 0x00067EF8
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "type", int_0)));
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_7(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000CF84 File Offset: 0x0000B184
		private void method_8()
		{
			this.class1851_0.method_0(this);
			this.class1853_0.method_0(this);
			this.class1855_0.method_0(this);
		}

		// Token: 0x040006E1 RID: 1761
		public Class2164.Class1851 class1851_0 = new Class2164.Class1851();

		// Token: 0x040006E2 RID: 1762
		public Class2164.Class1853 class1853_0 = new Class2164.Class1853();

		// Token: 0x040006E3 RID: 1763
		public Class2164.Class1855 class1855_0 = new Class2164.Class1855();

		// Token: 0x020002D9 RID: 729
		public sealed class Class1851 : IEnumerable
		{
			// Token: 0x060010FB RID: 4347 RVA: 0x0000CFAA File Offset: 0x0000B1AA
			public void method_0(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
			}

			// Token: 0x060010FC RID: 4348 RVA: 0x0007EDC4 File Offset: 0x0007CFC4
			public Class2164.Class1852 method_1()
			{
				return new Class2164.Class1852(this.class2164_0);
			}

			// Token: 0x060010FD RID: 4349 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006E4 RID: 1764
			private Class2164 class2164_0;
		}

		// Token: 0x020002DA RID: 730
		public sealed class Class1852 : IEnumerator
		{
			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060010FF RID: 4351 RVA: 0x0007EDF8 File Offset: 0x0007CFF8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001100 RID: 4352 RVA: 0x0000CFB3 File Offset: 0x0000B1B3
			public Class1852(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
				this.int_0 = -1;
			}

			// Token: 0x06001101 RID: 4353 RVA: 0x0000CFC9 File Offset: 0x0000B1C9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001102 RID: 4354 RVA: 0x0000CFD2 File Offset: 0x0000B1D2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2164_0.method_2();
			}

			// Token: 0x06001103 RID: 4355 RVA: 0x0007EE10 File Offset: 0x0007D010
			public Class2050 method_0()
			{
				return this.class2164_0.method_3(this.int_0);
			}

			// Token: 0x040006E5 RID: 1765
			private int int_0;

			// Token: 0x040006E6 RID: 1766
			private Class2164 class2164_0;
		}

		// Token: 0x020002DB RID: 731
		public sealed class Class1853 : IEnumerable
		{
			// Token: 0x06001104 RID: 4356 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
			public void method_0(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
			}

			// Token: 0x06001105 RID: 4357 RVA: 0x0007EE30 File Offset: 0x0007D030
			public Class2164.Class1854 method_1()
			{
				return new Class2164.Class1854(this.class2164_0);
			}

			// Token: 0x06001106 RID: 4358 RVA: 0x0007EE4C File Offset: 0x0007D04C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006E7 RID: 1767
			private Class2164 class2164_0;
		}

		// Token: 0x020002DC RID: 732
		public sealed class Class1854 : IEnumerator
		{
			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06001108 RID: 4360 RVA: 0x0007EE64 File Offset: 0x0007D064
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001109 RID: 4361 RVA: 0x0000CFFE File Offset: 0x0000B1FE
			public Class1854(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
				this.int_0 = -1;
			}

			// Token: 0x0600110A RID: 4362 RVA: 0x0000D014 File Offset: 0x0000B214
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600110B RID: 4363 RVA: 0x0000D01D File Offset: 0x0000B21D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2164_0.method_4();
			}

			// Token: 0x0600110C RID: 4364 RVA: 0x0007EE7C File Offset: 0x0007D07C
			public Class2050 method_0()
			{
				return this.class2164_0.method_5(this.int_0);
			}

			// Token: 0x040006E8 RID: 1768
			private int int_0;

			// Token: 0x040006E9 RID: 1769
			private Class2164 class2164_0;
		}

		// Token: 0x020002DD RID: 733
		public sealed class Class1855 : IEnumerable
		{
			// Token: 0x0600110D RID: 4365 RVA: 0x0000D040 File Offset: 0x0000B240
			public void method_0(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
			}

			// Token: 0x0600110E RID: 4366 RVA: 0x0007EE9C File Offset: 0x0007D09C
			public Class2164.Class1856 method_1()
			{
				return new Class2164.Class1856(this.class2164_0);
			}

			// Token: 0x0600110F RID: 4367 RVA: 0x0007EEB8 File Offset: 0x0007D0B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006EA RID: 1770
			private Class2164 class2164_0;
		}

		// Token: 0x020002DE RID: 734
		public sealed class Class1856 : IEnumerator
		{
			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06001111 RID: 4369 RVA: 0x0007EED0 File Offset: 0x0007D0D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001112 RID: 4370 RVA: 0x0000D049 File Offset: 0x0000B249
			public Class1856(Class2164 class2164_1)
			{
				this.class2164_0 = class2164_1;
				this.int_0 = -1;
			}

			// Token: 0x06001113 RID: 4371 RVA: 0x0000D05F File Offset: 0x0000B25F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001114 RID: 4372 RVA: 0x0000D068 File Offset: 0x0000B268
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2164_0.method_6();
			}

			// Token: 0x06001115 RID: 4373 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
			public Class2165 method_0()
			{
				return this.class2164_0.method_7(this.int_0);
			}

			// Token: 0x040006EB RID: 1771
			private int int_0;

			// Token: 0x040006EC RID: 1772
			private Class2164 class2164_0;
		}
	}
}
