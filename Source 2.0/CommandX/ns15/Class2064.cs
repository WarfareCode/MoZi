using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns15
{
	// Token: 0x02000691 RID: 1681
	public sealed class Class2064 : Class2059
	{
		// Token: 0x06002AA8 RID: 10920 RVA: 0x000FF0A4 File Offset: 0x000FD2A4
		public Class2064()
		{
			this.method_12();
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000FF0F4 File Offset: 0x000FD2F4
		public Class2064(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_12();
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000FF148 File Offset: 0x000FD348
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "Name");
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000FF168 File Offset: 0x000FD368
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "Name", int_0)));
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000FF194 File Offset: 0x000FD394
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TerrainTileService");
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000FF1B4 File Offset: 0x000FD3B4
		public Class2065 method_5(int int_0)
		{
			return new Class2065(base.method_1(Class2059.Enum155.const_1, "", "TerrainTileService", int_0));
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x000FF1DC File Offset: 0x000FD3DC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DownloadableWMSSet");
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000FF1FC File Offset: 0x000FD3FC
		public Class2060 method_7(int int_0)
		{
			return new Class2060(base.method_1(Class2059.Enum155.const_1, "", "DownloadableWMSSet", int_0));
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0007D258 File Offset: 0x0007B458
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LatLonBoundingBox");
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000FF224 File Offset: 0x000FD424
		public Class2062 method_9(int int_0)
		{
			return new Class2062(base.method_1(Class2059.Enum155.const_1, "", "LatLonBoundingBox", int_0));
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000FF24C File Offset: 0x000FD44C
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "HigherResolutionSubsets");
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000FF26C File Offset: 0x000FD46C
		public Class2064 method_11(int int_0)
		{
			return new Class2064(base.method_1(Class2059.Enum155.const_1, "", "HigherResolutionSubsets", int_0));
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000174AB File Offset: 0x000156AB
		private void method_12()
		{
			this.class871_0.method_0(this);
			this.class873_0.method_0(this);
			this.class875_0.method_0(this);
			this.class877_0.method_0(this);
			this.class879_0.method_0(this);
		}

		// Token: 0x0400144F RID: 5199
		public Class2064.Class871 class871_0 = new Class2064.Class871();

		// Token: 0x04001450 RID: 5200
		public Class2064.Class873 class873_0 = new Class2064.Class873();

		// Token: 0x04001451 RID: 5201
		public Class2064.Class875 class875_0 = new Class2064.Class875();

		// Token: 0x04001452 RID: 5202
		public Class2064.Class877 class877_0 = new Class2064.Class877();

		// Token: 0x04001453 RID: 5203
		public Class2064.Class879 class879_0 = new Class2064.Class879();

		// Token: 0x02000692 RID: 1682
		public sealed class Class871 : IEnumerable
		{
			// Token: 0x06002AB5 RID: 10933 RVA: 0x000174E9 File Offset: 0x000156E9
			public void method_0(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
			}

			// Token: 0x06002AB6 RID: 10934 RVA: 0x000FF294 File Offset: 0x000FD494
			public Class2064.Class872 method_1()
			{
				return new Class2064.Class872(this.class2064_0);
			}

			// Token: 0x06002AB7 RID: 10935 RVA: 0x000FF2B0 File Offset: 0x000FD4B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001454 RID: 5204
			private Class2064 class2064_0;
		}

		// Token: 0x02000693 RID: 1683
		public sealed class Class872 : IEnumerator
		{
			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000FF2C8 File Offset: 0x000FD4C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x000174F2 File Offset: 0x000156F2
			public Class872(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
				this.int_0 = -1;
			}

			// Token: 0x06002ABB RID: 10939 RVA: 0x00017508 File Offset: 0x00015708
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002ABC RID: 10940 RVA: 0x00017511 File Offset: 0x00015711
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2064_0.method_2();
			}

			// Token: 0x06002ABD RID: 10941 RVA: 0x000FF2E0 File Offset: 0x000FD4E0
			public Class2050 method_0()
			{
				return this.class2064_0.method_3(this.int_0);
			}

			// Token: 0x04001455 RID: 5205
			private int int_0;

			// Token: 0x04001456 RID: 5206
			private Class2064 class2064_0;
		}

		// Token: 0x02000694 RID: 1684
		public sealed class Class873 : IEnumerable
		{
			// Token: 0x06002ABE RID: 10942 RVA: 0x00017534 File Offset: 0x00015734
			public void method_0(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
			}

			// Token: 0x06002ABF RID: 10943 RVA: 0x000FF300 File Offset: 0x000FD500
			public Class2064.Class874 method_1()
			{
				return new Class2064.Class874(this.class2064_0);
			}

			// Token: 0x06002AC0 RID: 10944 RVA: 0x000FF31C File Offset: 0x000FD51C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001457 RID: 5207
			private Class2064 class2064_0;
		}

		// Token: 0x02000695 RID: 1685
		public sealed class Class874 : IEnumerator
		{
			// Token: 0x170002FA RID: 762
			// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000FF334 File Offset: 0x000FD534
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002AC3 RID: 10947 RVA: 0x0001753D File Offset: 0x0001573D
			public Class874(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
				this.int_0 = -1;
			}

			// Token: 0x06002AC4 RID: 10948 RVA: 0x00017553 File Offset: 0x00015753
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002AC5 RID: 10949 RVA: 0x0001755C File Offset: 0x0001575C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2064_0.method_4();
			}

			// Token: 0x06002AC6 RID: 10950 RVA: 0x000FF34C File Offset: 0x000FD54C
			public Class2065 method_0()
			{
				return this.class2064_0.method_5(this.int_0);
			}

			// Token: 0x04001458 RID: 5208
			private int int_0;

			// Token: 0x04001459 RID: 5209
			private Class2064 class2064_0;
		}

		// Token: 0x02000696 RID: 1686
		public sealed class Class875 : IEnumerable
		{
			// Token: 0x06002AC7 RID: 10951 RVA: 0x0001757F File Offset: 0x0001577F
			public void method_0(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
			}

			// Token: 0x06002AC8 RID: 10952 RVA: 0x000FF36C File Offset: 0x000FD56C
			public Class2064.Class876 method_1()
			{
				return new Class2064.Class876(this.class2064_0);
			}

			// Token: 0x06002AC9 RID: 10953 RVA: 0x000FF388 File Offset: 0x000FD588
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400145A RID: 5210
			private Class2064 class2064_0;
		}

		// Token: 0x02000697 RID: 1687
		public sealed class Class876 : IEnumerator
		{
			// Token: 0x170002FB RID: 763
			// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000FF3A0 File Offset: 0x000FD5A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002ACC RID: 10956 RVA: 0x00017588 File Offset: 0x00015788
			public Class876(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
				this.int_0 = -1;
			}

			// Token: 0x06002ACD RID: 10957 RVA: 0x0001759E File Offset: 0x0001579E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002ACE RID: 10958 RVA: 0x000175A7 File Offset: 0x000157A7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2064_0.method_6();
			}

			// Token: 0x06002ACF RID: 10959 RVA: 0x000FF3B8 File Offset: 0x000FD5B8
			public Class2060 method_0()
			{
				return this.class2064_0.method_7(this.int_0);
			}

			// Token: 0x0400145B RID: 5211
			private int int_0;

			// Token: 0x0400145C RID: 5212
			private Class2064 class2064_0;
		}

		// Token: 0x02000698 RID: 1688
		public sealed class Class877 : IEnumerable
		{
			// Token: 0x06002AD0 RID: 10960 RVA: 0x000175CA File Offset: 0x000157CA
			public void method_0(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
			}

			// Token: 0x06002AD1 RID: 10961 RVA: 0x000FF3D8 File Offset: 0x000FD5D8
			public Class2064.Class878 method_1()
			{
				return new Class2064.Class878(this.class2064_0);
			}

			// Token: 0x06002AD2 RID: 10962 RVA: 0x000FF3F4 File Offset: 0x000FD5F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400145D RID: 5213
			private Class2064 class2064_0;
		}

		// Token: 0x02000699 RID: 1689
		public sealed class Class878 : IEnumerator
		{
			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000FF40C File Offset: 0x000FD60C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002AD5 RID: 10965 RVA: 0x000175D3 File Offset: 0x000157D3
			public Class878(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
				this.int_0 = -1;
			}

			// Token: 0x06002AD6 RID: 10966 RVA: 0x000175E9 File Offset: 0x000157E9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002AD7 RID: 10967 RVA: 0x000175F2 File Offset: 0x000157F2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2064_0.method_8();
			}

			// Token: 0x06002AD8 RID: 10968 RVA: 0x000FF424 File Offset: 0x000FD624
			public Class2062 method_0()
			{
				return this.class2064_0.method_9(this.int_0);
			}

			// Token: 0x0400145E RID: 5214
			private int int_0;

			// Token: 0x0400145F RID: 5215
			private Class2064 class2064_0;
		}

		// Token: 0x0200069A RID: 1690
		public sealed class Class879 : IEnumerable
		{
			// Token: 0x06002AD9 RID: 10969 RVA: 0x00017615 File Offset: 0x00015815
			public void method_0(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
			}

			// Token: 0x06002ADA RID: 10970 RVA: 0x000FF444 File Offset: 0x000FD644
			public Class2064.Class880 method_1()
			{
				return new Class2064.Class880(this.class2064_0);
			}

			// Token: 0x06002ADB RID: 10971 RVA: 0x000FF460 File Offset: 0x000FD660
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001460 RID: 5216
			private Class2064 class2064_0;
		}

		// Token: 0x0200069B RID: 1691
		public sealed class Class880 : IEnumerator
		{
			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000FF478 File Offset: 0x000FD678
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002ADE RID: 10974 RVA: 0x0001761E File Offset: 0x0001581E
			public Class880(Class2064 class2064_1)
			{
				this.class2064_0 = class2064_1;
				this.int_0 = -1;
			}

			// Token: 0x06002ADF RID: 10975 RVA: 0x00017634 File Offset: 0x00015834
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002AE0 RID: 10976 RVA: 0x0001763D File Offset: 0x0001583D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2064_0.method_10();
			}

			// Token: 0x06002AE1 RID: 10977 RVA: 0x000FF490 File Offset: 0x000FD690
			public Class2064 method_0()
			{
				return this.class2064_0.method_11(this.int_0);
			}

			// Token: 0x04001461 RID: 5217
			private int int_0;

			// Token: 0x04001462 RID: 5218
			private Class2064 class2064_0;
		}
	}
}
