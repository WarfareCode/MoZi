using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x0200028A RID: 650
	public sealed class Class2161 : Class2059
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		public Class2161()
		{
			this.method_50();
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0007CF00 File Offset: 0x0007B100
		public Class2161(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_50();
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00067F64 File Offset: 0x00066164
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "queryable");
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0007D024 File Offset: 0x0007B224
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "queryable", int_0)));
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00067FB0 File Offset: 0x000661B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "cascaded");
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0007D050 File Offset: 0x0007B250
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "cascaded", int_0)));
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00067FFC File Offset: 0x000661FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "opaque");
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0007D07C File Offset: 0x0007B27C
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "opaque", int_0)));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00068048 File Offset: 0x00066248
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "noSubsets");
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "noSubsets", int_0)));
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00068094 File Offset: 0x00066294
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "fixedWidth");
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0007D0D4 File Offset: 0x0007B2D4
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "fixedWidth", int_0)));
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000680E0 File Offset: 0x000662E0
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "fixedHeight");
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0007D100 File Offset: 0x0007B300
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "fixedHeight", int_0)));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00077908 File Offset: 0x00075B08
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Title");
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00077928 File Offset: 0x00075B28
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Title", int_0)));
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0007D178 File Offset: 0x0007B378
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Abstract");
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0007D198 File Offset: 0x0007B398
		public Class2050 method_19(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Abstract", int_0)));
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0007D1C4 File Offset: 0x0007B3C4
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "KeywordList");
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0007D1E4 File Offset: 0x0007B3E4
		public Class2159 method_21(int int_0)
		{
			return new Class2159(base.method_1(Class2059.Enum155.const_1, "", "KeywordList", int_0));
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0007D20C File Offset: 0x0007B40C
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "SRS");
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0007D22C File Offset: 0x0007B42C
		public Class2050 method_23(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "SRS", int_0)));
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0007D258 File Offset: 0x0007B458
		public int method_24()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LatLonBoundingBox");
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0007D278 File Offset: 0x0007B478
		public Class2160 method_25(int int_0)
		{
			return new Class2160(base.method_1(Class2059.Enum155.const_1, "", "LatLonBoundingBox", int_0));
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0007D2A0 File Offset: 0x0007B4A0
		public int method_26()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBox");
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0007D2C0 File Offset: 0x0007B4C0
		public Class2139 method_27(int int_0)
		{
			return new Class2139(base.method_1(Class2059.Enum155.const_1, "", "BoundingBox", int_0));
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0007D2E8 File Offset: 0x0007B4E8
		public int method_28()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Dimension");
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0007D308 File Offset: 0x0007B508
		public Class2147 method_29(int int_0)
		{
			return new Class2147(base.method_1(Class2059.Enum155.const_1, "", "Dimension", int_0));
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0007D330 File Offset: 0x0007B530
		public int method_30()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Extent");
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0007D350 File Offset: 0x0007B550
		public Class2149 method_31(int int_0)
		{
			return new Class2149(base.method_1(Class2059.Enum155.const_1, "", "Extent", int_0));
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0007D378 File Offset: 0x0007B578
		public int method_32()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Attribution");
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0007D398 File Offset: 0x0007B598
		public Class2137 method_33(int int_0)
		{
			return new Class2137(base.method_1(Class2059.Enum155.const_1, "", "Attribution", int_0));
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0007D3C0 File Offset: 0x0007B5C0
		public int method_34()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "AuthorityURL");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0007D3E0 File Offset: 0x0007B5E0
		public Class2138 method_35(int int_0)
		{
			return new Class2138(base.method_1(Class2059.Enum155.const_1, "", "AuthorityURL", int_0));
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0007D408 File Offset: 0x0007B608
		public int method_36()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Identifier");
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0007D428 File Offset: 0x0007B628
		public Class2158 method_37(int int_0)
		{
			return new Class2158(base.method_1(Class2059.Enum155.const_1, "", "Identifier", int_0));
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0007D450 File Offset: 0x0007B650
		public int method_38()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MetadataURL");
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0007D470 File Offset: 0x0007B670
		public Class2164 method_39(int int_0)
		{
			return new Class2164(base.method_1(Class2059.Enum155.const_1, "", "MetadataURL", int_0));
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0007D498 File Offset: 0x0007B698
		public int method_40()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DataURL");
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0007D4B8 File Offset: 0x0007B6B8
		public Class2144 method_41(int int_0)
		{
			return new Class2144(base.method_1(Class2059.Enum155.const_1, "", "DataURL", int_0));
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0007D4E0 File Offset: 0x0007B6E0
		public int method_42()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "FeatureListURL");
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0007D500 File Offset: 0x0007B700
		public Class2150 method_43(int int_0)
		{
			return new Class2150(base.method_1(Class2059.Enum155.const_1, "", "FeatureListURL", int_0));
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0007D528 File Offset: 0x0007B728
		public int method_44()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Style");
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0007D548 File Offset: 0x0007B748
		public Class2172 method_45(int int_0)
		{
			return new Class2172(base.method_1(Class2059.Enum155.const_1, "", "Style", int_0));
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0007D570 File Offset: 0x0007B770
		public int method_46()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ScaleHint");
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0007D590 File Offset: 0x0007B790
		public Class2169 method_47(int int_0)
		{
			return new Class2169(base.method_1(Class2059.Enum155.const_1, "", "ScaleHint", int_0));
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00078340 File Offset: 0x00076540
		public int method_48()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Layer");
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00078360 File Offset: 0x00076560
		public Class2161 method_49(int int_0)
		{
			return new Class2161(base.method_1(Class2059.Enum155.const_1, "", "Layer", int_0));
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
		private void method_50()
		{
			this.class1787_0.method_0(this);
			this.class1789_0.method_0(this);
			this.class1791_0.method_0(this);
			this.class1793_0.method_0(this);
			this.class1795_0.method_0(this);
			this.class1797_0.method_0(this);
			this.class1799_0.method_0(this);
			this.class1801_0.method_0(this);
			this.class1803_0.method_0(this);
			this.class1805_0.method_0(this);
			this.class1807_0.method_0(this);
			this.class1809_0.method_0(this);
			this.class1811_0.method_0(this);
			this.class1813_0.method_0(this);
			this.class1815_0.method_0(this);
			this.class1817_0.method_0(this);
			this.class1819_0.method_0(this);
			this.class1821_0.method_0(this);
			this.class1823_0.method_0(this);
			this.class1825_0.method_0(this);
			this.class1827_0.method_0(this);
			this.class1829_0.method_0(this);
			this.class1831_0.method_0(this);
			this.class1833_0.method_0(this);
		}

		// Token: 0x0400063B RID: 1595
		public Class2161.Class1787 class1787_0 = new Class2161.Class1787();

		// Token: 0x0400063C RID: 1596
		public Class2161.Class1789 class1789_0 = new Class2161.Class1789();

		// Token: 0x0400063D RID: 1597
		public Class2161.Class1791 class1791_0 = new Class2161.Class1791();

		// Token: 0x0400063E RID: 1598
		public Class2161.Class1793 class1793_0 = new Class2161.Class1793();

		// Token: 0x0400063F RID: 1599
		public Class2161.Class1795 class1795_0 = new Class2161.Class1795();

		// Token: 0x04000640 RID: 1600
		public Class2161.Class1797 class1797_0 = new Class2161.Class1797();

		// Token: 0x04000641 RID: 1601
		public Class2161.Class1799 class1799_0 = new Class2161.Class1799();

		// Token: 0x04000642 RID: 1602
		public Class2161.Class1801 class1801_0 = new Class2161.Class1801();

		// Token: 0x04000643 RID: 1603
		public Class2161.Class1803 class1803_0 = new Class2161.Class1803();

		// Token: 0x04000644 RID: 1604
		public Class2161.Class1805 class1805_0 = new Class2161.Class1805();

		// Token: 0x04000645 RID: 1605
		public Class2161.Class1807 class1807_0 = new Class2161.Class1807();

		// Token: 0x04000646 RID: 1606
		public Class2161.Class1809 class1809_0 = new Class2161.Class1809();

		// Token: 0x04000647 RID: 1607
		public Class2161.Class1811 class1811_0 = new Class2161.Class1811();

		// Token: 0x04000648 RID: 1608
		public Class2161.Class1813 class1813_0 = new Class2161.Class1813();

		// Token: 0x04000649 RID: 1609
		public Class2161.Class1815 class1815_0 = new Class2161.Class1815();

		// Token: 0x0400064A RID: 1610
		public Class2161.Class1817 class1817_0 = new Class2161.Class1817();

		// Token: 0x0400064B RID: 1611
		public Class2161.Class1819 class1819_0 = new Class2161.Class1819();

		// Token: 0x0400064C RID: 1612
		public Class2161.Class1821 class1821_0 = new Class2161.Class1821();

		// Token: 0x0400064D RID: 1613
		public Class2161.Class1823 class1823_0 = new Class2161.Class1823();

		// Token: 0x0400064E RID: 1614
		public Class2161.Class1825 class1825_0 = new Class2161.Class1825();

		// Token: 0x0400064F RID: 1615
		public Class2161.Class1827 class1827_0 = new Class2161.Class1827();

		// Token: 0x04000650 RID: 1616
		public Class2161.Class1829 class1829_0 = new Class2161.Class1829();

		// Token: 0x04000651 RID: 1617
		public Class2161.Class1831 class1831_0 = new Class2161.Class1831();

		// Token: 0x04000652 RID: 1618
		public Class2161.Class1833 class1833_0 = new Class2161.Class1833();

		// Token: 0x0200028B RID: 651
		public sealed class Class1787 : IEnumerable
		{
			// Token: 0x06000F7F RID: 3967 RVA: 0x0000C2BA File Offset: 0x0000A4BA
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x0007D6E8 File Offset: 0x0007B8E8
			public Class2161.Class1788 method_1()
			{
				return new Class2161.Class1788(this.class2161_0);
			}

			// Token: 0x06000F81 RID: 3969 RVA: 0x0007D704 File Offset: 0x0007B904
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000653 RID: 1619
			private Class2161 class2161_0;
		}

		// Token: 0x0200028C RID: 652
		public sealed class Class1788 : IEnumerator
		{
			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0007D71C File Offset: 0x0007B91C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000F84 RID: 3972 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
			public Class1788(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000F85 RID: 3973 RVA: 0x0000C2D9 File Offset: 0x0000A4D9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000F86 RID: 3974 RVA: 0x0000C2E2 File Offset: 0x0000A4E2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_2();
			}

			// Token: 0x06000F87 RID: 3975 RVA: 0x0007D734 File Offset: 0x0007B934
			public Class2050 method_0()
			{
				return this.class2161_0.method_3(this.int_0);
			}

			// Token: 0x04000654 RID: 1620
			private int int_0;

			// Token: 0x04000655 RID: 1621
			private Class2161 class2161_0;
		}

		// Token: 0x0200028D RID: 653
		public sealed class Class1789 : IEnumerable
		{
			// Token: 0x06000F88 RID: 3976 RVA: 0x0000C305 File Offset: 0x0000A505
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000F89 RID: 3977 RVA: 0x0007D754 File Offset: 0x0007B954
			public Class2161.Class1790 method_1()
			{
				return new Class2161.Class1790(this.class2161_0);
			}

			// Token: 0x06000F8A RID: 3978 RVA: 0x0007D770 File Offset: 0x0007B970
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000656 RID: 1622
			private Class2161 class2161_0;
		}

		// Token: 0x0200028E RID: 654
		public sealed class Class1790 : IEnumerator
		{
			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0007D788 File Offset: 0x0007B988
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000F8D RID: 3981 RVA: 0x0000C30E File Offset: 0x0000A50E
			public Class1790(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000F8E RID: 3982 RVA: 0x0000C324 File Offset: 0x0000A524
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000F8F RID: 3983 RVA: 0x0000C32D File Offset: 0x0000A52D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_4();
			}

			// Token: 0x06000F90 RID: 3984 RVA: 0x0007D7A0 File Offset: 0x0007B9A0
			public Class2050 method_0()
			{
				return this.class2161_0.method_5(this.int_0);
			}

			// Token: 0x04000657 RID: 1623
			private int int_0;

			// Token: 0x04000658 RID: 1624
			private Class2161 class2161_0;
		}

		// Token: 0x0200028F RID: 655
		public sealed class Class1791 : IEnumerable
		{
			// Token: 0x06000F91 RID: 3985 RVA: 0x0000C350 File Offset: 0x0000A550
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000F92 RID: 3986 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
			public Class2161.Class1792 method_1()
			{
				return new Class2161.Class1792(this.class2161_0);
			}

			// Token: 0x06000F93 RID: 3987 RVA: 0x0007D7DC File Offset: 0x0007B9DC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000659 RID: 1625
			private Class2161 class2161_0;
		}

		// Token: 0x02000290 RID: 656
		public sealed class Class1792 : IEnumerator
		{
			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0007D7F4 File Offset: 0x0007B9F4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000F96 RID: 3990 RVA: 0x0000C359 File Offset: 0x0000A559
			public Class1792(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000F97 RID: 3991 RVA: 0x0000C36F File Offset: 0x0000A56F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000F98 RID: 3992 RVA: 0x0000C378 File Offset: 0x0000A578
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_6();
			}

			// Token: 0x06000F99 RID: 3993 RVA: 0x0007D80C File Offset: 0x0007BA0C
			public Class2050 method_0()
			{
				return this.class2161_0.method_7(this.int_0);
			}

			// Token: 0x0400065A RID: 1626
			private int int_0;

			// Token: 0x0400065B RID: 1627
			private Class2161 class2161_0;
		}

		// Token: 0x02000291 RID: 657
		public sealed class Class1793 : IEnumerable
		{
			// Token: 0x06000F9A RID: 3994 RVA: 0x0000C39B File Offset: 0x0000A59B
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000F9B RID: 3995 RVA: 0x0007D82C File Offset: 0x0007BA2C
			public Class2161.Class1794 method_1()
			{
				return new Class2161.Class1794(this.class2161_0);
			}

			// Token: 0x06000F9C RID: 3996 RVA: 0x0007D848 File Offset: 0x0007BA48
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400065C RID: 1628
			private Class2161 class2161_0;
		}

		// Token: 0x02000292 RID: 658
		public sealed class Class1794 : IEnumerator
		{
			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0007D860 File Offset: 0x0007BA60
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
			public Class1794(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x0000C3BA File Offset: 0x0000A5BA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_8();
			}

			// Token: 0x06000FA2 RID: 4002 RVA: 0x0007D878 File Offset: 0x0007BA78
			public Class2050 method_0()
			{
				return this.class2161_0.method_9(this.int_0);
			}

			// Token: 0x0400065D RID: 1629
			private int int_0;

			// Token: 0x0400065E RID: 1630
			private Class2161 class2161_0;
		}

		// Token: 0x02000293 RID: 659
		public sealed class Class1795 : IEnumerable
		{
			// Token: 0x06000FA3 RID: 4003 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x0007D898 File Offset: 0x0007BA98
			public Class2161.Class1796 method_1()
			{
				return new Class2161.Class1796(this.class2161_0);
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x0007D8B4 File Offset: 0x0007BAB4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400065F RID: 1631
			private Class2161 class2161_0;
		}

		// Token: 0x02000294 RID: 660
		public sealed class Class1796 : IEnumerator
		{
			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0007D8CC File Offset: 0x0007BACC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x0000C3EF File Offset: 0x0000A5EF
			public Class1796(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FA9 RID: 4009 RVA: 0x0000C405 File Offset: 0x0000A605
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FAA RID: 4010 RVA: 0x0000C40E File Offset: 0x0000A60E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_10();
			}

			// Token: 0x06000FAB RID: 4011 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
			public Class2050 method_0()
			{
				return this.class2161_0.method_11(this.int_0);
			}

			// Token: 0x04000660 RID: 1632
			private int int_0;

			// Token: 0x04000661 RID: 1633
			private Class2161 class2161_0;
		}

		// Token: 0x02000295 RID: 661
		public sealed class Class1797 : IEnumerable
		{
			// Token: 0x06000FAC RID: 4012 RVA: 0x0000C431 File Offset: 0x0000A631
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x0007D904 File Offset: 0x0007BB04
			public Class2161.Class1798 method_1()
			{
				return new Class2161.Class1798(this.class2161_0);
			}

			// Token: 0x06000FAE RID: 4014 RVA: 0x0007D920 File Offset: 0x0007BB20
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000662 RID: 1634
			private Class2161 class2161_0;
		}

		// Token: 0x02000296 RID: 662
		public sealed class Class1798 : IEnumerator
		{
			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0007D938 File Offset: 0x0007BB38
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FB1 RID: 4017 RVA: 0x0000C43A File Offset: 0x0000A63A
			public Class1798(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FB2 RID: 4018 RVA: 0x0000C450 File Offset: 0x0000A650
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FB3 RID: 4019 RVA: 0x0000C459 File Offset: 0x0000A659
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_12();
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x0007D950 File Offset: 0x0007BB50
			public Class2050 method_0()
			{
				return this.class2161_0.method_13(this.int_0);
			}

			// Token: 0x04000663 RID: 1635
			private int int_0;

			// Token: 0x04000664 RID: 1636
			private Class2161 class2161_0;
		}

		// Token: 0x02000297 RID: 663
		public sealed class Class1799 : IEnumerable
		{
			// Token: 0x06000FB5 RID: 4021 RVA: 0x0000C47C File Offset: 0x0000A67C
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FB6 RID: 4022 RVA: 0x0007D970 File Offset: 0x0007BB70
			public Class2161.Class1800 method_1()
			{
				return new Class2161.Class1800(this.class2161_0);
			}

			// Token: 0x06000FB7 RID: 4023 RVA: 0x0007D98C File Offset: 0x0007BB8C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000665 RID: 1637
			private Class2161 class2161_0;
		}

		// Token: 0x02000298 RID: 664
		public sealed class Class1800 : IEnumerator
		{
			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x0000C485 File Offset: 0x0000A685
			public Class1800(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x0000C49B File Offset: 0x0000A69B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_14();
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x0007D9BC File Offset: 0x0007BBBC
			public Class2050 method_0()
			{
				return this.class2161_0.method_15(this.int_0);
			}

			// Token: 0x04000666 RID: 1638
			private int int_0;

			// Token: 0x04000667 RID: 1639
			private Class2161 class2161_0;
		}

		// Token: 0x02000299 RID: 665
		public sealed class Class1801 : IEnumerable
		{
			// Token: 0x06000FBE RID: 4030 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FBF RID: 4031 RVA: 0x0007D9DC File Offset: 0x0007BBDC
			public Class2161.Class1802 method_1()
			{
				return new Class2161.Class1802(this.class2161_0);
			}

			// Token: 0x06000FC0 RID: 4032 RVA: 0x0007D9F8 File Offset: 0x0007BBF8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000668 RID: 1640
			private Class2161 class2161_0;
		}

		// Token: 0x0200029A RID: 666
		public sealed class Class1802 : IEnumerator
		{
			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0007DA10 File Offset: 0x0007BC10
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
			public Class1802(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FC4 RID: 4036 RVA: 0x0000C4E6 File Offset: 0x0000A6E6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FC5 RID: 4037 RVA: 0x0000C4EF File Offset: 0x0000A6EF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_16();
			}

			// Token: 0x06000FC6 RID: 4038 RVA: 0x0007DA28 File Offset: 0x0007BC28
			public Class2050 method_0()
			{
				return this.class2161_0.method_17(this.int_0);
			}

			// Token: 0x04000669 RID: 1641
			private int int_0;

			// Token: 0x0400066A RID: 1642
			private Class2161 class2161_0;
		}

		// Token: 0x0200029B RID: 667
		public sealed class Class1803 : IEnumerable
		{
			// Token: 0x06000FC7 RID: 4039 RVA: 0x0000C512 File Offset: 0x0000A712
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FC8 RID: 4040 RVA: 0x0007DA48 File Offset: 0x0007BC48
			public Class2161.Class1804 method_1()
			{
				return new Class2161.Class1804(this.class2161_0);
			}

			// Token: 0x06000FC9 RID: 4041 RVA: 0x0007DA64 File Offset: 0x0007BC64
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400066B RID: 1643
			private Class2161 class2161_0;
		}

		// Token: 0x0200029C RID: 668
		public sealed class Class1804 : IEnumerator
		{
			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0007DA7C File Offset: 0x0007BC7C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FCC RID: 4044 RVA: 0x0000C51B File Offset: 0x0000A71B
			public Class1804(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FCD RID: 4045 RVA: 0x0000C531 File Offset: 0x0000A731
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FCE RID: 4046 RVA: 0x0000C53A File Offset: 0x0000A73A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_18();
			}

			// Token: 0x06000FCF RID: 4047 RVA: 0x0007DA94 File Offset: 0x0007BC94
			public Class2050 method_0()
			{
				return this.class2161_0.method_19(this.int_0);
			}

			// Token: 0x0400066C RID: 1644
			private int int_0;

			// Token: 0x0400066D RID: 1645
			private Class2161 class2161_0;
		}

		// Token: 0x0200029D RID: 669
		public sealed class Class1805 : IEnumerable
		{
			// Token: 0x06000FD0 RID: 4048 RVA: 0x0000C55D File Offset: 0x0000A75D
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FD1 RID: 4049 RVA: 0x0007DAB4 File Offset: 0x0007BCB4
			public Class2161.Class1806 method_1()
			{
				return new Class2161.Class1806(this.class2161_0);
			}

			// Token: 0x06000FD2 RID: 4050 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400066E RID: 1646
			private Class2161 class2161_0;
		}

		// Token: 0x0200029E RID: 670
		public sealed class Class1806 : IEnumerator
		{
			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0007DAE8 File Offset: 0x0007BCE8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x0000C566 File Offset: 0x0000A766
			public Class1806(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FD6 RID: 4054 RVA: 0x0000C57C File Offset: 0x0000A77C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x0000C585 File Offset: 0x0000A785
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_20();
			}

			// Token: 0x06000FD8 RID: 4056 RVA: 0x0007DB00 File Offset: 0x0007BD00
			public Class2159 method_0()
			{
				return this.class2161_0.method_21(this.int_0);
			}

			// Token: 0x0400066F RID: 1647
			private int int_0;

			// Token: 0x04000670 RID: 1648
			private Class2161 class2161_0;
		}

		// Token: 0x0200029F RID: 671
		public sealed class Class1807 : IEnumerable
		{
			// Token: 0x06000FD9 RID: 4057 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FDA RID: 4058 RVA: 0x0007DB20 File Offset: 0x0007BD20
			public Class2161.Class1808 method_1()
			{
				return new Class2161.Class1808(this.class2161_0);
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x0007DB3C File Offset: 0x0007BD3C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000671 RID: 1649
			private Class2161 class2161_0;
		}

		// Token: 0x020002A0 RID: 672
		public sealed class Class1808 : IEnumerator
		{
			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0007DB54 File Offset: 0x0007BD54
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FDE RID: 4062 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
			public Class1808(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FDF RID: 4063 RVA: 0x0000C5C7 File Offset: 0x0000A7C7
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FE0 RID: 4064 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_22();
			}

			// Token: 0x06000FE1 RID: 4065 RVA: 0x0007DB6C File Offset: 0x0007BD6C
			public Class2050 method_0()
			{
				return this.class2161_0.method_23(this.int_0);
			}

			// Token: 0x04000672 RID: 1650
			private int int_0;

			// Token: 0x04000673 RID: 1651
			private Class2161 class2161_0;
		}

		// Token: 0x020002A1 RID: 673
		public sealed class Class1809 : IEnumerable
		{
			// Token: 0x06000FE2 RID: 4066 RVA: 0x0000C5F3 File Offset: 0x0000A7F3
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x0007DB8C File Offset: 0x0007BD8C
			public Class2161.Class1810 method_1()
			{
				return new Class2161.Class1810(this.class2161_0);
			}

			// Token: 0x06000FE4 RID: 4068 RVA: 0x0007DBA8 File Offset: 0x0007BDA8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000674 RID: 1652
			private Class2161 class2161_0;
		}

		// Token: 0x020002A2 RID: 674
		public sealed class Class1810 : IEnumerator
		{
			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FE7 RID: 4071 RVA: 0x0000C5FC File Offset: 0x0000A7FC
			public Class1810(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FE8 RID: 4072 RVA: 0x0000C612 File Offset: 0x0000A812
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FE9 RID: 4073 RVA: 0x0000C61B File Offset: 0x0000A81B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_24();
			}

			// Token: 0x06000FEA RID: 4074 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
			public Class2160 method_0()
			{
				return this.class2161_0.method_25(this.int_0);
			}

			// Token: 0x04000675 RID: 1653
			private int int_0;

			// Token: 0x04000676 RID: 1654
			private Class2161 class2161_0;
		}

		// Token: 0x020002A3 RID: 675
		public sealed class Class1811 : IEnumerable
		{
			// Token: 0x06000FEB RID: 4075 RVA: 0x0000C63E File Offset: 0x0000A83E
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x0007DBF8 File Offset: 0x0007BDF8
			public Class2161.Class1812 method_1()
			{
				return new Class2161.Class1812(this.class2161_0);
			}

			// Token: 0x06000FED RID: 4077 RVA: 0x0007DC14 File Offset: 0x0007BE14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000677 RID: 1655
			private Class2161 class2161_0;
		}

		// Token: 0x020002A4 RID: 676
		public sealed class Class1812 : IEnumerator
		{
			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0007DC2C File Offset: 0x0007BE2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FF0 RID: 4080 RVA: 0x0000C647 File Offset: 0x0000A847
			public Class1812(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FF1 RID: 4081 RVA: 0x0000C65D File Offset: 0x0000A85D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FF2 RID: 4082 RVA: 0x0000C666 File Offset: 0x0000A866
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_26();
			}

			// Token: 0x06000FF3 RID: 4083 RVA: 0x0007DC44 File Offset: 0x0007BE44
			public Class2139 method_0()
			{
				return this.class2161_0.method_27(this.int_0);
			}

			// Token: 0x04000678 RID: 1656
			private int int_0;

			// Token: 0x04000679 RID: 1657
			private Class2161 class2161_0;
		}

		// Token: 0x020002A5 RID: 677
		public sealed class Class1813 : IEnumerable
		{
			// Token: 0x06000FF4 RID: 4084 RVA: 0x0000C689 File Offset: 0x0000A889
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FF5 RID: 4085 RVA: 0x0007DC64 File Offset: 0x0007BE64
			public Class2161.Class1814 method_1()
			{
				return new Class2161.Class1814(this.class2161_0);
			}

			// Token: 0x06000FF6 RID: 4086 RVA: 0x0007DC80 File Offset: 0x0007BE80
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400067A RID: 1658
			private Class2161 class2161_0;
		}

		// Token: 0x020002A6 RID: 678
		public sealed class Class1814 : IEnumerator
		{
			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0007DC98 File Offset: 0x0007BE98
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000FF9 RID: 4089 RVA: 0x0000C692 File Offset: 0x0000A892
			public Class1814(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06000FFA RID: 4090 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x0000C6B1 File Offset: 0x0000A8B1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_28();
			}

			// Token: 0x06000FFC RID: 4092 RVA: 0x0007DCB0 File Offset: 0x0007BEB0
			public Class2147 method_0()
			{
				return this.class2161_0.method_29(this.int_0);
			}

			// Token: 0x0400067B RID: 1659
			private int int_0;

			// Token: 0x0400067C RID: 1660
			private Class2161 class2161_0;
		}

		// Token: 0x020002A7 RID: 679
		public sealed class Class1815 : IEnumerable
		{
			// Token: 0x06000FFD RID: 4093 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06000FFE RID: 4094 RVA: 0x0007DCD0 File Offset: 0x0007BED0
			public Class2161.Class1816 method_1()
			{
				return new Class2161.Class1816(this.class2161_0);
			}

			// Token: 0x06000FFF RID: 4095 RVA: 0x0007DCEC File Offset: 0x0007BEEC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400067D RID: 1661
			private Class2161 class2161_0;
		}

		// Token: 0x020002A8 RID: 680
		public sealed class Class1816 : IEnumerator
		{
			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06001001 RID: 4097 RVA: 0x0007DD04 File Offset: 0x0007BF04
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x0000C6DD File Offset: 0x0000A8DD
			public Class1816(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x0000C6F3 File Offset: 0x0000A8F3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001004 RID: 4100 RVA: 0x0000C6FC File Offset: 0x0000A8FC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_30();
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x0007DD1C File Offset: 0x0007BF1C
			public Class2149 method_0()
			{
				return this.class2161_0.method_31(this.int_0);
			}

			// Token: 0x0400067E RID: 1662
			private int int_0;

			// Token: 0x0400067F RID: 1663
			private Class2161 class2161_0;
		}

		// Token: 0x020002A9 RID: 681
		public sealed class Class1817 : IEnumerable
		{
			// Token: 0x06001006 RID: 4102 RVA: 0x0000C71F File Offset: 0x0000A91F
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x0007DD3C File Offset: 0x0007BF3C
			public Class2161.Class1818 method_1()
			{
				return new Class2161.Class1818(this.class2161_0);
			}

			// Token: 0x06001008 RID: 4104 RVA: 0x0007DD58 File Offset: 0x0007BF58
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000680 RID: 1664
			private Class2161 class2161_0;
		}

		// Token: 0x020002AA RID: 682
		public sealed class Class1818 : IEnumerator
		{
			// Token: 0x17000167 RID: 359
			// (get) Token: 0x0600100A RID: 4106 RVA: 0x0007DD70 File Offset: 0x0007BF70
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x0000C728 File Offset: 0x0000A928
			public Class1818(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x0000C73E File Offset: 0x0000A93E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x0000C747 File Offset: 0x0000A947
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_32();
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x0007DD88 File Offset: 0x0007BF88
			public Class2137 method_0()
			{
				return this.class2161_0.method_33(this.int_0);
			}

			// Token: 0x04000681 RID: 1665
			private int int_0;

			// Token: 0x04000682 RID: 1666
			private Class2161 class2161_0;
		}

		// Token: 0x020002AB RID: 683
		public sealed class Class1819 : IEnumerable
		{
			// Token: 0x0600100F RID: 4111 RVA: 0x0000C76A File Offset: 0x0000A96A
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001010 RID: 4112 RVA: 0x0007DDA8 File Offset: 0x0007BFA8
			public Class2161.Class1820 method_1()
			{
				return new Class2161.Class1820(this.class2161_0);
			}

			// Token: 0x06001011 RID: 4113 RVA: 0x0007DDC4 File Offset: 0x0007BFC4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000683 RID: 1667
			private Class2161 class2161_0;
		}

		// Token: 0x020002AC RID: 684
		public sealed class Class1820 : IEnumerator
		{
			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x0007DDDC File Offset: 0x0007BFDC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001014 RID: 4116 RVA: 0x0000C773 File Offset: 0x0000A973
			public Class1820(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001015 RID: 4117 RVA: 0x0000C789 File Offset: 0x0000A989
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001016 RID: 4118 RVA: 0x0000C792 File Offset: 0x0000A992
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_34();
			}

			// Token: 0x06001017 RID: 4119 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
			public Class2138 method_0()
			{
				return this.class2161_0.method_35(this.int_0);
			}

			// Token: 0x04000684 RID: 1668
			private int int_0;

			// Token: 0x04000685 RID: 1669
			private Class2161 class2161_0;
		}

		// Token: 0x020002AD RID: 685
		public sealed class Class1821 : IEnumerable
		{
			// Token: 0x06001018 RID: 4120 RVA: 0x0000C7B5 File Offset: 0x0000A9B5
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x0007DE14 File Offset: 0x0007C014
			public Class2161.Class1822 method_1()
			{
				return new Class2161.Class1822(this.class2161_0);
			}

			// Token: 0x0600101A RID: 4122 RVA: 0x0007DE30 File Offset: 0x0007C030
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000686 RID: 1670
			private Class2161 class2161_0;
		}

		// Token: 0x020002AE RID: 686
		public sealed class Class1822 : IEnumerator
		{
			// Token: 0x17000169 RID: 361
			// (get) Token: 0x0600101C RID: 4124 RVA: 0x0007DE48 File Offset: 0x0007C048
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x0000C7BE File Offset: 0x0000A9BE
			public Class1822(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x0600101E RID: 4126 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x0000C7DD File Offset: 0x0000A9DD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_36();
			}

			// Token: 0x06001020 RID: 4128 RVA: 0x0007DE60 File Offset: 0x0007C060
			public Class2158 method_0()
			{
				return this.class2161_0.method_37(this.int_0);
			}

			// Token: 0x04000687 RID: 1671
			private int int_0;

			// Token: 0x04000688 RID: 1672
			private Class2161 class2161_0;
		}

		// Token: 0x020002AF RID: 687
		public sealed class Class1823 : IEnumerable
		{
			// Token: 0x06001021 RID: 4129 RVA: 0x0000C800 File Offset: 0x0000AA00
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001022 RID: 4130 RVA: 0x0007DE80 File Offset: 0x0007C080
			public Class2161.Class1824 method_1()
			{
				return new Class2161.Class1824(this.class2161_0);
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x0007DE9C File Offset: 0x0007C09C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000689 RID: 1673
			private Class2161 class2161_0;
		}

		// Token: 0x020002B0 RID: 688
		public sealed class Class1824 : IEnumerator
		{
			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06001025 RID: 4133 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001026 RID: 4134 RVA: 0x0000C809 File Offset: 0x0000AA09
			public Class1824(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001027 RID: 4135 RVA: 0x0000C81F File Offset: 0x0000AA1F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001028 RID: 4136 RVA: 0x0000C828 File Offset: 0x0000AA28
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_38();
			}

			// Token: 0x06001029 RID: 4137 RVA: 0x0007DECC File Offset: 0x0007C0CC
			public Class2164 method_0()
			{
				return this.class2161_0.method_39(this.int_0);
			}

			// Token: 0x0400068A RID: 1674
			private int int_0;

			// Token: 0x0400068B RID: 1675
			private Class2161 class2161_0;
		}

		// Token: 0x020002B1 RID: 689
		public sealed class Class1825 : IEnumerable
		{
			// Token: 0x0600102A RID: 4138 RVA: 0x0000C84B File Offset: 0x0000AA4B
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x0600102B RID: 4139 RVA: 0x0007DEEC File Offset: 0x0007C0EC
			public Class2161.Class1826 method_1()
			{
				return new Class2161.Class1826(this.class2161_0);
			}

			// Token: 0x0600102C RID: 4140 RVA: 0x0007DF08 File Offset: 0x0007C108
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400068C RID: 1676
			private Class2161 class2161_0;
		}

		// Token: 0x020002B2 RID: 690
		public sealed class Class1826 : IEnumerator
		{
			// Token: 0x1700016B RID: 363
			// (get) Token: 0x0600102E RID: 4142 RVA: 0x0007DF20 File Offset: 0x0007C120
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600102F RID: 4143 RVA: 0x0000C854 File Offset: 0x0000AA54
			public Class1826(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x0000C86A File Offset: 0x0000AA6A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001031 RID: 4145 RVA: 0x0000C873 File Offset: 0x0000AA73
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_40();
			}

			// Token: 0x06001032 RID: 4146 RVA: 0x0007DF38 File Offset: 0x0007C138
			public Class2144 method_0()
			{
				return this.class2161_0.method_41(this.int_0);
			}

			// Token: 0x0400068D RID: 1677
			private int int_0;

			// Token: 0x0400068E RID: 1678
			private Class2161 class2161_0;
		}

		// Token: 0x020002B3 RID: 691
		public sealed class Class1827 : IEnumerable
		{
			// Token: 0x06001033 RID: 4147 RVA: 0x0000C896 File Offset: 0x0000AA96
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001034 RID: 4148 RVA: 0x0007DF58 File Offset: 0x0007C158
			public Class2161.Class1828 method_1()
			{
				return new Class2161.Class1828(this.class2161_0);
			}

			// Token: 0x06001035 RID: 4149 RVA: 0x0007DF74 File Offset: 0x0007C174
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400068F RID: 1679
			private Class2161 class2161_0;
		}

		// Token: 0x020002B4 RID: 692
		public sealed class Class1828 : IEnumerator
		{
			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06001037 RID: 4151 RVA: 0x0007DF8C File Offset: 0x0007C18C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001038 RID: 4152 RVA: 0x0000C89F File Offset: 0x0000AA9F
			public Class1828(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001039 RID: 4153 RVA: 0x0000C8B5 File Offset: 0x0000AAB5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600103A RID: 4154 RVA: 0x0000C8BE File Offset: 0x0000AABE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_42();
			}

			// Token: 0x0600103B RID: 4155 RVA: 0x0007DFA4 File Offset: 0x0007C1A4
			public Class2150 method_0()
			{
				return this.class2161_0.method_43(this.int_0);
			}

			// Token: 0x04000690 RID: 1680
			private int int_0;

			// Token: 0x04000691 RID: 1681
			private Class2161 class2161_0;
		}

		// Token: 0x020002B5 RID: 693
		public sealed class Class1829 : IEnumerable
		{
			// Token: 0x0600103C RID: 4156 RVA: 0x0000C8E1 File Offset: 0x0000AAE1
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x0600103D RID: 4157 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
			public Class2161.Class1830 method_1()
			{
				return new Class2161.Class1830(this.class2161_0);
			}

			// Token: 0x0600103E RID: 4158 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000692 RID: 1682
			private Class2161 class2161_0;
		}

		// Token: 0x020002B6 RID: 694
		public sealed class Class1830 : IEnumerator
		{
			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06001040 RID: 4160 RVA: 0x0007DFF8 File Offset: 0x0007C1F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001041 RID: 4161 RVA: 0x0000C8EA File Offset: 0x0000AAEA
			public Class1830(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001042 RID: 4162 RVA: 0x0000C900 File Offset: 0x0000AB00
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001043 RID: 4163 RVA: 0x0000C909 File Offset: 0x0000AB09
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_44();
			}

			// Token: 0x06001044 RID: 4164 RVA: 0x0007E010 File Offset: 0x0007C210
			public Class2172 method_0()
			{
				return this.class2161_0.method_45(this.int_0);
			}

			// Token: 0x04000693 RID: 1683
			private int int_0;

			// Token: 0x04000694 RID: 1684
			private Class2161 class2161_0;
		}

		// Token: 0x020002B7 RID: 695
		public sealed class Class1831 : IEnumerable
		{
			// Token: 0x06001045 RID: 4165 RVA: 0x0000C92C File Offset: 0x0000AB2C
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x06001046 RID: 4166 RVA: 0x0007E030 File Offset: 0x0007C230
			public Class2161.Class1832 method_1()
			{
				return new Class2161.Class1832(this.class2161_0);
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x0007E04C File Offset: 0x0007C24C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000695 RID: 1685
			private Class2161 class2161_0;
		}

		// Token: 0x020002B8 RID: 696
		public sealed class Class1832 : IEnumerator
		{
			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06001049 RID: 4169 RVA: 0x0007E064 File Offset: 0x0007C264
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600104A RID: 4170 RVA: 0x0000C935 File Offset: 0x0000AB35
			public Class1832(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x0600104B RID: 4171 RVA: 0x0000C94B File Offset: 0x0000AB4B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600104C RID: 4172 RVA: 0x0000C954 File Offset: 0x0000AB54
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_46();
			}

			// Token: 0x0600104D RID: 4173 RVA: 0x0007E07C File Offset: 0x0007C27C
			public Class2169 method_0()
			{
				return this.class2161_0.method_47(this.int_0);
			}

			// Token: 0x04000696 RID: 1686
			private int int_0;

			// Token: 0x04000697 RID: 1687
			private Class2161 class2161_0;
		}

		// Token: 0x020002B9 RID: 697
		public sealed class Class1833 : IEnumerable
		{
			// Token: 0x0600104E RID: 4174 RVA: 0x0000C977 File Offset: 0x0000AB77
			public void method_0(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
			}

			// Token: 0x0600104F RID: 4175 RVA: 0x0007E09C File Offset: 0x0007C29C
			public Class2161.Class1834 method_1()
			{
				return new Class2161.Class1834(this.class2161_0);
			}

			// Token: 0x06001050 RID: 4176 RVA: 0x0007E0B8 File Offset: 0x0007C2B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000698 RID: 1688
			private Class2161 class2161_0;
		}

		// Token: 0x020002BA RID: 698
		public sealed class Class1834 : IEnumerator
		{
			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06001052 RID: 4178 RVA: 0x0007E0D0 File Offset: 0x0007C2D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001053 RID: 4179 RVA: 0x0000C980 File Offset: 0x0000AB80
			public Class1834(Class2161 class2161_1)
			{
				this.class2161_0 = class2161_1;
				this.int_0 = -1;
			}

			// Token: 0x06001054 RID: 4180 RVA: 0x0000C996 File Offset: 0x0000AB96
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001055 RID: 4181 RVA: 0x0000C99F File Offset: 0x0000AB9F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2161_0.method_48();
			}

			// Token: 0x06001056 RID: 4182 RVA: 0x0007E0E8 File Offset: 0x0007C2E8
			public Class2161 method_0()
			{
				return this.class2161_0.method_49(this.int_0);
			}

			// Token: 0x04000699 RID: 1689
			private int int_0;

			// Token: 0x0400069A RID: 1690
			private Class2161 class2161_0;
		}
	}
}
