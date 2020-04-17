using System;
using System.Collections;
using ns16;
using ns17;
using ns20;

namespace ns21
{
	// Token: 0x02000931 RID: 2353
	public sealed class Class2101 : Class2059
	{
		// Token: 0x060039C4 RID: 14788 RVA: 0x001224C0 File Offset: 0x001206C0
		public Class2101()
		{
			this.method_24();
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x001066B8 File Offset: 0x001048B8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude");
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00122554 File Offset: 0x00120754
		public Class2037 method_9(int int_0)
		{
			return new Class2037(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude", int_0)));
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00106704 File Offset: 0x00104904
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude");
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00122580 File Offset: 0x00120780
		public Class2031 method_11(int int_0)
		{
			return new Class2031(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude", int_0)));
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x001225AC File Offset: 0x001207AC
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PlacenameListFilePath");
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x001225CC File Offset: 0x001207CC
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "PlacenameListFilePath", int_0)));
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00103FFC File Offset: 0x001021FC
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DisplayFont");
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x0010401C File Offset: 0x0010221C
		public Class2073 method_15(int int_0)
		{
			return new Class2073(base.method_1(Class2059.Enum155.const_1, "", "DisplayFont", int_0));
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x0011CE08 File Offset: 0x0011B008
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RGBColor");
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0011CE28 File Offset: 0x0011B028
		public Class2096 method_17(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "RGBColor", int_0));
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x0011CE50 File Offset: 0x0011B050
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WinColorName");
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0011CE70 File Offset: 0x0011B070
		public Class2050 method_19(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WinColorName", int_0)));
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x001225F8 File Offset: 0x001207F8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IconFilePath");
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00122618 File Offset: 0x00120818
		public Class2050 method_21(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IconFilePath", int_0)));
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_23(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00122644 File Offset: 0x00120844
		private void method_24()
		{
			this.class1315_0.method_0(this);
			this.class1317_0.method_0(this);
			this.class1319_0.method_0(this);
			this.class1321_0.method_0(this);
			this.class1323_0.method_0(this);
			this.class1325_0.method_0(this);
			this.class1327_0.method_0(this);
			this.class1329_0.method_0(this);
			this.class1331_0.method_0(this);
			this.class1333_0.method_0(this);
			this.class1335_0.method_0(this);
		}

		// Token: 0x04001A71 RID: 6769
		public Class2101.Class1315 class1315_0 = new Class2101.Class1315();

		// Token: 0x04001A72 RID: 6770
		public Class2101.Class1317 class1317_0 = new Class2101.Class1317();

		// Token: 0x04001A73 RID: 6771
		public Class2101.Class1319 class1319_0 = new Class2101.Class1319();

		// Token: 0x04001A74 RID: 6772
		public Class2101.Class1321 class1321_0 = new Class2101.Class1321();

		// Token: 0x04001A75 RID: 6773
		public Class2101.Class1323 class1323_0 = new Class2101.Class1323();

		// Token: 0x04001A76 RID: 6774
		public Class2101.Class1325 class1325_0 = new Class2101.Class1325();

		// Token: 0x04001A77 RID: 6775
		public Class2101.Class1327 class1327_0 = new Class2101.Class1327();

		// Token: 0x04001A78 RID: 6776
		public Class2101.Class1329 class1329_0 = new Class2101.Class1329();

		// Token: 0x04001A79 RID: 6777
		public Class2101.Class1331 class1331_0 = new Class2101.Class1331();

		// Token: 0x04001A7A RID: 6778
		public Class2101.Class1333 class1333_0 = new Class2101.Class1333();

		// Token: 0x04001A7B RID: 6779
		public Class2101.Class1335 class1335_0 = new Class2101.Class1335();

		// Token: 0x02000932 RID: 2354
		public sealed class Class1315 : IEnumerable
		{
			// Token: 0x060039DC RID: 14812 RVA: 0x0001EB34 File Offset: 0x0001CD34
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x001226D8 File Offset: 0x001208D8
			public Class2101.Class1316 method_1()
			{
				return new Class2101.Class1316(this.class2101_0);
			}

			// Token: 0x060039DE RID: 14814 RVA: 0x001226F4 File Offset: 0x001208F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A7C RID: 6780
			private Class2101 class2101_0;
		}

		// Token: 0x02000933 RID: 2355
		public sealed class Class1316 : IEnumerator
		{
			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0012270C File Offset: 0x0012090C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039E1 RID: 14817 RVA: 0x0001EB3D File Offset: 0x0001CD3D
			public Class1316(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x060039E2 RID: 14818 RVA: 0x0001EB53 File Offset: 0x0001CD53
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039E3 RID: 14819 RVA: 0x0001EB5C File Offset: 0x0001CD5C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_2();
			}

			// Token: 0x060039E4 RID: 14820 RVA: 0x00122724 File Offset: 0x00120924
			public Class2009 method_0()
			{
				return this.class2101_0.method_3(this.int_0);
			}

			// Token: 0x04001A7D RID: 6781
			private int int_0;

			// Token: 0x04001A7E RID: 6782
			private Class2101 class2101_0;
		}

		// Token: 0x02000934 RID: 2356
		public sealed class Class1317 : IEnumerable
		{
			// Token: 0x060039E5 RID: 14821 RVA: 0x0001EB7F File Offset: 0x0001CD7F
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x060039E6 RID: 14822 RVA: 0x00122744 File Offset: 0x00120944
			public Class2101.Class1318 method_1()
			{
				return new Class2101.Class1318(this.class2101_0);
			}

			// Token: 0x060039E7 RID: 14823 RVA: 0x00122760 File Offset: 0x00120960
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A7F RID: 6783
			private Class2101 class2101_0;
		}

		// Token: 0x02000935 RID: 2357
		public sealed class Class1318 : IEnumerator
		{
			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x060039E9 RID: 14825 RVA: 0x00122778 File Offset: 0x00120978
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039EA RID: 14826 RVA: 0x0001EB88 File Offset: 0x0001CD88
			public Class1318(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x060039EB RID: 14827 RVA: 0x0001EB9E File Offset: 0x0001CD9E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039EC RID: 14828 RVA: 0x0001EBA7 File Offset: 0x0001CDA7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_4();
			}

			// Token: 0x060039ED RID: 14829 RVA: 0x00122790 File Offset: 0x00120990
			public Class2050 method_0()
			{
				return this.class2101_0.method_5(this.int_0);
			}

			// Token: 0x04001A80 RID: 6784
			private int int_0;

			// Token: 0x04001A81 RID: 6785
			private Class2101 class2101_0;
		}

		// Token: 0x02000936 RID: 2358
		public sealed class Class1319 : IEnumerable
		{
			// Token: 0x060039EE RID: 14830 RVA: 0x0001EBCA File Offset: 0x0001CDCA
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x060039EF RID: 14831 RVA: 0x001227B0 File Offset: 0x001209B0
			public Class2101.Class1320 method_1()
			{
				return new Class2101.Class1320(this.class2101_0);
			}

			// Token: 0x060039F0 RID: 14832 RVA: 0x001227CC File Offset: 0x001209CC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A82 RID: 6786
			private Class2101 class2101_0;
		}

		// Token: 0x02000937 RID: 2359
		public sealed class Class1320 : IEnumerator
		{
			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x060039F2 RID: 14834 RVA: 0x001227E4 File Offset: 0x001209E4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039F3 RID: 14835 RVA: 0x0001EBD3 File Offset: 0x0001CDD3
			public Class1320(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x060039F4 RID: 14836 RVA: 0x0001EBE9 File Offset: 0x0001CDE9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039F5 RID: 14837 RVA: 0x0001EBF2 File Offset: 0x0001CDF2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_6();
			}

			// Token: 0x060039F6 RID: 14838 RVA: 0x001227FC File Offset: 0x001209FC
			public Class2020 method_0()
			{
				return this.class2101_0.method_7(this.int_0);
			}

			// Token: 0x04001A83 RID: 6787
			private int int_0;

			// Token: 0x04001A84 RID: 6788
			private Class2101 class2101_0;
		}

		// Token: 0x02000938 RID: 2360
		public sealed class Class1321 : IEnumerable
		{
			// Token: 0x060039F7 RID: 14839 RVA: 0x0001EC15 File Offset: 0x0001CE15
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x060039F8 RID: 14840 RVA: 0x0012281C File Offset: 0x00120A1C
			public Class2101.Class1322 method_1()
			{
				return new Class2101.Class1322(this.class2101_0);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x00122838 File Offset: 0x00120A38
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A85 RID: 6789
			private Class2101 class2101_0;
		}

		// Token: 0x02000939 RID: 2361
		public sealed class Class1322 : IEnumerator
		{
			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x060039FB RID: 14843 RVA: 0x00122850 File Offset: 0x00120A50
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x0001EC1E File Offset: 0x0001CE1E
			public Class1322(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x060039FD RID: 14845 RVA: 0x0001EC34 File Offset: 0x0001CE34
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x0001EC3D File Offset: 0x0001CE3D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_8();
			}

			// Token: 0x060039FF RID: 14847 RVA: 0x00122868 File Offset: 0x00120A68
			public Class2037 method_0()
			{
				return this.class2101_0.method_9(this.int_0);
			}

			// Token: 0x04001A86 RID: 6790
			private int int_0;

			// Token: 0x04001A87 RID: 6791
			private Class2101 class2101_0;
		}

		// Token: 0x0200093A RID: 2362
		public sealed class Class1323 : IEnumerable
		{
			// Token: 0x06003A00 RID: 14848 RVA: 0x0001EC60 File Offset: 0x0001CE60
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A01 RID: 14849 RVA: 0x00122888 File Offset: 0x00120A88
			public Class2101.Class1324 method_1()
			{
				return new Class2101.Class1324(this.class2101_0);
			}

			// Token: 0x06003A02 RID: 14850 RVA: 0x001228A4 File Offset: 0x00120AA4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A88 RID: 6792
			private Class2101 class2101_0;
		}

		// Token: 0x0200093B RID: 2363
		public sealed class Class1324 : IEnumerator
		{
			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06003A04 RID: 14852 RVA: 0x001228BC File Offset: 0x00120ABC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A05 RID: 14853 RVA: 0x0001EC69 File Offset: 0x0001CE69
			public Class1324(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A06 RID: 14854 RVA: 0x0001EC7F File Offset: 0x0001CE7F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A07 RID: 14855 RVA: 0x0001EC88 File Offset: 0x0001CE88
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_10();
			}

			// Token: 0x06003A08 RID: 14856 RVA: 0x001228D4 File Offset: 0x00120AD4
			public Class2031 method_0()
			{
				return this.class2101_0.method_11(this.int_0);
			}

			// Token: 0x04001A89 RID: 6793
			private int int_0;

			// Token: 0x04001A8A RID: 6794
			private Class2101 class2101_0;
		}

		// Token: 0x0200093C RID: 2364
		public sealed class Class1325 : IEnumerable
		{
			// Token: 0x06003A09 RID: 14857 RVA: 0x0001ECAB File Offset: 0x0001CEAB
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A0A RID: 14858 RVA: 0x001228F4 File Offset: 0x00120AF4
			public Class2101.Class1326 method_1()
			{
				return new Class2101.Class1326(this.class2101_0);
			}

			// Token: 0x06003A0B RID: 14859 RVA: 0x00122910 File Offset: 0x00120B10
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A8B RID: 6795
			private Class2101 class2101_0;
		}

		// Token: 0x0200093D RID: 2365
		public sealed class Class1326 : IEnumerator
		{
			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00122928 File Offset: 0x00120B28
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
			public Class1326(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A0F RID: 14863 RVA: 0x0001ECCA File Offset: 0x0001CECA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A10 RID: 14864 RVA: 0x0001ECD3 File Offset: 0x0001CED3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_12();
			}

			// Token: 0x06003A11 RID: 14865 RVA: 0x00122940 File Offset: 0x00120B40
			public Class2050 method_0()
			{
				return this.class2101_0.method_13(this.int_0);
			}

			// Token: 0x04001A8C RID: 6796
			private int int_0;

			// Token: 0x04001A8D RID: 6797
			private Class2101 class2101_0;
		}

		// Token: 0x0200093E RID: 2366
		public sealed class Class1327 : IEnumerable
		{
			// Token: 0x06003A12 RID: 14866 RVA: 0x0001ECF6 File Offset: 0x0001CEF6
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A13 RID: 14867 RVA: 0x00122960 File Offset: 0x00120B60
			public Class2101.Class1328 method_1()
			{
				return new Class2101.Class1328(this.class2101_0);
			}

			// Token: 0x06003A14 RID: 14868 RVA: 0x0012297C File Offset: 0x00120B7C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A8E RID: 6798
			private Class2101 class2101_0;
		}

		// Token: 0x0200093F RID: 2367
		public sealed class Class1328 : IEnumerator
		{
			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00122994 File Offset: 0x00120B94
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A17 RID: 14871 RVA: 0x0001ECFF File Offset: 0x0001CEFF
			public Class1328(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A18 RID: 14872 RVA: 0x0001ED15 File Offset: 0x0001CF15
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A19 RID: 14873 RVA: 0x0001ED1E File Offset: 0x0001CF1E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_14();
			}

			// Token: 0x06003A1A RID: 14874 RVA: 0x001229AC File Offset: 0x00120BAC
			public Class2073 method_0()
			{
				return this.class2101_0.method_15(this.int_0);
			}

			// Token: 0x04001A8F RID: 6799
			private int int_0;

			// Token: 0x04001A90 RID: 6800
			private Class2101 class2101_0;
		}

		// Token: 0x02000940 RID: 2368
		public sealed class Class1329 : IEnumerable
		{
			// Token: 0x06003A1B RID: 14875 RVA: 0x0001ED41 File Offset: 0x0001CF41
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A1C RID: 14876 RVA: 0x001229CC File Offset: 0x00120BCC
			public Class2101.Class1330 method_1()
			{
				return new Class2101.Class1330(this.class2101_0);
			}

			// Token: 0x06003A1D RID: 14877 RVA: 0x001229E8 File Offset: 0x00120BE8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A91 RID: 6801
			private Class2101 class2101_0;
		}

		// Token: 0x02000941 RID: 2369
		public sealed class Class1330 : IEnumerator
		{
			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06003A1F RID: 14879 RVA: 0x00122A00 File Offset: 0x00120C00
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A20 RID: 14880 RVA: 0x0001ED4A File Offset: 0x0001CF4A
			public Class1330(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A21 RID: 14881 RVA: 0x0001ED60 File Offset: 0x0001CF60
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A22 RID: 14882 RVA: 0x0001ED69 File Offset: 0x0001CF69
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_16();
			}

			// Token: 0x06003A23 RID: 14883 RVA: 0x00122A18 File Offset: 0x00120C18
			public Class2096 method_0()
			{
				return this.class2101_0.method_17(this.int_0);
			}

			// Token: 0x04001A92 RID: 6802
			private int int_0;

			// Token: 0x04001A93 RID: 6803
			private Class2101 class2101_0;
		}

		// Token: 0x02000942 RID: 2370
		public sealed class Class1331 : IEnumerable
		{
			// Token: 0x06003A24 RID: 14884 RVA: 0x0001ED8C File Offset: 0x0001CF8C
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A25 RID: 14885 RVA: 0x00122A38 File Offset: 0x00120C38
			public Class2101.Class1332 method_1()
			{
				return new Class2101.Class1332(this.class2101_0);
			}

			// Token: 0x06003A26 RID: 14886 RVA: 0x00122A54 File Offset: 0x00120C54
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A94 RID: 6804
			private Class2101 class2101_0;
		}

		// Token: 0x02000943 RID: 2371
		public sealed class Class1332 : IEnumerator
		{
			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06003A28 RID: 14888 RVA: 0x00122A6C File Offset: 0x00120C6C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A29 RID: 14889 RVA: 0x0001ED95 File Offset: 0x0001CF95
			public Class1332(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A2A RID: 14890 RVA: 0x0001EDAB File Offset: 0x0001CFAB
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A2B RID: 14891 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_18();
			}

			// Token: 0x06003A2C RID: 14892 RVA: 0x00122A84 File Offset: 0x00120C84
			public Class2050 method_0()
			{
				return this.class2101_0.method_19(this.int_0);
			}

			// Token: 0x04001A95 RID: 6805
			private int int_0;

			// Token: 0x04001A96 RID: 6806
			private Class2101 class2101_0;
		}

		// Token: 0x02000944 RID: 2372
		public sealed class Class1333 : IEnumerable
		{
			// Token: 0x06003A2D RID: 14893 RVA: 0x0001EDD7 File Offset: 0x0001CFD7
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A2E RID: 14894 RVA: 0x00122AA4 File Offset: 0x00120CA4
			public Class2101.Class1334 method_1()
			{
				return new Class2101.Class1334(this.class2101_0);
			}

			// Token: 0x06003A2F RID: 14895 RVA: 0x00122AC0 File Offset: 0x00120CC0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A97 RID: 6807
			private Class2101 class2101_0;
		}

		// Token: 0x02000945 RID: 2373
		public sealed class Class1334 : IEnumerator
		{
			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00122AD8 File Offset: 0x00120CD8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A32 RID: 14898 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
			public Class1334(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A33 RID: 14899 RVA: 0x0001EDF6 File Offset: 0x0001CFF6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A34 RID: 14900 RVA: 0x0001EDFF File Offset: 0x0001CFFF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_20();
			}

			// Token: 0x06003A35 RID: 14901 RVA: 0x00122AF0 File Offset: 0x00120CF0
			public Class2050 method_0()
			{
				return this.class2101_0.method_21(this.int_0);
			}

			// Token: 0x04001A98 RID: 6808
			private int int_0;

			// Token: 0x04001A99 RID: 6809
			private Class2101 class2101_0;
		}

		// Token: 0x02000946 RID: 2374
		public sealed class Class1335 : IEnumerable
		{
			// Token: 0x06003A36 RID: 14902 RVA: 0x0001EE22 File Offset: 0x0001D022
			public void method_0(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
			}

			// Token: 0x06003A37 RID: 14903 RVA: 0x00122B10 File Offset: 0x00120D10
			public Class2101.Class1336 method_1()
			{
				return new Class2101.Class1336(this.class2101_0);
			}

			// Token: 0x06003A38 RID: 14904 RVA: 0x00122B2C File Offset: 0x00120D2C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A9A RID: 6810
			private Class2101 class2101_0;
		}

		// Token: 0x02000947 RID: 2375
		public sealed class Class1336 : IEnumerator
		{
			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06003A3A RID: 14906 RVA: 0x00122B44 File Offset: 0x00120D44
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003A3B RID: 14907 RVA: 0x0001EE2B File Offset: 0x0001D02B
			public Class1336(Class2101 class2101_1)
			{
				this.class2101_0 = class2101_1;
				this.int_0 = -1;
			}

			// Token: 0x06003A3C RID: 14908 RVA: 0x0001EE41 File Offset: 0x0001D041
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003A3D RID: 14909 RVA: 0x0001EE4A File Offset: 0x0001D04A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2101_0.method_22();
			}

			// Token: 0x06003A3E RID: 14910 RVA: 0x00122B5C File Offset: 0x00120D5C
			public Class2074 method_0()
			{
				return this.class2101_0.method_23(this.int_0);
			}

			// Token: 0x04001A9B RID: 6811
			private int int_0;

			// Token: 0x04001A9C RID: 6812
			private Class2101 class2101_0;
		}
	}
}
