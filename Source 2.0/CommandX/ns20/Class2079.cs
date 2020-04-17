using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x020007BD RID: 1981
	public sealed class Class2079 : Class2059
	{
		// Token: 0x0600311E RID: 12574 RVA: 0x0001A657 File Offset: 0x00018857
		public Class2079()
		{
			this.method_10();
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0001A691 File Offset: 0x00018891
		public Class2079(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000FFF60 File Offset: 0x000FE160
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerUrl");
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000FFF80 File Offset: 0x000FE180
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerUrl", int_0)));
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000FFFAC File Offset: 0x000FE1AC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DataSetName");
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000FFFCC File Offset: 0x000FE1CC
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DataSetName", int_0)));
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000590B8 File Offset: 0x000572B8
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CacheExpirationTime");
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000590D8 File Offset: 0x000572D8
		public Class2100 method_7(int int_0)
		{
			return new Class2100(base.method_1(Class2059.Enum155.const_1, "", "CacheExpirationTime", int_0));
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x0005914C File Offset: 0x0005734C
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerLogoFilePath");
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0005916C File Offset: 0x0005736C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerLogoFilePath", int_0)));
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0001A6CC File Offset: 0x000188CC
		private void method_10()
		{
			this.class1039_0.method_0(this);
			this.class1041_0.method_0(this);
			this.class1043_0.method_0(this);
			this.class1045_0.method_0(this);
		}

		// Token: 0x040016D7 RID: 5847
		public Class2079.Class1039 class1039_0 = new Class2079.Class1039();

		// Token: 0x040016D8 RID: 5848
		public Class2079.Class1041 class1041_0 = new Class2079.Class1041();

		// Token: 0x040016D9 RID: 5849
		public Class2079.Class1043 class1043_0 = new Class2079.Class1043();

		// Token: 0x040016DA RID: 5850
		public Class2079.Class1045 class1045_0 = new Class2079.Class1045();

		// Token: 0x020007BE RID: 1982
		public sealed class Class1039 : IEnumerable
		{
			// Token: 0x06003129 RID: 12585 RVA: 0x0001A6FE File Offset: 0x000188FE
			public void method_0(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
			}

			// Token: 0x0600312A RID: 12586 RVA: 0x0010BA94 File Offset: 0x00109C94
			public Class2079.Class1040 method_1()
			{
				return new Class2079.Class1040(this.class2079_0);
			}

			// Token: 0x0600312B RID: 12587 RVA: 0x0010BAB0 File Offset: 0x00109CB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016DB RID: 5851
			private Class2079 class2079_0;
		}

		// Token: 0x020007BF RID: 1983
		public sealed class Class1040 : IEnumerator
		{
			// Token: 0x17000360 RID: 864
			// (get) Token: 0x0600312D RID: 12589 RVA: 0x0010BAC8 File Offset: 0x00109CC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600312E RID: 12590 RVA: 0x0001A707 File Offset: 0x00018907
			public Class1040(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
				this.int_0 = -1;
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x0001A71D File Offset: 0x0001891D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003130 RID: 12592 RVA: 0x0001A726 File Offset: 0x00018926
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2079_0.method_2();
			}

			// Token: 0x06003131 RID: 12593 RVA: 0x0010BAE0 File Offset: 0x00109CE0
			public Class2050 method_0()
			{
				return this.class2079_0.method_3(this.int_0);
			}

			// Token: 0x040016DC RID: 5852
			private int int_0;

			// Token: 0x040016DD RID: 5853
			private Class2079 class2079_0;
		}

		// Token: 0x020007C0 RID: 1984
		public sealed class Class1041 : IEnumerable
		{
			// Token: 0x06003132 RID: 12594 RVA: 0x0001A749 File Offset: 0x00018949
			public void method_0(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
			}

			// Token: 0x06003133 RID: 12595 RVA: 0x0010BB00 File Offset: 0x00109D00
			public Class2079.Class1042 method_1()
			{
				return new Class2079.Class1042(this.class2079_0);
			}

			// Token: 0x06003134 RID: 12596 RVA: 0x0010BB1C File Offset: 0x00109D1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016DE RID: 5854
			private Class2079 class2079_0;
		}

		// Token: 0x020007C1 RID: 1985
		public sealed class Class1042 : IEnumerator
		{
			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06003136 RID: 12598 RVA: 0x0010BB34 File Offset: 0x00109D34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003137 RID: 12599 RVA: 0x0001A752 File Offset: 0x00018952
			public Class1042(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
				this.int_0 = -1;
			}

			// Token: 0x06003138 RID: 12600 RVA: 0x0001A768 File Offset: 0x00018968
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003139 RID: 12601 RVA: 0x0001A771 File Offset: 0x00018971
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2079_0.method_4();
			}

			// Token: 0x0600313A RID: 12602 RVA: 0x0010BB4C File Offset: 0x00109D4C
			public Class2050 method_0()
			{
				return this.class2079_0.method_5(this.int_0);
			}

			// Token: 0x040016DF RID: 5855
			private int int_0;

			// Token: 0x040016E0 RID: 5856
			private Class2079 class2079_0;
		}

		// Token: 0x020007C2 RID: 1986
		public sealed class Class1043 : IEnumerable
		{
			// Token: 0x0600313B RID: 12603 RVA: 0x0001A794 File Offset: 0x00018994
			public void method_0(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
			}

			// Token: 0x0600313C RID: 12604 RVA: 0x0010BB6C File Offset: 0x00109D6C
			public Class2079.Class1044 method_1()
			{
				return new Class2079.Class1044(this.class2079_0);
			}

			// Token: 0x0600313D RID: 12605 RVA: 0x0010BB88 File Offset: 0x00109D88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016E1 RID: 5857
			private Class2079 class2079_0;
		}

		// Token: 0x020007C3 RID: 1987
		public sealed class Class1044 : IEnumerator
		{
			// Token: 0x17000362 RID: 866
			// (get) Token: 0x0600313F RID: 12607 RVA: 0x0010BBA0 File Offset: 0x00109DA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003140 RID: 12608 RVA: 0x0001A79D File Offset: 0x0001899D
			public Class1044(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
				this.int_0 = -1;
			}

			// Token: 0x06003141 RID: 12609 RVA: 0x0001A7B3 File Offset: 0x000189B3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003142 RID: 12610 RVA: 0x0001A7BC File Offset: 0x000189BC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2079_0.method_6();
			}

			// Token: 0x06003143 RID: 12611 RVA: 0x0010BBB8 File Offset: 0x00109DB8
			public Class2100 method_0()
			{
				return this.class2079_0.method_7(this.int_0);
			}

			// Token: 0x040016E2 RID: 5858
			private int int_0;

			// Token: 0x040016E3 RID: 5859
			private Class2079 class2079_0;
		}

		// Token: 0x020007C4 RID: 1988
		public sealed class Class1045 : IEnumerable
		{
			// Token: 0x06003144 RID: 12612 RVA: 0x0001A7DF File Offset: 0x000189DF
			public void method_0(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
			}

			// Token: 0x06003145 RID: 12613 RVA: 0x0010BBD8 File Offset: 0x00109DD8
			public Class2079.Class1046 method_1()
			{
				return new Class2079.Class1046(this.class2079_0);
			}

			// Token: 0x06003146 RID: 12614 RVA: 0x0010BBF4 File Offset: 0x00109DF4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016E4 RID: 5860
			private Class2079 class2079_0;
		}

		// Token: 0x020007C5 RID: 1989
		public sealed class Class1046 : IEnumerator
		{
			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06003148 RID: 12616 RVA: 0x0010BC0C File Offset: 0x00109E0C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003149 RID: 12617 RVA: 0x0001A7E8 File Offset: 0x000189E8
			public Class1046(Class2079 class2079_1)
			{
				this.class2079_0 = class2079_1;
				this.int_0 = -1;
			}

			// Token: 0x0600314A RID: 12618 RVA: 0x0001A7FE File Offset: 0x000189FE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600314B RID: 12619 RVA: 0x0001A807 File Offset: 0x00018A07
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2079_0.method_8();
			}

			// Token: 0x0600314C RID: 12620 RVA: 0x0010BC24 File Offset: 0x00109E24
			public Class2050 method_0()
			{
				return this.class2079_0.method_9(this.int_0);
			}

			// Token: 0x040016E5 RID: 5861
			private int int_0;

			// Token: 0x040016E6 RID: 5862
			private Class2079 class2079_0;
		}
	}
}
