using System;
using System.Collections;
using ns16;
using ns21;

namespace ns22
{
	// Token: 0x020001C7 RID: 455
	public sealed class Class2136 : Class2059
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x00009AD9 File Offset: 0x00007CD9
		public Class2136()
		{
			this.method_10();
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00077608 File Offset: 0x00075808
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "version");
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00077628 File Offset: 0x00075828
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "version", int_0)));
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00077654 File Offset: 0x00075854
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "updateSequence");
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00077674 File Offset: 0x00075874
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "updateSequence", int_0)));
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000776A0 File Offset: 0x000758A0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Service");
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000776C0 File Offset: 0x000758C0
		public Class2132 method_7(int int_0)
		{
			return new Class2132(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Service", int_0));
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000776E8 File Offset: 0x000758E8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Capability");
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00077708 File Offset: 0x00075908
		public Class2109 method_9(int int_0)
		{
			return new Class2109(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Capability", int_0));
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00009B13 File Offset: 0x00007D13
		private void method_10()
		{
			this.class1651_0.method_0(this);
			this.class1653_0.method_0(this);
			this.class1655_0.method_0(this);
			this.class1657_0.method_0(this);
		}

		// Token: 0x040004D3 RID: 1235
		public Class2136.Class1651 class1651_0 = new Class2136.Class1651();

		// Token: 0x040004D4 RID: 1236
		public Class2136.Class1653 class1653_0 = new Class2136.Class1653();

		// Token: 0x040004D5 RID: 1237
		public Class2136.Class1655 class1655_0 = new Class2136.Class1655();

		// Token: 0x040004D6 RID: 1238
		public Class2136.Class1657 class1657_0 = new Class2136.Class1657();

		// Token: 0x020001C8 RID: 456
		public sealed class Class1651 : IEnumerable
		{
			// Token: 0x06000AE5 RID: 2789 RVA: 0x00009B45 File Offset: 0x00007D45
			public void method_0(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
			}

			// Token: 0x06000AE6 RID: 2790 RVA: 0x00077730 File Offset: 0x00075930
			public Class2136.Class1652 method_1()
			{
				return new Class2136.Class1652(this.class2136_0);
			}

			// Token: 0x06000AE7 RID: 2791 RVA: 0x0007774C File Offset: 0x0007594C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004D7 RID: 1239
			private Class2136 class2136_0;
		}

		// Token: 0x020001C9 RID: 457
		public sealed class Class1652 : IEnumerator
		{
			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00077764 File Offset: 0x00075964
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x00009B4E File Offset: 0x00007D4E
			public Class1652(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
				this.int_0 = -1;
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x00009B64 File Offset: 0x00007D64
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x00009B6D File Offset: 0x00007D6D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2136_0.method_2();
			}

			// Token: 0x06000AED RID: 2797 RVA: 0x0007777C File Offset: 0x0007597C
			public Class2050 method_0()
			{
				return this.class2136_0.method_3(this.int_0);
			}

			// Token: 0x040004D8 RID: 1240
			private int int_0;

			// Token: 0x040004D9 RID: 1241
			private Class2136 class2136_0;
		}

		// Token: 0x020001CA RID: 458
		public sealed class Class1653 : IEnumerable
		{
			// Token: 0x06000AEE RID: 2798 RVA: 0x00009B90 File Offset: 0x00007D90
			public void method_0(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x0007779C File Offset: 0x0007599C
			public Class2136.Class1654 method_1()
			{
				return new Class2136.Class1654(this.class2136_0);
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x000777B8 File Offset: 0x000759B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004DA RID: 1242
			private Class2136 class2136_0;
		}

		// Token: 0x020001CB RID: 459
		public sealed class Class1654 : IEnumerator
		{
			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000777D0 File Offset: 0x000759D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000AF3 RID: 2803 RVA: 0x00009B99 File Offset: 0x00007D99
			public Class1654(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
				this.int_0 = -1;
			}

			// Token: 0x06000AF4 RID: 2804 RVA: 0x00009BAF File Offset: 0x00007DAF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000AF5 RID: 2805 RVA: 0x00009BB8 File Offset: 0x00007DB8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2136_0.method_4();
			}

			// Token: 0x06000AF6 RID: 2806 RVA: 0x000777E8 File Offset: 0x000759E8
			public Class2050 method_0()
			{
				return this.class2136_0.method_5(this.int_0);
			}

			// Token: 0x040004DB RID: 1243
			private int int_0;

			// Token: 0x040004DC RID: 1244
			private Class2136 class2136_0;
		}

		// Token: 0x020001CC RID: 460
		public sealed class Class1655 : IEnumerable
		{
			// Token: 0x06000AF7 RID: 2807 RVA: 0x00009BDB File Offset: 0x00007DDB
			public void method_0(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
			}

			// Token: 0x06000AF8 RID: 2808 RVA: 0x00077808 File Offset: 0x00075A08
			public Class2136.Class1656 method_1()
			{
				return new Class2136.Class1656(this.class2136_0);
			}

			// Token: 0x06000AF9 RID: 2809 RVA: 0x00077824 File Offset: 0x00075A24
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004DD RID: 1245
			private Class2136 class2136_0;
		}

		// Token: 0x020001CD RID: 461
		public sealed class Class1656 : IEnumerator
		{
			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0007783C File Offset: 0x00075A3C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000AFC RID: 2812 RVA: 0x00009BE4 File Offset: 0x00007DE4
			public Class1656(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
				this.int_0 = -1;
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x00009BFA File Offset: 0x00007DFA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000AFE RID: 2814 RVA: 0x00009C03 File Offset: 0x00007E03
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2136_0.method_6();
			}

			// Token: 0x06000AFF RID: 2815 RVA: 0x00077854 File Offset: 0x00075A54
			public Class2132 method_0()
			{
				return this.class2136_0.method_7(this.int_0);
			}

			// Token: 0x040004DE RID: 1246
			private int int_0;

			// Token: 0x040004DF RID: 1247
			private Class2136 class2136_0;
		}

		// Token: 0x020001CE RID: 462
		public sealed class Class1657 : IEnumerable
		{
			// Token: 0x06000B00 RID: 2816 RVA: 0x00009C26 File Offset: 0x00007E26
			public void method_0(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
			}

			// Token: 0x06000B01 RID: 2817 RVA: 0x00077874 File Offset: 0x00075A74
			public Class2136.Class1658 method_1()
			{
				return new Class2136.Class1658(this.class2136_0);
			}

			// Token: 0x06000B02 RID: 2818 RVA: 0x00077890 File Offset: 0x00075A90
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040004E0 RID: 1248
			private Class2136 class2136_0;
		}

		// Token: 0x020001CF RID: 463
		public sealed class Class1658 : IEnumerator
		{
			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000B04 RID: 2820 RVA: 0x000778A8 File Offset: 0x00075AA8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000B05 RID: 2821 RVA: 0x00009C2F File Offset: 0x00007E2F
			public Class1658(Class2136 class2136_1)
			{
				this.class2136_0 = class2136_1;
				this.int_0 = -1;
			}

			// Token: 0x06000B06 RID: 2822 RVA: 0x00009C45 File Offset: 0x00007E45
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000B07 RID: 2823 RVA: 0x00009C4E File Offset: 0x00007E4E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2136_0.method_8();
			}

			// Token: 0x06000B08 RID: 2824 RVA: 0x000778C0 File Offset: 0x00075AC0
			public Class2109 method_0()
			{
				return this.class2136_0.method_9(this.int_0);
			}

			// Token: 0x040004E1 RID: 1249
			private int int_0;

			// Token: 0x040004E2 RID: 1250
			private Class2136 class2136_0;
		}
	}
}
