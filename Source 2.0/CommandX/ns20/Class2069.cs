using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000719 RID: 1817
	public sealed class Class2069 : Class2059
	{
		// Token: 0x06002D3B RID: 11579 RVA: 0x000189BD File Offset: 0x00016BBD
		public Class2069()
		{
			this.method_10();
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x000189F7 File Offset: 0x00016BF7
		public Class2069(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00103764 File Offset: 0x00101964
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsBold");
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00103784 File Offset: 0x00101984
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsBold", int_0)));
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x001037B0 File Offset: 0x001019B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsItalic");
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x001037D0 File Offset: 0x001019D0
		public Class2009 method_5(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsItalic", int_0)));
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x001037FC File Offset: 0x001019FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsUnderlined");
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x0010381C File Offset: 0x00101A1C
		public Class2009 method_7(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsUnderlined", int_0)));
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00103848 File Offset: 0x00101A48
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsStrikeout");
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00103868 File Offset: 0x00101A68
		public Class2009 method_9(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsStrikeout", int_0)));
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00018A32 File Offset: 0x00016C32
		private void method_10()
		{
			this.class923_0.method_0(this);
			this.class925_0.method_0(this);
			this.class927_0.method_0(this);
			this.class929_0.method_0(this);
		}

		// Token: 0x0400152E RID: 5422
		public Class2069.Class923 class923_0 = new Class2069.Class923();

		// Token: 0x0400152F RID: 5423
		public Class2069.Class925 class925_0 = new Class2069.Class925();

		// Token: 0x04001530 RID: 5424
		public Class2069.Class927 class927_0 = new Class2069.Class927();

		// Token: 0x04001531 RID: 5425
		public Class2069.Class929 class929_0 = new Class2069.Class929();

		// Token: 0x0200071A RID: 1818
		public sealed class Class923 : IEnumerable
		{
			// Token: 0x06002D46 RID: 11590 RVA: 0x00018A64 File Offset: 0x00016C64
			public void method_0(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
			}

			// Token: 0x06002D47 RID: 11591 RVA: 0x00103894 File Offset: 0x00101A94
			public Class2069.Class924 method_1()
			{
				return new Class2069.Class924(this.class2069_0);
			}

			// Token: 0x06002D48 RID: 11592 RVA: 0x001038B0 File Offset: 0x00101AB0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001532 RID: 5426
			private Class2069 class2069_0;
		}

		// Token: 0x0200071B RID: 1819
		public sealed class Class924 : IEnumerator
		{
			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06002D4A RID: 11594 RVA: 0x001038C8 File Offset: 0x00101AC8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D4B RID: 11595 RVA: 0x00018A6D File Offset: 0x00016C6D
			public Class924(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D4C RID: 11596 RVA: 0x00018A83 File Offset: 0x00016C83
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D4D RID: 11597 RVA: 0x00018A8C File Offset: 0x00016C8C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2069_0.method_2();
			}

			// Token: 0x06002D4E RID: 11598 RVA: 0x001038E0 File Offset: 0x00101AE0
			public Class2009 method_0()
			{
				return this.class2069_0.method_3(this.int_0);
			}

			// Token: 0x04001533 RID: 5427
			private int int_0;

			// Token: 0x04001534 RID: 5428
			private Class2069 class2069_0;
		}

		// Token: 0x0200071C RID: 1820
		public sealed class Class925 : IEnumerable
		{
			// Token: 0x06002D4F RID: 11599 RVA: 0x00018AAF File Offset: 0x00016CAF
			public void method_0(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
			}

			// Token: 0x06002D50 RID: 11600 RVA: 0x00103900 File Offset: 0x00101B00
			public Class2069.Class926 method_1()
			{
				return new Class2069.Class926(this.class2069_0);
			}

			// Token: 0x06002D51 RID: 11601 RVA: 0x0010391C File Offset: 0x00101B1C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001535 RID: 5429
			private Class2069 class2069_0;
		}

		// Token: 0x0200071D RID: 1821
		public sealed class Class926 : IEnumerator
		{
			// Token: 0x17000313 RID: 787
			// (get) Token: 0x06002D53 RID: 11603 RVA: 0x00103934 File Offset: 0x00101B34
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D54 RID: 11604 RVA: 0x00018AB8 File Offset: 0x00016CB8
			public Class926(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D55 RID: 11605 RVA: 0x00018ACE File Offset: 0x00016CCE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D56 RID: 11606 RVA: 0x00018AD7 File Offset: 0x00016CD7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2069_0.method_4();
			}

			// Token: 0x06002D57 RID: 11607 RVA: 0x0010394C File Offset: 0x00101B4C
			public Class2009 method_0()
			{
				return this.class2069_0.method_5(this.int_0);
			}

			// Token: 0x04001536 RID: 5430
			private int int_0;

			// Token: 0x04001537 RID: 5431
			private Class2069 class2069_0;
		}

		// Token: 0x0200071E RID: 1822
		public sealed class Class927 : IEnumerable
		{
			// Token: 0x06002D58 RID: 11608 RVA: 0x00018AFA File Offset: 0x00016CFA
			public void method_0(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x0010396C File Offset: 0x00101B6C
			public Class2069.Class928 method_1()
			{
				return new Class2069.Class928(this.class2069_0);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x00103988 File Offset: 0x00101B88
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001538 RID: 5432
			private Class2069 class2069_0;
		}

		// Token: 0x0200071F RID: 1823
		public sealed class Class928 : IEnumerator
		{
			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06002D5C RID: 11612 RVA: 0x001039A0 File Offset: 0x00101BA0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D5D RID: 11613 RVA: 0x00018B03 File Offset: 0x00016D03
			public Class928(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D5E RID: 11614 RVA: 0x00018B19 File Offset: 0x00016D19
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D5F RID: 11615 RVA: 0x00018B22 File Offset: 0x00016D22
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2069_0.method_6();
			}

			// Token: 0x06002D60 RID: 11616 RVA: 0x001039B8 File Offset: 0x00101BB8
			public Class2009 method_0()
			{
				return this.class2069_0.method_7(this.int_0);
			}

			// Token: 0x04001539 RID: 5433
			private int int_0;

			// Token: 0x0400153A RID: 5434
			private Class2069 class2069_0;
		}

		// Token: 0x02000720 RID: 1824
		public sealed class Class929 : IEnumerable
		{
			// Token: 0x06002D61 RID: 11617 RVA: 0x00018B45 File Offset: 0x00016D45
			public void method_0(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
			}

			// Token: 0x06002D62 RID: 11618 RVA: 0x001039D8 File Offset: 0x00101BD8
			public Class2069.Class930 method_1()
			{
				return new Class2069.Class930(this.class2069_0);
			}

			// Token: 0x06002D63 RID: 11619 RVA: 0x001039F4 File Offset: 0x00101BF4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400153B RID: 5435
			private Class2069 class2069_0;
		}

		// Token: 0x02000721 RID: 1825
		public sealed class Class930 : IEnumerator
		{
			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00103A0C File Offset: 0x00101C0C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D66 RID: 11622 RVA: 0x00018B4E File Offset: 0x00016D4E
			public Class930(Class2069 class2069_1)
			{
				this.class2069_0 = class2069_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D67 RID: 11623 RVA: 0x00018B64 File Offset: 0x00016D64
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D68 RID: 11624 RVA: 0x00018B6D File Offset: 0x00016D6D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2069_0.method_8();
			}

			// Token: 0x06002D69 RID: 11625 RVA: 0x00103A24 File Offset: 0x00101C24
			public Class2009 method_0()
			{
				return this.class2069_0.method_9(this.int_0);
			}

			// Token: 0x0400153C RID: 5436
			private int int_0;

			// Token: 0x0400153D RID: 5437
			private Class2069 class2069_0;
		}
	}
}
