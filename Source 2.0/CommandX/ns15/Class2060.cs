using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns15
{
	// Token: 0x02000661 RID: 1633
	public sealed class Class2060 : Class2059
	{
		// Token: 0x060029AB RID: 10667 RVA: 0x000FDD34 File Offset: 0x000FBF34
		public Class2060()
		{
			this.method_24();
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000FDDC8 File Offset: 0x000FBFC8
		public Class2060(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00058E58 File Offset: 0x00057058
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Username");
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00058E78 File Offset: 0x00057078
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Username", int_0)));
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00058EA4 File Offset: 0x000570A4
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Password");
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00058EC4 File Offset: 0x000570C4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Password", int_0)));
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00058EF0 File Offset: 0x000570F0
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerGetMapUrl");
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00058F10 File Offset: 0x00057110
		public Class2050 method_7(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerGetMapUrl", int_0)));
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00058F3C File Offset: 0x0005713C
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Version");
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00058F5C File Offset: 0x0005715C
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Version", int_0)));
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00058F88 File Offset: 0x00057188
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageFormat");
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00058FA8 File Offset: 0x000571A8
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ImageFormat", int_0)));
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000FDE5C File Offset: 0x000FC05C
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "SamplesPerTile");
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000FDE7C File Offset: 0x000FC07C
		public Class2010 method_13(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "SamplesPerTile", int_0)));
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00058FD4 File Offset: 0x000571D4
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerName");
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00058FF4 File Offset: 0x000571F4
		public Class2050 method_15(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerName", int_0)));
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00059020 File Offset: 0x00057220
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSLayerStyle");
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00059040 File Offset: 0x00057240
		public Class2050 method_17(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "WMSLayerStyle", int_0)));
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0005906C File Offset: 0x0005726C
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "UseTransparency");
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0005908C File Offset: 0x0005728C
		public Class2009 method_19(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "UseTransparency", int_0)));
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00059100 File Offset: 0x00057300
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBoxOverlap");
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000FDEA8 File Offset: 0x000FC0A8
		public Class2021 method_21(int int_0)
		{
			return new Class2021(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "BoundingBoxOverlap", int_0)));
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0005914C File Offset: 0x0005734C
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ServerLogoFilePath");
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0005916C File Offset: 0x0005736C
		public Class2050 method_23(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ServerLogoFilePath", int_0)));
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000FDED4 File Offset: 0x000FC0D4
		private void method_24()
		{
			this.class837_0.method_0(this);
			this.class839_0.method_0(this);
			this.class841_0.method_0(this);
			this.class843_0.method_0(this);
			this.class845_0.method_0(this);
			this.class847_0.method_0(this);
			this.class849_0.method_0(this);
			this.class851_0.method_0(this);
			this.class853_0.method_0(this);
			this.class855_0.method_0(this);
			this.class857_0.method_0(this);
		}

		// Token: 0x040013F8 RID: 5112
		public Class2060.Class837 class837_0 = new Class2060.Class837();

		// Token: 0x040013F9 RID: 5113
		public Class2060.Class839 class839_0 = new Class2060.Class839();

		// Token: 0x040013FA RID: 5114
		public Class2060.Class841 class841_0 = new Class2060.Class841();

		// Token: 0x040013FB RID: 5115
		public Class2060.Class843 class843_0 = new Class2060.Class843();

		// Token: 0x040013FC RID: 5116
		public Class2060.Class845 class845_0 = new Class2060.Class845();

		// Token: 0x040013FD RID: 5117
		public Class2060.Class847 class847_0 = new Class2060.Class847();

		// Token: 0x040013FE RID: 5118
		public Class2060.Class849 class849_0 = new Class2060.Class849();

		// Token: 0x040013FF RID: 5119
		public Class2060.Class851 class851_0 = new Class2060.Class851();

		// Token: 0x04001400 RID: 5120
		public Class2060.Class853 class853_0 = new Class2060.Class853();

		// Token: 0x04001401 RID: 5121
		public Class2060.Class855 class855_0 = new Class2060.Class855();

		// Token: 0x04001402 RID: 5122
		public Class2060.Class857 class857_0 = new Class2060.Class857();

		// Token: 0x02000662 RID: 1634
		public sealed class Class837 : IEnumerable
		{
			// Token: 0x060029C4 RID: 10692 RVA: 0x00016D27 File Offset: 0x00014F27
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029C5 RID: 10693 RVA: 0x000FDF68 File Offset: 0x000FC168
			public Class2060.Class838 method_1()
			{
				return new Class2060.Class838(this.class2060_0);
			}

			// Token: 0x060029C6 RID: 10694 RVA: 0x000FDF84 File Offset: 0x000FC184
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001403 RID: 5123
			private Class2060 class2060_0;
		}

		// Token: 0x02000663 RID: 1635
		public sealed class Class838 : IEnumerator
		{
			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000FDF9C File Offset: 0x000FC19C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029C9 RID: 10697 RVA: 0x00016D30 File Offset: 0x00014F30
			public Class838(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029CA RID: 10698 RVA: 0x00016D46 File Offset: 0x00014F46
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029CB RID: 10699 RVA: 0x00016D4F File Offset: 0x00014F4F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_2();
			}

			// Token: 0x060029CC RID: 10700 RVA: 0x000FDFB4 File Offset: 0x000FC1B4
			public Class2050 method_0()
			{
				return this.class2060_0.method_3(this.int_0);
			}

			// Token: 0x04001404 RID: 5124
			private int int_0;

			// Token: 0x04001405 RID: 5125
			private Class2060 class2060_0;
		}

		// Token: 0x02000664 RID: 1636
		public sealed class Class839 : IEnumerable
		{
			// Token: 0x060029CD RID: 10701 RVA: 0x00016D72 File Offset: 0x00014F72
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029CE RID: 10702 RVA: 0x000FDFD4 File Offset: 0x000FC1D4
			public Class2060.Class840 method_1()
			{
				return new Class2060.Class840(this.class2060_0);
			}

			// Token: 0x060029CF RID: 10703 RVA: 0x000FDFF0 File Offset: 0x000FC1F0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001406 RID: 5126
			private Class2060 class2060_0;
		}

		// Token: 0x02000665 RID: 1637
		public sealed class Class840 : IEnumerator
		{
			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000FE008 File Offset: 0x000FC208
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029D2 RID: 10706 RVA: 0x00016D7B File Offset: 0x00014F7B
			public Class840(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029D3 RID: 10707 RVA: 0x00016D91 File Offset: 0x00014F91
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029D4 RID: 10708 RVA: 0x00016D9A File Offset: 0x00014F9A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_4();
			}

			// Token: 0x060029D5 RID: 10709 RVA: 0x000FE020 File Offset: 0x000FC220
			public Class2050 method_0()
			{
				return this.class2060_0.method_5(this.int_0);
			}

			// Token: 0x04001407 RID: 5127
			private int int_0;

			// Token: 0x04001408 RID: 5128
			private Class2060 class2060_0;
		}

		// Token: 0x02000666 RID: 1638
		public sealed class Class841 : IEnumerable
		{
			// Token: 0x060029D6 RID: 10710 RVA: 0x00016DBD File Offset: 0x00014FBD
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029D7 RID: 10711 RVA: 0x000FE040 File Offset: 0x000FC240
			public Class2060.Class842 method_1()
			{
				return new Class2060.Class842(this.class2060_0);
			}

			// Token: 0x060029D8 RID: 10712 RVA: 0x000FE05C File Offset: 0x000FC25C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001409 RID: 5129
			private Class2060 class2060_0;
		}

		// Token: 0x02000667 RID: 1639
		public sealed class Class842 : IEnumerator
		{
			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x060029DA RID: 10714 RVA: 0x000FE074 File Offset: 0x000FC274
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029DB RID: 10715 RVA: 0x00016DC6 File Offset: 0x00014FC6
			public Class842(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029DC RID: 10716 RVA: 0x00016DDC File Offset: 0x00014FDC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029DD RID: 10717 RVA: 0x00016DE5 File Offset: 0x00014FE5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_6();
			}

			// Token: 0x060029DE RID: 10718 RVA: 0x000FE08C File Offset: 0x000FC28C
			public Class2050 method_0()
			{
				return this.class2060_0.method_7(this.int_0);
			}

			// Token: 0x0400140A RID: 5130
			private int int_0;

			// Token: 0x0400140B RID: 5131
			private Class2060 class2060_0;
		}

		// Token: 0x02000668 RID: 1640
		public sealed class Class843 : IEnumerable
		{
			// Token: 0x060029DF RID: 10719 RVA: 0x00016E08 File Offset: 0x00015008
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029E0 RID: 10720 RVA: 0x000FE0AC File Offset: 0x000FC2AC
			public Class2060.Class844 method_1()
			{
				return new Class2060.Class844(this.class2060_0);
			}

			// Token: 0x060029E1 RID: 10721 RVA: 0x000FE0C8 File Offset: 0x000FC2C8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400140C RID: 5132
			private Class2060 class2060_0;
		}

		// Token: 0x02000669 RID: 1641
		public sealed class Class844 : IEnumerator
		{
			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000FE0E0 File Offset: 0x000FC2E0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029E4 RID: 10724 RVA: 0x00016E11 File Offset: 0x00015011
			public Class844(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029E5 RID: 10725 RVA: 0x00016E27 File Offset: 0x00015027
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029E6 RID: 10726 RVA: 0x00016E30 File Offset: 0x00015030
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_8();
			}

			// Token: 0x060029E7 RID: 10727 RVA: 0x000FE0F8 File Offset: 0x000FC2F8
			public Class2050 method_0()
			{
				return this.class2060_0.method_9(this.int_0);
			}

			// Token: 0x0400140D RID: 5133
			private int int_0;

			// Token: 0x0400140E RID: 5134
			private Class2060 class2060_0;
		}

		// Token: 0x0200066A RID: 1642
		public sealed class Class845 : IEnumerable
		{
			// Token: 0x060029E8 RID: 10728 RVA: 0x00016E53 File Offset: 0x00015053
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029E9 RID: 10729 RVA: 0x000FE118 File Offset: 0x000FC318
			public Class2060.Class846 method_1()
			{
				return new Class2060.Class846(this.class2060_0);
			}

			// Token: 0x060029EA RID: 10730 RVA: 0x000FE134 File Offset: 0x000FC334
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400140F RID: 5135
			private Class2060 class2060_0;
		}

		// Token: 0x0200066B RID: 1643
		public sealed class Class846 : IEnumerator
		{
			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x060029EC RID: 10732 RVA: 0x000FE14C File Offset: 0x000FC34C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029ED RID: 10733 RVA: 0x00016E5C File Offset: 0x0001505C
			public Class846(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029EE RID: 10734 RVA: 0x00016E72 File Offset: 0x00015072
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029EF RID: 10735 RVA: 0x00016E7B File Offset: 0x0001507B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_10();
			}

			// Token: 0x060029F0 RID: 10736 RVA: 0x000FE164 File Offset: 0x000FC364
			public Class2050 method_0()
			{
				return this.class2060_0.method_11(this.int_0);
			}

			// Token: 0x04001410 RID: 5136
			private int int_0;

			// Token: 0x04001411 RID: 5137
			private Class2060 class2060_0;
		}

		// Token: 0x0200066C RID: 1644
		public sealed class Class847 : IEnumerable
		{
			// Token: 0x060029F1 RID: 10737 RVA: 0x00016E9E File Offset: 0x0001509E
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029F2 RID: 10738 RVA: 0x000FE184 File Offset: 0x000FC384
			public Class2060.Class848 method_1()
			{
				return new Class2060.Class848(this.class2060_0);
			}

			// Token: 0x060029F3 RID: 10739 RVA: 0x000FE1A0 File Offset: 0x000FC3A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001412 RID: 5138
			private Class2060 class2060_0;
		}

		// Token: 0x0200066D RID: 1645
		public sealed class Class848 : IEnumerator
		{
			// Token: 0x170002EA RID: 746
			// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000FE1B8 File Offset: 0x000FC3B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029F6 RID: 10742 RVA: 0x00016EA7 File Offset: 0x000150A7
			public Class848(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x060029F7 RID: 10743 RVA: 0x00016EBD File Offset: 0x000150BD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060029F8 RID: 10744 RVA: 0x00016EC6 File Offset: 0x000150C6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_12();
			}

			// Token: 0x060029F9 RID: 10745 RVA: 0x000FE1D0 File Offset: 0x000FC3D0
			public Class2010 method_0()
			{
				return this.class2060_0.method_13(this.int_0);
			}

			// Token: 0x04001413 RID: 5139
			private int int_0;

			// Token: 0x04001414 RID: 5140
			private Class2060 class2060_0;
		}

		// Token: 0x0200066E RID: 1646
		public sealed class Class849 : IEnumerable
		{
			// Token: 0x060029FA RID: 10746 RVA: 0x00016EE9 File Offset: 0x000150E9
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x060029FB RID: 10747 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
			public Class2060.Class850 method_1()
			{
				return new Class2060.Class850(this.class2060_0);
			}

			// Token: 0x060029FC RID: 10748 RVA: 0x000FE20C File Offset: 0x000FC40C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001415 RID: 5141
			private Class2060 class2060_0;
		}

		// Token: 0x0200066F RID: 1647
		public sealed class Class850 : IEnumerator
		{
			// Token: 0x170002EB RID: 747
			// (get) Token: 0x060029FE RID: 10750 RVA: 0x000FE224 File Offset: 0x000FC424
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060029FF RID: 10751 RVA: 0x00016EF2 File Offset: 0x000150F2
			public Class850(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A00 RID: 10752 RVA: 0x00016F08 File Offset: 0x00015108
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A01 RID: 10753 RVA: 0x00016F11 File Offset: 0x00015111
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_14();
			}

			// Token: 0x06002A02 RID: 10754 RVA: 0x000FE23C File Offset: 0x000FC43C
			public Class2050 method_0()
			{
				return this.class2060_0.method_15(this.int_0);
			}

			// Token: 0x04001416 RID: 5142
			private int int_0;

			// Token: 0x04001417 RID: 5143
			private Class2060 class2060_0;
		}

		// Token: 0x02000670 RID: 1648
		public sealed class Class851 : IEnumerable
		{
			// Token: 0x06002A03 RID: 10755 RVA: 0x00016F34 File Offset: 0x00015134
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x06002A04 RID: 10756 RVA: 0x000FE25C File Offset: 0x000FC45C
			public Class2060.Class852 method_1()
			{
				return new Class2060.Class852(this.class2060_0);
			}

			// Token: 0x06002A05 RID: 10757 RVA: 0x000FE278 File Offset: 0x000FC478
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001418 RID: 5144
			private Class2060 class2060_0;
		}

		// Token: 0x02000671 RID: 1649
		public sealed class Class852 : IEnumerator
		{
			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000FE290 File Offset: 0x000FC490
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A08 RID: 10760 RVA: 0x00016F3D File Offset: 0x0001513D
			public Class852(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A09 RID: 10761 RVA: 0x00016F53 File Offset: 0x00015153
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A0A RID: 10762 RVA: 0x00016F5C File Offset: 0x0001515C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_16();
			}

			// Token: 0x06002A0B RID: 10763 RVA: 0x000FE2A8 File Offset: 0x000FC4A8
			public Class2050 method_0()
			{
				return this.class2060_0.method_17(this.int_0);
			}

			// Token: 0x04001419 RID: 5145
			private int int_0;

			// Token: 0x0400141A RID: 5146
			private Class2060 class2060_0;
		}

		// Token: 0x02000672 RID: 1650
		public sealed class Class853 : IEnumerable
		{
			// Token: 0x06002A0C RID: 10764 RVA: 0x00016F7F File Offset: 0x0001517F
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x06002A0D RID: 10765 RVA: 0x000FE2C8 File Offset: 0x000FC4C8
			public Class2060.Class854 method_1()
			{
				return new Class2060.Class854(this.class2060_0);
			}

			// Token: 0x06002A0E RID: 10766 RVA: 0x000FE2E4 File Offset: 0x000FC4E4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400141B RID: 5147
			private Class2060 class2060_0;
		}

		// Token: 0x02000673 RID: 1651
		public sealed class Class854 : IEnumerator
		{
			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000FE2FC File Offset: 0x000FC4FC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A11 RID: 10769 RVA: 0x00016F88 File Offset: 0x00015188
			public Class854(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A12 RID: 10770 RVA: 0x00016F9E File Offset: 0x0001519E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A13 RID: 10771 RVA: 0x00016FA7 File Offset: 0x000151A7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_18();
			}

			// Token: 0x06002A14 RID: 10772 RVA: 0x000FE314 File Offset: 0x000FC514
			public Class2009 method_0()
			{
				return this.class2060_0.method_19(this.int_0);
			}

			// Token: 0x0400141C RID: 5148
			private int int_0;

			// Token: 0x0400141D RID: 5149
			private Class2060 class2060_0;
		}

		// Token: 0x02000674 RID: 1652
		public sealed class Class855 : IEnumerable
		{
			// Token: 0x06002A15 RID: 10773 RVA: 0x00016FCA File Offset: 0x000151CA
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x06002A16 RID: 10774 RVA: 0x000FE334 File Offset: 0x000FC534
			public Class2060.Class856 method_1()
			{
				return new Class2060.Class856(this.class2060_0);
			}

			// Token: 0x06002A17 RID: 10775 RVA: 0x000FE350 File Offset: 0x000FC550
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400141E RID: 5150
			private Class2060 class2060_0;
		}

		// Token: 0x02000675 RID: 1653
		public sealed class Class856 : IEnumerator
		{
			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000FE368 File Offset: 0x000FC568
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A1A RID: 10778 RVA: 0x00016FD3 File Offset: 0x000151D3
			public Class856(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A1B RID: 10779 RVA: 0x00016FE9 File Offset: 0x000151E9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x00016FF2 File Offset: 0x000151F2
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_20();
			}

			// Token: 0x06002A1D RID: 10781 RVA: 0x000FE380 File Offset: 0x000FC580
			public Class2021 method_0()
			{
				return this.class2060_0.method_21(this.int_0);
			}

			// Token: 0x0400141F RID: 5151
			private int int_0;

			// Token: 0x04001420 RID: 5152
			private Class2060 class2060_0;
		}

		// Token: 0x02000676 RID: 1654
		public sealed class Class857 : IEnumerable
		{
			// Token: 0x06002A1E RID: 10782 RVA: 0x00017015 File Offset: 0x00015215
			public void method_0(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
			}

			// Token: 0x06002A1F RID: 10783 RVA: 0x000FE3A0 File Offset: 0x000FC5A0
			public Class2060.Class858 method_1()
			{
				return new Class2060.Class858(this.class2060_0);
			}

			// Token: 0x06002A20 RID: 10784 RVA: 0x000FE3BC File Offset: 0x000FC5BC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001421 RID: 5153
			private Class2060 class2060_0;
		}

		// Token: 0x02000677 RID: 1655
		public sealed class Class858 : IEnumerator
		{
			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000FE3D4 File Offset: 0x000FC5D4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A23 RID: 10787 RVA: 0x0001701E File Offset: 0x0001521E
			public Class858(Class2060 class2060_1)
			{
				this.class2060_0 = class2060_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A24 RID: 10788 RVA: 0x00017034 File Offset: 0x00015234
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A25 RID: 10789 RVA: 0x0001703D File Offset: 0x0001523D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2060_0.method_22();
			}

			// Token: 0x06002A26 RID: 10790 RVA: 0x000FE3EC File Offset: 0x000FC5EC
			public Class2050 method_0()
			{
				return this.class2060_0.method_23(this.int_0);
			}

			// Token: 0x04001422 RID: 5154
			private int int_0;

			// Token: 0x04001423 RID: 5155
			private Class2060 class2060_0;
		}
	}
}
