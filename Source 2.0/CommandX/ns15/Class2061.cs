using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns15
{
	// Token: 0x02000678 RID: 1656
	public sealed class Class2061 : Class2059
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000FE40C File Offset: 0x000FC60C
		public Class2022 Value
		{
			get
			{
				return this.method_3(0);
			}
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00017060 File Offset: 0x00015260
		public Class2061()
		{
			this.method_4();
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00017079 File Offset: 0x00015279
		public Class2061(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000FE444 File Offset: 0x000FC644
		public Class2022 method_3(int int_0)
		{
			return new Class2022(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00017093 File Offset: 0x00015293
		private void method_4()
		{
			this.class859_0.method_0(this);
		}

		// Token: 0x04001424 RID: 5156
		public Class2061.Class859 class859_0 = new Class2061.Class859();

		// Token: 0x02000679 RID: 1657
		public sealed class Class859 : IEnumerable
		{
			// Token: 0x06002A2D RID: 10797 RVA: 0x000170A1 File Offset: 0x000152A1
			public void method_0(Class2061 class2061_1)
			{
				this.class2061_0 = class2061_1;
			}

			// Token: 0x06002A2E RID: 10798 RVA: 0x000FE470 File Offset: 0x000FC670
			public Class2061.Class860 method_1()
			{
				return new Class2061.Class860(this.class2061_0);
			}

			// Token: 0x06002A2F RID: 10799 RVA: 0x000FE48C File Offset: 0x000FC68C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001425 RID: 5157
			private Class2061 class2061_0;
		}

		// Token: 0x0200067A RID: 1658
		public sealed class Class860 : IEnumerator
		{
			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000FE4A4 File Offset: 0x000FC6A4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A32 RID: 10802 RVA: 0x000170AA File Offset: 0x000152AA
			public Class860(Class2061 class2061_1)
			{
				this.class2061_0 = class2061_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A33 RID: 10803 RVA: 0x000170C0 File Offset: 0x000152C0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A34 RID: 10804 RVA: 0x000170C9 File Offset: 0x000152C9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2061_0.method_2();
			}

			// Token: 0x06002A35 RID: 10805 RVA: 0x000FE4BC File Offset: 0x000FC6BC
			public Class2022 method_0()
			{
				return this.class2061_0.method_3(this.int_0);
			}

			// Token: 0x04001426 RID: 5158
			private int int_0;

			// Token: 0x04001427 RID: 5159
			private Class2061 class2061_0;
		}
	}
}
