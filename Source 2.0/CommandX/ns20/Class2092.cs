using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x0200088A RID: 2186
	public sealed class Class2092 : Class2059
	{
		// Token: 0x060035E8 RID: 13800 RVA: 0x0011DC4C File Offset: 0x0011BE4C
		public Class2092()
		{
			this.method_20();
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x0011DCC8 File Offset: 0x0011BEC8
		public Class2092(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_20();
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0011CD24 File Offset: 0x0011AF24
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinDisplayAltitude");
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0011DD48 File Offset: 0x0011BF48
		public Class2036 method_9(int int_0)
		{
			return new Class2036(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinDisplayAltitude", int_0)));
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0011CD70 File Offset: 0x0011AF70
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaxDisplayAltitude");
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0011DD74 File Offset: 0x0011BF74
		public Class2030 method_11(int int_0)
		{
			return new Class2030(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaxDisplayAltitude", int_0)));
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0011CDBC File Offset: 0x0011AFBC
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PathsDirectory");
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0011CDDC File Offset: 0x0011AFDC
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "PathsDirectory", int_0)));
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0011CE08 File Offset: 0x0011B008
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RGBColor");
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0011CE28 File Offset: 0x0011B028
		public Class2096 method_15(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "RGBColor", int_0));
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0011CE50 File Offset: 0x0011B050
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WinColorName");
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0011CE70 File Offset: 0x0011B070
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WinColorName", int_0)));
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_19(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x0011DDA0 File Offset: 0x0011BFA0
		private void method_20()
		{
			this.class1169_0.method_0(this);
			this.class1171_0.method_0(this);
			this.class1173_0.method_0(this);
			this.class1175_0.method_0(this);
			this.class1177_0.method_0(this);
			this.class1179_0.method_0(this);
			this.class1181_0.method_0(this);
			this.class1183_0.method_0(this);
			this.class1185_0.method_0(this);
		}

		// Token: 0x040018E4 RID: 6372
		public Class2092.Class1169 class1169_0 = new Class2092.Class1169();

		// Token: 0x040018E5 RID: 6373
		public Class2092.Class1171 class1171_0 = new Class2092.Class1171();

		// Token: 0x040018E6 RID: 6374
		public Class2092.Class1173 class1173_0 = new Class2092.Class1173();

		// Token: 0x040018E7 RID: 6375
		public Class2092.Class1175 class1175_0 = new Class2092.Class1175();

		// Token: 0x040018E8 RID: 6376
		public Class2092.Class1177 class1177_0 = new Class2092.Class1177();

		// Token: 0x040018E9 RID: 6377
		public Class2092.Class1179 class1179_0 = new Class2092.Class1179();

		// Token: 0x040018EA RID: 6378
		public Class2092.Class1181 class1181_0 = new Class2092.Class1181();

		// Token: 0x040018EB RID: 6379
		public Class2092.Class1183 class1183_0 = new Class2092.Class1183();

		// Token: 0x040018EC RID: 6380
		public Class2092.Class1185 class1185_0 = new Class2092.Class1185();

		// Token: 0x0200088B RID: 2187
		public sealed class Class1169 : IEnumerable
		{
			// Token: 0x060035FD RID: 13821 RVA: 0x0001CCF9 File Offset: 0x0001AEF9
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x060035FE RID: 13822 RVA: 0x0011DE1C File Offset: 0x0011C01C
			public Class2092.Class1170 method_1()
			{
				return new Class2092.Class1170(this.class2092_0);
			}

			// Token: 0x060035FF RID: 13823 RVA: 0x0011DE38 File Offset: 0x0011C038
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018ED RID: 6381
			private Class2092 class2092_0;
		}

		// Token: 0x0200088C RID: 2188
		public sealed class Class1170 : IEnumerator
		{
			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06003601 RID: 13825 RVA: 0x0011DE50 File Offset: 0x0011C050
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003602 RID: 13826 RVA: 0x0001CD02 File Offset: 0x0001AF02
			public Class1170(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003603 RID: 13827 RVA: 0x0001CD18 File Offset: 0x0001AF18
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003604 RID: 13828 RVA: 0x0001CD21 File Offset: 0x0001AF21
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_2();
			}

			// Token: 0x06003605 RID: 13829 RVA: 0x0011DE68 File Offset: 0x0011C068
			public Class2009 method_0()
			{
				return this.class2092_0.method_3(this.int_0);
			}

			// Token: 0x040018EE RID: 6382
			private int int_0;

			// Token: 0x040018EF RID: 6383
			private Class2092 class2092_0;
		}

		// Token: 0x0200088D RID: 2189
		public sealed class Class1171 : IEnumerable
		{
			// Token: 0x06003606 RID: 13830 RVA: 0x0001CD44 File Offset: 0x0001AF44
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003607 RID: 13831 RVA: 0x0011DE88 File Offset: 0x0011C088
			public Class2092.Class1172 method_1()
			{
				return new Class2092.Class1172(this.class2092_0);
			}

			// Token: 0x06003608 RID: 13832 RVA: 0x0011DEA4 File Offset: 0x0011C0A4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018F0 RID: 6384
			private Class2092 class2092_0;
		}

		// Token: 0x0200088E RID: 2190
		public sealed class Class1172 : IEnumerator
		{
			// Token: 0x170003DC RID: 988
			// (get) Token: 0x0600360A RID: 13834 RVA: 0x0011DEBC File Offset: 0x0011C0BC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600360B RID: 13835 RVA: 0x0001CD4D File Offset: 0x0001AF4D
			public Class1172(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x0600360C RID: 13836 RVA: 0x0001CD63 File Offset: 0x0001AF63
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600360D RID: 13837 RVA: 0x0001CD6C File Offset: 0x0001AF6C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_4();
			}

			// Token: 0x0600360E RID: 13838 RVA: 0x0011DED4 File Offset: 0x0011C0D4
			public Class2050 method_0()
			{
				return this.class2092_0.method_5(this.int_0);
			}

			// Token: 0x040018F1 RID: 6385
			private int int_0;

			// Token: 0x040018F2 RID: 6386
			private Class2092 class2092_0;
		}

		// Token: 0x0200088F RID: 2191
		public sealed class Class1173 : IEnumerable
		{
			// Token: 0x0600360F RID: 13839 RVA: 0x0001CD8F File Offset: 0x0001AF8F
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003610 RID: 13840 RVA: 0x0011DEF4 File Offset: 0x0011C0F4
			public Class2092.Class1174 method_1()
			{
				return new Class2092.Class1174(this.class2092_0);
			}

			// Token: 0x06003611 RID: 13841 RVA: 0x0011DF10 File Offset: 0x0011C110
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018F3 RID: 6387
			private Class2092 class2092_0;
		}

		// Token: 0x02000890 RID: 2192
		public sealed class Class1174 : IEnumerator
		{
			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06003613 RID: 13843 RVA: 0x0011DF28 File Offset: 0x0011C128
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003614 RID: 13844 RVA: 0x0001CD98 File Offset: 0x0001AF98
			public Class1174(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x0001CDAE File Offset: 0x0001AFAE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x0001CDB7 File Offset: 0x0001AFB7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_6();
			}

			// Token: 0x06003617 RID: 13847 RVA: 0x0011DF40 File Offset: 0x0011C140
			public Class2020 method_0()
			{
				return this.class2092_0.method_7(this.int_0);
			}

			// Token: 0x040018F4 RID: 6388
			private int int_0;

			// Token: 0x040018F5 RID: 6389
			private Class2092 class2092_0;
		}

		// Token: 0x02000891 RID: 2193
		public sealed class Class1175 : IEnumerable
		{
			// Token: 0x06003618 RID: 13848 RVA: 0x0001CDDA File Offset: 0x0001AFDA
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003619 RID: 13849 RVA: 0x0011DF60 File Offset: 0x0011C160
			public Class2092.Class1176 method_1()
			{
				return new Class2092.Class1176(this.class2092_0);
			}

			// Token: 0x0600361A RID: 13850 RVA: 0x0011DF7C File Offset: 0x0011C17C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018F6 RID: 6390
			private Class2092 class2092_0;
		}

		// Token: 0x02000892 RID: 2194
		public sealed class Class1176 : IEnumerator
		{
			// Token: 0x170003DE RID: 990
			// (get) Token: 0x0600361C RID: 13852 RVA: 0x0011DF94 File Offset: 0x0011C194
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600361D RID: 13853 RVA: 0x0001CDE3 File Offset: 0x0001AFE3
			public Class1176(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x0600361E RID: 13854 RVA: 0x0001CDF9 File Offset: 0x0001AFF9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600361F RID: 13855 RVA: 0x0001CE02 File Offset: 0x0001B002
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_8();
			}

			// Token: 0x06003620 RID: 13856 RVA: 0x0011DFAC File Offset: 0x0011C1AC
			public Class2036 method_0()
			{
				return this.class2092_0.method_9(this.int_0);
			}

			// Token: 0x040018F7 RID: 6391
			private int int_0;

			// Token: 0x040018F8 RID: 6392
			private Class2092 class2092_0;
		}

		// Token: 0x02000893 RID: 2195
		public sealed class Class1177 : IEnumerable
		{
			// Token: 0x06003621 RID: 13857 RVA: 0x0001CE25 File Offset: 0x0001B025
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003622 RID: 13858 RVA: 0x0011DFCC File Offset: 0x0011C1CC
			public Class2092.Class1178 method_1()
			{
				return new Class2092.Class1178(this.class2092_0);
			}

			// Token: 0x06003623 RID: 13859 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018F9 RID: 6393
			private Class2092 class2092_0;
		}

		// Token: 0x02000894 RID: 2196
		public sealed class Class1178 : IEnumerator
		{
			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06003625 RID: 13861 RVA: 0x0011E000 File Offset: 0x0011C200
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003626 RID: 13862 RVA: 0x0001CE2E File Offset: 0x0001B02E
			public Class1178(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003627 RID: 13863 RVA: 0x0001CE44 File Offset: 0x0001B044
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003628 RID: 13864 RVA: 0x0001CE4D File Offset: 0x0001B04D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_10();
			}

			// Token: 0x06003629 RID: 13865 RVA: 0x0011E018 File Offset: 0x0011C218
			public Class2030 method_0()
			{
				return this.class2092_0.method_11(this.int_0);
			}

			// Token: 0x040018FA RID: 6394
			private int int_0;

			// Token: 0x040018FB RID: 6395
			private Class2092 class2092_0;
		}

		// Token: 0x02000895 RID: 2197
		public sealed class Class1179 : IEnumerable
		{
			// Token: 0x0600362A RID: 13866 RVA: 0x0001CE70 File Offset: 0x0001B070
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x0600362B RID: 13867 RVA: 0x0011E038 File Offset: 0x0011C238
			public Class2092.Class1180 method_1()
			{
				return new Class2092.Class1180(this.class2092_0);
			}

			// Token: 0x0600362C RID: 13868 RVA: 0x0011E054 File Offset: 0x0011C254
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018FC RID: 6396
			private Class2092 class2092_0;
		}

		// Token: 0x02000896 RID: 2198
		public sealed class Class1180 : IEnumerator
		{
			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x0600362E RID: 13870 RVA: 0x0011E06C File Offset: 0x0011C26C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600362F RID: 13871 RVA: 0x0001CE79 File Offset: 0x0001B079
			public Class1180(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003630 RID: 13872 RVA: 0x0001CE8F File Offset: 0x0001B08F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003631 RID: 13873 RVA: 0x0001CE98 File Offset: 0x0001B098
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_12();
			}

			// Token: 0x06003632 RID: 13874 RVA: 0x0011E084 File Offset: 0x0011C284
			public Class2050 method_0()
			{
				return this.class2092_0.method_13(this.int_0);
			}

			// Token: 0x040018FD RID: 6397
			private int int_0;

			// Token: 0x040018FE RID: 6398
			private Class2092 class2092_0;
		}

		// Token: 0x02000897 RID: 2199
		public sealed class Class1181 : IEnumerable
		{
			// Token: 0x06003633 RID: 13875 RVA: 0x0001CEBB File Offset: 0x0001B0BB
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003634 RID: 13876 RVA: 0x0011E0A4 File Offset: 0x0011C2A4
			public Class2092.Class1182 method_1()
			{
				return new Class2092.Class1182(this.class2092_0);
			}

			// Token: 0x06003635 RID: 13877 RVA: 0x0011E0C0 File Offset: 0x0011C2C0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018FF RID: 6399
			private Class2092 class2092_0;
		}

		// Token: 0x02000898 RID: 2200
		public sealed class Class1182 : IEnumerator
		{
			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06003637 RID: 13879 RVA: 0x0011E0D8 File Offset: 0x0011C2D8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003638 RID: 13880 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
			public Class1182(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003639 RID: 13881 RVA: 0x0001CEDA File Offset: 0x0001B0DA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600363A RID: 13882 RVA: 0x0001CEE3 File Offset: 0x0001B0E3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_14();
			}

			// Token: 0x0600363B RID: 13883 RVA: 0x0011E0F0 File Offset: 0x0011C2F0
			public Class2096 method_0()
			{
				return this.class2092_0.method_15(this.int_0);
			}

			// Token: 0x04001900 RID: 6400
			private int int_0;

			// Token: 0x04001901 RID: 6401
			private Class2092 class2092_0;
		}

		// Token: 0x02000899 RID: 2201
		public sealed class Class1183 : IEnumerable
		{
			// Token: 0x0600363C RID: 13884 RVA: 0x0001CF06 File Offset: 0x0001B106
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x0600363D RID: 13885 RVA: 0x0011E110 File Offset: 0x0011C310
			public Class2092.Class1184 method_1()
			{
				return new Class2092.Class1184(this.class2092_0);
			}

			// Token: 0x0600363E RID: 13886 RVA: 0x0011E12C File Offset: 0x0011C32C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001902 RID: 6402
			private Class2092 class2092_0;
		}

		// Token: 0x0200089A RID: 2202
		public sealed class Class1184 : IEnumerator
		{
			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06003640 RID: 13888 RVA: 0x0011E144 File Offset: 0x0011C344
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003641 RID: 13889 RVA: 0x0001CF0F File Offset: 0x0001B10F
			public Class1184(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x06003642 RID: 13890 RVA: 0x0001CF25 File Offset: 0x0001B125
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003643 RID: 13891 RVA: 0x0001CF2E File Offset: 0x0001B12E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_16();
			}

			// Token: 0x06003644 RID: 13892 RVA: 0x0011E15C File Offset: 0x0011C35C
			public Class2050 method_0()
			{
				return this.class2092_0.method_17(this.int_0);
			}

			// Token: 0x04001903 RID: 6403
			private int int_0;

			// Token: 0x04001904 RID: 6404
			private Class2092 class2092_0;
		}

		// Token: 0x0200089B RID: 2203
		public sealed class Class1185 : IEnumerable
		{
			// Token: 0x06003645 RID: 13893 RVA: 0x0001CF51 File Offset: 0x0001B151
			public void method_0(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
			}

			// Token: 0x06003646 RID: 13894 RVA: 0x0011E17C File Offset: 0x0011C37C
			public Class2092.Class1186 method_1()
			{
				return new Class2092.Class1186(this.class2092_0);
			}

			// Token: 0x06003647 RID: 13895 RVA: 0x0011E198 File Offset: 0x0011C398
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001905 RID: 6405
			private Class2092 class2092_0;
		}

		// Token: 0x0200089C RID: 2204
		public sealed class Class1186 : IEnumerator
		{
			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06003649 RID: 13897 RVA: 0x0011E1B0 File Offset: 0x0011C3B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600364A RID: 13898 RVA: 0x0001CF5A File Offset: 0x0001B15A
			public Class1186(Class2092 class2092_1)
			{
				this.class2092_0 = class2092_1;
				this.int_0 = -1;
			}

			// Token: 0x0600364B RID: 13899 RVA: 0x0001CF70 File Offset: 0x0001B170
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600364C RID: 13900 RVA: 0x0001CF79 File Offset: 0x0001B179
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2092_0.method_18();
			}

			// Token: 0x0600364D RID: 13901 RVA: 0x0011E1C8 File Offset: 0x0011C3C8
			public Class2074 method_0()
			{
				return this.class2092_0.method_19(this.int_0);
			}

			// Token: 0x04001906 RID: 6406
			private int int_0;

			// Token: 0x04001907 RID: 6407
			private Class2092 class2092_0;
		}
	}
}
