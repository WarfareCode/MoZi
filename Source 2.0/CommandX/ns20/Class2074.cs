using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000741 RID: 1857
	public sealed class Class2074 : Class2059
	{
		// Token: 0x06002E27 RID: 11815 RVA: 0x000191E0 File Offset: 0x000173E0
		public Class2074()
		{
			this.method_6();
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00019204 File Offset: 0x00017404
		public Class2074(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_6();
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x0007D178 File Offset: 0x0007B378
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Abstract");
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x0007D198 File Offset: 0x0007B398
		public Class2050 method_3(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Abstract", int_0)));
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00105384 File Offset: 0x00103584
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ToolBarImage");
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x001053A4 File Offset: 0x001035A4
		public Class2050 method_5(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ToolBarImage", int_0)));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00019229 File Offset: 0x00017429
		private void method_6()
		{
			this.class955_0.method_0(this);
			this.class957_0.method_0(this);
		}

		// Token: 0x04001584 RID: 5508
		public Class2074.Class955 class955_0 = new Class2074.Class955();

		// Token: 0x04001585 RID: 5509
		public Class2074.Class957 class957_0 = new Class2074.Class957();

		// Token: 0x02000742 RID: 1858
		public sealed class Class955 : IEnumerable
		{
			// Token: 0x06002E2E RID: 11822 RVA: 0x00019243 File Offset: 0x00017443
			public void method_0(Class2074 class2074_1)
			{
				this.class2074_0 = class2074_1;
			}

			// Token: 0x06002E2F RID: 11823 RVA: 0x001053D0 File Offset: 0x001035D0
			public Class2074.Class956 method_1()
			{
				return new Class2074.Class956(this.class2074_0);
			}

			// Token: 0x06002E30 RID: 11824 RVA: 0x001053EC File Offset: 0x001035EC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001586 RID: 5510
			private Class2074 class2074_0;
		}

		// Token: 0x02000743 RID: 1859
		public sealed class Class956 : IEnumerator
		{
			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00105404 File Offset: 0x00103604
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x0001924C File Offset: 0x0001744C
			public Class956(Class2074 class2074_1)
			{
				this.class2074_0 = class2074_1;
				this.int_0 = -1;
			}

			// Token: 0x06002E34 RID: 11828 RVA: 0x00019262 File Offset: 0x00017462
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002E35 RID: 11829 RVA: 0x0001926B File Offset: 0x0001746B
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2074_0.method_2();
			}

			// Token: 0x06002E36 RID: 11830 RVA: 0x0010541C File Offset: 0x0010361C
			public Class2050 method_0()
			{
				return this.class2074_0.method_3(this.int_0);
			}

			// Token: 0x04001587 RID: 5511
			private int int_0;

			// Token: 0x04001588 RID: 5512
			private Class2074 class2074_0;
		}

		// Token: 0x02000744 RID: 1860
		public sealed class Class957 : IEnumerable
		{
			// Token: 0x06002E37 RID: 11831 RVA: 0x0001928E File Offset: 0x0001748E
			public void method_0(Class2074 class2074_1)
			{
				this.class2074_0 = class2074_1;
			}

			// Token: 0x06002E38 RID: 11832 RVA: 0x0010543C File Offset: 0x0010363C
			public Class2074.Class958 method_1()
			{
				return new Class2074.Class958(this.class2074_0);
			}

			// Token: 0x06002E39 RID: 11833 RVA: 0x00105458 File Offset: 0x00103658
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001589 RID: 5513
			private Class2074 class2074_0;
		}

		// Token: 0x02000745 RID: 1861
		public sealed class Class958 : IEnumerator
		{
			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00105470 File Offset: 0x00103670
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002E3C RID: 11836 RVA: 0x00019297 File Offset: 0x00017497
			public Class958(Class2074 class2074_1)
			{
				this.class2074_0 = class2074_1;
				this.int_0 = -1;
			}

			// Token: 0x06002E3D RID: 11837 RVA: 0x000192AD File Offset: 0x000174AD
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002E3E RID: 11838 RVA: 0x000192B6 File Offset: 0x000174B6
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2074_0.method_4();
			}

			// Token: 0x06002E3F RID: 11839 RVA: 0x00105488 File Offset: 0x00103688
			public Class2050 method_0()
			{
				return this.class2074_0.method_5(this.int_0);
			}

			// Token: 0x0400158A RID: 5514
			private int int_0;

			// Token: 0x0400158B RID: 5515
			private Class2074 class2074_0;
		}
	}
}
