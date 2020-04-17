using System;
using System.Collections;
using System.Xml;
using ns16;
using ns17;
using ns21;

namespace ns20
{
	// Token: 0x0200077C RID: 1916
	public sealed class Class2076 : Class2059
	{
		// Token: 0x06002F50 RID: 12112 RVA: 0x001074B8 File Offset: 0x001056B8
		public Class2076()
		{
			this.method_18();
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x0010752C File Offset: 0x0010572C
		public Class2076(XmlNode xmlNode_1) : base(xmlNode_1)
		{
			this.method_18();
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000FFFF8 File Offset: 0x000FE1F8
		public int method_2()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "LevelZeroTileSizeDegrees");
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x001075A0 File Offset: 0x001057A0
		public Class2028 method_3(int int_0)
		{
			return new Class2028(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "LevelZeroTileSizeDegrees", int_0)));
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00100044 File Offset: 0x000FE244
		public int method_4()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "NumberLevels");
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00100064 File Offset: 0x000FE264
		public Class2010 method_5(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "NumberLevels", int_0)));
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x001075CC File Offset: 0x001057CC
		public int method_6()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "TextureSizePixels");
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x001075EC File Offset: 0x001057EC
		public Class2010 method_7(int int_0)
		{
			return new Class2010(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "TextureSizePixels", int_0)));
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00107618 File Offset: 0x00105818
		public int method_8()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageFileExtension");
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00107638 File Offset: 0x00105838
		public Class2050 method_9(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "ImageFileExtension", int_0)));
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00107664 File Offset: 0x00105864
		public int method_10()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "PermanantDirectory");
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00107684 File Offset: 0x00105884
		public Class2050 method_11(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "PermanantDirectory", int_0)));
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x001076B0 File Offset: 0x001058B0
		public int method_12()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "DuplicateTilePath");
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x001076D0 File Offset: 0x001058D0
		public Class2050 method_13(int int_0)
		{
			return new Class2050(Class2059.smethod_0(base.method_1(Class2059.Enum155.const_1, "", "DuplicateTilePath", int_0)));
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x001076FC File Offset: 0x001058FC
		public int method_14()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "WMSAccessor");
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x0010771C File Offset: 0x0010591C
		public Class2105 method_15(int int_0)
		{
			return new Class2105(base.method_1(Class2059.Enum155.const_1, "", "WMSAccessor", int_0));
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00107744 File Offset: 0x00105944
		public int method_16()
		{
			return base.method_0(Class2059.Enum155.const_1, "", "ImageTileService");
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00107764 File Offset: 0x00105964
		public Class2079 method_17(int int_0)
		{
			return new Class2079(base.method_1(Class2059.Enum155.const_1, "", "ImageTileService", int_0));
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0010778C File Offset: 0x0010598C
		private void method_18()
		{
			this.class993_0.method_0(this);
			this.class995_0.method_0(this);
			this.class997_0.method_0(this);
			this.class999_0.method_0(this);
			this.class1001_0.method_0(this);
			this.class1003_0.method_0(this);
			this.class1005_0.method_0(this);
			this.class1007_0.method_0(this);
		}

		// Token: 0x040015F3 RID: 5619
		public Class2076.Class993 class993_0 = new Class2076.Class993();

		// Token: 0x040015F4 RID: 5620
		public Class2076.Class995 class995_0 = new Class2076.Class995();

		// Token: 0x040015F5 RID: 5621
		public Class2076.Class997 class997_0 = new Class2076.Class997();

		// Token: 0x040015F6 RID: 5622
		public Class2076.Class999 class999_0 = new Class2076.Class999();

		// Token: 0x040015F7 RID: 5623
		public Class2076.Class1001 class1001_0 = new Class2076.Class1001();

		// Token: 0x040015F8 RID: 5624
		public Class2076.Class1003 class1003_0 = new Class2076.Class1003();

		// Token: 0x040015F9 RID: 5625
		public Class2076.Class1005 class1005_0 = new Class2076.Class1005();

		// Token: 0x040015FA RID: 5626
		public Class2076.Class1007 class1007_0 = new Class2076.Class1007();

		// Token: 0x0200077D RID: 1917
		public sealed class Class993 : IEnumerable
		{
			// Token: 0x06002F63 RID: 12131 RVA: 0x00019A44 File Offset: 0x00017C44
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x001077FC File Offset: 0x001059FC
			public Class2076.Class994 method_1()
			{
				return new Class2076.Class994(this.class2076_0);
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x00107818 File Offset: 0x00105A18
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015FB RID: 5627
			private Class2076 class2076_0;
		}

		// Token: 0x0200077E RID: 1918
		public sealed class Class994 : IEnumerator
		{
			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06002F67 RID: 12135 RVA: 0x00107830 File Offset: 0x00105A30
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x00019A4D File Offset: 0x00017C4D
			public Class994(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x00019A63 File Offset: 0x00017C63
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x00019A6C File Offset: 0x00017C6C
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_2();
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x00107848 File Offset: 0x00105A48
			public Class2028 method_0()
			{
				return this.class2076_0.method_3(this.int_0);
			}

			// Token: 0x040015FC RID: 5628
			private int int_0;

			// Token: 0x040015FD RID: 5629
			private Class2076 class2076_0;
		}

		// Token: 0x0200077F RID: 1919
		public sealed class Class995 : IEnumerable
		{
			// Token: 0x06002F6C RID: 12140 RVA: 0x00019A8F File Offset: 0x00017C8F
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F6D RID: 12141 RVA: 0x00107868 File Offset: 0x00105A68
			public Class2076.Class996 method_1()
			{
				return new Class2076.Class996(this.class2076_0);
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x00107884 File Offset: 0x00105A84
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x040015FE RID: 5630
			private Class2076 class2076_0;
		}

		// Token: 0x02000780 RID: 1920
		public sealed class Class996 : IEnumerator
		{
			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0010789C File Offset: 0x00105A9C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F71 RID: 12145 RVA: 0x00019A98 File Offset: 0x00017C98
			public Class996(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F72 RID: 12146 RVA: 0x00019AAE File Offset: 0x00017CAE
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x00019AB7 File Offset: 0x00017CB7
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_4();
			}

			// Token: 0x06002F74 RID: 12148 RVA: 0x001078B4 File Offset: 0x00105AB4
			public Class2010 method_0()
			{
				return this.class2076_0.method_5(this.int_0);
			}

			// Token: 0x040015FF RID: 5631
			private int int_0;

			// Token: 0x04001600 RID: 5632
			private Class2076 class2076_0;
		}

		// Token: 0x02000781 RID: 1921
		public sealed class Class997 : IEnumerable
		{
			// Token: 0x06002F75 RID: 12149 RVA: 0x00019ADA File Offset: 0x00017CDA
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F76 RID: 12150 RVA: 0x001078D4 File Offset: 0x00105AD4
			public Class2076.Class998 method_1()
			{
				return new Class2076.Class998(this.class2076_0);
			}

			// Token: 0x06002F77 RID: 12151 RVA: 0x001078F0 File Offset: 0x00105AF0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001601 RID: 5633
			private Class2076 class2076_0;
		}

		// Token: 0x02000782 RID: 1922
		public sealed class Class998 : IEnumerator
		{
			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00107908 File Offset: 0x00105B08
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F7A RID: 12154 RVA: 0x00019AE3 File Offset: 0x00017CE3
			public Class998(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F7B RID: 12155 RVA: 0x00019AF9 File Offset: 0x00017CF9
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F7C RID: 12156 RVA: 0x00019B02 File Offset: 0x00017D02
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_6();
			}

			// Token: 0x06002F7D RID: 12157 RVA: 0x00107920 File Offset: 0x00105B20
			public Class2010 method_0()
			{
				return this.class2076_0.method_7(this.int_0);
			}

			// Token: 0x04001602 RID: 5634
			private int int_0;

			// Token: 0x04001603 RID: 5635
			private Class2076 class2076_0;
		}

		// Token: 0x02000783 RID: 1923
		public sealed class Class999 : IEnumerable
		{
			// Token: 0x06002F7E RID: 12158 RVA: 0x00019B25 File Offset: 0x00017D25
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F7F RID: 12159 RVA: 0x00107940 File Offset: 0x00105B40
			public Class2076.Class1000 method_1()
			{
				return new Class2076.Class1000(this.class2076_0);
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x0010795C File Offset: 0x00105B5C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001604 RID: 5636
			private Class2076 class2076_0;
		}

		// Token: 0x02000784 RID: 1924
		public sealed class Class1000 : IEnumerator
		{
			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06002F82 RID: 12162 RVA: 0x00107974 File Offset: 0x00105B74
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F83 RID: 12163 RVA: 0x00019B2E File Offset: 0x00017D2E
			public Class1000(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F84 RID: 12164 RVA: 0x00019B44 File Offset: 0x00017D44
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F85 RID: 12165 RVA: 0x00019B4D File Offset: 0x00017D4D
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_8();
			}

			// Token: 0x06002F86 RID: 12166 RVA: 0x0010798C File Offset: 0x00105B8C
			public Class2050 method_0()
			{
				return this.class2076_0.method_9(this.int_0);
			}

			// Token: 0x04001605 RID: 5637
			private int int_0;

			// Token: 0x04001606 RID: 5638
			private Class2076 class2076_0;
		}

		// Token: 0x02000785 RID: 1925
		public sealed class Class1001 : IEnumerable
		{
			// Token: 0x06002F87 RID: 12167 RVA: 0x00019B70 File Offset: 0x00017D70
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F88 RID: 12168 RVA: 0x001079AC File Offset: 0x00105BAC
			public Class2076.Class1002 method_1()
			{
				return new Class2076.Class1002(this.class2076_0);
			}

			// Token: 0x06002F89 RID: 12169 RVA: 0x001079C8 File Offset: 0x00105BC8
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001607 RID: 5639
			private Class2076 class2076_0;
		}

		// Token: 0x02000786 RID: 1926
		public sealed class Class1002 : IEnumerator
		{
			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06002F8B RID: 12171 RVA: 0x001079E0 File Offset: 0x00105BE0
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F8C RID: 12172 RVA: 0x00019B79 File Offset: 0x00017D79
			public Class1002(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F8D RID: 12173 RVA: 0x00019B8F File Offset: 0x00017D8F
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F8E RID: 12174 RVA: 0x00019B98 File Offset: 0x00017D98
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_10();
			}

			// Token: 0x06002F8F RID: 12175 RVA: 0x001079F8 File Offset: 0x00105BF8
			public Class2050 method_0()
			{
				return this.class2076_0.method_11(this.int_0);
			}

			// Token: 0x04001608 RID: 5640
			private int int_0;

			// Token: 0x04001609 RID: 5641
			private Class2076 class2076_0;
		}

		// Token: 0x02000787 RID: 1927
		public sealed class Class1003 : IEnumerable
		{
			// Token: 0x06002F90 RID: 12176 RVA: 0x00019BBB File Offset: 0x00017DBB
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x00107A18 File Offset: 0x00105C18
			public Class2076.Class1004 method_1()
			{
				return new Class2076.Class1004(this.class2076_0);
			}

			// Token: 0x06002F92 RID: 12178 RVA: 0x00107A34 File Offset: 0x00105C34
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400160A RID: 5642
			private Class2076 class2076_0;
		}

		// Token: 0x02000788 RID: 1928
		public sealed class Class1004 : IEnumerator
		{
			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06002F94 RID: 12180 RVA: 0x00107A4C File Offset: 0x00105C4C
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F95 RID: 12181 RVA: 0x00019BC4 File Offset: 0x00017DC4
			public Class1004(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F96 RID: 12182 RVA: 0x00019BDA File Offset: 0x00017DDA
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002F97 RID: 12183 RVA: 0x00019BE3 File Offset: 0x00017DE3
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_12();
			}

			// Token: 0x06002F98 RID: 12184 RVA: 0x00107A64 File Offset: 0x00105C64
			public Class2050 method_0()
			{
				return this.class2076_0.method_13(this.int_0);
			}

			// Token: 0x0400160B RID: 5643
			private int int_0;

			// Token: 0x0400160C RID: 5644
			private Class2076 class2076_0;
		}

		// Token: 0x02000789 RID: 1929
		public sealed class Class1005 : IEnumerable
		{
			// Token: 0x06002F99 RID: 12185 RVA: 0x00019C06 File Offset: 0x00017E06
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x00107A84 File Offset: 0x00105C84
			public Class2076.Class1006 method_1()
			{
				return new Class2076.Class1006(this.class2076_0);
			}

			// Token: 0x06002F9B RID: 12187 RVA: 0x00107AA0 File Offset: 0x00105CA0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x0400160D RID: 5645
			private Class2076 class2076_0;
		}

		// Token: 0x0200078A RID: 1930
		public sealed class Class1006 : IEnumerator
		{
			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06002F9D RID: 12189 RVA: 0x00107AB8 File Offset: 0x00105CB8
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002F9E RID: 12190 RVA: 0x00019C0F File Offset: 0x00017E0F
			public Class1006(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x00019C25 File Offset: 0x00017E25
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x00019C2E File Offset: 0x00017E2E
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_14();
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x00107AD0 File Offset: 0x00105CD0
			public Class2105 method_0()
			{
				return this.class2076_0.method_15(this.int_0);
			}

			// Token: 0x0400160E RID: 5646
			private int int_0;

			// Token: 0x0400160F RID: 5647
			private Class2076 class2076_0;
		}

		// Token: 0x0200078B RID: 1931
		public sealed class Class1007 : IEnumerable
		{
			// Token: 0x06002FA2 RID: 12194 RVA: 0x00019C51 File Offset: 0x00017E51
			public void method_0(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
			}

			// Token: 0x06002FA3 RID: 12195 RVA: 0x00107AF0 File Offset: 0x00105CF0
			public Class2076.Class1008 method_1()
			{
				return new Class2076.Class1008(this.class2076_0);
			}

			// Token: 0x06002FA4 RID: 12196 RVA: 0x00107B0C File Offset: 0x00105D0C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.method_1();
			}

			// Token: 0x04001610 RID: 5648
			private Class2076 class2076_0;
		}

		// Token: 0x0200078C RID: 1932
		public sealed class Class1008 : IEnumerator
		{
			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x00107B24 File Offset: 0x00105D24
			object IEnumerator.Current
			{
				get
				{
					return this.method_0();
				}
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x00019C5A File Offset: 0x00017E5A
			public Class1008(Class2076 class2076_1)
			{
				this.class2076_0 = class2076_1;
				this.int_0 = -1;
			}

			// Token: 0x06002FA8 RID: 12200 RVA: 0x00019C70 File Offset: 0x00017E70
			public void Reset()
			{
				this.int_0 = -1;
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x00019C79 File Offset: 0x00017E79
			public bool MoveNext()
			{
				this.int_0++;
				return this.int_0 < this.class2076_0.method_16();
			}

			// Token: 0x06002FAA RID: 12202 RVA: 0x00107B3C File Offset: 0x00105D3C
			public Class2079 method_0()
			{
				return this.class2076_0.method_17(this.int_0);
			}

			// Token: 0x04001611 RID: 5649
			private int int_0;

			// Token: 0x04001612 RID: 5650
			private Class2076 class2076_0;
		}
	}
}
