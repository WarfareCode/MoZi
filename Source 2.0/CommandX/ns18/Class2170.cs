using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns18
{
	// Token: 0x0200030A RID: 778
	public sealed class Class2170 : Class2059
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00083544 File Offset: 0x00081744
		public Class2170()
		{
			this.method_18();
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000835B8 File Offset: 0x000817B8
		public Class2170(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_18();
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00077908 File Offset: 0x00075B08
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Title");
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00077928 File Offset: 0x00075B28
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Title", int_0)));
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0007D178 File Offset: 0x0007B378
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Abstract");
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0007D198 File Offset: 0x0007B398
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Abstract", int_0)));
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0007D1C4 File Offset: 0x0007B3C4
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "KeywordList");
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0007D1E4 File Offset: 0x0007B3E4
		public Class2159 method_9(int int_0)
		{
			return new Class2159(base.method_1(Class2059.Enum155.const_1, "", "KeywordList", int_0));
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_11(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0008362C File Offset: 0x0008182C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactInformation");
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0008364C File Offset: 0x0008184C
		public Class2142 method_13(int int_0)
		{
			return new Class2142(base.method_1(Class2059.Enum155.const_1, "", "ContactInformation", int_0));
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00083674 File Offset: 0x00081874
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Fees");
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00083694 File Offset: 0x00081894
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Fees", int_0)));
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000836C0 File Offset: 0x000818C0
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "AccessConstraints");
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000836E0 File Offset: 0x000818E0
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "AccessConstraints", int_0)));
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0008370C File Offset: 0x0008190C
		private void method_18()
		{
			this.class1887_0.method_0(this);
			this.class1889_0.method_0(this);
			this.class1891_0.method_0(this);
			this.class1893_0.method_0(this);
			this.class1895_0.method_0(this);
			this.class1897_0.method_0(this);
			this.class1899_0.method_0(this);
			this.class1901_0.method_0(this);
		}

		// Token: 0x040007A5 RID: 1957
		public Class2170.Class1887 class1887_0 = new Class2170.Class1887();

		// Token: 0x040007A6 RID: 1958
		public Class2170.Class1889 class1889_0 = new Class2170.Class1889();

		// Token: 0x040007A7 RID: 1959
		public Class2170.Class1891 class1891_0 = new Class2170.Class1891();

		// Token: 0x040007A8 RID: 1960
		public Class2170.Class1893 class1893_0 = new Class2170.Class1893();

		// Token: 0x040007A9 RID: 1961
		public Class2170.Class1895 class1895_0 = new Class2170.Class1895();

		// Token: 0x040007AA RID: 1962
		public Class2170.Class1897 class1897_0 = new Class2170.Class1897();

		// Token: 0x040007AB RID: 1963
		public Class2170.Class1899 class1899_0 = new Class2170.Class1899();

		// Token: 0x040007AC RID: 1964
		public Class2170.Class1901 class1901_0 = new Class2170.Class1901();

		// Token: 0x0200030B RID: 779
		public sealed class Class1887 : IEnumerable
		{
			// Token: 0x06001269 RID: 4713 RVA: 0x0000D878 File Offset: 0x0000BA78
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x0600126A RID: 4714 RVA: 0x0008377C File Offset: 0x0008197C
			public Class2170.Class1888 method_1()
			{
				return new Class2170.Class1888(this.class2170_0);
			}

			// Token: 0x0600126B RID: 4715 RVA: 0x00083798 File Offset: 0x00081998
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007AD RID: 1965
			private Class2170 class2170_0;
		}

		// Token: 0x0200030C RID: 780
		public sealed class Class1888 : IEnumerator
		{
			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600126D RID: 4717 RVA: 0x000837B0 File Offset: 0x000819B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600126E RID: 4718 RVA: 0x0000D881 File Offset: 0x0000BA81
			public Class1888(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x0600126F RID: 4719 RVA: 0x0000D897 File Offset: 0x0000BA97
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001270 RID: 4720 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_2();
			}

			// Token: 0x06001271 RID: 4721 RVA: 0x000837C8 File Offset: 0x000819C8
			public Class2050 method_0()
			{
				return this.class2170_0.method_3(this.int_0);
			}

			// Token: 0x040007AE RID: 1966
			private int int_0;

			// Token: 0x040007AF RID: 1967
			private Class2170 class2170_0;
		}

		// Token: 0x0200030D RID: 781
		public sealed class Class1889 : IEnumerable
		{
			// Token: 0x06001272 RID: 4722 RVA: 0x0000D8C3 File Offset: 0x0000BAC3
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x06001273 RID: 4723 RVA: 0x000837E8 File Offset: 0x000819E8
			public Class2170.Class1890 method_1()
			{
				return new Class2170.Class1890(this.class2170_0);
			}

			// Token: 0x06001274 RID: 4724 RVA: 0x00083804 File Offset: 0x00081A04
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007B0 RID: 1968
			private Class2170 class2170_0;
		}

		// Token: 0x0200030E RID: 782
		public sealed class Class1890 : IEnumerator
		{
			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06001276 RID: 4726 RVA: 0x0008381C File Offset: 0x00081A1C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001277 RID: 4727 RVA: 0x0000D8CC File Offset: 0x0000BACC
			public Class1890(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x06001278 RID: 4728 RVA: 0x0000D8E2 File Offset: 0x0000BAE2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001279 RID: 4729 RVA: 0x0000D8EB File Offset: 0x0000BAEB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_4();
			}

			// Token: 0x0600127A RID: 4730 RVA: 0x00083834 File Offset: 0x00081A34
			public Class2050 method_0()
			{
				return this.class2170_0.method_5(this.int_0);
			}

			// Token: 0x040007B1 RID: 1969
			private int int_0;

			// Token: 0x040007B2 RID: 1970
			private Class2170 class2170_0;
		}

		// Token: 0x0200030F RID: 783
		public sealed class Class1891 : IEnumerable
		{
			// Token: 0x0600127B RID: 4731 RVA: 0x0000D90E File Offset: 0x0000BB0E
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x0600127C RID: 4732 RVA: 0x00083854 File Offset: 0x00081A54
			public Class2170.Class1892 method_1()
			{
				return new Class2170.Class1892(this.class2170_0);
			}

			// Token: 0x0600127D RID: 4733 RVA: 0x00083870 File Offset: 0x00081A70
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007B3 RID: 1971
			private Class2170 class2170_0;
		}

		// Token: 0x02000310 RID: 784
		public sealed class Class1892 : IEnumerator
		{
			// Token: 0x17000198 RID: 408
			// (get) Token: 0x0600127F RID: 4735 RVA: 0x00083888 File Offset: 0x00081A88
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001280 RID: 4736 RVA: 0x0000D917 File Offset: 0x0000BB17
			public Class1892(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x06001281 RID: 4737 RVA: 0x0000D92D File Offset: 0x0000BB2D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001282 RID: 4738 RVA: 0x0000D936 File Offset: 0x0000BB36
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_6();
			}

			// Token: 0x06001283 RID: 4739 RVA: 0x000838A0 File Offset: 0x00081AA0
			public Class2050 method_0()
			{
				return this.class2170_0.method_7(this.int_0);
			}

			// Token: 0x040007B4 RID: 1972
			private int int_0;

			// Token: 0x040007B5 RID: 1973
			private Class2170 class2170_0;
		}

		// Token: 0x02000311 RID: 785
		public sealed class Class1893 : IEnumerable
		{
			// Token: 0x06001284 RID: 4740 RVA: 0x0000D959 File Offset: 0x0000BB59
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x06001285 RID: 4741 RVA: 0x000838C0 File Offset: 0x00081AC0
			public Class2170.Class1894 method_1()
			{
				return new Class2170.Class1894(this.class2170_0);
			}

			// Token: 0x06001286 RID: 4742 RVA: 0x000838DC File Offset: 0x00081ADC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007B6 RID: 1974
			private Class2170 class2170_0;
		}

		// Token: 0x02000312 RID: 786
		public sealed class Class1894 : IEnumerator
		{
			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06001288 RID: 4744 RVA: 0x000838F4 File Offset: 0x00081AF4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001289 RID: 4745 RVA: 0x0000D962 File Offset: 0x0000BB62
			public Class1894(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x0600128A RID: 4746 RVA: 0x0000D978 File Offset: 0x0000BB78
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600128B RID: 4747 RVA: 0x0000D981 File Offset: 0x0000BB81
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_8();
			}

			// Token: 0x0600128C RID: 4748 RVA: 0x0008390C File Offset: 0x00081B0C
			public Class2159 method_0()
			{
				return this.class2170_0.method_9(this.int_0);
			}

			// Token: 0x040007B7 RID: 1975
			private int int_0;

			// Token: 0x040007B8 RID: 1976
			private Class2170 class2170_0;
		}

		// Token: 0x02000313 RID: 787
		public sealed class Class1895 : IEnumerable
		{
			// Token: 0x0600128D RID: 4749 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x0600128E RID: 4750 RVA: 0x0008392C File Offset: 0x00081B2C
			public Class2170.Class1896 method_1()
			{
				return new Class2170.Class1896(this.class2170_0);
			}

			// Token: 0x0600128F RID: 4751 RVA: 0x00083948 File Offset: 0x00081B48
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007B9 RID: 1977
			private Class2170 class2170_0;
		}

		// Token: 0x02000314 RID: 788
		public sealed class Class1896 : IEnumerator
		{
			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06001291 RID: 4753 RVA: 0x00083960 File Offset: 0x00081B60
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001292 RID: 4754 RVA: 0x0000D9AD File Offset: 0x0000BBAD
			public Class1896(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x06001293 RID: 4755 RVA: 0x0000D9C3 File Offset: 0x0000BBC3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001294 RID: 4756 RVA: 0x0000D9CC File Offset: 0x0000BBCC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_10();
			}

			// Token: 0x06001295 RID: 4757 RVA: 0x00083978 File Offset: 0x00081B78
			public Class2165 method_0()
			{
				return this.class2170_0.method_11(this.int_0);
			}

			// Token: 0x040007BA RID: 1978
			private int int_0;

			// Token: 0x040007BB RID: 1979
			private Class2170 class2170_0;
		}

		// Token: 0x02000315 RID: 789
		public sealed class Class1897 : IEnumerable
		{
			// Token: 0x06001296 RID: 4758 RVA: 0x0000D9EF File Offset: 0x0000BBEF
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x06001297 RID: 4759 RVA: 0x00083998 File Offset: 0x00081B98
			public Class2170.Class1898 method_1()
			{
				return new Class2170.Class1898(this.class2170_0);
			}

			// Token: 0x06001298 RID: 4760 RVA: 0x000839B4 File Offset: 0x00081BB4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007BC RID: 1980
			private Class2170 class2170_0;
		}

		// Token: 0x02000316 RID: 790
		public sealed class Class1898 : IEnumerator
		{
			// Token: 0x1700019B RID: 411
			// (get) Token: 0x0600129A RID: 4762 RVA: 0x000839CC File Offset: 0x00081BCC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600129B RID: 4763 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
			public Class1898(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x0600129C RID: 4764 RVA: 0x0000DA0E File Offset: 0x0000BC0E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600129D RID: 4765 RVA: 0x0000DA17 File Offset: 0x0000BC17
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_12();
			}

			// Token: 0x0600129E RID: 4766 RVA: 0x000839E4 File Offset: 0x00081BE4
			public Class2142 method_0()
			{
				return this.class2170_0.method_13(this.int_0);
			}

			// Token: 0x040007BD RID: 1981
			private int int_0;

			// Token: 0x040007BE RID: 1982
			private Class2170 class2170_0;
		}

		// Token: 0x02000317 RID: 791
		public sealed class Class1899 : IEnumerable
		{
			// Token: 0x0600129F RID: 4767 RVA: 0x0000DA3A File Offset: 0x0000BC3A
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x060012A0 RID: 4768 RVA: 0x00083A04 File Offset: 0x00081C04
			public Class2170.Class1900 method_1()
			{
				return new Class2170.Class1900(this.class2170_0);
			}

			// Token: 0x060012A1 RID: 4769 RVA: 0x00083A20 File Offset: 0x00081C20
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007BF RID: 1983
			private Class2170 class2170_0;
		}

		// Token: 0x02000318 RID: 792
		public sealed class Class1900 : IEnumerator
		{
			// Token: 0x1700019C RID: 412
			// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00083A38 File Offset: 0x00081C38
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060012A4 RID: 4772 RVA: 0x0000DA43 File Offset: 0x0000BC43
			public Class1900(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x060012A5 RID: 4773 RVA: 0x0000DA59 File Offset: 0x0000BC59
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060012A6 RID: 4774 RVA: 0x0000DA62 File Offset: 0x0000BC62
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_14();
			}

			// Token: 0x060012A7 RID: 4775 RVA: 0x00083A50 File Offset: 0x00081C50
			public Class2050 method_0()
			{
				return this.class2170_0.method_15(this.int_0);
			}

			// Token: 0x040007C0 RID: 1984
			private int int_0;

			// Token: 0x040007C1 RID: 1985
			private Class2170 class2170_0;
		}

		// Token: 0x02000319 RID: 793
		public sealed class Class1901 : IEnumerable
		{
			// Token: 0x060012A8 RID: 4776 RVA: 0x0000DA85 File Offset: 0x0000BC85
			public void method_0(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
			}

			// Token: 0x060012A9 RID: 4777 RVA: 0x00083A70 File Offset: 0x00081C70
			public Class2170.Class1902 method_1()
			{
				return new Class2170.Class1902(this.class2170_0);
			}

			// Token: 0x060012AA RID: 4778 RVA: 0x00083A8C File Offset: 0x00081C8C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007C2 RID: 1986
			private Class2170 class2170_0;
		}

		// Token: 0x0200031A RID: 794
		public sealed class Class1902 : IEnumerator
		{
			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060012AC RID: 4780 RVA: 0x00083AA4 File Offset: 0x00081CA4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060012AD RID: 4781 RVA: 0x0000DA8E File Offset: 0x0000BC8E
			public Class1902(Class2170 class2170_1)
			{
				this.class2170_0 = class2170_1;
				this.int_0 = -1;
			}

			// Token: 0x060012AE RID: 4782 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060012AF RID: 4783 RVA: 0x0000DAAD File Offset: 0x0000BCAD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2170_0.method_16();
			}

			// Token: 0x060012B0 RID: 4784 RVA: 0x00083ABC File Offset: 0x00081CBC
			public Class2050 method_0()
			{
				return this.class2170_0.method_17(this.int_0);
			}

			// Token: 0x040007C3 RID: 1987
			private int int_0;

			// Token: 0x040007C4 RID: 1988
			private Class2170 class2170_0;
		}
	}
}
