using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000B9 RID: 185
	public sealed class Class2112 : Class2059
	{
		// Token: 0x060003AA RID: 938 RVA: 0x000062B5 File Offset: 0x000044B5
		public Class2112()
		{
			this.method_6();
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000062D9 File Offset: 0x000044D9
		public Class2112(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0005FA1C File Offset: 0x0005DC1C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPerson");
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0005FA3C File Offset: 0x0005DC3C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactPerson", int_0)));
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0005FA68 File Offset: 0x0005DC68
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactOrganization");
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0005FA88 File Offset: 0x0005DC88
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "ContactOrganization", int_0)));
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000062FE File Offset: 0x000044FE
		private void method_6()
		{
			this.class1463_0.method_0(this);
			this.class1465_0.method_0(this);
		}

		// Token: 0x040001FB RID: 507
		public Class2112.Class1463 class1463_0 = new Class2112.Class1463();

		// Token: 0x040001FC RID: 508
		public Class2112.Class1465 class1465_0 = new Class2112.Class1465();

		// Token: 0x020000BA RID: 186
		public sealed class Class1463 : IEnumerable
		{
			// Token: 0x060003B1 RID: 945 RVA: 0x00006318 File Offset: 0x00004518
			public void method_0(Class2112 class2112_1)
			{
				this.class2112_0 = class2112_1;
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0005FAB4 File Offset: 0x0005DCB4
			public Class2112.Class1464 method_1()
			{
				return new Class2112.Class1464(this.class2112_0);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x0005FAD0 File Offset: 0x0005DCD0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001FD RID: 509
			private Class2112 class2112_0;
		}

		// Token: 0x020000BB RID: 187
		public sealed class Class1464 : IEnumerator
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x0005FAE8 File Offset: 0x0005DCE8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00006321 File Offset: 0x00004521
			public Class1464(Class2112 class2112_1)
			{
				this.class2112_0 = class2112_1;
				this.int_0 = -1;
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00006337 File Offset: 0x00004537
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00006340 File Offset: 0x00004540
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2112_0.method_2();
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0005FB00 File Offset: 0x0005DD00
			public Class2050 method_0()
			{
				return this.class2112_0.method_3(this.int_0);
			}

			// Token: 0x040001FE RID: 510
			private int int_0;

			// Token: 0x040001FF RID: 511
			private Class2112 class2112_0;
		}

		// Token: 0x020000BC RID: 188
		public sealed class Class1465 : IEnumerable
		{
			// Token: 0x060003BA RID: 954 RVA: 0x00006363 File Offset: 0x00004563
			public void method_0(Class2112 class2112_1)
			{
				this.class2112_0 = class2112_1;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0005FB20 File Offset: 0x0005DD20
			public Class2112.Class1466 method_1()
			{
				return new Class2112.Class1466(this.class2112_0);
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0005FB3C File Offset: 0x0005DD3C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000200 RID: 512
			private Class2112 class2112_0;
		}

		// Token: 0x020000BD RID: 189
		public sealed class Class1466 : IEnumerator
		{
			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060003BE RID: 958 RVA: 0x0005FB54 File Offset: 0x0005DD54
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000636C File Offset: 0x0000456C
			public Class1466(Class2112 class2112_1)
			{
				this.class2112_0 = class2112_1;
				this.int_0 = -1;
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00006382 File Offset: 0x00004582
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000638B File Offset: 0x0000458B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2112_0.method_4();
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0005FB6C File Offset: 0x0005DD6C
			public Class2050 method_0()
			{
				return this.class2112_0.method_5(this.int_0);
			}

			// Token: 0x04000201 RID: 513
			private int int_0;

			// Token: 0x04000202 RID: 514
			private Class2112 class2112_0;
		}
	}
}
