using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;
using ns20;

namespace ns21
{
	// Token: 0x0200094C RID: 2380
	public sealed class Class2102 : Class2059
	{
		// Token: 0x06003A82 RID: 14978 RVA: 0x00123C04 File Offset: 0x00121E04
		public Class2102()
		{
			this.method_24();
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00123C98 File Offset: 0x00121E98
		public Class2102(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x0007D14C File Offset: 0x0007B34C
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001066B8 File Offset: 0x001048B8
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude");
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00123D2C File Offset: 0x00121F2C
		public Class2038 method_9(int int_0)
		{
			return new Class2038(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MinimumDisplayAltitude", int_0)));
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00106704 File Offset: 0x00104904
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude");
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00123D58 File Offset: 0x00121F58
		public Class2032 method_11(int int_0)
		{
			return new Class2032(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "MaximumDisplayAltitude", int_0)));
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x001225AC File Offset: 0x001207AC
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PlacenameListFilePath");
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001225CC File Offset: 0x001207CC
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "PlacenameListFilePath", int_0)));
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00103FFC File Offset: 0x001021FC
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DisplayFont");
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x0010401C File Offset: 0x0010221C
		public Class2073 method_15(int int_0)
		{
			return new Class2073(base.method_1(Class2059.Enum155.const_1, "", "DisplayFont", int_0));
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0011CE08 File Offset: 0x0011B008
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RGBColor");
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x0011CE28 File Offset: 0x0011B028
		public Class2096 method_17(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "RGBColor", int_0));
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0011CE50 File Offset: 0x0011B050
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WinColorName");
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x0011CE70 File Offset: 0x0011B070
		public Class2050 method_19(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WinColorName", int_0)));
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x001225F8 File Offset: 0x001207F8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IconFilePath");
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x00122618 File Offset: 0x00120818
		public Class2050 method_21(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IconFilePath", int_0)));
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_23(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00123D84 File Offset: 0x00121F84
		private void method_24()
		{
			this.class1337_0.method_0(this);
			this.class1339_0.method_0(this);
			this.class1341_0.method_0(this);
			this.class1343_0.method_0(this);
			this.class1345_0.method_0(this);
			this.class1347_0.method_0(this);
			this.class1349_0.method_0(this);
			this.class1351_0.method_0(this);
			this.class1353_0.method_0(this);
			this.class1355_0.method_0(this);
			this.class1357_0.method_0(this);
		}

		// Token: 0x04001ABE RID: 6846
		public Class2102.Class1337 class1337_0 = new Class2102.Class1337();

		// Token: 0x04001ABF RID: 6847
		public Class2102.Class1339 class1339_0 = new Class2102.Class1339();

		// Token: 0x04001AC0 RID: 6848
		public Class2102.Class1341 class1341_0 = new Class2102.Class1341();

		// Token: 0x04001AC1 RID: 6849
		public Class2102.Class1343 class1343_0 = new Class2102.Class1343();

		// Token: 0x04001AC2 RID: 6850
		public Class2102.Class1345 class1345_0 = new Class2102.Class1345();

		// Token: 0x04001AC3 RID: 6851
		public Class2102.Class1347 class1347_0 = new Class2102.Class1347();

		// Token: 0x04001AC4 RID: 6852
		public Class2102.Class1349 class1349_0 = new Class2102.Class1349();

		// Token: 0x04001AC5 RID: 6853
		public Class2102.Class1351 class1351_0 = new Class2102.Class1351();

		// Token: 0x04001AC6 RID: 6854
		public Class2102.Class1353 class1353_0 = new Class2102.Class1353();

		// Token: 0x04001AC7 RID: 6855
		public Class2102.Class1355 class1355_0 = new Class2102.Class1355();

		// Token: 0x04001AC8 RID: 6856
		public Class2102.Class1357 class1357_0 = new Class2102.Class1357();

		// Token: 0x0200094D RID: 2381
		public sealed class Class1337 : IEnumerable
		{
			// Token: 0x06003A9B RID: 15003 RVA: 0x0001F16F File Offset: 0x0001D36F
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003A9C RID: 15004 RVA: 0x00123E18 File Offset: 0x00122018
			public Class2102.Class1338 method_1()
			{
				return new Class2102.Class1338(this.class2102_0);
			}

			// Token: 0x06003A9D RID: 15005 RVA: 0x00123E34 File Offset: 0x00122034
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AC9 RID: 6857
			private Class2102 class2102_0;
		}

		// Token: 0x0200094E RID: 2382
		public sealed class Class1338 : IEnumerator
		{
			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00123E4C File Offset: 0x0012204C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AA0 RID: 15008 RVA: 0x0001F178 File Offset: 0x0001D378
			public Class1338(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AA1 RID: 15009 RVA: 0x0001F18E File Offset: 0x0001D38E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AA2 RID: 15010 RVA: 0x0001F197 File Offset: 0x0001D397
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_2();
			}

			// Token: 0x06003AA3 RID: 15011 RVA: 0x00123E64 File Offset: 0x00122064
			public Class2009 method_0()
			{
				return this.class2102_0.method_3(this.int_0);
			}

			// Token: 0x04001ACA RID: 6858
			private int int_0;

			// Token: 0x04001ACB RID: 6859
			private Class2102 class2102_0;
		}

		// Token: 0x0200094F RID: 2383
		public sealed class Class1339 : IEnumerable
		{
			// Token: 0x06003AA4 RID: 15012 RVA: 0x0001F1BA File Offset: 0x0001D3BA
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AA5 RID: 15013 RVA: 0x00123E84 File Offset: 0x00122084
			public Class2102.Class1340 method_1()
			{
				return new Class2102.Class1340(this.class2102_0);
			}

			// Token: 0x06003AA6 RID: 15014 RVA: 0x00123EA0 File Offset: 0x001220A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001ACC RID: 6860
			private Class2102 class2102_0;
		}

		// Token: 0x02000950 RID: 2384
		public sealed class Class1340 : IEnumerator
		{
			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x00123EB8 File Offset: 0x001220B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AA9 RID: 15017 RVA: 0x0001F1C3 File Offset: 0x0001D3C3
			public Class1340(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AAA RID: 15018 RVA: 0x0001F1D9 File Offset: 0x0001D3D9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AAB RID: 15019 RVA: 0x0001F1E2 File Offset: 0x0001D3E2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_4();
			}

			// Token: 0x06003AAC RID: 15020 RVA: 0x00123ED0 File Offset: 0x001220D0
			public Class2050 method_0()
			{
				return this.class2102_0.method_5(this.int_0);
			}

			// Token: 0x04001ACD RID: 6861
			private int int_0;

			// Token: 0x04001ACE RID: 6862
			private Class2102 class2102_0;
		}

		// Token: 0x02000951 RID: 2385
		public sealed class Class1341 : IEnumerable
		{
			// Token: 0x06003AAD RID: 15021 RVA: 0x0001F205 File Offset: 0x0001D405
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AAE RID: 15022 RVA: 0x00123EF0 File Offset: 0x001220F0
			public Class2102.Class1342 method_1()
			{
				return new Class2102.Class1342(this.class2102_0);
			}

			// Token: 0x06003AAF RID: 15023 RVA: 0x00123F0C File Offset: 0x0012210C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001ACF RID: 6863
			private Class2102 class2102_0;
		}

		// Token: 0x02000952 RID: 2386
		public sealed class Class1342 : IEnumerator
		{
			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x00123F24 File Offset: 0x00122124
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AB2 RID: 15026 RVA: 0x0001F20E File Offset: 0x0001D40E
			public Class1342(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AB3 RID: 15027 RVA: 0x0001F224 File Offset: 0x0001D424
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AB4 RID: 15028 RVA: 0x0001F22D File Offset: 0x0001D42D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_6();
			}

			// Token: 0x06003AB5 RID: 15029 RVA: 0x00123F3C File Offset: 0x0012213C
			public Class2020 method_0()
			{
				return this.class2102_0.method_7(this.int_0);
			}

			// Token: 0x04001AD0 RID: 6864
			private int int_0;

			// Token: 0x04001AD1 RID: 6865
			private Class2102 class2102_0;
		}

		// Token: 0x02000953 RID: 2387
		public sealed class Class1343 : IEnumerable
		{
			// Token: 0x06003AB6 RID: 15030 RVA: 0x0001F250 File Offset: 0x0001D450
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AB7 RID: 15031 RVA: 0x00123F5C File Offset: 0x0012215C
			public Class2102.Class1344 method_1()
			{
				return new Class2102.Class1344(this.class2102_0);
			}

			// Token: 0x06003AB8 RID: 15032 RVA: 0x00123F78 File Offset: 0x00122178
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AD2 RID: 6866
			private Class2102 class2102_0;
		}

		// Token: 0x02000954 RID: 2388
		public sealed class Class1344 : IEnumerator
		{
			// Token: 0x1700046E RID: 1134
			// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00123F90 File Offset: 0x00122190
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003ABB RID: 15035 RVA: 0x0001F259 File Offset: 0x0001D459
			public Class1344(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003ABC RID: 15036 RVA: 0x0001F26F File Offset: 0x0001D46F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003ABD RID: 15037 RVA: 0x0001F278 File Offset: 0x0001D478
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_8();
			}

			// Token: 0x06003ABE RID: 15038 RVA: 0x00123FA8 File Offset: 0x001221A8
			public Class2038 method_0()
			{
				return this.class2102_0.method_9(this.int_0);
			}

			// Token: 0x04001AD3 RID: 6867
			private int int_0;

			// Token: 0x04001AD4 RID: 6868
			private Class2102 class2102_0;
		}

		// Token: 0x02000955 RID: 2389
		public sealed class Class1345 : IEnumerable
		{
			// Token: 0x06003ABF RID: 15039 RVA: 0x0001F29B File Offset: 0x0001D49B
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AC0 RID: 15040 RVA: 0x00123FC8 File Offset: 0x001221C8
			public Class2102.Class1346 method_1()
			{
				return new Class2102.Class1346(this.class2102_0);
			}

			// Token: 0x06003AC1 RID: 15041 RVA: 0x00123FE4 File Offset: 0x001221E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AD5 RID: 6869
			private Class2102 class2102_0;
		}

		// Token: 0x02000956 RID: 2390
		public sealed class Class1346 : IEnumerator
		{
			// Token: 0x1700046F RID: 1135
			// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00123FFC File Offset: 0x001221FC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AC4 RID: 15044 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
			public Class1346(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AC5 RID: 15045 RVA: 0x0001F2BA File Offset: 0x0001D4BA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AC6 RID: 15046 RVA: 0x0001F2C3 File Offset: 0x0001D4C3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_10();
			}

			// Token: 0x06003AC7 RID: 15047 RVA: 0x00124014 File Offset: 0x00122214
			public Class2032 method_0()
			{
				return this.class2102_0.method_11(this.int_0);
			}

			// Token: 0x04001AD6 RID: 6870
			private int int_0;

			// Token: 0x04001AD7 RID: 6871
			private Class2102 class2102_0;
		}

		// Token: 0x02000957 RID: 2391
		public sealed class Class1347 : IEnumerable
		{
			// Token: 0x06003AC8 RID: 15048 RVA: 0x0001F2E6 File Offset: 0x0001D4E6
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AC9 RID: 15049 RVA: 0x00124034 File Offset: 0x00122234
			public Class2102.Class1348 method_1()
			{
				return new Class2102.Class1348(this.class2102_0);
			}

			// Token: 0x06003ACA RID: 15050 RVA: 0x00124050 File Offset: 0x00122250
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AD8 RID: 6872
			private Class2102 class2102_0;
		}

		// Token: 0x02000958 RID: 2392
		public sealed class Class1348 : IEnumerator
		{
			// Token: 0x17000470 RID: 1136
			// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00124068 File Offset: 0x00122268
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003ACD RID: 15053 RVA: 0x0001F2EF File Offset: 0x0001D4EF
			public Class1348(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003ACE RID: 15054 RVA: 0x0001F305 File Offset: 0x0001D505
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003ACF RID: 15055 RVA: 0x0001F30E File Offset: 0x0001D50E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_12();
			}

			// Token: 0x06003AD0 RID: 15056 RVA: 0x00124080 File Offset: 0x00122280
			public Class2050 method_0()
			{
				return this.class2102_0.method_13(this.int_0);
			}

			// Token: 0x04001AD9 RID: 6873
			private int int_0;

			// Token: 0x04001ADA RID: 6874
			private Class2102 class2102_0;
		}

		// Token: 0x02000959 RID: 2393
		public sealed class Class1349 : IEnumerable
		{
			// Token: 0x06003AD1 RID: 15057 RVA: 0x0001F331 File Offset: 0x0001D531
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AD2 RID: 15058 RVA: 0x001240A0 File Offset: 0x001222A0
			public Class2102.Class1350 method_1()
			{
				return new Class2102.Class1350(this.class2102_0);
			}

			// Token: 0x06003AD3 RID: 15059 RVA: 0x001240BC File Offset: 0x001222BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001ADB RID: 6875
			private Class2102 class2102_0;
		}

		// Token: 0x0200095A RID: 2394
		public sealed class Class1350 : IEnumerator
		{
			// Token: 0x17000471 RID: 1137
			// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x001240D4 File Offset: 0x001222D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AD6 RID: 15062 RVA: 0x0001F33A File Offset: 0x0001D53A
			public Class1350(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AD7 RID: 15063 RVA: 0x0001F350 File Offset: 0x0001D550
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AD8 RID: 15064 RVA: 0x0001F359 File Offset: 0x0001D559
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_14();
			}

			// Token: 0x06003AD9 RID: 15065 RVA: 0x001240EC File Offset: 0x001222EC
			public Class2073 method_0()
			{
				return this.class2102_0.method_15(this.int_0);
			}

			// Token: 0x04001ADC RID: 6876
			private int int_0;

			// Token: 0x04001ADD RID: 6877
			private Class2102 class2102_0;
		}

		// Token: 0x0200095B RID: 2395
		public sealed class Class1351 : IEnumerable
		{
			// Token: 0x06003ADA RID: 15066 RVA: 0x0001F37C File Offset: 0x0001D57C
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003ADB RID: 15067 RVA: 0x0012410C File Offset: 0x0012230C
			public Class2102.Class1352 method_1()
			{
				return new Class2102.Class1352(this.class2102_0);
			}

			// Token: 0x06003ADC RID: 15068 RVA: 0x00124128 File Offset: 0x00122328
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001ADE RID: 6878
			private Class2102 class2102_0;
		}

		// Token: 0x0200095C RID: 2396
		public sealed class Class1352 : IEnumerator
		{
			// Token: 0x17000472 RID: 1138
			// (get) Token: 0x06003ADE RID: 15070 RVA: 0x00124140 File Offset: 0x00122340
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003ADF RID: 15071 RVA: 0x0001F385 File Offset: 0x0001D585
			public Class1352(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AE0 RID: 15072 RVA: 0x0001F39B File Offset: 0x0001D59B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AE1 RID: 15073 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_16();
			}

			// Token: 0x06003AE2 RID: 15074 RVA: 0x00124158 File Offset: 0x00122358
			public Class2096 method_0()
			{
				return this.class2102_0.method_17(this.int_0);
			}

			// Token: 0x04001ADF RID: 6879
			private int int_0;

			// Token: 0x04001AE0 RID: 6880
			private Class2102 class2102_0;
		}

		// Token: 0x0200095D RID: 2397
		public sealed class Class1353 : IEnumerable
		{
			// Token: 0x06003AE3 RID: 15075 RVA: 0x0001F3C7 File Offset: 0x0001D5C7
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AE4 RID: 15076 RVA: 0x00124178 File Offset: 0x00122378
			public Class2102.Class1354 method_1()
			{
				return new Class2102.Class1354(this.class2102_0);
			}

			// Token: 0x06003AE5 RID: 15077 RVA: 0x00124194 File Offset: 0x00122394
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AE1 RID: 6881
			private Class2102 class2102_0;
		}

		// Token: 0x0200095E RID: 2398
		public sealed class Class1354 : IEnumerator
		{
			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x001241AC File Offset: 0x001223AC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AE8 RID: 15080 RVA: 0x0001F3D0 File Offset: 0x0001D5D0
			public Class1354(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AE9 RID: 15081 RVA: 0x0001F3E6 File Offset: 0x0001D5E6
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AEA RID: 15082 RVA: 0x0001F3EF File Offset: 0x0001D5EF
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_18();
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x001241C4 File Offset: 0x001223C4
			public Class2050 method_0()
			{
				return this.class2102_0.method_19(this.int_0);
			}

			// Token: 0x04001AE2 RID: 6882
			private int int_0;

			// Token: 0x04001AE3 RID: 6883
			private Class2102 class2102_0;
		}

		// Token: 0x0200095F RID: 2399
		public sealed class Class1355 : IEnumerable
		{
			// Token: 0x06003AEC RID: 15084 RVA: 0x0001F412 File Offset: 0x0001D612
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AED RID: 15085 RVA: 0x001241E4 File Offset: 0x001223E4
			public Class2102.Class1356 method_1()
			{
				return new Class2102.Class1356(this.class2102_0);
			}

			// Token: 0x06003AEE RID: 15086 RVA: 0x00124200 File Offset: 0x00122400
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AE4 RID: 6884
			private Class2102 class2102_0;
		}

		// Token: 0x02000960 RID: 2400
		public sealed class Class1356 : IEnumerator
		{
			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x00124218 File Offset: 0x00122418
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AF1 RID: 15089 RVA: 0x0001F41B File Offset: 0x0001D61B
			public Class1356(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AF2 RID: 15090 RVA: 0x0001F431 File Offset: 0x0001D631
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AF3 RID: 15091 RVA: 0x0001F43A File Offset: 0x0001D63A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_20();
			}

			// Token: 0x06003AF4 RID: 15092 RVA: 0x00124230 File Offset: 0x00122430
			public Class2050 method_0()
			{
				return this.class2102_0.method_21(this.int_0);
			}

			// Token: 0x04001AE5 RID: 6885
			private int int_0;

			// Token: 0x04001AE6 RID: 6886
			private Class2102 class2102_0;
		}

		// Token: 0x02000961 RID: 2401
		public sealed class Class1357 : IEnumerable
		{
			// Token: 0x06003AF5 RID: 15093 RVA: 0x0001F45D File Offset: 0x0001D65D
			public void method_0(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
			}

			// Token: 0x06003AF6 RID: 15094 RVA: 0x00124250 File Offset: 0x00122450
			public Class2102.Class1358 method_1()
			{
				return new Class2102.Class1358(this.class2102_0);
			}

			// Token: 0x06003AF7 RID: 15095 RVA: 0x0012426C File Offset: 0x0012246C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001AE7 RID: 6887
			private Class2102 class2102_0;
		}

		// Token: 0x02000962 RID: 2402
		public sealed class Class1358 : IEnumerator
		{
			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00124284 File Offset: 0x00122484
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003AFA RID: 15098 RVA: 0x0001F466 File Offset: 0x0001D666
			public Class1358(Class2102 class2102_1)
			{
				this.class2102_0 = class2102_1;
				this.int_0 = -1;
			}

			// Token: 0x06003AFB RID: 15099 RVA: 0x0001F47C File Offset: 0x0001D67C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003AFC RID: 15100 RVA: 0x0001F485 File Offset: 0x0001D685
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2102_0.method_22();
			}

			// Token: 0x06003AFD RID: 15101 RVA: 0x0012429C File Offset: 0x0012249C
			public Class2074 method_0()
			{
				return this.class2102_0.method_23(this.int_0);
			}

			// Token: 0x04001AE8 RID: 6888
			private int int_0;

			// Token: 0x04001AE9 RID: 6889
			private Class2102 class2102_0;
		}
	}
}
