using System;
using System.Collections;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x020008CB RID: 2251
	public sealed class Class2095 : Class2059
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x0001D5F6 File Offset: 0x0001B7F6
		public Class2095()
		{
			this.method_8();
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0011F098 File Offset: 0x0011D298
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Red");
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0011F0B8 File Offset: 0x0011D2B8
		public Class2016 method_3(int int_0)
		{
			return new Class2016(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Red", int_0)));
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x0011F0E4 File Offset: 0x0011D2E4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Green");
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0011F104 File Offset: 0x0011D304
		public Class2013 method_5(int int_0)
		{
			return new Class2013(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Green", int_0)));
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0011F130 File Offset: 0x0011D330
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Blue");
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x0011F150 File Offset: 0x0011D350
		public Class2011 method_7(int int_0)
		{
			return new Class2011(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Blue", int_0)));
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0001D625 File Offset: 0x0001B825
		private void method_8()
		{
			this.class1227_0.method_0(this);
			this.class1229_0.method_0(this);
			this.class1231_0.method_0(this);
		}

		// Token: 0x04001962 RID: 6498
		public Class2095.Class1227 class1227_0 = new Class2095.Class1227();

		// Token: 0x04001963 RID: 6499
		public Class2095.Class1229 class1229_0 = new Class2095.Class1229();

		// Token: 0x04001964 RID: 6500
		public Class2095.Class1231 class1231_0 = new Class2095.Class1231();

		// Token: 0x020008CC RID: 2252
		public sealed class Class1227 : IEnumerable
		{
			// Token: 0x0600374B RID: 14155 RVA: 0x0001D64B File Offset: 0x0001B84B
			public void method_0(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
			}

			// Token: 0x0600374C RID: 14156 RVA: 0x0011F17C File Offset: 0x0011D37C
			public Class2095.Class1228 method_1()
			{
				return new Class2095.Class1228(this.class2095_0);
			}

			// Token: 0x0600374D RID: 14157 RVA: 0x0011F198 File Offset: 0x0011D398
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001965 RID: 6501
			private Class2095 class2095_0;
		}

		// Token: 0x020008CD RID: 2253
		public sealed class Class1228 : IEnumerator
		{
			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x0600374F RID: 14159 RVA: 0x0011F1B0 File Offset: 0x0011D3B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003750 RID: 14160 RVA: 0x0001D654 File Offset: 0x0001B854
			public Class1228(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
				this.int_0 = -1;
			}

			// Token: 0x06003751 RID: 14161 RVA: 0x0001D66A File Offset: 0x0001B86A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003752 RID: 14162 RVA: 0x0001D673 File Offset: 0x0001B873
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2095_0.method_2();
			}

			// Token: 0x06003753 RID: 14163 RVA: 0x0011F1C8 File Offset: 0x0011D3C8
			public Class2016 method_0()
			{
				return this.class2095_0.method_3(this.int_0);
			}

			// Token: 0x04001966 RID: 6502
			private int int_0;

			// Token: 0x04001967 RID: 6503
			private Class2095 class2095_0;
		}

		// Token: 0x020008CE RID: 2254
		public sealed class Class1229 : IEnumerable
		{
			// Token: 0x06003754 RID: 14164 RVA: 0x0001D696 File Offset: 0x0001B896
			public void method_0(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
			}

			// Token: 0x06003755 RID: 14165 RVA: 0x0011F1E8 File Offset: 0x0011D3E8
			public Class2095.Class1230 method_1()
			{
				return new Class2095.Class1230(this.class2095_0);
			}

			// Token: 0x06003756 RID: 14166 RVA: 0x0011F204 File Offset: 0x0011D404
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001968 RID: 6504
			private Class2095 class2095_0;
		}

		// Token: 0x020008CF RID: 2255
		public sealed class Class1230 : IEnumerator
		{
			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06003758 RID: 14168 RVA: 0x0011F21C File Offset: 0x0011D41C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003759 RID: 14169 RVA: 0x0001D69F File Offset: 0x0001B89F
			public Class1230(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
				this.int_0 = -1;
			}

			// Token: 0x0600375A RID: 14170 RVA: 0x0001D6B5 File Offset: 0x0001B8B5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600375B RID: 14171 RVA: 0x0001D6BE File Offset: 0x0001B8BE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2095_0.method_4();
			}

			// Token: 0x0600375C RID: 14172 RVA: 0x0011F234 File Offset: 0x0011D434
			public Class2013 method_0()
			{
				return this.class2095_0.method_5(this.int_0);
			}

			// Token: 0x04001969 RID: 6505
			private int int_0;

			// Token: 0x0400196A RID: 6506
			private Class2095 class2095_0;
		}

		// Token: 0x020008D0 RID: 2256
		public sealed class Class1231 : IEnumerable
		{
			// Token: 0x0600375D RID: 14173 RVA: 0x0001D6E1 File Offset: 0x0001B8E1
			public void method_0(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
			}

			// Token: 0x0600375E RID: 14174 RVA: 0x0011F254 File Offset: 0x0011D454
			public Class2095.Class1232 method_1()
			{
				return new Class2095.Class1232(this.class2095_0);
			}

			// Token: 0x0600375F RID: 14175 RVA: 0x0011F270 File Offset: 0x0011D470
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400196B RID: 6507
			private Class2095 class2095_0;
		}

		// Token: 0x020008D1 RID: 2257
		public sealed class Class1232 : IEnumerator
		{
			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06003761 RID: 14177 RVA: 0x0011F288 File Offset: 0x0011D488
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003762 RID: 14178 RVA: 0x0001D6EA File Offset: 0x0001B8EA
			public Class1232(Class2095 class2095_1)
			{
				this.class2095_0 = class2095_1;
				this.int_0 = -1;
			}

			// Token: 0x06003763 RID: 14179 RVA: 0x0001D700 File Offset: 0x0001B900
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003764 RID: 14180 RVA: 0x0001D709 File Offset: 0x0001B909
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2095_0.method_6();
			}

			// Token: 0x06003765 RID: 14181 RVA: 0x0011F2A0 File Offset: 0x0011D4A0
			public Class2011 method_0()
			{
				return this.class2095_0.method_7(this.int_0);
			}

			// Token: 0x0400196C RID: 6508
			private int int_0;

			// Token: 0x0400196D RID: 6509
			private Class2095 class2095_0;
		}
	}
}
