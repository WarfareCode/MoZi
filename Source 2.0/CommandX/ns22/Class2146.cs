using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000225 RID: 549
	public sealed class Class2146 : Class2059
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x0000AB10 File Offset: 0x00008D10
		public Class2146()
		{
			this.method_6();
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0000AB34 File Offset: 0x00008D34
		public Class2146(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00079DDC File Offset: 0x00077FDC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DCPType");
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00079DFC File Offset: 0x00077FFC
		public Class2145 method_5(int int_0)
		{
			return new Class2145(base.method_1(Class2059.Enum155.const_1, "", "DCPType", int_0));
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000AB59 File Offset: 0x00008D59
		private void method_6()
		{
			this.class1727_0.method_0(this);
			this.class1729_0.method_0(this);
		}

		// Token: 0x04000583 RID: 1411
		public Class2146.Class1727 class1727_0 = new Class2146.Class1727();

		// Token: 0x04000584 RID: 1412
		public Class2146.Class1729 class1729_0 = new Class2146.Class1729();

		// Token: 0x02000226 RID: 550
		public sealed class Class1727 : IEnumerable
		{
			// Token: 0x06000CE4 RID: 3300 RVA: 0x0000AB73 File Offset: 0x00008D73
			public void method_0(Class2146 class2146_1)
			{
				this.class2146_0 = class2146_1;
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x00079E24 File Offset: 0x00078024
			public Class2146.Class1728 method_1()
			{
				return new Class2146.Class1728(this.class2146_0);
			}

			// Token: 0x06000CE6 RID: 3302 RVA: 0x00079E40 File Offset: 0x00078040
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000585 RID: 1413
			private Class2146 class2146_0;
		}

		// Token: 0x02000227 RID: 551
		public sealed class Class1728 : IEnumerator
		{
			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00079E58 File Offset: 0x00078058
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CE9 RID: 3305 RVA: 0x0000AB7C File Offset: 0x00008D7C
			public Class1728(Class2146 class2146_1)
			{
				this.class2146_0 = class2146_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CEA RID: 3306 RVA: 0x0000AB92 File Offset: 0x00008D92
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CEB RID: 3307 RVA: 0x0000AB9B File Offset: 0x00008D9B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2146_0.method_2();
			}

			// Token: 0x06000CEC RID: 3308 RVA: 0x00079E70 File Offset: 0x00078070
			public Class2050 method_0()
			{
				return this.class2146_0.method_3(this.int_0);
			}

			// Token: 0x04000586 RID: 1414
			private int int_0;

			// Token: 0x04000587 RID: 1415
			private Class2146 class2146_0;
		}

		// Token: 0x02000228 RID: 552
		public sealed class Class1729 : IEnumerable
		{
			// Token: 0x06000CED RID: 3309 RVA: 0x0000ABBE File Offset: 0x00008DBE
			public void method_0(Class2146 class2146_1)
			{
				this.class2146_0 = class2146_1;
			}

			// Token: 0x06000CEE RID: 3310 RVA: 0x00079E90 File Offset: 0x00078090
			public Class2146.Class1730 method_1()
			{
				return new Class2146.Class1730(this.class2146_0);
			}

			// Token: 0x06000CEF RID: 3311 RVA: 0x00079EAC File Offset: 0x000780AC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000588 RID: 1416
			private Class2146 class2146_0;
		}

		// Token: 0x02000229 RID: 553
		public sealed class Class1730 : IEnumerator
		{
			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00079EC4 File Offset: 0x000780C4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CF2 RID: 3314 RVA: 0x0000ABC7 File Offset: 0x00008DC7
			public Class1730(Class2146 class2146_1)
			{
				this.class2146_0 = class2146_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CF3 RID: 3315 RVA: 0x0000ABDD File Offset: 0x00008DDD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CF4 RID: 3316 RVA: 0x0000ABE6 File Offset: 0x00008DE6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2146_0.method_4();
			}

			// Token: 0x06000CF5 RID: 3317 RVA: 0x00079EDC File Offset: 0x000780DC
			public Class2145 method_0()
			{
				return this.class2146_0.method_5(this.int_0);
			}

			// Token: 0x04000589 RID: 1417
			private int int_0;

			// Token: 0x0400058A RID: 1418
			private Class2146 class2146_0;
		}
	}
}
