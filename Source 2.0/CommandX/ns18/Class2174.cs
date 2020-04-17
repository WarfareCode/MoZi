using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x02000336 RID: 822
	public sealed class Class2174 : Class2059
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0000DFA1 File Offset: 0x0000C1A1
		public Class2174()
		{
			this.method_10();
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0000DFDB File Offset: 0x0000C1DB
		public Class2174(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00084EA0 File Offset: 0x000830A0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "SupportSLD");
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00084EC0 File Offset: 0x000830C0
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "SupportSLD", int_0)));
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00084EEC File Offset: 0x000830EC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "UserLayer");
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00084F0C File Offset: 0x0008310C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "UserLayer", int_0)));
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00084F38 File Offset: 0x00083138
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "UserStyle");
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00084F58 File Offset: 0x00083158
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "UserStyle", int_0)));
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00084F84 File Offset: 0x00083184
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "RemoteWFS");
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00084FA4 File Offset: 0x000831A4
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "RemoteWFS", int_0)));
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0000E016 File Offset: 0x0000C216
		private void method_10()
		{
			this.class1923_0.method_0(this);
			this.class1925_0.method_0(this);
			this.class1927_0.method_0(this);
			this.class1929_0.method_0(this);
		}

		// Token: 0x04000805 RID: 2053
		public Class2174.Class1923 class1923_0 = new Class2174.Class1923();

		// Token: 0x04000806 RID: 2054
		public Class2174.Class1925 class1925_0 = new Class2174.Class1925();

		// Token: 0x04000807 RID: 2055
		public Class2174.Class1927 class1927_0 = new Class2174.Class1927();

		// Token: 0x04000808 RID: 2056
		public Class2174.Class1929 class1929_0 = new Class2174.Class1929();

		// Token: 0x02000337 RID: 823
		public sealed class Class1923 : IEnumerable
		{
			// Token: 0x06001369 RID: 4969 RVA: 0x0000E048 File Offset: 0x0000C248
			public void method_0(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
			}

			// Token: 0x0600136A RID: 4970 RVA: 0x00084FD0 File Offset: 0x000831D0
			public Class2174.Class1924 method_1()
			{
				return new Class2174.Class1924(this.class2174_0);
			}

			// Token: 0x0600136B RID: 4971 RVA: 0x00084FEC File Offset: 0x000831EC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000809 RID: 2057
			private Class2174 class2174_0;
		}

		// Token: 0x02000338 RID: 824
		public sealed class Class1924 : IEnumerator
		{
			// Token: 0x170001AC RID: 428
			// (get) Token: 0x0600136D RID: 4973 RVA: 0x00085004 File Offset: 0x00083204
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600136E RID: 4974 RVA: 0x0000E051 File Offset: 0x0000C251
			public Class1924(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
				this.int_0 = -1;
			}

			// Token: 0x0600136F RID: 4975 RVA: 0x0000E067 File Offset: 0x0000C267
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001370 RID: 4976 RVA: 0x0000E070 File Offset: 0x0000C270
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2174_0.method_2();
			}

			// Token: 0x06001371 RID: 4977 RVA: 0x0008501C File Offset: 0x0008321C
			public Class2050 method_0()
			{
				return this.class2174_0.method_3(this.int_0);
			}

			// Token: 0x0400080A RID: 2058
			private int int_0;

			// Token: 0x0400080B RID: 2059
			private Class2174 class2174_0;
		}

		// Token: 0x02000339 RID: 825
		public sealed class Class1925 : IEnumerable
		{
			// Token: 0x06001372 RID: 4978 RVA: 0x0000E093 File Offset: 0x0000C293
			public void method_0(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
			}

			// Token: 0x06001373 RID: 4979 RVA: 0x0008503C File Offset: 0x0008323C
			public Class2174.Class1926 method_1()
			{
				return new Class2174.Class1926(this.class2174_0);
			}

			// Token: 0x06001374 RID: 4980 RVA: 0x00085058 File Offset: 0x00083258
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400080C RID: 2060
			private Class2174 class2174_0;
		}

		// Token: 0x0200033A RID: 826
		public sealed class Class1926 : IEnumerator
		{
			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06001376 RID: 4982 RVA: 0x00085070 File Offset: 0x00083270
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001377 RID: 4983 RVA: 0x0000E09C File Offset: 0x0000C29C
			public Class1926(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
				this.int_0 = -1;
			}

			// Token: 0x06001378 RID: 4984 RVA: 0x0000E0B2 File Offset: 0x0000C2B2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001379 RID: 4985 RVA: 0x0000E0BB File Offset: 0x0000C2BB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2174_0.method_4();
			}

			// Token: 0x0600137A RID: 4986 RVA: 0x00085088 File Offset: 0x00083288
			public Class2050 method_0()
			{
				return this.class2174_0.method_5(this.int_0);
			}

			// Token: 0x0400080D RID: 2061
			private int int_0;

			// Token: 0x0400080E RID: 2062
			private Class2174 class2174_0;
		}

		// Token: 0x0200033B RID: 827
		public sealed class Class1927 : IEnumerable
		{
			// Token: 0x0600137B RID: 4987 RVA: 0x0000E0DE File Offset: 0x0000C2DE
			public void method_0(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
			}

			// Token: 0x0600137C RID: 4988 RVA: 0x000850A8 File Offset: 0x000832A8
			public Class2174.Class1928 method_1()
			{
				return new Class2174.Class1928(this.class2174_0);
			}

			// Token: 0x0600137D RID: 4989 RVA: 0x000850C4 File Offset: 0x000832C4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400080F RID: 2063
			private Class2174 class2174_0;
		}

		// Token: 0x0200033C RID: 828
		public sealed class Class1928 : IEnumerator
		{
			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600137F RID: 4991 RVA: 0x000850DC File Offset: 0x000832DC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001380 RID: 4992 RVA: 0x0000E0E7 File Offset: 0x0000C2E7
			public Class1928(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
				this.int_0 = -1;
			}

			// Token: 0x06001381 RID: 4993 RVA: 0x0000E0FD File Offset: 0x0000C2FD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001382 RID: 4994 RVA: 0x0000E106 File Offset: 0x0000C306
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2174_0.method_6();
			}

			// Token: 0x06001383 RID: 4995 RVA: 0x000850F4 File Offset: 0x000832F4
			public Class2050 method_0()
			{
				return this.class2174_0.method_7(this.int_0);
			}

			// Token: 0x04000810 RID: 2064
			private int int_0;

			// Token: 0x04000811 RID: 2065
			private Class2174 class2174_0;
		}

		// Token: 0x0200033D RID: 829
		public sealed class Class1929 : IEnumerable
		{
			// Token: 0x06001384 RID: 4996 RVA: 0x0000E129 File Offset: 0x0000C329
			public void method_0(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
			}

			// Token: 0x06001385 RID: 4997 RVA: 0x00085114 File Offset: 0x00083314
			public Class2174.Class1930 method_1()
			{
				return new Class2174.Class1930(this.class2174_0);
			}

			// Token: 0x06001386 RID: 4998 RVA: 0x00085130 File Offset: 0x00083330
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000812 RID: 2066
			private Class2174 class2174_0;
		}

		// Token: 0x0200033E RID: 830
		public sealed class Class1930 : IEnumerator
		{
			// Token: 0x170001AF RID: 431
			// (get) Token: 0x06001388 RID: 5000 RVA: 0x00085148 File Offset: 0x00083348
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001389 RID: 5001 RVA: 0x0000E132 File Offset: 0x0000C332
			public Class1930(Class2174 class2174_1)
			{
				this.class2174_0 = class2174_1;
				this.int_0 = -1;
			}

			// Token: 0x0600138A RID: 5002 RVA: 0x0000E148 File Offset: 0x0000C348
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600138B RID: 5003 RVA: 0x0000E151 File Offset: 0x0000C351
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2174_0.method_8();
			}

			// Token: 0x0600138C RID: 5004 RVA: 0x00085160 File Offset: 0x00083360
			public Class2050 method_0()
			{
				return this.class2174_0.method_9(this.int_0);
			}

			// Token: 0x04000813 RID: 2067
			private int int_0;

			// Token: 0x04000814 RID: 2068
			private Class2174 class2174_0;
		}
	}
}
