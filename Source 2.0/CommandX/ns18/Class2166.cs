using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns18
{
	// Token: 0x020002E7 RID: 743
	public sealed class Class2166 : Class2059
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x0000D242 File Offset: 0x0000B442
		public Class2166()
		{
			this.method_4();
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0000D25B File Offset: 0x0000B45B
		public Class2166(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00077954 File Offset: 0x00075B54
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "OnlineResource");
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00077974 File Offset: 0x00075B74
		public Class2165 method_3(int int_0)
		{
			return new Class2165(base.method_1(Class2059.Enum155.const_1, "", "OnlineResource", int_0));
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0000D275 File Offset: 0x0000B475
		private void method_4()
		{
			this.class1863_0.method_0(this);
		}

		// Token: 0x04000704 RID: 1796
		public Class2166.Class1863 class1863_0 = new Class2166.Class1863();

		// Token: 0x020002E8 RID: 744
		public sealed class Class1863 : IEnumerable
		{
			// Token: 0x06001160 RID: 4448 RVA: 0x0000D283 File Offset: 0x0000B483
			public void method_0(Class2166 class2166_1)
			{
				this.class2166_0 = class2166_1;
			}

			// Token: 0x06001161 RID: 4449 RVA: 0x0007FA2C File Offset: 0x0007DC2C
			public Class2166.Class1864 method_1()
			{
				return new Class2166.Class1864(this.class2166_0);
			}

			// Token: 0x06001162 RID: 4450 RVA: 0x0007FA48 File Offset: 0x0007DC48
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000705 RID: 1797
			private Class2166 class2166_0;
		}

		// Token: 0x020002E9 RID: 745
		public sealed class Class1864 : IEnumerator
		{
			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06001164 RID: 4452 RVA: 0x0007FA60 File Offset: 0x0007DC60
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06001165 RID: 4453 RVA: 0x0000D28C File Offset: 0x0000B48C
			public Class1864(Class2166 class2166_1)
			{
				this.class2166_0 = class2166_1;
				this.int_0 = -1;
			}

			// Token: 0x06001166 RID: 4454 RVA: 0x0000D2A2 File Offset: 0x0000B4A2
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06001167 RID: 4455 RVA: 0x0000D2AB File Offset: 0x0000B4AB
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2166_0.method_2();
			}

			// Token: 0x06001168 RID: 4456 RVA: 0x0007FA78 File Offset: 0x0007DC78
			public Class2165 method_0()
			{
				return this.class2166_0.method_3(this.int_0);
			}

			// Token: 0x04000706 RID: 1798
			private int int_0;

			// Token: 0x04000707 RID: 1799
			private Class2166 class2166_0;
		}
	}
}
