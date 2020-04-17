using System;
using System.Collections;
using ns16;

namespace ns20
{
	// Token: 0x0200091D RID: 2333
	public sealed class Class2099 : Class2059
	{
		// Token: 0x06003951 RID: 14673 RVA: 0x0001E6F9 File Offset: 0x0001C8F9
		public Class2099()
		{
			this.method_10();
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x00121DD8 File Offset: 0x0011FFD8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Days");
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00121DF8 File Offset: 0x0011FFF8
		public Class2010 method_3(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Days", int_0)));
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00121E24 File Offset: 0x00120024
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Hours");
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00121E44 File Offset: 0x00120044
		public Class2018 method_5(int int_0)
		{
			return new Class2018(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Hours", int_0)));
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00121E70 File Offset: 0x00120070
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Mins");
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00121E90 File Offset: 0x00120090
		public Class2010 method_7(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Mins", int_0)));
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00121EBC File Offset: 0x001200BC
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Seconds");
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00121EDC File Offset: 0x001200DC
		public Class2010 method_9(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Seconds", int_0)));
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0001E733 File Offset: 0x0001C933
		private void method_10()
		{
			this.class1299_0.method_0(this);
			this.class1301_0.method_0(this);
			this.class1303_0.method_0(this);
			this.class1305_0.method_0(this);
		}

		// Token: 0x04001A48 RID: 6728
		public Class2099.Class1299 class1299_0 = new Class2099.Class1299();

		// Token: 0x04001A49 RID: 6729
		public Class2099.Class1301 class1301_0 = new Class2099.Class1301();

		// Token: 0x04001A4A RID: 6730
		public Class2099.Class1303 class1303_0 = new Class2099.Class1303();

		// Token: 0x04001A4B RID: 6731
		public Class2099.Class1305 class1305_0 = new Class2099.Class1305();

		// Token: 0x0200091E RID: 2334
		public sealed class Class1299 : IEnumerable
		{
			// Token: 0x0600395B RID: 14683 RVA: 0x0001E765 File Offset: 0x0001C965
			public void method_0(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
			}

			// Token: 0x0600395C RID: 14684 RVA: 0x00121F08 File Offset: 0x00120108
			public Class2099.Class1300 method_1()
			{
				return new Class2099.Class1300(this.class2099_0);
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x00121F24 File Offset: 0x00120124
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A4C RID: 6732
			private Class2099 class2099_0;
		}

		// Token: 0x0200091F RID: 2335
		public sealed class Class1300 : IEnumerator
		{
			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x0600395F RID: 14687 RVA: 0x00121F3C File Offset: 0x0012013C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003960 RID: 14688 RVA: 0x0001E76E File Offset: 0x0001C96E
			public Class1300(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
				this.int_0 = -1;
			}

			// Token: 0x06003961 RID: 14689 RVA: 0x0001E784 File Offset: 0x0001C984
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003962 RID: 14690 RVA: 0x0001E78D File Offset: 0x0001C98D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2099_0.method_2();
			}

			// Token: 0x06003963 RID: 14691 RVA: 0x00121F54 File Offset: 0x00120154
			public Class2010 method_0()
			{
				return this.class2099_0.method_3(this.int_0);
			}

			// Token: 0x04001A4D RID: 6733
			private int int_0;

			// Token: 0x04001A4E RID: 6734
			private Class2099 class2099_0;
		}

		// Token: 0x02000920 RID: 2336
		public sealed class Class1301 : IEnumerable
		{
			// Token: 0x06003964 RID: 14692 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
			public void method_0(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
			}

			// Token: 0x06003965 RID: 14693 RVA: 0x00121F74 File Offset: 0x00120174
			public Class2099.Class1302 method_1()
			{
				return new Class2099.Class1302(this.class2099_0);
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x00121F90 File Offset: 0x00120190
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A4F RID: 6735
			private Class2099 class2099_0;
		}

		// Token: 0x02000921 RID: 2337
		public sealed class Class1302 : IEnumerator
		{
			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06003968 RID: 14696 RVA: 0x00121FA8 File Offset: 0x001201A8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003969 RID: 14697 RVA: 0x0001E7B9 File Offset: 0x0001C9B9
			public Class1302(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
				this.int_0 = -1;
			}

			// Token: 0x0600396A RID: 14698 RVA: 0x0001E7CF File Offset: 0x0001C9CF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600396B RID: 14699 RVA: 0x0001E7D8 File Offset: 0x0001C9D8
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2099_0.method_4();
			}

			// Token: 0x0600396C RID: 14700 RVA: 0x00121FC0 File Offset: 0x001201C0
			public Class2018 method_0()
			{
				return this.class2099_0.method_5(this.int_0);
			}

			// Token: 0x04001A50 RID: 6736
			private int int_0;

			// Token: 0x04001A51 RID: 6737
			private Class2099 class2099_0;
		}

		// Token: 0x02000922 RID: 2338
		public sealed class Class1303 : IEnumerable
		{
			// Token: 0x0600396D RID: 14701 RVA: 0x0001E7FB File Offset: 0x0001C9FB
			public void method_0(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
			}

			// Token: 0x0600396E RID: 14702 RVA: 0x00121FE0 File Offset: 0x001201E0
			public Class2099.Class1304 method_1()
			{
				return new Class2099.Class1304(this.class2099_0);
			}

			// Token: 0x0600396F RID: 14703 RVA: 0x00121FFC File Offset: 0x001201FC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A52 RID: 6738
			private Class2099 class2099_0;
		}

		// Token: 0x02000923 RID: 2339
		public sealed class Class1304 : IEnumerator
		{
			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06003971 RID: 14705 RVA: 0x00122014 File Offset: 0x00120214
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003972 RID: 14706 RVA: 0x0001E804 File Offset: 0x0001CA04
			public Class1304(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
				this.int_0 = -1;
			}

			// Token: 0x06003973 RID: 14707 RVA: 0x0001E81A File Offset: 0x0001CA1A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003974 RID: 14708 RVA: 0x0001E823 File Offset: 0x0001CA23
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2099_0.method_6();
			}

			// Token: 0x06003975 RID: 14709 RVA: 0x0012202C File Offset: 0x0012022C
			public Class2010 method_0()
			{
				return this.class2099_0.method_7(this.int_0);
			}

			// Token: 0x04001A53 RID: 6739
			private int int_0;

			// Token: 0x04001A54 RID: 6740
			private Class2099 class2099_0;
		}

		// Token: 0x02000924 RID: 2340
		public sealed class Class1305 : IEnumerable
		{
			// Token: 0x06003976 RID: 14710 RVA: 0x0001E846 File Offset: 0x0001CA46
			public void method_0(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
			}

			// Token: 0x06003977 RID: 14711 RVA: 0x0012204C File Offset: 0x0012024C
			public Class2099.Class1306 method_1()
			{
				return new Class2099.Class1306(this.class2099_0);
			}

			// Token: 0x06003978 RID: 14712 RVA: 0x00122068 File Offset: 0x00120268
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001A55 RID: 6741
			private Class2099 class2099_0;
		}

		// Token: 0x02000925 RID: 2341
		public sealed class Class1306 : IEnumerator
		{
			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x0600397A RID: 14714 RVA: 0x00122080 File Offset: 0x00120280
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600397B RID: 14715 RVA: 0x0001E84F File Offset: 0x0001CA4F
			public Class1306(Class2099 class2099_1)
			{
				this.class2099_0 = class2099_1;
				this.int_0 = -1;
			}

			// Token: 0x0600397C RID: 14716 RVA: 0x0001E865 File Offset: 0x0001CA65
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600397D RID: 14717 RVA: 0x0001E86E File Offset: 0x0001CA6E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2099_0.method_8();
			}

			// Token: 0x0600397E RID: 14718 RVA: 0x00122098 File Offset: 0x00120298
			public Class2010 method_0()
			{
				return this.class2099_0.method_9(this.int_0);
			}

			// Token: 0x04001A56 RID: 6742
			private int int_0;

			// Token: 0x04001A57 RID: 6743
			private Class2099 class2099_0;
		}
	}
}
