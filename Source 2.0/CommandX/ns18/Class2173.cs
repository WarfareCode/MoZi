using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x0200032F RID: 815
	public sealed class Class2173 : Class2059
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x0000DE15 File Offset: 0x0000C015
		public Class2173()
		{
			this.method_6();
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0000DE39 File Offset: 0x0000C039
		public Class2173(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000799EC File Offset: 0x00077BEC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Format");
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00079A0C File Offset: 0x00077C0C
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Format", int_0)));
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_5(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0000DE5E File Offset: 0x0000C05E
		private void method_6()
		{
			this.class1919_0.method_0(this);
			this.class1921_0.method_0(this);
		}

		// Token: 0x040007FA RID: 2042
		public Class2173.Class1919 class1919_0 = new Class2173.Class1919();

		// Token: 0x040007FB RID: 2043
		public Class2173.Class1921 class1921_0 = new Class2173.Class1921();

		// Token: 0x02000330 RID: 816
		public sealed class Class1919 : IEnumerable
		{
			// Token: 0x0600133E RID: 4926 RVA: 0x0000DE78 File Offset: 0x0000C078
			public void method_0(Class2173 class2173_1)
			{
				this.class2173_0 = class2173_1;
			}

			// Token: 0x0600133F RID: 4927 RVA: 0x00084BFC File Offset: 0x00082DFC
			public Class2173.Class1920 method_1()
			{
				return new Class2173.Class1920(this.class2173_0);
			}

			// Token: 0x06001340 RID: 4928 RVA: 0x00084C18 File Offset: 0x00082E18
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007FC RID: 2044
			private Class2173 class2173_0;
		}

		// Token: 0x02000331 RID: 817
		public sealed class Class1920 : IEnumerator
		{
			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06001342 RID: 4930 RVA: 0x00084C30 File Offset: 0x00082E30
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001343 RID: 4931 RVA: 0x0000DE81 File Offset: 0x0000C081
			public Class1920(Class2173 class2173_1)
			{
				this.class2173_0 = class2173_1;
				this.int_0 = -1;
			}

			// Token: 0x06001344 RID: 4932 RVA: 0x0000DE97 File Offset: 0x0000C097
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001345 RID: 4933 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2173_0.method_2();
			}

			// Token: 0x06001346 RID: 4934 RVA: 0x00084C48 File Offset: 0x00082E48
			public Class2050 method_0()
			{
				return this.class2173_0.method_3(this.int_0);
			}

			// Token: 0x040007FD RID: 2045
			private int int_0;

			// Token: 0x040007FE RID: 2046
			private Class2173 class2173_0;
		}

		// Token: 0x02000332 RID: 818
		public sealed class Class1921 : IEnumerable
		{
			// Token: 0x06001347 RID: 4935 RVA: 0x0000DEC3 File Offset: 0x0000C0C3
			public void method_0(Class2173 class2173_1)
			{
				this.class2173_0 = class2173_1;
			}

			// Token: 0x06001348 RID: 4936 RVA: 0x00084C68 File Offset: 0x00082E68
			public Class2173.Class1922 method_1()
			{
				return new Class2173.Class1922(this.class2173_0);
			}

			// Token: 0x06001349 RID: 4937 RVA: 0x00084C84 File Offset: 0x00082E84
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040007FF RID: 2047
			private Class2173 class2173_0;
		}

		// Token: 0x02000333 RID: 819
		public sealed class Class1922 : IEnumerator
		{
			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600134B RID: 4939 RVA: 0x00084C9C File Offset: 0x00082E9C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600134C RID: 4940 RVA: 0x0000DECC File Offset: 0x0000C0CC
			public Class1922(Class2173 class2173_1)
			{
				this.class2173_0 = class2173_1;
				this.int_0 = -1;
			}

			// Token: 0x0600134D RID: 4941 RVA: 0x0000DEE2 File Offset: 0x0000C0E2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600134E RID: 4942 RVA: 0x0000DEEB File Offset: 0x0000C0EB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2173_0.method_4();
			}

			// Token: 0x0600134F RID: 4943 RVA: 0x00084CB4 File Offset: 0x00082EB4
			public Class2165 method_0()
			{
				return this.class2173_0.method_5(this.int_0);
			}

			// Token: 0x04000800 RID: 2048
			private int int_0;

			// Token: 0x04000801 RID: 2049
			private Class2173 class2173_0;
		}
	}
}
