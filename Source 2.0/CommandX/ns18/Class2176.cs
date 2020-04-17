using System;
using System.Collections;
using ns16;
using ns22;

namespace ns18
{
	// Token: 0x02000341 RID: 833
	public sealed class Class2176 : Class2059
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		public Class2176()
		{
			this.method_10();
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00077608 File Offset: 0x00075808
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "version");
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00077628 File Offset: 0x00075828
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "version", int_0)));
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00077654 File Offset: 0x00075854
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "updateSequence");
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00077674 File Offset: 0x00075874
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "updateSequence", int_0)));
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00085180 File Offset: 0x00083380
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Service");
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000851A0 File Offset: 0x000833A0
		public Class2170 method_7(int int_0)
		{
			return new Class2170(base.method_1(Class2059.Enum155.const_1, "", "Service", int_0));
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000851C8 File Offset: 0x000833C8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Capability");
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000851E8 File Offset: 0x000833E8
		public Class2140 method_9(int int_0)
		{
			return new Class2140(base.method_1(Class2059.Enum155.const_1, "", "Capability", int_0));
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0000E1E6 File Offset: 0x0000C3E6
		private void method_10()
		{
			this.class1931_0.method_0(this);
			this.class1933_0.method_0(this);
			this.class1935_0.method_0(this);
			this.class1937_0.method_0(this);
		}

		// Token: 0x04000815 RID: 2069
		public Class2176.Class1931 class1931_0 = new Class2176.Class1931();

		// Token: 0x04000816 RID: 2070
		public Class2176.Class1933 class1933_0 = new Class2176.Class1933();

		// Token: 0x04000817 RID: 2071
		public Class2176.Class1935 class1935_0 = new Class2176.Class1935();

		// Token: 0x04000818 RID: 2072
		public Class2176.Class1937 class1937_0 = new Class2176.Class1937();

		// Token: 0x02000342 RID: 834
		public sealed class Class1931 : IEnumerable
		{
			// Token: 0x0600139D RID: 5021 RVA: 0x0000E218 File Offset: 0x0000C418
			public void method_0(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
			}

			// Token: 0x0600139E RID: 5022 RVA: 0x00085210 File Offset: 0x00083410
			public Class2176.Class1932 method_1()
			{
				return new Class2176.Class1932(this.class2176_0);
			}

			// Token: 0x0600139F RID: 5023 RVA: 0x0008522C File Offset: 0x0008342C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000819 RID: 2073
			private Class2176 class2176_0;
		}

		// Token: 0x02000343 RID: 835
		public sealed class Class1932 : IEnumerator
		{
			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00085244 File Offset: 0x00083444
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060013A2 RID: 5026 RVA: 0x0000E221 File Offset: 0x0000C421
			public Class1932(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
				this.int_0 = -1;
			}

			// Token: 0x060013A3 RID: 5027 RVA: 0x0000E237 File Offset: 0x0000C437
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060013A4 RID: 5028 RVA: 0x0000E240 File Offset: 0x0000C440
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2176_0.method_2();
			}

			// Token: 0x060013A5 RID: 5029 RVA: 0x0008525C File Offset: 0x0008345C
			public Class2050 method_0()
			{
				return this.class2176_0.method_3(this.int_0);
			}

			// Token: 0x0400081A RID: 2074
			private int int_0;

			// Token: 0x0400081B RID: 2075
			private Class2176 class2176_0;
		}

		// Token: 0x02000344 RID: 836
		public sealed class Class1933 : IEnumerable
		{
			// Token: 0x060013A6 RID: 5030 RVA: 0x0000E263 File Offset: 0x0000C463
			public void method_0(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
			}

			// Token: 0x060013A7 RID: 5031 RVA: 0x0008527C File Offset: 0x0008347C
			public Class2176.Class1934 method_1()
			{
				return new Class2176.Class1934(this.class2176_0);
			}

			// Token: 0x060013A8 RID: 5032 RVA: 0x00085298 File Offset: 0x00083498
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400081C RID: 2076
			private Class2176 class2176_0;
		}

		// Token: 0x02000345 RID: 837
		public sealed class Class1934 : IEnumerator
		{
			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060013AA RID: 5034 RVA: 0x000852B0 File Offset: 0x000834B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060013AB RID: 5035 RVA: 0x0000E26C File Offset: 0x0000C46C
			public Class1934(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
				this.int_0 = -1;
			}

			// Token: 0x060013AC RID: 5036 RVA: 0x0000E282 File Offset: 0x0000C482
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060013AD RID: 5037 RVA: 0x0000E28B File Offset: 0x0000C48B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2176_0.method_4();
			}

			// Token: 0x060013AE RID: 5038 RVA: 0x000852C8 File Offset: 0x000834C8
			public Class2050 method_0()
			{
				return this.class2176_0.method_5(this.int_0);
			}

			// Token: 0x0400081D RID: 2077
			private int int_0;

			// Token: 0x0400081E RID: 2078
			private Class2176 class2176_0;
		}

		// Token: 0x02000346 RID: 838
		public sealed class Class1935 : IEnumerable
		{
			// Token: 0x060013AF RID: 5039 RVA: 0x0000E2AE File Offset: 0x0000C4AE
			public void method_0(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
			}

			// Token: 0x060013B0 RID: 5040 RVA: 0x000852E8 File Offset: 0x000834E8
			public Class2176.Class1936 method_1()
			{
				return new Class2176.Class1936(this.class2176_0);
			}

			// Token: 0x060013B1 RID: 5041 RVA: 0x00085304 File Offset: 0x00083504
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400081F RID: 2079
			private Class2176 class2176_0;
		}

		// Token: 0x02000347 RID: 839
		public sealed class Class1936 : IEnumerator
		{
			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0008531C File Offset: 0x0008351C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060013B4 RID: 5044 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
			public Class1936(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
				this.int_0 = -1;
			}

			// Token: 0x060013B5 RID: 5045 RVA: 0x0000E2CD File Offset: 0x0000C4CD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060013B6 RID: 5046 RVA: 0x0000E2D6 File Offset: 0x0000C4D6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2176_0.method_6();
			}

			// Token: 0x060013B7 RID: 5047 RVA: 0x00085334 File Offset: 0x00083534
			public Class2170 method_0()
			{
				return this.class2176_0.method_7(this.int_0);
			}

			// Token: 0x04000820 RID: 2080
			private int int_0;

			// Token: 0x04000821 RID: 2081
			private Class2176 class2176_0;
		}

		// Token: 0x02000348 RID: 840
		public sealed class Class1937 : IEnumerable
		{
			// Token: 0x060013B8 RID: 5048 RVA: 0x0000E2F9 File Offset: 0x0000C4F9
			public void method_0(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
			}

			// Token: 0x060013B9 RID: 5049 RVA: 0x00085354 File Offset: 0x00083554
			public Class2176.Class1938 method_1()
			{
				return new Class2176.Class1938(this.class2176_0);
			}

			// Token: 0x060013BA RID: 5050 RVA: 0x00085370 File Offset: 0x00083570
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000822 RID: 2082
			private Class2176 class2176_0;
		}

		// Token: 0x02000349 RID: 841
		public sealed class Class1938 : IEnumerator
		{
			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060013BC RID: 5052 RVA: 0x00085388 File Offset: 0x00083588
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060013BD RID: 5053 RVA: 0x0000E302 File Offset: 0x0000C502
			public Class1938(Class2176 class2176_1)
			{
				this.class2176_0 = class2176_1;
				this.int_0 = -1;
			}

			// Token: 0x060013BE RID: 5054 RVA: 0x0000E318 File Offset: 0x0000C518
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060013BF RID: 5055 RVA: 0x0000E321 File Offset: 0x0000C521
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2176_0.method_8();
			}

			// Token: 0x060013C0 RID: 5056 RVA: 0x000853A0 File Offset: 0x000835A0
			public Class2140 method_0()
			{
				return this.class2176_0.method_9(this.int_0);
			}

			// Token: 0x04000823 RID: 2083
			private int int_0;

			// Token: 0x04000824 RID: 2084
			private Class2176 class2176_0;
		}
	}
}
