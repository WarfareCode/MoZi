using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x020001DA RID: 474
	public sealed class Class2138 : Class2059
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00009E11 File Offset: 0x00008011
		public Class2138()
		{
			this.method_6();
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00009E35 File Offset: 0x00008035
		public Class2138(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "name");
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0005B4E4 File Offset: 0x000596E4
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "name", int_0)));
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00009E5A File Offset: 0x0000805A
		private void method_6()
		{
			this.class1665_0.method_0(this);
			this.class1667_0.method_0(this);
		}

		// Token: 0x040004F0 RID: 1264
		public Class2138.Class1665 class1665_0 = new Class2138.Class1665();

		// Token: 0x040004F1 RID: 1265
		public Class2138.Class1667 class1667_0 = new Class2138.Class1667();

		// Token: 0x020001DB RID: 475
		public sealed class Class1665 : IEnumerable
		{
			// Token: 0x06000B3D RID: 2877 RVA: 0x00009E74 File Offset: 0x00008074
			public void method_0(Class2138 class2138_1)
			{
				this.class2138_0 = class2138_1;
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x00077B28 File Offset: 0x00075D28
			public Class2138.Class1666 method_1()
			{
				return new Class2138.Class1666(this.class2138_0);
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00077B44 File Offset: 0x00075D44
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004F2 RID: 1266
			private Class2138 class2138_0;
		}

		// Token: 0x020001DC RID: 476
		public sealed class Class1666 : IEnumerator
		{
			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00077B5C File Offset: 0x00075D5C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B42 RID: 2882 RVA: 0x00009E7D File Offset: 0x0000807D
			public Class1666(Class2138 class2138_1)
			{
				this.class2138_0 = class2138_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x00009E93 File Offset: 0x00008093
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B44 RID: 2884 RVA: 0x00009E9C File Offset: 0x0000809C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2138_0.method_2();
			}

			// Token: 0x06000B45 RID: 2885 RVA: 0x00077B74 File Offset: 0x00075D74
			public Class2050 method_0()
			{
				return this.class2138_0.method_3(this.int_0);
			}

			// Token: 0x040004F3 RID: 1267
			private int int_0;

			// Token: 0x040004F4 RID: 1268
			private Class2138 class2138_0;
		}

		// Token: 0x020001DD RID: 477
		public sealed class Class1667 : IEnumerable
		{
			// Token: 0x06000B46 RID: 2886 RVA: 0x00009EBF File Offset: 0x000080BF
			public void method_0(Class2138 class2138_1)
			{
				this.class2138_0 = class2138_1;
			}

			// Token: 0x06000B47 RID: 2887 RVA: 0x00077B94 File Offset: 0x00075D94
			public Class2138.Class1668 method_1()
			{
				return new Class2138.Class1668(this.class2138_0);
			}

			// Token: 0x06000B48 RID: 2888 RVA: 0x00077BB0 File Offset: 0x00075DB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004F5 RID: 1269
			private Class2138 class2138_0;
		}

		// Token: 0x020001DE RID: 478
		public sealed class Class1668 : IEnumerator
		{
			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00077BC8 File Offset: 0x00075DC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B4B RID: 2891 RVA: 0x00009EC8 File Offset: 0x000080C8
			public Class1668(Class2138 class2138_1)
			{
				this.class2138_0 = class2138_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B4C RID: 2892 RVA: 0x00009EDE File Offset: 0x000080DE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x00009EE7 File Offset: 0x000080E7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2138_0.method_4();
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x00077BE0 File Offset: 0x00075DE0
			public Class2165 method_0()
			{
				return this.class2138_0.method_5(this.int_0);
			}

			// Token: 0x040004F6 RID: 1270
			private int int_0;

			// Token: 0x040004F7 RID: 1271
			private Class2138 class2138_0;
		}
	}
}
