using System;
using System.Collections;
using System.Xml;
using ns16;
using ns22;

namespace ns18
{
	// Token: 0x020002F3 RID: 755
	public sealed class Class2168 : Class2059
	{
		// Token: 0x060011A4 RID: 4516 RVA: 0x00081098 File Offset: 0x0007F298
		public Class2168()
		{
			this.method_16();
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00081100 File Offset: 0x0007F300
		public Class2168(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_16();
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00081168 File Offset: 0x0007F368
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "GetCapabilities");
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00081188 File Offset: 0x0007F388
		public Class2151 method_3(int int_0)
		{
			return new Class2151(base.method_1(Class2059.Enum155.const_1, "", "GetCapabilities", int_0));
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000811B0 File Offset: 0x0007F3B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "GetMap");
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000811D0 File Offset: 0x0007F3D0
		public Class2154 method_5(int int_0)
		{
			return new Class2154(base.method_1(Class2059.Enum155.const_1, "", "GetMap", int_0));
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000811F8 File Offset: 0x0007F3F8
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "GetFeatureInfo");
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00081218 File Offset: 0x0007F418
		public Class2152 method_7(int int_0)
		{
			return new Class2152(base.method_1(Class2059.Enum155.const_1, "", "GetFeatureInfo", int_0));
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00081240 File Offset: 0x0007F440
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DescribeLayer");
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00081260 File Offset: 0x0007F460
		public Class2146 method_9(int int_0)
		{
			return new Class2146(base.method_1(Class2059.Enum155.const_1, "", "DescribeLayer", int_0));
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00081288 File Offset: 0x0007F488
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "GetLegendGraphic");
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000812A8 File Offset: 0x0007F4A8
		public Class2153 method_11(int int_0)
		{
			return new Class2153(base.method_1(Class2059.Enum155.const_1, "", "GetLegendGraphic", int_0));
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x000812D0 File Offset: 0x0007F4D0
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "GetStyles");
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x000812F0 File Offset: 0x0007F4F0
		public Class2155 method_13(int int_0)
		{
			return new Class2155(base.method_1(Class2059.Enum155.const_1, "", "GetStyles", int_0));
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00081318 File Offset: 0x0007F518
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PutStyles");
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00081338 File Offset: 0x0007F538
		public Class2167 method_15(int int_0)
		{
			return new Class2167(base.method_1(Class2059.Enum155.const_1, "", "PutStyles", int_0));
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00081360 File Offset: 0x0007F560
		private void method_16()
		{
			this.class1869_0.method_0(this);
			this.class1871_0.method_0(this);
			this.class1873_0.method_0(this);
			this.class1875_0.method_0(this);
			this.class1877_0.method_0(this);
			this.class1879_0.method_0(this);
			this.class1881_0.method_0(this);
		}

		// Token: 0x04000746 RID: 1862
		public Class2168.Class1869 class1869_0 = new Class2168.Class1869();

		// Token: 0x04000747 RID: 1863
		public Class2168.Class1871 class1871_0 = new Class2168.Class1871();

		// Token: 0x04000748 RID: 1864
		public Class2168.Class1873 class1873_0 = new Class2168.Class1873();

		// Token: 0x04000749 RID: 1865
		public Class2168.Class1875 class1875_0 = new Class2168.Class1875();

		// Token: 0x0400074A RID: 1866
		public Class2168.Class1877 class1877_0 = new Class2168.Class1877();

		// Token: 0x0400074B RID: 1867
		public Class2168.Class1879 class1879_0 = new Class2168.Class1879();

		// Token: 0x0400074C RID: 1868
		public Class2168.Class1881 class1881_0 = new Class2168.Class1881();

		// Token: 0x020002F4 RID: 756
		public sealed class Class1869 : IEnumerable
		{
			// Token: 0x060011B5 RID: 4533 RVA: 0x0000D427 File Offset: 0x0000B627
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011B6 RID: 4534 RVA: 0x000813C4 File Offset: 0x0007F5C4
			public Class2168.Class1870 method_1()
			{
				return new Class2168.Class1870(this.class2168_0);
			}

			// Token: 0x060011B7 RID: 4535 RVA: 0x000813E0 File Offset: 0x0007F5E0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400074D RID: 1869
			private Class2168 class2168_0;
		}

		// Token: 0x020002F5 RID: 757
		public sealed class Class1870 : IEnumerator
		{
			// Token: 0x1700018B RID: 395
			// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000813F8 File Offset: 0x0007F5F8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011BA RID: 4538 RVA: 0x0000D430 File Offset: 0x0000B630
			public Class1870(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011BB RID: 4539 RVA: 0x0000D446 File Offset: 0x0000B646
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011BC RID: 4540 RVA: 0x0000D44F File Offset: 0x0000B64F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_2();
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x00081410 File Offset: 0x0007F610
			public Class2151 method_0()
			{
				return this.class2168_0.method_3(this.int_0);
			}

			// Token: 0x0400074E RID: 1870
			private int int_0;

			// Token: 0x0400074F RID: 1871
			private Class2168 class2168_0;
		}

		// Token: 0x020002F6 RID: 758
		public sealed class Class1871 : IEnumerable
		{
			// Token: 0x060011BE RID: 4542 RVA: 0x0000D472 File Offset: 0x0000B672
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x00081430 File Offset: 0x0007F630
			public Class2168.Class1872 method_1()
			{
				return new Class2168.Class1872(this.class2168_0);
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x0008144C File Offset: 0x0007F64C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000750 RID: 1872
			private Class2168 class2168_0;
		}

		// Token: 0x020002F7 RID: 759
		public sealed class Class1872 : IEnumerator
		{
			// Token: 0x1700018C RID: 396
			// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00081464 File Offset: 0x0007F664
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011C3 RID: 4547 RVA: 0x0000D47B File Offset: 0x0000B67B
			public Class1872(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011C4 RID: 4548 RVA: 0x0000D491 File Offset: 0x0000B691
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011C5 RID: 4549 RVA: 0x0000D49A File Offset: 0x0000B69A
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_4();
			}

			// Token: 0x060011C6 RID: 4550 RVA: 0x0008147C File Offset: 0x0007F67C
			public Class2154 method_0()
			{
				return this.class2168_0.method_5(this.int_0);
			}

			// Token: 0x04000751 RID: 1873
			private int int_0;

			// Token: 0x04000752 RID: 1874
			private Class2168 class2168_0;
		}

		// Token: 0x020002F8 RID: 760
		public sealed class Class1873 : IEnumerable
		{
			// Token: 0x060011C7 RID: 4551 RVA: 0x0000D4BD File Offset: 0x0000B6BD
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011C8 RID: 4552 RVA: 0x0008149C File Offset: 0x0007F69C
			public Class2168.Class1874 method_1()
			{
				return new Class2168.Class1874(this.class2168_0);
			}

			// Token: 0x060011C9 RID: 4553 RVA: 0x000814B8 File Offset: 0x0007F6B8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000753 RID: 1875
			private Class2168 class2168_0;
		}

		// Token: 0x020002F9 RID: 761
		public sealed class Class1874 : IEnumerator
		{
			// Token: 0x1700018D RID: 397
			// (get) Token: 0x060011CB RID: 4555 RVA: 0x000814D0 File Offset: 0x0007F6D0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011CC RID: 4556 RVA: 0x0000D4C6 File Offset: 0x0000B6C6
			public Class1874(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011CD RID: 4557 RVA: 0x0000D4DC File Offset: 0x0000B6DC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011CE RID: 4558 RVA: 0x0000D4E5 File Offset: 0x0000B6E5
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_6();
			}

			// Token: 0x060011CF RID: 4559 RVA: 0x000814E8 File Offset: 0x0007F6E8
			public Class2152 method_0()
			{
				return this.class2168_0.method_7(this.int_0);
			}

			// Token: 0x04000754 RID: 1876
			private int int_0;

			// Token: 0x04000755 RID: 1877
			private Class2168 class2168_0;
		}

		// Token: 0x020002FA RID: 762
		public sealed class Class1875 : IEnumerable
		{
			// Token: 0x060011D0 RID: 4560 RVA: 0x0000D508 File Offset: 0x0000B708
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011D1 RID: 4561 RVA: 0x00081508 File Offset: 0x0007F708
			public Class2168.Class1876 method_1()
			{
				return new Class2168.Class1876(this.class2168_0);
			}

			// Token: 0x060011D2 RID: 4562 RVA: 0x00081524 File Offset: 0x0007F724
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000756 RID: 1878
			private Class2168 class2168_0;
		}

		// Token: 0x020002FB RID: 763
		public sealed class Class1876 : IEnumerator
		{
			// Token: 0x1700018E RID: 398
			// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0008153C File Offset: 0x0007F73C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011D5 RID: 4565 RVA: 0x0000D511 File Offset: 0x0000B711
			public Class1876(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011D6 RID: 4566 RVA: 0x0000D527 File Offset: 0x0000B727
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011D7 RID: 4567 RVA: 0x0000D530 File Offset: 0x0000B730
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_8();
			}

			// Token: 0x060011D8 RID: 4568 RVA: 0x00081554 File Offset: 0x0007F754
			public Class2146 method_0()
			{
				return this.class2168_0.method_9(this.int_0);
			}

			// Token: 0x04000757 RID: 1879
			private int int_0;

			// Token: 0x04000758 RID: 1880
			private Class2168 class2168_0;
		}

		// Token: 0x020002FC RID: 764
		public sealed class Class1877 : IEnumerable
		{
			// Token: 0x060011D9 RID: 4569 RVA: 0x0000D553 File Offset: 0x0000B753
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011DA RID: 4570 RVA: 0x00081574 File Offset: 0x0007F774
			public Class2168.Class1878 method_1()
			{
				return new Class2168.Class1878(this.class2168_0);
			}

			// Token: 0x060011DB RID: 4571 RVA: 0x00081590 File Offset: 0x0007F790
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000759 RID: 1881
			private Class2168 class2168_0;
		}

		// Token: 0x020002FD RID: 765
		public sealed class Class1878 : IEnumerator
		{
			// Token: 0x1700018F RID: 399
			// (get) Token: 0x060011DD RID: 4573 RVA: 0x000815A8 File Offset: 0x0007F7A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011DE RID: 4574 RVA: 0x0000D55C File Offset: 0x0000B75C
			public Class1878(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x0000D572 File Offset: 0x0000B772
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011E0 RID: 4576 RVA: 0x0000D57B File Offset: 0x0000B77B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_10();
			}

			// Token: 0x060011E1 RID: 4577 RVA: 0x000815C0 File Offset: 0x0007F7C0
			public Class2153 method_0()
			{
				return this.class2168_0.method_11(this.int_0);
			}

			// Token: 0x0400075A RID: 1882
			private int int_0;

			// Token: 0x0400075B RID: 1883
			private Class2168 class2168_0;
		}

		// Token: 0x020002FE RID: 766
		public sealed class Class1879 : IEnumerable
		{
			// Token: 0x060011E2 RID: 4578 RVA: 0x0000D59E File Offset: 0x0000B79E
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011E3 RID: 4579 RVA: 0x000815E0 File Offset: 0x0007F7E0
			public Class2168.Class1880 method_1()
			{
				return new Class2168.Class1880(this.class2168_0);
			}

			// Token: 0x060011E4 RID: 4580 RVA: 0x000815FC File Offset: 0x0007F7FC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400075C RID: 1884
			private Class2168 class2168_0;
		}

		// Token: 0x020002FF RID: 767
		public sealed class Class1880 : IEnumerator
		{
			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00081614 File Offset: 0x0007F814
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011E7 RID: 4583 RVA: 0x0000D5A7 File Offset: 0x0000B7A7
			public Class1880(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011E8 RID: 4584 RVA: 0x0000D5BD File Offset: 0x0000B7BD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011E9 RID: 4585 RVA: 0x0000D5C6 File Offset: 0x0000B7C6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_12();
			}

			// Token: 0x060011EA RID: 4586 RVA: 0x0008162C File Offset: 0x0007F82C
			public Class2155 method_0()
			{
				return this.class2168_0.method_13(this.int_0);
			}

			// Token: 0x0400075D RID: 1885
			private int int_0;

			// Token: 0x0400075E RID: 1886
			private Class2168 class2168_0;
		}

		// Token: 0x02000300 RID: 768
		public sealed class Class1881 : IEnumerable
		{
			// Token: 0x060011EB RID: 4587 RVA: 0x0000D5E9 File Offset: 0x0000B7E9
			public void method_0(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
			}

			// Token: 0x060011EC RID: 4588 RVA: 0x0008164C File Offset: 0x0007F84C
			public Class2168.Class1882 method_1()
			{
				return new Class2168.Class1882(this.class2168_0);
			}

			// Token: 0x060011ED RID: 4589 RVA: 0x00081668 File Offset: 0x0007F868
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400075F RID: 1887
			private Class2168 class2168_0;
		}

		// Token: 0x02000301 RID: 769
		public sealed class Class1882 : IEnumerator
		{
			// Token: 0x17000191 RID: 401
			// (get) Token: 0x060011EF RID: 4591 RVA: 0x00081680 File Offset: 0x0007F880
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060011F0 RID: 4592 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
			public Class1882(Class2168 class2168_1)
			{
				this.class2168_0 = class2168_1;
				this.int_0 = -1;
			}

			// Token: 0x060011F1 RID: 4593 RVA: 0x0000D608 File Offset: 0x0000B808
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060011F2 RID: 4594 RVA: 0x0000D611 File Offset: 0x0000B811
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2168_0.method_14();
			}

			// Token: 0x060011F3 RID: 4595 RVA: 0x00081698 File Offset: 0x0007F898
			public Class2167 method_0()
			{
				return this.class2168_0.method_15(this.int_0);
			}

			// Token: 0x04000760 RID: 1888
			private int int_0;

			// Token: 0x04000761 RID: 1889
			private Class2168 class2168_0;
		}
	}
}
