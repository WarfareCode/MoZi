using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x020002C8 RID: 712
	public sealed class Class2163 : Class2059
	{
		// Token: 0x060010B0 RID: 4272 RVA: 0x0000CCD1 File Offset: 0x0000AED1
		public Class2163()
		{
			this.method_10();
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000CD0B File Offset: 0x0000AF0B
		public Class2163(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00069358 File Offset: 0x00067558
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "width");
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0007E448 File Offset: 0x0007C648
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "width", int_0)));
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x000693A4 File Offset: 0x000675A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "height");
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0007E474 File Offset: 0x0007C674
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "height", int_0)));
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_9(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0000CD46 File Offset: 0x0000AF46
		private void method_10()
		{
			this.class1843_0.method_0(this);
			this.class1845_0.method_0(this);
			this.class1847_0.method_0(this);
			this.class1849_0.method_0(this);
		}

		// Token: 0x040006BA RID: 1722
		public Class2163.Class1843 class1843_0 = new Class2163.Class1843();

		// Token: 0x040006BB RID: 1723
		public Class2163.Class1845 class1845_0 = new Class2163.Class1845();

		// Token: 0x040006BC RID: 1724
		public Class2163.Class1847 class1847_0 = new Class2163.Class1847();

		// Token: 0x040006BD RID: 1725
		public Class2163.Class1849 class1849_0 = new Class2163.Class1849();

		// Token: 0x020002C9 RID: 713
		public sealed class Class1843 : IEnumerable
		{
			// Token: 0x060010BB RID: 4283 RVA: 0x0000CD78 File Offset: 0x0000AF78
			public void method_0(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
			}

			// Token: 0x060010BC RID: 4284 RVA: 0x0007E95C File Offset: 0x0007CB5C
			public Class2163.Class1844 method_1()
			{
				return new Class2163.Class1844(this.class2163_0);
			}

			// Token: 0x060010BD RID: 4285 RVA: 0x0007E978 File Offset: 0x0007CB78
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006BE RID: 1726
			private Class2163 class2163_0;
		}

		// Token: 0x020002CA RID: 714
		public sealed class Class1844 : IEnumerator
		{
			// Token: 0x17000179 RID: 377
			// (get) Token: 0x060010BF RID: 4287 RVA: 0x0007E990 File Offset: 0x0007CB90
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060010C0 RID: 4288 RVA: 0x0000CD81 File Offset: 0x0000AF81
			public Class1844(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
				this.int_0 = -1;
			}

			// Token: 0x060010C1 RID: 4289 RVA: 0x0000CD97 File Offset: 0x0000AF97
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060010C2 RID: 4290 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2163_0.method_2();
			}

			// Token: 0x060010C3 RID: 4291 RVA: 0x0007E9A8 File Offset: 0x0007CBA8
			public Class2050 method_0()
			{
				return this.class2163_0.method_3(this.int_0);
			}

			// Token: 0x040006BF RID: 1727
			private int int_0;

			// Token: 0x040006C0 RID: 1728
			private Class2163 class2163_0;
		}

		// Token: 0x020002CB RID: 715
		public sealed class Class1845 : IEnumerable
		{
			// Token: 0x060010C4 RID: 4292 RVA: 0x0000CDC3 File Offset: 0x0000AFC3
			public void method_0(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
			}

			// Token: 0x060010C5 RID: 4293 RVA: 0x0007E9C8 File Offset: 0x0007CBC8
			public Class2163.Class1846 method_1()
			{
				return new Class2163.Class1846(this.class2163_0);
			}

			// Token: 0x060010C6 RID: 4294 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006C1 RID: 1729
			private Class2163 class2163_0;
		}

		// Token: 0x020002CC RID: 716
		public sealed class Class1846 : IEnumerator
		{
			// Token: 0x1700017A RID: 378
			// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0007E9FC File Offset: 0x0007CBFC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060010C9 RID: 4297 RVA: 0x0000CDCC File Offset: 0x0000AFCC
			public Class1846(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
				this.int_0 = -1;
			}

			// Token: 0x060010CA RID: 4298 RVA: 0x0000CDE2 File Offset: 0x0000AFE2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060010CB RID: 4299 RVA: 0x0000CDEB File Offset: 0x0000AFEB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2163_0.method_4();
			}

			// Token: 0x060010CC RID: 4300 RVA: 0x0007EA14 File Offset: 0x0007CC14
			public Class2050 method_0()
			{
				return this.class2163_0.method_5(this.int_0);
			}

			// Token: 0x040006C2 RID: 1730
			private int int_0;

			// Token: 0x040006C3 RID: 1731
			private Class2163 class2163_0;
		}

		// Token: 0x020002CD RID: 717
		public sealed class Class1847 : IEnumerable
		{
			// Token: 0x060010CD RID: 4301 RVA: 0x0000CE0E File Offset: 0x0000B00E
			public void method_0(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
			}

			// Token: 0x060010CE RID: 4302 RVA: 0x0007EA34 File Offset: 0x0007CC34
			public Class2163.Class1848 method_1()
			{
				return new Class2163.Class1848(this.class2163_0);
			}

			// Token: 0x060010CF RID: 4303 RVA: 0x0007EA50 File Offset: 0x0007CC50
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006C4 RID: 1732
			private Class2163 class2163_0;
		}

		// Token: 0x020002CE RID: 718
		public sealed class Class1848 : IEnumerator
		{
			// Token: 0x1700017B RID: 379
			// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0007EA68 File Offset: 0x0007CC68
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060010D2 RID: 4306 RVA: 0x0000CE17 File Offset: 0x0000B017
			public Class1848(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
				this.int_0 = -1;
			}

			// Token: 0x060010D3 RID: 4307 RVA: 0x0000CE2D File Offset: 0x0000B02D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060010D4 RID: 4308 RVA: 0x0000CE36 File Offset: 0x0000B036
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2163_0.method_6();
			}

			// Token: 0x060010D5 RID: 4309 RVA: 0x0007EA80 File Offset: 0x0007CC80
			public Class2050 method_0()
			{
				return this.class2163_0.method_7(this.int_0);
			}

			// Token: 0x040006C5 RID: 1733
			private int int_0;

			// Token: 0x040006C6 RID: 1734
			private Class2163 class2163_0;
		}

		// Token: 0x020002CF RID: 719
		public sealed class Class1849 : IEnumerable
		{
			// Token: 0x060010D6 RID: 4310 RVA: 0x0000CE59 File Offset: 0x0000B059
			public void method_0(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
			}

			// Token: 0x060010D7 RID: 4311 RVA: 0x0007EAA0 File Offset: 0x0007CCA0
			public Class2163.Class1850 method_1()
			{
				return new Class2163.Class1850(this.class2163_0);
			}

			// Token: 0x060010D8 RID: 4312 RVA: 0x0007EABC File Offset: 0x0007CCBC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040006C7 RID: 1735
			private Class2163 class2163_0;
		}

		// Token: 0x020002D0 RID: 720
		public sealed class Class1850 : IEnumerator
		{
			// Token: 0x1700017C RID: 380
			// (get) Token: 0x060010DA RID: 4314 RVA: 0x0007EAD4 File Offset: 0x0007CCD4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060010DB RID: 4315 RVA: 0x0000CE62 File Offset: 0x0000B062
			public Class1850(Class2163 class2163_1)
			{
				this.class2163_0 = class2163_1;
				this.int_0 = -1;
			}

			// Token: 0x060010DC RID: 4316 RVA: 0x0000CE78 File Offset: 0x0000B078
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060010DD RID: 4317 RVA: 0x0000CE81 File Offset: 0x0000B081
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2163_0.method_8();
			}

			// Token: 0x060010DE RID: 4318 RVA: 0x0007EAEC File Offset: 0x0007CCEC
			public Class2165 method_0()
			{
				return this.class2163_0.method_9(this.int_0);
			}

			// Token: 0x040006C8 RID: 1736
			private int int_0;

			// Token: 0x040006C9 RID: 1737
			private Class2163 class2163_0;
		}
	}
}
