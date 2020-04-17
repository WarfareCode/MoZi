using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x02000862 RID: 2146
	public sealed class Class2089 : Class2059
	{
		// Token: 0x060034FF RID: 13567 RVA: 0x0001C5DE File Offset: 0x0001A7DE
		public Class2089()
		{
			this.method_8();
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0011C664 File Offset: 0x0011A864
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationX");
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0011C684 File Offset: 0x0011A884
		public Class2020 method_3(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationX", int_0)));
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0011C6B0 File Offset: 0x0011A8B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationY");
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationY", int_0)));
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x0011C6FC File Offset: 0x0011A8FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationZ");
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x0011C71C File Offset: 0x0011A91C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationZ", int_0)));
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0001C60D File Offset: 0x0001A80D
		private void method_8()
		{
			this.class1139_0.method_0(this);
			this.class1141_0.method_0(this);
			this.class1143_0.method_0(this);
		}

		// Token: 0x0400188D RID: 6285
		public Class2089.Class1139 class1139_0 = new Class2089.Class1139();

		// Token: 0x0400188E RID: 6286
		public Class2089.Class1141 class1141_0 = new Class2089.Class1141();

		// Token: 0x0400188F RID: 6287
		public Class2089.Class1143 class1143_0 = new Class2089.Class1143();

		// Token: 0x02000863 RID: 2147
		public sealed class Class1139 : IEnumerable
		{
			// Token: 0x06003507 RID: 13575 RVA: 0x0001C633 File Offset: 0x0001A833
			public void method_0(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
			}

			// Token: 0x06003508 RID: 13576 RVA: 0x0011C748 File Offset: 0x0011A948
			public Class2089.Class1140 method_1()
			{
				return new Class2089.Class1140(this.class2089_0);
			}

			// Token: 0x06003509 RID: 13577 RVA: 0x0011C764 File Offset: 0x0011A964
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001890 RID: 6288
			private Class2089 class2089_0;
		}

		// Token: 0x02000864 RID: 2148
		public sealed class Class1140 : IEnumerator
		{
			// Token: 0x170003BD RID: 957
			// (get) Token: 0x0600350B RID: 13579 RVA: 0x0011C77C File Offset: 0x0011A97C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600350C RID: 13580 RVA: 0x0001C63C File Offset: 0x0001A83C
			public Class1140(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
				this.int_0 = -1;
			}

			// Token: 0x0600350D RID: 13581 RVA: 0x0001C652 File Offset: 0x0001A852
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600350E RID: 13582 RVA: 0x0001C65B File Offset: 0x0001A85B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2089_0.method_2();
			}

			// Token: 0x0600350F RID: 13583 RVA: 0x0011C794 File Offset: 0x0011A994
			public Class2020 method_0()
			{
				return this.class2089_0.method_3(this.int_0);
			}

			// Token: 0x04001891 RID: 6289
			private int int_0;

			// Token: 0x04001892 RID: 6290
			private Class2089 class2089_0;
		}

		// Token: 0x02000865 RID: 2149
		public sealed class Class1141 : IEnumerable
		{
			// Token: 0x06003510 RID: 13584 RVA: 0x0001C67E File Offset: 0x0001A87E
			public void method_0(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
			}

			// Token: 0x06003511 RID: 13585 RVA: 0x0011C7B4 File Offset: 0x0011A9B4
			public Class2089.Class1142 method_1()
			{
				return new Class2089.Class1142(this.class2089_0);
			}

			// Token: 0x06003512 RID: 13586 RVA: 0x0011C7D0 File Offset: 0x0011A9D0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001893 RID: 6291
			private Class2089 class2089_0;
		}

		// Token: 0x02000866 RID: 2150
		public sealed class Class1142 : IEnumerator
		{
			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06003514 RID: 13588 RVA: 0x0011C7E8 File Offset: 0x0011A9E8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003515 RID: 13589 RVA: 0x0001C687 File Offset: 0x0001A887
			public Class1142(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
				this.int_0 = -1;
			}

			// Token: 0x06003516 RID: 13590 RVA: 0x0001C69D File Offset: 0x0001A89D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003517 RID: 13591 RVA: 0x0001C6A6 File Offset: 0x0001A8A6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2089_0.method_4();
			}

			// Token: 0x06003518 RID: 13592 RVA: 0x0011C800 File Offset: 0x0011AA00
			public Class2020 method_0()
			{
				return this.class2089_0.method_5(this.int_0);
			}

			// Token: 0x04001894 RID: 6292
			private int int_0;

			// Token: 0x04001895 RID: 6293
			private Class2089 class2089_0;
		}

		// Token: 0x02000867 RID: 2151
		public sealed class Class1143 : IEnumerable
		{
			// Token: 0x06003519 RID: 13593 RVA: 0x0001C6C9 File Offset: 0x0001A8C9
			public void method_0(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
			}

			// Token: 0x0600351A RID: 13594 RVA: 0x0011C820 File Offset: 0x0011AA20
			public Class2089.Class1144 method_1()
			{
				return new Class2089.Class1144(this.class2089_0);
			}

			// Token: 0x0600351B RID: 13595 RVA: 0x0011C83C File Offset: 0x0011AA3C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001896 RID: 6294
			private Class2089 class2089_0;
		}

		// Token: 0x02000868 RID: 2152
		public sealed class Class1144 : IEnumerator
		{
			// Token: 0x170003BF RID: 959
			// (get) Token: 0x0600351D RID: 13597 RVA: 0x0011C854 File Offset: 0x0011AA54
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600351E RID: 13598 RVA: 0x0001C6D2 File Offset: 0x0001A8D2
			public Class1144(Class2089 class2089_1)
			{
				this.class2089_0 = class2089_1;
				this.int_0 = -1;
			}

			// Token: 0x0600351F RID: 13599 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003520 RID: 13600 RVA: 0x0001C6F1 File Offset: 0x0001A8F1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2089_0.method_6();
			}

			// Token: 0x06003521 RID: 13601 RVA: 0x0011C86C File Offset: 0x0011AA6C
			public Class2020 method_0()
			{
				return this.class2089_0.method_7(this.int_0);
			}

			// Token: 0x04001897 RID: 6295
			private int int_0;

			// Token: 0x04001898 RID: 6296
			private Class2089 class2089_0;
		}
	}
}
