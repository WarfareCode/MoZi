using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns21
{
	// Token: 0x0200015F RID: 351
	public sealed class Class2128 : Class2059
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0006A59C File Offset: 0x0006879C
		public Class2128()
		{
			this.method_16();
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0006A604 File Offset: 0x00068804
		public Class2128(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_16();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0006A66C File Offset: 0x0006886C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "type");
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0006A68C File Offset: 0x0006888C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "type", int_0)));
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0006A6B8 File Offset: 0x000688B8
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "href");
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0006A6D8 File Offset: 0x000688D8
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "href", int_0)));
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0006A704 File Offset: 0x00068904
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "role");
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0006A724 File Offset: 0x00068924
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "role", int_0)));
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0006A750 File Offset: 0x00068950
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "arcrole");
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0006A770 File Offset: 0x00068970
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "arcrole", int_0)));
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0006A79C File Offset: 0x0006899C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "title");
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0006A7BC File Offset: 0x000689BC
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "title", int_0)));
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0006A7E8 File Offset: 0x000689E8
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "show");
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0006A808 File Offset: 0x00068A08
		public Class2057 method_13(int int_0)
		{
			return new Class2057(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "show", int_0)));
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0006A834 File Offset: 0x00068A34
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "actuate");
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0006A854 File Offset: 0x00068A54
		public Class2056 method_15(int int_0)
		{
			return new Class2056(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "http://www.w3.org/1999/xlink", "actuate", int_0)));
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0006A880 File Offset: 0x00068A80
		private void method_16()
		{
			this.class1583_0.method_0(this);
			this.class1585_0.method_0(this);
			this.class1587_0.method_0(this);
			this.class1589_0.method_0(this);
			this.class1591_0.method_0(this);
			this.class1593_0.method_0(this);
			this.class1595_0.method_0(this);
		}

		// Token: 0x04000361 RID: 865
		public Class2128.Class1583 class1583_0 = new Class2128.Class1583();

		// Token: 0x04000362 RID: 866
		public Class2128.Class1585 class1585_0 = new Class2128.Class1585();

		// Token: 0x04000363 RID: 867
		public Class2128.Class1587 class1587_0 = new Class2128.Class1587();

		// Token: 0x04000364 RID: 868
		public Class2128.Class1589 class1589_0 = new Class2128.Class1589();

		// Token: 0x04000365 RID: 869
		public Class2128.Class1591 class1591_0 = new Class2128.Class1591();

		// Token: 0x04000366 RID: 870
		public Class2128.Class1593 class1593_0 = new Class2128.Class1593();

		// Token: 0x04000367 RID: 871
		public Class2128.Class1595 class1595_0 = new Class2128.Class1595();

		// Token: 0x02000160 RID: 352
		public sealed class Class1583 : IEnumerable
		{
			// Token: 0x060007BC RID: 1980 RVA: 0x00008376 File Offset: 0x00006576
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x0006A8E4 File Offset: 0x00068AE4
			public Class2128.Class1584 method_1()
			{
				return new Class2128.Class1584(this.class2128_0);
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x0006A900 File Offset: 0x00068B00
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000368 RID: 872
			private Class2128 class2128_0;
		}

		// Token: 0x02000161 RID: 353
		public sealed class Class1584 : IEnumerator
		{
			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0006A918 File Offset: 0x00068B18
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x0000837F File Offset: 0x0000657F
			public Class1584(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00008395 File Offset: 0x00006595
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x0000839E File Offset: 0x0000659E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_2();
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x0006A930 File Offset: 0x00068B30
			public Class2050 method_0()
			{
				return this.class2128_0.method_3(this.int_0);
			}

			// Token: 0x04000369 RID: 873
			private int int_0;

			// Token: 0x0400036A RID: 874
			private Class2128 class2128_0;
		}

		// Token: 0x02000162 RID: 354
		public sealed class Class1585 : IEnumerable
		{
			// Token: 0x060007C5 RID: 1989 RVA: 0x000083C1 File Offset: 0x000065C1
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x0006A950 File Offset: 0x00068B50
			public Class2128.Class1586 method_1()
			{
				return new Class2128.Class1586(this.class2128_0);
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x0006A96C File Offset: 0x00068B6C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400036B RID: 875
			private Class2128 class2128_0;
		}

		// Token: 0x02000163 RID: 355
		public sealed class Class1586 : IEnumerator
		{
			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0006A984 File Offset: 0x00068B84
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x000083CA File Offset: 0x000065CA
			public Class1586(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x000083E0 File Offset: 0x000065E0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x000083E9 File Offset: 0x000065E9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_4();
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x0006A99C File Offset: 0x00068B9C
			public Class2050 method_0()
			{
				return this.class2128_0.method_5(this.int_0);
			}

			// Token: 0x0400036C RID: 876
			private int int_0;

			// Token: 0x0400036D RID: 877
			private Class2128 class2128_0;
		}

		// Token: 0x02000164 RID: 356
		public sealed class Class1587 : IEnumerable
		{
			// Token: 0x060007CE RID: 1998 RVA: 0x0000840C File Offset: 0x0000660C
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x0006A9BC File Offset: 0x00068BBC
			public Class2128.Class1588 method_1()
			{
				return new Class2128.Class1588(this.class2128_0);
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x0006A9D8 File Offset: 0x00068BD8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400036E RID: 878
			private Class2128 class2128_0;
		}

		// Token: 0x02000165 RID: 357
		public sealed class Class1588 : IEnumerator
		{
			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0006A9F0 File Offset: 0x00068BF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00008415 File Offset: 0x00006615
			public Class1588(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007D4 RID: 2004 RVA: 0x0000842B File Offset: 0x0000662B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x00008434 File Offset: 0x00006634
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_6();
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x0006AA08 File Offset: 0x00068C08
			public Class2050 method_0()
			{
				return this.class2128_0.method_7(this.int_0);
			}

			// Token: 0x0400036F RID: 879
			private int int_0;

			// Token: 0x04000370 RID: 880
			private Class2128 class2128_0;
		}

		// Token: 0x02000166 RID: 358
		public sealed class Class1589 : IEnumerable
		{
			// Token: 0x060007D7 RID: 2007 RVA: 0x00008457 File Offset: 0x00006657
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x0006AA28 File Offset: 0x00068C28
			public Class2128.Class1590 method_1()
			{
				return new Class2128.Class1590(this.class2128_0);
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x0006AA44 File Offset: 0x00068C44
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000371 RID: 881
			private Class2128 class2128_0;
		}

		// Token: 0x02000167 RID: 359
		public sealed class Class1590 : IEnumerator
		{
			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060007DB RID: 2011 RVA: 0x0006AA5C File Offset: 0x00068C5C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x00008460 File Offset: 0x00006660
			public Class1590(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x00008476 File Offset: 0x00006676
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x0000847F File Offset: 0x0000667F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_8();
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x0006AA74 File Offset: 0x00068C74
			public Class2050 method_0()
			{
				return this.class2128_0.method_9(this.int_0);
			}

			// Token: 0x04000372 RID: 882
			private int int_0;

			// Token: 0x04000373 RID: 883
			private Class2128 class2128_0;
		}

		// Token: 0x02000168 RID: 360
		public sealed class Class1591 : IEnumerable
		{
			// Token: 0x060007E0 RID: 2016 RVA: 0x000084A2 File Offset: 0x000066A2
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007E1 RID: 2017 RVA: 0x0006AA94 File Offset: 0x00068C94
			public Class2128.Class1592 method_1()
			{
				return new Class2128.Class1592(this.class2128_0);
			}

			// Token: 0x060007E2 RID: 2018 RVA: 0x0006AAB0 File Offset: 0x00068CB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000374 RID: 884
			private Class2128 class2128_0;
		}

		// Token: 0x02000169 RID: 361
		public sealed class Class1592 : IEnumerator
		{
			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0006AAC8 File Offset: 0x00068CC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007E5 RID: 2021 RVA: 0x000084AB File Offset: 0x000066AB
			public Class1592(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007E6 RID: 2022 RVA: 0x000084C1 File Offset: 0x000066C1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x000084CA File Offset: 0x000066CA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_10();
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x0006AAE0 File Offset: 0x00068CE0
			public Class2050 method_0()
			{
				return this.class2128_0.method_11(this.int_0);
			}

			// Token: 0x04000375 RID: 885
			private int int_0;

			// Token: 0x04000376 RID: 886
			private Class2128 class2128_0;
		}

		// Token: 0x0200016A RID: 362
		public sealed class Class1593 : IEnumerable
		{
			// Token: 0x060007E9 RID: 2025 RVA: 0x000084ED File Offset: 0x000066ED
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x0006AB00 File Offset: 0x00068D00
			public Class2128.Class1594 method_1()
			{
				return new Class2128.Class1594(this.class2128_0);
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x0006AB1C File Offset: 0x00068D1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000377 RID: 887
			private Class2128 class2128_0;
		}

		// Token: 0x0200016B RID: 363
		public sealed class Class1594 : IEnumerator
		{
			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060007ED RID: 2029 RVA: 0x0006AB34 File Offset: 0x00068D34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x000084F6 File Offset: 0x000066F6
			public Class1594(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x0000850C File Offset: 0x0000670C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007F0 RID: 2032 RVA: 0x00008515 File Offset: 0x00006715
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_12();
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x0006AB4C File Offset: 0x00068D4C
			public Class2057 method_0()
			{
				return this.class2128_0.method_13(this.int_0);
			}

			// Token: 0x04000378 RID: 888
			private int int_0;

			// Token: 0x04000379 RID: 889
			private Class2128 class2128_0;
		}

		// Token: 0x0200016C RID: 364
		public sealed class Class1595 : IEnumerable
		{
			// Token: 0x060007F2 RID: 2034 RVA: 0x00008538 File Offset: 0x00006738
			public void method_0(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
			}

			// Token: 0x060007F3 RID: 2035 RVA: 0x0006AB6C File Offset: 0x00068D6C
			public Class2128.Class1596 method_1()
			{
				return new Class2128.Class1596(this.class2128_0);
			}

			// Token: 0x060007F4 RID: 2036 RVA: 0x0006AB88 File Offset: 0x00068D88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400037A RID: 890
			private Class2128 class2128_0;
		}

		// Token: 0x0200016D RID: 365
		public sealed class Class1596 : IEnumerator
		{
			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0006ABA0 File Offset: 0x00068DA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060007F7 RID: 2039 RVA: 0x00008541 File Offset: 0x00006741
			public Class1596(Class2128 class2128_1)
			{
				this.class2128_0 = class2128_1;
				this.int_0 = -1;
			}

			// Token: 0x060007F8 RID: 2040 RVA: 0x00008557 File Offset: 0x00006757
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x00008560 File Offset: 0x00006760
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2128_0.method_14();
			}

			// Token: 0x060007FA RID: 2042 RVA: 0x0006ABB8 File Offset: 0x00068DB8
			public Class2056 method_0()
			{
				return this.class2128_0.method_15(this.int_0);
			}

			// Token: 0x0400037B RID: 891
			private int int_0;

			// Token: 0x0400037C RID: 892
			private Class2128 class2128_0;
		}
	}
}
