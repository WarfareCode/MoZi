using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000723 RID: 1827
	public sealed class Class2070 : Class2059
	{
		// Token: 0x06002D78 RID: 11640 RVA: 0x00018BE4 File Offset: 0x00016DE4
		public Class2070()
		{
			this.method_10();
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00018C1E File Offset: 0x00016E1E
		public Class2070(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_10();
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00103764 File Offset: 0x00101964
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsBold");
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00103784 File Offset: 0x00101984
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsBold", int_0)));
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x001037B0 File Offset: 0x001019B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsItalic");
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x001037D0 File Offset: 0x001019D0
		public Class2009 method_5(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsItalic", int_0)));
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x001037FC File Offset: 0x001019FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsUnderlined");
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x0010381C File Offset: 0x00101A1C
		public Class2009 method_7(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsUnderlined", int_0)));
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00103848 File Offset: 0x00101A48
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "IsStrikeout");
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00103868 File Offset: 0x00101A68
		public Class2009 method_9(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "IsStrikeout", int_0)));
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00018C59 File Offset: 0x00016E59
		private void method_10()
		{
			this.class931_0.method_0(this);
			this.class933_0.method_0(this);
			this.class935_0.method_0(this);
			this.class937_0.method_0(this);
		}

		// Token: 0x04001542 RID: 5442
		public Class2070.Class931 class931_0 = new Class2070.Class931();

		// Token: 0x04001543 RID: 5443
		public Class2070.Class933 class933_0 = new Class2070.Class933();

		// Token: 0x04001544 RID: 5444
		public Class2070.Class935 class935_0 = new Class2070.Class935();

		// Token: 0x04001545 RID: 5445
		public Class2070.Class937 class937_0 = new Class2070.Class937();

		// Token: 0x02000724 RID: 1828
		public sealed class Class931 : IEnumerable
		{
			// Token: 0x06002D83 RID: 11651 RVA: 0x00018C8B File Offset: 0x00016E8B
			public void method_0(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
			}

			// Token: 0x06002D84 RID: 11652 RVA: 0x00103E00 File Offset: 0x00102000
			public Class2070.Class932 method_1()
			{
				return new Class2070.Class932(this.class2070_0);
			}

			// Token: 0x06002D85 RID: 11653 RVA: 0x00103E1C File Offset: 0x0010201C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001546 RID: 5446
			private Class2070 class2070_0;
		}

		// Token: 0x02000725 RID: 1829
		public sealed class Class932 : IEnumerator
		{
			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06002D87 RID: 11655 RVA: 0x00103E34 File Offset: 0x00102034
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D88 RID: 11656 RVA: 0x00018C94 File Offset: 0x00016E94
			public Class932(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D89 RID: 11657 RVA: 0x00018CAA File Offset: 0x00016EAA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D8A RID: 11658 RVA: 0x00018CB3 File Offset: 0x00016EB3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2070_0.method_2();
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x00103E4C File Offset: 0x0010204C
			public Class2009 method_0()
			{
				return this.class2070_0.method_3(this.int_0);
			}

			// Token: 0x04001547 RID: 5447
			private int int_0;

			// Token: 0x04001548 RID: 5448
			private Class2070 class2070_0;
		}

		// Token: 0x02000726 RID: 1830
		public sealed class Class933 : IEnumerable
		{
			// Token: 0x06002D8C RID: 11660 RVA: 0x00018CD6 File Offset: 0x00016ED6
			public void method_0(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
			}

			// Token: 0x06002D8D RID: 11661 RVA: 0x00103E6C File Offset: 0x0010206C
			public Class2070.Class934 method_1()
			{
				return new Class2070.Class934(this.class2070_0);
			}

			// Token: 0x06002D8E RID: 11662 RVA: 0x00103E88 File Offset: 0x00102088
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001549 RID: 5449
			private Class2070 class2070_0;
		}

		// Token: 0x02000727 RID: 1831
		public sealed class Class934 : IEnumerator
		{
			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06002D90 RID: 11664 RVA: 0x00103EA0 File Offset: 0x001020A0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D91 RID: 11665 RVA: 0x00018CDF File Offset: 0x00016EDF
			public Class934(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D92 RID: 11666 RVA: 0x00018CF5 File Offset: 0x00016EF5
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D93 RID: 11667 RVA: 0x00018CFE File Offset: 0x00016EFE
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2070_0.method_4();
			}

			// Token: 0x06002D94 RID: 11668 RVA: 0x00103EB8 File Offset: 0x001020B8
			public Class2009 method_0()
			{
				return this.class2070_0.method_5(this.int_0);
			}

			// Token: 0x0400154A RID: 5450
			private int int_0;

			// Token: 0x0400154B RID: 5451
			private Class2070 class2070_0;
		}

		// Token: 0x02000728 RID: 1832
		public sealed class Class935 : IEnumerable
		{
			// Token: 0x06002D95 RID: 11669 RVA: 0x00018D21 File Offset: 0x00016F21
			public void method_0(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
			}

			// Token: 0x06002D96 RID: 11670 RVA: 0x00103ED8 File Offset: 0x001020D8
			public Class2070.Class936 method_1()
			{
				return new Class2070.Class936(this.class2070_0);
			}

			// Token: 0x06002D97 RID: 11671 RVA: 0x00103EF4 File Offset: 0x001020F4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400154C RID: 5452
			private Class2070 class2070_0;
		}

		// Token: 0x02000729 RID: 1833
		public sealed class Class936 : IEnumerator
		{
			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00103F0C File Offset: 0x0010210C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002D9A RID: 11674 RVA: 0x00018D2A File Offset: 0x00016F2A
			public Class936(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
				this.int_0 = -1;
			}

			// Token: 0x06002D9B RID: 11675 RVA: 0x00018D40 File Offset: 0x00016F40
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002D9C RID: 11676 RVA: 0x00018D49 File Offset: 0x00016F49
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2070_0.method_6();
			}

			// Token: 0x06002D9D RID: 11677 RVA: 0x00103F24 File Offset: 0x00102124
			public Class2009 method_0()
			{
				return this.class2070_0.method_7(this.int_0);
			}

			// Token: 0x0400154D RID: 5453
			private int int_0;

			// Token: 0x0400154E RID: 5454
			private Class2070 class2070_0;
		}

		// Token: 0x0200072A RID: 1834
		public sealed class Class937 : IEnumerable
		{
			// Token: 0x06002D9E RID: 11678 RVA: 0x00018D6C File Offset: 0x00016F6C
			public void method_0(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
			}

			// Token: 0x06002D9F RID: 11679 RVA: 0x00103F44 File Offset: 0x00102144
			public Class2070.Class938 method_1()
			{
				return new Class2070.Class938(this.class2070_0);
			}

			// Token: 0x06002DA0 RID: 11680 RVA: 0x00103F60 File Offset: 0x00102160
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400154F RID: 5455
			private Class2070 class2070_0;
		}

		// Token: 0x0200072B RID: 1835
		public sealed class Class938 : IEnumerator
		{
			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00103F78 File Offset: 0x00102178
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002DA3 RID: 11683 RVA: 0x00018D75 File Offset: 0x00016F75
			public Class938(Class2070 class2070_1)
			{
				this.class2070_0 = class2070_1;
				this.int_0 = -1;
			}

			// Token: 0x06002DA4 RID: 11684 RVA: 0x00018D8B File Offset: 0x00016F8B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002DA5 RID: 11685 RVA: 0x00018D94 File Offset: 0x00016F94
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2070_0.method_8();
			}

			// Token: 0x06002DA6 RID: 11686 RVA: 0x00103F90 File Offset: 0x00102190
			public Class2009 method_0()
			{
				return this.class2070_0.method_9(this.int_0);
			}

			// Token: 0x04001550 RID: 5456
			private int int_0;

			// Token: 0x04001551 RID: 5457
			private Class2070 class2070_0;
		}
	}
}
