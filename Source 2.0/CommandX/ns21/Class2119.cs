using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns21
{
	// Token: 0x020000E7 RID: 231
	public sealed class Class2119 : Class2059
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00006B78 File Offset: 0x00004D78
		public Class2119()
		{
			this.method_4();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00006B91 File Offset: 0x00004D91
		public Class2119(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_4();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0005B2F0 File Offset: 0x000594F0
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource");
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0005B310 File Offset: 0x00059510
		public Class2128 method_3(int int_0)
		{
			return new Class2128(base.method_1(Class2059.Enum155.const_1, "http://www.opengis.net/wms", "OnlineResource", int_0));
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00006BAB File Offset: 0x00004DAB
		private void method_4()
		{
			this.class1501_0.method_0(this);
		}

		// Token: 0x04000256 RID: 598
		public Class2119.Class1501 class1501_0 = new Class2119.Class1501();

		// Token: 0x020000E8 RID: 232
		public sealed class Class1501 : IEnumerable
		{
			// Token: 0x060004E9 RID: 1257 RVA: 0x00006BB9 File Offset: 0x00004DB9
			public void method_0(Class2119 class2119_1)
			{
				this.class2119_0 = class2119_1;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00065684 File Offset: 0x00063884
			public Class2119.Class1502 method_1()
			{
				return new Class2119.Class1502(this.class2119_0);
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x000656A0 File Offset: 0x000638A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04000257 RID: 599
			private Class2119 class2119_0;
		}

		// Token: 0x020000E9 RID: 233
		public sealed class Class1502 : IEnumerator
		{
			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x000656B8 File Offset: 0x000638B8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x00006BC2 File Offset: 0x00004DC2
			public Class1502(Class2119 class2119_1)
			{
				this.class2119_0 = class2119_1;
				this.int_0 = -1;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00006BD8 File Offset: 0x00004DD8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x00006BE1 File Offset: 0x00004DE1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2119_0.method_2();
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x000656D0 File Offset: 0x000638D0
			public Class2128 method_0()
			{
				return this.class2119_0.method_3(this.int_0);
			}

			// Token: 0x04000258 RID: 600
			private int int_0;

			// Token: 0x04000259 RID: 601
			private Class2119 class2119_0;
		}
	}
}
