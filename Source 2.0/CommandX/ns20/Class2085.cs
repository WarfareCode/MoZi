using System;
using System.Collections;
using ns16;
using ns21;

namespace ns20
{
	// Token: 0x02000820 RID: 2080
	public sealed class Class2085 : Class2059
	{
		// Token: 0x0600334A RID: 13130 RVA: 0x0001B6F6 File Offset: 0x000198F6
		public Class2085()
		{
			this.method_4();
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00119890 File Offset: 0x00117A90
		public Class2044 method_3(int int_0)
		{
			return new Class2044(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x0001B70F File Offset: 0x0001990F
		private void method_4()
		{
			this.class1091_0.method_0(this);
		}

		// Token: 0x040017D0 RID: 6096
		public Class2085.Class1091 class1091_0 = new Class2085.Class1091();

		// Token: 0x02000821 RID: 2081
		public sealed class Class1091 : IEnumerable
		{
			// Token: 0x0600334E RID: 13134 RVA: 0x0001B71D File Offset: 0x0001991D
			public void method_0(Class2085 class2085_1)
			{
				this.class2085_0 = class2085_1;
			}

			// Token: 0x0600334F RID: 13135 RVA: 0x001198BC File Offset: 0x00117ABC
			public Class2085.Class1092 method_1()
			{
				return new Class2085.Class1092(this.class2085_0);
			}

			// Token: 0x06003350 RID: 13136 RVA: 0x001198D8 File Offset: 0x00117AD8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017D1 RID: 6097
			private Class2085 class2085_0;
		}

		// Token: 0x02000822 RID: 2082
		public sealed class Class1092 : IEnumerator
		{
			// Token: 0x17000381 RID: 897
			// (get) Token: 0x06003352 RID: 13138 RVA: 0x001198F0 File Offset: 0x00117AF0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003353 RID: 13139 RVA: 0x0001B726 File Offset: 0x00019926
			public Class1092(Class2085 class2085_1)
			{
				this.class2085_0 = class2085_1;
				this.int_0 = -1;
			}

			// Token: 0x06003354 RID: 13140 RVA: 0x0001B73C File Offset: 0x0001993C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003355 RID: 13141 RVA: 0x0001B745 File Offset: 0x00019945
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2085_0.method_2();
			}

			// Token: 0x06003356 RID: 13142 RVA: 0x00119908 File Offset: 0x00117B08
			public Class2044 method_0()
			{
				return this.class2085_0.method_3(this.int_0);
			}

			// Token: 0x040017D2 RID: 6098
			private int int_0;

			// Token: 0x040017D3 RID: 6099
			private Class2085 class2085_0;
		}
	}
}
