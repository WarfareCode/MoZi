using System;
using System.Collections;
using System.Xml;
using ns16;

namespace ns20
{
	// Token: 0x02000869 RID: 2153
	public sealed class Class2090 : Class2059
	{
		// Token: 0x06003522 RID: 13602 RVA: 0x0001C714 File Offset: 0x0001A914
		public Class2090()
		{
			this.method_8();
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0001C743 File Offset: 0x0001A943
		public Class2090(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_8();
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x0011C664 File Offset: 0x0011A864
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationX");
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0011C684 File Offset: 0x0011A884
		public Class2020 method_3(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationX", int_0)));
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0011C6B0 File Offset: 0x0011A8B0
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationY");
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
		public Class2020 method_5(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationY", int_0)));
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0011C6FC File Offset: 0x0011A8FC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "RotationZ");
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0011C71C File Offset: 0x0011A91C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "RotationZ", int_0)));
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0001C773 File Offset: 0x0001A973
		private void method_8()
		{
			this.class1145_0.method_0(this);
			this.class1147_0.method_0(this);
			this.class1149_0.method_0(this);
		}

		// Token: 0x04001899 RID: 6297
		public Class2090.Class1145 class1145_0 = new Class2090.Class1145();

		// Token: 0x0400189A RID: 6298
		public Class2090.Class1147 class1147_0 = new Class2090.Class1147();

		// Token: 0x0400189B RID: 6299
		public Class2090.Class1149 class1149_0 = new Class2090.Class1149();

		// Token: 0x0200086A RID: 2154
		public sealed class Class1145 : IEnumerable
		{
			// Token: 0x0600352B RID: 13611 RVA: 0x0001C799 File Offset: 0x0001A999
			public void method_0(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
			}

			// Token: 0x0600352C RID: 13612 RVA: 0x0011C88C File Offset: 0x0011AA8C
			public Class2090.Class1146 method_1()
			{
				return new Class2090.Class1146(this.class2090_0);
			}

			// Token: 0x0600352D RID: 13613 RVA: 0x0011C8A8 File Offset: 0x0011AAA8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400189C RID: 6300
			private Class2090 class2090_0;
		}

		// Token: 0x0200086B RID: 2155
		public sealed class Class1146 : IEnumerator
		{
			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x0600352F RID: 13615 RVA: 0x0011C8C0 File Offset: 0x0011AAC0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003530 RID: 13616 RVA: 0x0001C7A2 File Offset: 0x0001A9A2
			public Class1146(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
				this.int_0 = -1;
			}

			// Token: 0x06003531 RID: 13617 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003532 RID: 13618 RVA: 0x0001C7C1 File Offset: 0x0001A9C1
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2090_0.method_2();
			}

			// Token: 0x06003533 RID: 13619 RVA: 0x0011C8D8 File Offset: 0x0011AAD8
			public Class2020 method_0()
			{
				return this.class2090_0.method_3(this.int_0);
			}

			// Token: 0x0400189D RID: 6301
			private int int_0;

			// Token: 0x0400189E RID: 6302
			private Class2090 class2090_0;
		}

		// Token: 0x0200086C RID: 2156
		public sealed class Class1147 : IEnumerable
		{
			// Token: 0x06003534 RID: 13620 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
			public void method_0(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
			}

			// Token: 0x06003535 RID: 13621 RVA: 0x0011C8F8 File Offset: 0x0011AAF8
			public Class2090.Class1148 method_1()
			{
				return new Class2090.Class1148(this.class2090_0);
			}

			// Token: 0x06003536 RID: 13622 RVA: 0x0011C914 File Offset: 0x0011AB14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400189F RID: 6303
			private Class2090 class2090_0;
		}

		// Token: 0x0200086D RID: 2157
		public sealed class Class1148 : IEnumerator
		{
			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06003538 RID: 13624 RVA: 0x0011C92C File Offset: 0x0011AB2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003539 RID: 13625 RVA: 0x0001C7ED File Offset: 0x0001A9ED
			public Class1148(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
				this.int_0 = -1;
			}

			// Token: 0x0600353A RID: 13626 RVA: 0x0001C803 File Offset: 0x0001AA03
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600353B RID: 13627 RVA: 0x0001C80C File Offset: 0x0001AA0C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2090_0.method_4();
			}

			// Token: 0x0600353C RID: 13628 RVA: 0x0011C944 File Offset: 0x0011AB44
			public Class2020 method_0()
			{
				return this.class2090_0.method_5(this.int_0);
			}

			// Token: 0x040018A0 RID: 6304
			private int int_0;

			// Token: 0x040018A1 RID: 6305
			private Class2090 class2090_0;
		}

		// Token: 0x0200086E RID: 2158
		public sealed class Class1149 : IEnumerable
		{
			// Token: 0x0600353D RID: 13629 RVA: 0x0001C82F File Offset: 0x0001AA2F
			public void method_0(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
			}

			// Token: 0x0600353E RID: 13630 RVA: 0x0011C964 File Offset: 0x0011AB64
			public Class2090.Class1150 method_1()
			{
				return new Class2090.Class1150(this.class2090_0);
			}

			// Token: 0x0600353F RID: 13631 RVA: 0x0011C980 File Offset: 0x0011AB80
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040018A2 RID: 6306
			private Class2090 class2090_0;
		}

		// Token: 0x0200086F RID: 2159
		public sealed class Class1150 : IEnumerator
		{
			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06003541 RID: 13633 RVA: 0x0011C998 File Offset: 0x0011AB98
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003542 RID: 13634 RVA: 0x0001C838 File Offset: 0x0001AA38
			public Class1150(Class2090 class2090_1)
			{
				this.class2090_0 = class2090_1;
				this.int_0 = -1;
			}

			// Token: 0x06003543 RID: 13635 RVA: 0x0001C84E File Offset: 0x0001AA4E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003544 RID: 13636 RVA: 0x0001C857 File Offset: 0x0001AA57
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2090_0.method_6();
			}

			// Token: 0x06003545 RID: 13637 RVA: 0x0011C9B0 File Offset: 0x0011ABB0
			public Class2020 method_0()
			{
				return this.class2090_0.method_7(this.int_0);
			}

			// Token: 0x040018A3 RID: 6307
			private int int_0;

			// Token: 0x040018A4 RID: 6308
			private Class2090 class2090_0;
		}
	}
}
