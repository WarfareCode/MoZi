using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns15
{
	// Token: 0x02000681 RID: 1665
	public sealed class Class2062 : Class2059
	{
		// Token: 0x06002A55 RID: 10837 RVA: 0x000171E0 File Offset: 0x000153E0
		public Class2062()
		{
			this.method_10();
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x0001721A File Offset: 0x0001541A
		public Class2062(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000FE8F8 File Offset: 0x000FCAF8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "North");
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000FE918 File Offset: 0x000FCB18
		public Class2061 method_3(int int_0)
		{
			return new Class2061(base.method_1(Class2059.Enum155.const_1, "", "North", int_0));
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000FE940 File Offset: 0x000FCB40
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "South");
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000FE960 File Offset: 0x000FCB60
		public Class2061 method_5(int int_0)
		{
			return new Class2061(base.method_1(Class2059.Enum155.const_1, "", "South", int_0));
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000FE988 File Offset: 0x000FCB88
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "West");
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000FE9A8 File Offset: 0x000FCBA8
		public Class2063 method_7(int int_0)
		{
			return new Class2063(base.method_1(Class2059.Enum155.const_1, "", "West", int_0));
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000FE9D0 File Offset: 0x000FCBD0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "East");
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000FE9F0 File Offset: 0x000FCBF0
		public Class2063 method_9(int int_0)
		{
			return new Class2063(base.method_1(Class2059.Enum155.const_1, "", "East", int_0));
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00017255 File Offset: 0x00015455
		private void method_10()
		{
			this.class861_0.method_0(this);
			this.class863_0.method_0(this);
			this.class865_0.method_0(this);
			this.class867_0.method_0(this);
		}

		// Token: 0x04001434 RID: 5172
		public Class2062.Class861 class861_0 = new Class2062.Class861();

		// Token: 0x04001435 RID: 5173
		public Class2062.Class863 class863_0 = new Class2062.Class863();

		// Token: 0x04001436 RID: 5174
		public Class2062.Class865 class865_0 = new Class2062.Class865();

		// Token: 0x04001437 RID: 5175
		public Class2062.Class867 class867_0 = new Class2062.Class867();

		// Token: 0x02000682 RID: 1666
		public sealed class Class861 : IEnumerable
		{
			// Token: 0x06002A60 RID: 10848 RVA: 0x00017287 File Offset: 0x00015487
			public void method_0(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
			}

			// Token: 0x06002A61 RID: 10849 RVA: 0x000FEA18 File Offset: 0x000FCC18
			public Class2062.Class862 method_1()
			{
				return new Class2062.Class862(this.class2062_0);
			}

			// Token: 0x06002A62 RID: 10850 RVA: 0x000FEA34 File Offset: 0x000FCC34
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001438 RID: 5176
			private Class2062 class2062_0;
		}

		// Token: 0x02000683 RID: 1667
		public sealed class Class862 : IEnumerator
		{
			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000FEA4C File Offset: 0x000FCC4C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A65 RID: 10853 RVA: 0x00017290 File Offset: 0x00015490
			public Class862(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A66 RID: 10854 RVA: 0x000172A6 File Offset: 0x000154A6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A67 RID: 10855 RVA: 0x000172AF File Offset: 0x000154AF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2062_0.method_2();
			}

			// Token: 0x06002A68 RID: 10856 RVA: 0x000FEA64 File Offset: 0x000FCC64
			public Class2061 method_0()
			{
				return this.class2062_0.method_3(this.int_0);
			}

			// Token: 0x04001439 RID: 5177
			private int int_0;

			// Token: 0x0400143A RID: 5178
			private Class2062 class2062_0;
		}

		// Token: 0x02000684 RID: 1668
		public sealed class Class863 : IEnumerable
		{
			// Token: 0x06002A69 RID: 10857 RVA: 0x000172D2 File Offset: 0x000154D2
			public void method_0(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
			}

			// Token: 0x06002A6A RID: 10858 RVA: 0x000FEA84 File Offset: 0x000FCC84
			public Class2062.Class864 method_1()
			{
				return new Class2062.Class864(this.class2062_0);
			}

			// Token: 0x06002A6B RID: 10859 RVA: 0x000FEAA0 File Offset: 0x000FCCA0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400143B RID: 5179
			private Class2062 class2062_0;
		}

		// Token: 0x02000685 RID: 1669
		public sealed class Class864 : IEnumerator
		{
			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06002A6D RID: 10861 RVA: 0x000FEAB8 File Offset: 0x000FCCB8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A6E RID: 10862 RVA: 0x000172DB File Offset: 0x000154DB
			public Class864(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A6F RID: 10863 RVA: 0x000172F1 File Offset: 0x000154F1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A70 RID: 10864 RVA: 0x000172FA File Offset: 0x000154FA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2062_0.method_4();
			}

			// Token: 0x06002A71 RID: 10865 RVA: 0x000FEAD0 File Offset: 0x000FCCD0
			public Class2061 method_0()
			{
				return this.class2062_0.method_5(this.int_0);
			}

			// Token: 0x0400143C RID: 5180
			private int int_0;

			// Token: 0x0400143D RID: 5181
			private Class2062 class2062_0;
		}

		// Token: 0x02000686 RID: 1670
		public sealed class Class865 : IEnumerable
		{
			// Token: 0x06002A72 RID: 10866 RVA: 0x0001731D File Offset: 0x0001551D
			public void method_0(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
			}

			// Token: 0x06002A73 RID: 10867 RVA: 0x000FEAF0 File Offset: 0x000FCCF0
			public Class2062.Class866 method_1()
			{
				return new Class2062.Class866(this.class2062_0);
			}

			// Token: 0x06002A74 RID: 10868 RVA: 0x000FEB0C File Offset: 0x000FCD0C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400143E RID: 5182
			private Class2062 class2062_0;
		}

		// Token: 0x02000687 RID: 1671
		public sealed class Class866 : IEnumerator
		{
			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000FEB24 File Offset: 0x000FCD24
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A77 RID: 10871 RVA: 0x00017326 File Offset: 0x00015526
			public Class866(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A78 RID: 10872 RVA: 0x0001733C File Offset: 0x0001553C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A79 RID: 10873 RVA: 0x00017345 File Offset: 0x00015545
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2062_0.method_6();
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x000FEB3C File Offset: 0x000FCD3C
			public Class2063 method_0()
			{
				return this.class2062_0.method_7(this.int_0);
			}

			// Token: 0x0400143F RID: 5183
			private int int_0;

			// Token: 0x04001440 RID: 5184
			private Class2062 class2062_0;
		}

		// Token: 0x02000688 RID: 1672
		public sealed class Class867 : IEnumerable
		{
			// Token: 0x06002A7B RID: 10875 RVA: 0x00017368 File Offset: 0x00015568
			public void method_0(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
			}

			// Token: 0x06002A7C RID: 10876 RVA: 0x000FEB5C File Offset: 0x000FCD5C
			public Class2062.Class868 method_1()
			{
				return new Class2062.Class868(this.class2062_0);
			}

			// Token: 0x06002A7D RID: 10877 RVA: 0x000FEB78 File Offset: 0x000FCD78
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001441 RID: 5185
			private Class2062 class2062_0;
		}

		// Token: 0x02000689 RID: 1673
		public sealed class Class868 : IEnumerator
		{
			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000FEB90 File Offset: 0x000FCD90
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A80 RID: 10880 RVA: 0x00017371 File Offset: 0x00015571
			public Class868(Class2062 class2062_1)
			{
				this.class2062_0 = class2062_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A81 RID: 10881 RVA: 0x00017387 File Offset: 0x00015587
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A82 RID: 10882 RVA: 0x00017390 File Offset: 0x00015590
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2062_0.method_8();
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x000FEBA8 File Offset: 0x000FCDA8
			public Class2063 method_0()
			{
				return this.class2062_0.method_9(this.int_0);
			}

			// Token: 0x04001442 RID: 5186
			private int int_0;

			// Token: 0x04001443 RID: 5187
			private Class2062 class2062_0;
		}
	}
}
