using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns22
{
	// Token: 0x02000206 RID: 518
	public sealed class Class2142 : Class2059
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x00078B04 File Offset: 0x00076D04
		public Class2142()
		{
			this.method_14();
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00078B60 File Offset: 0x00076D60
		public Class2142(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_14();
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00078BBC File Offset: 0x00076DBC
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactPersonPrimary");
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00078BDC File Offset: 0x00076DDC
		public Class2143 method_3(int int_0)
		{
			return new Class2143(base.method_1(Class2059.Enum155.const_1, "", "ContactPersonPrimary", int_0));
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00078C04 File Offset: 0x00076E04
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactPosition");
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00078C24 File Offset: 0x00076E24
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactPosition", int_0)));
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00078C50 File Offset: 0x00076E50
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactAddress");
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00078C70 File Offset: 0x00076E70
		public Class2141 method_7(int int_0)
		{
			return new Class2141(base.method_1(Class2059.Enum155.const_1, "", "ContactAddress", int_0));
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00078C98 File Offset: 0x00076E98
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactVoiceTelephone");
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00078CB8 File Offset: 0x00076EB8
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactVoiceTelephone", int_0)));
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00078CE4 File Offset: 0x00076EE4
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactFacsimileTelephone");
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00078D04 File Offset: 0x00076F04
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactFacsimileTelephone", int_0)));
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00078D30 File Offset: 0x00076F30
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ContactElectronicMailAddress");
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00078D50 File Offset: 0x00076F50
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ContactElectronicMailAddress", int_0)));
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00078D7C File Offset: 0x00076F7C
		private void method_14()
		{
			this.class1705_0.method_0(this);
			this.class1707_0.method_0(this);
			this.class1709_0.method_0(this);
			this.class1711_0.method_0(this);
			this.class1713_0.method_0(this);
			this.class1715_0.method_0(this);
		}

		// Token: 0x04000540 RID: 1344
		public Class2142.Class1705 class1705_0 = new Class2142.Class1705();

		// Token: 0x04000541 RID: 1345
		public Class2142.Class1707 class1707_0 = new Class2142.Class1707();

		// Token: 0x04000542 RID: 1346
		public Class2142.Class1709 class1709_0 = new Class2142.Class1709();

		// Token: 0x04000543 RID: 1347
		public Class2142.Class1711 class1711_0 = new Class2142.Class1711();

		// Token: 0x04000544 RID: 1348
		public Class2142.Class1713 class1713_0 = new Class2142.Class1713();

		// Token: 0x04000545 RID: 1349
		public Class2142.Class1715 class1715_0 = new Class2142.Class1715();

		// Token: 0x02000207 RID: 519
		public sealed class Class1705 : IEnumerable
		{
			// Token: 0x06000C2D RID: 3117 RVA: 0x0000A48E File Offset: 0x0000868E
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x00078DD4 File Offset: 0x00076FD4
			public Class2142.Class1706 method_1()
			{
				return new Class2142.Class1706(this.class2142_0);
			}

			// Token: 0x06000C2F RID: 3119 RVA: 0x00078DF0 File Offset: 0x00076FF0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000546 RID: 1350
			private Class2142 class2142_0;
		}

		// Token: 0x02000208 RID: 520
		public sealed class Class1706 : IEnumerator
		{
			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00078E08 File Offset: 0x00077008
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x0000A497 File Offset: 0x00008697
			public Class1706(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x0000A4AD File Offset: 0x000086AD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x0000A4B6 File Offset: 0x000086B6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_2();
			}

			// Token: 0x06000C35 RID: 3125 RVA: 0x00078E20 File Offset: 0x00077020
			public Class2143 method_0()
			{
				return this.class2142_0.method_3(this.int_0);
			}

			// Token: 0x04000547 RID: 1351
			private int int_0;

			// Token: 0x04000548 RID: 1352
			private Class2142 class2142_0;
		}

		// Token: 0x02000209 RID: 521
		public sealed class Class1707 : IEnumerable
		{
			// Token: 0x06000C36 RID: 3126 RVA: 0x0000A4D9 File Offset: 0x000086D9
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C37 RID: 3127 RVA: 0x00078E40 File Offset: 0x00077040
			public Class2142.Class1708 method_1()
			{
				return new Class2142.Class1708(this.class2142_0);
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x00078E5C File Offset: 0x0007705C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000549 RID: 1353
			private Class2142 class2142_0;
		}

		// Token: 0x0200020A RID: 522
		public sealed class Class1708 : IEnumerator
		{
			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00078E74 File Offset: 0x00077074
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x0000A4E2 File Offset: 0x000086E2
			public Class1708(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x0000A4F8 File Offset: 0x000086F8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x0000A501 File Offset: 0x00008701
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_4();
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x00078E8C File Offset: 0x0007708C
			public Class2050 method_0()
			{
				return this.class2142_0.method_5(this.int_0);
			}

			// Token: 0x0400054A RID: 1354
			private int int_0;

			// Token: 0x0400054B RID: 1355
			private Class2142 class2142_0;
		}

		// Token: 0x0200020B RID: 523
		public sealed class Class1709 : IEnumerable
		{
			// Token: 0x06000C3F RID: 3135 RVA: 0x0000A524 File Offset: 0x00008724
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x00078EAC File Offset: 0x000770AC
			public Class2142.Class1710 method_1()
			{
				return new Class2142.Class1710(this.class2142_0);
			}

			// Token: 0x06000C41 RID: 3137 RVA: 0x00078EC8 File Offset: 0x000770C8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400054C RID: 1356
			private Class2142 class2142_0;
		}

		// Token: 0x0200020C RID: 524
		public sealed class Class1710 : IEnumerator
		{
			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00078EE0 File Offset: 0x000770E0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C44 RID: 3140 RVA: 0x0000A52D File Offset: 0x0000872D
			public Class1710(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C45 RID: 3141 RVA: 0x0000A543 File Offset: 0x00008743
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C46 RID: 3142 RVA: 0x0000A54C File Offset: 0x0000874C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_6();
			}

			// Token: 0x06000C47 RID: 3143 RVA: 0x00078EF8 File Offset: 0x000770F8
			public Class2141 method_0()
			{
				return this.class2142_0.method_7(this.int_0);
			}

			// Token: 0x0400054D RID: 1357
			private int int_0;

			// Token: 0x0400054E RID: 1358
			private Class2142 class2142_0;
		}

		// Token: 0x0200020D RID: 525
		public sealed class Class1711 : IEnumerable
		{
			// Token: 0x06000C48 RID: 3144 RVA: 0x0000A56F File Offset: 0x0000876F
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C49 RID: 3145 RVA: 0x00078F18 File Offset: 0x00077118
			public Class2142.Class1712 method_1()
			{
				return new Class2142.Class1712(this.class2142_0);
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x00078F34 File Offset: 0x00077134
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400054F RID: 1359
			private Class2142 class2142_0;
		}

		// Token: 0x0200020E RID: 526
		public sealed class Class1712 : IEnumerator
		{
			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00078F4C File Offset: 0x0007714C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x0000A578 File Offset: 0x00008778
			public Class1712(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x0000A58E File Offset: 0x0000878E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x0000A597 File Offset: 0x00008797
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_8();
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x00078F64 File Offset: 0x00077164
			public Class2050 method_0()
			{
				return this.class2142_0.method_9(this.int_0);
			}

			// Token: 0x04000550 RID: 1360
			private int int_0;

			// Token: 0x04000551 RID: 1361
			private Class2142 class2142_0;
		}

		// Token: 0x0200020F RID: 527
		public sealed class Class1713 : IEnumerable
		{
			// Token: 0x06000C51 RID: 3153 RVA: 0x0000A5BA File Offset: 0x000087BA
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x00078F84 File Offset: 0x00077184
			public Class2142.Class1714 method_1()
			{
				return new Class2142.Class1714(this.class2142_0);
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x00078FA0 File Offset: 0x000771A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000552 RID: 1362
			private Class2142 class2142_0;
		}

		// Token: 0x02000210 RID: 528
		public sealed class Class1714 : IEnumerator
		{
			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00078FB8 File Offset: 0x000771B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C56 RID: 3158 RVA: 0x0000A5C3 File Offset: 0x000087C3
			public Class1714(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C57 RID: 3159 RVA: 0x0000A5D9 File Offset: 0x000087D9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C58 RID: 3160 RVA: 0x0000A5E2 File Offset: 0x000087E2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_10();
			}

			// Token: 0x06000C59 RID: 3161 RVA: 0x00078FD0 File Offset: 0x000771D0
			public Class2050 method_0()
			{
				return this.class2142_0.method_11(this.int_0);
			}

			// Token: 0x04000553 RID: 1363
			private int int_0;

			// Token: 0x04000554 RID: 1364
			private Class2142 class2142_0;
		}

		// Token: 0x02000211 RID: 529
		public sealed class Class1715 : IEnumerable
		{
			// Token: 0x06000C5A RID: 3162 RVA: 0x0000A605 File Offset: 0x00008805
			public void method_0(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x00078FF0 File Offset: 0x000771F0
			public Class2142.Class1716 method_1()
			{
				return new Class2142.Class1716(this.class2142_0);
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x0007900C File Offset: 0x0007720C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000555 RID: 1365
			private Class2142 class2142_0;
		}

		// Token: 0x02000212 RID: 530
		public sealed class Class1716 : IEnumerator
		{
			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00079024 File Offset: 0x00077224
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x0000A60E File Offset: 0x0000880E
			public Class1716(Class2142 class2142_1)
			{
				this.class2142_0 = class2142_1;
				this.int_0 = -1;
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x0000A624 File Offset: 0x00008824
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x0000A62D File Offset: 0x0000882D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2142_0.method_12();
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x0007903C File Offset: 0x0007723C
			public Class2050 method_0()
			{
				return this.class2142_0.method_13(this.int_0);
			}

			// Token: 0x04000556 RID: 1366
			private int int_0;

			// Token: 0x04000557 RID: 1367
			private Class2142 class2142_0;
		}
	}
}
