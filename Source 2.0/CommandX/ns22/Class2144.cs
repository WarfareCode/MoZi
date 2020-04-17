using System;
using System.Collections;
using System.Xml;
using ns16;
using ns18;

namespace ns22
{
	// Token: 0x0200021C RID: 540
	public sealed class Class2144 : Class2059
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x0000A91F File Offset: 0x00008B1F
		public Class2144()
		{
			this.method_6();
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0000A943 File Offset: 0x00008B43
		public Class2144(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0000A968 File Offset: 0x00008B68
		private void method_6()
		{
			this.class1721_0.method_0(this);
			this.class1723_0.method_0(this);
		}

		// Token: 0x04000573 RID: 1395
		public Class2144.Class1721 class1721_0 = new Class2144.Class1721();

		// Token: 0x04000574 RID: 1396
		public Class2144.Class1723 class1723_0 = new Class2144.Class1723();

		// Token: 0x0200021D RID: 541
		public sealed class Class1721 : IEnumerable
		{
			// Token: 0x06000CB0 RID: 3248 RVA: 0x0000A982 File Offset: 0x00008B82
			public void method_0(Class2144 class2144_1)
			{
				this.class2144_0 = class2144_1;
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00079A38 File Offset: 0x00077C38
			public Class2144.Class1722 method_1()
			{
				return new Class2144.Class1722(this.class2144_0);
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00079A54 File Offset: 0x00077C54
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000575 RID: 1397
			private Class2144 class2144_0;
		}

		// Token: 0x0200021E RID: 542
		public sealed class Class1722 : IEnumerator
		{
			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00079A6C File Offset: 0x00077C6C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x0000A98B File Offset: 0x00008B8B
			public Class1722(Class2144 class2144_1)
			{
				this.class2144_0 = class2144_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x0000A9A1 File Offset: 0x00008BA1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x0000A9AA File Offset: 0x00008BAA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2144_0.method_2();
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x00079A84 File Offset: 0x00077C84
			public Class2050 method_0()
			{
				return this.class2144_0.method_3(this.int_0);
			}

			// Token: 0x04000576 RID: 1398
			private int int_0;

			// Token: 0x04000577 RID: 1399
			private Class2144 class2144_0;
		}

		// Token: 0x0200021F RID: 543
		public sealed class Class1723 : IEnumerable
		{
			// Token: 0x06000CB9 RID: 3257 RVA: 0x0000A9CD File Offset: 0x00008BCD
			public void method_0(Class2144 class2144_1)
			{
				this.class2144_0 = class2144_1;
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x00079AA4 File Offset: 0x00077CA4
			public Class2144.Class1724 method_1()
			{
				return new Class2144.Class1724(this.class2144_0);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00079AC0 File Offset: 0x00077CC0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000578 RID: 1400
			private Class2144 class2144_0;
		}

		// Token: 0x02000220 RID: 544
		public sealed class Class1724 : IEnumerator
		{
			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00079AD8 File Offset: 0x00077CD8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x0000A9D6 File Offset: 0x00008BD6
			public Class1724(Class2144 class2144_1)
			{
				this.class2144_0 = class2144_1;
				this.int_0 = -1;
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x0000A9EC File Offset: 0x00008BEC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x0000A9F5 File Offset: 0x00008BF5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2144_0.method_4();
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00079AF0 File Offset: 0x00077CF0
			public Class2165 method_0()
			{
				return this.class2144_0.method_5(this.int_0);
			}

			// Token: 0x04000579 RID: 1401
			private int int_0;

			// Token: 0x0400057A RID: 1402
			private Class2144 class2144_0;
		}
	}
}
