using System;
using System.Collections;
using ns16;

namespace ns21
{
	// Token: 0x02000963 RID: 2403
	public sealed class Class2103 : Class2059
	{
		// Token: 0x06003AFE RID: 15102 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		public Class2103()
		{
			this.method_8();
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x001242BC File Offset: 0x001224BC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "x");
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x001242DC File Offset: 0x001224DC
		public Class2020 method_3(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "x", int_0)));
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00124308 File Offset: 0x00122508
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "y");
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00124328 File Offset: 0x00122528
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "y", int_0)));
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00124354 File Offset: 0x00122554
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "z");
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00124374 File Offset: 0x00122574
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "z", int_0)));
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x0001F4D7 File Offset: 0x0001D6D7
		private void method_8()
		{
			this.class1359_0.method_0(this);
			this.class1361_0.method_0(this);
			this.class1363_0.method_0(this);
		}

		// Token: 0x04001AEA RID: 6890
		public Class2103.Class1359 class1359_0 = new Class2103.Class1359();

		// Token: 0x04001AEB RID: 6891
		public Class2103.Class1361 class1361_0 = new Class2103.Class1361();

		// Token: 0x04001AEC RID: 6892
		public Class2103.Class1363 class1363_0 = new Class2103.Class1363();

		// Token: 0x02000964 RID: 2404
		public sealed class Class1359 : IEnumerable
		{
			// Token: 0x06003B06 RID: 15110 RVA: 0x0001F4FD File Offset: 0x0001D6FD
			public void method_0(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
			}

			// Token: 0x06003B07 RID: 15111 RVA: 0x001243A0 File Offset: 0x001225A0
			public Class2103.Class1360 method_1()
			{
				return new Class2103.Class1360(this.class2103_0);
			}

			// Token: 0x06003B08 RID: 15112 RVA: 0x001243BC File Offset: 0x001225BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AED RID: 6893
			private Class2103 class2103_0;
		}

		// Token: 0x02000965 RID: 2405
		public sealed class Class1360 : IEnumerator
		{
			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x06003B0A RID: 15114 RVA: 0x001243D4 File Offset: 0x001225D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003B0B RID: 15115 RVA: 0x0001F506 File Offset: 0x0001D706
			public Class1360(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
				this.int_0 = -1;
			}

			// Token: 0x06003B0C RID: 15116 RVA: 0x0001F51C File Offset: 0x0001D71C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003B0D RID: 15117 RVA: 0x0001F525 File Offset: 0x0001D725
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2103_0.method_2();
			}

			// Token: 0x06003B0E RID: 15118 RVA: 0x001243EC File Offset: 0x001225EC
			public Class2020 method_0()
			{
				return this.class2103_0.method_3(this.int_0);
			}

			// Token: 0x04001AEE RID: 6894
			private int int_0;

			// Token: 0x04001AEF RID: 6895
			private Class2103 class2103_0;
		}

		// Token: 0x02000966 RID: 2406
		public sealed class Class1361 : IEnumerable
		{
			// Token: 0x06003B0F RID: 15119 RVA: 0x0001F548 File Offset: 0x0001D748
			public void method_0(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
			}

			// Token: 0x06003B10 RID: 15120 RVA: 0x0012440C File Offset: 0x0012260C
			public Class2103.Class1362 method_1()
			{
				return new Class2103.Class1362(this.class2103_0);
			}

			// Token: 0x06003B11 RID: 15121 RVA: 0x00124428 File Offset: 0x00122628
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AF0 RID: 6896
			private Class2103 class2103_0;
		}

		// Token: 0x02000967 RID: 2407
		public sealed class Class1362 : IEnumerator
		{
			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x06003B13 RID: 15123 RVA: 0x00124440 File Offset: 0x00122640
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003B14 RID: 15124 RVA: 0x0001F551 File Offset: 0x0001D751
			public Class1362(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
				this.int_0 = -1;
			}

			// Token: 0x06003B15 RID: 15125 RVA: 0x0001F567 File Offset: 0x0001D767
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003B16 RID: 15126 RVA: 0x0001F570 File Offset: 0x0001D770
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2103_0.method_4();
			}

			// Token: 0x06003B17 RID: 15127 RVA: 0x00124458 File Offset: 0x00122658
			public Class2020 method_0()
			{
				return this.class2103_0.method_5(this.int_0);
			}

			// Token: 0x04001AF1 RID: 6897
			private int int_0;

			// Token: 0x04001AF2 RID: 6898
			private Class2103 class2103_0;
		}

		// Token: 0x02000968 RID: 2408
		public sealed class Class1363 : IEnumerable
		{
			// Token: 0x06003B18 RID: 15128 RVA: 0x0001F593 File Offset: 0x0001D793
			public void method_0(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
			}

			// Token: 0x06003B19 RID: 15129 RVA: 0x00124478 File Offset: 0x00122678
			public Class2103.Class1364 method_1()
			{
				return new Class2103.Class1364(this.class2103_0);
			}

			// Token: 0x06003B1A RID: 15130 RVA: 0x00124494 File Offset: 0x00122694
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AF3 RID: 6899
			private Class2103 class2103_0;
		}

		// Token: 0x02000969 RID: 2409
		public sealed class Class1364 : IEnumerator
		{
			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x06003B1C RID: 15132 RVA: 0x001244AC File Offset: 0x001226AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003B1D RID: 15133 RVA: 0x0001F59C File Offset: 0x0001D79C
			public Class1364(Class2103 class2103_1)
			{
				this.class2103_0 = class2103_1;
				this.int_0 = -1;
			}

			// Token: 0x06003B1E RID: 15134 RVA: 0x0001F5B2 File Offset: 0x0001D7B2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003B1F RID: 15135 RVA: 0x0001F5BB File Offset: 0x0001D7BB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2103_0.method_6();
			}

			// Token: 0x06003B20 RID: 15136 RVA: 0x001244C4 File Offset: 0x001226C4
			public Class2020 method_0()
			{
				return this.class2103_0.method_7(this.int_0);
			}

			// Token: 0x04001AF4 RID: 6900
			private int int_0;

			// Token: 0x04001AF5 RID: 6901
			private Class2103 class2103_0;
		}
	}
}
