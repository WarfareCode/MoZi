using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns15
{
	// Token: 0x0200068C RID: 1676
	public sealed class Class2063 : Class2059
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000FED7C File Offset: 0x000FCF7C
		public Class2023 Value
		{
			get
			{
				return this.method_3(0);
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000173CE File Offset: 0x000155CE
		public Class2063()
		{
			this.method_4();
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000173E7 File Offset: 0x000155E7
		public Class2063(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000FE424 File Offset: 0x000FC624
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Value");
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000FED94 File Offset: 0x000FCF94
		public Class2023 method_3(int int_0)
		{
			return new Class2023(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Value", int_0)));
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00017401 File Offset: 0x00015601
		private void method_4()
		{
			this.class869_0.method_0(this);
		}

		// Token: 0x04001446 RID: 5190
		public Class2063.Class869 class869_0 = new Class2063.Class869();

		// Token: 0x0200068D RID: 1677
		public sealed class Class869 : IEnumerable
		{
			// Token: 0x06002A91 RID: 10897 RVA: 0x0001740F File Offset: 0x0001560F
			public void method_0(Class2063 class2063_1)
			{
				this.class2063_0 = class2063_1;
			}

			// Token: 0x06002A92 RID: 10898 RVA: 0x000FEDC0 File Offset: 0x000FCFC0
			public Class2063.Class870 method_1()
			{
				return new Class2063.Class870(this.class2063_0);
			}

			// Token: 0x06002A93 RID: 10899 RVA: 0x000FEDDC File Offset: 0x000FCFDC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001447 RID: 5191
			private Class2063 class2063_0;
		}

		// Token: 0x0200068E RID: 1678
		public sealed class Class870 : IEnumerator
		{
			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000FEDF4 File Offset: 0x000FCFF4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002A96 RID: 10902 RVA: 0x00017418 File Offset: 0x00015618
			public Class870(Class2063 class2063_1)
			{
				this.class2063_0 = class2063_1;
				this.int_0 = -1;
			}

			// Token: 0x06002A97 RID: 10903 RVA: 0x0001742E File Offset: 0x0001562E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002A98 RID: 10904 RVA: 0x00017437 File Offset: 0x00015637
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2063_0.method_2();
			}

			// Token: 0x06002A99 RID: 10905 RVA: 0x000FEE0C File Offset: 0x000FD00C
			public Class2023 method_0()
			{
				return this.class2063_0.method_3(this.int_0);
			}

			// Token: 0x04001448 RID: 5192
			private int int_0;

			// Token: 0x04001449 RID: 5193
			private Class2063 class2063_0;
		}
	}
}
