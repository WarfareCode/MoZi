using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x020007CE RID: 1998
	public sealed class Class2082 : Class2059
	{
		// Token: 0x0600318E RID: 12686 RVA: 0x0001AA64 File Offset: 0x00018C64
		public Class2082()
		{
			this.method_10();
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000FE8F8 File Offset: 0x000FCAF8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "North");
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0010C84C File Offset: 0x0010AA4C
		public Class2081 method_3(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "North", int_0));
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000FE940 File Offset: 0x000FCB40
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "South");
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0010C874 File Offset: 0x0010AA74
		public Class2081 method_5(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "South", int_0));
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000FE988 File Offset: 0x000FCB88
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "West");
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x0010C89C File Offset: 0x0010AA9C
		public Class2086 method_7(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "West", int_0));
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000FE9D0 File Offset: 0x000FCBD0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "East");
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x0010C8C4 File Offset: 0x0010AAC4
		public Class2086 method_9(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "East", int_0));
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x0001AA9E File Offset: 0x00018C9E
		private void method_10()
		{
			this.class1051_0.method_0(this);
			this.class1053_0.method_0(this);
			this.class1055_0.method_0(this);
			this.class1057_0.method_0(this);
		}

		// Token: 0x040016F7 RID: 5879
		public Class2082.Class1051 class1051_0 = new Class2082.Class1051();

		// Token: 0x040016F8 RID: 5880
		public Class2082.Class1053 class1053_0 = new Class2082.Class1053();

		// Token: 0x040016F9 RID: 5881
		public Class2082.Class1055 class1055_0 = new Class2082.Class1055();

		// Token: 0x040016FA RID: 5882
		public Class2082.Class1057 class1057_0 = new Class2082.Class1057();

		// Token: 0x020007CF RID: 1999
		public sealed class Class1051 : IEnumerable
		{
			// Token: 0x06003198 RID: 12696 RVA: 0x0001AAD0 File Offset: 0x00018CD0
			public void method_0(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
			}

			// Token: 0x06003199 RID: 12697 RVA: 0x0010C8EC File Offset: 0x0010AAEC
			public Class2082.Class1052 method_1()
			{
				return new Class2082.Class1052(this.class2082_0);
			}

			// Token: 0x0600319A RID: 12698 RVA: 0x0010C908 File Offset: 0x0010AB08
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016FB RID: 5883
			private Class2082 class2082_0;
		}

		// Token: 0x020007D0 RID: 2000
		public sealed class Class1052 : IEnumerator
		{
			// Token: 0x17000369 RID: 873
			// (get) Token: 0x0600319C RID: 12700 RVA: 0x0010C920 File Offset: 0x0010AB20
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600319D RID: 12701 RVA: 0x0001AAD9 File Offset: 0x00018CD9
			public Class1052(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
				this.int_0 = -1;
			}

			// Token: 0x0600319E RID: 12702 RVA: 0x0001AAEF File Offset: 0x00018CEF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600319F RID: 12703 RVA: 0x0001AAF8 File Offset: 0x00018CF8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2082_0.method_2();
			}

			// Token: 0x060031A0 RID: 12704 RVA: 0x0010C938 File Offset: 0x0010AB38
			public Class2081 method_0()
			{
				return this.class2082_0.method_3(this.int_0);
			}

			// Token: 0x040016FC RID: 5884
			private int int_0;

			// Token: 0x040016FD RID: 5885
			private Class2082 class2082_0;
		}

		// Token: 0x020007D1 RID: 2001
		public sealed class Class1053 : IEnumerable
		{
			// Token: 0x060031A1 RID: 12705 RVA: 0x0001AB1B File Offset: 0x00018D1B
			public void method_0(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
			}

			// Token: 0x060031A2 RID: 12706 RVA: 0x0010C958 File Offset: 0x0010AB58
			public Class2082.Class1054 method_1()
			{
				return new Class2082.Class1054(this.class2082_0);
			}

			// Token: 0x060031A3 RID: 12707 RVA: 0x0010C974 File Offset: 0x0010AB74
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016FE RID: 5886
			private Class2082 class2082_0;
		}

		// Token: 0x020007D2 RID: 2002
		public sealed class Class1054 : IEnumerator
		{
			// Token: 0x1700036A RID: 874
			// (get) Token: 0x060031A5 RID: 12709 RVA: 0x0010C98C File Offset: 0x0010AB8C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031A6 RID: 12710 RVA: 0x0001AB24 File Offset: 0x00018D24
			public Class1054(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
				this.int_0 = -1;
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x0001AB3A File Offset: 0x00018D3A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031A8 RID: 12712 RVA: 0x0001AB43 File Offset: 0x00018D43
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2082_0.method_4();
			}

			// Token: 0x060031A9 RID: 12713 RVA: 0x0010C9A4 File Offset: 0x0010ABA4
			public Class2081 method_0()
			{
				return this.class2082_0.method_5(this.int_0);
			}

			// Token: 0x040016FF RID: 5887
			private int int_0;

			// Token: 0x04001700 RID: 5888
			private Class2082 class2082_0;
		}

		// Token: 0x020007D3 RID: 2003
		public sealed class Class1055 : IEnumerable
		{
			// Token: 0x060031AA RID: 12714 RVA: 0x0001AB66 File Offset: 0x00018D66
			public void method_0(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
			}

			// Token: 0x060031AB RID: 12715 RVA: 0x0010C9C4 File Offset: 0x0010ABC4
			public Class2082.Class1056 method_1()
			{
				return new Class2082.Class1056(this.class2082_0);
			}

			// Token: 0x060031AC RID: 12716 RVA: 0x0010C9E0 File Offset: 0x0010ABE0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001701 RID: 5889
			private Class2082 class2082_0;
		}

		// Token: 0x020007D4 RID: 2004
		public sealed class Class1056 : IEnumerator
		{
			// Token: 0x1700036B RID: 875
			// (get) Token: 0x060031AE RID: 12718 RVA: 0x0010C9F8 File Offset: 0x0010ABF8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031AF RID: 12719 RVA: 0x0001AB6F File Offset: 0x00018D6F
			public Class1056(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
				this.int_0 = -1;
			}

			// Token: 0x060031B0 RID: 12720 RVA: 0x0001AB85 File Offset: 0x00018D85
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031B1 RID: 12721 RVA: 0x0001AB8E File Offset: 0x00018D8E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2082_0.method_6();
			}

			// Token: 0x060031B2 RID: 12722 RVA: 0x0010CA10 File Offset: 0x0010AC10
			public Class2086 method_0()
			{
				return this.class2082_0.method_7(this.int_0);
			}

			// Token: 0x04001702 RID: 5890
			private int int_0;

			// Token: 0x04001703 RID: 5891
			private Class2082 class2082_0;
		}

		// Token: 0x020007D5 RID: 2005
		public sealed class Class1057 : IEnumerable
		{
			// Token: 0x060031B3 RID: 12723 RVA: 0x0001ABB1 File Offset: 0x00018DB1
			public void method_0(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
			}

			// Token: 0x060031B4 RID: 12724 RVA: 0x0010CA30 File Offset: 0x0010AC30
			public Class2082.Class1058 method_1()
			{
				return new Class2082.Class1058(this.class2082_0);
			}

			// Token: 0x060031B5 RID: 12725 RVA: 0x0010CA4C File Offset: 0x0010AC4C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001704 RID: 5892
			private Class2082 class2082_0;
		}

		// Token: 0x020007D6 RID: 2006
		public sealed class Class1058 : IEnumerator
		{
			// Token: 0x1700036C RID: 876
			// (get) Token: 0x060031B7 RID: 12727 RVA: 0x0010CA64 File Offset: 0x0010AC64
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031B8 RID: 12728 RVA: 0x0001ABBA File Offset: 0x00018DBA
			public Class1058(Class2082 class2082_1)
			{
				this.class2082_0 = class2082_1;
				this.int_0 = -1;
			}

			// Token: 0x060031B9 RID: 12729 RVA: 0x0001ABD0 File Offset: 0x00018DD0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031BA RID: 12730 RVA: 0x0001ABD9 File Offset: 0x00018DD9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2082_0.method_8();
			}

			// Token: 0x060031BB RID: 12731 RVA: 0x0010CA7C File Offset: 0x0010AC7C
			public Class2086 method_0()
			{
				return this.class2082_0.method_9(this.int_0);
			}

			// Token: 0x04001705 RID: 5893
			private int int_0;

			// Token: 0x04001706 RID: 5894
			private Class2082 class2082_0;
		}
	}
}
