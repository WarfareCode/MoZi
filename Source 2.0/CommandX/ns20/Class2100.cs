using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000926 RID: 2342
	public sealed class Class2100 : Class2059
	{
		// Token: 0x0600397F RID: 14719 RVA: 0x0001E891 File Offset: 0x0001CA91
		public Class2100()
		{
			this.method_10();
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0001E8CB File Offset: 0x0001CACB
		public Class2100(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00121DD8 File Offset: 0x0011FFD8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Days");
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00121DF8 File Offset: 0x0011FFF8
		public Class2010 method_3(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Days", int_0)));
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00121E24 File Offset: 0x00120024
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Hours");
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00121E44 File Offset: 0x00120044
		public Class2018 method_5(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Hours", int_0)));
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00121E70 File Offset: 0x00120070
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Mins");
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00121E90 File Offset: 0x00120090
		public Class2010 method_7(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Mins", int_0)));
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00121EBC File Offset: 0x001200BC
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Seconds");
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00121EDC File Offset: 0x001200DC
		public Class2010 method_9(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Seconds", int_0)));
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0001E906 File Offset: 0x0001CB06
		private void method_10()
		{
			this.class1307_0.method_0(this);
			this.class1309_0.method_0(this);
			this.class1311_0.method_0(this);
			this.class1313_0.method_0(this);
		}

		// Token: 0x04001A58 RID: 6744
		public Class2100.Class1307 class1307_0 = new Class2100.Class1307();

		// Token: 0x04001A59 RID: 6745
		public Class2100.Class1309 class1309_0 = new Class2100.Class1309();

		// Token: 0x04001A5A RID: 6746
		public Class2100.Class1311 class1311_0 = new Class2100.Class1311();

		// Token: 0x04001A5B RID: 6747
		public Class2100.Class1313 class1313_0 = new Class2100.Class1313();

		// Token: 0x02000927 RID: 2343
		public sealed class Class1307 : IEnumerable
		{
			// Token: 0x0600398A RID: 14730 RVA: 0x0001E938 File Offset: 0x0001CB38
			public void method_0(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
			}

			// Token: 0x0600398B RID: 14731 RVA: 0x001220B8 File Offset: 0x001202B8
			public Class2100.Class1308 method_1()
			{
				return new Class2100.Class1308(this.class2100_0);
			}

			// Token: 0x0600398C RID: 14732 RVA: 0x001220D4 File Offset: 0x001202D4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A5C RID: 6748
			private Class2100 class2100_0;
		}

		// Token: 0x02000928 RID: 2344
		public sealed class Class1308 : IEnumerator
		{
			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x0600398E RID: 14734 RVA: 0x001220EC File Offset: 0x001202EC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600398F RID: 14735 RVA: 0x0001E941 File Offset: 0x0001CB41
			public Class1308(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
				this.int_0 = -1;
			}

			// Token: 0x06003990 RID: 14736 RVA: 0x0001E957 File Offset: 0x0001CB57
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003991 RID: 14737 RVA: 0x0001E960 File Offset: 0x0001CB60
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2100_0.method_2();
			}

			// Token: 0x06003992 RID: 14738 RVA: 0x00122104 File Offset: 0x00120304
			public Class2010 method_0()
			{
				return this.class2100_0.method_3(this.int_0);
			}

			// Token: 0x04001A5D RID: 6749
			private int int_0;

			// Token: 0x04001A5E RID: 6750
			private Class2100 class2100_0;
		}

		// Token: 0x02000929 RID: 2345
		public sealed class Class1309 : IEnumerable
		{
			// Token: 0x06003993 RID: 14739 RVA: 0x0001E983 File Offset: 0x0001CB83
			public void method_0(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
			}

			// Token: 0x06003994 RID: 14740 RVA: 0x00122124 File Offset: 0x00120324
			public Class2100.Class1310 method_1()
			{
				return new Class2100.Class1310(this.class2100_0);
			}

			// Token: 0x06003995 RID: 14741 RVA: 0x00122140 File Offset: 0x00120340
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A5F RID: 6751
			private Class2100 class2100_0;
		}

		// Token: 0x0200092A RID: 2346
		public sealed class Class1310 : IEnumerator
		{
			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06003997 RID: 14743 RVA: 0x00122158 File Offset: 0x00120358
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003998 RID: 14744 RVA: 0x0001E98C File Offset: 0x0001CB8C
			public Class1310(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
				this.int_0 = -1;
			}

			// Token: 0x06003999 RID: 14745 RVA: 0x0001E9A2 File Offset: 0x0001CBA2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600399A RID: 14746 RVA: 0x0001E9AB File Offset: 0x0001CBAB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2100_0.method_4();
			}

			// Token: 0x0600399B RID: 14747 RVA: 0x00122170 File Offset: 0x00120370
			public Class2018 method_0()
			{
				return this.class2100_0.method_5(this.int_0);
			}

			// Token: 0x04001A60 RID: 6752
			private int int_0;

			// Token: 0x04001A61 RID: 6753
			private Class2100 class2100_0;
		}

		// Token: 0x0200092B RID: 2347
		public sealed class Class1311 : IEnumerable
		{
			// Token: 0x0600399C RID: 14748 RVA: 0x0001E9CE File Offset: 0x0001CBCE
			public void method_0(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x00122190 File Offset: 0x00120390
			public Class2100.Class1312 method_1()
			{
				return new Class2100.Class1312(this.class2100_0);
			}

			// Token: 0x0600399E RID: 14750 RVA: 0x001221AC File Offset: 0x001203AC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A62 RID: 6754
			private Class2100 class2100_0;
		}

		// Token: 0x0200092C RID: 2348
		public sealed class Class1312 : IEnumerator
		{
			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x060039A0 RID: 14752 RVA: 0x001221C4 File Offset: 0x001203C4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039A1 RID: 14753 RVA: 0x0001E9D7 File Offset: 0x0001CBD7
			public Class1312(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
				this.int_0 = -1;
			}

			// Token: 0x060039A2 RID: 14754 RVA: 0x0001E9ED File Offset: 0x0001CBED
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039A3 RID: 14755 RVA: 0x0001E9F6 File Offset: 0x0001CBF6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2100_0.method_6();
			}

			// Token: 0x060039A4 RID: 14756 RVA: 0x001221DC File Offset: 0x001203DC
			public Class2010 method_0()
			{
				return this.class2100_0.method_7(this.int_0);
			}

			// Token: 0x04001A63 RID: 6755
			private int int_0;

			// Token: 0x04001A64 RID: 6756
			private Class2100 class2100_0;
		}

		// Token: 0x0200092D RID: 2349
		public sealed class Class1313 : IEnumerable
		{
			// Token: 0x060039A5 RID: 14757 RVA: 0x0001EA19 File Offset: 0x0001CC19
			public void method_0(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
			}

			// Token: 0x060039A6 RID: 14758 RVA: 0x001221FC File Offset: 0x001203FC
			public Class2100.Class1314 method_1()
			{
				return new Class2100.Class1314(this.class2100_0);
			}

			// Token: 0x060039A7 RID: 14759 RVA: 0x00122218 File Offset: 0x00120418
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A65 RID: 6757
			private Class2100 class2100_0;
		}

		// Token: 0x0200092E RID: 2350
		public sealed class Class1314 : IEnumerator
		{
			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x060039A9 RID: 14761 RVA: 0x00122230 File Offset: 0x00120430
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039AA RID: 14762 RVA: 0x0001EA22 File Offset: 0x0001CC22
			public Class1314(Class2100 class2100_1)
			{
				this.class2100_0 = class2100_1;
				this.int_0 = -1;
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x0001EA38 File Offset: 0x0001CC38
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039AC RID: 14764 RVA: 0x0001EA41 File Offset: 0x0001CC41
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2100_0.method_8();
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x00122248 File Offset: 0x00120448
			public Class2010 method_0()
			{
				return this.class2100_0.method_9(this.int_0);
			}

			// Token: 0x04001A66 RID: 6758
			private int int_0;

			// Token: 0x04001A67 RID: 6759
			private Class2100 class2100_0;
		}
	}
}
