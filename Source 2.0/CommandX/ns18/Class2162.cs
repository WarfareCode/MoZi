using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x020002BC RID: 700
	public sealed class Class2162 : Class2059
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x0000CA29 File Offset: 0x0000AC29
		public Class2162()
		{
			this.method_10();
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0000CA63 File Offset: 0x0000AC63
		public Class2162(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00069358 File Offset: 0x00067558
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "width");
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0007E448 File Offset: 0x0007C648
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "width", int_0)));
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000693A4 File Offset: 0x000675A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "height");
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0007E474 File Offset: 0x0007C674
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "height", int_0)));
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_9(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0000CA9E File Offset: 0x0000AC9E
		private void method_10()
		{
			this.class1835_0.method_0(this);
			this.class1837_0.method_0(this);
			this.class1839_0.method_0(this);
			this.class1841_0.method_0(this);
		}

		// Token: 0x040006A1 RID: 1697
		public Class2162.Class1835 class1835_0 = new Class2162.Class1835();

		// Token: 0x040006A2 RID: 1698
		public Class2162.Class1837 class1837_0 = new Class2162.Class1837();

		// Token: 0x040006A3 RID: 1699
		public Class2162.Class1839 class1839_0 = new Class2162.Class1839();

		// Token: 0x040006A4 RID: 1700
		public Class2162.Class1841 class1841_0 = new Class2162.Class1841();

		// Token: 0x020002BD RID: 701
		public sealed class Class1835 : IEnumerable
		{
			// Token: 0x06001073 RID: 4211 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
			public void method_0(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
			}

			// Token: 0x06001074 RID: 4212 RVA: 0x0007E4A0 File Offset: 0x0007C6A0
			public Class2162.Class1836 method_1()
			{
				return new Class2162.Class1836(this.class2162_0);
			}

			// Token: 0x06001075 RID: 4213 RVA: 0x0007E4BC File Offset: 0x0007C6BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006A5 RID: 1701
			private Class2162 class2162_0;
		}

		// Token: 0x020002BE RID: 702
		public sealed class Class1836 : IEnumerator
		{
			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06001077 RID: 4215 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001078 RID: 4216 RVA: 0x0000CAD9 File Offset: 0x0000ACD9
			public Class1836(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
				this.int_0 = -1;
			}

			// Token: 0x06001079 RID: 4217 RVA: 0x0000CAEF File Offset: 0x0000ACEF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600107A RID: 4218 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2162_0.method_2();
			}

			// Token: 0x0600107B RID: 4219 RVA: 0x0007E4EC File Offset: 0x0007C6EC
			public Class2050 method_0()
			{
				return this.class2162_0.method_3(this.int_0);
			}

			// Token: 0x040006A6 RID: 1702
			private int int_0;

			// Token: 0x040006A7 RID: 1703
			private Class2162 class2162_0;
		}

		// Token: 0x020002BF RID: 703
		public sealed class Class1837 : IEnumerable
		{
			// Token: 0x0600107C RID: 4220 RVA: 0x0000CB1B File Offset: 0x0000AD1B
			public void method_0(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
			}

			// Token: 0x0600107D RID: 4221 RVA: 0x0007E50C File Offset: 0x0007C70C
			public Class2162.Class1838 method_1()
			{
				return new Class2162.Class1838(this.class2162_0);
			}

			// Token: 0x0600107E RID: 4222 RVA: 0x0007E528 File Offset: 0x0007C728
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006A8 RID: 1704
			private Class2162 class2162_0;
		}

		// Token: 0x020002C0 RID: 704
		public sealed class Class1838 : IEnumerator
		{
			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06001080 RID: 4224 RVA: 0x0007E540 File Offset: 0x0007C740
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001081 RID: 4225 RVA: 0x0000CB24 File Offset: 0x0000AD24
			public Class1838(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
				this.int_0 = -1;
			}

			// Token: 0x06001082 RID: 4226 RVA: 0x0000CB3A File Offset: 0x0000AD3A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001083 RID: 4227 RVA: 0x0000CB43 File Offset: 0x0000AD43
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2162_0.method_4();
			}

			// Token: 0x06001084 RID: 4228 RVA: 0x0007E558 File Offset: 0x0007C758
			public Class2050 method_0()
			{
				return this.class2162_0.method_5(this.int_0);
			}

			// Token: 0x040006A9 RID: 1705
			private int int_0;

			// Token: 0x040006AA RID: 1706
			private Class2162 class2162_0;
		}

		// Token: 0x020002C1 RID: 705
		public sealed class Class1839 : IEnumerable
		{
			// Token: 0x06001085 RID: 4229 RVA: 0x0000CB66 File Offset: 0x0000AD66
			public void method_0(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
			}

			// Token: 0x06001086 RID: 4230 RVA: 0x0007E578 File Offset: 0x0007C778
			public Class2162.Class1840 method_1()
			{
				return new Class2162.Class1840(this.class2162_0);
			}

			// Token: 0x06001087 RID: 4231 RVA: 0x0007E594 File Offset: 0x0007C794
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006AB RID: 1707
			private Class2162 class2162_0;
		}

		// Token: 0x020002C2 RID: 706
		public sealed class Class1840 : IEnumerator
		{
			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06001089 RID: 4233 RVA: 0x0007E5AC File Offset: 0x0007C7AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600108A RID: 4234 RVA: 0x0000CB6F File Offset: 0x0000AD6F
			public Class1840(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
				this.int_0 = -1;
			}

			// Token: 0x0600108B RID: 4235 RVA: 0x0000CB85 File Offset: 0x0000AD85
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600108C RID: 4236 RVA: 0x0000CB8E File Offset: 0x0000AD8E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2162_0.method_6();
			}

			// Token: 0x0600108D RID: 4237 RVA: 0x0007E5C4 File Offset: 0x0007C7C4
			public Class2050 method_0()
			{
				return this.class2162_0.method_7(this.int_0);
			}

			// Token: 0x040006AC RID: 1708
			private int int_0;

			// Token: 0x040006AD RID: 1709
			private Class2162 class2162_0;
		}

		// Token: 0x020002C3 RID: 707
		public sealed class Class1841 : IEnumerable
		{
			// Token: 0x0600108E RID: 4238 RVA: 0x0000CBB1 File Offset: 0x0000ADB1
			public void method_0(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
			}

			// Token: 0x0600108F RID: 4239 RVA: 0x0007E5E4 File Offset: 0x0007C7E4
			public Class2162.Class1842 method_1()
			{
				return new Class2162.Class1842(this.class2162_0);
			}

			// Token: 0x06001090 RID: 4240 RVA: 0x0007E600 File Offset: 0x0007C800
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006AE RID: 1710
			private Class2162 class2162_0;
		}

		// Token: 0x020002C4 RID: 708
		public sealed class Class1842 : IEnumerator
		{
			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06001092 RID: 4242 RVA: 0x0007E618 File Offset: 0x0007C818
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001093 RID: 4243 RVA: 0x0000CBBA File Offset: 0x0000ADBA
			public Class1842(Class2162 class2162_1)
			{
				this.class2162_0 = class2162_1;
				this.int_0 = -1;
			}

			// Token: 0x06001094 RID: 4244 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001095 RID: 4245 RVA: 0x0000CBD9 File Offset: 0x0000ADD9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2162_0.method_8();
			}

			// Token: 0x06001096 RID: 4246 RVA: 0x0007E630 File Offset: 0x0007C830
			public Class2165 method_0()
			{
				return this.class2162_0.method_9(this.int_0);
			}

			// Token: 0x040006AF RID: 1711
			private int int_0;

			// Token: 0x040006B0 RID: 1712
			private Class2162 class2162_0;
		}
	}
}
