using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x02000321 RID: 801
	public sealed class Class2172 : Class2059
	{
		// Token: 0x060012E7 RID: 4839 RVA: 0x000845C0 File Offset: 0x000827C0
		public Class2172()
		{
			this.method_14();
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0008461C File Offset: 0x0008281C
		public Class2172(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00077908 File Offset: 0x00075B08
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Title");
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00077928 File Offset: 0x00075B28
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Title", int_0)));
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0007D178 File Offset: 0x0007B378
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Abstract");
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0007D198 File Offset: 0x0007B398
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Abstract", int_0)));
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00084678 File Offset: 0x00082878
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LegendURL");
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00084698 File Offset: 0x00082898
		public Class2162 method_9(int int_0)
		{
			return new Class2162(base.method_1(Class2059.Enum155.const_1, "", "LegendURL", int_0));
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000846C0 File Offset: 0x000828C0
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "StyleSheetURL");
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000846E0 File Offset: 0x000828E0
		public Class2171 method_11(int int_0)
		{
			return new Class2171(base.method_1(Class2059.Enum155.const_1, "", "StyleSheetURL", int_0));
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00084708 File Offset: 0x00082908
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "StyleURL");
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00084728 File Offset: 0x00082928
		public Class2173 method_13(int int_0)
		{
			return new Class2173(base.method_1(Class2059.Enum155.const_1, "", "StyleURL", int_0));
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00084750 File Offset: 0x00082950
		private void method_14()
		{
			this.class1907_0.method_0(this);
			this.class1909_0.method_0(this);
			this.class1911_0.method_0(this);
			this.class1913_0.method_0(this);
			this.class1915_0.method_0(this);
			this.class1917_0.method_0(this);
		}

		// Token: 0x040007DF RID: 2015
		public Class2172.Class1907 class1907_0 = new Class2172.Class1907();

		// Token: 0x040007E0 RID: 2016
		public Class2172.Class1909 class1909_0 = new Class2172.Class1909();

		// Token: 0x040007E1 RID: 2017
		public Class2172.Class1911 class1911_0 = new Class2172.Class1911();

		// Token: 0x040007E2 RID: 2018
		public Class2172.Class1913 class1913_0 = new Class2172.Class1913();

		// Token: 0x040007E3 RID: 2019
		public Class2172.Class1915 class1915_0 = new Class2172.Class1915();

		// Token: 0x040007E4 RID: 2020
		public Class2172.Class1917 class1917_0 = new Class2172.Class1917();

		// Token: 0x02000322 RID: 802
		public sealed class Class1907 : IEnumerable
		{
			// Token: 0x060012F6 RID: 4854 RVA: 0x0000DBDB File Offset: 0x0000BDDB
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x060012F7 RID: 4855 RVA: 0x000847A8 File Offset: 0x000829A8
			public Class2172.Class1908 method_1()
			{
				return new Class2172.Class1908(this.class2172_0);
			}

			// Token: 0x060012F8 RID: 4856 RVA: 0x000847C4 File Offset: 0x000829C4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007E5 RID: 2021
			private Class2172 class2172_0;
		}

		// Token: 0x02000323 RID: 803
		public sealed class Class1908 : IEnumerator
		{
			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060012FA RID: 4858 RVA: 0x000847DC File Offset: 0x000829DC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060012FB RID: 4859 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
			public Class1908(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x060012FC RID: 4860 RVA: 0x0000DBFA File Offset: 0x0000BDFA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060012FD RID: 4861 RVA: 0x0000DC03 File Offset: 0x0000BE03
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_2();
			}

			// Token: 0x060012FE RID: 4862 RVA: 0x000847F4 File Offset: 0x000829F4
			public Class2050 method_0()
			{
				return this.class2172_0.method_3(this.int_0);
			}

			// Token: 0x040007E6 RID: 2022
			private int int_0;

			// Token: 0x040007E7 RID: 2023
			private Class2172 class2172_0;
		}

		// Token: 0x02000324 RID: 804
		public sealed class Class1909 : IEnumerable
		{
			// Token: 0x060012FF RID: 4863 RVA: 0x0000DC26 File Offset: 0x0000BE26
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x06001300 RID: 4864 RVA: 0x00084814 File Offset: 0x00082A14
			public Class2172.Class1910 method_1()
			{
				return new Class2172.Class1910(this.class2172_0);
			}

			// Token: 0x06001301 RID: 4865 RVA: 0x00084830 File Offset: 0x00082A30
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007E8 RID: 2024
			private Class2172 class2172_0;
		}

		// Token: 0x02000325 RID: 805
		public sealed class Class1910 : IEnumerator
		{
			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06001303 RID: 4867 RVA: 0x00084848 File Offset: 0x00082A48
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001304 RID: 4868 RVA: 0x0000DC2F File Offset: 0x0000BE2F
			public Class1910(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x06001305 RID: 4869 RVA: 0x0000DC45 File Offset: 0x0000BE45
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001306 RID: 4870 RVA: 0x0000DC4E File Offset: 0x0000BE4E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_4();
			}

			// Token: 0x06001307 RID: 4871 RVA: 0x00084860 File Offset: 0x00082A60
			public Class2050 method_0()
			{
				return this.class2172_0.method_5(this.int_0);
			}

			// Token: 0x040007E9 RID: 2025
			private int int_0;

			// Token: 0x040007EA RID: 2026
			private Class2172 class2172_0;
		}

		// Token: 0x02000326 RID: 806
		public sealed class Class1911 : IEnumerable
		{
			// Token: 0x06001308 RID: 4872 RVA: 0x0000DC71 File Offset: 0x0000BE71
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x06001309 RID: 4873 RVA: 0x00084880 File Offset: 0x00082A80
			public Class2172.Class1912 method_1()
			{
				return new Class2172.Class1912(this.class2172_0);
			}

			// Token: 0x0600130A RID: 4874 RVA: 0x0008489C File Offset: 0x00082A9C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007EB RID: 2027
			private Class2172 class2172_0;
		}

		// Token: 0x02000327 RID: 807
		public sealed class Class1912 : IEnumerator
		{
			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600130C RID: 4876 RVA: 0x000848B4 File Offset: 0x00082AB4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x0000DC7A File Offset: 0x0000BE7A
			public Class1912(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x0600130E RID: 4878 RVA: 0x0000DC90 File Offset: 0x0000BE90
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600130F RID: 4879 RVA: 0x0000DC99 File Offset: 0x0000BE99
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_6();
			}

			// Token: 0x06001310 RID: 4880 RVA: 0x000848CC File Offset: 0x00082ACC
			public Class2050 method_0()
			{
				return this.class2172_0.method_7(this.int_0);
			}

			// Token: 0x040007EC RID: 2028
			private int int_0;

			// Token: 0x040007ED RID: 2029
			private Class2172 class2172_0;
		}

		// Token: 0x02000328 RID: 808
		public sealed class Class1913 : IEnumerable
		{
			// Token: 0x06001311 RID: 4881 RVA: 0x0000DCBC File Offset: 0x0000BEBC
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x06001312 RID: 4882 RVA: 0x000848EC File Offset: 0x00082AEC
			public Class2172.Class1914 method_1()
			{
				return new Class2172.Class1914(this.class2172_0);
			}

			// Token: 0x06001313 RID: 4883 RVA: 0x00084908 File Offset: 0x00082B08
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007EE RID: 2030
			private Class2172 class2172_0;
		}

		// Token: 0x02000329 RID: 809
		public sealed class Class1914 : IEnumerator
		{
			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06001315 RID: 4885 RVA: 0x00084920 File Offset: 0x00082B20
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001316 RID: 4886 RVA: 0x0000DCC5 File Offset: 0x0000BEC5
			public Class1914(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x06001317 RID: 4887 RVA: 0x0000DCDB File Offset: 0x0000BEDB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001318 RID: 4888 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_8();
			}

			// Token: 0x06001319 RID: 4889 RVA: 0x00084938 File Offset: 0x00082B38
			public Class2162 method_0()
			{
				return this.class2172_0.method_9(this.int_0);
			}

			// Token: 0x040007EF RID: 2031
			private int int_0;

			// Token: 0x040007F0 RID: 2032
			private Class2172 class2172_0;
		}

		// Token: 0x0200032A RID: 810
		public sealed class Class1915 : IEnumerable
		{
			// Token: 0x0600131A RID: 4890 RVA: 0x0000DD07 File Offset: 0x0000BF07
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x0600131B RID: 4891 RVA: 0x00084958 File Offset: 0x00082B58
			public Class2172.Class1916 method_1()
			{
				return new Class2172.Class1916(this.class2172_0);
			}

			// Token: 0x0600131C RID: 4892 RVA: 0x00084974 File Offset: 0x00082B74
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007F1 RID: 2033
			private Class2172 class2172_0;
		}

		// Token: 0x0200032B RID: 811
		public sealed class Class1916 : IEnumerator
		{
			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600131E RID: 4894 RVA: 0x0008498C File Offset: 0x00082B8C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600131F RID: 4895 RVA: 0x0000DD10 File Offset: 0x0000BF10
			public Class1916(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x06001320 RID: 4896 RVA: 0x0000DD26 File Offset: 0x0000BF26
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001321 RID: 4897 RVA: 0x0000DD2F File Offset: 0x0000BF2F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_10();
			}

			// Token: 0x06001322 RID: 4898 RVA: 0x000849A4 File Offset: 0x00082BA4
			public Class2171 method_0()
			{
				return this.class2172_0.method_11(this.int_0);
			}

			// Token: 0x040007F2 RID: 2034
			private int int_0;

			// Token: 0x040007F3 RID: 2035
			private Class2172 class2172_0;
		}

		// Token: 0x0200032C RID: 812
		public sealed class Class1917 : IEnumerable
		{
			// Token: 0x06001323 RID: 4899 RVA: 0x0000DD52 File Offset: 0x0000BF52
			public void method_0(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
			}

			// Token: 0x06001324 RID: 4900 RVA: 0x000849C4 File Offset: 0x00082BC4
			public Class2172.Class1918 method_1()
			{
				return new Class2172.Class1918(this.class2172_0);
			}

			// Token: 0x06001325 RID: 4901 RVA: 0x000849E0 File Offset: 0x00082BE0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007F4 RID: 2036
			private Class2172 class2172_0;
		}

		// Token: 0x0200032D RID: 813
		public sealed class Class1918 : IEnumerator
		{
			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06001327 RID: 4903 RVA: 0x000849F8 File Offset: 0x00082BF8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001328 RID: 4904 RVA: 0x0000DD5B File Offset: 0x0000BF5B
			public Class1918(Class2172 class2172_1)
			{
				this.class2172_0 = class2172_1;
				this.int_0 = -1;
			}

			// Token: 0x06001329 RID: 4905 RVA: 0x0000DD71 File Offset: 0x0000BF71
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600132A RID: 4906 RVA: 0x0000DD7A File Offset: 0x0000BF7A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2172_0.method_12();
			}

			// Token: 0x0600132B RID: 4907 RVA: 0x00084A10 File Offset: 0x00082C10
			public Class2173 method_0()
			{
				return this.class2172_0.method_13(this.int_0);
			}

			// Token: 0x040007F5 RID: 2037
			private int int_0;

			// Token: 0x040007F6 RID: 2038
			private Class2172 class2172_0;
		}
	}
}
