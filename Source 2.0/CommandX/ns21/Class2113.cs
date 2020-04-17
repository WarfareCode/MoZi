using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000BE RID: 190
	public sealed class Class2113 : Class2059
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x000063AE File Offset: 0x000045AE
		public Class2113()
		{
			this.method_6();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000063D2 File Offset: 0x000045D2
		public Class2113(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0005FB8C File Offset: 0x0005DD8C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format");
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Format", int_0)));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_5(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000063F7 File Offset: 0x000045F7
		private void method_6()
		{
			this.class1467_0.method_0(this);
			this.class1469_0.method_0(this);
		}

		// Token: 0x04000203 RID: 515
		public Class2113.Class1467 class1467_0 = new Class2113.Class1467();

		// Token: 0x04000204 RID: 516
		public Class2113.Class1469 class1469_0 = new Class2113.Class1469();

		// Token: 0x020000BF RID: 191
		public sealed class Class1467 : IEnumerable
		{
			// Token: 0x060003CA RID: 970 RVA: 0x00006411 File Offset: 0x00004611
			public void method_0(Class2113 class2113_1)
			{
				this.class2113_0 = class2113_1;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0005FBD8 File Offset: 0x0005DDD8
			public Class2113.Class1468 method_1()
			{
				return new Class2113.Class1468(this.class2113_0);
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0005FBF4 File Offset: 0x0005DDF4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000205 RID: 517
			private Class2113 class2113_0;
		}

		// Token: 0x020000C0 RID: 192
		public sealed class Class1468 : IEnumerator
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060003CE RID: 974 RVA: 0x0005FC0C File Offset: 0x0005DE0C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000641A File Offset: 0x0000461A
			public Class1468(Class2113 class2113_1)
			{
				this.class2113_0 = class2113_1;
				this.int_0 = -1;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00006430 File Offset: 0x00004630
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00006439 File Offset: 0x00004639
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2113_0.method_2();
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0005FC24 File Offset: 0x0005DE24
			public Class2050 method_0()
			{
				return this.class2113_0.method_3(this.int_0);
			}

			// Token: 0x04000206 RID: 518
			private int int_0;

			// Token: 0x04000207 RID: 519
			private Class2113 class2113_0;
		}

		// Token: 0x020000C1 RID: 193
		public sealed class Class1469 : IEnumerable
		{
			// Token: 0x060003D3 RID: 979 RVA: 0x0000645C File Offset: 0x0000465C
			public void method_0(Class2113 class2113_1)
			{
				this.class2113_0 = class2113_1;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0005FC44 File Offset: 0x0005DE44
			public Class2113.Class1470 method_1()
			{
				return new Class2113.Class1470(this.class2113_0);
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x0005FC60 File Offset: 0x0005DE60
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000208 RID: 520
			private Class2113 class2113_0;
		}

		// Token: 0x020000C2 RID: 194
		public sealed class Class1470 : IEnumerator
		{
			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x0005FC78 File Offset: 0x0005DE78
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00006465 File Offset: 0x00004665
			public Class1470(Class2113 class2113_1)
			{
				this.class2113_0 = class2113_1;
				this.int_0 = -1;
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x0000647B File Offset: 0x0000467B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00006484 File Offset: 0x00004684
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2113_0.method_4();
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0005FC90 File Offset: 0x0005DE90
			public Class2128 method_0()
			{
				return this.class2113_0.method_5(this.int_0);
			}

			// Token: 0x04000209 RID: 521
			private int int_0;

			// Token: 0x0400020A RID: 522
			private Class2113 class2113_0;
		}
	}
}
