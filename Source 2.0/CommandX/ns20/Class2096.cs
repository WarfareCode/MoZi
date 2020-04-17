using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x020008D2 RID: 2258
	public sealed class Class2096 : Class2059
	{
		// Token: 0x06003766 RID: 14182 RVA: 0x0001D72C File Offset: 0x0001B92C
		public Class2096()
		{
			this.method_8();
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x0001D75B File Offset: 0x0001B95B
		public Class2096(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0011F098 File Offset: 0x0011D298
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Red");
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x0011F2C0 File Offset: 0x0011D4C0
		public Class2017 method_3(int int_0)
		{
			return new Class2017(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Red", int_0)));
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x0011F0E4 File Offset: 0x0011D2E4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Green");
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0011F2EC File Offset: 0x0011D4EC
		public Class2014 method_5(int int_0)
		{
			return new Class2014(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Green", int_0)));
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x0011F130 File Offset: 0x0011D330
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Blue");
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0011F318 File Offset: 0x0011D518
		public Class2012 method_7(int int_0)
		{
			return new Class2012(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Blue", int_0)));
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0001D78B File Offset: 0x0001B98B
		private void method_8()
		{
			this.class1233_0.method_0(this);
			this.class1235_0.method_0(this);
			this.class1237_0.method_0(this);
		}

		// Token: 0x0400196E RID: 6510
		public Class2096.Class1233 class1233_0 = new Class2096.Class1233();

		// Token: 0x0400196F RID: 6511
		public Class2096.Class1235 class1235_0 = new Class2096.Class1235();

		// Token: 0x04001970 RID: 6512
		public Class2096.Class1237 class1237_0 = new Class2096.Class1237();

		// Token: 0x020008D3 RID: 2259
		public sealed class Class1233 : IEnumerable
		{
			// Token: 0x0600376F RID: 14191 RVA: 0x0001D7B1 File Offset: 0x0001B9B1
			public void method_0(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
			}

			// Token: 0x06003770 RID: 14192 RVA: 0x0011F344 File Offset: 0x0011D544
			public Class2096.Class1234 method_1()
			{
				return new Class2096.Class1234(this.class2096_0);
			}

			// Token: 0x06003771 RID: 14193 RVA: 0x0011F360 File Offset: 0x0011D560
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001971 RID: 6513
			private Class2096 class2096_0;
		}

		// Token: 0x020008D4 RID: 2260
		public sealed class Class1234 : IEnumerator
		{
			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06003773 RID: 14195 RVA: 0x0011F378 File Offset: 0x0011D578
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003774 RID: 14196 RVA: 0x0001D7BA File Offset: 0x0001B9BA
			public Class1234(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
				this.int_0 = -1;
			}

			// Token: 0x06003775 RID: 14197 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003776 RID: 14198 RVA: 0x0001D7D9 File Offset: 0x0001B9D9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2096_0.method_2();
			}

			// Token: 0x06003777 RID: 14199 RVA: 0x0011F390 File Offset: 0x0011D590
			public Class2017 method_0()
			{
				return this.class2096_0.method_3(this.int_0);
			}

			// Token: 0x04001972 RID: 6514
			private int int_0;

			// Token: 0x04001973 RID: 6515
			private Class2096 class2096_0;
		}

		// Token: 0x020008D5 RID: 2261
		public sealed class Class1235 : IEnumerable
		{
			// Token: 0x06003778 RID: 14200 RVA: 0x0001D7FC File Offset: 0x0001B9FC
			public void method_0(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
			}

			// Token: 0x06003779 RID: 14201 RVA: 0x0011F3B0 File Offset: 0x0011D5B0
			public Class2096.Class1236 method_1()
			{
				return new Class2096.Class1236(this.class2096_0);
			}

			// Token: 0x0600377A RID: 14202 RVA: 0x0011F3CC File Offset: 0x0011D5CC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001974 RID: 6516
			private Class2096 class2096_0;
		}

		// Token: 0x020008D6 RID: 2262
		public sealed class Class1236 : IEnumerator
		{
			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x0600377C RID: 14204 RVA: 0x0011F3E4 File Offset: 0x0011D5E4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600377D RID: 14205 RVA: 0x0001D805 File Offset: 0x0001BA05
			public Class1236(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
				this.int_0 = -1;
			}

			// Token: 0x0600377E RID: 14206 RVA: 0x0001D81B File Offset: 0x0001BA1B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600377F RID: 14207 RVA: 0x0001D824 File Offset: 0x0001BA24
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2096_0.method_4();
			}

			// Token: 0x06003780 RID: 14208 RVA: 0x0011F3FC File Offset: 0x0011D5FC
			public Class2014 method_0()
			{
				return this.class2096_0.method_5(this.int_0);
			}

			// Token: 0x04001975 RID: 6517
			private int int_0;

			// Token: 0x04001976 RID: 6518
			private Class2096 class2096_0;
		}

		// Token: 0x020008D7 RID: 2263
		public sealed class Class1237 : IEnumerable
		{
			// Token: 0x06003781 RID: 14209 RVA: 0x0001D847 File Offset: 0x0001BA47
			public void method_0(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
			}

			// Token: 0x06003782 RID: 14210 RVA: 0x0011F41C File Offset: 0x0011D61C
			public Class2096.Class1238 method_1()
			{
				return new Class2096.Class1238(this.class2096_0);
			}

			// Token: 0x06003783 RID: 14211 RVA: 0x0011F438 File Offset: 0x0011D638
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001977 RID: 6519
			private Class2096 class2096_0;
		}

		// Token: 0x020008D8 RID: 2264
		public sealed class Class1238 : IEnumerator
		{
			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06003785 RID: 14213 RVA: 0x0011F450 File Offset: 0x0011D650
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003786 RID: 14214 RVA: 0x0001D850 File Offset: 0x0001BA50
			public Class1238(Class2096 class2096_1)
			{
				this.class2096_0 = class2096_1;
				this.int_0 = -1;
			}

			// Token: 0x06003787 RID: 14215 RVA: 0x0001D866 File Offset: 0x0001BA66
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003788 RID: 14216 RVA: 0x0001D86F File Offset: 0x0001BA6F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2096_0.method_6();
			}

			// Token: 0x06003789 RID: 14217 RVA: 0x0011F468 File Offset: 0x0011D668
			public Class2012 method_0()
			{
				return this.class2096_0.method_7(this.int_0);
			}

			// Token: 0x04001978 RID: 6520
			private int int_0;

			// Token: 0x04001979 RID: 6521
			private Class2096 class2096_0;
		}
	}
}
