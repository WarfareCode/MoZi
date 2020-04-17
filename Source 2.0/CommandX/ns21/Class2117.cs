using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000D8 RID: 216
	public sealed class Class2117 : Class2059
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x000067DF File Offset: 0x000049DF
		public Class2117()
		{
			this.method_10();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00006819 File Offset: 0x00004A19
		public Class2117(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000603E0 File Offset: 0x0005E5E0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "westBoundLongitude");
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00060400 File Offset: 0x0005E600
		public Class2048 method_3(int int_0)
		{
			return new Class2048(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "westBoundLongitude", int_0)));
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0006042C File Offset: 0x0005E62C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "eastBoundLongitude");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0006044C File Offset: 0x0005E64C
		public Class2048 method_5(int int_0)
		{
			return new Class2048(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "eastBoundLongitude", int_0)));
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00060478 File Offset: 0x0005E678
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "southBoundLatitude");
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00060498 File Offset: 0x0005E698
		public Class2047 method_7(int int_0)
		{
			return new Class2047(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "southBoundLatitude", int_0)));
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000604C4 File Offset: 0x0005E6C4
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "northBoundLatitude");
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000604E4 File Offset: 0x0005E6E4
		public Class2047 method_9(int int_0)
		{
			return new Class2047(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "northBoundLatitude", int_0)));
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00006854 File Offset: 0x00004A54
		private void method_10()
		{
			this.class1489_0.method_0(this);
			this.class1491_0.method_0(this);
			this.class1493_0.method_0(this);
			this.class1495_0.method_0(this);
		}

		// Token: 0x0400022F RID: 559
		public Class2117.Class1489 class1489_0 = new Class2117.Class1489();

		// Token: 0x04000230 RID: 560
		public Class2117.Class1491 class1491_0 = new Class2117.Class1491();

		// Token: 0x04000231 RID: 561
		public Class2117.Class1493 class1493_0 = new Class2117.Class1493();

		// Token: 0x04000232 RID: 562
		public Class2117.Class1495 class1495_0 = new Class2117.Class1495();

		// Token: 0x020000D9 RID: 217
		public sealed class Class1489 : IEnumerable
		{
			// Token: 0x06000455 RID: 1109 RVA: 0x00006886 File Offset: 0x00004A86
			public void method_0(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00060510 File Offset: 0x0005E710
			public Class2117.Class1490 method_1()
			{
				return new Class2117.Class1490(this.class2117_0);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x0006052C File Offset: 0x0005E72C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000233 RID: 563
			private Class2117 class2117_0;
		}

		// Token: 0x020000DA RID: 218
		public sealed class Class1490 : IEnumerator
		{
			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x00060544 File Offset: 0x0005E744
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x0000688F File Offset: 0x00004A8F
			public Class1490(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
				this.int_0 = -1;
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x000068A5 File Offset: 0x00004AA5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x000068AE File Offset: 0x00004AAE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2117_0.method_2();
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0006055C File Offset: 0x0005E75C
			public Class2048 method_0()
			{
				return this.class2117_0.method_3(this.int_0);
			}

			// Token: 0x04000234 RID: 564
			private int int_0;

			// Token: 0x04000235 RID: 565
			private Class2117 class2117_0;
		}

		// Token: 0x020000DB RID: 219
		public sealed class Class1491 : IEnumerable
		{
			// Token: 0x0600045E RID: 1118 RVA: 0x000068D1 File Offset: 0x00004AD1
			public void method_0(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x0006057C File Offset: 0x0005E77C
			public Class2117.Class1492 method_1()
			{
				return new Class2117.Class1492(this.class2117_0);
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00060598 File Offset: 0x0005E798
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000236 RID: 566
			private Class2117 class2117_0;
		}

		// Token: 0x020000DC RID: 220
		public sealed class Class1492 : IEnumerator
		{
			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x000605B0 File Offset: 0x0005E7B0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x000068DA File Offset: 0x00004ADA
			public Class1492(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
				this.int_0 = -1;
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x000068F0 File Offset: 0x00004AF0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x000068F9 File Offset: 0x00004AF9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2117_0.method_4();
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x000605C8 File Offset: 0x0005E7C8
			public Class2048 method_0()
			{
				return this.class2117_0.method_5(this.int_0);
			}

			// Token: 0x04000237 RID: 567
			private int int_0;

			// Token: 0x04000238 RID: 568
			private Class2117 class2117_0;
		}

		// Token: 0x020000DD RID: 221
		public sealed class Class1493 : IEnumerable
		{
			// Token: 0x06000467 RID: 1127 RVA: 0x0000691C File Offset: 0x00004B1C
			public void method_0(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x000605E8 File Offset: 0x0005E7E8
			public Class2117.Class1494 method_1()
			{
				return new Class2117.Class1494(this.class2117_0);
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00060604 File Offset: 0x0005E804
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000239 RID: 569
			private Class2117 class2117_0;
		}

		// Token: 0x020000DE RID: 222
		public sealed class Class1494 : IEnumerator
		{
			// Token: 0x17000070 RID: 112
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x0006061C File Offset: 0x0005E81C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00006925 File Offset: 0x00004B25
			public Class1494(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
				this.int_0 = -1;
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x0000693B File Offset: 0x00004B3B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00006944 File Offset: 0x00004B44
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2117_0.method_6();
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00060634 File Offset: 0x0005E834
			public Class2047 method_0()
			{
				return this.class2117_0.method_7(this.int_0);
			}

			// Token: 0x0400023A RID: 570
			private int int_0;

			// Token: 0x0400023B RID: 571
			private Class2117 class2117_0;
		}

		// Token: 0x020000DF RID: 223
		public sealed class Class1495 : IEnumerable
		{
			// Token: 0x06000470 RID: 1136 RVA: 0x00006967 File Offset: 0x00004B67
			public void method_0(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00060654 File Offset: 0x0005E854
			public Class2117.Class1496 method_1()
			{
				return new Class2117.Class1496(this.class2117_0);
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00060670 File Offset: 0x0005E870
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400023C RID: 572
			private Class2117 class2117_0;
		}

		// Token: 0x020000E0 RID: 224
		public sealed class Class1496 : IEnumerator
		{
			// Token: 0x17000071 RID: 113
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00060688 File Offset: 0x0005E888
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00006970 File Offset: 0x00004B70
			public Class1496(Class2117 class2117_1)
			{
				this.class2117_0 = class2117_1;
				this.int_0 = -1;
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00006986 File Offset: 0x00004B86
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x0000698F File Offset: 0x00004B8F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2117_0.method_8();
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x000606A0 File Offset: 0x0005E8A0
			public Class2047 method_0()
			{
				return this.class2117_0.method_9(this.int_0);
			}

			// Token: 0x0400023D RID: 573
			private int int_0;

			// Token: 0x0400023E RID: 574
			private Class2117 class2117_0;
		}
	}
}
