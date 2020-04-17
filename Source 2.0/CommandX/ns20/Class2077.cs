using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;

namespace ns20
{
	// Token: 0x0200079A RID: 1946
	public sealed class Class2077 : Class2059
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x0010A4E4 File Offset: 0x001086E4
		public Class2077()
		{
			this.method_24();
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0010A578 File Offset: 0x00108778
		public Class2077(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_24();
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00106590 File Offset: 0x00104790
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_0, "", "ShowAtStartup");
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x001065B0 File Offset: 0x001047B0
		public Class2009 method_3(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_0, "", "ShowAtStartup", int_0)));
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0007D12C File Offset: 0x0007B32C
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Name");
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0010A60C File Offset: 0x0010880C
		public Class2053 method_5(int int_0)
		{
			return new Class2053(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Name", int_0)));
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0010666C File Offset: 0x0010486C
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DistanceAboveSurface");
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0010668C File Offset: 0x0010488C
		public Class2020 method_7(int int_0)
		{
			return new Class2020(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DistanceAboveSurface", int_0)));
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0007D2A0 File Offset: 0x0007B4A0
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "BoundingBox");
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0010A638 File Offset: 0x00108838
		public Class2083 method_9(int int_0)
		{
			return new Class2083(base.method_1(Class2059.Enum155.const_1, "", "BoundingBox", int_0));
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0010A660 File Offset: 0x00108860
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TexturePath");
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0010A680 File Offset: 0x00108880
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TexturePath", int_0)));
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0010A6AC File Offset: 0x001088AC
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "Opacity");
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0010A6CC File Offset: 0x001088CC
		public Class2015 method_13(int int_0)
		{
			return new Class2015(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "Opacity", int_0)));
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0010A6F8 File Offset: 0x001088F8
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TerrainMapped");
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0010A718 File Offset: 0x00108918
		public Class2009 method_15(int int_0)
		{
			return new Class2009(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TerrainMapped", int_0)));
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0010A744 File Offset: 0x00108944
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TransparencyColor");
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x0010A764 File Offset: 0x00108964
		public Class2096 method_17(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "TransparencyColor", int_0));
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0010A78C File Offset: 0x0010898C
		public int method_18()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LegendImagePath");
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x0010A7AC File Offset: 0x001089AC
		public Class2050 method_19(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "LegendImagePath", int_0)));
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x001069A8 File Offset: 0x00104BA8
		public int method_20()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ExtendedInformation");
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x001069C8 File Offset: 0x00104BC8
		public Class2074 method_21(int int_0)
		{
			return new Class2074(base.method_1(Class2059.Enum155.const_1, "", "ExtendedInformation", int_0));
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0010A7D8 File Offset: 0x001089D8
		public int method_22()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TransparentColor");
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x0010A7F8 File Offset: 0x001089F8
		public Class2096 method_23(int int_0)
		{
			return new Class2096(base.method_1(Class2059.Enum155.const_1, "", "TransparentColor", int_0));
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0010A820 File Offset: 0x00108A20
		private void method_24()
		{
			this.class1009_0.method_0(this);
			this.class1011_0.method_0(this);
			this.class1013_0.method_0(this);
			this.class1015_0.method_0(this);
			this.class1017_0.method_0(this);
			this.class1019_0.method_0(this);
			this.class1021_0.method_0(this);
			this.class1023_0.method_0(this);
			this.class1025_0.method_0(this);
			this.class1027_0.method_0(this);
			this.class1029_0.method_0(this);
		}

		// Token: 0x0400167D RID: 5757
		public Class2077.Class1009 class1009_0 = new Class2077.Class1009();

		// Token: 0x0400167E RID: 5758
		public Class2077.Class1011 class1011_0 = new Class2077.Class1011();

		// Token: 0x0400167F RID: 5759
		public Class2077.Class1013 class1013_0 = new Class2077.Class1013();

		// Token: 0x04001680 RID: 5760
		public Class2077.Class1015 class1015_0 = new Class2077.Class1015();

		// Token: 0x04001681 RID: 5761
		public Class2077.Class1017 class1017_0 = new Class2077.Class1017();

		// Token: 0x04001682 RID: 5762
		public Class2077.Class1019 class1019_0 = new Class2077.Class1019();

		// Token: 0x04001683 RID: 5763
		public Class2077.Class1021 class1021_0 = new Class2077.Class1021();

		// Token: 0x04001684 RID: 5764
		public Class2077.Class1023 class1023_0 = new Class2077.Class1023();

		// Token: 0x04001685 RID: 5765
		public Class2077.Class1025 class1025_0 = new Class2077.Class1025();

		// Token: 0x04001686 RID: 5766
		public Class2077.Class1027 class1027_0 = new Class2077.Class1027();

		// Token: 0x04001687 RID: 5767
		public Class2077.Class1029 class1029_0 = new Class2077.Class1029();

		// Token: 0x0200079B RID: 1947
		public sealed class Class1009 : IEnumerable
		{
			// Token: 0x06003056 RID: 12374 RVA: 0x00019EFF File Offset: 0x000180FF
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003057 RID: 12375 RVA: 0x0010A8B4 File Offset: 0x00108AB4
			public Class2077.Class1010 method_1()
			{
				return new Class2077.Class1010(this.class2077_0);
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x0010A8D0 File Offset: 0x00108AD0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001688 RID: 5768
			private Class2077 class2077_0;
		}

		// Token: 0x0200079C RID: 1948
		public sealed class Class1010 : IEnumerator
		{
			// Token: 0x17000342 RID: 834
			// (get) Token: 0x0600305A RID: 12378 RVA: 0x0010A8E8 File Offset: 0x00108AE8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600305B RID: 12379 RVA: 0x00019F08 File Offset: 0x00018108
			public Class1010(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x0600305C RID: 12380 RVA: 0x00019F1E File Offset: 0x0001811E
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600305D RID: 12381 RVA: 0x00019F27 File Offset: 0x00018127
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_2();
			}

			// Token: 0x0600305E RID: 12382 RVA: 0x0010A900 File Offset: 0x00108B00
			public Class2009 method_0()
			{
				return this.class2077_0.method_3(this.int_0);
			}

			// Token: 0x04001689 RID: 5769
			private int int_0;

			// Token: 0x0400168A RID: 5770
			private Class2077 class2077_0;
		}

		// Token: 0x0200079D RID: 1949
		public sealed class Class1011 : IEnumerable
		{
			// Token: 0x0600305F RID: 12383 RVA: 0x00019F4A File Offset: 0x0001814A
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003060 RID: 12384 RVA: 0x0010A920 File Offset: 0x00108B20
			public Class2077.Class1012 method_1()
			{
				return new Class2077.Class1012(this.class2077_0);
			}

			// Token: 0x06003061 RID: 12385 RVA: 0x0010A93C File Offset: 0x00108B3C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400168B RID: 5771
			private Class2077 class2077_0;
		}

		// Token: 0x0200079E RID: 1950
		public sealed class Class1012 : IEnumerator
		{
			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06003063 RID: 12387 RVA: 0x0010A954 File Offset: 0x00108B54
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003064 RID: 12388 RVA: 0x00019F53 File Offset: 0x00018153
			public Class1012(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x06003065 RID: 12389 RVA: 0x00019F69 File Offset: 0x00018169
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003066 RID: 12390 RVA: 0x00019F72 File Offset: 0x00018172
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_4();
			}

			// Token: 0x06003067 RID: 12391 RVA: 0x0010A96C File Offset: 0x00108B6C
			public Class2053 method_0()
			{
				return this.class2077_0.method_5(this.int_0);
			}

			// Token: 0x0400168C RID: 5772
			private int int_0;

			// Token: 0x0400168D RID: 5773
			private Class2077 class2077_0;
		}

		// Token: 0x0200079F RID: 1951
		public sealed class Class1013 : IEnumerable
		{
			// Token: 0x06003068 RID: 12392 RVA: 0x00019F95 File Offset: 0x00018195
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003069 RID: 12393 RVA: 0x0010A98C File Offset: 0x00108B8C
			public Class2077.Class1014 method_1()
			{
				return new Class2077.Class1014(this.class2077_0);
			}

			// Token: 0x0600306A RID: 12394 RVA: 0x0010A9A8 File Offset: 0x00108BA8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400168E RID: 5774
			private Class2077 class2077_0;
		}

		// Token: 0x020007A0 RID: 1952
		public sealed class Class1014 : IEnumerator
		{
			// Token: 0x17000344 RID: 836
			// (get) Token: 0x0600306C RID: 12396 RVA: 0x0010A9C0 File Offset: 0x00108BC0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600306D RID: 12397 RVA: 0x00019F9E File Offset: 0x0001819E
			public Class1014(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x0600306E RID: 12398 RVA: 0x00019FB4 File Offset: 0x000181B4
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600306F RID: 12399 RVA: 0x00019FBD File Offset: 0x000181BD
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_6();
			}

			// Token: 0x06003070 RID: 12400 RVA: 0x0010A9D8 File Offset: 0x00108BD8
			public Class2020 method_0()
			{
				return this.class2077_0.method_7(this.int_0);
			}

			// Token: 0x0400168F RID: 5775
			private int int_0;

			// Token: 0x04001690 RID: 5776
			private Class2077 class2077_0;
		}

		// Token: 0x020007A1 RID: 1953
		public sealed class Class1015 : IEnumerable
		{
			// Token: 0x06003071 RID: 12401 RVA: 0x00019FE0 File Offset: 0x000181E0
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003072 RID: 12402 RVA: 0x0010A9F8 File Offset: 0x00108BF8
			public Class2077.Class1016 method_1()
			{
				return new Class2077.Class1016(this.class2077_0);
			}

			// Token: 0x06003073 RID: 12403 RVA: 0x0010AA14 File Offset: 0x00108C14
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001691 RID: 5777
			private Class2077 class2077_0;
		}

		// Token: 0x020007A2 RID: 1954
		public sealed class Class1016 : IEnumerator
		{
			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06003075 RID: 12405 RVA: 0x0010AA2C File Offset: 0x00108C2C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003076 RID: 12406 RVA: 0x00019FE9 File Offset: 0x000181E9
			public Class1016(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x06003077 RID: 12407 RVA: 0x00019FFF File Offset: 0x000181FF
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003078 RID: 12408 RVA: 0x0001A008 File Offset: 0x00018208
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_8();
			}

			// Token: 0x06003079 RID: 12409 RVA: 0x0010AA44 File Offset: 0x00108C44
			public Class2083 method_0()
			{
				return this.class2077_0.method_9(this.int_0);
			}

			// Token: 0x04001692 RID: 5778
			private int int_0;

			// Token: 0x04001693 RID: 5779
			private Class2077 class2077_0;
		}

		// Token: 0x020007A3 RID: 1955
		public sealed class Class1017 : IEnumerable
		{
			// Token: 0x0600307A RID: 12410 RVA: 0x0001A02B File Offset: 0x0001822B
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x0600307B RID: 12411 RVA: 0x0010AA64 File Offset: 0x00108C64
			public Class2077.Class1018 method_1()
			{
				return new Class2077.Class1018(this.class2077_0);
			}

			// Token: 0x0600307C RID: 12412 RVA: 0x0010AA80 File Offset: 0x00108C80
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001694 RID: 5780
			private Class2077 class2077_0;
		}

		// Token: 0x020007A4 RID: 1956
		public sealed class Class1018 : IEnumerator
		{
			// Token: 0x17000346 RID: 838
			// (get) Token: 0x0600307E RID: 12414 RVA: 0x0010AA98 File Offset: 0x00108C98
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600307F RID: 12415 RVA: 0x0001A034 File Offset: 0x00018234
			public Class1018(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x06003080 RID: 12416 RVA: 0x0001A04A File Offset: 0x0001824A
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003081 RID: 12417 RVA: 0x0001A053 File Offset: 0x00018253
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_10();
			}

			// Token: 0x06003082 RID: 12418 RVA: 0x0010AAB0 File Offset: 0x00108CB0
			public Class2050 method_0()
			{
				return this.class2077_0.method_11(this.int_0);
			}

			// Token: 0x04001695 RID: 5781
			private int int_0;

			// Token: 0x04001696 RID: 5782
			private Class2077 class2077_0;
		}

		// Token: 0x020007A5 RID: 1957
		public sealed class Class1019 : IEnumerable
		{
			// Token: 0x06003083 RID: 12419 RVA: 0x0001A076 File Offset: 0x00018276
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x0010AAD0 File Offset: 0x00108CD0
			public Class2077.Class1020 method_1()
			{
				return new Class2077.Class1020(this.class2077_0);
			}

			// Token: 0x06003085 RID: 12421 RVA: 0x0010AAEC File Offset: 0x00108CEC
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001697 RID: 5783
			private Class2077 class2077_0;
		}

		// Token: 0x020007A6 RID: 1958
		public sealed class Class1020 : IEnumerator
		{
			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06003087 RID: 12423 RVA: 0x0010AB04 File Offset: 0x00108D04
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003088 RID: 12424 RVA: 0x0001A07F File Offset: 0x0001827F
			public Class1020(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x06003089 RID: 12425 RVA: 0x0001A095 File Offset: 0x00018295
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600308A RID: 12426 RVA: 0x0001A09E File Offset: 0x0001829E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_12();
			}

			// Token: 0x0600308B RID: 12427 RVA: 0x0010AB1C File Offset: 0x00108D1C
			public Class2015 method_0()
			{
				return this.class2077_0.method_13(this.int_0);
			}

			// Token: 0x04001698 RID: 5784
			private int int_0;

			// Token: 0x04001699 RID: 5785
			private Class2077 class2077_0;
		}

		// Token: 0x020007A7 RID: 1959
		public sealed class Class1021 : IEnumerable
		{
			// Token: 0x0600308C RID: 12428 RVA: 0x0001A0C1 File Offset: 0x000182C1
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x0600308D RID: 12429 RVA: 0x0010AB3C File Offset: 0x00108D3C
			public Class2077.Class1022 method_1()
			{
				return new Class2077.Class1022(this.class2077_0);
			}

			// Token: 0x0600308E RID: 12430 RVA: 0x0010AB58 File Offset: 0x00108D58
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400169A RID: 5786
			private Class2077 class2077_0;
		}

		// Token: 0x020007A8 RID: 1960
		public sealed class Class1022 : IEnumerator
		{
			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06003090 RID: 12432 RVA: 0x0010AB70 File Offset: 0x00108D70
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06003091 RID: 12433 RVA: 0x0001A0CA File Offset: 0x000182CA
			public Class1022(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x06003092 RID: 12434 RVA: 0x0001A0E0 File Offset: 0x000182E0
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06003093 RID: 12435 RVA: 0x0001A0E9 File Offset: 0x000182E9
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_14();
			}

			// Token: 0x06003094 RID: 12436 RVA: 0x0010AB88 File Offset: 0x00108D88
			public Class2009 method_0()
			{
				return this.class2077_0.method_15(this.int_0);
			}

			// Token: 0x0400169B RID: 5787
			private int int_0;

			// Token: 0x0400169C RID: 5788
			private Class2077 class2077_0;
		}

		// Token: 0x020007A9 RID: 1961
		public sealed class Class1023 : IEnumerable
		{
			// Token: 0x06003095 RID: 12437 RVA: 0x0001A10C File Offset: 0x0001830C
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x06003096 RID: 12438 RVA: 0x0010ABA8 File Offset: 0x00108DA8
			public Class2077.Class1024 method_1()
			{
				return new Class2077.Class1024(this.class2077_0);
			}

			// Token: 0x06003097 RID: 12439 RVA: 0x0010ABC4 File Offset: 0x00108DC4
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400169D RID: 5789
			private Class2077 class2077_0;
		}

		// Token: 0x020007AA RID: 1962
		public sealed class Class1024 : IEnumerator
		{
			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06003099 RID: 12441 RVA: 0x0010ABDC File Offset: 0x00108DDC
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x0600309A RID: 12442 RVA: 0x0001A115 File Offset: 0x00018315
			public Class1024(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x0600309B RID: 12443 RVA: 0x0001A12B File Offset: 0x0001832B
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x0600309C RID: 12444 RVA: 0x0001A134 File Offset: 0x00018334
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_16();
			}

			// Token: 0x0600309D RID: 12445 RVA: 0x0010ABF4 File Offset: 0x00108DF4
			public Class2096 method_0()
			{
				return this.class2077_0.method_17(this.int_0);
			}

			// Token: 0x0400169E RID: 5790
			private int int_0;

			// Token: 0x0400169F RID: 5791
			private Class2077 class2077_0;
		}

		// Token: 0x020007AB RID: 1963
		public sealed class Class1025 : IEnumerable
		{
			// Token: 0x0600309E RID: 12446 RVA: 0x0001A157 File Offset: 0x00018357
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x0600309F RID: 12447 RVA: 0x0010AC14 File Offset: 0x00108E14
			public Class2077.Class1026 method_1()
			{
				return new Class2077.Class1026(this.class2077_0);
			}

			// Token: 0x060030A0 RID: 12448 RVA: 0x0010AC30 File Offset: 0x00108E30
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016A0 RID: 5792
			private Class2077 class2077_0;
		}

		// Token: 0x020007AC RID: 1964
		public sealed class Class1026 : IEnumerator
		{
			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060030A2 RID: 12450 RVA: 0x0010AC48 File Offset: 0x00108E48
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030A3 RID: 12451 RVA: 0x0001A160 File Offset: 0x00018360
			public Class1026(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x060030A4 RID: 12452 RVA: 0x0001A176 File Offset: 0x00018376
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030A5 RID: 12453 RVA: 0x0001A17F File Offset: 0x0001837F
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_18();
			}

			// Token: 0x060030A6 RID: 12454 RVA: 0x0010AC60 File Offset: 0x00108E60
			public Class2050 method_0()
			{
				return this.class2077_0.method_19(this.int_0);
			}

			// Token: 0x040016A1 RID: 5793
			private int int_0;

			// Token: 0x040016A2 RID: 5794
			private Class2077 class2077_0;
		}

		// Token: 0x020007AD RID: 1965
		public sealed class Class1027 : IEnumerable
		{
			// Token: 0x060030A7 RID: 12455 RVA: 0x0001A1A2 File Offset: 0x000183A2
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x060030A8 RID: 12456 RVA: 0x0010AC80 File Offset: 0x00108E80
			public Class2077.Class1028 method_1()
			{
				return new Class2077.Class1028(this.class2077_0);
			}

			// Token: 0x060030A9 RID: 12457 RVA: 0x0010AC9C File Offset: 0x00108E9C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016A3 RID: 5795
			private Class2077 class2077_0;
		}

		// Token: 0x020007AE RID: 1966
		public sealed class Class1028 : IEnumerator
		{
			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060030AB RID: 12459 RVA: 0x0010ACB4 File Offset: 0x00108EB4
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030AC RID: 12460 RVA: 0x0001A1AB File Offset: 0x000183AB
			public Class1028(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x060030AD RID: 12461 RVA: 0x0001A1C1 File Offset: 0x000183C1
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030AE RID: 12462 RVA: 0x0001A1CA File Offset: 0x000183CA
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_20();
			}

			// Token: 0x060030AF RID: 12463 RVA: 0x0010ACCC File Offset: 0x00108ECC
			public Class2074 method_0()
			{
				return this.class2077_0.method_21(this.int_0);
			}

			// Token: 0x040016A4 RID: 5796
			private int int_0;

			// Token: 0x040016A5 RID: 5797
			private Class2077 class2077_0;
		}

		// Token: 0x020007AF RID: 1967
		public sealed class Class1029 : IEnumerable
		{
			// Token: 0x060030B0 RID: 12464 RVA: 0x0001A1ED File Offset: 0x000183ED
			public void method_0(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
			}

			// Token: 0x060030B1 RID: 12465 RVA: 0x0010ACEC File Offset: 0x00108EEC
			public Class2077.Class1030 method_1()
			{
				return new Class2077.Class1030(this.class2077_0);
			}

			// Token: 0x060030B2 RID: 12466 RVA: 0x0010AD08 File Offset: 0x00108F08
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040016A6 RID: 5798
			private Class2077 class2077_0;
		}

		// Token: 0x020007B0 RID: 1968
		public sealed class Class1030 : IEnumerator
		{
			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060030B4 RID: 12468 RVA: 0x0010AD20 File Offset: 0x00108F20
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x060030B5 RID: 12469 RVA: 0x0001A1F6 File Offset: 0x000183F6
			public Class1030(Class2077 class2077_1)
			{
				this.class2077_0 = class2077_1;
				this.int_0 = -1;
			}

			// Token: 0x060030B6 RID: 12470 RVA: 0x0001A20C File Offset: 0x0001840C
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x060030B7 RID: 12471 RVA: 0x0001A215 File Offset: 0x00018415
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2077_0.method_22();
			}

			// Token: 0x060030B8 RID: 12472 RVA: 0x0010AD38 File Offset: 0x00108F38
			public Class2096 method_0()
			{
				return this.class2077_0.method_23(this.int_0);
			}

			// Token: 0x040016A7 RID: 5799
			private int int_0;

			// Token: 0x040016A8 RID: 5800
			private Class2077 class2077_0;
		}
	}
}
