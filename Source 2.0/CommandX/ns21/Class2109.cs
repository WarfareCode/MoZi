using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns21
{
	// Token: 0x02000097 RID: 151
	public sealed class Class2109 : Class2059
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00005DCB File Offset: 0x00003FCB
		public Class2109()
		{
			this.method_8();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00005DFA File Offset: 0x00003FFA
		public Class2109(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0005D42C File Offset: 0x0005B62C
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Request");
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0005D44C File Offset: 0x0005B64C
		public Class2131 method_3(int int_0)
		{
			return new Class2131(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Request", int_0));
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0005D474 File Offset: 0x0005B674
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Exception");
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0005D494 File Offset: 0x0005B694
		public Class2116 method_5(int int_0)
		{
			return new Class2116(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Exception", int_0));
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0005D4BC File Offset: 0x0005B6BC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Layer");
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0005D4DC File Offset: 0x0005B6DC
		public Class2124 method_7(int int_0)
		{
			return new Class2124(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "Layer", int_0));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00005E2A File Offset: 0x0000402A
		private void method_8()
		{
			this.class1433_0.method_0(this);
			this.class1435_0.method_0(this);
			this.class1437_0.method_0(this);
		}

		// Token: 0x040001BC RID: 444
		public Class2109.Class1433 class1433_0 = new Class2109.Class1433();

		// Token: 0x040001BD RID: 445
		public Class2109.Class1435 class1435_0 = new Class2109.Class1435();

		// Token: 0x040001BE RID: 446
		public Class2109.Class1437 class1437_0 = new Class2109.Class1437();

		// Token: 0x02000098 RID: 152
		public sealed class Class1433 : IEnumerable
		{
			// Token: 0x060002FD RID: 765 RVA: 0x00005E50 File Offset: 0x00004050
			public void method_0(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0005D504 File Offset: 0x0005B704
			public Class2109.Class1434 method_1()
			{
				return new Class2109.Class1434(this.class2109_0);
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0005D520 File Offset: 0x0005B720
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001BF RID: 447
			private Class2109 class2109_0;
		}

		// Token: 0x02000099 RID: 153
		public sealed class Class1434 : IEnumerator
		{
			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0005D538 File Offset: 0x0005B738
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00005E59 File Offset: 0x00004059
			public Class1434(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
				this.int_0 = -1;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00005E6F File Offset: 0x0000406F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00005E78 File Offset: 0x00004078
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2109_0.method_2();
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0005D550 File Offset: 0x0005B750
			public Class2131 method_0()
			{
				return this.class2109_0.method_3(this.int_0);
			}

			// Token: 0x040001C0 RID: 448
			private int int_0;

			// Token: 0x040001C1 RID: 449
			private Class2109 class2109_0;
		}

		// Token: 0x0200009A RID: 154
		public sealed class Class1435 : IEnumerable
		{
			// Token: 0x06000306 RID: 774 RVA: 0x00005E9B File Offset: 0x0000409B
			public void method_0(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0005D570 File Offset: 0x0005B770
			public Class2109.Class1436 method_1()
			{
				return new Class2109.Class1436(this.class2109_0);
			}

			// Token: 0x06000308 RID: 776 RVA: 0x0005D58C File Offset: 0x0005B78C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001C2 RID: 450
			private Class2109 class2109_0;
		}

		// Token: 0x0200009B RID: 155
		public sealed class Class1436 : IEnumerator
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600030A RID: 778 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00005EA4 File Offset: 0x000040A4
			public Class1436(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
				this.int_0 = -1;
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00005EBA File Offset: 0x000040BA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600030D RID: 781 RVA: 0x00005EC3 File Offset: 0x000040C3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2109_0.method_4();
			}

			// Token: 0x0600030E RID: 782 RVA: 0x0005D5BC File Offset: 0x0005B7BC
			public Class2116 method_0()
			{
				return this.class2109_0.method_5(this.int_0);
			}

			// Token: 0x040001C3 RID: 451
			private int int_0;

			// Token: 0x040001C4 RID: 452
			private Class2109 class2109_0;
		}

		// Token: 0x0200009C RID: 156
		public sealed class Class1437 : IEnumerable
		{
			// Token: 0x0600030F RID: 783 RVA: 0x00005EE6 File Offset: 0x000040E6
			public void method_0(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
			}

			// Token: 0x06000310 RID: 784 RVA: 0x0005D5DC File Offset: 0x0005B7DC
			public Class2109.Class1438 method_1()
			{
				return new Class2109.Class1438(this.class2109_0);
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0005D5F8 File Offset: 0x0005B7F8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040001C5 RID: 453
			private Class2109 class2109_0;
		}

		// Token: 0x0200009D RID: 157
		public sealed class Class1438 : IEnumerator
		{
			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0005D610 File Offset: 0x0005B810
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06000314 RID: 788 RVA: 0x00005EEF File Offset: 0x000040EF
			public Class1438(Class2109 class2109_1)
			{
				this.class2109_0 = class2109_1;
				this.int_0 = -1;
			}

			// Token: 0x06000315 RID: 789 RVA: 0x00005F05 File Offset: 0x00004105
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00005F0E File Offset: 0x0000410E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2109_0.method_6();
			}

			// Token: 0x06000317 RID: 791 RVA: 0x0005D628 File Offset: 0x0005B828
			public Class2124 method_0()
			{
				return this.class2109_0.method_7(this.int_0);
			}

			// Token: 0x040001C6 RID: 454
			private int int_0;

			// Token: 0x040001C7 RID: 455
			private Class2109 class2109_0;
		}
	}
}
