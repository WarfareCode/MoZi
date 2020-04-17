using System;
using System.Collections;
using System.Xml;
using ns16;
using ns21;

namespace ns20
{
	// Token: 0x020007C9 RID: 1993
	public sealed class Class2081 : Class2059
	{
		// Token: 0x0600315A RID: 12634 RVA: 0x0001A89C File Offset: 0x00018A9C
		public Class2081()
		{
			this.method_4();
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0001A8B5 File Offset: 0x00018AB5
		public Class2081(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x0010BCDC File Offset: 0x00109EDC
		public Class2045 method_3(int int_0)
		{
			return new Class2045(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0001A8CF File Offset: 0x00018ACF
		private void method_4()
		{
			this.class1049_0.method_0(this);
		}

		// Token: 0x040016EB RID: 5867
		public Class2081.Class1049 class1049_0 = new Class2081.Class1049();

		// Token: 0x020007CA RID: 1994
		public sealed class Class1049 : IEnumerable
		{
			// Token: 0x0600315F RID: 12639 RVA: 0x0001A8DD File Offset: 0x00018ADD
			public void method_0(Class2081 class2081_1)
			{
				this.class2081_0 = class2081_1;
			}

			// Token: 0x06003160 RID: 12640 RVA: 0x0010BD08 File Offset: 0x00109F08
			public Class2081.Class1050 method_1()
			{
				return new Class2081.Class1050(this.class2081_0);
			}

			// Token: 0x06003161 RID: 12641 RVA: 0x0010BD24 File Offset: 0x00109F24
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016EC RID: 5868
			private Class2081 class2081_0;
		}

		// Token: 0x020007CB RID: 1995
		public sealed class Class1050 : IEnumerator
		{
			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x0010BD3C File Offset: 0x00109F3C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003164 RID: 12644 RVA: 0x0001A8E6 File Offset: 0x00018AE6
			public Class1050(Class2081 class2081_1)
			{
				this.class2081_0 = class2081_1;
				this.int_0 = -1;
			}

			// Token: 0x06003165 RID: 12645 RVA: 0x0001A8FC File Offset: 0x00018AFC
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003166 RID: 12646 RVA: 0x0001A905 File Offset: 0x00018B05
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2081_0.method_2();
			}

			// Token: 0x06003167 RID: 12647 RVA: 0x0010BD54 File Offset: 0x00109F54
			public Class2045 method_0()
			{
				return this.class2081_0.method_3(this.int_0);
			}

			// Token: 0x040016ED RID: 5869
			private int int_0;

			// Token: 0x040016EE RID: 5870
			private Class2081 class2081_0;
		}
	}
}
