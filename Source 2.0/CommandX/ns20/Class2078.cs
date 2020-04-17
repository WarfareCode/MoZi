using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x020007B3 RID: 1971
	public sealed class Class2078 : Class2059
	{
		// Token: 0x060030C8 RID: 12488 RVA: 0x0001A277 File Offset: 0x00018477
		public Class2078()
		{
			this.method_10();
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000FFF60 File Offset: 0x000FE160
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerUrl");
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000FFF80 File Offset: 0x000FE180
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerUrl", int_0)));
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000FFFAC File Offset: 0x000FE1AC
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DataSetName");
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000FFFCC File Offset: 0x000FE1CC
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DataSetName", int_0)));
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000590B8 File Offset: 0x000572B8
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "CacheExpirationTime");
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000590D8 File Offset: 0x000572D8
		public Class2100 method_7(int int_0)
		{
			return new Class2100(base.method_1(Class2059.Enum155.const_1, "", "CacheExpirationTime", int_0));
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0005914C File Offset: 0x0005734C
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerLogoFilePath");
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0005916C File Offset: 0x0005736C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerLogoFilePath", int_0)));
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0001A2B1 File Offset: 0x000184B1
		private void method_10()
		{
			this.class1031_0.method_0(this);
			this.class1033_0.method_0(this);
			this.class1035_0.method_0(this);
			this.class1037_0.method_0(this);
		}

		// Token: 0x040016B0 RID: 5808
		public Class2078.Class1031 class1031_0 = new Class2078.Class1031();

		// Token: 0x040016B1 RID: 5809
		public Class2078.Class1033 class1033_0 = new Class2078.Class1033();

		// Token: 0x040016B2 RID: 5810
		public Class2078.Class1035 class1035_0 = new Class2078.Class1035();

		// Token: 0x040016B3 RID: 5811
		public Class2078.Class1037 class1037_0 = new Class2078.Class1037();

		// Token: 0x020007B4 RID: 1972
		public sealed class Class1031 : IEnumerable
		{
			// Token: 0x060030D2 RID: 12498 RVA: 0x0001A2E3 File Offset: 0x000184E3
			public void method_0(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
			}

			// Token: 0x060030D3 RID: 12499 RVA: 0x0010B2BC File Offset: 0x001094BC
			public Class2078.Class1032 method_1()
			{
				return new Class2078.Class1032(this.class2078_0);
			}

			// Token: 0x060030D4 RID: 12500 RVA: 0x0010B2D8 File Offset: 0x001094D8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016B4 RID: 5812
			private Class2078 class2078_0;
		}

		// Token: 0x020007B5 RID: 1973
		public sealed class Class1032 : IEnumerator
		{
			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060030D6 RID: 12502 RVA: 0x0010B2F0 File Offset: 0x001094F0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030D7 RID: 12503 RVA: 0x0001A2EC File Offset: 0x000184EC
			public Class1032(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
				this.int_0 = -1;
			}

			// Token: 0x060030D8 RID: 12504 RVA: 0x0001A302 File Offset: 0x00018502
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030D9 RID: 12505 RVA: 0x0001A30B File Offset: 0x0001850B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2078_0.method_2();
			}

			// Token: 0x060030DA RID: 12506 RVA: 0x0010B308 File Offset: 0x00109508
			public Class2050 method_0()
			{
				return this.class2078_0.method_3(this.int_0);
			}

			// Token: 0x040016B5 RID: 5813
			private int int_0;

			// Token: 0x040016B6 RID: 5814
			private Class2078 class2078_0;
		}

		// Token: 0x020007B6 RID: 1974
		public sealed class Class1033 : IEnumerable
		{
			// Token: 0x060030DB RID: 12507 RVA: 0x0001A32E File Offset: 0x0001852E
			public void method_0(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
			}

			// Token: 0x060030DC RID: 12508 RVA: 0x0010B328 File Offset: 0x00109528
			public Class2078.Class1034 method_1()
			{
				return new Class2078.Class1034(this.class2078_0);
			}

			// Token: 0x060030DD RID: 12509 RVA: 0x0010B344 File Offset: 0x00109544
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016B7 RID: 5815
			private Class2078 class2078_0;
		}

		// Token: 0x020007B7 RID: 1975
		public sealed class Class1034 : IEnumerator
		{
			// Token: 0x1700034E RID: 846
			// (get) Token: 0x060030DF RID: 12511 RVA: 0x0010B35C File Offset: 0x0010955C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030E0 RID: 12512 RVA: 0x0001A337 File Offset: 0x00018537
			public Class1034(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
				this.int_0 = -1;
			}

			// Token: 0x060030E1 RID: 12513 RVA: 0x0001A34D File Offset: 0x0001854D
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030E2 RID: 12514 RVA: 0x0001A356 File Offset: 0x00018556
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2078_0.method_4();
			}

			// Token: 0x060030E3 RID: 12515 RVA: 0x0010B374 File Offset: 0x00109574
			public Class2050 method_0()
			{
				return this.class2078_0.method_5(this.int_0);
			}

			// Token: 0x040016B8 RID: 5816
			private int int_0;

			// Token: 0x040016B9 RID: 5817
			private Class2078 class2078_0;
		}

		// Token: 0x020007B8 RID: 1976
		public sealed class Class1035 : IEnumerable
		{
			// Token: 0x060030E4 RID: 12516 RVA: 0x0001A379 File Offset: 0x00018579
			public void method_0(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
			}

			// Token: 0x060030E5 RID: 12517 RVA: 0x0010B394 File Offset: 0x00109594
			public Class2078.Class1036 method_1()
			{
				return new Class2078.Class1036(this.class2078_0);
			}

			// Token: 0x060030E6 RID: 12518 RVA: 0x0010B3B0 File Offset: 0x001095B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016BA RID: 5818
			private Class2078 class2078_0;
		}

		// Token: 0x020007B9 RID: 1977
		public sealed class Class1036 : IEnumerator
		{
			// Token: 0x1700034F RID: 847
			// (get) Token: 0x060030E8 RID: 12520 RVA: 0x0010B3C8 File Offset: 0x001095C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030E9 RID: 12521 RVA: 0x0001A382 File Offset: 0x00018582
			public Class1036(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
				this.int_0 = -1;
			}

			// Token: 0x060030EA RID: 12522 RVA: 0x0001A398 File Offset: 0x00018598
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030EB RID: 12523 RVA: 0x0001A3A1 File Offset: 0x000185A1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2078_0.method_6();
			}

			// Token: 0x060030EC RID: 12524 RVA: 0x0010B3E0 File Offset: 0x001095E0
			public Class2100 method_0()
			{
				return this.class2078_0.method_7(this.int_0);
			}

			// Token: 0x040016BB RID: 5819
			private int int_0;

			// Token: 0x040016BC RID: 5820
			private Class2078 class2078_0;
		}

		// Token: 0x020007BA RID: 1978
		public sealed class Class1037 : IEnumerable
		{
			// Token: 0x060030ED RID: 12525 RVA: 0x0001A3C4 File Offset: 0x000185C4
			public void method_0(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
			}

			// Token: 0x060030EE RID: 12526 RVA: 0x0010B400 File Offset: 0x00109600
			public Class2078.Class1038 method_1()
			{
				return new Class2078.Class1038(this.class2078_0);
			}

			// Token: 0x060030EF RID: 12527 RVA: 0x0010B41C File Offset: 0x0010961C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016BD RID: 5821
			private Class2078 class2078_0;
		}

		// Token: 0x020007BB RID: 1979
		public sealed class Class1038 : IEnumerator
		{
			// Token: 0x17000350 RID: 848
			// (get) Token: 0x060030F1 RID: 12529 RVA: 0x0010B434 File Offset: 0x00109634
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030F2 RID: 12530 RVA: 0x0001A3CD File Offset: 0x000185CD
			public Class1038(Class2078 class2078_1)
			{
				this.class2078_0 = class2078_1;
				this.int_0 = -1;
			}

			// Token: 0x060030F3 RID: 12531 RVA: 0x0001A3E3 File Offset: 0x000185E3
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030F4 RID: 12532 RVA: 0x0001A3EC File Offset: 0x000185EC
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2078_0.method_8();
			}

			// Token: 0x060030F5 RID: 12533 RVA: 0x0010B44C File Offset: 0x0010964C
			public Class2050 method_0()
			{
				return this.class2078_0.method_9(this.int_0);
			}

			// Token: 0x040016BE RID: 5822
			private int int_0;

			// Token: 0x040016BF RID: 5823
			private Class2078 class2078_0;
		}
	}
}
