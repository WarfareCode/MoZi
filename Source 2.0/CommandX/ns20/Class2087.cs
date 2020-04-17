using System;
using System.Collections;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x02000829 RID: 2089
	public sealed class Class2087 : Class2059
	{
		// Token: 0x06003386 RID: 13190 RVA: 0x0011A25C File Offset: 0x0011845C
		public Class2087()
		{
			this.method_24();
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x0011A2F0 File Offset: 0x001184F0
		public Class2026 method_7(int int_0)
		{
			return new Class2026(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x001065DC File Offset: 0x001047DC
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Latitude");
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x001065FC File Offset: 0x001047FC
		public Class2081 method_9(int int_0)
		{
			return new Class2081(base.method_1(Class2059.Enum155.const_1, "", "Latitude", int_0));
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00106624 File Offset: 0x00104824
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Longitude");
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00106644 File Offset: 0x00104844
		public Class2086 method_11(int int_0)
		{
			return new Class2086(base.method_1(Class2059.Enum155.const_1, "", "Longitude", int_0));
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0011A31C File Offset: 0x0011851C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Orientation");
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x0011A33C File Offset: 0x0011853C
		public Class2090 method_13(int int_0)
		{
			return new Class2090(base.method_1(Class2059.Enum155.const_1, "", "Orientation", int_0));
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0011A364 File Offset: 0x00118564
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ScaleFactor");
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0011A384 File Offset: 0x00118584
		public Class2041 method_15(int int_0)
		{
			return new Class2041(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ScaleFactor", int_0)));
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x0011A3B0 File Offset: 0x001185B0
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinViewRange");
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x0011A3D0 File Offset: 0x001185D0
		public Class2039 method_17(int int_0)
		{
			return new Class2039(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinViewRange", int_0)));
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x0011A3FC File Offset: 0x001185FC
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaxViewRange");
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0011A41C File Offset: 0x0011861C
		public Class2033 method_19(int int_0)
		{
			return new Class2033(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaxViewRange", int_0)));
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0011A448 File Offset: 0x00118648
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MeshFilePath");
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0011A468 File Offset: 0x00118668
		public Class2051 method_21(int int_0)
		{
			return new Class2051(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MeshFilePath", int_0)));
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_23(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x0011A494 File Offset: 0x00118694
		private void method_24()
		{
			this.class1095_0.method_0(this);
			this.class1097_0.method_0(this);
			this.class1099_0.method_0(this);
			this.class1101_0.method_0(this);
			this.class1103_0.method_0(this);
			this.class1105_0.method_0(this);
			this.class1107_0.method_0(this);
			this.class1109_0.method_0(this);
			this.class1111_0.method_0(this);
			this.class1113_0.method_0(this);
			this.class1115_0.method_0(this);
		}

		// Token: 0x040017F4 RID: 6132
		public Class2087.Class1095 class1095_0 = new Class2087.Class1095();

		// Token: 0x040017F5 RID: 6133
		public Class2087.Class1097 class1097_0 = new Class2087.Class1097();

		// Token: 0x040017F6 RID: 6134
		public Class2087.Class1099 class1099_0 = new Class2087.Class1099();

		// Token: 0x040017F7 RID: 6135
		public Class2087.Class1101 class1101_0 = new Class2087.Class1101();

		// Token: 0x040017F8 RID: 6136
		public Class2087.Class1103 class1103_0 = new Class2087.Class1103();

		// Token: 0x040017F9 RID: 6137
		public Class2087.Class1105 class1105_0 = new Class2087.Class1105();

		// Token: 0x040017FA RID: 6138
		public Class2087.Class1107 class1107_0 = new Class2087.Class1107();

		// Token: 0x040017FB RID: 6139
		public Class2087.Class1109 class1109_0 = new Class2087.Class1109();

		// Token: 0x040017FC RID: 6140
		public Class2087.Class1111 class1111_0 = new Class2087.Class1111();

		// Token: 0x040017FD RID: 6141
		public Class2087.Class1113 class1113_0 = new Class2087.Class1113();

		// Token: 0x040017FE RID: 6142
		public Class2087.Class1115 class1115_0 = new Class2087.Class1115();

		// Token: 0x0200082A RID: 2090
		public sealed class Class1095 : IEnumerable
		{
			// Token: 0x0600339E RID: 13214 RVA: 0x0001B95F File Offset: 0x00019B5F
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x0600339F RID: 13215 RVA: 0x0011A528 File Offset: 0x00118728
			public Class2087.Class1096 method_1()
			{
				return new Class2087.Class1096(this.class2087_0);
			}

			// Token: 0x060033A0 RID: 13216 RVA: 0x0011A544 File Offset: 0x00118744
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040017FF RID: 6143
			private Class2087 class2087_0;
		}

		// Token: 0x0200082B RID: 2091
		public sealed class Class1096 : IEnumerator
		{
			// Token: 0x17000388 RID: 904
			// (get) Token: 0x060033A2 RID: 13218 RVA: 0x0011A55C File Offset: 0x0011875C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033A3 RID: 13219 RVA: 0x0001B968 File Offset: 0x00019B68
			public Class1096(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033A4 RID: 13220 RVA: 0x0001B97E File Offset: 0x00019B7E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033A5 RID: 13221 RVA: 0x0001B987 File Offset: 0x00019B87
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_2();
			}

			// Token: 0x060033A6 RID: 13222 RVA: 0x0011A574 File Offset: 0x00118774
			public Class2009 method_0()
			{
				return this.class2087_0.method_3(this.int_0);
			}

			// Token: 0x04001800 RID: 6144
			private int int_0;

			// Token: 0x04001801 RID: 6145
			private Class2087 class2087_0;
		}

		// Token: 0x0200082C RID: 2092
		public sealed class Class1097 : IEnumerable
		{
			// Token: 0x060033A7 RID: 13223 RVA: 0x0001B9AA File Offset: 0x00019BAA
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033A8 RID: 13224 RVA: 0x0011A594 File Offset: 0x00118794
			public Class2087.Class1098 method_1()
			{
				return new Class2087.Class1098(this.class2087_0);
			}

			// Token: 0x060033A9 RID: 13225 RVA: 0x0011A5B0 File Offset: 0x001187B0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001802 RID: 6146
			private Class2087 class2087_0;
		}

		// Token: 0x0200082D RID: 2093
		public sealed class Class1098 : IEnumerator
		{
			// Token: 0x17000389 RID: 905
			// (get) Token: 0x060033AB RID: 13227 RVA: 0x0011A5C8 File Offset: 0x001187C8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033AC RID: 13228 RVA: 0x0001B9B3 File Offset: 0x00019BB3
			public Class1098(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033AD RID: 13229 RVA: 0x0001B9C9 File Offset: 0x00019BC9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033AE RID: 13230 RVA: 0x0001B9D2 File Offset: 0x00019BD2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_4();
			}

			// Token: 0x060033AF RID: 13231 RVA: 0x0011A5E0 File Offset: 0x001187E0
			public Class2050 method_0()
			{
				return this.class2087_0.method_5(this.int_0);
			}

			// Token: 0x04001803 RID: 6147
			private int int_0;

			// Token: 0x04001804 RID: 6148
			private Class2087 class2087_0;
		}

		// Token: 0x0200082E RID: 2094
		public sealed class Class1099 : IEnumerable
		{
			// Token: 0x060033B0 RID: 13232 RVA: 0x0001B9F5 File Offset: 0x00019BF5
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033B1 RID: 13233 RVA: 0x0011A600 File Offset: 0x00118800
			public Class2087.Class1100 method_1()
			{
				return new Class2087.Class1100(this.class2087_0);
			}

			// Token: 0x060033B2 RID: 13234 RVA: 0x0011A61C File Offset: 0x0011881C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001805 RID: 6149
			private Class2087 class2087_0;
		}

		// Token: 0x0200082F RID: 2095
		public sealed class Class1100 : IEnumerator
		{
			// Token: 0x1700038A RID: 906
			// (get) Token: 0x060033B4 RID: 13236 RVA: 0x0011A634 File Offset: 0x00118834
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033B5 RID: 13237 RVA: 0x0001B9FE File Offset: 0x00019BFE
			public Class1100(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033B6 RID: 13238 RVA: 0x0001BA14 File Offset: 0x00019C14
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033B7 RID: 13239 RVA: 0x0001BA1D File Offset: 0x00019C1D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_6();
			}

			// Token: 0x060033B8 RID: 13240 RVA: 0x0011A64C File Offset: 0x0011884C
			public Class2026 method_0()
			{
				return this.class2087_0.method_7(this.int_0);
			}

			// Token: 0x04001806 RID: 6150
			private int int_0;

			// Token: 0x04001807 RID: 6151
			private Class2087 class2087_0;
		}

		// Token: 0x02000830 RID: 2096
		public sealed class Class1101 : IEnumerable
		{
			// Token: 0x060033B9 RID: 13241 RVA: 0x0001BA40 File Offset: 0x00019C40
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033BA RID: 13242 RVA: 0x0011A66C File Offset: 0x0011886C
			public Class2087.Class1102 method_1()
			{
				return new Class2087.Class1102(this.class2087_0);
			}

			// Token: 0x060033BB RID: 13243 RVA: 0x0011A688 File Offset: 0x00118888
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001808 RID: 6152
			private Class2087 class2087_0;
		}

		// Token: 0x02000831 RID: 2097
		public sealed class Class1102 : IEnumerator
		{
			// Token: 0x1700038B RID: 907
			// (get) Token: 0x060033BD RID: 13245 RVA: 0x0011A6A0 File Offset: 0x001188A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033BE RID: 13246 RVA: 0x0001BA49 File Offset: 0x00019C49
			public Class1102(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033BF RID: 13247 RVA: 0x0001BA5F File Offset: 0x00019C5F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033C0 RID: 13248 RVA: 0x0001BA68 File Offset: 0x00019C68
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_8();
			}

			// Token: 0x060033C1 RID: 13249 RVA: 0x0011A6B8 File Offset: 0x001188B8
			public Class2081 method_0()
			{
				return this.class2087_0.method_9(this.int_0);
			}

			// Token: 0x04001809 RID: 6153
			private int int_0;

			// Token: 0x0400180A RID: 6154
			private Class2087 class2087_0;
		}

		// Token: 0x02000832 RID: 2098
		public sealed class Class1103 : IEnumerable
		{
			// Token: 0x060033C2 RID: 13250 RVA: 0x0001BA8B File Offset: 0x00019C8B
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033C3 RID: 13251 RVA: 0x0011A6D8 File Offset: 0x001188D8
			public Class2087.Class1104 method_1()
			{
				return new Class2087.Class1104(this.class2087_0);
			}

			// Token: 0x060033C4 RID: 13252 RVA: 0x0011A6F4 File Offset: 0x001188F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400180B RID: 6155
			private Class2087 class2087_0;
		}

		// Token: 0x02000833 RID: 2099
		public sealed class Class1104 : IEnumerator
		{
			// Token: 0x1700038C RID: 908
			// (get) Token: 0x060033C6 RID: 13254 RVA: 0x0011A70C File Offset: 0x0011890C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033C7 RID: 13255 RVA: 0x0001BA94 File Offset: 0x00019C94
			public Class1104(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033C8 RID: 13256 RVA: 0x0001BAAA File Offset: 0x00019CAA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033C9 RID: 13257 RVA: 0x0001BAB3 File Offset: 0x00019CB3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_10();
			}

			// Token: 0x060033CA RID: 13258 RVA: 0x0011A724 File Offset: 0x00118924
			public Class2086 method_0()
			{
				return this.class2087_0.method_11(this.int_0);
			}

			// Token: 0x0400180C RID: 6156
			private int int_0;

			// Token: 0x0400180D RID: 6157
			private Class2087 class2087_0;
		}

		// Token: 0x02000834 RID: 2100
		public sealed class Class1105 : IEnumerable
		{
			// Token: 0x060033CB RID: 13259 RVA: 0x0001BAD6 File Offset: 0x00019CD6
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033CC RID: 13260 RVA: 0x0011A744 File Offset: 0x00118944
			public Class2087.Class1106 method_1()
			{
				return new Class2087.Class1106(this.class2087_0);
			}

			// Token: 0x060033CD RID: 13261 RVA: 0x0011A760 File Offset: 0x00118960
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400180E RID: 6158
			private Class2087 class2087_0;
		}

		// Token: 0x02000835 RID: 2101
		public sealed class Class1106 : IEnumerator
		{
			// Token: 0x1700038D RID: 909
			// (get) Token: 0x060033CF RID: 13263 RVA: 0x0011A778 File Offset: 0x00118978
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033D0 RID: 13264 RVA: 0x0001BADF File Offset: 0x00019CDF
			public Class1106(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033D1 RID: 13265 RVA: 0x0001BAF5 File Offset: 0x00019CF5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033D2 RID: 13266 RVA: 0x0001BAFE File Offset: 0x00019CFE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_12();
			}

			// Token: 0x060033D3 RID: 13267 RVA: 0x0011A790 File Offset: 0x00118990
			public Class2090 method_0()
			{
				return this.class2087_0.method_13(this.int_0);
			}

			// Token: 0x0400180F RID: 6159
			private int int_0;

			// Token: 0x04001810 RID: 6160
			private Class2087 class2087_0;
		}

		// Token: 0x02000836 RID: 2102
		public sealed class Class1107 : IEnumerable
		{
			// Token: 0x060033D4 RID: 13268 RVA: 0x0001BB21 File Offset: 0x00019D21
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033D5 RID: 13269 RVA: 0x0011A7B0 File Offset: 0x001189B0
			public Class2087.Class1108 method_1()
			{
				return new Class2087.Class1108(this.class2087_0);
			}

			// Token: 0x060033D6 RID: 13270 RVA: 0x0011A7CC File Offset: 0x001189CC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001811 RID: 6161
			private Class2087 class2087_0;
		}

		// Token: 0x02000837 RID: 2103
		public sealed class Class1108 : IEnumerator
		{
			// Token: 0x1700038E RID: 910
			// (get) Token: 0x060033D8 RID: 13272 RVA: 0x0011A7E4 File Offset: 0x001189E4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033D9 RID: 13273 RVA: 0x0001BB2A File Offset: 0x00019D2A
			public Class1108(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033DA RID: 13274 RVA: 0x0001BB40 File Offset: 0x00019D40
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033DB RID: 13275 RVA: 0x0001BB49 File Offset: 0x00019D49
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_14();
			}

			// Token: 0x060033DC RID: 13276 RVA: 0x0011A7FC File Offset: 0x001189FC
			public Class2041 method_0()
			{
				return this.class2087_0.method_15(this.int_0);
			}

			// Token: 0x04001812 RID: 6162
			private int int_0;

			// Token: 0x04001813 RID: 6163
			private Class2087 class2087_0;
		}

		// Token: 0x02000838 RID: 2104
		public sealed class Class1109 : IEnumerable
		{
			// Token: 0x060033DD RID: 13277 RVA: 0x0001BB6C File Offset: 0x00019D6C
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033DE RID: 13278 RVA: 0x0011A81C File Offset: 0x00118A1C
			public Class2087.Class1110 method_1()
			{
				return new Class2087.Class1110(this.class2087_0);
			}

			// Token: 0x060033DF RID: 13279 RVA: 0x0011A838 File Offset: 0x00118A38
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001814 RID: 6164
			private Class2087 class2087_0;
		}

		// Token: 0x02000839 RID: 2105
		public sealed class Class1110 : IEnumerator
		{
			// Token: 0x1700038F RID: 911
			// (get) Token: 0x060033E1 RID: 13281 RVA: 0x0011A850 File Offset: 0x00118A50
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033E2 RID: 13282 RVA: 0x0001BB75 File Offset: 0x00019D75
			public Class1110(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033E3 RID: 13283 RVA: 0x0001BB8B File Offset: 0x00019D8B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033E4 RID: 13284 RVA: 0x0001BB94 File Offset: 0x00019D94
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_16();
			}

			// Token: 0x060033E5 RID: 13285 RVA: 0x0011A868 File Offset: 0x00118A68
			public Class2039 method_0()
			{
				return this.class2087_0.method_17(this.int_0);
			}

			// Token: 0x04001815 RID: 6165
			private int int_0;

			// Token: 0x04001816 RID: 6166
			private Class2087 class2087_0;
		}

		// Token: 0x0200083A RID: 2106
		public sealed class Class1111 : IEnumerable
		{
			// Token: 0x060033E6 RID: 13286 RVA: 0x0001BBB7 File Offset: 0x00019DB7
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033E7 RID: 13287 RVA: 0x0011A888 File Offset: 0x00118A88
			public Class2087.Class1112 method_1()
			{
				return new Class2087.Class1112(this.class2087_0);
			}

			// Token: 0x060033E8 RID: 13288 RVA: 0x0011A8A4 File Offset: 0x00118AA4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001817 RID: 6167
			private Class2087 class2087_0;
		}

		// Token: 0x0200083B RID: 2107
		public sealed class Class1112 : IEnumerator
		{
			// Token: 0x17000390 RID: 912
			// (get) Token: 0x060033EA RID: 13290 RVA: 0x0011A8BC File Offset: 0x00118ABC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033EB RID: 13291 RVA: 0x0001BBC0 File Offset: 0x00019DC0
			public Class1112(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033EC RID: 13292 RVA: 0x0001BBD6 File Offset: 0x00019DD6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033ED RID: 13293 RVA: 0x0001BBDF File Offset: 0x00019DDF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_18();
			}

			// Token: 0x060033EE RID: 13294 RVA: 0x0011A8D4 File Offset: 0x00118AD4
			public Class2033 method_0()
			{
				return this.class2087_0.method_19(this.int_0);
			}

			// Token: 0x04001818 RID: 6168
			private int int_0;

			// Token: 0x04001819 RID: 6169
			private Class2087 class2087_0;
		}

		// Token: 0x0200083C RID: 2108
		public sealed class Class1113 : IEnumerable
		{
			// Token: 0x060033EF RID: 13295 RVA: 0x0001BC02 File Offset: 0x00019E02
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033F0 RID: 13296 RVA: 0x0011A8F4 File Offset: 0x00118AF4
			public Class2087.Class1114 method_1()
			{
				return new Class2087.Class1114(this.class2087_0);
			}

			// Token: 0x060033F1 RID: 13297 RVA: 0x0011A910 File Offset: 0x00118B10
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400181A RID: 6170
			private Class2087 class2087_0;
		}

		// Token: 0x0200083D RID: 2109
		public sealed class Class1114 : IEnumerator
		{
			// Token: 0x17000391 RID: 913
			// (get) Token: 0x060033F3 RID: 13299 RVA: 0x0011A928 File Offset: 0x00118B28
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033F4 RID: 13300 RVA: 0x0001BC0B File Offset: 0x00019E0B
			public Class1114(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033F5 RID: 13301 RVA: 0x0001BC21 File Offset: 0x00019E21
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033F6 RID: 13302 RVA: 0x0001BC2A File Offset: 0x00019E2A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_20();
			}

			// Token: 0x060033F7 RID: 13303 RVA: 0x0011A940 File Offset: 0x00118B40
			public Class2051 method_0()
			{
				return this.class2087_0.method_21(this.int_0);
			}

			// Token: 0x0400181B RID: 6171
			private int int_0;

			// Token: 0x0400181C RID: 6172
			private Class2087 class2087_0;
		}

		// Token: 0x0200083E RID: 2110
		public sealed class Class1115 : IEnumerable
		{
			// Token: 0x060033F8 RID: 13304 RVA: 0x0001BC4D File Offset: 0x00019E4D
			public void method_0(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x0011A960 File Offset: 0x00118B60
			public Class2087.Class1116 method_1()
			{
				return new Class2087.Class1116(this.class2087_0);
			}

			// Token: 0x060033FA RID: 13306 RVA: 0x0011A97C File Offset: 0x00118B7C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400181D RID: 6173
			private Class2087 class2087_0;
		}

		// Token: 0x0200083F RID: 2111
		public sealed class Class1116 : IEnumerator
		{
			// Token: 0x17000392 RID: 914
			// (get) Token: 0x060033FC RID: 13308 RVA: 0x0011A994 File Offset: 0x00118B94
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060033FD RID: 13309 RVA: 0x0001BC56 File Offset: 0x00019E56
			public Class1116(Class2087 class2087_1)
			{
				this.class2087_0 = class2087_1;
				this.int_0 = -1;
			}

			// Token: 0x060033FE RID: 13310 RVA: 0x0001BC6C File Offset: 0x00019E6C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060033FF RID: 13311 RVA: 0x0001BC75 File Offset: 0x00019E75
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2087_0.method_22();
			}

			// Token: 0x06003400 RID: 13312 RVA: 0x0011A9AC File Offset: 0x00118BAC
			public Class2074 method_0()
			{
				return this.class2087_0.method_23(this.int_0);
			}

			// Token: 0x0400181E RID: 6174
			private int int_0;

			// Token: 0x0400181F RID: 6175
			private Class2087 class2087_0;
		}
	}
}
