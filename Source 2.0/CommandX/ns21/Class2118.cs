using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000E2 RID: 226
	public sealed class Class2118 : Class2059
	{
		// Token: 0x060004CB RID: 1227 RVA: 0x00006A7F File Offset: 0x00004C7F
		public Class2118()
		{
			this.method_6();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00006AA3 File Offset: 0x00004CA3
		public Class2118(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private void method_6()
		{
			this.class1497_0.method_0(this);
			this.class1499_0.method_0(this);
		}

		// Token: 0x0400024E RID: 590
		public Class2118.Class1497 class1497_0 = new Class2118.Class1497();

		// Token: 0x0400024F RID: 591
		public Class2118.Class1499 class1499_0 = new Class2118.Class1499();

		// Token: 0x020000E3 RID: 227
		public sealed class Class1497 : IEnumerable
		{
			// Token: 0x060004D2 RID: 1234 RVA: 0x00006AE2 File Offset: 0x00004CE2
			public void method_0(Class2118 class2118_1)
			{
				this.class2118_0 = class2118_1;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x000655AC File Offset: 0x000637AC
			public Class2118.Class1498 method_1()
			{
				return new Class2118.Class1498(this.class2118_0);
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x000655C8 File Offset: 0x000637C8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000250 RID: 592
			private Class2118 class2118_0;
		}

		// Token: 0x020000E4 RID: 228
		public sealed class Class1498 : IEnumerator
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000655E0 File Offset: 0x000637E0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00006AEB File Offset: 0x00004CEB
			public Class1498(Class2118 class2118_1)
			{
				this.class2118_0 = class2118_1;
				this.int_0 = -1;
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00006B01 File Offset: 0x00004D01
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x00006B0A File Offset: 0x00004D0A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2118_0.method_2();
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x000655F8 File Offset: 0x000637F8
			public Class2050 method_0()
			{
				return this.class2118_0.method_3(this.int_0);
			}

			// Token: 0x04000251 RID: 593
			private int int_0;

			// Token: 0x04000252 RID: 594
			private Class2118 class2118_0;
		}

		// Token: 0x020000E5 RID: 229
		public sealed class Class1499 : IEnumerable
		{
			// Token: 0x060004DB RID: 1243 RVA: 0x00006B2D File Offset: 0x00004D2D
			public void method_0(Class2118 class2118_1)
			{
				this.class2118_0 = class2118_1;
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x00065618 File Offset: 0x00063818
			public Class2118.Class1500 method_1()
			{
				return new Class2118.Class1500(this.class2118_0);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x00065634 File Offset: 0x00063834
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000253 RID: 595
			private Class2118 class2118_0;
		}

		// Token: 0x020000E6 RID: 230
		public sealed class Class1500 : IEnumerator
		{
			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0006564C File Offset: 0x0006384C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x00006B36 File Offset: 0x00004D36
			public Class1500(Class2118 class2118_1)
			{
				this.class2118_0 = class2118_1;
				this.int_0 = -1;
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x00006B4C File Offset: 0x00004D4C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x00006B55 File Offset: 0x00004D55
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2118_0.method_4();
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x00065664 File Offset: 0x00063864
			public Class2128 method_0()
			{
				return this.class2118_0.method_5(this.int_0);
			}

			// Token: 0x04000254 RID: 596
			private int int_0;

			// Token: 0x04000255 RID: 597
			private Class2118 class2118_0;
		}
	}
}
