using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x020007DE RID: 2014
	public sealed class Class2083 : Class2059
	{
		// Token: 0x060031D6 RID: 12758 RVA: 0x0001AD2E File Offset: 0x00018F2E
		public Class2083()
		{
			this.method_10();
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0001AD68 File Offset: 0x00018F68
		public Class2083(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000FE8F8 File Offset: 0x000FCAF8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "North");
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0010C84C File Offset: 0x0010AA4C
		public Class2081 method_3(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "North", int_0));
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000FE940 File Offset: 0x000FCB40
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "South");
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0010C874 File Offset: 0x0010AA74
		public Class2081 method_5(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "South", int_0));
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000FE988 File Offset: 0x000FCB88
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "West");
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0010C89C File Offset: 0x0010AA9C
		public Class2086 method_7(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "West", int_0));
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000FE9D0 File Offset: 0x000FCBD0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "East");
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0010C8C4 File Offset: 0x0010AAC4
		public Class2086 method_9(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "East", int_0));
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0001ADA3 File Offset: 0x00018FA3
		private void method_10()
		{
			this.class1059_0.method_0(this);
			this.class1061_0.method_0(this);
			this.class1063_0.method_0(this);
			this.class1065_0.method_0(this);
		}

		// Token: 0x04001723 RID: 5923
		public Class2083.Class1059 class1059_0 = new Class2083.Class1059();

		// Token: 0x04001724 RID: 5924
		public Class2083.Class1061 class1061_0 = new Class2083.Class1061();

		// Token: 0x04001725 RID: 5925
		public Class2083.Class1063 class1063_0 = new Class2083.Class1063();

		// Token: 0x04001726 RID: 5926
		public Class2083.Class1065 class1065_0 = new Class2083.Class1065();

		// Token: 0x020007DF RID: 2015
		public sealed class Class1059 : IEnumerable
		{
			// Token: 0x060031E1 RID: 12769 RVA: 0x0001ADD5 File Offset: 0x00018FD5
			public void method_0(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
			}

			// Token: 0x060031E2 RID: 12770 RVA: 0x0010D074 File Offset: 0x0010B274
			public Class2083.Class1060 method_1()
			{
				return new Class2083.Class1060(this.class2083_0);
			}

			// Token: 0x060031E3 RID: 12771 RVA: 0x0010D090 File Offset: 0x0010B290
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001727 RID: 5927
			private Class2083 class2083_0;
		}

		// Token: 0x020007E0 RID: 2016
		public sealed class Class1060 : IEnumerator
		{
			// Token: 0x1700036F RID: 879
			// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0010D0A8 File Offset: 0x0010B2A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031E6 RID: 12774 RVA: 0x0001ADDE File Offset: 0x00018FDE
			public Class1060(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
				this.int_0 = -1;
			}

			// Token: 0x060031E7 RID: 12775 RVA: 0x0001ADF4 File Offset: 0x00018FF4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031E8 RID: 12776 RVA: 0x0001ADFD File Offset: 0x00018FFD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2083_0.method_2();
			}

			// Token: 0x060031E9 RID: 12777 RVA: 0x0010D0C0 File Offset: 0x0010B2C0
			public Class2081 method_0()
			{
				return this.class2083_0.method_3(this.int_0);
			}

			// Token: 0x04001728 RID: 5928
			private int int_0;

			// Token: 0x04001729 RID: 5929
			private Class2083 class2083_0;
		}

		// Token: 0x020007E1 RID: 2017
		public sealed class Class1061 : IEnumerable
		{
			// Token: 0x060031EA RID: 12778 RVA: 0x0001AE20 File Offset: 0x00019020
			public void method_0(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
			}

			// Token: 0x060031EB RID: 12779 RVA: 0x0010D0E0 File Offset: 0x0010B2E0
			public Class2083.Class1062 method_1()
			{
				return new Class2083.Class1062(this.class2083_0);
			}

			// Token: 0x060031EC RID: 12780 RVA: 0x0010D0FC File Offset: 0x0010B2FC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400172A RID: 5930
			private Class2083 class2083_0;
		}

		// Token: 0x020007E2 RID: 2018
		public sealed class Class1062 : IEnumerator
		{
			// Token: 0x17000370 RID: 880
			// (get) Token: 0x060031EE RID: 12782 RVA: 0x0010D114 File Offset: 0x0010B314
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031EF RID: 12783 RVA: 0x0001AE29 File Offset: 0x00019029
			public Class1062(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
				this.int_0 = -1;
			}

			// Token: 0x060031F0 RID: 12784 RVA: 0x0001AE3F File Offset: 0x0001903F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031F1 RID: 12785 RVA: 0x0001AE48 File Offset: 0x00019048
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2083_0.method_4();
			}

			// Token: 0x060031F2 RID: 12786 RVA: 0x0010D12C File Offset: 0x0010B32C
			public Class2081 method_0()
			{
				return this.class2083_0.method_5(this.int_0);
			}

			// Token: 0x0400172B RID: 5931
			private int int_0;

			// Token: 0x0400172C RID: 5932
			private Class2083 class2083_0;
		}

		// Token: 0x020007E3 RID: 2019
		public sealed class Class1063 : IEnumerable
		{
			// Token: 0x060031F3 RID: 12787 RVA: 0x0001AE6B File Offset: 0x0001906B
			public void method_0(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
			}

			// Token: 0x060031F4 RID: 12788 RVA: 0x0010D14C File Offset: 0x0010B34C
			public Class2083.Class1064 method_1()
			{
				return new Class2083.Class1064(this.class2083_0);
			}

			// Token: 0x060031F5 RID: 12789 RVA: 0x0010D168 File Offset: 0x0010B368
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400172D RID: 5933
			private Class2083 class2083_0;
		}

		// Token: 0x020007E4 RID: 2020
		public sealed class Class1064 : IEnumerator
		{
			// Token: 0x17000371 RID: 881
			// (get) Token: 0x060031F7 RID: 12791 RVA: 0x0010D180 File Offset: 0x0010B380
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060031F8 RID: 12792 RVA: 0x0001AE74 File Offset: 0x00019074
			public Class1064(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
				this.int_0 = -1;
			}

			// Token: 0x060031F9 RID: 12793 RVA: 0x0001AE8A File Offset: 0x0001908A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060031FA RID: 12794 RVA: 0x0001AE93 File Offset: 0x00019093
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2083_0.method_6();
			}

			// Token: 0x060031FB RID: 12795 RVA: 0x0010D198 File Offset: 0x0010B398
			public Class2086 method_0()
			{
				return this.class2083_0.method_7(this.int_0);
			}

			// Token: 0x0400172E RID: 5934
			private int int_0;

			// Token: 0x0400172F RID: 5935
			private Class2083 class2083_0;
		}

		// Token: 0x020007E5 RID: 2021
		public sealed class Class1065 : IEnumerable
		{
			// Token: 0x060031FC RID: 12796 RVA: 0x0001AEB6 File Offset: 0x000190B6
			public void method_0(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
			}

			// Token: 0x060031FD RID: 12797 RVA: 0x0010D1B8 File Offset: 0x0010B3B8
			public Class2083.Class1066 method_1()
			{
				return new Class2083.Class1066(this.class2083_0);
			}

			// Token: 0x060031FE RID: 12798 RVA: 0x0010D1D4 File Offset: 0x0010B3D4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001730 RID: 5936
			private Class2083 class2083_0;
		}

		// Token: 0x020007E6 RID: 2022
		public sealed class Class1066 : IEnumerator
		{
			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06003200 RID: 12800 RVA: 0x0010D1EC File Offset: 0x0010B3EC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003201 RID: 12801 RVA: 0x0001AEBF File Offset: 0x000190BF
			public Class1066(Class2083 class2083_1)
			{
				this.class2083_0 = class2083_1;
				this.int_0 = -1;
			}

			// Token: 0x06003202 RID: 12802 RVA: 0x0001AED5 File Offset: 0x000190D5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003203 RID: 12803 RVA: 0x0001AEDE File Offset: 0x000190DE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2083_0.method_8();
			}

			// Token: 0x06003204 RID: 12804 RVA: 0x0010D204 File Offset: 0x0010B404
			public Class2086 method_0()
			{
				return this.class2083_0.method_9(this.int_0);
			}

			// Token: 0x04001731 RID: 5937
			private int int_0;

			// Token: 0x04001732 RID: 5938
			private Class2083 class2083_0;
		}
	}
}
